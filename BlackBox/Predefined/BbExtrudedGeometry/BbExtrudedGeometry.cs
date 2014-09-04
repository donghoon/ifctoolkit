using System.Collections.Generic;
using BlackBox.Service;
using IFC2X3;
using EbInstanceModel;

namespace BlackBox.Predefined
{
    public partial class BbExtrudedGeometry : BbElementGeometry
	{

		private IfcExtrudedAreaSolid _ifcExtrudedAreaSolid;
        private IfcShapeRepresentation _ifcShapeRepresentation;
        private IfcProductDefinitionShape _ifcProductDefinitionShape;


		[EarlyBindingInstance]
		public override IfcGeometricRepresentationItem IfcGeometricRepresentationItem { 
			get{return _ifcExtrudedAreaSolid;}
            set { _ifcExtrudedAreaSolid = value as IfcExtrudedAreaSolid; }
		}

		[EarlyBindingInstance]
		public override IfcShapeRepresentation  IfcShapeRepresentation{ get { return _ifcShapeRepresentation; } }
		[EarlyBindingInstance]
		public override IfcProductDefinitionShape IfcProductDefinitionShape { get { return _ifcProductDefinitionShape; } }


		public BbExtrudedGeometry (
			BbProfile profile,
			BbPosition3D position3D,
			BbDirection3D direction3D,
			double depth
			)
		{
			_ifcExtrudedAreaSolid = new IfcExtrudedAreaSolid{
				SweptArea = profile.IfcProfileDef,
				Position = position3D.IfcAxis2Placement3D,
				ExtrudedDirection = direction3D.IfcDirection,
				Depth = depth,
			};

			_ifcShapeRepresentation = new IfcShapeRepresentation
			{
                ContextOfItems = BbHeaderSetting.Setting3D.GeometricRepresentationContext,
				RepresentationIdentifier = "Body",
				RepresentationType = "SweptSolid",
				Items = new List<IfcRepresentationItem>(),
			};
			_ifcShapeRepresentation.Items.Add(_ifcExtrudedAreaSolid);
			
			_ifcProductDefinitionShape = new IfcProductDefinitionShape
			{
				// Name=
				// Description = 
				Representations = new List<IfcRepresentation>(),
			};
			_ifcProductDefinitionShape.Representations.Add(_ifcShapeRepresentation);
		}

        public BbExtrudedGeometry()
        {
        }

		public static BbExtrudedGeometry Create(
			BbProfile profile,
			BbPosition3D position3D,
			BbDirection3D direction3D,
			double depth)
		{
			var extrudedGeometry = new BbExtrudedGeometry(profile,
			                             position3D,
			                             direction3D,
			                             depth);

			return extrudedGeometry;
		}


//		public static IfcProductDefinitionShape Create(IfcRepresentationContext representationContext,
//		                                               IfcProfileDef ifcProfileDef, 
//		                                               IfcAxis2Placement3D placement3D, 
//		                                               IfcDirection direction, 
//		                                               double depth)
//		{
//			var extruded = new IfcExtrudedAreaSolid
//			{
//				SweptArea = ifcProfileDef,
//				Position =  placement3D,
//				ExtrudedDirection = direction ,
//				Depth = depth,
//			};
//			
//			var shaperep = new IfcShapeRepresentation
//			{
//				ContextOfItems = representationContext,
//				RepresentationIdentifier = "Body",
//				RepresentationType = "SweptSolid",
//				Items = new List<IfcRepresentationItem>(),
//			};
//			shaperep.Items.Add(extruded);
//			
//			var ifcShape = new IfcProductDefinitionShape
//			{
//				// Name=
//				// Description = 
//				Representations = new List<IfcRepresentation>(),
//			};
//			ifcShape.Representations.Add(shaperep);
//			
//			return ifcShape;
//		}
//
//


        public static BbExtrudedGeometry RetrieveFromMainPiece(BbElement mainPiece)
        {
            var ret = new BbExtrudedGeometry();
            var ipds = mainPiece.IfcObject as IfcElement;
            var iPDS = ipds.Representation as IfcProductDefinitionShape;
            var reps = iPDS.Representations;
            foreach (var rep in reps)
            {
                var iSR = rep as IfcShapeRepresentation;
                var repItems = rep.Items;
                foreach (var repItem in repItems)
                {
                    var ExtGeo = repItem as IfcExtrudedAreaSolid;
                    if (ExtGeo == null) continue;
                    var semExGeo = new BbExtrudedGeometry { IfcGeometricRepresentationItem = ExtGeo, _ifcProductDefinitionShape = iPDS, _ifcShapeRepresentation = iSR };
                    BbInstanceDB.AddToExport(semExGeo);
                    //var profile = BbProfile.Retrieve(semExGeo);
                    //mainPiece.Profile = profile;
                    ret = semExGeo;
                }
            }
            return ret;
        }

        public static BbExtrudedGeometry RetrieveFromFeature(BbFeature feature)
        {
            var ret = new BbExtrudedGeometry(); 
            // need modification
            //var pDS = feature.IfcOpeningElement.Representation as IfcProductDefinitionShape;
            //var representations = pDS.Representations;
            //foreach (var representation in representations)
            //{
            //    var sR = representation as IfcShapeRepresentation;
            //    var repItems = representation.Items;
            //    foreach (var repItem in repItems)
            //    {
            //        var eAS = repItem as IfcExtrudedAreaSolid;
            //        var semExtudedGeometry = new BbExtrudedGeometry { _ifcProductDefinitionShape = pDS, IfcGeometricRepresentationItem = eAS, _ifcShapeRepresentation = sR };
            //        ret = semExtudedGeometry;
            //    }
            //}
            return ret;
        }

	}
}

