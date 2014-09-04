using System;

namespace IFC2X3
{
    public partial class IfcOwnerHistory
    {

        public IfcOwnerHistory(IfcPersonAndOrganization owningUser, IfcApplication application)
        {
            if (owningUser == null) throw new ArgumentNullException("owningUser");
            OwningUser = owningUser;
            OwningApplication = application;
            ChangeAction = IfcChangeActionEnum.NOCHANGE;
            CreationDate = IfcTimeStamp.GetTimeStamp();
        }
    }
}