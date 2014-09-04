using System;
using System.Collections.Generic;
using System.ComponentModel;
using EbInstanceModel;
using IFC2X3;
using SchemaModel;
using BlackBox.Service;

namespace BlackBox.Predefined
{
    public partial class SemEm11Tester
    {
        public static bool WriteTest(string filename)
        {
        //    var headerSetting = BbHeaderSetting.Create(
        //        "donghoon", "Georgia Tech", "sem Tool", "alpha 1", "gatech", BbUnit.Metric);
        //    var floor = BbFloor.CreateSingleStoreyProject(
        //        "project", "site", "building", "1st floor", 0);

        //    // first assembly
        //    var assembly = BbAssembly.Create(
        //        "assid001",
        //        "Steel Assembly",
        //        "ASS01",
        //        "client_marker",
        //        "prelim_marker",
        //        "ship_mark",
        //        "102301123423", floor,
        //        BbCoordinate3D.Create(0, 0, 6000), BbDirection3D.ZAxis, BbDirection3D.XAxis2D);

        //    var paint = PaintFinish.Create("g1001", "gal 1020", "galvanized");

        //    assembly.AddPaintFinish(paint);

        //    var qAss = BbQuantityRequired.Create();
        //    qAss.Add(assembly);

        //    var profile = BbNamedIProfile.Create("AISC", "W460X260", 260, 508, 22.6, 40.4);

        //    // main piece
        //    var mainPart = BbMainPiece.Create(
        //        "P0001",
        //        "main piece", profile, 6000,
        //        BbCoordinate3D.Create(0, 0, -254),
        //        BbDirection3D.XAxis2D,
        //        BbDirection3D.YAxis2D,
        //        assembly);




        //    var pieceIdentity = BbPieceIdentity.Create("idmark001", "premMark001", "123456890", true);
        //    pieceIdentity.AssignTo(mainPart);

        //    var beamType = SemBeamType.Create("wideflange", "pm0001", IfcBeamTypeEnum.BEAM);
        //    beamType.Defines(mainPart);


        //    var material = BbMaterial.Create("ASTM", "A992", "ASTM A992");
        //    material.AssociateTo(mainPart);

        //    //var paint2 = PaintFinish.Create("p1001", "antirust", "paint");

        //    var coord2d00 = BbCoordinate2D.Create(-100, 0);
        //    var coord2d01 = BbCoordinate2D.Create(100, 0);
        //    var coord2d02 = BbCoordinate2D.Create(100, 3400);
        //    var coord2d03 = BbCoordinate2D.Create(-100, 3400);
        //    var poly2d0 = BbPolyline2D.Create(new[] { coord2d00, coord2d01, coord2d02, coord2d03 });


        //    var coord2d10 = BbCoordinate2D.Create(-40, 1500);
        //    var coord2d11 = BbCoordinate2D.Create(40, 1500);
        //    var coord2d12 = BbCoordinate2D.Create(40, 2500);
        //    var coord2d13 = BbCoordinate2D.Create(-40, 2500);
        //    var poly2d1 = BbPolyline2D.Create(new[] { coord2d10, coord2d11, coord2d12, coord2d13 });


        //    var sg = BbSurfaceGeometry.Create(poly2d0, new[] { poly2d1 });
        //    //-----------------
        //    var paint3 = SemPaintFinishPatch.Create("p1001", "antirust", "paint", sg);

        //    var ploc = BbLocalPlacement3D.Create(
        //        mainPart.ObjectBbLocalPlacement,
        //        BbPosition3D.Create(
        //        BbCoordinate3D.Create(0, 254, 100),
        //        BbDirection3D.YAxis2D,
        //        BbDirection3D.XAxisMinus2D)
        //        );

        //    mainPart.AddPaintFinish(paint3, ploc);


        //    SemAnnotation.Create
        //        ("north", "LocationOfMark", mainPart, BbCoordinate3D.Create(0, 254, 5), BbDirection3D.YAxis2D, BbDirection3D.XAxisMinus2D);

        //    BbPosition3D pos = BbPosition3D.Create(
        //        BbCoordinate3D.Create(0, 0, 300),
        //        BbDirection3D.Create(0.215665546, -0.107832773, -0.970494959),
        //        BbDirection3D.Create(-0.970494959, 0.107832773, -0.215665546)
        //        );

        //    BbSkewedEnd.Create(mainPart, pos);


        //    //            var arb = ArbitraryProfile.Create(poly2d0);
        //    //
        //    //            ExtrudedElement.Create(
        //    //                "new", arb, 10, Coordinate3D.Create(0, 254, 100),
        //    //                Direction3D.YAxis2D, Direction3D.XAxisMinus2D,
        //    //                mainPart, typeof(IfcPlate));

        //    //// TypeProduct.Create(mainPart, "main piece", typeof(IfcBeam));


        //    BbCutCope.Create(mainPart, 210, 50, 10, SemCopeLocation.BottomRight);
        //    BbCutCope.Create(mainPart, 210, 50, 10, SemCopeLocation.TopRight);
        //    //CutCope.Create(mainPart, 210, 50, 10, CopeLocation.BottomLeft);
        //    //CutCope.Create(mainPart, 210, 50, 10, CopeLocation.TopLeft);

        //    BbDrillHoles.Create(mainPart, BbCoordinate2D.Create(1100, 60), 30, SemHoleLocation.Bottom, false);
        //    BbDrillHoles.Create(mainPart, BbCoordinate2D.Create(1100, -60), 30, SemHoleLocation.Bottom, true);
        //    BbDrillHoles.Create(mainPart, BbCoordinate2D.Create(1200, 60), 30, SemHoleLocation.Top, true);
        //    BbDrillHoles.Create(mainPart, BbCoordinate2D.Create(1200, -60), 30, SemHoleLocation.Top, false);
        //    //DrillHoles.Create(mainPart, Coordinate2D.Create(300, 60), 15, HoleLocation.Left, false);
        //    //DrillHoles.Create(mainPart, Coordinate2D.Create(400, -60), 15, HoleLocation.Left, true);
        //    //DrillHoles.Create(mainPart, Coordinate2D.Create(500, 60), 15, HoleLocation.Right, false);
        //    //DrillHoles.Create(mainPart, Coordinate2D.Create(600, -60), 15, HoleLocation.Right, true);
        //    BbDrillHoles.Create(mainPart, BbCoordinate2D.Create(700, 60), 15, SemHoleLocation.Web, false);
        //    BbDrillHoles.Create(mainPart, BbCoordinate2D.Create(800, -60), 15, SemHoleLocation.Web, true);
        //    //DrillHoles.Create(mainPart, Coordinate2D.Create(6000 - 106.5, -100), 15, HoleLocation.Web, true);
        //    //DrillHoles.Create(mainPart, Coordinate2D.Create(6000 - 91.5, 100), 20, HoleLocation.Web, true);
        //    //DrillHoles.Create(mainPart, Coordinate2D.Create(101.5 + 5, -100), 15, HoleLocation.Web, true);
        //    //DrillHoles.Create(mainPart, Coordinate2D.Create(101.5 + 5, 100), 15, HoleLocation.Web, true);


        //    BbSlottedHole.Create(mainPart, BbCoordinate2D.Create(3000, 50), 70, 30, BbDirection2D.RefDirection2D, SemHoleLocation.Web, true);

        //    var aProfile = BbNamedLProfile.Create("AISC", "L203X152X19", 203, 152, 19);

        //    var derived1 = BbDerivedProfile.Create(aProfile, false, true);
        //    // -90.3 for showing gap between elements
        //    var angle = BbClipAngle.Create(
        //        "a00102",
        //        "angle",

        //        derived1, 360,
        //        BbCoordinate3D.Create(5898.5, 90.3, -180 - 254), BbDirection3D.ZAxis, BbDirection3D.XAxis2D, assembly
        //        );



        //    //DrillHoles.Create(angle, Coordinate2D.Create(100, -5), 15, HoleLocation.Bottom, false);
        //    //DrillHoles.Create(angle, Coordinate2D.Create(300, 10), 20, HoleLocation.Bottom, false);
        //    BbDrillHoles.Create(angle, BbCoordinate2D.Create(80, 9.5), 15, SemHoleLocation.Right, false);
        //    BbDrillHoles.Create(angle, BbCoordinate2D.Create(280, 9.5), 20, SemHoleLocation.Right, false);


        //    var derived = BbDerivedProfile.Create(aProfile, true, true);
        //    var angle2 = BbClipAngle.Create("a00103",
        //        "angle", derived, 360,
        //        BbCoordinate3D.Create(5898.5, -90.3, -180 - 254), BbDirection3D.ZAxis, BbDirection3D.XAxis2D, assembly);

        //    //DrillHoles.Create(angle2, Coordinate2D.Create(100, -5), 15, HoleLocation.Top, false);
        //    //DrillHoles.Create(angle2, Coordinate2D.Create(300, 10), 20, HoleLocation.Top, false);
        //    BbDrillHoles.Create(angle2, BbCoordinate2D.Create(80, -9.5), 15, SemHoleLocation.Right, false);
        //    BbDrillHoles.Create(angle2, BbCoordinate2D.Create(280, -9.5), 20, SemHoleLocation.Right, false);

        //    var qAng = BbQuantityRequired.Create();
        //    qAng.Add(angle);
        //    qAng.Add(angle2);



        //    var w1 = BbWeld.Create("Tee Joint", mainPart, angle);
        //    var w2 = BbWeld.Create("Tee Joint", mainPart, angle2);





        //    var wtype = SemWeldType.Create("Tee Joint", "tj0001");
        //    wtype.Defines(w1);
        //    wtype.Defines(w2);


        //    //var derived2 = DerivedProfile.Create(aProfile, true, false);
        //    //var angle3 = SteelPiece.Create("a00104",
        //    //    "angle", derived2, 400,
        //    //    Coordinate3D.Create(101.5, -90.3, -200 - 254), Direction3D.ZAxis, Direction3D.XAxis2D, assembly,
        //    //    typeof(IfcDiscreteAccessory));



        //    ////DrillHoles.Create(angle3, Coordinate2D.Create(100, 5), 15, HoleLocation.Top, false);
        //    ////DrillHoles.Create(angle3, Coordinate2D.Create(300, 5), 15, HoleLocation.Top, false);
        //    //DrillHoles.Create(angle3, Coordinate2D.Create(100, -10), 15, HoleLocation.Left, false);
        //    //DrillHoles.Create(angle3, Coordinate2D.Create(300, -10), 15, HoleLocation.Left, false);

        //    //var angle4 = SteelPiece.Create("a00105",
        //    //    "angle",  aProfile, 400,
        //    //    Coordinate3D.Create(101.5, 90.3, -200 - 254), Direction3D.ZAxis, Direction3D.XAxis2D, assembly,
        //    //    typeof(IfcDiscreteAccessory));

        //    ////DrillHoles.Create(angle4, Coordinate2D.Create(100, 5), 15, HoleLocation.Bottom, false);
        //    ////DrillHoles.Create(angle4, Coordinate2D.Create(300, 5), 15, HoleLocation.Bottom, false);
        //    //DrillHoles.Create(angle4, Coordinate2D.Create(100, 10), 15, HoleLocation.Left, false);
        //    //DrillHoles.Create(angle4, Coordinate2D.Create(300, 10), 15, HoleLocation.Left, false);


        //    var assembly2 = BbAssembly.Create(
        //        "assid003", "Steel Assembly", "ASS02", "client_marker", "prelim_marker", "ship_mark", "202301123433", floor,
        //        BbCoordinate3D.Create(6014.3, 0, 0), BbDirection3D.ZAxis, BbDirection3D.XAxis2D);
        //    var mainPart2 = BbMainPiece.Create("c00102",
        //        "main piece", profile, 6000,
        //        BbCoordinate3D.DefaultOrigin, BbDirection3D.ZAxis, BbDirection3D.XAxis2D, assembly2);

        //    BbDrillHoles.Create(mainPart2, BbCoordinate2D.Create(6000 - 508 / 2 - 100, 100), 15, SemHoleLocation.Web, false);
        //    BbDrillHoles.Create(mainPart2, BbCoordinate2D.Create(6000 - 508 / 2 + 100, 100), 15, SemHoleLocation.Web, false);
        //    BbDrillHoles.Create(mainPart2, BbCoordinate2D.Create(6000 - 508 / 2 - 100, -100), 15, SemHoleLocation.Web, false);
        //    BbDrillHoles.Create(mainPart2, BbCoordinate2D.Create(6000 - 508 / 2 + 100, -100), 15, SemHoleLocation.Web, false);

        //    BbSlottedHole.Create(mainPart2, BbCoordinate2D.Create(5000, 50), 100, 30, BbDirection2D.Create(0.9, 0.1), SemHoleLocation.Web, true);


        //    SemConnectedElements.Create(assembly, assembly2);

        //    var wp = BbWeldProperties.Create(10, 14);
        //    wp.AssignTo(w1);
        //    wp.AssignTo(w2);


        //    var assembly3 = BbAssembly.Create(
        //        "assid003", "Steel Assembly", "ASS02", "client_marker", "prelim_marker", "ship_mark", "302301123423", floor,
        //        BbCoordinate3D.Create(-14.3, 0, 0), BbDirection3D.ZAxis, BbDirection3D.XAxis2D);
        //    var mainPart3 = BbMainPiece.Create("c20010",
        //        "main piece", profile, 6000,
        //        BbCoordinate3D.DefaultOrigin, BbDirection3D.ZAxis, BbDirection3D.XAxis2D, assembly3);
        //    BbDrillHoles.Create(mainPart3, BbCoordinate2D.Create(6000 - 508 / 2 - 100, 100), 15, SemHoleLocation.Web, false);
        //    BbDrillHoles.Create(mainPart3, BbCoordinate2D.Create(6000 - 508 / 2 + 100, 100), 15, SemHoleLocation.Web, false);
        //    BbDrillHoles.Create(mainPart3, BbCoordinate2D.Create(6000 - 508 / 2 - 100, -100), 15, SemHoleLocation.Web, false);
        //    BbDrillHoles.Create(mainPart3, BbCoordinate2D.Create(6000 - 508 / 2 + 100, -100), 15, SemHoleLocation.Web, false);

        //    var rect = BbNamedRectangleProfile.Create(400, 300);
        //    BbExtrudedElement.Create(
        //        "new", rect, 5000, BbCoordinate3D.Create(0, 4000, 0), BbDirection3D.ZAxis, BbDirection3D.XAxis2D,
        //        floor, typeof(IfcColumn));

        //    BbExtrudedElement.Create(
        //        "new", rect, 5000, BbCoordinate3D.Create(6000, 4000, 0), BbDirection3D.ZAxis, BbDirection3D.XAxis2D,
        //        floor, typeof(IfcColumn));

        //    BbExtrudedElement.Create(
        //        "new", rect, 6000 + 400, BbCoordinate3D.Create(-200, 4000, 5210),
        //        BbDirection3D.XAxis2D, BbDirection3D.ZAxisMinus,
        //        floor, typeof(IfcBeam));



        //    var faces = new List<BbFace>();

        //    var p000 = BbCoordinate3D.Create(-300, -300, 0);
        //    var p100 = BbCoordinate3D.Create(300, -300, 0);
        //    var p110 = BbCoordinate3D.Create(300, 300, 0);
        //    var p010 = BbCoordinate3D.Create(-300, 300, 0);

        //    var p001 = BbCoordinate3D.Create(-100, -100, 4000);
        //    var p101 = BbCoordinate3D.Create(100, -100, 4000);
        //    var p111 = BbCoordinate3D.Create(100, 100, 4000);
        //    var p011 = BbCoordinate3D.Create(-100, 100, 4000);


        //    faces.Add(BbFace.Create(new List<BbCoordinate3D>()
        //        {
        //            p000,
        //            p010,
        //            p110,
        //            p100
        //        }));
        //    faces.Add(BbFace.Create(new List<BbCoordinate3D>()
        //        {
        //            p000,
        //            p100,
        //            p101,
        //            p001
        //        }));

        //    faces.Add(BbFace.Create(new List<BbCoordinate3D>()
        //        {
        //            p000,
        //            p001,
        //            p011,
        //            p010
        //        }));

        //    faces.Add(BbFace.Create(new List<BbCoordinate3D>()
        //        {
        //            p010,
        //            p011,
        //            p111,
        //            p110
        //        }));

        //    faces.Add(BbFace.Create(new List<BbCoordinate3D>()
        //        {
        //            p100,
        //            p110,
        //            p111,
        //            p101
        //        }));

        //    faces.Add(BbFace.Create(new List<BbCoordinate3D>()
        //        {
        //            p001,
        //            p101,
        //            p111,
        //            p011
        //        }));

        //    var brep = BbBRepGeometry.Create(faces);

        //    var belem = BbBrepElement.Create("brep", brep, BbCoordinate3D.Create(0, 8000, 0), BbDirection3D.ZAxis, BbDirection3D.XAxis2D,
        //                        floor, typeof(IfcColumn));


        //    var sp1 = BbSingleProperty.Create("test", "valueTest", true);
        //    var sp2 = BbSingleProperty.Create("test string", "string valueTest", false);

        //    var sp3 = BbSingleProperty.Create("realtest", 10.0, typeof(IfcPositiveLengthMeasure));

        //    var pset = BbPropertySet.Create("id");

        //    pset.AddProperty(sp1);
        //    pset.AddProperty(sp2);
        //    pset.AddProperty(sp3);

        //    pset.AssignTo(belem);
        //    return BbInstanceDB.Write(filename);


            
        //}


        //public static bool ReadTest(string filename)
        //{
            

        //    EarlyBindingInstanceModel.Read("IFC2X3_TC1", filename);
            
        //    var headerSetting = BbHeaderSetting.Retrieve();
        //    BbProject.Retrieve();
            
        //    var sites = BbSite.Retrieve();

            

        //    ////retrieve SEMs out of sites
        //    var semBuildings = new List<BbBuilding>();
        //    foreach (var theSite in sites)
        //    {
        //        var buildings = BbBuilding.Retrieve(theSite);
        //        foreach(var building in buildings)
        //        { semBuildings.Add(building); }
        //    }
            
        //    ////retrieve SEMs out of buildings
        //    var semFloors = new List<BbFloor>();
        //    foreach (var theBuilding in semBuildings)
        //    {
        //        var floors = BbFloor.Retrieve(theBuilding);
        //        foreach (var floor in floors)
        //        { semFloors.Add(floor); }
        //    }
            
        //    ////retrieve SEMs out of floors
        //    var semAssemblies = new List<BbAssembly>();
        //    foreach (var theFloor in semFloors) 
        //    {
        //        var assemblies = BbAssembly.Retrieve(theFloor);
        //        foreach(var assem in assemblies)
        //        { semAssemblies.Add(assem); }
        //    }

        //    ////retrieve SEMs out of Assemblies
        //    var semElements = new List<BbMainPiece>();
        //    foreach (var assembly in semAssemblies)
        //    {
        //        var semPaintFinishes = assembly.PaintFinishes; 
        //        //BbQuantityRequired 
        //        var elements = BbMainPiece.Retrieve(assembly);// all related SEMs are retrieved inside
        //        foreach (var element in elements)
        //        { semElements.Add(element); }
        //        var connectedElements = SemConnectedElements.Retrieve(assembly);
        //    }

        //    ////retrieve SEMs out of MainPieces
        //    foreach (var mainPiece in semElements)
        //    {
        //        var beamType = SemBeamType.Retrieve(mainPiece);
        //        var material = BbMaterial.Retrieve(mainPiece);
        //        var pFinishPatches = mainPiece.PaintFinishes; // all related SEMs are retrieved inside
        //        var annotation = SemAnnotation.Retrieve(mainPiece);
        //        var skewedEnds = BbSkewedEnd.Retrieve(mainPiece); // all related SEMs are retrieved inside
        //        var semCutCopes = BbCutCope.Retrieve(mainPiece); // all related SEMs are retrieved inside
        //        var semDrillHoles = BbDrillHoles.Retrieve(mainPiece); // all related SEMs are retrieved inside
        //        var semSlottedHoles = BbSlottedHole.Retrieve(mainPiece); // all related SEMs are retrieved inside

        //        var welds = BbWeld.Retrieve(mainPiece);
        //        foreach (var weld in welds)
        //        {
        //            var weldType = SemWeldType.Retrieve(weld);                 
        //            var weldProp = BbWeldProperties.Retrieve(weld);// all related SEMs are retrieved inside
        //            var clipAngle = BbClipAngle.Retrieve(weld);
                    
        //            var angleDrillHoles = BbDrillHoles.Retrieve(clipAngle); 
        //            var AngleSlottedHoles = BbSlottedHole.Retrieve(clipAngle); 
        //        }   
        //    }

        //    // BbCoordinate2D, BbCoordinate3D, BbDirection3D
            
            



        //    //foreach (var assem in assemblies)
        //    //{
        //    //    Console.WriteLine(assem.ToString());
        //    //}

        //    //return BbInstanceDB.Read(filename);
            return false;
        }
    }
}