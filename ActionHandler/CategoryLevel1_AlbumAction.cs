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
    public class CategoryLevel1_AlbumAction:IAction
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
                    case "Sel_ByCodeAlbum_ByIDLang":
                        this.Sel_ByCodeAlbum_ByIDLang(context);
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
        public void Sel_ByCodeAlbum_ByIDLang(HttpContext context)
        {

            String jSonString = "";
            AlbumsBO albumBO = new AlbumsBO();
            int IDLang = string.IsNullOrEmpty(context.Request.QueryString["IDLang"]) ? CORE_Language.sys_CUR_LANG : int.Parse(context.Request.QueryString["IDLang"]);
            string CodeAlbum = string.IsNullOrEmpty(context.Request.QueryString["CodeAlbum"]) ? "000" : context.Request.QueryString["CodeAlbum"].ToString();


            List<Albums> obj = albumBO.Sel_ByCodeAlbum_ByIDLang(CodeAlbum,IDLang).ToList();
            
            
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
