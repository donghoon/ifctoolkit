using System;
using BlackBox.Service;
using IFC2X3;

namespace BlackBox.Predefined
{
    public class BbBrepElement : BbElement{
        //public string Name;
		
        // todo: better method to incorporate other entity types
        IfcElement ifcElement;



        [EarlyBindingInstance]
        public override IfcObject IfcObject
        {
            get { return ifcElement; }
            protected set
            {
                base.IfcObject = value;
                ifcElement = base.IfcObject as IfcElement;
            }
        }


        BbBrepElement(
            string name,
            BbBRepGeometry brepGeometry,
            BbCoordinate3D position,
            BbDirection3D zAxis,
            BbDirection3D xAxis,
            BbLocalPlacement3D containerLocation,
            IfcOwnerHistory ownerHistory,
            Type IfcEntityType)
        {
            Name = name;
            //Profile = profile;
            BbPosition3D pos = BbPosition3D.Create(position, zAxis, xAxis);
			
            ObjectBbLocalPlacement = BbLocalPlacement3D.Create(
                containerLocation, pos	);
			

			
//			ifcBuildingElement = Activator.CreateInstance(EbConstants.Part21NSName, EbConstants.Part21NSName + "." + ifcEntityName);
            ifcElement = Activator.CreateInstance(IfcEntityType) as IfcElement;

            ifcElement.GlobalId = IfcGloballyUniqueId.NewGuid();
            ifcElement.OwnerHistory = ownerHistory;
            ifcElement.Name = Name;
            //ObjectType = ,
            ifcElement.ObjectPlacement = ObjectBbLocalPlacement.IfcLocalPlacement;
            ifcElement.Representation = brepGeometry.IfcProductDefinitionShape;

        }


        public static BbBrepElement Create(
            string name,
            BbBRepGeometry brepGeometry,
            BbCoordinate3D position,
            BbDirection3D zAxis,
            BbDirection3D xAxis,
            BbSpatialElement container,
            Type ifcEntityType
            )
        {
            var mainPart = new BbBrepElement(
                name, brepGeometry, position, zAxis, xAxis, 
                container.ObjectBbLocalPlacement, 
                container.IfcSpatialStructureElement.OwnerHistory,
                ifcEntityType);
            //container.AddContained (mainPart);
            mainPart.AddToSpatialElement(container);
            BbInstanceDB.AddToExport(mainPart);
            return mainPart;
        }
    }
}