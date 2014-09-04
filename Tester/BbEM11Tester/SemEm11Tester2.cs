
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
        public static bool ReadTestV02(string filename)
        {
            BbInstanceDB.Reset();

            EarlyBindingInstanceModel.Reset();

            if (! EarlyBindingInstanceModel.Read(RegisteredSchema.IFC2X3, filename))
                return false;

            BbHeaderSetting.Retrieve();
            BbProject.Retrieve();
            BbSite.Retrieve();
            BbBuilding.Retrieve();
            BbFloor.Retrieve();
            
//            var sites = BbSite.Retrieve(project);
//
//
//
//
//            ////retrieve SEMs out of sites
//            var semBuildings = new List<BbBuilding>();
//            foreach (var theSite in sites)
//            {
//                var buildings = BbBuilding.Retrieve(theSite);
//                foreach(var building in buildings)
//                { semBuildings.Add(building); }
//            }
//
//            ////retrieve SEMs out of buildings
//            var semFloors = new List<BbFloor>();
//            foreach (var theBuilding in semBuildings)
//            {
//                var floors = BbFloor.Retrieve(theBuilding);
//                foreach (var floor in floors)
//                { semFloors.Add(floor); }
//            }
//
//            ////retrieve SEMs out of floors
//            var semAssemblies = new List<BbAssembly>();
//            foreach (var theFloor in semFloors) 
//            {
//                var assemblies = BbAssembly.Retrieve(theFloor);
//                foreach(var assem in assemblies)
//                { semAssemblies.Add(assem); }
//            }
//
//            ////retrieve SEMs out of Assemblies
//            var semElements = new List<BbMainPiece>();
//            foreach (var assembly in semAssemblies)
//            {
//                var semPaintFinishes = assembly.PaintFinishes; 
//                //BbQuantityRequired 
//                var elements = BbMainPiece.Retrieve(assembly);// all related SEMs are retrieved inside
//                foreach (var element in elements)
//                { semElements.Add(element); }
//                // Retrieve DiscreteAccessory
//            }
//
//            ////retrieve SEMs out of MainPieces
//            foreach (var mainPiece in semElements)
//            {
//                var beamType = SemBeamSemType.Retrieve(mainPiece);
//                var material = BbMaterial.Retrieve(mainPiece);
//                var pFinishPatches = mainPiece.PaintFinishes; // all related SEMs are retrieved inside
//                var annotation = SemAnnotation.Retrieve(mainPiece);
//                var skewedEnds = BbSkewedEnd.Retrieve(mainPiece); // all related SEMs are retrieved inside
//                var semCutCopes = BbCutCope.Retrieve(mainPiece); // all related SEMs are retrieved inside
//                var semDrillHoles = BbDrillHoles.Retrieve(mainPiece); // all related SEMs are retrieved inside
//                var semSlottedHoles = BbSlottedHole.Retrieve(mainPiece); // all related SEMs are retrieved inside
//
//                var welds = Weld.Retrieve(mainPiece);
//                foreach (var weld in welds)
//                {
//                    var weldType = SemWeldSemType.Retrieve(weld); // Q1: check if SemWeldType exist or not before adding to DB
//                    // Q2: semWeldType.DefinedElements inside SemWeldSemType
//
//                    var weldProp = BbWeldProperties.Retrieve(weld);
//
//                    var clipAngle = BbClipAngle.Retrieve(weld);// Q3: DiscreteAccessory vs. ClipAngle                    
//                    /////////////////////////////// G1 //////// alternative solution for retrieving profile of clipAngle
//                    var extGeometry = clipAngle.BbElementGeometry as BbExtrudedGeometry;
//                    var profile = BbMainPiece.RetrieveProfile(extGeometry);// Q8: Can't put retrieveProfile in any other place + clipAngle
//                    clipAngle.Profile = profile;
//
//                    var angleDrillHoles = BbDrillHoles.Retrieve(clipAngle); 
//                    var AngleSlottedHoles = BbSlottedHole.Retrieve(clipAngle); 
//                    // Q4 : add clipAngle to mainPiece to retrieve holes? retriving holes should be done seperately (mainPiece & clipAngle) now
//                    // Q5 : inside MainPiece.RetrieveProfile
//                    // Q6 : inside MainPiece, under extrudedGeometry
//                    // Q7 : inside MainPiece, under profile
//                    // Q9 : inside BbWeldProperties
//
//                }   
//            }


            // SemConnectedElements

            // BbCoordinate2D, SemCoordinate3D, BbDirection3D

            // BbSingleProperty ...





            //foreach (var assem in assemblies)
            //{
            //    Console.WriteLine(assem.ToString());
            //}

            //return BbInstanceDB.Read(filename);
            return false;
        }
    }
}