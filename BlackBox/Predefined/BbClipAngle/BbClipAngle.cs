using System;
using BlackBox.Service;
using IFC2X3;

namespace BlackBox.Predefined
{

	public class BbClipAngle : BbAccessory
    {

        //IfcElement _ifcElement;

        //[EarlyBindingInstance]
        //public override IfcElement IfcElement
        //{
        //    get { return _ifcElement; }
        //    set { _ifcElement = value; }
        //}

        //private BbLocalPlacement3D _objectSemLocalPlacement;

        //public override BbLocalPlacement3D ObjectBbLocalPlacement
        //{
        //    get { return _objectSemLocalPlacement; }
        //    set { _objectSemLocalPlacement = value; }
        //}

	    protected BbClipAngle(
            string id, string name, BbProfile profile,
	        double length, BbCoordinate3D position, BbDirection3D zAxis,
	        BbDirection3D xAxis, BbDirection3D extrudeDirection,
	        BbElement container)
            :base(id, name, "Clip Angle", profile, length, position, zAxis, xAxis, extrudeDirection, container) 
	    {
	    }

        //private BbClipAngle()
        //{
        //}

        public static BbClipAngle Create(
            string id, string pieceName, BbProfile profile,
            double depth, BbCoordinate3D position, BbDirection3D zAxis,
            BbDirection3D xAxis, BbElement container
        )
        {
            var clipAngle = new BbClipAngle(
                id, pieceName, profile, depth, position, zAxis, xAxis, BbHeaderSetting.Setting3D.ZAxis, container);
            clipAngle.AddToHostObject(container);

            BbInstanceDB.AddToExport(clipAngle);
            return clipAngle;
        }

        public static BbClipAngle Create(
            string id, string pieceName, BbProfile profile,
            double depth, BbCoordinate3D position, BbDirection3D zAxis,
            BbDirection3D xAxis, BbElement container,
            string indicationMark, string pieceMark, string prelimMark, string barCode)
        {
            var clipAngle = new BbClipAngle(
                id, pieceName, profile, depth, position, zAxis, xAxis, BbHeaderSetting.Setting3D.ZAxis, container);
            //container.AddElement(mainPart);
            clipAngle.BbAccessoryIdentity = BbPieceIdentity.Create(indicationMark, pieceMark, prelimMark, barCode, false);
            clipAngle.AddToHostObject(container);
            BbInstanceDB.AddToExport(clipAngle);
            return clipAngle;
        }


        /// <summary>
        /// wrong implementation need to modify, donghoon 20131205
        /// </summary>
        /// <param name="weld"></param>
        /// <returns></returns>
        public static BbClipAngle Retrieve(BbWeld weld)
        {
            //var element = weld.IfcRelConnectsElements.RelatedElement; 
            //var clipAngle = new BbClipAngle { _ifcElement = element };

            //// Retreive related SEMs
            //var extrudedGeometry = BbExtrudedGeometry.RetrieveFromMainPiece(weld.AttachedElement);
            //clipAngle.BbElementGeometry = extrudedGeometry;
            //var profile = BbProfile.Retrieve(extrudedGeometry);
            //clipAngle.Profile = profile;

            //return clipAngle;
            throw  new NotImplementedException();
        }

    }
}