using System;
using BlackBox.Service;
using IFC2X3;
using EbInstanceModel;
using System.Collections.Generic;

namespace BlackBox.Predefined
{
    public partial class BbMainPiece : BbPiece
    {
       

        private IfcBuildingElement _ifcBuildingElement;

        [EarlyBindingInstance]
        public override IfcObject IfcObject
        {
            get { return _ifcBuildingElement; }
            protected set
            {
                base.IfcObject = _ifcBuildingElement = value as IfcBuildingElement;
                if(_ifcBuildingElement == null)
                    throw new InvalidCastException();
            }
        }

        
        //public BbAssembly BbAssembly { get; protected set; }

        protected BbMainPiece()
            : this(Guid.NewGuid())
        {
        }

        protected BbMainPiece(Guid guid)
            : base(guid)
        {
        }


        protected BbMainPiece(
            string id, string name, string objectType, BbProfile profile,
            double length, BbCoordinate3D position, BbDirection3D zAxis,
            BbDirection3D xAxis, BbDirection3D extrudeDirection,
            BbAssembly container,
            Type ifcType)
            : base(id, name, objectType, profile, length, position, zAxis, xAxis, extrudeDirection, container, ifcType)
        {
            _ifcBuildingElement = base.IfcObject as IfcBuildingElement;
        }

        protected BbMainPiece(BbAssembly assembly, IfcElement element, IfcRelAggregates ifcRelAggregates)
        {
            //BbAssembly = assembly;
            // wrong implementation need modification, donghoon 20131205
            //_ifcElement = element;
            //_ifcRelAggregates = ifcRelAggregates;

        }

        public static BbMainPiece Create(
            string id, string pieceName, BbProfile profile,
            double depth, BbCoordinate3D position, BbDirection3D zAxis,
            BbDirection3D xAxis, BbAssembly container
        )
        {

            var trueZ = GetTrueZDirection(zAxis, container);

            BbMainPiece mainPart;
            if (IsColumn(trueZ))
            {
                mainPart = new BbMainPiece(
                id, pieceName, "Column", profile, depth, position, zAxis, xAxis,
                BbHeaderSetting.Setting3D.ZAxis, container, typeof(IfcColumn));
            }
            else if (IsBeam(trueZ))
            {
                mainPart = new BbMainPiece(
                id, pieceName, "Beam", profile, depth, position, zAxis, xAxis,
                BbHeaderSetting.Setting3D.ZAxis, container, typeof(IfcBeam));
            }
            else
            {
                mainPart = new BbMainPiece(
                id, pieceName, "Member", profile, depth, position, zAxis, xAxis,
                BbHeaderSetting.Setting3D.ZAxis, container, typeof(IfcMember));
            }

            //container.AddElement(mainPart);


            mainPart.AddToHostObject(container);
            BbInstanceDB.AddToExport(mainPart);
            return mainPart;
        }


        private static bool IsColumn(BbDirection3D zAxis)
        {
            return zAxis.Z.Equals(1) && zAxis.X.Equals(0) && zAxis.Y.Equals(0);
        }

        private static bool IsBeam(BbDirection3D zAxis)
        {
            return zAxis.Z.Equals(0);
        }


        /// <summary>
        /// incomplete function need revise
        /// </summary>
        /// <param name="zAxis"></param>
        /// <param name="container"></param>
        /// <returns></returns>
        private static BbDirection3D GetTrueZDirection(BbDirection3D zAxis, BbAssembly container)
        {
            var ifcLocalPlacement = container.ObjectBbLocalPlacement.IfcLocalPlacement;
            var baseLoc = ifcLocalPlacement.PlacementRelTo as IfcLocalPlacement;
            var relLoc = ifcLocalPlacement.RelativePlacement.AIfcAxis2Placement3D;
            var ifcDirection = relLoc.Axis;
            while (baseLoc != null)
            {
                baseLoc = baseLoc.PlacementRelTo as IfcLocalPlacement;
                if (baseLoc != null)
                    relLoc = baseLoc.RelativePlacement.AIfcAxis2Placement3D;
            }

            return zAxis;
        }


        /// <summary>
        /// wrong implementation, revise needed, donghoon 20131205
        /// </summary>
        /// <param name="assembly"></param>
        /// <returns></returns>
        public static ICollection<BbMainPiece> Retrieve(BbAssembly assembly)
        {
            var refed = EarlyBindingInstanceModel.GetReferencedEntities(assembly.IfcObject.EIN);
            //if (refed.Count <= 0) throw new InvalidDataException();

            var ret = new List<BbMainPiece>();



            //foreach (var p21Instance in refed)
            //{
            //    if (p21Instance.Value.GetType() != typeof(IfcRelAggregates)) continue;
            //    var agg = p21Instance.Value as IfcRelAggregates;
            //    if (agg == null) continue;

            //    //added
            //    //var a = assembly._ifcRelContainedInSpatialStructure.RelatedElements;
            //    //foreach (var aa in a)
            //    //{
            //    //if (aa.EIN == agg.RelatingObject.EIN)
            //    //{


            //    foreach (var instance in agg.RelatedObjects)
            //    {
            //        if (instance.GetType() == typeof(IfcColumn))
            //        {
            //            var piece = instance as IfcColumn;
            //            if (piece == null) continue;
            //            var semMainPiece = new BbMainPiece(assembly, piece, agg);
            //            ret.Add(semMainPiece);
            //            //assembly.IfcRelAggregates = agg;
            //            BbInstanceDB.AddToExport(semMainPiece);

            //            //Retrieve attributes
            //            var paints = RetrievePaintFinishPatch(semMainPiece);
            //            semMainPiece.PaintFinishes = paints;
            //            var extrudedGeometry = BbExtrudedGeometry.RetrieveFromMainPiece(semMainPiece);
            //            semMainPiece.BbElementGeometry = extrudedGeometry;
            //            var profile = BbProfile.Retrieve(extrudedGeometry);
            //            semMainPiece.Profile = profile;
            //        }


            //        if (instance.GetType() == typeof(IfcBeam))
            //        {

            //            var piece = instance as IfcBeam;
            //            if (piece == null) continue;
            //            var semMainPiece = new BbMainPiece(assembly, piece, agg);
            //            ret.Add(semMainPiece);
            //            //assembly.IfcRelAggregates = agg;
            //            BbInstanceDB.AddToExport(semMainPiece);
            //            //Retrieve attributes
            //            var paints = RetrievePaintFinishPatch(semMainPiece);
            //            semMainPiece.PaintFinishes = paints;
            //            var extrudedGeometry = BbExtrudedGeometry.RetrieveFromMainPiece(semMainPiece);
            //            semMainPiece.BbElementGeometry = extrudedGeometry;
            //            var profile = BbProfile.Retrieve(extrudedGeometry);
            //            semMainPiece.Profile = profile;

            //        }

            //        if (instance.GetType() == typeof(IfcMember))
            //        {
            //            var piece = instance as IfcMember;
            //            if (piece == null) continue;
            //            var semMainPiece = new BbMainPiece(assembly, piece, agg);
            //            ret.Add(semMainPiece);
            //            // assembly.IfcRelAggregates = agg;
            //            BbInstanceDB.AddToExport(semMainPiece);
            //            //Retrieve attributes
            //            var paints = RetrievePaintFinishPatch(semMainPiece);
            //            semMainPiece.PaintFinishes = paints;
            //            var extrudedGeometry = BbExtrudedGeometry.RetrieveFromMainPiece(semMainPiece);
            //            semMainPiece.BbElementGeometry = extrudedGeometry;
            //            var profile = BbProfile.Retrieve(extrudedGeometry);
            //            semMainPiece.Profile = profile;

            //        }
            //    }
            //    //}
            //    //}
            //}


            return ret;

        }

        //public static List<BbPaintFinish> RetrievePaintFinishPatch(BbMainPiece mainPiece)
        //{
        //    var refed = EarlyBindingInstanceModel.GetReferencedEntities(mainPiece.IfcObject.EIN);
        //    //if (refed.Count <= 0) throw new InvalidDataException();

        //    var ret = new List<BbPaintFinish>();
        //    foreach (var p21Instance in refed)
        //    {
        //        if (p21Instance.Value.GetType() != typeof(IfcRelCoversBldgElements)) continue;
        //        var agg = p21Instance.Value as IfcRelCoversBldgElements;
        //        if (agg == null) continue;

        //        foreach (var instance in agg.RelatedCoverings)
        //        {
        //            if (instance.GetType() != typeof(IfcCovering)) continue;
        //            var paint = instance as IfcCovering;
        //            if (paint == null) continue;
        //            var paintFinishPatch = new SemPaintFinishPatch(paint, agg);
        //            ret.Add(paintFinishPatch);
        //            BbInstanceDB.AddToExport(paintFinishPatch);

        //            // Retrieve attributes and related SEMs
        //            mainPiece.IfcRelCoversBldgElements = agg;
        //            var localPlacement = BbPaintFinish.RetrieveLocalPlacement(paintFinishPatch);
        //            paintFinishPatch._bbLocalPlacement3D = localPlacement;
        //            var surfaceGeometry = BbPaintFinish.RetrieveSurfaceGeometry(paintFinishPatch);
        //            paintFinishPatch._semSurfaceGeometry = surfaceGeometry;
        //            var polyLines = BbSurfaceGeometry.RetrievePolylines(surfaceGeometry);
        //            foreach (var polyLine in polyLines)
        //            {
        //                var coordinate2D = BbPolyline2D.RetrieveCartesianPoints(polyLine);
        //            }
        //        }
        //    }
        //    return ret;
        //}
    }
}