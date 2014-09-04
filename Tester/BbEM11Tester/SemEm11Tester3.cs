using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackBox.Service;
using EbInstanceModel;
using IFC2X3;
using SchemaModel;

namespace BlackBox.Predefined
{
    public partial class SemEm11Tester
    {
        public static bool Phase2Writer(string filename)
        {
            BbInstanceDB.Reset();

            //var em11PsetName = @"AISC_EM11_Pset_Status";
            BbHeaderSetting.Create(
                "donghoon", "Georgia Tech", "sem Tool", "alpha 1", "gatech", BbUnit.Metric);
            var floor = BbFloor.CreateSingleStoreyProject(
                "project", "site", "building", "1st floor", 0);

            // first assembly
            var assembly = BbAssembly.Create(
                "assid001",
                "Steel Assembly",
                "ASS01",
                "client_marker",
                "prelim_marker",
                "ship_mark",
                "102301123423", floor,
                BbCoordinate3D.Create(0, 0, 6000), BbHeaderSetting.Setting3D.ZAxis, BbHeaderSetting.Setting3D.XAxis);

            //var paint = PaintFinish.Create("g1001", "gal 1020", "galvanized");

            //assembly.AddPaintFinish(paint);

            //var qAss = BbQuantityRequired.Create();
            //qAss.Add(assembly);

            var profile = BbNamedIProfile.Create("AISC", "W460X260", 260, 508, 22.6, 40.4);

            // main piece
            var mainPart = BbMainPiece.Create(
                "P0001",
                "main piece", profile, 6000,
                BbCoordinate3D.Create(0, 0, -254),
                BbHeaderSetting.Setting3D.XAxis,
                BbHeaderSetting.Setting3D.YAxis,
                assembly);


            var pSet01 = BbPropertySet.Create(@"AISC_EM11_Pset_Status");
            var status01 = BbStatus.Create(pSet01, "Default", "Changed", true);
            status01.AssignTo(mainPart);

            var pSet02 = BbPropertySet.Create(@"AISC_EM11_Pset_Schedule");
            var schedule01 = BbSchedule.Create(pSet02, "seq01", "seqLevel 01", DateTime.Now);
            schedule01.AssignTo(assembly);


            //var pieceIdentity = BbPieceIdentity.Create("idmark001", "premMark001", "123456890", true);
            //pieceIdentity.AssignTo(mainPart);

            //var beamType = SemBeamType.Create("wideflange", "pm0001", IfcBeamTypeEnum.BEAM);
            //beamType.Defines(mainPart);


            //var material = BbMaterial.Create("ASTM", "A992", "ASTM A992");
            //material.AssociateTo(mainPart);

            ////var paint2 = PaintFinish.Create("p1001", "antirust", "paint");

            //var coord2d00 = BbCoordinate2D.Create(-100, 0);
            //var coord2d01 = BbCoordinate2D.Create(100, 0);
            //var coord2d02 = BbCoordinate2D.Create(100, 3400);
            //var coord2d03 = BbCoordinate2D.Create(-100, 3400);
            //var poly2d0 = BbPolyline2D.Create(new[] {coord2d00, coord2d01, coord2d02, coord2d03});


            //var coord2d10 = BbCoordinate2D.Create(-40, 1500);
            //var coord2d11 = BbCoordinate2D.Create(40, 1500);
            //var coord2d12 = BbCoordinate2D.Create(40, 2500);
            //var coord2d13 = BbCoordinate2D.Create(-40, 2500);
            //var poly2d1 = BbPolyline2D.Create(new[] {coord2d10, coord2d11, coord2d12, coord2d13});


            //var sg = BbSurfaceGeometry.Create(poly2d0, new[] {poly2d1});
            ////-----------------
            //var paint3 = SemPaintFinishPatch.Create("p1001", "antirust", "paint", sg);

            //var ploc = BbLocalPlacement3D.Create(
            //    mainPart.ObjectBbLocalPlacement,
            //    BbPosition3D.Create(
            //        BbCoordinate3D.Create(0, 254, 100),
            //        BbDirection3D.YAxis2D,
            //        BbDirection3D.XAxisMinus2D)
            //    );

            //mainPart.AddPaintFinish(paint3, ploc);


            //SemAnnotation.Create
            //    ("north", "LocationOfMark", mainPart, BbCoordinate3D.Create(0, 254, 5), BbDirection3D.YAxis2D,
            //        BbDirection3D.XAxisMinus2D);

            //BbPosition3D pos = BbPosition3D.Create(
            //    BbCoordinate3D.Create(0, 0, 300),
            //    BbDirection3D.Create(0.215665546, -0.107832773, -0.970494959),
            //    BbDirection3D.Create(-0.970494959, 0.107832773, -0.215665546)
            //    );

            //BbSkewedEnd.Create(mainPart, pos);


            ////            var arb = ArbitraryProfile.Create(poly2d0);
            ////
            ////            ExtrudedElement.Create(
            ////                "new", arb, 10, Coordinate3D.Create(0, 254, 100),
            ////                Direction3D.YAxis2D, Direction3D.XAxisMinus2D,
            ////                mainPart, typeof(IfcPlate));

            ////// TypeProduct.Create(mainPart, "main piece", typeof(IfcBeam));


            //BbCutCope.Create(mainPart, 210, 50, 10, SemCopeLocation.BottomRight);
            //BbCutCope.Create(mainPart, 210, 50, 10, SemCopeLocation.TopRight);
            ////CutCope.Create(mainPart, 210, 50, 10, CopeLocation.BottomLeft);
            ////CutCope.Create(mainPart, 210, 50, 10, CopeLocation.TopLeft);

            BbDrillHoles.Create(mainPart, BbCoordinate2D.Create(1100, 60), 30, SemHoleLocation.Bottom, false);
            BbDrillHoles.Create(mainPart, BbCoordinate2D.Create(1100, -60), 30, SemHoleLocation.Bottom, true);
            BbDrillHoles.Create(mainPart, BbCoordinate2D.Create(1200, 60), 30, SemHoleLocation.Top, true);
            BbDrillHoles.Create(mainPart, BbCoordinate2D.Create(1200, -60), 30, SemHoleLocation.Top, false);
            //DrillHoles.Create(mainPart, Coordinate2D.Create(300, 60), 15, HoleLocation.Left, false);
            //DrillHoles.Create(mainPart, Coordinate2D.Create(400, -60), 15, HoleLocation.Left, true);
            //DrillHoles.Create(mainPart, Coordinate2D.Create(500, 60), 15, HoleLocation.Right, false);
            //DrillHoles.Create(mainPart, Coordinate2D.Create(600, -60), 15, HoleLocation.Right, true);
            BbDrillHoles.Create(mainPart, BbCoordinate2D.Create(700, 60), 15, SemHoleLocation.Web, false);
            BbDrillHoles.Create(mainPart, BbCoordinate2D.Create(800, -60), 15, SemHoleLocation.Web, true);
            //DrillHoles.Create(mainPart, Coordinate2D.Create(6000 - 106.5, -100), 15, HoleLocation.Web, true);
            //DrillHoles.Create(mainPart, Coordinate2D.Create(6000 - 91.5, 100), 20, HoleLocation.Web, true);
            //DrillHoles.Create(mainPart, Coordinate2D.Create(101.5 + 5, -100), 15, HoleLocation.Web, true);
            //DrillHoles.Create(mainPart, Coordinate2D.Create(101.5 + 5, 100), 15, HoleLocation.Web, true);

           
            


            //BbSlottedHole.Create(mainPart, BbCoordinate2D.Create(3000, 50), 70, 30, BbDirection2D.RefDirection2D,
            //    SemHoleLocation.Web, true);

            var aProfile = BbNamedLProfile.Create("AISC", "L203X152X19", 203, 152, 19);

            var derived1 = BbDerivedProfile.Create(aProfile, false, true);
            // -90.3 for showing gap between elements
            var angle = BbClipAngle.Create(
                "a00102",
                "angle",
                derived1, 360,
                //BbCoordinate3D.Create(5898.5, 90.3, -180 - 254),
                BbCoordinate3D.Create(90.3, -180,  5898.5),
                BbHeaderSetting.Setting3D.YAxis, BbHeaderSetting.Setting3D.Axis,
                mainPart
                );

            //var w000 = BbCoordinate3D.Create(5898.5, 0, 0);
            //var w001 = BbCoordinate3D.Create(5898.5, 0, 200);
            var w000 = BbCoordinate3D.Create(5898.5, 0, 0);
            var w001 = BbCoordinate3D.Create(5898.5, 0, 200);
            var curve = BbPolyline3D.Create(new BbCoordinate3D[] {w000, w001});
            var curveGeometry = BbCurveGeometry.Create(curve);



            //DrillHoles.Create(angle, Coordinate2D.Create(100, -5), 15, HoleLocation.Bottom, false);
            //DrillHoles.Create(angle, Coordinate2D.Create(300, 10), 20, HoleLocation.Bottom, false);
            BbDrillHoles.Create(angle, BbCoordinate2D.Create(80, 9.5), 15, SemHoleLocation.Right, false);
            BbDrillHoles.Create(angle, BbCoordinate2D.Create(280, 9.5), 20, SemHoleLocation.Right, false);


            var derived = BbDerivedProfile.Create(aProfile, true, true);
            var angle2 = BbClipAngle.Create("a00103",
                "angle", derived, 360,
                //BbCoordinate3D.Create(5898.5, -90.3, -180 - 254),
                BbCoordinate3D.Create(-90.3, -180, 5898.5 ),
                //BbDirection3D.ZAxis, BbDirection3D.XAxis2D,
                BbHeaderSetting.Setting3D.YAxis, BbHeaderSetting.Setting3D.Axis,
                mainPart);

            //DrillHoles.Create(angle2, Coordinate2D.Create(100, -5), 15, HoleLocation.Top, false);
            //DrillHoles.Create(angle2, Coordinate2D.Create(300, 10), 20, HoleLocation.Top, false);
            BbDrillHoles.Create(angle2, BbCoordinate2D.Create(80, -9.5), 15, SemHoleLocation.Right, false);
            BbDrillHoles.Create(angle2, BbCoordinate2D.Create(280, -9.5), 20, SemHoleLocation.Right, false);

            //var qAng = BbQuantityRequired.Create();
            //qAng.Add(angle);
            //qAng.Add(angle2);


            var w1 = BbWeld.Create(mainPart, angle);
            //var w1 = BbWeld.Create("Tee Joint", mainPart, angle);
            //var w2 = Weld.Create("Tee Joint", mainPart, angle2);
            w1.AddWeldingPath(curveGeometry, BbCoordinate3D.Create(0.0,0.0,0.0));

            var pSetw1 = BbPropertySet.Create(@"AISC_EM11_Pset_Weld");

            w1.AddProperties(pSetw1, "weld id", "weld description", "wps code", "category", "weld grade", 100, false);
            w1.AddProperties(pSetw1, "weld type1", "weld type2", "weld surface1", "weld surface 2", 123, "weld process",
                1, 2, 3, 4, 5, 6, 7, 8, false, false);
            
            pSetw1.AssignTo(w1);


            var wc000 = BbCoordinate3D.Create(5898.5, 0, 0);
            var wc001 = BbCoordinate3D.Create(5898.5, 0, 200);
            var ccurve = BbPolyline3D.Create(new BbCoordinate3D[] { wc000, wc001 });
            var ccurveGeometry = BbCurveGeometry.Create(ccurve);

            var boltAss = BbBoltAssembly.Create(mainPart, angle, ccurveGeometry, BbCoordinate3D.Create(1200, 60, 0));

            var nut = BbNut.Create(boltAss);

            var nutPSetw1 = BbPropertySet.Create(@"AISC_EM11_Pset_Nut");
            nut.AddProperties(nutPSetw1, "nut standard", "nut type", 5, 3, false);
            nutPSetw1.AssignTo(nut);

            var washer1 = BbWasher.Create(boltAss);

            var washerPSetw1 = BbPropertySet.Create(@"AISC_EM11_Pset_Washer");
            nut.AddProperties(washerPSetw1, "washer standard", "washer type", 5, 2, false);
            washerPSetw1.AssignTo(washer1);

            var washer2 = BbWasher.Create(boltAss);
            var washerPSetw2 = BbPropertySet.Create(@"AISC_EM11_Pset_Washer");
            nut.AddProperties(washerPSetw2, "washer standard", "washer type", 5, 1, true);
            washerPSetw2.AssignTo(washer2);

            //w1.AddProperties();


            //var wtype = SemWeldType.Create("Tee Joint", "tj0001");
            //wtype.Defines(w1);
            //wtype.Defines(w2);


            ////var derived2 = DerivedProfile.Create(aProfile, true, false);
            ////var angle3 = SteelPiece.Create("a00104",
            ////    "angle", derived2, 400,
            ////    Coordinate3D.Create(101.5, -90.3, -200 - 254), Direction3D.ZAxis, Direction3D.XAxis2D, assembly,
            ////    typeof(IfcDiscreteAccessory));



            //////DrillHoles.Create(angle3, Coordinate2D.Create(100, 5), 15, HoleLocation.Top, false);
            //////DrillHoles.Create(angle3, Coordinate2D.Create(300, 5), 15, HoleLocation.Top, false);
            ////DrillHoles.Create(angle3, Coordinate2D.Create(100, -10), 15, HoleLocation.Left, false);
            ////DrillHoles.Create(angle3, Coordinate2D.Create(300, -10), 15, HoleLocation.Left, false);

            ////var angle4 = SteelPiece.Create("a00105",
            ////    "angle",  aProfile, 400,
            ////    Coordinate3D.Create(101.5, 90.3, -200 - 254), Direction3D.ZAxis, Direction3D.XAxis2D, assembly,
            ////    typeof(IfcDiscreteAccessory));

            //////DrillHoles.Create(angle4, Coordinate2D.Create(100, 5), 15, HoleLocation.Bottom, false);
            //////DrillHoles.Create(angle4, Coordinate2D.Create(300, 5), 15, HoleLocation.Bottom, false);
            ////DrillHoles.Create(angle4, Coordinate2D.Create(100, 10), 15, HoleLocation.Left, false);
            ////DrillHoles.Create(angle4, Coordinate2D.Create(300, 10), 15, HoleLocation.Left, false);


            //var assembly2 = BbAssembly.Create(
            //    "assid003", "Steel Assembly", "ASS02", "client_marker", "prelim_marker", "ship_mark", "202301123433",
            //    floor,
            //    BbCoordinate3D.Create(6014.3, 0, 0), BbDirection3D.ZAxis, BbDirection3D.XAxis2D);
            //var mainPart2 = BbMainPiece.Create("c00102",
            //    "main piece", profile, 6000,
            //    BbCoordinate3D.DefaultOrigin, BbDirection3D.ZAxis, BbDirection3D.XAxis2D, assembly2);

            //BbDrillHoles.Create(mainPart2, BbCoordinate2D.Create(6000 - 508/2 - 100, 100), 15, SemHoleLocation.Web,
            //    false);
            //BbDrillHoles.Create(mainPart2, BbCoordinate2D.Create(6000 - 508/2 + 100, 100), 15, SemHoleLocation.Web,
            //    false);
            //BbDrillHoles.Create(mainPart2, BbCoordinate2D.Create(6000 - 508/2 - 100, -100), 15, SemHoleLocation.Web,
            //    false);
            //BbDrillHoles.Create(mainPart2, BbCoordinate2D.Create(6000 - 508/2 + 100, -100), 15, SemHoleLocation.Web,
            //    false);

            //BbSlottedHole.Create(mainPart2, BbCoordinate2D.Create(5000, 50), 100, 30, BbDirection2D.Create(0.9, 0.1),
            //    SemHoleLocation.Web, true);


            //SemConnectedElements.Create(assembly, assembly2);

            //var wp = BbWeldProperties.Create(10, 14);
            //wp.AssignTo(w1);
            //wp.AssignTo(w2);


            //var assembly3 = BbAssembly.Create(
            //    "assid003", "Steel Assembly", "ASS02", "client_marker", "prelim_marker", "ship_mark", "302301123423",
            //    floor,
            //    BbCoordinate3D.Create(-14.3, 0, 0), BbDirection3D.ZAxis, BbDirection3D.XAxis2D);
            //var mainPart3 = BbMainPiece.Create("c20010",
            //    "main piece", profile, 6000,
            //    BbCoordinate3D.DefaultOrigin, BbDirection3D.ZAxis, BbDirection3D.XAxis2D, assembly3);
            //BbDrillHoles.Create(mainPart3, BbCoordinate2D.Create(6000 - 508/2 - 100, 100), 15, SemHoleLocation.Web,
            //    false);
            //BbDrillHoles.Create(mainPart3, BbCoordinate2D.Create(6000 - 508/2 + 100, 100), 15, SemHoleLocation.Web,
            //    false);
            //BbDrillHoles.Create(mainPart3, BbCoordinate2D.Create(6000 - 508/2 - 100, -100), 15, SemHoleLocation.Web,
            //    false);
            //BbDrillHoles.Create(mainPart3, BbCoordinate2D.Create(6000 - 508/2 + 100, -100), 15, SemHoleLocation.Web,
            //    false);

            //var rect = BbNamedRectangleProfile.Create(400, 300);
            //BbExtrudedElement.Create(
            //    "new", rect, 5000, BbCoordinate3D.Create(0, 4000, 0), BbDirection3D.ZAxis, BbDirection3D.XAxis2D,
            //    floor, typeof (IfcColumn));

            //BbExtrudedElement.Create(
            //    "new", rect, 5000, BbCoordinate3D.Create(6000, 4000, 0), BbDirection3D.ZAxis, BbDirection3D.XAxis2D,
            //    floor, typeof (IfcColumn));

            //BbExtrudedElement.Create(
            //    "new", rect, 6000 + 400, BbCoordinate3D.Create(-200, 4000, 5210),
            //    BbDirection3D.XAxis2D, BbDirection3D.ZAxisMinus,
            //    floor, typeof (IfcBeam));



            //var faces = new List<BbFace>();

            //var p000 = BbCoordinate3D.Create(-300, -300, 0);
            //var p100 = BbCoordinate3D.Create(300, -300, 0);
            //var p110 = BbCoordinate3D.Create(300, 300, 0);
            //var p010 = BbCoordinate3D.Create(-300, 300, 0);

            //var p001 = BbCoordinate3D.Create(-100, -100, 4000);
            //var p101 = BbCoordinate3D.Create(100, -100, 4000);
            //var p111 = BbCoordinate3D.Create(100, 100, 4000);
            //var p011 = BbCoordinate3D.Create(-100, 100, 4000);


            //faces.Add(BbFace.Create(new List<BbCoordinate3D>()
            //{
            //    p000,
            //    p010,
            //    p110,
            //    p100
            //}));
            //faces.Add(BbFace.Create(new List<BbCoordinate3D>()
            //{
            //    p000,
            //    p100,
            //    p101,
            //    p001
            //}));

            //faces.Add(BbFace.Create(new List<BbCoordinate3D>()
            //{
            //    p000,
            //    p001,
            //    p011,
            //    p010
            //}));

            //faces.Add(BbFace.Create(new List<BbCoordinate3D>()
            //{
            //    p010,
            //    p011,
            //    p111,
            //    p110
            //}));

            //faces.Add(BbFace.Create(new List<BbCoordinate3D>()
            //{
            //    p100,
            //    p110,
            //    p111,
            //    p101
            //}));

            //faces.Add(BbFace.Create(new List<BbCoordinate3D>()
            //{
            //    p001,
            //    p101,
            //    p111,
            //    p011
            //}));

            //var brep = BbBRepGeometry.Create(faces);

            //var belem = BbBrepElement.Create("brep", brep, BbCoordinate3D.Create(0, 8000, 0), BbDirection3D.ZAxis,
            //    BbDirection3D.XAxis2D,
            //    floor, typeof (IfcColumn));


            //var sp1 = BbSingleProperty.Create("test", "valueTest", true);
            //var sp2 = BbSingleProperty.Create("test string", "string valueTest", false);

            //var sp3 = BbSingleProperty.Create("realtest", 10.0, typeof (IfcPositiveLengthMeasure));

            //var pset = BbPropertySet.Create("id", "semdid");

            //pset.AddProperty(sp1);
            //pset.AddProperty(sp2);
            //pset.AddProperty(sp3);

            //pset.AssignTo(belem);
            return BbInstanceDB.Write(filename);



        }



        public static bool Phase2Reader(string filename)
        {
            BbInstanceDB.Reset();

            EarlyBindingInstanceModel.Reset();

            if (!EarlyBindingInstanceModel.Read(RegisteredSchema.IFC2X3, filename))
                return false;

            BbHeaderSetting.Retrieve();
            BbProject.Retrieve();
            BbSite.Retrieve();
            BbBuilding.Retrieve();
            BbFloor.Retrieve();


            return false;
        }
    }
}