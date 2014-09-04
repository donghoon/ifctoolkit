using System;
using BlackBox.Service;
using IFC2X3;

namespace BlackBox.Predefined
{
    public class BbAccessory : BbPiece
    {
        public BbPieceIdentity BbAccessoryIdentity { get; protected set; }

        protected BbAccessory(
            string id, string name, string objectType, BbProfile profile,
            double length, BbCoordinate3D position, BbDirection3D zAxis,
            BbDirection3D xAxis, BbDirection3D extrudeDirection,
            BbElement container)
            : base(id, name, objectType, profile, length, position, zAxis, xAxis, extrudeDirection, container, typeof(IfcDiscreteAccessory))
        {
        }

        public static BbAccessory Create(
            string id, string pieceName, string objectType, BbProfile profile,
            double depth, BbCoordinate3D position, BbDirection3D zAxis,
            BbDirection3D xAxis, BbElement container
        )
        {
            var mainPart = new BbAccessory(
                id, pieceName, objectType, profile, depth, position, zAxis, xAxis, BbHeaderSetting.Setting3D.ZAxis, container);
            //container.AddElement(mainPart);

            BbInstanceDB.AddToExport(mainPart);
            return mainPart;
        }

    }
}