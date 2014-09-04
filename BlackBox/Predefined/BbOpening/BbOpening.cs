using BlackBox.Service;
using IFC2X3;
using System.Collections.Generic;
using EbInstanceModel;


namespace BlackBox.Predefined
{

    /// <summary>
    /// Hole location.
    /// </summary>
    public enum SemHoleLocation
    {
        Bottom,
        Top,
        Web,
        Left,
        Right,
    }

    public class BbOpening : BbFeature
    {
        private IfcOpeningElement _ifcOpeningElement;
        private IfcRelVoidsElement _ifcRelVoidsElement;

        [EarlyBindingInstance]
        public override IfcObject IfcObject
        {
            get { return _ifcOpeningElement; }
            protected set
            {
                var a = value as IfcOpeningElement;
                if (a != null) _ifcOpeningElement = a;
            }
        }


        [EarlyBindingInstance]
        public IfcRelVoidsElement IfcRelVoidsElement
        {
            get { return _ifcRelVoidsElement; }
        }

        protected BbOpening(
            BbElement hostElement,
            BbCoordinate2D position,
            BbProfile profile,
            SemHoleLocation location,
            bool through,
            string type
            )
        {
            var mainPart = hostElement as BbPiece;
            if (mainPart == null)
                return;


            double thickness;
            BbPosition3D pos;

            // x direction follows extrusion direction
            // extrude origin  projected to bottom or left becomes the origin

            switch (location)
            {

                case SemHoleLocation.Left:
                    pos = BbPosition3D.Create(
                        BbCoordinate3D.Create(
                            -(mainPart.Profile.Width / 2),
                            position.Y,
                            position.X),
                        BbHeaderSetting.Setting3D.XAxis,
                        BbHeaderSetting.Setting3D.ZAxis);
                    if (through)
                        thickness = mainPart.Profile.Width;
                    else
                        thickness = mainPart.Profile.Width / 2;
                    break;
                case SemHoleLocation.Right:
                    pos = BbPosition3D.Create(
                        BbCoordinate3D.Create(
                            (mainPart.Profile.Width / 2),
                            position.Y,
                            position.X),
                        BbHeaderSetting.Setting3D.XAxisMinus,
                        BbHeaderSetting.Setting3D.ZAxis);
                    if (through)
                        thickness = mainPart.Profile.Width;
                    else
                        thickness = mainPart.Profile.Width / 2;
                    break;
                case SemHoleLocation.Web:
                    if (through)
                    {
                        pos = BbPosition3D.Create(
                            BbCoordinate3D.Create(
                                (mainPart.Profile.Width / 2),
                                position.Y,
                                position.X
                                ),
                            BbHeaderSetting.Setting3D.XAxisMinus,
                            BbHeaderSetting.Setting3D.ZAxis);
                        thickness = mainPart.Profile.Width;
                    }
                    else
                    {
                        pos = BbPosition3D.Create(
                            BbCoordinate3D.Create(
                                (mainPart.Profile.Width / 4),
                                position.Y,
                                position.X
                                ),
                            BbHeaderSetting.Setting3D.XAxisMinus,
                            BbHeaderSetting.Setting3D.ZAxis);
                        thickness = mainPart.Profile.Width / 2;
                    }
                    break;

                case SemHoleLocation.Bottom:
                    pos = BbPosition3D.Create(
                        BbCoordinate3D.Create(
                            position.Y,
                            -(mainPart.Profile.Depth / 2),
                            position.X
                            ),
                        BbHeaderSetting.Setting3D.YAxis,
                        BbHeaderSetting.Setting3D.ZAxis);
                    if (through)
                        thickness = mainPart.Profile.Depth;
                    else
                        thickness = mainPart.Profile.Depth / 2;
                    break;
                case SemHoleLocation.Top:
                default:
                    pos = BbPosition3D.Create(
                        BbCoordinate3D.Create(
                            position.Y,
                            (mainPart.Profile.Depth / 2),
                            position.X
                            ),
                        BbHeaderSetting.Setting3D.YAxisMinus,
                        BbHeaderSetting.Setting3D.ZAxis);
                    if (through)
                        thickness = mainPart.Profile.Depth;
                    else
                        thickness = mainPart.Profile.Depth / 2;
                    break;
            }

            ObjectBbLocalPlacement = BbLocalPlacement3D.Create(
                hostElement.ObjectBbLocalPlacement, pos);

            BbExtrudedGeometry bbExtrudedGeometry = BbExtrudedGeometry.Create(
                profile,
                BbHeaderSetting.Setting3D.DefaultBbPosition3D,
                BbHeaderSetting.Setting3D.ZAxis,
                thickness);

            _ifcOpeningElement = new IfcOpeningElement
                {
                    GlobalId = IfcGloballyUniqueId.NewGuid(),
                    OwnerHistory = hostElement.IfcObject.OwnerHistory,
                    // Name = 
                    // Description =
                    ObjectType = "Opening",
                    ObjectPlacement = ObjectBbLocalPlacement.IfcLocalPlacement,
                    Representation = bbExtrudedGeometry.IfcProductDefinitionShape,
                };

            _ifcRelVoidsElement = new IfcRelVoidsElement
                {
                    GlobalId = IfcGloballyUniqueId.NewGuid(),
                    OwnerHistory = hostElement.IfcObject.OwnerHistory,
                    Name = type,
                    RelatingBuildingElement = hostElement.IfcObject as IfcElement,
                    RelatedOpeningElement = _ifcOpeningElement,
                };
        }

        protected BbOpening()
        {
        }

        public static BbOpening Create(BbElement hostElement,
                                     BbCoordinate2D position,
                                     BbProfile profile,
                                     SemHoleLocation location,
                                     bool through,
            string type)
        {
            var hole = new BbOpening(hostElement, position, profile, location, through, type);
            BbInstanceDB.AddToExport(hole);
            return hole;
        }
    }
}