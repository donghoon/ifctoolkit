﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using EbInstanceModel;
using IFC2X3;
using SchemaModel;
using Sem.Service;

namespace Sem.Predefined
{
    public partial class SemEm11Tester
    {
        public static bool Phase2Writer(string filename)
        {

            var em11PsetName = @"AISC_EM11_Pset_Status";
            SemHeaderSetting.Create(
                "donghoon", "Georgia Tech", "sem Tool", "alpha 1", "gatech", SemUnit.Metric);
            var floor = SemFloor.CreateSingleStoreyProject(
                "project", "site", "building", "1st floor", 0);

            // first assembly
            var assembly = SemAssembly.Create(
                "assid001",
                "Steel Assembly",
                "ASS01",
                "client_marker",
                "prelim_marker",
                "ship_mark",
                "102301123423", floor,
                SemCoordinate3D.Create(0, 0, 6000), SemDirection3D.ZAxis, SemDirection3D.XAxis);

            //var paint = PaintFinish.Create("g1001", "gal 1020", "galvanized");

            //assembly.AddPaintFinish(paint);

            //var qAss = SemQuantityRequired.Create();
            //qAss.Add(assembly);

            var profile = SemNamedIProfile.Create("AISC", "W460X260", 260, 508, 22.6, 40.4);

            // main piece
            var mainPart = SemMainPiece.Create(
                "P0001",
                "main piece", profile, 6000,
                SemCoordinate3D.Create(0, 0, -254),
                SemDirection3D.XAxis,
                SemDirection3D.YAxis,
                assembly);


            var pSet01 = SemPropertySet.Create(@"AISC_EM11_Pset_Status");
            var status01 = SemStatus.Create(pSet01, "Default", "Changed", true);
            status01.AssignTo(mainPart);

            var pSet02 = SemPropertySet.Create(@"AISC_EM11_Pset_Schedule");
            var schedule01 = SemSchedule.Create(pSet02, "seq01", "seqLevel 01", DateTime.Now);
            schedule01.AssignTo(assembly);


            //var pieceIdentity = SemPieceIdentity.Create("idmark001", "premMark001", "123456890", true);
            //pieceIdentity.AssignTo(mainPart);

            //var beamType = SemBeamType.Create("wideflange", "pm0001", IfcBeamTypeEnum.BEAM);
            //beamType.Defines(mainPart);


            //var material = SemMaterial.Create("ASTM", "A992", "ASTM A992");
            //material.AssociateTo(mainPart);

            ////var paint2 = PaintFinish.Create("p1001", "antirust", "paint");

            //var coord2d00 = SemCoordinate2D.Create(-100, 0);
            //var coord2d01 = SemCoordinate2D.Create(100, 0);
            //var coord2d02 = SemCoordinate2D.Create(100, 3400);
            //var coord2d03 = SemCoordinate2D.Create(-100, 3400);
            //var poly2d0 = SemPolyline2D.Create(new[] {coord2d00, coord2d01, coord2d02, coord2d03});


            //var coord2d10 = SemCoordinate2D.Create(-40, 1500);
            //var coord2d11 = SemCoordinate2D.Create(40, 1500);
            //var coord2d12 = SemCoordinate2D.Create(40, 2500);
            //var coord2d13 = SemCoordinate2D.Create(-40, 2500);
            //var poly2d1 = SemPolyline2D.Create(new[] {coord2d10, coord2d11, coord2d12, coord2d13});


            //var sg = SemSurfaceGeometry.Create(poly2d0, new[] {poly2d1});
            ////-----------------
            //var paint3 = SemPaintFinishPatch.Create("p1001", "antirust", "paint", sg);

            //var ploc = SemLocalPlacement3D.Create(
            //    mainPart.ObjectSemLocalPlacement,
            //    SemPosition3D.Create(
            //        SemCoordinate3D.Create(0, 254, 100),
            //        SemDirection3D.YAxis,
            //        SemDirection3D.XAxisMinus)
            //    );

            //mainPart.AddPaintFinish(paint3, ploc);


            //SemAnnotation.Create
            //    ("north", "LocationOfMark", mainPart, SemCoordinate3D.Create(0, 254, 5), SemDirection3D.YAxis,
            //        SemDirection3D.XAxisMinus);

            //SemPosition3D pos = SemPosition3D.Create(
            //    SemCoordinate3D.Create(0, 0, 300),
            //    SemDirection3D.Create(0.215665546, -0.107832773, -0.970494959),
            //    SemDirection3D.Create(-0.970494959, 0.107832773, -0.215665546)
            //    );

            //SemSkewedEnd.Create(mainPart, pos);


            ////            var arb = ArbitraryProfile.Create(poly2d0);
            ////
            ////            ExtrudedElement.Create(
            ////                "new", arb, 10, Coordinate3D.Create(0, 254, 100),
            ////                Direction3D.YAxis, Direction3D.XAxisMinus,
            ////                mainPart, typeof(IfcPlate));

            ////// TypeProduct.Create(mainPart, "main piece", typeof(IfcBeam));


            //SemCutCope.Create(mainPart, 210, 50, 10, SemCopeLocation.BottomRight);
            //SemCutCope.Create(mainPart, 210, 50, 10, SemCopeLocation.TopRight);
            ////CutCope.Create(mainPart, 210, 50, 10, CopeLocation.BottomLeft);
            ////CutCope.Create(mainPart, 210, 50, 10, CopeLocation.TopLeft);

            SemDrillHoles.Create(mainPart, SemCoordinate2D.Create(1100, 60), 30, SemHoleLocation.Bottom, false);
            SemDrillHoles.Create(mainPart, SemCoordinate2D.Create(1100, -60), 30, SemHoleLocation.Bottom, true);
            SemDrillHoles.Create(mainPart, SemCoordinate2D.Create(1200, 60), 30, SemHoleLocation.Top, true);
            SemDrillHoles.Create(mainPart, SemCoordinate2D.Create(1200, -60), 30, SemHoleLocation.Top, false);
            //DrillHoles.Create(mainPart, Coordinate2D.Create(300, 60), 15, HoleLocation.Left, false);
            //DrillHoles.Create(mainPart, Coordinate2D.Create(400, -60), 15, HoleLocation.Left, true);
            //DrillHoles.Create(mainPart, Coordinate2D.Create(500, 60), 15, HoleLocation.Right, false);
            //DrillHoles.Create(mainPart, Coordinate2D.Create(600, -60), 15, HoleLocation.Right, true);
            SemDrillHoles.Create(mainPart, SemCoordinate2D.Create(700, 60), 15, SemHoleLocation.Web, false);
            SemDrillHoles.Create(mainPart, SemCoordinate2D.Create(800, -60), 15, SemHoleLocation.Web, true);
            //DrillHoles.Create(mainPart, Coordinate2D.Create(6000 - 106.5, -100), 15, HoleLocation.Web, true);
            //DrillHoles.Create(mainPart, Coordinate2D.Create(6000 - 91.5, 100), 20, HoleLocation.Web, true);
            //DrillHoles.Create(mainPart, Coordinate2D.Create(101.5 + 5, -100), 15, HoleLocation.Web, true);
            //DrillHoles.Create(mainPart, Coordinate2D.Create(101.5 + 5, 100), 15, HoleLocation.Web, true);

           
            


            //SemSlottedHole.Create(mainPart, SemCoordinate2D.Create(3000, 50), 70, 30, SemDirection2D.RefDirection,
            //    SemHoleLocation.Web, true);

            var aProfile = SemNamedLProfile.Create("AISC", "L203X152X19", 203, 152, 19);

            var derived1 = SemDerivedProfile.Create(aProfile, false, true);
            // -90.3 for showing gap between elements
            var angle = SemClipAngle.Create(
                "a00102",
                "angle",
                derived1, 360,
                //SemCoordinate3D.Create(5898.5, 90.3, -180 - 254),
                SemCoordinate3D.Create(90.3, -180,  5898.5),
                SemDirection3D.YAxis, SemDirection3D.Axis,
                mainPart
                );

            //var w000 = SemCoordinate3D.Create(5898.5, 0, 0);
            //var w001 = SemCoordinate3D.Create(5898.5, 0, 200);
            var w000 = SemCoordinate3D.Create(5898.5, 0, 0);
            var w001 = SemCoordinate3D.Create(5898.5, 0, 200);
            var curve = SemPolyline3D.Create(new SemCoordinate3D[] {w000, w001});
            var curveGeometry = SemCurveGeometry.Create(curve);



            //DrillHoles.Create(angle, Coordinate2D.Create(100, -5), 15, HoleLocation.Bottom, false);
            //DrillHoles.Create(angle, Coordinate2D.Create(300, 10), 20, HoleLocation.Bottom, false);
            SemDrillHoles.Create(angle, SemCoordinate2D.Create(80, 9.5), 15, SemHoleLocation.Right, false);
            SemDrillHoles.Create(angle, SemCoordinate2D.Create(280, 9.5), 20, SemHoleLocation.Right, false);


            var derived = SemDerivedProfile.Create(aProfile, true, true);
            var angle2 = SemClipAngle.Create("a00103",
                "angle", derived, 360,
                //SemCoordinate3D.Create(5898.5, -90.3, -180 - 254),
                SemCoordinate3D.Create(-90.3, -180, 5898.5 ),
                //SemDirection3D.ZAxis, SemDirection3D.XAxis,
                SemDirection3D.YAxis, SemDirection3D.Axis,
                mainPart);

            //DrillHoles.Create(angle2, Coordinate2D.Create(100, -5), 15, HoleLocation.Top, false);
            //DrillHoles.Create(angle2, Coordinate2D.Create(300, 10), 20, HoleLocation.Top, false);
            SemDrillHoles.Create(angle2, SemCoordinate2D.Create(80, -9.5), 15, SemHoleLocation.Right, false);
            SemDrillHoles.Create(angle2, SemCoordinate2D.Create(280, -9.5), 20, SemHoleLocation.Right, false);

            //var qAng = SemQuantityRequired.Create();
            //qAng.Add(angle);
            //qAng.Add(angle2);


            var w1 = SemWeld.Create(mainPart, angle);
            //var w1 = SemWeld.Create("Tee Joint", mainPart, angle);
            //var w2 = Weld.Create("Tee Joint", mainPart, angle2);
            w1.AddWeldingPath(curveGeometry, SemCoordinate3D.Create(0.0,0.0,0.0));

            var pSetw1 = SemPropertySet.Create(@"AISC_EM11_Pset_Weld");

            w1.AddProperties(pSetw1, "weld id", "weld description", "wps code", "category", "weld grade", 100, false);
            w1.AddProperties(pSetw1, "weld type1", "weld type2", "weld surface1", "weld surface 2", 123, "weld process",
                1, 2, 3, 4, 5, 6, 7, 8, false, false);
            
            pSetw1.AssignTo(w1);


            var wc000 = SemCoordinate3D.Create(5898.5, 0, 0);
            var wc001 = SemCoordinate3D.Create(5898.5, 0, 200);
            var ccurve = SemPolyline3D.Create(new SemCoordinate3D[] { wc000, wc001 });
            var ccurveGeometry = SemCurveGeometry.Create(ccurve);

            var boltAss = SemBoltAssembly.Create(mainPart, angle, ccurveGeometry, SemCoordinate3D.Create(1200, 60, 0));

            var nut = SemNut.Create(boltAss);

            var nutPSetw1 = SemPropertySet.Create(@"AISC_EM11_Pset_Nut");
            nut.AddProperties(nutPSetw1, "nut standard", "nut type", 5, 3, false);
            nutPSetw1.AssignTo(nut);

            var washer1 = SemWasher.Create(boltAss);

            var washerPSetw1 = SemPropertySet.Create(@"AISC_EM11_Pset_Washer");
            nut.AddProperties(washerPSetw1, "washer standard", "washer type", 5, 2, false);
            washerPSetw1.AssignTo(washer1);

            var washer2 = SemWasher.Create(boltAss);
            var washerPSetw2 = SemPropertySet.Create(@"AISC_EM11_Pset_Washer");
            nut.AddProperties(washerPSetw2, "washer standard", "washer type", 5, 1, true);
            washerPSetw2.AssignTo(washer2);

            //w1.AddProperties();


            //var wtype = SemWeldType.Create("Tee Joint", "tj0001");
            //wtype.Defines(w1);
            //wtype.Defines(w2);


            ////var derived2 = DerivedProfile.Create(aProfile, true, false);
            ////var angle3 = SteelPiece.Create("a00104",
            ////    "angle", derived2, 400,
            ////    Coordinate3D.Create(101.5, -90.3, -200 - 254), Direction3D.ZAxis, Direction3D.XAxis, assembly,
            ////    typeof(IfcDiscreteAccessory));



            //////DrillHoles.Create(angle3, Coordinate2D.Create(100, 5), 15, HoleLocation.Top, false);
            //////DrillHoles.Create(angle3, Coordinate2D.Create(300, 5), 15, HoleLocation.Top, false);
            ////DrillHoles.Create(angle3, Coordinate2D.Create(100, -10), 15, HoleLocation.Left, false);
            ////DrillHoles.Create(angle3, Coordinate2D.Create(300, -10), 15, HoleLocation.Left, false);

            ////var angle4 = SteelPiece.Create("a00105",
            ////    "angle",  aProfile, 400,
            ////    Coordinate3D.Create(101.5, 90.3, -200 - 254), Direction3D.ZAxis, Direction3D.XAxis, assembly,
            ////    typeof(IfcDiscreteAccessory));

            //////DrillHoles.Create(angle4, Coordinate2D.Create(100, 5), 15, HoleLocation.Bottom, false);
            //////DrillHoles.Create(angle4, Coordinate2D.Create(300, 5), 15, HoleLocation.Bottom, false);
            ////DrillHoles.Create(angle4, Coordinate2D.Create(100, 10), 15, HoleLocation.Left, false);
            ////DrillHoles.Create(angle4, Coordinate2D.Create(300, 10), 15, HoleLocation.Left, false);


            //var assembly2 = SemAssembly.Create(
            //    "assid003", "Steel Assembly", "ASS02", "client_marker", "prelim_marker", "ship_mark", "202301123433",
            //    floor,
            //    SemCoordinate3D.Create(6014.3, 0, 0), SemDirection3D.ZAxis, SemDirection3D.XAxis);
            //var mainPart2 = SemMainPiece.Create("c00102",
            //    "main piece", profile, 6000,
            //    SemCoordinate3D.Origin, SemDirection3D.ZAxis, SemDirection3D.XAxis, assembly2);

            //SemDrillHoles.Create(mainPart2, SemCoordinate2D.Create(6000 - 508/2 - 100, 100), 15, SemHoleLocation.Web,
            //    false);
            //SemDrillHoles.Create(mainPart2, SemCoordinate2D.Create(6000 - 508/2 + 100, 100), 15, SemHoleLocation.Web,
            //    false);
            //SemDrillHoles.Create(mainPart2, SemCoordinate2D.Create(6000 - 508/2 - 100, -100), 15, SemHoleLocation.Web,
            //    false);
            //SemDrillHoles.Create(mainPart2, SemCoordinate2D.Create(6000 - 508/2 + 100, -100), 15, SemHoleLocation.Web,
            //    false);

            //SemSlottedHole.Create(mainPart2, SemCoordinate2D.Create(5000, 50), 100, 30, SemDirection2D.Create(0.9, 0.1),
            //    SemHoleLocation.Web, true);


            //SemConnectedElements.Create(assembly, assembly2);

            //var wp = SemWeldProperties.Create(10, 14);
            //wp.AssignTo(w1);
            //wp.AssignTo(w2);


            //var assembly3 = SemAssembly.Create(
            //    "assid003", "Steel Assembly", "ASS02", "client_marker", "prelim_marker", "ship_mark", "302301123423",
            //    floor,
            //    SemCoordinate3D.Create(-14.3, 0, 0), SemDirection3D.ZAxis, SemDirection3D.XAxis);
            //var mainPart3 = SemMainPiece.Create("c20010",
            //    "main piece", profile, 6000,
            //    SemCoordinate3D.Origin, SemDirection3D.ZAxis, SemDirection3D.XAxis, assembly3);
            //SemDrillHoles.Create(mainPart3, SemCoordinate2D.Create(6000 - 508/2 - 100, 100), 15, SemHoleLocation.Web,
            //    false);
            //SemDrillHoles.Create(mainPart3, SemCoordinate2D.Create(6000 - 508/2 + 100, 100), 15, SemHoleLocation.Web,
            //    false);
            //SemDrillHoles.Create(mainPart3, SemCoordinate2D.Create(6000 - 508/2 - 100, -100), 15, SemHoleLocation.Web,
            //    false);
            //SemDrillHoles.Create(mainPart3, SemCoordinate2D.Create(6000 - 508/2 + 100, -100), 15, SemHoleLocation.Web,
            //    false);

            //var rect = SemNamedRectangleProfile.Create(400, 300);
            //SemExtrudedElement.Create(
            //    "new", rect, 5000, SemCoordinate3D.Create(0, 4000, 0), SemDirection3D.ZAxis, SemDirection3D.XAxis,
            //    floor, typeof (IfcColumn));

            //SemExtrudedElement.Create(
            //    "new", rect, 5000, SemCoordinate3D.Create(6000, 4000, 0), SemDirection3D.ZAxis, SemDirection3D.XAxis,
            //    floor, typeof (IfcColumn));

            //SemExtrudedElement.Create(
            //    "new", rect, 6000 + 400, SemCoordinate3D.Create(-200, 4000, 5210),
            //    SemDirection3D.XAxis, SemDirection3D.ZAxisMinus,
            //    floor, typeof (IfcBeam));



            //var faces = new List<SemFace>();

            //var p000 = SemCoordinate3D.Create(-300, -300, 0);
            //var p100 = SemCoordinate3D.Create(300, -300, 0);
            //var p110 = SemCoordinate3D.Create(300, 300, 0);
            //var p010 = SemCoordinate3D.Create(-300, 300, 0);

            //var p001 = SemCoordinate3D.Create(-100, -100, 4000);
            //var p101 = SemCoordinate3D.Create(100, -100, 4000);
            //var p111 = SemCoordinate3D.Create(100, 100, 4000);
            //var p011 = SemCoordinate3D.Create(-100, 100, 4000);


            //faces.Add(SemFace.Create(new List<SemCoordinate3D>()
            //{
            //    p000,
            //    p010,
            //    p110,
            //    p100
            //}));
            //faces.Add(SemFace.Create(new List<SemCoordinate3D>()
            //{
            //    p000,
            //    p100,
            //    p101,
            //    p001
            //}));

            //faces.Add(SemFace.Create(new List<SemCoordinate3D>()
            //{
            //    p000,
            //    p001,
            //    p011,
            //    p010
            //}));

            //faces.Add(SemFace.Create(new List<SemCoordinate3D>()
            //{
            //    p010,
            //    p011,
            //    p111,
            //    p110
            //}));

            //faces.Add(SemFace.Create(new List<SemCoordinate3D>()
            //{
            //    p100,
            //    p110,
            //    p111,
            //    p101
            //}));

            //faces.Add(SemFace.Create(new List<SemCoordinate3D>()
            //{
            //    p001,
            //    p101,
            //    p111,
            //    p011
            //}));

            //var brep = SemBRepGeometry.Create(faces);

            //var belem = SemBrepElement.Create("brep", brep, SemCoordinate3D.Create(0, 8000, 0), SemDirection3D.ZAxis,
            //    SemDirection3D.XAxis,
            //    floor, typeof (IfcColumn));


            //var sp1 = SemSingleProperty.Create("test", "valueTest", true);
            //var sp2 = SemSingleProperty.Create("test string", "string valueTest", false);

            //var sp3 = SemSingleProperty.Create("realtest", 10.0, typeof (IfcPositiveLengthMeasure));

            //var pset = SemPropertySet.Create("id", "semdid");

            //pset.AddProperty(sp1);
            //pset.AddProperty(sp2);
            //pset.AddProperty(sp3);

            //pset.AssignTo(belem);
            return SemInstanceDB.Write(filename);



        }



        public static bool Phase2Reader(string filename)
        {
            SemInstanceDB.Reset();

            EarlyBindingInstanceModel.Reset();

            if (!EarlyBindingInstanceModel.Read(RegisteredSchema.IFC2X3, filename))
                return false;

            SemHeaderSetting.Retrieve();
            SemProject.Retrieve();
            SemSite.Retrieve();
            SemBuilding.Retrieve();
            SemFloor.Retrieve();


            return false;
        }
    }
}