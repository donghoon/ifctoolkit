
using System;
using System.Collections.Generic;
using System.ComponentModel;
using EbInstanceModel;
using IFC2X3;
using Sem.Service;
using SchemaModel;

namespace Sem.Predefined
{
    public partial class SemEm11Tester
    {
        public static bool ReadTestV02(string filename)
        {
            SemInstanceDB.Reset();

            EarlyBindingInstanceModel.Reset();

            if (! EarlyBindingInstanceModel.Read(RegisteredSchema.IFC2X3, filename))
                return false;

            SemHeaderSetting.Retrieve();
            SemProject.Retrieve();
            SemSite.Retrieve();
            SemBuilding.Retrieve();
            SemFloor.Retrieve();
            
//            var sites = SemSite.Retrieve(project);
//
//
//
//
//            ////retrieve SEMs out of sites
//            var semBuildings = new List<SemBuilding>();
//            foreach (var theSite in sites)
//            {
//                var buildings = SemBuilding.Retrieve(theSite);
//                foreach(var building in buildings)
//                { semBuildings.Add(building); }
//            }
//
//            ////retrieve SEMs out of buildings
//            var semFloors = new List<SemFloor>();
//            foreach (var theBuilding in semBuildings)
//            {
//                var floors = SemFloor.Retrieve(theBuilding);
//                foreach (var floor in floors)
//                { semFloors.Add(floor); }
//            }
//
//            ////retrieve SEMs out of floors
//            var semAssemblies = new List<SemAssembly>();
//            foreach (var theFloor in semFloors) 
//            {
//                var assemblies = SemAssembly.Retrieve(theFloor);
//                foreach(var assem in assemblies)
//                { semAssemblies.Add(assem); }
//            }
//
//            ////retrieve SEMs out of Assemblies
//            var semElements = new List<SemMainPiece>();
//            foreach (var assembly in semAssemblies)
//            {
//                var semPaintFinishes = assembly.PaintFinishes; 
//                //SemQuantityRequired 
//                var elements = SemMainPiece.Retrieve(assembly);// all related SEMs are retrieved inside
//                foreach (var element in elements)
//                { semElements.Add(element); }
//                // Retrieve DiscreteAccessory
//            }
//
//            ////retrieve SEMs out of MainPieces
//            foreach (var mainPiece in semElements)
//            {
//                var beamType = SemBeamSemType.Retrieve(mainPiece);
//                var material = SemMaterial.Retrieve(mainPiece);
//                var pFinishPatches = mainPiece.PaintFinishes; // all related SEMs are retrieved inside
//                var annotation = SemAnnotation.Retrieve(mainPiece);
//                var skewedEnds = SemSkewedEnd.Retrieve(mainPiece); // all related SEMs are retrieved inside
//                var semCutCopes = SemCutCope.Retrieve(mainPiece); // all related SEMs are retrieved inside
//                var semDrillHoles = SemDrillHoles.Retrieve(mainPiece); // all related SEMs are retrieved inside
//                var semSlottedHoles = SemSlottedHole.Retrieve(mainPiece); // all related SEMs are retrieved inside
//
//                var welds = Weld.Retrieve(mainPiece);
//                foreach (var weld in welds)
//                {
//                    var weldType = SemWeldSemType.Retrieve(weld); // Q1: check if SemWeldType exist or not before adding to DB
//                    // Q2: semWeldType.DefinedElements inside SemWeldSemType
//
//                    var weldProp = SemWeldProperties.Retrieve(weld);
//
//                    var clipAngle = SemClipAngle.Retrieve(weld);// Q3: DiscreteAccessory vs. ClipAngle                    
//                    /////////////////////////////// G1 //////// alternative solution for retrieving profile of clipAngle
//                    var extGeometry = clipAngle.SemElementGeometry as SemExtrudedGeometry;
//                    var profile = SemMainPiece.RetrieveProfile(extGeometry);// Q8: Can't put retrieveProfile in any other place + clipAngle
//                    clipAngle.Profile = profile;
//
//                    var angleDrillHoles = SemDrillHoles.Retrieve(clipAngle); 
//                    var AngleSlottedHoles = SemSlottedHole.Retrieve(clipAngle); 
//                    // Q4 : add clipAngle to mainPiece to retrieve holes? retriving holes should be done seperately (mainPiece & clipAngle) now
//                    // Q5 : inside MainPiece.RetrieveProfile
//                    // Q6 : inside MainPiece, under extrudedGeometry
//                    // Q7 : inside MainPiece, under profile
//                    // Q9 : inside SemWeldProperties
//
//                }   
//            }


            // SemConnectedElements

            // SemCoordinate2D, SemCoordinate3D, SemDirection3D

            // SemSingleProperty ...





            //foreach (var assem in assemblies)
            //{
            //    Console.WriteLine(assem.ToString());
            //}

            //return SemInstanceDB.Read(filename);
            return false;
        }
    }
}