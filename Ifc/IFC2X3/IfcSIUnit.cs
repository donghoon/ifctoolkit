namespace IFC2X3
{
    public partial class IfcSIUnit
    {
        public IfcSIUnit(IfcUnitEnum unitType, IfcSIUnitName name)
        {
            Dimensions = new IfcDimensionalExponents();
            Dimensions.IsDerived = true;
            UnitType = unitType;
            Name = name;
        }

        public IfcSIUnit(IfcUnitEnum unitType, IfcSIPrefix prefix, IfcSIUnitName name)
        {
            Dimensions = new IfcDimensionalExponents();
            Dimensions.IsDerived = true;
            UnitType = unitType;
            Prefix = prefix;
            Name = name;
        }
    }
}