using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using BussinessLogic;
using DataAccess;

namespace ActionHandler {
    /// <summary>
    /// Handler for Configs. 
    /// data will be recieved from client
    /// </summary>
    /// <author> Nam Chu </author>
    /// <created>10/06/15</created>
    /// 
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
    public class ConfigsAction : IAction {
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
                    case "Sel_ByAccessKey":
                        Sel_ByAccessKey(context);
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
                    case "Ins_ListConfigs":
                        Ins_ListConfigs(context);
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
            ConfigsBO configsBO = new ConfigsBO();
            bool disable = !String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                ? Convert.ToBoolean(context.Request.QueryString["Disable"])
                : false;
            List<Configs> listConfigs = String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                ? configsBO.Sel()
                : configsBO.Sel(disable);
            if (listConfigs.Any()) {
                _converter.DateTimeFormat = "dd/MM/yyyy";
                jSonString = JsonConvert.SerializeObject(listConfigs, _converter);
            }
            jSonString = "{\"data\":" + jSonString + "}";

            context.Response.Write(jSonString);
        }

        private void Sel_ByID(HttpContext context) {
            string jSonString = string.Empty;
            ConfigsBO configsBO = new ConfigsBO();
            int id = Convert.ToInt32(context.Request.QueryString["ID"]);
            bool disable = !String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                ? Convert.ToBoolean(context.Request.QueryString["Disable"])
                : false;
            Configs configs = String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                ? configsBO.Sel_ByID(id)
                : configsBO.Sel_ByID(id, disable);
            if (configs != null) {
                _converter.DateTimeFormat = "dd/MM/yyyy";
                jSonString = JsonConvert.SerializeObject(configs, _converter);
            }
            jSonString = "{\"data\":" + jSonString + "}";

            context.Response.Write(jSonString);
        }

        private void Sel_ByAccessKey(HttpContext context) {
            string jSonString = string.Empty;
            ConfigsBO configsBO = new ConfigsBO();
            string accessKey = context.Request.QueryString["AccessKey"];
            bool disable = !String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                ? Convert.ToBoolean(context.Request.QueryString["Disable"])
                : false;
            List<Configs> listConfigs = String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                ? configsBO.Sel_ByAccessKey(accessKey)
                : configsBO.Sel_ByAccessKey(accessKey, disable);
            if (listConfigs.Any()) {
                _converter.DateTimeFormat = "dd/MM/yyyy";
                jSonString = JsonConvert.SerializeObject(listConfigs, _converter);
            }
            jSonString = "{\"data\":" + jSonString + "}";

            context.Response.Write(jSonString);
        }

        private void Sel_ByType(HttpContext context) {
            String jSonString = "";
            ConfigsBO configsBO = new ConfigsBO();
            int type = Convert.ToInt32(context.Request.QueryString["Type"]);
            bool disable = !String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                ? Convert.ToBoolean(context.Request.QueryString["Disable"])
                : false;
            List<Configs> listConfigs = String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                ? configsBO.Sel_ByType(type)
                : configsBO.Sel_ByType(type, disable);
            if (listConfigs.Any()) {
                _converter.DateTimeFormat = "dd/MM/yyyy";
                jSonString = JsonConvert.SerializeObject(listConfigs, _converter);
            }
            jSonString = "{\"data\":" + jSonString + "}";

            context.Response.Write(jSonString);
        }

        private void Sel_ByStatus(HttpContext context) {
            String jSonString = "";
            ConfigsBO configsBO = new ConfigsBO();
            int status = Convert.ToInt32(context.Request.QueryString["Status"]);
            bool disable = !String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                ? Convert.ToBoolean(context.Request.QueryString["Disable"])
                : false;
            List<Configs> listConfigs = String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                ? configsBO.Sel_ByStatus(status)
                : configsBO.Sel_ByStatus(status, disable);
            if (listConfigs.Any()) {
                _converter.DateTimeFormat = "dd/MM/yyyy";
                jSonString = JsonConvert.SerializeObject(listConfigs, _converter);
            }
            jSonString = "{\"data\":" + jSonString + "}";

            context.Response.Write(jSonString);
        }

        private void Sel_ByType_ByStatus(HttpContext context) {
            String jSonString = "";
            ConfigsBO configsBO = new ConfigsBO();

            int type = Convert.ToInt32(context.Request.QueryString["Type"]);
            int status = Convert.ToInt32(context.Request.QueryString["Status"]);
            bool disable = !String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                ? Convert.ToBoolean(context.Request.QueryString["Disable"])
                : false;
            List<Configs> listConfigs = String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                ? configsBO.Sel_ByType_ByStatus(type, status)
                : configsBO.Sel_ByType_ByStatus(type, status, disable);

            if (listConfigs.Any()) {
                _converter.DateTimeFormat = "dd/MM/yyyy";
                jSonString = JsonConvert.SerializeObject(listConfigs, _converter);
            }
            jSonString = "{\"data\":" + jSonString + "}";

            context.Response.Write(jSonString);
        }

        private void Ins(HttpContext context) {
            String jSonString = "";
            try {
                Configs aConfigs = new Configs {
                    AccessKey =
                        !String.IsNullOrEmpty(context.Request.Form["txtAccessKey"])
                            ? Convert.ToString(context.Request.Form["txtAccessKey"])
                            : "",
                    Value =
                        !String.IsNullOrEmpty(context.Request.Form["txtValue"])
                            ? Convert.ToString(context.Request.Form["txtValue"])
                            : "",
                    Status =
                        !String.IsNullOrEmpty(context.Request.Form["cbbStatus"])
                            ? Convert.ToInt32(context.Request.Form["cbbStatus"])
                            : 0,
                    Type =
                        !String.IsNullOrEmpty(context.Request.Form["cbbType"])
                            ? Convert.ToInt32(context.Request.Form["cbbType"])
                            : 0,
                    Group =
                        !String.IsNullOrEmpty(context.Request.Form["cbbGroup"])
                            ? Convert.ToInt32(context.Request.Form["cbbGroup"])
                            : 0,
                    Note =
                        !String.IsNullOrEmpty(context.Request.Form["txtNote"])
                            ? Convert.ToString(context.Request.Form["txtNote"])
                            : "",
                    Image =
                        !String.IsNullOrEmpty(context.Request.Form["txtImage_1"])
                            ? Convert.ToString(context.Request.Form["txtImage_1"])
                            : "",
                    Disable =
                        !String.IsNullOrEmpty(context.Request.Form["cbbDisable"])
                            ? Convert.ToBoolean(context.Request.Form["cbbDisable"])
                            : false,
                };

                ConfigsBO configsBO = new ConfigsBO();
                int ret = configsBO.Ins(aConfigs);

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

        private void Ins_ListConfigs(HttpContext context) {
            throw new NotImplementedException();
        }

        private void Upd_ByID(HttpContext context) {
            String jSonString = "";
            try {
                int idConfigs = Convert.ToInt32(context.Request.Form["txtID"]);
                ConfigsBO configsBO = new ConfigsBO();
                Configs aConfigs = configsBO.Sel_ByID(idConfigs);

                aConfigs.ID = idConfigs;
                aConfigs.AccessKey = !String.IsNullOrEmpty(context.Request.Form["txtAccessKey"])
                    ? Convert.ToString(context.Request.Form["txtAccessKey"])
                    : aConfigs.AccessKey;
                aConfigs.Value = !String.IsNullOrEmpty(context.Request.Form["txtValue"])
                    ? Convert.ToString(context.Request.Form["txtValue"])
                    : aConfigs.Value;
                aConfigs.Status = !String.IsNullOrEmpty(context.Request.Form["cbbStatus"])
                    ? Convert.ToInt32(context.Request.Form["cbbStatus"])
                    : aConfigs.Status;
                aConfigs.Type = !String.IsNullOrEmpty(context.Request.Form["cbbType"])
                    ? Convert.ToInt32(context.Request.Form["cbbType"])
                    : aConfigs.Type;
                aConfigs.Group = !String.IsNullOrEmpty(context.Request.Form["cbbGroup"])
                    ? Convert.ToInt32(context.Request.Form["cbbGroup"])
                    : aConfigs.Group;
                aConfigs.Note = !String.IsNullOrEmpty(context.Request.Form["txtNote"])
                    ? Convert.ToString(context.Request.Form["txtNote"])
                    : aConfigs.Note;
                aConfigs.Disable = !String.IsNullOrEmpty(context.Request.Form["cbbDisable"])
                    ? Convert.ToBoolean(context.Request.Form["cbbDisable"])
                    : aConfigs.Disable;
                aConfigs.Image = !String.IsNullOrEmpty(context.Request.Form["txtImage_1"])
                    ? Convert.ToString(context.Request.Form["txtImage_1"])
                    : aConfigs.Image;

                int ret = configsBO.Upd(aConfigs);

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

        private void Upd_Type_ByID(HttpContext context) {
            String jSonString = "";
            try {
                ConfigsBO configsBo = new ConfigsBO();
                int id = Convert.ToInt32(context.Request.QueryString["ID"]);
                int type = Convert.ToInt32(context.Request.QueryString["Type"]);
                int ret = configsBo.Upd_Type(id, type);
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

        private void Upd_Status_ByID(HttpContext context) {
            String jSonString = "";
            try {
                ConfigsBO configsBo = new ConfigsBO();
                int id = Convert.ToInt32(context.Request.QueryString["ID"]);
                int status = Convert.ToInt32(context.Request.QueryString["Status"]);
                int ret = configsBo.Upd_Status(id, status);
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
                ConfigsBO configsBo = new ConfigsBO();
                int id = Convert.ToInt32(context.Request.QueryString["ID"]);
                bool disable = Convert.ToBoolean(context.Request.QueryString["Disable"]);
                int ret = configsBo.Upd_Disable(id, disable);
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
                int idConfigs = Convert.ToInt32(context.Request.QueryString["ID"]);
                ConfigsBO configsBO = new ConfigsBO();
                int ret = configsBO.Del(idConfigs);

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