using BlackBox.Service;

namespace BlackBox.Predefined
{
    public class BbPieceIdentity : BbBase
    {
        //public string Name { get; private set; }

        public string IndicationMark { get; private set; }

        public string PieceMark { get; private set; }

        public string PrelimMark { get; private set; }

        public string BarCode { get; private set; }


        public BbPropertySet BbPropertySet { get; private set; }


        BbPieceIdentity(
            //string name,
            string indicationMark,
            string pieceMark,
            string prelimMark,
            string barCode,
            bool isMainPiece)
        {
            //Name = name;
            IndicationMark = indicationMark;
            PieceMark = pieceMark;
            PrelimMark = prelimMark;
            BarCode = barCode;

            BbPropertySet = BbPropertySet.Create("PieceIdentificationProperty");
            if (!string.IsNullOrWhiteSpace(indicationMark))
                BbPropertySet.AddProperty(BbSingleProperty.Create("IndicationMark", indicationMark, true));
            if (!string.IsNullOrWhiteSpace(pieceMark))
                BbPropertySet.AddProperty(BbSingleProperty.Create("PieceMark", pieceMark, true));
            if (!string.IsNullOrWhiteSpace(prelimMark))
                BbPropertySet.AddProperty(BbSingleProperty.Create("PrelimMark", prelimMark, true));
            if (!string.IsNullOrWhiteSpace(barCode))
                BbPropertySet.AddProperty(BbSingleProperty.Create("BarCode", barCode, true));
            BbPropertySet.AddProperty(BbSingleProperty.Create("MainPieceTag", isMainPiece));
        }

        public static BbPieceIdentity Create(
            //string name,
            //string pieceMark,
            string indicationMark,
            string pieceMark,
            string prelimMark,
            string barCode,
            bool isMainPiece)
        {
            var ai = new BbPieceIdentity(
                //name,
                indicationMark,
                pieceMark,
                prelimMark,
                barCode, isMainPiece);
            return ai;
        }

        public void AssignTo(BbElement element)
        {
            BbPropertySet.AssignTo(element);
        }


    }
}
