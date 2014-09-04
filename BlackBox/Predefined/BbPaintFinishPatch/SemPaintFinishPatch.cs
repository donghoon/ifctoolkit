//using Sem.Service;
//using EbInstanceModel;
//using IFC2X3;

//namespace Sem.Predefined
//{
//    public class SemPaintFinishPatch : BbElementGeometry
//    {
//        public BbSurfaceGeometry _bbSurfaceGeometry;

//        public BbSurfaceGeometry Patch
//        {
//            get { return _bbSurfaceGeometry; }
//            set
//            {
//                _bbSurfaceGeometry = value;
//                IfcCovering.Representation = _bbSurfaceGeometry.IfcProductDefinitionShape;
//            }
//        }


//        public BbLocalPlacement3D _bbLocalPlacement3D;

//        public BbLocalPlacement3D BbLocalPlacement3D
//        {
//            get { return _bbLocalPlacement3D; }
//            set
//            {
//                _bbLocalPlacement3D = value;
//                IfcCovering.ObjectPlacement = _bbLocalPlacement3D.IfcLocalPlacement;
//            }
//        }


//        protected SemPaintFinishPatch(string name, string type, BbSurfaceGeometry semSurfaceGeometry)
//            : base(name, type)
//        {
//            Patch = semSurfaceGeometry;
//        }

//        protected SemPaintFinishPatch()
//        { }


//        protected SemPaintFinishPatch(IfcCovering paint, IfcRelCoversBldgElements agg)
//        {
//            IfcCovering = paint;
//            IfcRelCoversBldgElements = agg;
//        }

//        public static SemPaintFinishPatch Create(string name, string type, BbSurfaceGeometry semSurfaceGeometry)
//        {
//            var pat = new SemPaintFinishPatch(name, type, semSurfaceGeometry);
//            BbInstanceDB.AddToExport(pat);

//            return pat;
//        }


//        public void AddToElement(BbElement element, BbLocalPlacement3D semLocalPlacement3D)
//        {
//            AddToElement(element);
//            BbLocalPlacement3D = semLocalPlacement3D;
//        }

//    }
//}


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using BlackBox.Service;
using IFC2X3;
using EbInstanceModel;

namespace BlackBox.Predefined
{
    /// <summary>
    /// Paint finish.
    /// </summary>
    public partial class BbPaintFinishApplied : BbPaintFinish
    {

        [EarlyBindingInstanceCollection]
        public IList<IfcCovering> IfcCoveringList
        {
            get
            {
                var a = (from x in _hostElements
                    select  x.IfcObject).OfType<IfcCovering>().ToList();
                return a.Any() ? a.ToList() : null;
            }
        }

        [EarlyBindingInstanceCollection]
        public IList<IfcRelCoversBldgElements> IfcRelCoversBldgElementsList
        {
            get { return _ifcRelCoversBldgElementsList; }
        }

        readonly List<IfcCovering> _ifcCoveringList = new List<IfcCovering>();


        readonly List<IfcRelCoversBldgElements> _ifcRelCoversBldgElementsList = new List<IfcRelCoversBldgElements>();

        readonly List<BbPaintFinish> _paintFinishes = new List<BbPaintFinish>(); 

        readonly List<BbElement> _hostElements = new List<BbElement>();


        public BbElement TheElement
        {
            get
            {
                return _hostElements.Count == 1 ? _hostElements[0] : null;
            }

        }


        // BLASTED, GALVANIZED, PAINTED, PRIMED and ETC

        //protected BbPaintFinishApplied(BbElement hostElement, BbPaintFinish paintFinish, BbSurfaceGeometry shape, BbPosition3D localPlacement3D)
        //{
        //    if (hostElement == null) { throw new ArgumentNullException(); }
        //    if (hostElement.IfcObject == null) { throw new NullReferenceException(); }

        //    _hostElements.Add(hostElement);
        //    _paintFinishes.Add(paintFinish);
            


        //    //var ploc = BbLocalPlacement3D.Create(TheElement.ObjectBbLocalPlacement, localPlacement3D);
        //    //paintFinish.BbLocalPlacement3D = ploc;

            
        //    var bElement = hostElement.IfcObject as IfcElement;
        //    if (bElement == null){throw new InvalidCastException();}

        //    var relCovers = new IfcRelCoversBldgElements
        //    {
        //        GlobalId = IfcGloballyUniqueId.NewGuid(),
        //        OwnerHistory = BbHeaderSetting.Setting3D.IfcOwnerHistory,
        //        RelatingBuildingElement = bElement,
        //        RelatedCoverings = new List<IfcCovering>{paintFinish.IfcCovering},
        //    };

        //    IfcRelCoversBldgElementsList.Add(relCovers);

        //}





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



        //protected BbPaintFinishApplied(IfcCovering paint, IfcRelCoversBldgElements agg)
        //{

        //    _ifcCoveringList.Add(paint);
        //    _ifcRelCoversBldgElementsList.Add(agg);

        //}


        //public static BbPaintFinishApplied Create(BbElement hostElement, BbPaintFinish paintFinish, BbPosition3D localPlacement3D)
        //{
        //    var paintFinishes = new BbPaintFinishApplied(hostElement, paintFinish, localPlacement3D);

        //    BbInstanceDB.AddToExport(paintFinishes);

        //    return paintFinishes;
        //}


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


        //public void AddGeometryToAll(BbSurfaceGeometry geometryDefinition)
        //{
        //    foreach (var ifcCovering in _ifcCoveringList)
        //    {
        //        ifcCovering.Representation = geometryDefinition.IfcProductDefinitionShape;
        //        ifcCovering.ObjectPlacement = _bbLocalPlacement3D.IfcLocalPlacement;
        //    }
        //}


        //public void AddToElement(BbElement element, BbLocalPlacement3D semLocalPlacement3D)
        //{
        //    AddToElement(element);
        //    BbLocalPlacement3D = semLocalPlacement3D;
        //}





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
