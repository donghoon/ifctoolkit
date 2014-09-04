using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using BlackBox.Service;
using EbInstanceModel;
using IFC2X3;


namespace BlackBox.Predefined
{
    public class BbHeaderSetting : BbBase
    {

        public static BbHeaderSetting Setting3D;

        public BbPosition3D DefaultBbPosition3D;

        public BbCoordinate3D DefaultOrigin;

        public BbDirection3D RefDirection;
        public BbDirection3D Axis;
        public BbDirection3D XAxis;
        public BbDirection3D YAxis;
        public BbDirection3D ZAxis;
        public BbDirection3D XAxisMinus;
        public BbDirection3D YAxisMinus;
        public BbDirection3D ZAxisMinus;


        public BbCoordinate2D Origin2D;

        public BbDirection2D XAxis2D;
        public BbDirection2D RefDirection2D;
        public BbDirection2D YAxis2D;
        public BbDirection2D XAxisMinus2D;
        public BbDirection2D YAxisMinus2D;

        public BbPosition2D Position2D;


        public string Author
        {
            get
            {
                if (IfcOwnerHistory != null &&
                    IfcOwnerHistory.OwningUser != null &&
                    IfcOwnerHistory.OwningUser.ThePerson != null)
                    return IfcOwnerHistory.OwningUser.ThePerson.FamilyName;

                return null;
            }
        }


        //[BbAttributeRetrieve]
        public string Company
        {
            get
            {
                if (IfcOwnerHistory != null &&
                    IfcOwnerHistory.OwningUser != null &&
                    IfcOwnerHistory.OwningUser.TheOrganization != null)
                    return IfcOwnerHistory.OwningUser.TheOrganization.Name;
                return null;
            }
        }

        public string SoftwareName
        {
            get
            {
                if (IfcOwnerHistory != null &&
                    IfcOwnerHistory.OwningApplication != null &&
                    IfcOwnerHistory.OwningApplication.ApplicationFullName != null)
                    return IfcOwnerHistory.OwningApplication.ApplicationFullName;
                return null;
            }
        }

        public string SoftwareVersion
        {
            get
            {
                if (IfcOwnerHistory != null &&
                    IfcOwnerHistory.OwningApplication != null &&
                    IfcOwnerHistory.OwningApplication.Version != null)
                    return IfcOwnerHistory.OwningApplication.Version;
                return null;
            }
        }

        public string SoftwareCompany
        {
            get
            {
                if (IfcOwnerHistory != null &&
                    IfcOwnerHistory.OwningApplication != null &&
                    IfcOwnerHistory.OwningApplication.ApplicationDeveloper != null)
                    return IfcOwnerHistory.OwningApplication.ApplicationDeveloper.Name;
                return null;
            }
        }

        private BbUnit _bbUnit;


        public BbUnit ModelBbUnit
        { get { return _bbUnit; } }

        [EarlyBindingInstance]
        public IfcOwnerHistory IfcOwnerHistory { get; set; }

        [EarlyBindingInstance]
        public IfcUnitAssignment IfcUnitAssignment { get; set; }

        [EarlyBindingInstance]
        public IfcGeometricRepresentationContext GeometricRepresentationContext { get; set; }

        public static BbHeaderSetting Create(string authorName,
            string authorCompany,
            string softwareName,
            string softwareVersion,
            string softwareCompany,
            BbUnit bbUnitBase)
        {
            var headerSetting = new BbHeaderSetting(authorName,
             authorCompany,
             softwareName,
             softwareVersion,
             softwareCompany,
             bbUnitBase);

            BbInstanceDB.AddToExport(headerSetting);



            return headerSetting;
        }


        BbHeaderSetting(
            string authorName,
            string authorCompany,
            string softwareName,
            string softwareVersion,
            string softwareCompany,
            BbUnit bbUnitBase
            )
        //            : this()
        {
            SetCreator(authorName, authorCompany, softwareName, softwareVersion, softwareCompany);
            SetUnit(bbUnitBase);
            SetContext();

            Setting3D = this;
        }



        /// <summary>
        /// retrieve BbHeaderSetting from Early Binding Instance Model
        /// </summary>
        /// <param name="model">instance of model</param>
        /// <returns>Sem Header Setting instance</returns>
        public static BbHeaderSetting Retrieve()
        {
            ////    if (!EarlyBindingInstanceModel.TheModel.DataByType.ContainsKey("IfcOwnerHistory")) return null;

            //    var ownerList = EarlyBindingInstanceModel.GetDataByType("IfcOwnerHistory").Values;

            //    if (ownerList.Count != 1) throw new NotImplementedException();
            //    Setting3D = new BbHeaderSetting();
            //    foreach (var owner in ownerList.Select(p21Instance => p21Instance as IfcOwnerHistory))
            //    {
            //        Setting3D.RetrieveCreator(owner);
            //        break;
            //    }

            //    //if (!EarlyBindingInstanceModel.TheModel.DataByType.ContainsKey("IfcUnitAssignment")) return null;
            //    var unitAssignList = EarlyBindingInstanceModel.GetDataByType("IfcUnitAssignment").Values;
            //    if (unitAssignList.Count != 1) throw new NotImplementedException();
            //    foreach (var unitAssign in unitAssignList.Select(p21Instance => p21Instance as IfcUnitAssignment))
            //    {
            //        Setting3D.RetrieveUnit(unitAssign);
            //        break;
            //    }


            //   // if (!EarlyBindingInstanceModel.TheModel.DataByType.ContainsKey("IfcGeometricRepresentationContext")) return null;
            //    var geoRepList = EarlyBindingInstanceModel.GetDataByType("IfcGeometricRepresentationContext").Values;
            //    if (geoRepList.Count != 1) throw new NotImplementedException();
            //    foreach (var geoRep in geoRepList.Select(p21Instance => p21Instance as IfcGeometricRepresentationContext))
            //    {
            //        Setting3D.RetrieveContext(geoRep);
            //        break;
            //    }

            //    BbInstanceDB.AddToImport(Setting3D);
            return Setting3D;
        }





        #region OwnerHistory



        /// <summary>
        /// 
        /// </summary>
        /// <param name="authorName"></param>
        /// <param name="authorCompany"></param>
        /// <param name="softwareName"></param>
        /// <param name="softwareVersion"></param>
        /// <param name="softwareCompany"></param>
        public void SetCreator(
            string authorName,
            string authorCompany,
            string softwareName,
            string softwareVersion,
            string softwareCompany)
        {


            var person = new IfcPerson
            {
                GivenName = authorName,
                FamilyName = authorName
            };
            var organization = new IfcOrganization(authorCompany);

            var personAndOrganization = new IfcPersonAndOrganization(person, organization);

            var appOrganization = new IfcOrganization(softwareCompany);

            var application = new IfcApplication
            {
                ApplicationDeveloper = appOrganization,
                Version = softwareVersion,
                ApplicationFullName = softwareName,
                ApplicationIdentifier = softwareCompany + @"." + softwareName,
            };
            IfcOwnerHistory = new IfcOwnerHistory()
            {
                OwningUser = personAndOrganization,
                OwningApplication = application,
                State = IfcStateEnum.READONLY,
                ChangeAction = IfcChangeActionEnum.NOCHANGE,
                CreationDate = IfcTimeStamp.GetTimeStamp(),
            };


        }



        public void RetrieveCreator(IfcOwnerHistory ifcOwnerHistory)
        {
            IfcOwnerHistory = ifcOwnerHistory;
        }



        #endregion

        #region unitassignment



        public void RetrieveUnit(IfcUnitAssignment ifcUnitAssignment)
        {
            IfcUnitAssignment = ifcUnitAssignment;
            _bbUnit = BbUnit.Imperial;
            foreach (var unit in IfcUnitAssignment.Units)
            {
                if (!(unit.Value is IfcSIUnit)) continue;
                var si = unit.Value as IfcSIUnit;
                if (si.UnitType == IfcUnitEnum.LENGTHUNIT
                    && si.Name == IfcSIUnitName.METRE)
                    _bbUnit = BbUnit.Metric;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bbUnitBase"></param>
        public void SetUnit(
             BbUnit bbUnitBase)
        {
            _bbUnit = bbUnitBase;
            IfcUnitAssignment = new IfcUnitAssignment { Units = new List<IfcUnit>() };
            switch (_bbUnit)
            {
                case BbUnit.Metric:
                    #region metric

                    IfcUnitAssignment.Units.Add(
                        new IfcUnit
                        {
                            Value = new IfcSIUnit(
                                IfcUnitEnum.LENGTHUNIT, IfcSIPrefix.MILLI, IfcSIUnitName.METRE)
                        });
                    IfcUnitAssignment.Units.Add(
                        new IfcUnit
                        {
                            Value = new IfcSIUnit(
                                IfcUnitEnum.AREAUNIT, IfcSIUnitName.SQUARE_METRE)
                        });
                    IfcUnitAssignment.Units.Add(
                        new IfcUnit
                        {
                            Value = new IfcSIUnit(
                                IfcUnitEnum.VOLUMEUNIT, IfcSIUnitName.CUBIC_METRE)
                        });

                    #endregion
                    break;
                case BbUnit.Imperial:
                    #region imperial
                    var leng = new IfcConversionBasedUnit
                    {
                        Dimensions = new IfcDimensionalExponents
                        {
                            LengthExponent = 1,
                            MassExponent = 0,
                            TimeExponent = 0,
                            ElectricCurrentExponent = 0,
                            ThermodynamicTemperatureExponent = 0,
                            AmountOfSubstanceExponent = 0,
                            LuminousIntensityExponent = 0,
                        },
                        UnitType = IfcUnitEnum.LENGTHUNIT,
                        Name = "FOOT",
                        ConversionFactor = new IfcMeasureWithUnit
                        {
                            ValueComponent = new IfcValue
                            {
                                Value = new IfcRatioMeasure { Value = 0.3048 }
                            },
                            UnitComponent = new IfcUnit { Value = new IfcSIUnit(IfcUnitEnum.LENGTHUNIT, IfcSIUnitName.METRE) }
                        }
                    };
                    var length = new IfcUnit { Value = leng };
                    IfcUnitAssignment.Units.Add(length);

                    var area = new IfcConversionBasedUnit
                    {
                        Dimensions = new IfcDimensionalExponents
                        {
                            LengthExponent = 2,
                            MassExponent = 0,
                            TimeExponent = 0,
                            ElectricCurrentExponent = 0,
                            ThermodynamicTemperatureExponent = 0,
                            AmountOfSubstanceExponent = 0,
                            LuminousIntensityExponent = 0,
                        },
                        UnitType = IfcUnitEnum.AREAUNIT,
                        Name = "SQUARE FOOT",
                        ConversionFactor = new IfcMeasureWithUnit
                        {
                            ValueComponent = new IfcValue
                            {
                                Value
                                = new IfcRatioMeasure { Value = 0.09290304 }
                            },
                            UnitComponent = new IfcUnit { Value = new IfcSIUnit(IfcUnitEnum.AREAUNIT, IfcSIUnitName.SQUARE_METRE) }
                        }
                    };

                    var areaUnit = new IfcUnit { Value = area };
                    IfcUnitAssignment.Units.Add(areaUnit);

                    var volume = new IfcConversionBasedUnit
                    {
                        Dimensions = new IfcDimensionalExponents
                        {
                            LengthExponent = 3,
                            MassExponent = 0,
                            TimeExponent = 0,
                            ElectricCurrentExponent = 0,
                            ThermodynamicTemperatureExponent = 0,
                            AmountOfSubstanceExponent = 0,
                            LuminousIntensityExponent = 0,

                        },
                        UnitType = IfcUnitEnum.VOLUMEUNIT,
                        Name = "CUBIC FOOT",
                        ConversionFactor = new IfcMeasureWithUnit
                        {
                            ValueComponent = new IfcValue
                            {
                                Value = new IfcRatioMeasure { Value = 0.02831685 }
                            },
                            UnitComponent = new IfcUnit { Value = new IfcSIUnit(IfcUnitEnum.VOLUMEUNIT, IfcSIUnitName.CUBIC_METRE) }
                        }
                    };

                    var volumeUnit = new IfcUnit { Value = volume };
                    IfcUnitAssignment.Units.Add(volumeUnit);
                    #endregion
                    break;
            }

            var degree = new IfcConversionBasedUnit
            {
                Dimensions = new IfcDimensionalExponents
                {
                    LengthExponent = 0,
                    MassExponent = 0,
                    TimeExponent = 0,
                    ElectricCurrentExponent = 0,
                    ThermodynamicTemperatureExponent = 0,
                    AmountOfSubstanceExponent = 0,
                    LuminousIntensityExponent = 0,
                },
                UnitType = IfcUnitEnum.PLANEANGLEUNIT,
                Name = "DEGREE",
                ConversionFactor = new IfcMeasureWithUnit
                {
                    ValueComponent = new IfcValue
                    {
                        Value = new IfcPlaneAngleMeasure
                        {
                            Value = 0.01745329
                        }
                    },
                    UnitComponent = new IfcUnit
                    {
                        Value = new IfcSIUnit(IfcUnitEnum.PLANEANGLEUNIT, IfcSIUnitName.RADIAN)
                    }
                }
            };
            var angle = new IfcUnit { Value = degree };
            IfcUnitAssignment.Units.Add(angle);

            IfcUnitAssignment.Units.Add(
                new IfcUnit()
                {
                    Value = new IfcSIUnit(IfcUnitEnum.SOLIDANGLEUNIT, IfcSIUnitName.STERADIAN)
                });
            IfcUnitAssignment.Units.Add(
                new IfcUnit()
                {
                    Value = new IfcSIUnit(IfcUnitEnum.MASSUNIT, IfcSIUnitName.GRAM)
                });
            IfcUnitAssignment.Units.Add(
                new IfcUnit()
                {
                    Value = new IfcSIUnit(IfcUnitEnum.TIMEUNIT, IfcSIUnitName.SECOND)
                });
            IfcUnitAssignment.Units.Add(
                new IfcUnit()
                {
                    Value = new IfcSIUnit(IfcUnitEnum.THERMODYNAMICTEMPERATUREUNIT, IfcSIUnitName.DEGREE_CELSIUS)
                });
            IfcUnitAssignment.Units.Add(
                new IfcUnit()
                {
                    Value = new IfcSIUnit(IfcUnitEnum.LUMINOUSINTENSITYUNIT, IfcSIUnitName.LUMEN)
                });
        }
        #endregion

        #region representation context


        public void RetrieveContext(IfcGeometricRepresentationContext ifcGeometricRepresentationContext)
        {
            GeometricRepresentationContext = ifcGeometricRepresentationContext;
        }

        public void SetContext()
        {

            SetBbDirection3D();


            Origin2D = BbCoordinate2D.Create();
            SetBbDirection2D();


            GeometricRepresentationContext = new IfcGeometricRepresentationContext
            {
                ContextType = "Model",
                CoordinateSpaceDimension = 3,
                Precision = 1E-08,
                WorldCoordinateSystem = new IfcAxis2Placement
                {
                    Value = DefaultBbPosition3D.IfcAxis2Placement3D
                }
            };
        }

        void SetBbDirection3D()
        {
            XAxis = RefDirection = BbDirection3D.Create(1, 0, 0);
            YAxis = BbDirection3D.Create(0, 1, 0);
            ZAxis = Axis = BbDirection3D.Create(0, 0, 1);
            XAxisMinus = BbDirection3D.Create(-1, 0, 0);
            YAxisMinus = BbDirection3D.Create(0, -1, 0);
            ZAxisMinus = BbDirection3D.Create(0, 0, -1);
            DefaultOrigin = BbCoordinate3D.Create();
            DefaultBbPosition3D = BbPosition3D.Create(DefaultOrigin, Axis, RefDirection);
        }


        void SetBbDirection2D()
        {
            XAxis2D = RefDirection2D = BbDirection2D.Create(1, 0);
            YAxis2D = BbDirection2D.Create(0, 1);
            XAxisMinus2D = BbDirection2D.Create(-1, 0);
            YAxisMinus2D = BbDirection2D.Create(0, -1);

            Origin2D = BbCoordinate2D.Create();
            Position2D = BbPosition2D.Create(Origin2D, RefDirection2D);
        }


        #endregion



    }



}
