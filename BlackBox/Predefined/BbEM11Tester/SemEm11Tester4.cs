using System;
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
        public static bool Tester4Writer(string filename)
        {
            var em11PsetName = @"AISC_EM11_Pset_Status";
            SemHeaderSetting.Create(
                "donghoon", "Georgia Tech", "sem Tool", "alpha 1", "gatech", SemUnit.Metric);
            var floor = SemFloor.CreateSingleStoreyProject(
                "project", "site", "building", "1st floor", 0);

            // assembly 1-Beam-------------------------------------------------------------------------------------

            var assembly = SemAssembly.Create(
                "assid001",
                "Steel Assembly",
                "ASS01",
                "client_marker",
                "prelim_marker",
                "ship_mark",
                "102301123423", floor,
                SemCoordinate3D.Create(0, 0, 6000), SemDirection3D.ZAxis, SemDirection3D.XAxis);

            // assembly 1 properties
            //Quantity
            var qAssemBeam = SemQuantityRequired.Create();
            qAssemBeam.Add(assembly);
            //Finish/tearment
            var paintAssem = PaintFinish.Create();
            assembly.AddPaintFinish(paintAssem);

            var pSetAssemSTr01 = SemPropertySet.Create(@"AISC_EM11_Pset_SurfaceTreatment");
            var paintAssem1Pset = SemSurfaceTreatmentProperty.Create(pSetAssemSTr01, new List<string> {"Painted"});
            paintAssem1Pset.AssignTo(assembly);
            //Scheduling
            var pSetAssemSc01 = SemPropertySet.Create(@"AISC_EM11_Pset_Schedule");
            var AssemSch01 = SemSchedule.Create(pSetAssemSc01, "seq01", "seqLevel 01", DateTime.Now);
            AssemSch01.AssignTo(assembly);
            //Status
            var pSetAssemSt01 = SemPropertySet.Create(@"AISC_EM11_Pset_StatusInformation");
            var AssemStat01 = SemStatus.Create(pSetAssemSt01, "Default", "Default", true);
            AssemStat01.AssignTo(assembly);
            //Drawing number
            var pSetAssemDN01 = SemPropertySet.Create(@"AISC_EM11_Pset_DrawingNumber");
            var DnumberAssem1Pset = SemDrawingNumber.Create(pSetAssemDN01, new List<string> {"DR001PH1005","DR001PH1004"});
            DnumberAssem1Pset.AssignTo(assembly);
            //Version
            var pSetAssemVr01 = SemPropertySet.Create(@"AISC_EM11_Pset_VersionInformation");
            var versionAssem01 = SemVersion.Create(pSetAssemVr01, "versionAssem01");
            versionAssem01.AssignTo(assembly);


            // main piece 1- Beam------------------------------------------------------------------------------------
            var profile = SemNamedIProfile.Create("AISC", "W460X260", 260, 508, 22.6, 40.4);
            var mainPart = SemMainPiece.Create(
                "P0001",
                "main piece", profile, 6000,
                SemCoordinate3D.Create(0, 0, -254),
                SemDirection3D.XAxis,
                SemDirection3D.YAxis,
                assembly);
            var beamType = SemBeamType.Create("wideflange", "pm0001", IfcBeamTypeEnum.BEAM);
            beamType.Defines(mainPart);

            // Main piece 1-Beam properties
            //Identification
            var pieceIdBeam01 = SemPieceIdentity.Create("indMark001", "pieceMark001", "prelimMark001", "barcode123456890", true);
            pieceIdBeam01.AssignTo(mainPart);
            //Material

            var pSetMat2 = SemPropertySet.Create(@"AISC_EM11_Pset_MaterialProperty");
            var materialBeam01 = SemMaterial.Create("ASTM A992", pSetMat2, "materialID001", "materialCert001", "materialGrade001", "materialType001");
            materialBeam01.AssociateTo(mainPart);
            
            //Quantity
            var qBeam = SemQuantityRequired.Create();
            qBeam.Add(mainPart);
            //Finish/treatment
            ////var paint2 = PaintFinish.Create("p1001", "antirust", "paint");
            var coord2d00 = SemCoordinate2D.Create(-100, 0);
            var coord2d01 = SemCoordinate2D.Create(100, 0);
            var coord2d02 = SemCoordinate2D.Create(100, 3400);
            var coord2d03 = SemCoordinate2D.Create(-100, 3400);
            var poly2d0 = SemPolyline2D.Create(new[] {coord2d00, coord2d01, coord2d02, coord2d03});

            var coord2d10 = SemCoordinate2D.Create(-40, 1500);
            var coord2d11 = SemCoordinate2D.Create(40, 1500);
            var coord2d12 = SemCoordinate2D.Create(40, 2500);
            var coord2d13 = SemCoordinate2D.Create(-40, 2500);
            var poly2d1 = SemPolyline2D.Create(new[] {coord2d10, coord2d11, coord2d12, coord2d13});

            var sg = SemSurfaceGeometry.Create(poly2d0, new[] {poly2d1});
            var paint3 = SemPaintFinishPatch.Create("p1001", "antirust", "paint", sg);

            var ploc = SemLocalPlacement3D.Create(
                mainPart.ObjectSemLocalPlacement,
                SemPosition3D.Create(
                    SemCoordinate3D.Create(0, 254, 100),
                    SemDirection3D.YAxis,
                    SemDirection3D.XAxisMinus)
                );

            mainPart.AddPaintFinish(paint3, ploc);

            var pSetBeamSTr01 = SemPropertySet.Create(@"AISC_EM11_Pset_SurfaceTreatment");
            var paintBeam1Pset = SemSurfaceTreatmentProperty.Create(pSetBeamSTr01, new List<string>{ "Galvanized"});
            paintBeam1Pset.AssignTo(mainPart);
            //Status
            var pSetBeamSt01 = SemPropertySet.Create(@"AISC_EM11_Pset_StatusInformation");
            var statusBeam01 = SemStatus.Create(pSetBeamSt01, "Default", "Default", false);
            statusBeam01.AssignTo(mainPart);
            //Version
            var pSetBeamVr01 = SemPropertySet.Create(@"AISC_EM11_Pset_VersionInformation");
            var versionBeam01 = SemVersion.Create(pSetBeamVr01, "versionBeam01");
            versionBeam01.AssignTo(mainPart);
            //Tolerance
            var pSetBeamLT01 = SemPropertySet.Create(@"AISC_EM11_Pset_ToleranceForLayout");
            var toleranceBeam01 = SemLayoutTolerance.Create(pSetBeamLT01, 0.01);
            toleranceBeam01.AssignTo(mainPart);
            //Catellation
            //No castellation needed

            //Feature

            //SemAnnotation.Create
            //    ("north", "LocationOfMark", mainPart, SemCoordinate3D.Create(0, 254, 5), SemDirection3D.YAxis,
            //        SemDirection3D.XAxisMinus);

            //SemPosition3D pos = SemPosition3D.Create(
            //    SemCoordinate3D.Create(0, 0, 100),
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

            var bHoleBeam01 = SemDrillHoles.Create(mainPart, SemCoordinate2D.Create(1100, 60), 30, SemHoleLocation.Bottom, false);
            var bHoleBeam02 = SemDrillHoles.Create(mainPart, SemCoordinate2D.Create(1100, -60), 30, SemHoleLocation.Bottom, true);
            var bHoleBeam03 = SemDrillHoles.Create(mainPart, SemCoordinate2D.Create(1200, 60), 30, SemHoleLocation.Top, true);
            var bHoleBeam04 = SemDrillHoles.Create(mainPart, SemCoordinate2D.Create(1200, -60), 30, SemHoleLocation.Top, false);
            //DrillHoles.Create(mainPart, Coordinate2D.Create(300, 60), 15, HoleLocation.Left, false);
            //DrillHoles.Create(mainPart, Coordinate2D.Create(400, -60), 15, HoleLocation.Left, true);
            //DrillHoles.Create(mainPart, Coordinate2D.Create(500, 60), 15, HoleLocation.Right, false);
            //DrillHoles.Create(mainPart, Coordinate2D.Create(600, -60), 15, HoleLocation.Right, true);
            var bHoleBeam05 = SemDrillHoles.Create(mainPart, SemCoordinate2D.Create(700, 60), 15, SemHoleLocation.Web, false);
            var bHoleBeam06 = SemDrillHoles.Create(mainPart, SemCoordinate2D.Create(800, -60), 15, SemHoleLocation.Web, true);
            //DrillHoles.Create(mainPart, Coordinate2D.Create(6000 - 106.5, -100), 15, HoleLocation.Web, true);
            //DrillHoles.Create(mainPart, Coordinate2D.Create(6000 - 91.5, 100), 20, HoleLocation.Web, true);
            //DrillHoles.Create(mainPart, Coordinate2D.Create(101.5 + 5, -100), 15, HoleLocation.Web, true);
            //DrillHoles.Create(mainPart, Coordinate2D.Create(101.5 + 5, 100), 15, HoleLocation.Web, true);

            //Beam Bolt Hole properties
            var pSetBeamBH01 = SemPropertySet.Create(@"AISC_EM11_Pset_BoltHole");
            var boltHoleBeamPset1 = SemBoltHoleProperties.Create(pSetBeamBH01, "Drilling", "Top", "No design constraint", "Tapped Hole", 30, false, 0);
            boltHoleBeamPset1.AssignTo(bHoleBeam01);
            boltHoleBeamPset1.AssignTo(bHoleBeam02);
            boltHoleBeamPset1.AssignTo(bHoleBeam03);
            boltHoleBeamPset1.AssignTo(bHoleBeam04);
            boltHoleBeamPset1.AssignTo(bHoleBeam05);
            boltHoleBeamPset1.AssignTo(bHoleBeam06);

            // Stiffeners-------------------------------------------------------------------------------------------
            //Stiffener1
            var stiffener1 = SemStiffener.Create("st00102", "stiffener", 100, 425, 35,
                SemCoordinate3D.Create(65, 0, 5000), SemDirection3D.ZAxis, SemDirection3D.XAxis, mainPart);
            //Stifenner1 properties
            //Identification
            var stiffIdentity1 = SemPieceIdentity.Create("indMark002", "pieceMark002", "prelimMark002", "barcode123456892", false); 
            stiffIdentity1.AssignTo(stiffener1);
            //Status
            var pSetStstiff01 = SemPropertySet.Create(@"AISC_EM11_Pset_StatusInformation");
            var statusstiff01 = SemStatus.Create(pSetStstiff01, "ReadyForProcurement", "Default", true);
            statusstiff01.AssignTo(stiffener1);
            //Version
            var pSetVrstiff01 = SemPropertySet.Create(@"AISC_EM11_Pset_VersionInformation");
            var versionstiff01 = SemVersion.Create(pSetVrstiff01, "versionStiff01");
            versionstiff01.AssignTo(stiffener1);
            //Tolerance
            var pSetLystiff01 = SemPropertySet.Create(@"AISC_EM11_Pset_ToleranceForLayout");
            var tolerancestiff01 = SemLayoutTolerance.Create(pSetLystiff01, 0.01);
            tolerancestiff01.AssignTo(stiffener1);
            //Quantity
            var qStiff = SemQuantityRequired.Create();
            qStiff.Add(stiffener1);
            //Material
            var pSetMat1 = SemPropertySet.Create(@"AISC_EM11_Pset_MaterialProperty");
            var materialStiff = SemMaterial.Create("ASTM A992", pSetMat1, "materialID002", 
                                                    "materialCert002", "materialGrade002", "materialType002");   
            materialStiff.AssociateTo(stiffener1);
            //Finish/treatment
            var paintStiff = PaintFinish.Create();
            stiffener1.AddPaintFinish(paintStiff);

            var pSetSTstiff01 = SemPropertySet.Create(@"AISC_EM11_Pset_SurfaceTreatment");
            var paintStiffPset = SemSurfaceTreatmentProperty.Create(pSetSTstiff01, new List<string>{ "Galvanized"});
            paintStiffPset.AssignTo(stiffener1);

            //Stiffener2-------------------------------
            var stiffener2 = SemStiffener.Create("st00102", "stiffener", 100, 425, 35,
                SemCoordinate3D.Create(-65, 0, 5000), SemDirection3D.ZAxis, SemDirection3D.XAxis, mainPart);
            //Stifenner2 properties
            //Identification
            var stiffIdentity2 = SemPieceIdentity.Create("indMark003", "pieceMark003", "prelimMark003", "barcode123456893", false);
            stiffIdentity2.AssignTo(stiffener2);
            //Status
            statusstiff01.AssignTo(stiffener2);
            //Version
            versionstiff01.AssignTo(stiffener2);
            //Tolerance
            tolerancestiff01.AssignTo(stiffener2);
            //Quantity
            qStiff.Add(stiffener2);
            //Material
            materialStiff.AssociateTo(stiffener2);
            //Finish/treatment
            stiffener2.AddPaintFinish(paintStiff);
            //paintStiffPset.AssignTo(stiffener2);

            //Stiffener3-------------------------------
            var stiffener3 = SemStiffener.Create("st00102", "stiffener", 100, 425, 35,
                SemCoordinate3D.Create(65, 0, 4600), SemDirection3D.ZAxis, SemDirection3D.XAxis, mainPart);
            //Stifenner3 properties
            //Identification
            var stiffIdentity3 = SemPieceIdentity.Create("indMark004", "pieceMark004", "prelimMark004", "barcode123456894", false);
            stiffIdentity3.AssignTo(stiffener3);
            //Status
            statusstiff01.AssignTo(stiffener3);
            //Version
            versionstiff01.AssignTo(stiffener3);
            //Tolerance
            tolerancestiff01.AssignTo(stiffener3);
            //Quantity
            qStiff.Add(stiffener3);
            //Material
            materialStiff.AssociateTo(stiffener3);
            //Finish/treatment
            stiffener3.AddPaintFinish(paintStiff);
            //paintStiffPset.AssignTo(stiffener3);

            //Stiffener4-------------------------------
            var stiffener4 = SemStiffener.Create("st00102", "stiffener", 100, 425, 35,
                SemCoordinate3D.Create(-65, 0, 4600), SemDirection3D.ZAxis, SemDirection3D.XAxis, mainPart);
            //Stifenner4 properties
            //Identification
            var stiffIdentity4 = SemPieceIdentity.Create("indMark005", "pieceMark005", "prelimMark005", "barcode123456895", false);
            stiffIdentity4.AssignTo(stiffener4);
            //Status
            statusstiff01.AssignTo(stiffener4);
            //Version
            versionstiff01.AssignTo(stiffener4);
            //Tolerance
            tolerancestiff01.AssignTo(stiffener4);
            //Quantity
            qStiff.Add(stiffener4);
            //Material
            materialStiff.AssociateTo(stiffener4);
            //Finish/treatment
            stiffener4.AddPaintFinish(paintStiff);
            //paintStiffPset.AssignTo(stiffener4);

            // welding stiffeners with beam //DDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD


            //SemSlottedHole.Create(mainPart, SemCoordinate2D.Create(3000, 50), 70, 30, SemDirection2D.RefDirection,
            //    SemHoleLocation.Web, true);

            //2 Clip angles for column1----------------------------------------------------------------------------------

            var aProfile = SemNamedLProfile.Create("AISC", "L203X152X19", 203, 152, 19);

            var derived1 = SemDerivedProfile.Create(aProfile, false, true);
            // -90.3 for showing gap between elements
            var angle = SemClipAngle.Create(
                "a00102",
                "angle",
                derived1, 360,
                //SemCoordinate3D.Create(5898.5, 90.3, -180 - 254),
                SemCoordinate3D.Create(90.3, -180, 5898.5),
                SemDirection3D.YAxis, SemDirection3D.Axis,
                mainPart
                );

            //var w000 = SemCoordinate3D.Create(5898.5, 0, 0);
            //var w001 = SemCoordinate3D.Create(5898.5, 0, 200);
            var w000 = SemCoordinate3D.Create(5898.5, 0, 0);
            var w001 = SemCoordinate3D.Create(5898.5, 0, 200);
            var curve = SemPolyline3D.Create(new SemCoordinate3D[] { w000, w001 });
            var curveGeometry = SemCurveGeometry.Create(curve);

            //Clip angle 1 properties
            //Identification
            var angleIdentity1 = SemPieceIdentity.Create("indMark006", "pieceMark006", "prelimMark006", "barcode123456896", false);
            angleIdentity1.AssignTo(angle);
            //Status
            var pSetStAngle01 = SemPropertySet.Create(@"AISC_EM11_Pset_StatusInformation");
            var statusAngle01 = SemStatus.Create(pSetStAngle01, "ReadyForProcurement", "Default", false);
            statusAngle01.AssignTo(angle);
            //Version
            var pSetVrAngle01 = SemPropertySet.Create(@"AISC_EM11_Pset_VersionInformation");
            var versionAngle01 = SemVersion.Create(pSetVrAngle01, "versionAngle001");
            versionAngle01.AssignTo(angle);
            //Tolerance
            var pSetLyAngle01 = SemPropertySet.Create(@"AISC_EM11_Pset_ToleranceForLayout");
            var toleranceAngle01 = SemLayoutTolerance.Create(pSetLyAngle01, 0.01);
            toleranceAngle01.AssignTo(angle);
            //Quantity
            var qAngle = SemQuantityRequired.Create();
            qAngle.Add(angle);
            //Material

            var pSetMat3 = SemPropertySet.Create(@"AISC_EM11_Pset_MaterialProperty");
            var materialAngle = SemMaterial.Create("ASTM A992", pSetMat3, "materialID003", 
                                                    "materialCert003", "materialGrade003", "materialType003");
            materialAngle.AssociateTo(angle);
            //Finish/treatment
            var paintAngle = PaintFinish.Create();
            angle.AddPaintFinish(paintAngle);

            var pSetSTAngle01 = SemPropertySet.Create(@"AISC_EM11_Pset_SurfaceTreatment");
            var paintAnglePset = SemSurfaceTreatmentProperty.Create(pSetSTAngle01, new List<string>{ "Galvanized"});
            paintAnglePset.AssignTo(angle);

            //Feature
            //DrillHoles.Create(angle, Coordinate2D.Create(100, -5), 15, HoleLocation.Bottom, false);
            //DrillHoles.Create(angle, Coordinate2D.Create(300, 10), 20, HoleLocation.Bottom, false);
            var bHoleAngle01 = SemDrillHoles.Create(angle, SemCoordinate2D.Create(80, 9.5), 15, SemHoleLocation.Right, false);
            var bHoleAngle02 = SemDrillHoles.Create(angle, SemCoordinate2D.Create(280, 9.5), 20, SemHoleLocation.Right, false);
            //Clip Angle1 Bolt Hole properties
            var pSetAngleBH01 = SemPropertySet.Create(@"AISC_EM11_Pset_BoltHole");
            var boltHoleAnglePset1 = SemBoltHoleProperties.Create(pSetAngleBH01, "Drilling", "Top", "No design constraint", "Tapped Hole", 30, false, 0);
            boltHoleAnglePset1.AssignTo(bHoleAngle01);
            boltHoleAnglePset1.AssignTo(bHoleAngle02);


            var derived = SemDerivedProfile.Create(aProfile, true, true);
            var angle2 = SemClipAngle.Create("a00103",
                "angle", derived, 360,
                //SemCoordinate3D.Create(5898.5, -90.3, -180 - 254),
                SemCoordinate3D.Create(-90.3, -180, 5898.5),
                //SemDirection3D.ZAxis, SemDirection3D.XAxis,
                SemDirection3D.YAxis, SemDirection3D.Axis,
                mainPart);
            
            //Clip angle 2 properties
            //Identification
            var angleIdentity2 = SemPieceIdentity.Create("indMark007", "pieceMark007", "prelimMark007", "barcode123456897", false);
            angleIdentity2.AssignTo(angle2);
            //Status
            statusAngle01.AssignTo(angle2);
            //Version
            versionAngle01.AssignTo(angle2);
            //Tolerance
            toleranceAngle01.AssignTo(angle2);
            //Quantity
            qAngle.Add(angle2);
            //Material
            materialAngle.AssociateTo(angle2);
            //Finish/treatment
            angle2.AddPaintFinish(paintAngle);
            //paintAnglePset.AssignTo(angle2);

            //DrillHoles.Create(angle2, Coordinate2D.Create(100, -5), 15, HoleLocation.Top, false);
            //DrillHoles.Create(angle2, Coordinate2D.Create(300, 10), 20, HoleLocation.Top, false);
            var bHoleAngle03 = SemDrillHoles.Create(angle2, SemCoordinate2D.Create(80, -9.5), 15, SemHoleLocation.Right, false);
            var bHoleAngle04 = SemDrillHoles.Create(angle2, SemCoordinate2D.Create(280, -9.5), 20, SemHoleLocation.Right, false);
            //Clip Angle2 Bolt Hole properties
            boltHoleAnglePset1.AssignTo(bHoleAngle03);
            boltHoleAnglePset1.AssignTo(bHoleAngle04);



            var w1 = SemWeld.Create(mainPart, angle);
            //var w1 = SemWeld.Create("Tee Joint", mainPart, angle);
            //var w2 = Weld.Create("Tee Joint", mainPart, angle2);
            w1.AddWeldingPath(curveGeometry, SemCoordinate3D.Create(0.0, 0.0, 0.0));

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



            //Clip angle for column2----------------------------------------------------------------------------------

            var derived3 = SemDerivedProfile.Create(aProfile, true, false);
            var angle3 = SemClipAngle.Create(
                "a00103",
                "angle",
                derived3, 360,
                SemCoordinate3D.Create(-90.3, -180, 5898.5 - 5798.5),
                SemDirection3D.YAxis, SemDirection3D.Axis,
                mainPart
                );
            
            //Clip angle 3 properties
            //Identification
            var angleIdentity3 = SemPieceIdentity.Create("indMark008", "pieceMark008", "prelimMark008", "barcode123456898", false);
            angleIdentity3.AssignTo(angle3);
            //Status
            statusAngle01.AssignTo(angle3);
            //Version
            versionAngle01.AssignTo(angle3);
            //Tolerance
            toleranceAngle01.AssignTo(angle3);
            //Quantity
            qAngle.Add(angle3);
            //Material
            materialAngle.AssociateTo(angle3);
            //Finish/treatment
            angle3.AddPaintFinish(paintAngle);
            //paintAnglePset.AssignTo(angle3);

            var bHoleAngle05 = SemDrillHoles.Create(angle3, SemCoordinate2D.Create(80, -10), 15, SemHoleLocation.Left, false);
            var bHoleAngle06 = SemDrillHoles.Create(angle3, SemCoordinate2D.Create(280, -10), 15, SemHoleLocation.Left, false);
            //Clip Angle3 Bolt Hole properties
            boltHoleAnglePset1.AssignTo(bHoleAngle05);
            boltHoleAnglePset1.AssignTo(bHoleAngle06);
            

            var derived4 = SemDerivedProfile.Create(aProfile, false, false);
            var angle4 = SemClipAngle.Create(
                    "a00104",
                    "angle",
                    derived4, 360,
                    SemCoordinate3D.Create(90.3, -180, 5898.5 - 5798.5),
                    SemDirection3D.YAxis, SemDirection3D.Axis,
                    mainPart
                    );

            //Clip angle 4 properties
            //Identification
            var angleIdentity4 = SemPieceIdentity.Create("indMark009", "pieceMark009", "prelimMark009", "barcode123456899", false);
            angleIdentity4.AssignTo(angle4);
            //Status
            statusAngle01.AssignTo(angle4);
            //Version
            versionAngle01.AssignTo(angle4);
            //Tolerance
            toleranceAngle01.AssignTo(angle4);
            //Quantity
            qAngle.Add(angle4);
            //Material
            materialAngle.AssociateTo(angle4);
            //Finish/treatment
            angle4.AddPaintFinish(paintAngle);
            //paintAnglePset.AssignTo(angle4);

            var bHoleAngle07 = SemDrillHoles.Create(angle4, SemCoordinate2D.Create(80, 10), 15, SemHoleLocation.Left, false);
            var bHoleAngle08 = SemDrillHoles.Create(angle4, SemCoordinate2D.Create(280, 10), 15, SemHoleLocation.Left, false);
            boltHoleAnglePset1.AssignTo(bHoleAngle07);
            boltHoleAnglePset1.AssignTo(bHoleAngle08);

            // welding column 2 & beam with angle 3,4//DDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD


            // Assembly 2- Column1-------------------------------------------------------------------------------------
            var assembly2 = SemAssembly.Create(
                "assid003",
                "Steel Assembly",
                "ASS02", "client_marker2",
                "prelim_marker2",
                "ship_mark2",
                "202301123433",
                floor,
                SemCoordinate3D.Create(6014.3, 0, 0),
                SemDirection3D.ZAxis,
                SemDirection3D.XAxis);

            // assembly 2 properties
            //Quantity
            var qAssemCol1 = SemQuantityRequired.Create();
            qAssemCol1.Add(assembly2);
            //Finish/tearment
            var paintAssem2 = PaintFinish.Create();
            assembly2.AddPaintFinish(paintAssem2);

            var pSetAssemSTr02 = SemPropertySet.Create(@"AISC_EM11_Pset_SurfaceTreatment");
            var paintAssem2Pset = SemSurfaceTreatmentProperty.Create(pSetAssemSTr02, new List<string>{ "Galvanized"});
            paintAssem2Pset.AssignTo(assembly2);
            //Scheduling
            var pSetAssemSc02 = SemPropertySet.Create(@"AISC_EM11_Pset_Schedule");
            var AssemSch02 = SemSchedule.Create(pSetAssemSc02, "seq01", "seqLevel 01", DateTime.Now);
            AssemSch02.AssignTo(assembly2);
            //Status
            var pSetAssemSt02 = SemPropertySet.Create(@"AISC_EM11_Pset_StatusInformation");
            var AssemStat02 = SemStatus.Create(pSetAssemSt02, "Default", "Default", true);
            AssemStat02.AssignTo(assembly2);
            //Drawing number
            var pSetAssemDN02 = SemPropertySet.Create(@"AISC_EM11_Pset_DrawingNumber");
            var DnumberAssem2Pset = SemDrawingNumber.Create(pSetAssemDN02, new List<string> {"DR001PH1006","DR001PH1005"}); 
            DnumberAssem2Pset.AssignTo(assembly2);
            //Version
            var pSetAssemVr02 = SemPropertySet.Create(@"AISC_EM11_Pset_VersionInformation");
            var versionAssem02 = SemVersion.Create(pSetAssemVr02, "versionAssem02");
            versionAssem02.AssignTo(assembly2);

            //Main Piece 2- Column1
            var mainPart2 = SemMainPiece.Create(
                "c00102",
                "main piece",
                profile, 6000,
                SemCoordinate3D.Origin,
                SemDirection3D.ZAxis,
                SemDirection3D.XAxis,
                assembly2);

            // Column1 properties
            //Identification
            var pieceIdCol01 = SemPieceIdentity.Create("indMark010", "pieceMark010", "prelimMark010", "barcode123456880", true);
            pieceIdCol01.AssignTo(mainPart2);
            //Status
            var pSetColSt01 = SemPropertySet.Create(@"AISC_EM11_Pset_StatusInformation");
            var statusCol01 = SemStatus.Create(pSetColSt01, "ReadyForProcurement", "Default", true);
            statusCol01.AssignTo(mainPart2);
            //Version
            var pSetColVr01 = SemPropertySet.Create(@"AISC_EM11_Pset_VersionInformation");
            var versionCol01 = SemVersion.Create(pSetColVr01, "versionCol001");
            versionCol01.AssignTo(mainPart2);
            //Tolerance
            var pSetColLy01 = SemPropertySet.Create(@"AISC_EM11_Pset_ToleranceForLayout");
            var toleranceCol01 = SemLayoutTolerance.Create(pSetColLy01, 0.002);
            toleranceCol01.AssignTo(mainPart2);
            //Quantity
            var qPieceCol = SemQuantityRequired.Create();
            qPieceCol.Add(mainPart2);
            //Material

            var pSetMat4 = SemPropertySet.Create(@"AISC_EM11_Pset_MaterialProperty");

            var materialCol1 = SemMaterial.Create("ASTM A992", pSetMat4, "materialID004",
                                                    "materialCert004", "materialGrade004", "materialType004");
            materialCol1.AssociateTo(mainPart2);
            //Finish/treatment
            var paintCol1 = PaintFinish.Create();
            mainPart2.AddPaintFinish(paintCol1);

            var pSetColST01 = SemPropertySet.Create(@"AISC_EM11_Pset_SurfaceTreatment");
            var paintColPset = SemSurfaceTreatmentProperty.Create(pSetColST01, new List<string> { "Blast" });
            paintColPset.AssignTo(mainPart2);
            //Castellation
            //var pSetCt02 = SemPropertySet.Create(@"AISC_EM11_Pset_Castellation");
            //var castellation2 = SemCastellation.Create(pSetCt02, "Circular", 0.002, 0.002, 0.001, 0.002, 0.01, 0.001);
            //castellation2.AssignTo(mainPart2);

            //Features
            var bHoleCol01 = SemDrillHoles.Create(mainPart2, SemCoordinate2D.Create(6000 - 508 / 2 - 100, 100), 15, SemHoleLocation.Web,
                false);
            var bHoleCol02 = SemDrillHoles.Create(mainPart2, SemCoordinate2D.Create(6000 - 508 / 2 + 100, 100), 15, SemHoleLocation.Web,
                false);
            var bHoleCol03 = SemDrillHoles.Create(mainPart2, SemCoordinate2D.Create(6000 - 508 / 2 - 100, -100), 15, SemHoleLocation.Web,
                false);
            var bHoleCol04 = SemDrillHoles.Create(mainPart2, SemCoordinate2D.Create(6000 - 508 / 2 + 100, -100), 15, SemHoleLocation.Web,
                false);

            var pSetColBH01 = SemPropertySet.Create(@"AISC_EM11_Pset_BoltHole");
            var boltHoleColPset1 = SemBoltHoleProperties.Create(pSetColBH01, "Drilling", "Top", "No design constraint", "Tapped Hole", 20, false, 0);
            boltHoleColPset1.AssignTo(bHoleCol01);
            boltHoleColPset1.AssignTo(bHoleCol02);
            boltHoleColPset1.AssignTo(bHoleCol03);
            boltHoleColPset1.AssignTo(bHoleCol04);

            SemSlottedHole.Create(mainPart2, SemCoordinate2D.Create(5000, 50), 100, 30, SemDirection2D.Create(0.9, 0.3),
                SemHoleLocation.Web, true);
            //Slotted Hole properties


            // welding colum 1 with angle//DDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD

            SemConnectedElements.Create(assembly, assembly2);

            ///////////////////////////////////////////weld

            //var wp = SemWeldProperties.Create(10, 14);
            //wp.AssignTo(w1);
            //wp.AssignTo(w2);


            // Assembly 3- Column2----------------------------------------------------------------------------------------
            var assembly3 = SemAssembly.Create(
                "assid003", "Steel Assembly", "ASS02", "client_marker3", "prelim_marker3", "ship_mark3", "302301123425",
                floor,
                SemCoordinate3D.Create(-14.3, 0, 0), SemDirection3D.ZAxis, SemDirection3D.XAxis);

            // Assembly 3 properties
            //Quantity
            qAssemCol1.Add(assembly3);
            //Finish/tearment
            assembly3.AddPaintFinish(paintAssem2);
            //paintAssem2Pset.AssignTo(assembly3);
            //Scheduling
            AssemSch02.AssignTo(assembly3);
            //Status
            AssemStat02.AssignTo(assembly3);
            //Drawing number
            var pSetAssemDN03 = SemPropertySet.Create(@"AISC_EM11_Pset_DrawingNumber");
            var DnumberAssem3Pset = SemDrawingNumber.Create(pSetAssemDN03, new List<string> {"DR001PH1006","DR001PH1005", "DR001PH1008"});
            DnumberAssem3Pset.AssignTo(assembly3);
            //Version
            versionAssem02.AssignTo(assembly3);

            //Main Piece 3- Column 2
            var mainPart3 = SemMainPiece.Create("c20010",
                "main piece", profile, 6000,
                SemCoordinate3D.Origin, SemDirection3D.ZAxis, SemDirection3D.XAxis, assembly3);


            //Column2 properties
            //Identification
            var pieceIdCol02 = SemPieceIdentity.Create("indMark011", "pieceMark011", "prelimMark011", "barcode123456881", true);
            pieceIdCol02.AssignTo(mainPart3);
            //Status
            var pSetColSt02 = SemPropertySet.Create(@"AISC_EM11_Pset_StatusInformation");
            var statusCol02 = SemStatus.Create(pSetColSt02, "ReadyForMill", "Default", true);
            statusCol02.AssignTo(mainPart3);
            //Version
            var pSetColVr02 = SemPropertySet.Create(@"AISC_EM11_Pset_VersionInformation");
            var versionCol02 = SemVersion.Create(pSetColVr02, "versionCol002");
            versionCol02.AssignTo(mainPart3);
            //Tolerance
            toleranceCol01.AssignTo(mainPart3);
            //Quantity
            qPieceCol.Add(mainPart3);
            //Material
            materialCol1.AssociateTo(mainPart3);
            //Finish/treatment
            mainPart3.AddPaintFinish(paintCol1);
            //paintColPset.AssignTo(mainPart3);

            //Castellation- not required
            //var pSetCt02 = SemPropertySet.Create(@"AISC_EM11_Pset_Castellation");
            //var castellation2 = SemCastellation.Create(pSetCt02, "Circular", 0.002, 0.002, 0.001, 0.002, 0.01, 0.001);
            //castellation2.AssignTo(mainPart2);


            // Column2 features
            var bHoleCol05 = SemDrillHoles.Create(mainPart3, SemCoordinate2D.Create(6000 - 508 / 2 - 100, 100), 15, SemHoleLocation.Web,
                false);
            var bHoleCol06 = SemDrillHoles.Create(mainPart3, SemCoordinate2D.Create(6000 - 508 / 2 + 100, 100), 15, SemHoleLocation.Web,
                false);
            var bHoleCol07 = SemDrillHoles.Create(mainPart3, SemCoordinate2D.Create(6000 - 508 / 2 - 100, -100), 15, SemHoleLocation.Web,
                false);
            var bHoleCol08 = SemDrillHoles.Create(mainPart3, SemCoordinate2D.Create(6000 - 508 / 2 + 100, -100), 15, SemHoleLocation.Web,
                false);
            boltHoleColPset1.AssignTo(bHoleCol05);
            boltHoleColPset1.AssignTo(bHoleCol06);
            boltHoleColPset1.AssignTo(bHoleCol07);
            boltHoleColPset1.AssignTo(bHoleCol08);


            return SemInstanceDB.Write(filename);
        }
        //public static bool Tester4Writer1(string filename)
        //{

        //    var em11PsetName = @"AISC_EM11_Pset";

        //    SemHeaderSetting.Create(
        //        "donghoon", "Georgia Tech", "sem Tool", "alpha 1", "gatech", SemUnit.Metric);
        //    var floor = SemFloor.CreateSingleStoreyProject(
        //        "project", "site", "building", "1st floor", 0);

        //    // first assembly
        //    var assembly = SemAssembly.Create(
        //        "assid001",
        //        "Steel Assembly",
        //        "ASS01",
        //        "client_marker",
        //        "prelim_marker",
        //        "ship_mark",
        //        "102301123423", floor,
        //        SemCoordinate3D.Create(0, 0, 6000), SemDirection3D.ZAxis, SemDirection3D.XAxis);

        //    var paint = PaintFinish.Create("g1001", "gal 1020", "galvanized");

        //    assembly.AddPaintFinish(paint);

        //    var qAss = SemQuantityRequired.Create();
        //    qAss.Add(assembly);

        //    var profile = SemNamedIProfile.Create("AISC", "W460X260", 260, 508, 22.6, 40.4);

        //    // main piece
        //    var mainPart = SemMainPiece.Create(
        //        "P0001",
        //        "main piece", profile, 6000,
        //        SemCoordinate3D.Create(0, 0, -254),
        //        SemDirection3D.XAxis,
        //        SemDirection3D.YAxis,
        //        assembly);




        //    var pieceIdentity = SemPieceIdentity.Create("idmark001", "pieceMark001", "premMark001", "123456890", true);
        //    pieceIdentity.AssignTo(mainPart);

        //    var beamType = SemBeamType.Create("wideflange", "pm0001", IfcBeamTypeEnum.BEAM);
        //    beamType.Defines(mainPart);


        //    var material = SemMaterial.Create("ASTM", "A992", "ASTM A992",
        //                                      "materialID01", "materialCert01", "materialGrade01", "materialType01");
        //    material.AssociateTo(mainPart);

        //    //var paint2 = PaintFinish.Create("p1001", "antirust", "paint");

        //    var coord2d00 = SemCoordinate2D.Create(-100, 0);
        //    var coord2d01 = SemCoordinate2D.Create(100, 0);
        //    var coord2d02 = SemCoordinate2D.Create(100, 3400);
        //    var coord2d03 = SemCoordinate2D.Create(-100, 3400);
        //    var poly2d0 = SemPolyline2D.Create(new[] {coord2d00, coord2d01, coord2d02, coord2d03});


        //    var coord2d10 = SemCoordinate2D.Create(-40, 1500);
        //    var coord2d11 = SemCoordinate2D.Create(40, 1500);
        //    var coord2d12 = SemCoordinate2D.Create(40, 2500);
        //    var coord2d13 = SemCoordinate2D.Create(-40, 2500);
        //    var poly2d1 = SemPolyline2D.Create(new[] {coord2d10, coord2d11, coord2d12, coord2d13});


        //    var sg = SemSurfaceGeometry.Create(poly2d0, new[] {poly2d1});

        //    var paint3 = SemPaintFinishPatch.Create("p1001", "antirust", "paint", sg);

        //    var ploc = SemLocalPlacement3D.Create(
        //        mainPart.ObjectSemLocalPlacement,
        //        SemPosition3D.Create(
        //            SemCoordinate3D.Create(0, 254, 100),
        //            SemDirection3D.YAxis,
        //            SemDirection3D.XAxisMinus)
        //        );

        //    mainPart.AddPaintFinish(paint3, ploc);


        //    SemAnnotation.Create
        //        ("north", "LocationOfMark", mainPart, SemCoordinate3D.Create(0, 254, 5), SemDirection3D.YAxis,
        //            SemDirection3D.XAxisMinus);

        //    SemPosition3D pos = SemPosition3D.Create(
        //        SemCoordinate3D.Create(0, 0, 300),
        //        SemDirection3D.Create(0.215665546, -0.107832773, -0.970494959),
        //        SemDirection3D.Create(-0.970494959, 0.107832773, -0.215665546)
        //        );

        //    var skewedEndpropertySet1 = SemPropertySet.Create("AISC_EM11_Pset_SkewedEnd");
        //    SemSkewedEnd.Create(mainPart, pos, skewedEndpropertySet1, 0.1, 0.1);

        //    var CutCopepropertySet1 = SemPropertySet.Create("AISC_EM11_Pset_CutCope");
        //    SemCutCope.Create(mainPart, 210, 50, 10, SemCopeLocation.BottomRight,CutCopepropertySet1, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10);
        //    SemCutCope.Create(mainPart, 210, 50, 10, SemCopeLocation.TopRight,CutCopepropertySet1, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10);

        //    var DrillHolepropertySet1 = SemPropertySet.Create("AISC_EM11_Pset_DrillHole");
        //    var dHProperty1 = SemDrillHoleProperty.Create(DrillHolepropertySet1, "BeveledHole", 60, false, 360);

        //    var drillHole1 = new List<SemDrillHoles> (){ 
        //    SemDrillHoles.Create(mainPart, SemCoordinate2D.Create(1100, 60), 30, SemHoleLocation.Bottom, false),
        //    SemDrillHoles.Create(mainPart, SemCoordinate2D.Create(1100, -60), 30, SemHoleLocation.Bottom, true),
        //    SemDrillHoles.Create(mainPart, SemCoordinate2D.Create(1200, 60), 30, SemHoleLocation.Top, true),
        //    SemDrillHoles.Create(mainPart, SemCoordinate2D.Create(1200, -60), 30, SemHoleLocation.Top, false),

        //    SemDrillHoles.Create(mainPart, SemCoordinate2D.Create(700, 60), 15, SemHoleLocation.Web, false),
        //    SemDrillHoles.Create(mainPart, SemCoordinate2D.Create(800, -60), 15, SemHoleLocation.Web, true)};

        //    dHProperty1.AssignTo(drillHole1);

        //    var slottedHolepropertySet1 = SemPropertySet.Create("AISC_EM11_Pset_SlottedHole");
        //    SemSlottedHole.Create(mainPart, SemCoordinate2D.Create(3000, 50), 70, 30, SemDirection2D.RefDirection, SemHoleLocation.Web, true, slottedHolepropertySet1, "ThreadedHole");

        //    var aProfile = SemNamedLProfile.Create("AISC", "L203X152X19", 203, 152, 19);

        //    var derived1 = SemDerivedProfile.Create(aProfile, false, true);
        //    // -90.3 for showing gap between elements
        //    var angle = SemClipAngle.Create(
        //        "a00102",
        //        "angle",
        //        derived1, 360,
        //        SemCoordinate3D.Create(5898.5, 90.3, -180 - 254), SemDirection3D.ZAxis, SemDirection3D.XAxis, assembly,
        //        "idmark002", "pieceMark002", "premMark002", "123456892");

        //    var material2 = SemMaterial.Create("ASTM", "A992", "ASTM A992","materialID02", "materialCert02", "materialGrade02", "materialType02");
        //    material2.AssociateTo(angle);

        //    var DrillHolepropertySet2 = SemPropertySet.Create("AISC_EM11_Pset_DrillHole");
        //    var dHProperty2 = SemDrillHoleProperty.Create(DrillHolepropertySet2, "TappedHole", 30, false, 360);
        //    var drillHole2 = SemDrillHoles.Create(angle, SemCoordinate2D.Create(80, 9.5), 15, SemHoleLocation.Right, false);
        //    dHProperty2.AssignTo(drillHole2);

        //    var DrillHolepropertySet3 = SemPropertySet.Create("AISC_EM11_Pset_DrillHole");
        //    var dHProperty3 = SemDrillHoleProperty.Create(DrillHolepropertySet3, "TappedHole", 40, false, 360);
        //    var drillHole3 = SemDrillHoles.Create(angle, SemCoordinate2D.Create(280, 9.5), 20, SemHoleLocation.Right, false);
        //    dHProperty3.AssignTo(drillHole3);

        //    var derived = SemDerivedProfile.Create(aProfile, true, true);
        //    var angle2 = SemClipAngle.Create("a00103",
        //        "angle", derived, 360,
        //        SemCoordinate3D.Create(5898.5, -90.3, -180 - 254), SemDirection3D.ZAxis, SemDirection3D.XAxis, assembly);


        //    var drillHole4 = SemDrillHoles.Create(angle2, SemCoordinate2D.Create(80, -9.5), 15, SemHoleLocation.Right, false);
        //    dHProperty2.AssignTo(drillHole4);

        //    var drillHole5 = SemDrillHoles.Create(angle2, SemCoordinate2D.Create(280, -9.5), 20, SemHoleLocation.Right, false);
        //    dHProperty3.AssignTo(drillHole5);

        //    var qAng = SemQuantityRequired.Create();
        //    qAng.Add(angle);
        //    qAng.Add(angle2);



        //    //var w1 = Weld.Create("Tee Joint", mainPart, angle);
        //    //var w2 = Weld.Create("Tee Joint", mainPart, angle2);





        //    //var wtype = SemWeldType.Create("Tee Joint", "tj0001");
        //    //wtype.Defines(w1);
        //    //wtype.Defines(w2);




        //    var assembly2 = SemAssembly.Create(
        //        "assid003", "Steel Assembly", "ASS02", "client_marker", "prelim_marker", "ship_mark", "202301123433",
        //        floor,
        //        SemCoordinate3D.Create(6014.3, 0, 0), SemDirection3D.ZAxis, SemDirection3D.XAxis);
        //    var mainPart2 = SemMainPiece.Create("c00102",
        //        "main piece", profile, 6000,
        //        SemCoordinate3D.Origin, SemDirection3D.ZAxis, SemDirection3D.XAxis, assembly2);

        //    var DrillHolepropertySet4 = SemPropertySet.Create("AISC_EM11_Pset_DrillHole");
        //    var dHProperty4 = SemDrillHoleProperty.Create(DrillHolepropertySet4, "BeveledHole", 30, false, 30);

        //    var drillHole6 = new List<SemDrillHoles>(){ 
        //    SemDrillHoles.Create(mainPart2, SemCoordinate2D.Create(6000 - 508/2 - 100, 100), 15, SemHoleLocation.Web, false),
        //    SemDrillHoles.Create(mainPart2, SemCoordinate2D.Create(6000 - 508/2 + 100, 100), 15, SemHoleLocation.Web, false),
        //    SemDrillHoles.Create(mainPart2, SemCoordinate2D.Create(6000 - 508/2 - 100, -100), 15, SemHoleLocation.Web, false),
        //    SemDrillHoles.Create(mainPart2, SemCoordinate2D.Create(6000 - 508/2 + 100, -100), 15, SemHoleLocation.Web, false)};
        //    dHProperty4.AssignTo(drillHole6);

        //    var slottedHolepropertySet2 = SemPropertySet.Create("AISC_EM11_Pset_SlottedHole");
        //    SemSlottedHole.Create(mainPart2, SemCoordinate2D.Create(5000, 50), 100, 30, SemDirection2D.Create(0.9, 0.1),
        //        SemHoleLocation.Web, true, slottedHolepropertySet2, "TappedHole");


        //    SemConnectedElements.Create(assembly, assembly2);

        //    //var wp = SemWeldProperties.Create(10, 14);
        //    //wp.AssignTo(w1);
        //    //wp.AssignTo(w2);


        //    var assembly3 = SemAssembly.Create(
        //        "assid003", "Steel Assembly", "ASS02", "client_marker", "prelim_marker", "ship_mark", "302301123423",
        //        floor,
        //        SemCoordinate3D.Create(-14.3, 0, 0), SemDirection3D.ZAxis, SemDirection3D.XAxis);
        //    var mainPart3 = SemMainPiece.Create("c20010",
        //        "main piece", profile, 6000,
        //        SemCoordinate3D.Origin, SemDirection3D.ZAxis, SemDirection3D.XAxis, assembly3);


        //    var drillHole7 = new List<SemDrillHoles>(){ 
        //    SemDrillHoles.Create(mainPart3, SemCoordinate2D.Create(6000 - 508/2 - 100, 100), 15, SemHoleLocation.Web, false),
        //    SemDrillHoles.Create(mainPart3, SemCoordinate2D.Create(6000 - 508/2 + 100, 100), 15, SemHoleLocation.Web, false),
        //    SemDrillHoles.Create(mainPart3, SemCoordinate2D.Create(6000 - 508/2 - 100, -100), 15, SemHoleLocation.Web, false),
        //    SemDrillHoles.Create(mainPart3, SemCoordinate2D.Create(6000 - 508/2 + 100, -100), 15, SemHoleLocation.Web, false)};
        //    dHProperty4.AssignTo(drillHole7);

        //    return SemInstanceDB.Write(filename);



        //}
    }
}