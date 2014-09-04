using System;
using System.Collections.Generic;
using BlackBox.Service;
using IFC2X3;
using EbInstanceModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Linq;
namespace BlackBox.Predefined
{
    /// <summary>
    /// Steel assembly.
    /// </summary>
    public partial class BbAssembly : BbElement
    {
        #region properties

        //[BbAttributeRetrieve]
        public string BarCode { get; protected set; }

        public BbAssemblyIdentity BbAssemblyIdentity { get; protected set; }

        private IfcElementAssembly _ifcElementAssembly;

        [EarlyBindingInstance]
        public override IfcObject IfcObject
        {
            get { return _ifcElementAssembly; }
            protected set
            {
                _ifcElementAssembly = value as IfcElementAssembly;
                if (_ifcElementAssembly == null) throw new InvalidCastException();
            }
        }





        #region constructor



        protected BbAssembly(
            string assemblyId,
            string assemblyName,
            string assemblyMark,
            string clientMark,
            string prelimMark,
            string shippingMark,
            string barCode,
            BbSpatialElement floor)
            : this(assemblyId,
                   assemblyName,
                   assemblyMark,
                   clientMark,
                 prelimMark,
                 shippingMark,
                 barCode, floor,
                   BbHeaderSetting.Setting3D.DefaultOrigin,
            BbHeaderSetting.Setting3D.ZAxis,
            BbHeaderSetting.Setting3D.XAxis)
        {
        }


        protected BbAssembly(
            string assemblyId,
            string assemblyName,
            string assemblyMark,
            string clientMark,
            string prelimMark,
            string shippingMark,
            string barCode,
            BbSpatialElement floor,
            BbCoordinate3D position,
            BbDirection3D zAxis,
            BbDirection3D xAxis
        )
        {
            //AssemblyName = assemblyName;
            //AssemblyMark = assemblyMark;

            var pos = BbPosition3D.Create(position, zAxis, xAxis);

            ObjectBbLocalPlacement = BbLocalPlacement3D.Create(
                floor.ObjectBbLocalPlacement, pos);

            _ifcElementAssembly = new IfcElementAssembly
            {
                GlobalId = IfcGloballyUniqueId.NewGuid(),
                OwnerHistory = floor.IfcSpatialStructureElement.OwnerHistory,
                Name = assemblyName,
                Description = null,
                ObjectType = null,

                ObjectPlacement = ObjectBbLocalPlacement.IfcLocalPlacement,
                Representation = null,
                Tag = assemblyId,
                AssemblyPlace = IfcAssemblyPlaceEnum.NOTDEFINED,
                PredefinedType = IfcElementAssemblyTypeEnum.RIGID_FRAME
            };


            BbAssemblyIdentity = BbAssemblyIdentity.Create(
                //				assemblyName, 
                assemblyMark, clientMark, prelimMark, shippingMark,
                                                       barCode);
            BbAssemblyIdentity.AssignTo(this);

            AddToSpatialElement(floor);

            // var relContaineds = EarlyBindingInstanceModel.GetDataByType("IfcRelContainedInSpatialStructure");

            //var thecontained = from y in ( from x in relContaineds
            //                   select x.Value as IfcRelContainedInSpatialStructure)
            //                       where y.;

            //var b = BbInstanceDB.GetTypedList(typeof(BbAssembly));


            //if (b == null)
            //{
            //    IfcRelContainedInSpatialStructure = new IfcRelContainedInSpatialStructure
            //    {
            //        GlobalId = IfcGloballyUniqueId.NewGuid(),
            //        OwnerHistory = _ifcElementAssembly.OwnerHistory,
            //        RelatingStructure = floor.IfcSpatialStructureElement,
            //        RelatedElements = new List<IfcProduct>(),
            //    };
            //}
            //else
            //{

            //    var otherAssemblies = (from x in b.OfType<BbAssembly>()

            //                           select x).ToList();

            //    //var a = otherAssemblies as IList<BbAssembly>;

            //    var other = (from x in otherAssemblies
            //                 where x.BbSpatialElement.IfcSpatialStructureElement.Name
            //                 == BbSpatialElement.IfcSpatialStructureElement.Name
            //                 select x).First();
            //    if (other == null)
            //    {
            //        IfcRelContainedInSpatialStructure = new IfcRelContainedInSpatialStructure
            //        {
            //            GlobalId = IfcGloballyUniqueId.NewGuid(),
            //            OwnerHistory = _ifcElementAssembly.OwnerHistory,
            //            RelatingStructure = BbSpatialElement.IfcSpatialStructureElement,
            //            RelatedElements = new List<IfcProduct>(),
            //        };
            //    }
            //    else
            //    {
            //        IfcRelContainedInSpatialStructure = other.IfcRelContainedInSpatialStructure;
            //    }
            //}

            //IfcRelContainedInSpatialStructure.RelatedElements.Add(_ifcElementAssembly);

        }



        protected BbAssembly(
            BbSpatialElement floor,
            IfcElementAssembly assembly,
            IfcRelContainedInSpatialStructure spatialStructure)
        {
            //BbSpatialElement = floor;
            _ifcElementAssembly = assembly;
            AddToSpatialElement(floor);

        }

        public static BbAssembly Create(
            string assemblyId,
            string assemblyName,
            string assemblyMark,
            string clientMark,
            string prelimMark,
            string shippingMark,
            string barCode,
            BbSpatialElement floor)
        {
            var steelAssembly = new BbAssembly(
                assemblyId,
                assemblyName, assemblyMark, clientMark,
                 prelimMark,
                 shippingMark,
                 barCode, floor);
            //floor.AddContained(steelAssembly);
            //steelAssembly.AddToSpatialElement(floor);
            BbInstanceDB.AddToExport(steelAssembly);
            return steelAssembly;
        }

        public static BbAssembly Create(
            string assemblyId,
            string assemblyName,
            string assemblyMark,
            string clientMark,
            string prelimMark,
            string shippingMark,
            string barCode,
            BbSpatialElement floor,
            BbCoordinate3D position,
            BbDirection3D zAxis,
            BbDirection3D xAxis)
        {
            var steelAssembly = new BbAssembly(
                assemblyId,
                assemblyName, assemblyMark, clientMark,
                 prelimMark,
                 shippingMark,
                 barCode, floor,
                position, zAxis, xAxis);
            //floor.AddContained(steelAssembly);
            BbInstanceDB.AddToExport(steelAssembly);
            return steelAssembly;
        }

        //public static ICollection<BbAssembly> Retrieve(BbSpatialElement floor)
        //{
        //    /*
        //    var ret = new List<BbAssembly>();

        //    if (!EarlyBindingInstanceModel.TheModel.DataByType.ContainsKey("IfcElementAssembly")) return null;
        //    var collection = EarlyBindingInstanceModel.TheModel.DataByType["IfcElementAssembly"].Values;
        //    foreach (var item in collection)
        //    {
        //        var elementAssembly = item as IfcElementAssembly;
        //        if (elementAssembly == null) continue;
        //        foreach (var space in floor.SpatialComponents)
        //        {
        //            if (item.EIN == space.IfcElement.EIN)
        //            {
        //                var semAssembly = new BbAssembly { _ifcElementAssembly = elementAssembly };

        //                // Retrieve Attributes
        //                var elements = RetrieveElement(semAssembly);
        //                semAssembly.Elements = elements;
        //                var paints = RetrievePaintFinish(semAssembly);
        //                semAssembly.PaintFinishes = paints;

        //                BbInstanceDB.Add(semAssembly);
        //                ret.Add(semAssembly);
        //            }
        //        }
        //    }
        //    return ret;
        //    */

        //    var refed = EarlyBindingInstanceModel.GetReferencedEntities(floor.IfcSpatialStructureElement.EIN);
        //    //if (refed.Count <= 0) throw new InvalidDataException();

        //    var ret = new List<BbAssembly>();
        //    foreach (var p21Instance in refed)
        //    {
        //        if (p21Instance.Value.GetType() != typeof(IfcRelContainedInSpatialStructure)) continue;
        //        var agg = p21Instance.Value as IfcRelContainedInSpatialStructure;
        //        if (agg == null) continue;

        //        foreach (var instance in agg.RelatedElements)
        //        {
        //            if (instance.GetType() != typeof(IfcElementAssembly)) continue;
        //            var assembly = instance as IfcElementAssembly;
        //            if (assembly == null) continue;
        //            var semAssembly = new BbAssembly(floor, assembly, agg);
        //            ret.Add(semAssembly);
        //            BbInstanceDB.AddToExport(semAssembly);
        //            var paints = RetrievePaintFinish(semAssembly);
        //            semAssembly.PaintFinishes = paints;
        //        }
        //    }
        //    return ret;

        //}

        //public void AddElement (BbElement element)
        //{
        //    if (Elements == null) {
        //        Elements = new List<BbElement> ();
        //    }
        //    Elements.Add (element);

        //    if (IfcRelAggregates == null) {
        //        IfcRelAggregates = new IfcRelAggregates
        //        {
        //            GlobalId = IfcGloballyUniqueId.NewGuid(),
        //            OwnerHistory = IfcElement.OwnerHistory,
        //            RelatingObject = IfcElement,
        //            RelatedObjects = new List<IfcObjectDefinition>(),
        //        };
        //    }
        //    IfcRelAggregates.RelatedObjects.Add (element.IfcElement);
        //}
        /*
        private static List<BbElement> RetrieveElement(BbAssembly assembly)
        {
            var semElements = new List<BbElement>();
            if (!EarlyBindingInstanceModel.TheModel.DataByType.ContainsKey("IfcRelAggregates")) return null;
            var collection = EarlyBindingInstanceModel.TheModel.DataByType["IfcRelAggregates"].Values;
            //if (collection.Count != 1) throw new NotImplementedException();
            foreach (var item in collection)
            {
                var theItem = item as IfcRelAggregates;
                if (theItem == null) continue;
                if (theItem.RelatingObject.EIN == assembly._ifcElementAssembly.EIN)
                {
                    foreach (var a in theItem.RelatedObjects)
                    {
                        var element = a as IfcElement;
                        if (element == null) continue;
                        var semElement = new BbElement { IfcElement = element };
                        assembly.IfcRelAggregates = theItem;
                        BbInstanceDB.Add(semElement);
                        semElements.Add(semElement);
                    }
                }
            }
            return semElements;
        }
        */



        //private static List<BbPaintFinish> RetrievePaintFinish(BbAssembly assembly)
        //{
        //    /*
        //    var semPaintFinishes = new List<PaintFinish>();
        //    if (EarlyBindingInstanceModel.TheModel.DataByType.ContainsKey("IfcRelCoversBldgElements"))
        //    {
        //        var collection = EarlyBindingInstanceModel.TheModel.DataByType["IfcRelCoversBldgElements"].Values;
        //        //if (collection.Count != 1) throw new NotImplementedException();
        //        foreach (var item in collection)
        //        {
        //            var theItem = item as IfcRelCoversBldgElements;
        //            if (theItem == null) continue;
        //            if (theItem.RelatingBuildingElement.EIN == assembly._ifcElementAssembly.EIN)
        //            {
        //                foreach (var a in theItem.RelatedCoverings)
        //                {
        //                    var paint = a as IfcCovering;
        //                    if (paint == null) continue;
        //                    var semPaint = new PaintFinish { IfcCovering = paint };
        //                    assembly.IfcRelCoversBldgElements = theItem;
        //                    BbInstanceDB.Add(semPaint);
        //                    semPaintFinishes.Add(semPaint);
        //                }
        //            }
        //        }
        //    }
        //    return semPaintFinishes;
        //    */


        //    var refed = EarlyBindingInstanceModel.GetReferencedEntities(assembly._ifcElementAssembly.EIN);
        //    //if (refed.Count <= 0) throw new InvalidDataException();

        //    var ret = new List<BbPaintFinish>();
        //    foreach (var p21Instance in refed)
        //    {
        //        if (p21Instance.Value.GetType() != typeof(IfcRelCoversBldgElements)) continue;
        //        var agg = p21Instance.Value as IfcRelCoversBldgElements;
        //        if (agg == null) continue;

        //        foreach (var instance in agg.RelatedCoverings)
        //        {
        //            if (instance.GetType() != typeof(IfcCovering)) continue;
        //            var paint = instance as IfcCovering;
        //            if (paint == null) continue;
        //            var paintFinish = new BbPaintFinish(paint, agg);
        //            ret.Add(paintFinish);
        //        }
        //    }
        //    return ret;

        //}


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            /// todo: list all value of accessor and print out
            /// ex, BarCode : some value
            return ShowContents();
        }

        string ShowContents()
        {

            foreach (PropertyInfo propertyInfo in this.GetType().GetProperties())
            {
                if (IsSemAttributeRetrieve(propertyInfo))
                {

                    continue;
                }



            }
            return "show me";
        }

        private static bool IsSemAttributeRetrieve(PropertyInfo property)
        {
            foreach (object attribute in property.GetCustomAttributes(true))
            {
                if (attribute is BbAttributeRetrieve)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion
    }
        #endregion
}