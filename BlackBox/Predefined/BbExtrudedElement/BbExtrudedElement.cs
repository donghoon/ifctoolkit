using System;
using BlackBox.Service;
using IFC2X3;

namespace BlackBox.Predefined
{
    /// <summary>
	/// Extruded element.
	/// </summary>
	public class BbExtrudedElement: BbElement
	{
		//public string Name;

		// todo: better method to incorporate other entity types
		IfcElement _ifcElement;
		
		[EarlyBindingInstance]
        public override IfcObject IfcObject
		{
			get { return _ifcElement; }
		 protected	set { _ifcElement = value as IfcElement; }
		}
		
		public BbProfile Profile { get; set; }

//		ExtrudedElement(
//			string name,
//			Profile profile,
//			double length,
//			Coordinate3D position,
//			Direction3D zAxis,
//			Direction3D xAxis,
//			Direction3D extrudeDirection,
//			Element container)
//			:this (name, profile, length, position, zAxis, xAxis, extrudeDirection, 
//			       container.ObjectLocalPlacement, container.IfcElement.OwnerHistory)
//		{}
//
//		ExtrudedElement(
//			string name,
//			Profile profile,
//			double length,
//			Coordinate3D position,
//			Direction3D zAxis,
//			Direction3D xAxis,
//			Direction3D extrudeDirection,
//			SpatialElement container)
//			:this (name, profile, length, position, zAxis, xAxis, extrudeDirection, 
//			       container.ObjectLocalPlacement, container.IfcSpatialStructureElement.OwnerHistory)
//		{}

		BbExtrudedElement(
			string name,
			BbProfile profile,
			double length,
			BbCoordinate3D position,
			BbDirection3D zAxis,
			BbDirection3D xAxis,
			BbDirection3D extrudeDirection,
			BbLocalPlacement3D containerLocation,
			IfcOwnerHistory ownerHistory,
			Type ifcEntityType)
		{
			Name = name;
			Profile = profile;
			Length = length;			
			BbPosition3D pos = BbPosition3D.Create(position, zAxis, xAxis);
			
			ObjectBbLocalPlacement = BbLocalPlacement3D.Create(
				containerLocation, pos	);
			
			BbExtrudedGeometry bbExtrudedGeometry = BbExtrudedGeometry.Create(
				profile,
                BbHeaderSetting.Setting3D.DefaultBbPosition3D,
                BbHeaderSetting.Setting3D.ZAxis, 
				Length);
			
			_ifcElement = Activator.CreateInstance(ifcEntityType) as IfcElement;
			_ifcElement.GlobalId = IfcGloballyUniqueId.NewGuid();
			_ifcElement.OwnerHistory = ownerHistory;
			_ifcElement.Name = Name;
				//ObjectType = ,
			_ifcElement.ObjectPlacement = ObjectBbLocalPlacement.IfcLocalPlacement;
			_ifcElement.Representation = bbExtrudedGeometry.IfcProductDefinitionShape;

		}
		
		
//		ExtrudedElement(
//			string name, Profile profile, double length,
//			Coordinate3D position, Direction3D zAxis, Direction3D xAxis, Element container)
//			: this(name, profile, length, position, zAxis, xAxis, Direction3D.RefDirection, container)
//		{
//		}
		

		public static BbExtrudedElement Create(
			string name,
			BbProfile profile,
			double depth,
			BbCoordinate3D position,
			BbDirection3D zAxis,
			BbDirection3D xAxis,
			BbElement container,
			Type ifcEntityType
			)
		{
			var mainPart = new BbExtrudedElement(
                name, profile, depth, position, zAxis, xAxis, BbHeaderSetting.Setting3D.RefDirection, container.ObjectBbLocalPlacement, container.IfcObject.OwnerHistory, ifcEntityType);
			BbInstanceDB.AddToExport(mainPart);
			return mainPart;
		}

		public static BbExtrudedElement Create(
			string name,
			BbProfile profile,
			double depth,
			BbCoordinate3D position,
			BbDirection3D zAxis,
			BbDirection3D xAxis,
			BbSpatialElement container,
			Type ifcEntityType
			)
		{
			var mainPart = new BbExtrudedElement(
                name, profile, depth, position, zAxis, xAxis, BbHeaderSetting.Setting3D.RefDirection, container.ObjectBbLocalPlacement, container.IfcSpatialStructureElement.OwnerHistory, ifcEntityType);
			//container.AddContained (mainPart);
            mainPart.AddToSpatialElement(container);
			BbInstanceDB.AddToExport(mainPart);
			return mainPart;
		}

	}
}

