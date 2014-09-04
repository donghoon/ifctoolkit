using BlackBox.Service;
using IFC2X3;
using EbInstanceModel;
using System;
using System.Collections.Generic;

namespace BlackBox.Predefined
{

    public class BbPiece : BbElement
    {
       
        //[EarlyBindingInstance]
        //public IfcRelAggregates IfcRelAggregates { get; protected set; }

        private IfcElement _ifcElement;

        [EarlyBindingInstance]
        public override IfcObject IfcObject
        {
            get { return _ifcElement; }
            protected set
            {
                base.IfcObject = _ifcElement = value as IfcElement;
            }
        }

        public BbProfile Profile { get; protected set; }

        protected BbPiece()
            : this(Guid.NewGuid())
        {
        }

        protected BbPiece(Guid guid)
            : base(guid)
        {
        }

        protected BbPiece(
            string id, string name, string objectType, BbProfile profile,
            double length, BbCoordinate3D position, BbDirection3D zAxis,
            BbDirection3D xAxis, BbDirection3D extrudeDirection,
            BbElement hostElement, Type ifcEntityType)
            :this( name,  objectType,  profile,
             length,  position,  zAxis,
             xAxis,  extrudeDirection,
             hostElement.ObjectBbLocalPlacement,  ifcEntityType)
        {
            //AddToHostObject(hostElement);
        }


        private BbPiece(string name, string objectType, BbProfile profile,
            double length, BbCoordinate3D position, BbDirection3D zAxis,
            BbDirection3D xAxis, BbDirection3D extrudeDirection,
            BbLocalPlacement3D hostPlacement, Type ifcEntityType)
        {
            Length = length;
            Profile = profile;
            var pos = BbPosition3D.Create(position, zAxis, xAxis);

            ObjectBbLocalPlacement = BbLocalPlacement3D.Create(
                hostPlacement, pos);

            var semExtrudedGeometry = BbExtrudedGeometry.Create(
                profile,
                BbHeaderSetting.Setting3D.DefaultBbPosition3D,
                extrudeDirection,
                Length);

            _ifcElement = Activator.CreateInstance(ifcEntityType) as IfcElement;
            if (_ifcElement == null)
                return;

            _ifcElement.GlobalId = IfcGloballyUniqueId.ConvertToIfcGuid(Guid);
            _ifcElement.OwnerHistory = BbHeaderSetting.Setting3D.IfcOwnerHistory;
            _ifcElement.Name = name;
            _ifcElement.ObjectType = objectType;
            _ifcElement.ObjectPlacement = ObjectBbLocalPlacement.IfcLocalPlacement;
            _ifcElement.Representation = semExtrudedGeometry.IfcProductDefinitionShape;
            //_ifcElement.Tag = id;
        }



        //protected BbPiece(
        //    string id, string name, string objectType, BbProfile profile,
        //    double length, BbCoordinate3D position, BbDirection3D zAxis,
        //    BbDirection3D xAxis, BbDirection3D extrudeDirection,
        //    BbSpatialElement element, Type ifcEntityType)
        //{
        //    //Profile = profile;
        //    Length = length;

        //    var pos = BbPosition3D.Create(position, zAxis, xAxis);

        //    ObjectBbLocalPlacement = BbLocalPlacement3D.Create(
        //        element.ObjectBbLocalPlacement, pos);

        //    var semExtrudedGeometry = BbExtrudedGeometry.Create(
        //        profile,
        //        BbPosition3D.DefaultPosition,
        //        extrudeDirection,
        //        Length);



        //    _ifcElement = Activator.CreateInstance(ifcEntityType) as IfcElement;
        //    if (_ifcElement == null)
        //        return;

        //    _ifcElement.GlobalId = IfcGloballyUniqueId.NewGuid();
        //    _ifcElement.OwnerHistory = BbHeaderSetting.Setting3D.IfcOwnerHistory;
        //    _ifcElement.Name = name;
        //    _ifcElement.ObjectType = objectType;
        //    _ifcElement.ObjectPlacement = ObjectBbLocalPlacement.IfcLocalPlacement;
        //    _ifcElement.Representation = semExtrudedGeometry.IfcProductDefinitionShape;
        //    _ifcElement.Tag = id;


        //    var a = element.IfcRelAggregates;
        //    if (a == null)
        //    {
        //        element.IfcRelAggregates = new IfcRelAggregates()
        //        {
        //            GlobalId = IfcGloballyUniqueId.NewGuid(),
        //            OwnerHistory = BbHeaderSetting.Setting3D.IfcOwnerHistory,
        //            RelatingObject = element.IfcSpatialStructureElement,
        //            RelatedObjects = new List<IfcObjectDefinition>() { _ifcElement },
        //        };
        //    }
        //    element.IfcRelAggregates.RelatedObjects.Add(_ifcElement);

        //}



        //public static BbPiece Create(
        //    string id, string pieceName, string objectType, BbProfile profile,
        //    double depth, BbCoordinate3D position, BbDirection3D zAxis,
        //    BbDirection3D xAxis, BbAssembly container, Type ifcEntityType
        //)
        //{
        //    var mainPart = new BbPiece(
        //        id, pieceName, objectType, profile, depth, position, zAxis, xAxis,
        //        BbDirection3D.ZAxis, container, ifcEntityType);
        //    //container.AddElement (mainPart);

        //    BbInstanceDB.AddToExport(mainPart);
        //    return mainPart;
        //}


        
 
    }
}