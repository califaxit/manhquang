using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Web;
using Library;
using Newtonsoft.Json;
using EntitiesExt;
using Newtonsoft.Json.Converters;
using BussinessLogic;
using System.IO;
using System.Globalization;
using CORE;
using DataAccess;
using Bussiness;


namespace ActionHandler
{
    public class CategoryLevel1_CategoryLevel2Action:IAction
    {
        public SystemUsers aCurrentSystemUsers = new SystemUsers();
        public void Do(HttpContext context)
        {
            string action = context.Request["action"].ToString();
            if (!String.IsNullOrEmpty(action))
            {
                this.aCurrentSystemUsers = (SystemUsers)context.Session["LoginAccount"];

                switch (action)
                {
                    case "Sel_ByCodeCategoryLevel1_ByIDLang":
                        this.Sel_ByCodeCategoryLevel1_ByIDLang(context);
                        break;
                    
                    //-----------------------------------------------------------------------
                    default:
                        context.Response.Write("Can't find action");
                        break;
                }
            }
        }


        private IsoDateTimeConverter _converter = new IsoDateTimeConverter();
        private IFormatProvider culture = new CultureInfo("es-ES", true);


        //--------------// 
        public void Sel_ByCodeCategoryLevel1_ByIDLang(HttpContext context)
        {

            String jSonString = "";
            CategoryLevel1_CategoryLevel2BO aCategoryLevel1_CategoryLevel2BO = new CategoryLevel1_CategoryLevel2BO();
            int IDLang = string.IsNullOrEmpty(context.Request.QueryString["IDLang"]) ? CORE_Language.sys_CUR_LANG : int.Parse(context.Request.QueryString["IDLang"]);
            string CodeCategoryLevel1 = string.IsNullOrEmpty(context.Request.QueryString["CodeCategoryLevel1"]) ? "000" : context.Request.QueryString["CodeCategoryLevel1"].ToString();

            List<CategoryLevel1_CategoryLevel2> obj = aCategoryLevel1_CategoryLevel2BO.Sel_ByCodeCategoryLevel1_ByIDLang(CodeCategoryLevel1, IDLang).ToList();
            if (obj != null)
            {
                _converter.DateTimeFormat = "dd/MM/yyyy";
                jSonString = JsonConvert.SerializeObject(obj, _converter);
            }

            jSonString = "{\"data\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }

    }
}
