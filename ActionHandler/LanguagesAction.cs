using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Web;
using DataAccess;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using BussinessLogic;

namespace ActionHandler {
    /// <summary>
    /// Handler for Languages. 
    /// data will be recieved from client
    /// </summary>
    /// <author> Nam Chu </author>
    /// <created>10/06/15</created>
    /// <modified>
    /// Nam Chu
    /// 01/07/15
    /// 
    /// -optimize and reformat code
    /// </modified>
    /// <modified>
    /// Nam Chu
    /// 03/07/15
    /// 
    /// -update disable for select mothods
    /// -add update by type, status, disable methods
    /// -reformat and optimize code
    /// </modified>
    /// 
    /// <modified>
    /// Nam Chu
    /// 08/07/15
    /// 
    /// -fix bugs
    /// -update some methods
    /// -reformat code
    /// </modified>
    /// 

    //TODO: Ins_ListConfigs and Del_ListID is NOT available
    [SuppressMessage("ReSharper", "SimplifyConditionalTernaryExpression")]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class LanguagesAction : IAction {
        private readonly IsoDateTimeConverter _converter = new IsoDateTimeConverter();

        public void Do(HttpContext context) {
            string action = context.Request["action"];
            if (!String.IsNullOrEmpty(action)) {
                switch (action) {
                    case "Sel":
                        Sel(context);
                        break;
                    case "Sel_ByID":
                        Sel_ByID(context);
                        break;
                    case "Sel_ByType":
                        Sel_ByType(context);
                        break;
                    case "Sel_ByStatus":
                        Sel_ByStatus(context);
                        break;
                    case "Sel_ByType_ByStatus":
                        Sel_ByType_ByStatus(context);
                        break;

                    case "Ins":
                        Ins(context);
                        break;
                    case "Ins_ListLanguages":
                        Ins_ListLanguages(context);
                        break;

                    case "Upd_ByID":
                        Upd_ByID(context);
                        break;
                    case "Upd_Type_ByID":
                        Upd_Type_ByID(context);
                        break;
                    case "Upd_Status_ByID":
                        Upd_Status_ByID(context);
                        break;
                    case "Upd_Disable_ByID":
                        Upd_Disable_ByID(context);
                        break;

                    case "Del_ByID":
                        Del_ByID(context);
                        break;
                    case "Del_ByListID":
                        Del_ByListID(context);
                        break;

                    default:
                        context.Response.Write("Can't find action");
                        break;
                }
            }
        }

        private void Sel(HttpContext context) {
            string jSonString = string.Empty;
            LanguagesBO languagesBO = new LanguagesBO();
            bool disable = !String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                ? Convert.ToBoolean(context.Request.QueryString["Disable"])
                : false;
            List<Languages> listLanguages =
                String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                    ? languagesBO.Sel()
                    : languagesBO.Sel(disable);

            if (listLanguages.Any()) {
                _converter.DateTimeFormat = "dd/MM/yyyy";
                jSonString = JsonConvert.SerializeObject(listLanguages, _converter);
            }
            jSonString = "{\"data\":" + jSonString + "}";

            context.Response.Write(jSonString);
        }

        private void Sel_ByID(HttpContext context) {
            string jSonString = string.Empty;
            LanguagesBO languagesBO = new LanguagesBO();

            int id = Convert.ToInt32(context.Request.QueryString["ID"]);
            bool disable = !String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                ? Convert.ToBoolean(context.Request.QueryString["Disable"])
                : false;
            Languages languages = String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                ? languagesBO.Sel_ByID(id)
                : languagesBO.Sel_ByID(id, disable);

            if (!languages.Equals(null)) {
                _converter.DateTimeFormat = "dd/MM/yyyy";
                jSonString = JsonConvert.SerializeObject(languages, _converter);
            }
            jSonString = "{\"data\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }

        private void Sel_ByType(HttpContext context) {
            string jSonString = string.Empty;
            LanguagesBO languagesBO = new LanguagesBO();

            int type = Convert.ToInt32(context.Request.QueryString["Type"]);
            bool disable = !String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                ? Convert.ToBoolean(context.Request.QueryString["Disable"])
                : false;
            List<Languages> listLanguages =
                String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                    ? languagesBO.Sel_ByType(type)
                    : languagesBO.Sel_ByType(type, disable);

            if (listLanguages.Any()) {
                _converter.DateTimeFormat = "dd/MM/yyyy";
                jSonString = JsonConvert.SerializeObject(listLanguages, _converter);
            }
            jSonString = "{\"data\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }

        private void Sel_ByStatus(HttpContext context) {
            string jSonString = string.Empty;
            LanguagesBO languagesBO = new LanguagesBO();

            int status = Convert.ToInt32(context.Request.QueryString["Status"]);
            bool disable = !String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                ? Convert.ToBoolean(context.Request.QueryString["Disable"])
                : false;
            List<Languages> listLanguages =
                String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                    ? languagesBO.Sel_ByStatus(status)
                    : languagesBO.Sel_ByStatus(status, disable);

            if (listLanguages.Any()) {
                _converter.DateTimeFormat = "dd/MM/yyyy";
                jSonString = JsonConvert.SerializeObject(listLanguages, _converter);
            }
            jSonString = "{\"data\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }

        private void Sel_ByType_ByStatus(HttpContext context) {
            string jSonString = string.Empty;
            LanguagesBO languagesBO = new LanguagesBO();

            int type = Convert.ToInt32(context.Request.QueryString["Type"]);
            int status = Convert.ToInt32(context.Request.QueryString["Status"]);
            bool disable = !String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                ? Convert.ToBoolean(context.Request.QueryString["Disable"])
                : false;
            List<Languages> listLanguages =
                String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                    ? languagesBO.Sel_ByType_ByStatus(type, status)
                    : languagesBO.Sel_ByType_ByStatus(type, status, disable);

            if (listLanguages.Any()) {
                _converter.DateTimeFormat = "dd/MM/yyyy";
                jSonString = JsonConvert.SerializeObject(listLanguages, _converter);
            }
            jSonString = "{\"data\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }

        private void Ins(HttpContext context) {
            LanguagesBO languagesBO = new LanguagesBO();
            String jSonString = "";
            try {
                Languages aLanguages = new Languages();

                aLanguages.NameLang = !String.IsNullOrEmpty(context.Request.Form["txtNameLang"])
                    ? Convert.ToString(context.Request.Form["txtNameLang"])
                    : aLanguages.NameLang;
                aLanguages.Image = !String.IsNullOrEmpty(context.Request.Form["txtImage_1"])
                    ? Convert.ToString(context.Request.Form["txtImage_1"])
                    : aLanguages.Image;
                aLanguages.Directory = !String.IsNullOrEmpty(context.Request.Form["txtDirectory"])
                    ? Convert.ToString(context.Request.Form["txtDirectory"])
                    : aLanguages.Directory;
                aLanguages.Filename = !String.IsNullOrEmpty(context.Request.Form["txtFilename"])
                    ? Convert.ToString(context.Request.Form["txtFilename"])
                    : aLanguages.Filename;
                aLanguages.Status = !String.IsNullOrEmpty(context.Request.Form["cbbStatus"])
                    ? Convert.ToInt32(context.Request.Form["cbbStatus"])
                    : aLanguages.Status;
                aLanguages.Type = !String.IsNullOrEmpty(context.Request.Form["cbbType"])
                    ? Convert.ToInt32(context.Request.Form["cbbType"])
                    : aLanguages.Type;
                aLanguages.Disable = !String.IsNullOrEmpty(context.Request.Form["cbbDisable"])
                    ? Convert.ToBoolean(context.Request.Form["cbbDisable"])
                    : aLanguages.Disable;

                int ret = languagesBO.Ins(aLanguages);

                if (ret != 0) jSonString = "{\"status\": \"success\"}";
                if (ret == 0) jSonString = "{\"status\":\"error|" + ret + "\"}";
            }
            catch (Exception ex) {
                jSonString = "{\"status\":\"error\" ,\"message\":\"" + ex.Message + "\"}";
            }
            finally {
                context.Response.Write(jSonString);
            }
        }

        private void Ins_ListLanguages(HttpContext context) {
            throw new NotImplementedException();
        }

        private void Upd_ByID(HttpContext context) {
            LanguagesBO languagesBO = new LanguagesBO();
            String jSonString = "";
            try {
                int languagesId = Convert.ToInt32(context.Request.Form["txtID"]);
                var aLanguages = languagesBO.Sel_ByID(languagesId);

                aLanguages.NameLang = !String.IsNullOrEmpty(context.Request.Form["txtNameLang"])
                    ? Convert.ToString(context.Request.Form["txtNameLang"])
                    : aLanguages.NameLang;
                aLanguages.Image = !String.IsNullOrEmpty(context.Request.Form["txtImage_1"])
                    ? Convert.ToString(context.Request.Form["txtImage_1"])
                    : aLanguages.Image;
                aLanguages.Directory = !String.IsNullOrEmpty(context.Request.Form["txtDirectory"])
                    ? Convert.ToString(context.Request.Form["txtDirectory"])
                    : aLanguages.Directory;
                aLanguages.Filename = !String.IsNullOrEmpty(context.Request.Form["txtFilename"])
                    ? Convert.ToString(context.Request.Form["txtFilename"])
                    : aLanguages.Filename;
                aLanguages.Status = !String.IsNullOrEmpty(context.Request.Form["cbbStatus"])
                    ? Convert.ToInt32(context.Request.Form["cbbStatus"])
                    : aLanguages.Status;
                aLanguages.Type = !String.IsNullOrEmpty(context.Request.Form["cbbType"])
                    ? Convert.ToInt32(context.Request.Form["cbbType"])
                    : aLanguages.Type;
                aLanguages.Disable = !String.IsNullOrEmpty(context.Request.Form["cbbDisable"])
                    ? Convert.ToBoolean(context.Request.Form["cbbDisable"])
                    : aLanguages.Disable;
                int ret = languagesBO.Upd(aLanguages);

                if (ret != 0) jSonString = "{\"status\": \"success\"}";
                if (ret == 0) jSonString = "{\"status\":\"error|" + ret + "\"}";
            }
            catch (Exception ex) {
                jSonString = "{\"status\":\"error\" ,\"message\":\"" + ex.Message + "\"}";
            }
            finally {
                context.Response.Write(jSonString);
            }
        }

        private void Upd_Status_ByID(HttpContext context) {
            String jSonString = "";
            try {
                LanguagesBO languagesBO = new LanguagesBO();
                int id = Convert.ToInt32(context.Request.QueryString["ID"]);
                int status = Convert.ToInt32(context.Request.QueryString["Status"]);
                int ret = languagesBO.Upd_Status(id, status);
                if (ret == 0) jSonString = "{\"status\":\"error|" + ret + "\"}";
                if (ret != 0) jSonString = "{\"status\": \"success\"}";
            }
            catch (Exception ex) {
                jSonString = "{\"status\":\"error\" ,\"message\":\"" + ex.Message + "\"}";
            }
            finally {
                context.Response.Write(jSonString);
            }
        }

        private void Upd_Type_ByID(HttpContext context) {
            String jSonString = "";
            try {
                LanguagesBO languagesBO = new LanguagesBO();
                int id = Convert.ToInt32(context.Request.QueryString["ID"]);
                int type = Convert.ToInt32(context.Request.QueryString["Type"]);
                int ret = languagesBO.Upd_Type(id, type);
                if (ret == 0) jSonString = "{\"status\":\"error|" + ret + "\"}";
                if (ret != 0) jSonString = "{\"status\": \"success\"}";
            }
            catch (Exception ex) {
                jSonString = "{\"status\":\"error\" ,\"message\":\"" + ex.Message + "\"}";
            }
            finally {
                context.Response.Write(jSonString);
            }
        }

        private void Upd_Disable_ByID(HttpContext context) {
            String jSonString = "";
            try {
                LanguagesBO languagesBO = new LanguagesBO();
                int id = Convert.ToInt32(context.Request.QueryString["ID"]);
                bool disable = Convert.ToBoolean(context.Request.QueryString["Disable"]);
                int ret = languagesBO.Upd_Disable(id, disable);
                if (ret == 0) jSonString = "{\"status\":\"error|" + ret + "\"}";
                if (ret != 0) jSonString = "{\"status\": \"success\"}";
            }
            catch (Exception ex) {
                jSonString = "{\"status\":\"error\" ,\"message\":\"" + ex.Message + "\"}";
            }
            finally {
                context.Response.Write(jSonString);
            }
        }

        private void Del_ByID(HttpContext context) {
            String jSonString = "";
            try {
                int languagesId = Convert.ToInt32(context.Request.QueryString["ID"]);
                LanguagesBO languagesBO = new LanguagesBO();

                int ret = languagesBO.Del_ByID(languagesId);

                if (ret != 0) jSonString = "{\"status\": \"success\"}";
                if (ret == 0) jSonString = "{\"status\":\"error|" + ret + "\"}";
            }
            catch (Exception ex) {
                jSonString = "{\"status\":\"error\" ,\"message\":\"" + ex.Message + "\"}";
            }
            finally {
                context.Response.Write(jSonString);
            }
        }

        private void Del_ByListID(HttpContext context) {
            throw new NotImplementedException();
        }
    }
}