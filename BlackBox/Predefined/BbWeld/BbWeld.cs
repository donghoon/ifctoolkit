using System.Collections.Generic;
using BlackBox.Service;
using IFC2X3;
using EbInstanceModel;



namespace BlackBox.Predefined
{
    /// <summary>
    /// Weld.
    /// </summary>
    public class BbWeld : BbFastener
    {

        IfcFastener _ifcElement;

        [EarlyBindingInstance]
        public override IfcObject IfcObject
        {
            get { return _ifcElement; }
            protected set { base.IfcObject = _ifcElement = value as IfcFastener; }
        }



        public BbElement MainElement { get; private set; }
        public BbElement AttachedElement { get; private set; }


        public BbPropertySet BbPropertySet { get; private set; }


        private BbCurveGeometry _weldingPath;

        public BbCurveGeometry WeldingPath
        {
            get { return _weldingPath; }
            private set
            {
                _weldingPath = value;
                _ifcElement.Representation = _weldingPath.IfcProductDefinitionShape;
            }
        }

        BbWeld(BbElement mainElement, BbElement attachedElement)
        {
            _ifcElement = new IfcFastener
            {
                GlobalId = IfcGloballyUniqueId.NewGuid(),
                OwnerHistory = BbHeaderSetting.Setting3D.IfcOwnerHistory,

                ObjectType = "Weld",

            };

            MainElement = mainElement;
            AttachedElement = attachedElement;

            IfcRelConnectsElements = new IfcRelConnectsWithRealizingElements
            {
                GlobalId = IfcGloballyUniqueId.NewGuid(),
                OwnerHistory = BbHeaderSetting.Setting3D.IfcOwnerHistory,
                RelatingElement = MainElement.IfcObject as IfcElement,
                RelatedElement = AttachedElement.IfcObject as IfcElement,
                RealizingElements = new List<IfcElement> { _ifcElement },
            };
        }

        private BbWeld()
        {
        }

        public static BbWeld Create(BbElement mainElement, BbElement attchedElement)
        {
            var weld = new BbWeld(mainElement, attchedElement);
            BbInstanceDB.AddToExport(weld);
            return weld;
        }

        public static ICollection<BbWeld> Retrieve(BbElement mainPiece)
        {
            var ret = new List<BbWeld>();
            //if (!EarlyBindingInstanceModel.TheModel.DataByType.ContainsKey("IfcRelConnectsWithRealizingElements")) return null;
            var collection = EarlyBindingInstanceModel.GetDataByType("IfcRelConnectsWithRealizingElements").Values;
            foreach (var theItem in collection)
            {
                var rel = theItem as IfcRelConnectsWithRealizingElements;
                if (rel == null) continue;
                if (rel.RelatingElement.EIN == mainPiece.IfcObject.EIN)
                {
                    //if (!EarlyBindingInstanceModel.TheModel.DataByType.ContainsKey("IfcFastener")) return null;
                    var collection1 = EarlyBindingInstanceModel.GetDataByType("IfcFastener").Values;
                    foreach (var item in collection1)
                    {
                        var relElements = rel.RealizingElements;
                        foreach (var relElement in relElements)
                        {
                            if (relElement.EIN == item.EIN)
                            {
                                var fastener = item as IfcFastener;
                                if (fastener == null) continue;
                                var weld = new BbWeld { _ifcElement = fastener, IfcRelConnectsElements = rel };
                                //BbInstanceDB.Add(weld);
                                ret.Add(weld);

                                // Retrieve MainElement
                                weld.MainElement = mainPiece;
                                // Retrieve AttachedElement
                                var relatedElement = weld.IfcRelConnectsElements.RelatedElement as IfcElement;
                                // wrong implementation, need to revise, donghoon 20131205
                                //weld.AttachedElement = new BbElement { IfcElement = relatedElement };
                            }
                        }
                    }
                }
            }
            return ret;
        }

        public void AddWeldingPath(BbCurveGeometry weldingPath, BbCoordinate3D position)
        {
            WeldingPath = weldingPath;
            var pos = BbPosition3D.Create(position,
                BbHeaderSetting.Setting3D.ZAxis, BbHeaderSetting.Setting3D.XAxis);
            ObjectBbLocalPlacement = BbLocalPlacement3D.Create(
                MainElement.ObjectBbLocalPlacement, pos);

            _ifcElement.ObjectPlacement = ObjectBbLocalPlacement.IfcLocalPlacement;

        }


        public double WeldThickness { get; set; }
        public double WeldLegSize { get; set; }
        public double WeldThroatSize { get; set; }
        public List<string> WeldGrade
        {
            get { return _weldGrade; }
        }

        private readonly List<string> _weldGrade = new List<string>();

        public string WeldID { get; set; }
        public string WeldDescription { get; set; }
        public string WPSCode { get; set; }
        public string WeldCategory { get; set; }
        public double WeldLength { get; set; }
        public bool FieldWeld { get; set; }

        public string WeldType1 { get; set; }
        public string WeldType2 { get; set; }
        public string WeldSurface1 { get; set; }
        public string WeldSurface2 { get; set; }
        public int WeldProcess { get; set; }
        public string WeldProcessName { get; set; }
        public double WeldA { get; set; }
        public double WeldC { get; set; }
        public double WeldD { get; set; }
        public double WeldE { get; set; }
        public double WeldL { get; set; }
        public double WeldN { get; set; }
        public double WeldS { get; set; }
        public double WeldZ { get; set; }
        public bool WeldIntermittent { get; set; }
        public bool WeldStaggered { get; set; }


        public void AddProperties(
            BbPropertySet bbPropertySet,
            string weldId, string weldDescription,
            string wpsCode, string weldCategory,
            string weldGrade,
            double? weldLength, bool? fieldWeld)
        {
            if (BbPropertySet == null)
                BbPropertySet = bbPropertySet;
            if (!string.IsNullOrWhiteSpace(weldId))
            {
                WeldID = weldId;
                bbPropertySet.AddProperty(BbSingleProperty.Create("WeldID", WeldID, true));
            }

            if (!string.IsNullOrWhiteSpace(weldDescription))
            {
                WeldDescription = weldDescription;
                bbPropertySet.AddProperty(BbSingleProperty.Create("WeldDescription", WeldDescription, true));
            }

            if (!string.IsNullOrWhiteSpace(wpsCode))
            {
                WPSCode = wpsCode;
                bbPropertySet.AddProperty(BbSingleProperty.Create("WPSCode", WPSCode, true));
            }

            if (!string.IsNullOrWhiteSpace(weldCategory))
            {
                WeldCategory = weldCategory;
                bbPropertySet.AddProperty(BbSingleProperty.Create("WeldCategory", WeldCategory, true));
            }

            if (!string.IsNullOrEmpty(weldGrade))
            {
                WeldGrade.Add(weldGrade);
                bbPropertySet.AddProperty(BbListProperty.Create("WeldGrade", weldGrade, typeof(IfcLabel)));
            }

            if (weldLength != null)
            {
                WeldLength = weldLength.Value;
                bbPropertySet.AddProperty(BbSingleProperty.Create("WeldLength", WeldLength, typeof(IfcPositiveLengthMeasure)));
            }
            else
            {
                WeldLength = 0.0;
            }

            if (fieldWeld != null)
            {
                FieldWeld = fieldWeld.Value;
                bbPropertySet.AddProperty(BbSingleProperty.Create("FieldWeld", FieldWeld));
            }
            else
            {
                WeldLength = 0.0;
            }
        }

        public void AddProperties(
            BbPropertySet bbPropertySet,
            string weldType1, string weldType2,
            string weldSurface1, string weldSurface2,
            int? weldProcess, string weldProcessName,
            double? weldA, double? weldC, double? weldD,
            double? weldE, double? weldL, double? weldN,
            double? weldS, double? weldZ,
            bool? weldIntermittent, bool? weldStaggered)
        {
            if (BbPropertySet == null)
                BbPropertySet = bbPropertySet;
            if (!string.IsNullOrWhiteSpace(weldType1))
            {
                WeldType1 = weldType1;
                bbPropertySet.AddProperty(BbSingleProperty.Create("WeldType1", WeldType1, true));
            }

            if (!string.IsNullOrWhiteSpace(weldType2))
            {
                WeldType2 = weldType2;
                bbPropertySet.AddProperty(BbSingleProperty.Create("WeldType2", WeldType2, true));
            }

            if (!string.IsNullOrWhiteSpace(weldSurface1))
            {
                WeldSurface1 = weldSurface1;
                bbPropertySet.AddProperty(BbSingleProperty.Create("WeldSurface1", WeldSurface1, true));
            }

            if (!string.IsNullOrWhiteSpace(weldSurface2))
            {
                WeldSurface2 = weldSurface2;
                bbPropertySet.AddProperty(BbSingleProperty.Create("WeldSurface2", WeldSurface2, true));
            }

            if (weldProcess != null)
            {
                WeldProcess = weldProcess.Value;
                bbPropertySet.AddProperty(BbSingleProperty.Create("WeldProcess", WeldProcess, typeof(IfcInteger)));
            }
            else
            {
                WeldProcess = 0;
            }

            if (!string.IsNullOrWhiteSpace(weldProcessName))
            {
                WeldProcessName = weldProcessName;
                bbPropertySet.AddProperty(BbSingleProperty.Create("WeldProcessName", WeldProcessName, true));
            }

            if (weldA != null)
            {
                WeldA = weldA.Value;
                bbPropertySet.AddProperty(BbSingleProperty.Create("WeldA", WeldA, typeof(IfcPositiveLengthMeasure)));
            }
            else
            {
                WeldA = 0.0;
            }

            if (weldC != null)
            {
                WeldC = weldC.Value;
                bbPropertySet.AddProperty(BbSingleProperty.Create("WeldC", WeldC, typeof(IfcPositiveLengthMeasure)));
            }
            else
            {
                WeldC = 0.0;
            }

            if (weldD != null)
            {
                WeldD = weldD.Value;
                bbPropertySet.AddProperty(BbSingleProperty.Create("WeldD", WeldD, typeof(IfcPositiveLengthMeasure)));
            }
            else
            {
                WeldD = 0.0;
            }

            if (weldE != null)
            {
                WeldE = weldE.Value;
                bbPropertySet.AddProperty(BbSingleProperty.Create("WeldE", WeldE, typeof(IfcPositiveLengthMeasure)));
            }
            else
            {
                WeldE = 0.0;
            }


            if (weldL != null)
            {
                WeldL = weldL.Value;
                bbPropertySet.AddProperty(BbSingleProperty.Create("WeldL", WeldL, typeof(IfcPositiveLengthMeasure)));
            }
            else
            {
                WeldL = 0.0;
            }

            if (weldN != null)
            {
                WeldN = weldN.Value;
                bbPropertySet.AddProperty(BbSingleProperty.Create("WeldN", WeldN, typeof(IfcPositiveLengthMeasure)));
            }
            else
            {
                WeldN = 0.0;
            }

            if (weldS != null)
            {
                WeldS = weldS.Value;
                bbPropertySet.AddProperty(BbSingleProperty.Create("WeldS", WeldN, typeof(IfcPositiveLengthMeasure)));
            }
            else
            {
                WeldS = 0.0;
            }

            if (weldZ != null)
            {
                WeldZ = weldZ.Value;
                bbPropertySet.AddProperty(BbSingleProperty.Create("WeldZ", WeldZ, typeof(IfcPositiveLengthMeasure)));
            }
            else
            {
                WeldZ = 0.0;
            }
        }
    }



}

