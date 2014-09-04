using IFC2X3;
using Sem.Service;
using System.Collections.Generic;
using EbInstanceModel;

namespace Sem.Predefined
{
    public partial class SemBeamType : SemTypeProduct
    {
        //public IfcBeamType ifcBeamType { get; private set; }
        protected SemBeamType(string name, string pieceMark, IfcBeamTypeEnum ifcBeamTypeEnum)
            : base(name, pieceMark, typeof (IfcBeam))
        {
            var ifcBeamType = IfcTypeProduct as IfcBeamType;
            if (ifcBeamType == null) return;
            ifcBeamType.PredefinedType = ifcBeamTypeEnum;
        }

        private SemBeamType() 
        {
        }

        public static SemBeamType Create(string name, string pieceMark, IfcBeamTypeEnum ifcBeamTypeEnum)
        {
            var beamType = new SemBeamType(name, pieceMark, ifcBeamTypeEnum);
            SemInstanceDB.AddToExport(beamType);
            return beamType;
        }



        public static SemBeamType Retrieve(SemMainPiece mainPiece)
        {
            if (mainPiece.IfcObject.GetType() == typeof(IfcBeam))
            {
                var ret = new SemBeamType();
                //if (!EarlyBindingInstanceModel.TheModel.DataByType.ContainsKey("IfcRelDefinesByType")) return null;
                var collection1 = EarlyBindingInstanceModel.GetDataByType("IfcRelDefinesByType").Values;
                //if (collection.Count != 1) throw new NotImplementedException();
                foreach (var item in collection1)
                {
                    var theItem = item as IfcRelDefinesByType;
                    if (theItem == null) continue;

                    foreach (var a in theItem.RelatedObjects)
                    {
                        if (a.EIN == mainPiece.IfcObject.EIN)
                        {
                            //if (!EarlyBindingInstanceModel.TheModel.DataByType.ContainsKey("IfcBeamType")) return null;
                            var collection2 = EarlyBindingInstanceModel.GetDataByType("IfcBeamType").Values;
                            foreach (var item2 in collection2)
                            {
                                if (item2.EIN == theItem.RelatingType.EIN)
                                {
                                    var type = item2 as IfcBeamType;
                                    if (type == null) continue;
                                    var beamType = new SemBeamType { IfcTypeProduct = type, IfcRelDefinesByType = theItem };
                                    beamType.DefinedElements.Add(mainPiece);
                                    SemInstanceDB.AddToExport(beamType);
                                    ret = beamType;
                                }
                            }
                        }
                    }
                }
                return ret;
            }
            else { return null; }
        }
    }
}