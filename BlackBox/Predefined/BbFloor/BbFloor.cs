using System;
using System.Collections.Generic;
using BlackBox.Service;
using EbInstanceModel;
using IFC2X3;

namespace BlackBox.Predefined
{

    public partial class BbFloor : BbSpatialElement
    {
        private IfcBuildingStorey _ifcBuildingStorey { get; set; }

        [EarlyBindingInstance]
		public override IfcSpatialStructureElement IfcSpatialStructureElement
        {
            get
            {
                return _ifcBuildingStorey;
            }
            set
            {
                _ifcBuildingStorey = value as IfcBuildingStorey;
            }
        }

        //[ComponentsCollection]
        //public List<SemSpace> Spaces { get; set; }
        public BbBuilding BbBuilding { get; set; }
        
        BbFloor(
            string name,
            double elevation,
            BbBuilding building)
        {
            ObjectBbLocalPlacement = BbLocalPlacement3D.Create(building.ObjectBbLocalPlacement, BbHeaderSetting.Setting3D.DefaultBbPosition3D);

            IfcSpatialStructureElement = new IfcBuildingStorey
            {
                GlobalId = IfcGloballyUniqueId.NewGuid(),

				OwnerHistory = BbHeaderSetting.Setting3D.IfcOwnerHistory,
                Name = name,
                //Description = "",
                //ObjectType = "",
				ObjectPlacement = ObjectBbLocalPlacement.IfcLocalPlacement,
                //Representation = 
                //LongName = "",
                CompositionType = IfcElementCompositionEnum.ELEMENT,
                Elevation = elevation,
            };

            //building.AddFloor(this);
            BbBuilding = building;

            if (true)
            {
                IfcRelAggregates = new IfcRelAggregates()
                {
                    GlobalId = IfcGloballyUniqueId.NewGuid(),
                    OwnerHistory = BbHeaderSetting.Setting3D.IfcOwnerHistory,
                    RelatingObject = BbBuilding.IfcSpatialStructureElement,
                    RelatedObjects = new List<IfcObjectDefinition>() { IfcSpatialStructureElement },
                };
            }
        }

        private BbFloor()
        {
        }

        protected BbFloor(BbBuilding building, IfcBuildingStorey floor, IfcRelAggregates ifcRelAggregates)
        {
            BbBuilding = building;
            IfcSpatialStructureElement = floor;
            IfcRelAggregates = ifcRelAggregates;

        }

        public static BbFloor Create (
			string name,
			double elevation,
			BbBuilding building)
		{
			var f = new BbFloor(name, elevation, building);
			BbInstanceDB.AddToExport(f);
			return f;
		}

        public static ICollection<BbFloor> Retrieve(BbBuilding building)
        {
            /*
            var ret = new List<BbFloor>();

            if (!EarlyBindingInstanceModel.TheModel.DataByType.ContainsKey("IfcBuildingStorey")) return null;
            var collection = EarlyBindingInstanceModel.TheModel.DataByType["IfcBuildingStorey"].Values;
            foreach (var item in collection)
            {
                var buildingStorey = item as IfcBuildingStorey;
                if (buildingStorey == null) continue;
                foreach ( var floor in building.Floors)
                {
                    if (floor.IfcSpatialStructureElement.EIN == buildingStorey.EIN)
                    {
                        var semFloor = new BbFloor { _ifcBuildingStorey = buildingStorey };
                        var floorItem = RetrieveSpatialComponents(semFloor);
                        semFloor.SpatialComponents = floorItem;

                        BbInstanceDB.Add(semFloor);
                        ret.Add(semFloor);
                    }
                }
            }
            return ret;
            */

            
            var refed = EarlyBindingInstanceModel.GetReferencedEntities(building.IfcSpatialStructureElement.EIN);
            //if (refed.Count <= 0) throw new InvalidDataException();

            var ret = new List<BbFloor>();
            foreach (var p21Instance in refed)
            {
                if (p21Instance.Value.GetType() != typeof(IfcRelAggregates)) continue;
                var agg = p21Instance.Value as IfcRelAggregates;
                if (agg == null) continue;

                foreach (var instance in agg.RelatedObjects) 
                {
                    if (instance.GetType() != typeof(IfcBuildingStorey)) continue;
                    var floor = instance as IfcBuildingStorey;
                    if (floor == null) continue;
                    var semFloor = new BbFloor(building, floor, agg);
                    ret.Add(semFloor);
                    BbInstanceDB.AddToExport(semFloor);
                }
            }
            return ret;
            
        }
        /*
        public static void RetrieveSpace(BbFloor floor)
        {
            var spaces = new List<SemSpace>();
            if (EarlyBindingInstanceModel.TheModel.DataByType.ContainsKey("IfcRelAggregates"))
            {
                var collection = EarlyBindingInstanceModel.TheModel.DataByType["IfcRelAggregates"].Values;
                //if (collection.Count != 1) throw new NotImplementedException();
                foreach (var item in collection)
                {
                    var theItem = item as IfcRelAggregates;
                    if (theItem == null) continue;
                    if (theItem.RelatingObject.EIN == floor.IfcSpatialStructureElement.EIN)
                    {
                        foreach (var a in theItem.RelatedObjects)
                        {
                            var space = a as IfcSpace;
                            if (space == null) continue;
                            var semSpace = new SemSpace { IfcSpace = space };
                            BbInstanceDB.Add(semSpace);
                            spaces.Add(semSpace);
                        }
                    }
                }
            }
            floor.Spaces = spaces;
        }
        */

        //public static List<BbElement> RetrieveSpatialComponents(BbFloor floor)
        //{
        //    var spatialComponents = new List<BbElement>();
        //    //if (!EarlyBindingInstanceModel.TheModel.DataByType.ContainsKey("IfcRelContainedInSpatialStructure")) return null;
        //    var collection = EarlyBindingInstanceModel.GetDataByType("IfcRelContainedInSpatialStructure").Values;
        //    //if (collection.Count != 1) throw new NotImplementedException();
        //    foreach (var item in collection)
        //    {
        //        var theItem = item as IfcRelContainedInSpatialStructure;
        //        if (theItem == null) continue;
        //        if (theItem.RelatingStructure.EIN == floor.IfcSpatialStructureElement.EIN)
        //        {
        //            foreach (var a in theItem.RelatedElements)
        //            {
        //                var component = a as IfcElement;// HERE I SHOULD SEPERATE IfcElementAssembly FROM IfcColumn & IfcBeam
        //                if (component == null) continue;
        //                var spatialComponent = new BbElement { IfcElement = component };//IfcRelContainedInSpatialStructure
        //                BbInstanceDB.AddToExport(spatialComponent);
        //                spatialComponents.Add(spatialComponent);
        //            }
        //        }
        //    }
        //    return spatialComponents;
        //}


        
        //public void AddSpace(SemSpace semSpace)
        //{
        //    if(Spaces == null)
        //    {Spaces = new List<SemSpace>();}
        //    if (IfcRelAggregates == null)
        //    {
        //        IfcRelAggregates = new IfcRelAggregates
        //        {
        //            GlobalId = IfcGloballyUniqueId.NewGuid(),
        //            OwnerHistory = _ifcBuildingStorey.OwnerHistory,
        //            RelatingObject = _ifcBuildingStorey,
        //            RelatedObjects = new List<IfcObjectDefinition>(),
        //        };
        //    }
        //    Spaces.Add(semSpace);
        //    IfcRelAggregates.RelatedObjects.Add(semSpace.IfcSpace);
        //}

        //public void AddToFloor(BbElement floorItem)
        //{
        //    if (IfcRelContainedInSpatialStructure == null)
        //    {
        //        IfcRelContainedInSpatialStructure = new IfcRelContainedInSpatialStructure
        //        {
        //            GlobalId = IfcGloballyUniqueId.NewGuid(),
        //            OwnerHistory = _ifcBuildingStorey.OwnerHistory,
        //            RelatingStructure = _ifcBuildingStorey,
        //            RelatedElements =  new List<IfcProduct>(),
        //        };
        //    }

        //    if(SpatialComponents == null)
        //    {
        //        SpatialComponents = new List<BbElement>();
        //    }
        //    SpatialComponents.Add(floorItem);
        //}


        public static BbFloor CreateSingleStoreyProject(
            string projectName,
            string siteName,
            string buildingName,
            string floorName,
            double floorLevel)
        {
            var project = BbProject.Create(projectName);
            var site = BbSite.Create(siteName, project);
            var building = BbBuilding.Create(buildingName, site);
            var floor = BbFloor.Create(floorName, floorLevel, building);
            return floor;
        }




    }
    
}
