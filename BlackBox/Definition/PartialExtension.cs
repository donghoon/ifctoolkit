using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BlackBox.Service;

namespace BlackBox
{
    public partial class BbDefinition
    {
        //public bool SaveToDb()
        //{
        //    var semDef = new Sem_definition()
        //    {
        //      //  Guid = this.Guid,
        //      //  Name = this.InputName,
        //        //Super = Guid.Parse(SemFamilyList.SelectedValue),
        //        Description = this.Description,
        //        //Full_description = FullDescription.Text,
        //        //Creator = Page.User.Identity.Name,
        //        Creation_date = DateTime.Now,
        //        //Namespace = Guid.Parse(NewDomainList.SelectedValue),
        //        //Version = _version,

        //    };

        //    if (!SemDbService.InsertOrUpdate(semDef))
        //    {
        //        return false;
        //    }


        //    var alist = new List<Sem_attribute_mapping>();
        //    foreach (var mapping in AttributeMappingList)
        //    {
        //        var amap = new Sem_attribute_mapping()
        //            {
        //                Attribute_name = mapping.AttName,
        //                Datatype = mapping.AttType,
        //            };
        //        alist.Add(amap);
        //    }

        //    if (alist.Count > 0)
        //        return SemDbService.InsertOrUpdate(alist);

        //    return true;
        //}
    }

    public partial class AttributeDefinition
    {

        
    }
}
