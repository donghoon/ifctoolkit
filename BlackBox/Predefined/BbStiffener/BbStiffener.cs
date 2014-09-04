using System;
using BlackBox.Service;
using IFC2X3;

namespace BlackBox.Predefined
{

    public class BbStiffener : BbAccessory
    {

        protected BbStiffener(
            string id, string name,
            double width, double height,
            double length, BbCoordinate3D position, BbDirection3D zAxis,
            BbDirection3D xAxis, BbDirection3D extrudeDirection,
            BbElement container)
            : base(id, name, "Stiffener", BbNamedRectangleProfile.Create(width, height), length, position, zAxis, xAxis, extrudeDirection, container)
        {
        }

        public static BbStiffener Create(
            string id, string pieceName, 
            double width, double height,
            double depth, BbCoordinate3D position, BbDirection3D zAxis,
            BbDirection3D xAxis, BbElement container
        )
        {
            var stiffener = new BbStiffener(
                id, pieceName, width, height, depth, position, zAxis, xAxis, BbHeaderSetting.Setting3D.ZAxis, container);
            stiffener.AddToHostObject(container);
            BbInstanceDB.AddToExport(stiffener);
            return stiffener;
        }

    }
}