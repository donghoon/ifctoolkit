
using System;
using System.Collections.Generic;
using BlackBox.Service;
using IFC2X3;
using EbInstanceModel;

namespace BlackBox.Predefined
{
    /// <summary>
    /// Paint finish.
    /// </summary>
    public partial class BbPaintFinish : BbBase
    {

        [EarlyBindingInstance]
        public IfcCovering IfcCovering { get; set; } 


        /// <summary>
        /// 
        /// </summary>
        /// <param name="type">BLASTED, GALVANIZED, PAINTED, PRIMED or ETC</param>
        protected BbPaintFinish(string type)
        {
            IfcCovering = new IfcCovering
            {
                GlobalId = IfcGloballyUniqueId.NewGuid(),
                OwnerHistory = BbHeaderSetting.Setting3D.IfcOwnerHistory,
                Name = "FINISH",
                ObjectType = type,
                Tag = "FINISH",
                PredefinedType = IfcCoveringTypeEnum.USERDEFINED,

            };
        }

        protected BbPaintFinish()
        {
        }


        private BbSurfaceGeometry _bbSurfaceGeometry;

        public BbSurfaceGeometry BbSurfaceGeometry{
            get { return _bbSurfaceGeometry; }
            protected set
            {
                _bbSurfaceGeometry = value;
                IfcCovering.Representation = _bbSurfaceGeometry.IfcProductDefinitionShape;
            }
        }


        private BbLocalPlacement3D _bbLocalPlacement3D;

        public BbLocalPlacement3D BbLocalPlacement3D
        {
            get
            {
                return _bbLocalPlacement3D;
            }
            protected set
            {
                _bbLocalPlacement3D = value;
                IfcCovering.ObjectPlacement = _bbLocalPlacement3D.IfcLocalPlacement;
            }
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="type">one of SemSurfaceTreatmentProperties</param>
        //public BbPaintFinish()
        //{

        //    IfcCovering = new IfcCovering
        //    {
        //        GlobalId = IfcGloballyUniqueId.NewGuid(),
        //        OwnerHistory = BbHeaderSetting.Setting3D.IfcOwnerHistory,
        //        //Name = name,
        //        ObjectType = "FINISH",
        //        //Tag = id,
        //        PredefinedType = IfcCoveringTypeEnum.USERDEFINED,
        //        /// set propertySet value with type parameter value
        //    };
        //}
        


        //public BbPaintFinish(IfcCovering paint, IfcRelCoversBldgElements agg)
        //{
        //    IfcCovering = paint;
        //    IfcRelCoversBldgElements = agg;

        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type">BLASTED, GALVANIZED, PAINTED, PRIMED or ETC</param>
        /// <returns></returns>
        public static BbPaintFinish Create(string type)
        {
            var paintFinish = new BbPaintFinish(type);

            BbInstanceDB.AddToExport(paintFinish);

            return paintFinish;
        }



        public void AddGeometricRepresentation(BbElement hostElement, BbSurfaceGeometry surfaceGeometry,
            BbPosition3D position3D)
        {
            var ploc = BbLocalPlacement3D.Create(
                hostElement.ObjectBbLocalPlacement,
                BbPosition3D.Create(
                    BbCoordinate3D.Create(0, 254, 100),
                    BbHeaderSetting.Setting3D.YAxis,
                    BbHeaderSetting.Setting3D.XAxisMinus)
                );
            AddGeometricRepresentation(hostElement, surfaceGeometry, ploc);
        }

        public void AddGeometricRepresentation(BbElement hostElement, BbSurfaceGeometry surfaceGeometry,
            BbLocalPlacement3D localPlacement3D)
        {
            BbSurfaceGeometry = surfaceGeometry;
            BbLocalPlacement3D = localPlacement3D;
        }

        //public static BbPaintFinish Create(string type, BbSurfaceGeometry appliedSection, BbLocalPlacement3D localPlacement3D )
        //{
        //    var paintFinish = new BbPaintFinish(type, appliedSection, localPlacement3D);
            
        //    BbInstanceDB.AddToExport(paintFinish);

        //    return paintFinish;
        //}


        //public static BbPaintFinish Create()
        //{
        //    var paintFinish = new BbPaintFinish();

        //    BbInstanceDB.AddToExport(paintFinish);

        //    return paintFinish;
        //}

        //public static BbLocalPlacement3D RetrieveLocalPlacement(BbPaintFinish pFinishPatch)
        //{
        //    var localPlacement = new BbLocalPlacement3D();

        //    //if (!EarlyBindingInstanceModel.TheModel.DataByType.ContainsKey("IfcLocalPlacement")) return null;

        //    var collection = EarlyBindingInstanceModel.GetDataByType("IfcLocalPlacement").Values;
        //    foreach (var item in collection)
        //    {
        //        if (item.EIN == pFinishPatch.IfcCovering.ObjectPlacement.EIN)
        //        {
        //            var placement = item as IfcLocalPlacement;
        //            if (placement == null) continue;

        //            var Instance = new BbLocalPlacement3D { IfcLocalPlacement = placement };
        //            BbInstanceDB.AddToExport(Instance);
        //            localPlacement = Instance;
        //        }

        //    }

        //    return localPlacement;

        //}

        //public static BbSurfaceGeometry RetrieveSurfaceGeometry(BbPaintFinish pFinishPatch)
        //{
        //    //if (!EarlyBindingInstanceModel.TheModel.DataByType.ContainsKey("IfcCurveBoundedPlane")) return null;
        //    var collection = EarlyBindingInstanceModel.GetDataByType("IfcCurveBoundedPlane").Values;

        //    var ret = new BbSurfaceGeometry();
        //    foreach (var item in collection)
        //    {
        //        var shapeRepresentations = pFinishPatch.IfcCovering.Representation.Representations;
        //        foreach (var shapeRepresentation in shapeRepresentations)
        //        {
        //            var RepItems = shapeRepresentation.Items;
        //            foreach (var RepItem in RepItems)
        //            {
        //                if (item.EIN == RepItem.EIN)
        //                {
        //                    var curvePlane = item as IfcCurveBoundedPlane;
        //                    if (curvePlane == null) continue;
        //                    var surfaceGeometry = new BbSurfaceGeometry { ifcCurveBoundedPlane = curvePlane };
        //                    BbInstanceDB.AddToExport(surfaceGeometry);
        //                    ret = surfaceGeometry;
        //                }
        //            }
        //        }

        //    }
        //    return ret;
        //}


    }
}

 


/*
using System;
using System.Collections.Generic;
using System.IO;
using IFC2X3;
using Sem.Service;
using EbInstanceModel;

namespace Sem.Predefined
{
    /// <summary>
    /// Paint finish.
    /// </summary>
    public partial class BbPaintFinish : BbBase
    {

        [EarlyBindingInstanceCollection]
        public IList<IfcCovering> IfcCoveringList
        {
            get { return _ifcCoveringList; }
        }

        [EarlyBindingInstanceCollection]
        public IList<IfcRelCoversBldgElements> IfcRelCoversBldgElementsList
        {
            get { return _ifcRelCoversBldgElementsList; }
        }

        readonly List<IfcCovering> _ifcCoveringList = new List<IfcCovering>();


        readonly List<IfcRelCoversBldgElements> _ifcRelCoversBldgElementsList = new List<IfcRelCoversBldgElements>();


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type">BLASTED, GALVANIZED, PAINTED, PRIMED and ETC</param>
        /// <param name="element"></param>
        protected BbPaintFinish(string name, string type, BbElement element)
        {
            var ifcCovering = new IfcCovering
            {
                GlobalId = IfcGloballyUniqueId.NewGuid(),
                OwnerHistory = BbHeaderSetting.Setting3D.IfcOwnerHistory,
                Name = name,
                ObjectType = type,
                //Tag = id,
                PredefinedType = IfcCoveringTypeEnum.USERDEFINED,
            };
            _ifcCoveringList.Add(ifcCovering);

            var elem = element.IfcObject as IfcElement;

            if (elem == null) throw new InvalidCastException();

            var ifcRelCoversBldgElements = new IfcRelCoversBldgElements
            {
                GlobalId = IfcGloballyUniqueId.NewGuid(),
                OwnerHistory = BbHeaderSetting.Setting3D.IfcOwnerHistory,
                RelatedCoverings = new List<IfcCovering>(),
                RelatingBuildingElement = elem
            };

            _ifcRelCoversBldgElementsList.Add(ifcRelCoversBldgElements);

            ifcRelCoversBldgElements.RelatedCoverings.Add(ifcCovering);

        }


        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="type">one of SemSurfaceTreatmentProperties</param>
        //protected BbPaintFinish()
        //    : this(@"FINISH", @"PAINTED")
        //{

        //    //IfcCovering = new IfcCovering
        //    //{
        //    //    GlobalId = IfcGloballyUniqueId.NewGuid(),
        //    //    OwnerHistory = BbHeaderSetting.Setting3D.IfcOwnerHistory,
        //    //    //Name = name,
        //    //    ObjectType = "FINISH",
        //    //    //Tag = id,
        //    //    PredefinedType = IfcCoveringTypeEnum.USERDEFINED,
        //    //    /// set propertySet value with type parameter value
        //    //};n
        //}



        protected BbPaintFinish(IfcCovering paint, IfcRelCoversBldgElements agg)
        {

            _ifcCoveringList.Add(paint);
            _ifcRelCoversBldgElementsList.Add(agg);

        }


        public static BbPaintFinish Create(string name, string type, BbElement element)
        {
            var paintFinish = new BbPaintFinish(name, type, element);

            BbInstanceDB.AddToExport(paintFinish);

            return paintFinish;
        }


        //public static BbPaintFinish Create()
        //{
        //    var paintFinish = new BbPaintFinish();

        //    BbInstanceDB.AddToExport(paintFinish);

        //    return paintFinish;
        //}


        public void AddToOtherElement(BbElement element)
        {

            if (element == null)
            {
                throw new ArgumentNullException();
            }

            if (element.IfcObject == null)
            {
                throw new NullReferenceException();
            }


            var bElement = element.IfcObject as IfcElement;
            if (bElement == null)
            {
                throw new InvalidCastException();
            }

            var relCovers = new IfcRelCoversBldgElements
            {
                RelatingBuildingElement = bElement,

            };
            
            IfcRelCoversBldgElementsList.Add(relCovers);

            //PaintFinishes.Add(paintFinish);
        }

        public void AddNextLayer(string name, string type)
        {
            var ifcCovering = new IfcCovering
            {
                GlobalId = IfcGloballyUniqueId.NewGuid(),
                OwnerHistory = BbHeaderSetting.Setting3D.IfcOwnerHistory,
                Name = name,
                ObjectType = type,
                //Tag = id,
                PredefinedType = IfcCoveringTypeEnum.USERDEFINED,
            };
            _ifcCoveringList.Add(ifcCovering);

            foreach (var coversBldgElement in _ifcRelCoversBldgElementsList)
            {
                coversBldgElement.RelatedCoverings.Add(ifcCovering);
            }

        }


        public void AddGeometryToAll(BbSurfaceGeometry geometryDefinition)
        {
            foreach (var ifcCovering in _ifcCoveringList)
            {
                ifcCovering.Representation = geometryDefinition.IfcProductDefinitionShape;
                ifcCovering.ObjectPlacement = _bbLocalPlacement3D.IfcLocalPlacement;
            }
        }


        public void AddToElement(BbElement element, BbLocalPlacement3D semLocalPlacement3D)
        {
            AddToElement(element);
            BbLocalPlacement3D = semLocalPlacement3D;
        }





        //public void AddToElement(SemPaintFinishPatch semPaintFinish, BbLocalPlacement3D semLocalPlacement3D)
        //{
        //    AddToElement(semPaintFinish);
        //    semPaintFinish.BbLocalPlacement3D = semLocalPlacement3D;
        //}



        //public List<BbPaintFinish> PaintFinishes { get; protected set; }


        //public void AddPaintFinish(BbPaintFinish paintFinish)
        //{
        //    if (PaintFinishes == null)
        //    {
        //        PaintFinishes = new List<BbPaintFinish>();
        //    }

        //    if (IfcRelCoversBldgElements == null)
        //    {
        //        IfcRelCoversBldgElements = new IfcRelCoversBldgElements
        //            {
        //                GlobalId = IfcGloballyUniqueId.NewGuid(),
        //                OwnerHistory = BbHeaderSetting.Setting3D.IfcOwnerHistory,
        //                RelatingBuildingElement = IfcObject as IfcElement,
        //                RelatedCoverings = new List<IfcCovering>(),
        //            };
        //    }

        //    IfcRelCoversBldgElements.RelatedCoverings.Add(paintFinish.IfcCovering);


        //    PaintFinishes.Add(paintFinish);
        //}

        //public void AddPaintFinish(SemPaintFinishPatch semPaintFinish, BbLocalPlacement3D semLocalPlacement3D)
        //{
        //    AddPaintFinish(semPaintFinish);
        //    semPaintFinish.BbLocalPlacement3D = semLocalPlacement3D;
        //}


        //public static BbLocalPlacement3D RetrieveLocalPlacement(BbPaintFinish pFinishPatch)
        //{
        //    var localPlacement = new BbLocalPlacement3D();

        //    //if (!EarlyBindingInstanceModel.TheModel.DataByType.ContainsKey("IfcLocalPlacement")) return null;

        //    var collection = EarlyBindingInstanceModel.GetDataByType("IfcLocalPlacement").Values;
        //    foreach (var item in collection)
        //    {
        //        if (item.EIN == pFinishPatch.IfcCovering.ObjectPlacement.EIN)
        //        {
        //            var placement = item as IfcLocalPlacement;
        //            if (placement == null) continue;

        //            var Instance = new BbLocalPlacement3D { IfcLocalPlacement = placement };
        //            BbInstanceDB.AddToExport(Instance);
        //            localPlacement = Instance;
        //        }

        //    }

        //    return localPlacement;

        //}

        //public static BbSurfaceGeometry RetrieveSurfaceGeometry(BbPaintFinish pFinishPatch)
        //{
        //    //if (!EarlyBindingInstanceModel.TheModel.DataByType.ContainsKey("IfcCurveBoundedPlane")) return null;
        //    var collection = EarlyBindingInstanceModel.GetDataByType("IfcCurveBoundedPlane").Values;

        //    var ret = new BbSurfaceGeometry();
        //    foreach (var item in collection)
        //    {
        //        var shapeRepresentations = pFinishPatch.IfcCovering.Representation.Representations;
        //        foreach (var shapeRepresentation in shapeRepresentations)
        //        {
        //            var RepItems = shapeRepresentation.Items;
        //            foreach (var RepItem in RepItems)
        //            {
        //                if (item.EIN == RepItem.EIN)
        //                {
        //                    var curvePlane = item as IfcCurveBoundedPlane;
        //                    if (curvePlane == null) continue;
        //                    var surfaceGeometry = new BbSurfaceGeometry { ifcCurveBoundedPlane = curvePlane };
        //                    BbInstanceDB.AddToExport(surfaceGeometry);
        //                    ret = surfaceGeometry;
        //                }
        //            }
        //        }

        //    }
        //    return ret;
        //}


    }
}

*/
