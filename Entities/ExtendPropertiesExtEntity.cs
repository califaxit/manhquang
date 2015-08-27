using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesExt
{
    public class ExtendPropertiesExtEntity:ExtendProperties
    {
        public void SetValue(ExtendProperties aExtendProperties )
        {
            this.ID = aExtendProperties.ID;
            this.Name = aExtendProperties.Name;
            this.Value = aExtendProperties.Value;
            this.ValueType = aExtendProperties.ValueType;
            this.Image = aExtendProperties.Image;
            this.Code = aExtendProperties.Code;
            this.IDObject = aExtendProperties.IDObject;
            this.ObjectType = aExtendProperties.ObjectType;
            this.IDLang = aExtendProperties.IDLang;
            this.Type = aExtendProperties.Type;
            this.Group = aExtendProperties.Group;
            this.Status = aExtendProperties.Status;
            this.CodeObject = aExtendProperties.CodeObject;
            this.Disable = aExtendProperties.Disable;
        }
        public ExtendProperties ConvertToExtendProperties()
        {
            ExtendProperties aExtendProperties = new ExtendProperties();
              aExtendProperties.ID=this.ID ;
             aExtendProperties.Name= this.Name;
             aExtendProperties.Value = this.Value; ;
             aExtendProperties.ValueType=this.ValueType;
             aExtendProperties.Image=this.Image;
             aExtendProperties.Code=this.Code;
             aExtendProperties.IDObject=this.IDObject;
             aExtendProperties.ObjectType=this.ObjectType;
             aExtendProperties.IDLang=this.IDLang;
            aExtendProperties.Type=this.Type;
            aExtendProperties.Group=this.Group;
            aExtendProperties.Status=this.Status;
            aExtendProperties.CodeObject=this.CodeObject;
            aExtendProperties.Disable=this.Disable;
            return aExtendProperties;
        }
    }
}
