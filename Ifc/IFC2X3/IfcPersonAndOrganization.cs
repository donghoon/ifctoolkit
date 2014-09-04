namespace IFC2X3
{
    public partial class IfcPersonAndOrganization
    {
        public IfcPersonAndOrganization(IfcPerson person, IfcOrganization organization)
        {
            ThePerson = person;
            TheOrganization = organization;
        }
    }
}