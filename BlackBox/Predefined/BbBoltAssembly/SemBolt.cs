using System.Collections.Generic;
using BlackBox.Service;
using IFC2X3;
using EbInstanceModel;



namespace BlackBox.Predefined
{
    /// <summary>
    /// Weld.
    /// </summary>
    public class BbBoltAssembly : BbFastener
    {

        IfcMechanicalFastener _ifcElement;

        [EarlyBindingInstance]
        public override IfcObject IfcObject
        {
            get { return _ifcElement; }
            protected set { base.IfcObject = _ifcElement = value as IfcMechanicalFastener; }
        }



        public BbElement MainElement { get; private set; }
        public BbElement AttachedElement { get; private set; }

        public BbPropertySet BbPropertySet { get; private set; }


        private BbCurveGeometry _boltDirection;

        public BbCurveGeometry BoltDirection
        {
            get { return _boltDirection; }
            private set
            {
                _boltDirection = value;
                _ifcElement.Representation = _boltDirection.IfcProductDefinitionShape;
            }
        }

        protected BbBoltAssembly(BbElement mainElement, BbElement attachedElement)
            : this()
        {


            MainElement = mainElement;
            AttachedElement = attachedElement;

            IfcRelConnectsElements = new IfcRelConnectsWithRealizingElements
            {
                GlobalId = IfcGloballyUniqueId.NewGuid(),
                OwnerHistory = BbHeaderSetting.Setting3D.IfcOwnerHistory,
                RelatingElement = MainElement.IfcObject as IfcElement,
                RelatedElement = AttachedElement.IfcObject as IfcElement,
                RealizingElements = new List<IfcElement> { _ifcElement },
            };
        }

        protected BbBoltAssembly()
        {
            _ifcElement = new IfcMechanicalFastener
            {
                GlobalId = IfcGloballyUniqueId.NewGuid(),
                OwnerHistory = BbHeaderSetting.Setting3D.IfcOwnerHistory,

                ObjectType = "Bolt",

            };
        }

        public static BbBoltAssembly Create(
            BbElement mainElement, BbElement attchedElement, BbCurveGeometry boltDirection, BbCoordinate3D position)
        {
            var bolt = new BbBoltAssembly(mainElement, attchedElement);
            bolt.AddBoltDirection(boltDirection, position);
            BbInstanceDB.AddToExport(bolt);
            return bolt;
        }



        protected void AddBoltDirection(BbCurveGeometry boltDirection, BbCoordinate3D position)
        {
            BoltDirection = boltDirection;
            var pos = BbPosition3D.Create(position, BbHeaderSetting.Setting3D.ZAxis, BbHeaderSetting.Setting3D.XAxis);
            ObjectBbLocalPlacement = BbLocalPlacement3D.Create(
                MainElement.ObjectBbLocalPlacement, pos);

            _ifcElement.ObjectPlacement = ObjectBbLocalPlacement.IfcLocalPlacement;
        }


        //protected void AddBoltDirection(BbElement hostElement,
        //    BbCoordinate2D position,
        //    BbProfile profile,
        //    SemHoleLocation location,
        //    bool through,
        //    string type)
        //{
        //    var mainPart = hostElement as BbPiece;
        //    if (mainPart == null)
        //        return;


        //    double thickness;
        //    BbPosition3D pos;

        //    // x direction follows extrusion direction
        //    // extrude origin  projected to bottom or left becomes the origin

        //    switch (location)
        //    {

        //        case SemHoleLocation.Left:
        //            pos = BbPosition3D.Create(
        //                BbCoordinate3D.Create(
        //                    -(mainPart.Profile.Width / 2),
        //                    position.Y,
        //                    position.X),
        //                BbDirection3D.XAxis,
        //                BbDirection3D.ZAxis);
        //            if (through)
        //                thickness = mainPart.Profile.Width;
        //            else
        //                thickness = mainPart.Profile.Width / 2;
        //            break;
        //        case SemHoleLocation.Right:
        //            pos = BbPosition3D.Create(
        //                BbCoordinate3D.Create(
        //                    (mainPart.Profile.Width / 2),
        //                    position.Y,
        //                    position.X),
        //                BbDirection3D.XAxisMinus,
        //                BbDirection3D.ZAxis);
        //            if (through)
        //                thickness = mainPart.Profile.Width;
        //            else
        //                thickness = mainPart.Profile.Width / 2;
        //            break;
        //        case SemHoleLocation.Web:
        //            if (through)
        //            {
        //                pos = BbPosition3D.Create(
        //                    BbCoordinate3D.Create(
        //                        (mainPart.Profile.Width / 2),
        //                        position.Y,
        //                        position.X
        //                        ),
        //                    BbDirection3D.XAxisMinus,
        //                    BbDirection3D.ZAxis);
        //                thickness = mainPart.Profile.Width;
        //            }
        //            else
        //            {
        //                pos = BbPosition3D.Create(
        //                    BbCoordinate3D.Create(
        //                        (mainPart.Profile.Width / 4),
        //                        position.Y,
        //                        position.X
        //                        ),
        //                    BbDirection3D.XAxisMinus,
        //                    BbDirection3D.ZAxis);
        //                thickness = mainPart.Profile.Width / 2;
        //            }
        //            break;

        //        case SemHoleLocation.Bottom:
        //            pos = BbPosition3D.Create(
        //                BbCoordinate3D.Create(
        //                    position.Y,
        //                    -(mainPart.Profile.Depth / 2),
        //                    position.X
        //                    ),
        //                BbDirection3D.YAxis,
        //                BbDirection3D.ZAxis);
        //            if (through)
        //                thickness = mainPart.Profile.Depth;
        //            else
        //                thickness = mainPart.Profile.Depth / 2;
        //            break;
        //        case SemHoleLocation.Top:
        //        default:
        //            pos = BbPosition3D.Create(
        //                BbCoordinate3D.Create(
        //                    position.Y,
        //                    (mainPart.Profile.Depth / 2),
        //                    position.X
        //                    ),
        //                BbDirection3D.YAxisMinus,
        //                BbDirection3D.ZAxis);
        //            if (through)
        //                thickness = mainPart.Profile.Depth;
        //            else
        //                thickness = mainPart.Profile.Depth / 2;
        //            break;
        //    }

        //    ObjectBbLocalPlacement = BbLocalPlacement3D.Create(
        //        hostElement.ObjectBbLocalPlacement, pos);

        //    BbExtrudedGeometry semExtrudedGeometry = BbExtrudedGeometry.Create(
        //        profile,
        //        BbPosition3D.DefaultPosition,
        //        BbDirection3D.ZAxis,
        //        thickness);

        //    ifcOpeningElement = new IfcOpeningElement
        //    {
        //        GlobalId = IfcGloballyUniqueId.NewGuid(),
        //        OwnerHistory = hostElement.IfcObject.OwnerHistory,
        //        // Name = 
        //        // Description =
        //        ObjectType = "Opening",
        //        ObjectPlacement = ObjectBbLocalPlacement.IfcLocalPlacement,
        //        Representation = semExtrudedGeometry.IfcProductDefinitionShape,
        //    };

        //    ifcRelVoidsElement = new IfcRelVoidsElement
        //    {
        //        GlobalId = IfcGloballyUniqueId.NewGuid(),
        //        OwnerHistory = hostElement.IfcObject.OwnerHistory,
        //        Name = type,
        //        RelatingBuildingElement = hostElement.IfcObject as IfcElement,
        //        RelatedOpeningElement = ifcOpeningElement,
        //    };
        //}

        public string BoltStandard { get; set; }
        public string BoltType { get; set; }

        public List<string> BoltGrade
        {
            get { return _boltGrade; }
        }

        private readonly List<string> _boltGrade = new List<string>();

        public double BoltDiameter { get; set; }
        public double BoltLength { get; set; }
        public bool BoltFiledAssembled { get; set; }



        public void AddProperties(
            BbPropertySet bbPropertySet,
            string boltStandard, string boltType, string boltGrade,

            double? boltDiameter, double? boltLength, bool? boltFiledAssembled)
        {
            if (BbPropertySet == null)
                BbPropertySet = bbPropertySet;
            if (!string.IsNullOrWhiteSpace(boltStandard))
            {
                BoltStandard = boltStandard;
                bbPropertySet.AddProperty(BbSingleProperty.Create("BoltStandard", BoltStandard, true));
            }

            if (!string.IsNullOrEmpty(boltGrade))
            {
                BoltGrade.Add(boltGrade);
                bbPropertySet.AddProperty(BbListProperty.Create("BoltGrade", boltGrade, typeof(IfcLabel)));
            }


            if (!string.IsNullOrWhiteSpace(boltType))
            {
                BoltType = boltType;
                bbPropertySet.AddProperty(BbSingleProperty.Create("BoltType", BoltType, true));
            }

           
            if (boltDiameter != null)
            {
                BoltDiameter = boltDiameter.Value;
                bbPropertySet.AddProperty(BbSingleProperty.Create("BoltDiameter", BoltDiameter, typeof(IfcPositiveLengthMeasure)));
            }
            else
            {
                BoltDiameter = 0.0;
            }

            if (boltFiledAssembled != null)
            {
                BoltFiledAssembled = boltFiledAssembled.Value;
                bbPropertySet.AddProperty(BbSingleProperty.Create("BoltFiledAssembled", BoltFiledAssembled));
            }
            else
            {
                BoltDiameter = 0.0;
            }

            if (boltLength != null)
            {
                BoltLength = boltLength.Value;
                bbPropertySet.AddProperty(BbSingleProperty.Create("BoltLength", BoltLength, typeof(IfcPositiveLengthMeasure)));
            }
            else
            {
                BoltLength = 0.0;
            }

        }

        
    }



}

