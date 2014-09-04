using IFC2X3;
using Sem.Service;
using EbInstanceModel;
using System.Collections.Generic;

namespace Sem.Predefined
{
    public class SemWeldType : SemTypeProduct
    {
        protected SemWeldType(string name, string pieceMark)
            : base(name, pieceMark, typeof(IfcFastener))
        {
            var ifcWeldType = IfcTypeProduct as IfcFastenerType;
            if (ifcWeldType == null) return;
            ifcWeldType.ElementType = "Weld";
        }

        private SemWeldType()
        {
        }

        public static SemWeldType Create(string name, string pieceMark)
        {
            var weldType = new SemWeldType(name, pieceMark);
            SemInstanceDB.AddToExport(weldType);
            return weldType;
        }

        public static SemWeldType Retrieve(SemFastener weld)
        {
            var ret = new SemWeldType();

            //if (!EarlyBindingInstanceModel.TheModel.DataByType.ContainsKey("IfcRelDefinesByType")) return null;
            var collection = EarlyBindingInstanceModel.GetDataByType("IfcRelDefinesByType").Values;
            foreach (var theItem in collection)
            {
                var relType = theItem as IfcRelDefinesByType;
                var relObjects = relType.RelatedObjects;
                foreach (var relObject in relObjects)
                {
                    if (relObject.EIN == weld.IfcObject.EIN)
                    {
                        //if (!EarlyBindingInstanceModel.TheModel.DataByType.ContainsKey("IfcFastenerType")) return null;
                        var collection1 = EarlyBindingInstanceModel.GetDataByType("IfcFastenerType").Values;
                        foreach (var item in collection1)
                        {
                            if (relType.RelatingType.EIN == item.EIN)
                            {
                                var weldType = item as IfcFastenerType;
                                if (weldType == null) continue;
                                var semWeldType = new SemWeldType { IfcTypeProduct = weldType, IfcRelDefinesByType = relType };
                                semWeldType.DefinedElements.Add(weld);

                                // check if this SemWeldSemType exist or not before adding to DB and add weld to its DefinedElements
                                //SemInstanceDB.Add(semWeldType);// Q1
                                ret = semWeldType;
                            }
                        }
                    }
                } 
            }
            return ret;
        }
    }
}