using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Web;
using BussinessLogic;
using DataAccess;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ActionHandler {
    /// <summary>
    /// Handler for Permits. 
    /// data will be recieved from client
    /// </summary>
    /// <author> Nam Chu </author>
    /// <created>10/06/15</created>
    /// <modified>
    /// Nam Chu
    /// 08/07/15
    /// 
    /// -fix bugs
    /// -update disable for select mothods
    /// -add update by type, status, disable methods
    /// -reformat and optimize code
    /// </modified>

    //TODO: Ins_ListConfigs and Del_ListID is NOT available
    [SuppressMessage("ReSharper", "SimplifyConditionalTernaryExpression")]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class PermitsAction : IAction {
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
                    case "Ins_ListPermits":
                        Ins_ListPermits(context);
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
            String jSonString = "";
            PermitsBO permitsBO = new PermitsBO();
            bool disable = !String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                ? Convert.ToBoolean(context.Request.QueryString["Disable"])
                : false;
            List<Permits> listPermits =
                String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                    ? permitsBO.Sel()
                    : permitsBO.Sel(disable);

            if (listPermits.Any()) {
                _converter.DateTimeFormat = "dd/MM/yyyy";
                jSonString = JsonConvert.SerializeObject(listPermits, _converter);
            }
            jSonString = "{\"data\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }

        private void Sel_ByID(HttpContext context) {
            String jSonString = "";
            PermitsBO permitsBO = new PermitsBO();
            int id = Convert.ToInt32(context.Request.QueryString["ID"]);
            bool disable = !String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                ? Convert.ToBoolean(context.Request.QueryString["Disable"])
                : false;
            Permits permits =
                String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                    ? permitsBO.Sel_ByID(id)
                    : permitsBO.Sel_ByID(id, disable);

            if (permits != null) {
                _converter.DateTimeFormat = "dd/MM/yyyy";
                jSonString = JsonConvert.SerializeObject(permits, _converter);
            }
            jSonString = "{\"data\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }

        private void Sel_ByType(HttpContext context) {
            String jSonString = "";
            PermitsBO permitsBO = new PermitsBO();
            int type = Convert.ToInt32(context.Request.QueryString["Type"]);
            bool disable = !String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                ? Convert.ToBoolean(context.Request.QueryString["Disable"])
                : false;
            List<Permits> listPermits =
                String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                    ? permitsBO.Sel_ByType(type)
                    : permitsBO.Sel_ByType(type, disable);

            if (listPermits.Any()) {
                _converter.DateTimeFormat = "dd/MM/yyyy";
                jSonString = JsonConvert.SerializeObject(listPermits, _converter);
            }
            jSonString = "{\"data\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }

        private void Sel_ByStatus(HttpContext context) {
            String jSonString = "";
            PermitsBO permitsBO = new PermitsBO();
            int status = Convert.ToInt32(context.Request.QueryString["Status"]);
            bool disable = !String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                ? Convert.ToBoolean(context.Request.QueryString["Disable"])
                : false;
            List<Permits> listPermits =
                String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                    ? permitsBO.Sel_ByStatus(status)
                    : permitsBO.Sel_ByStatus(status, disable);

            if (listPermits.Any()) {
                _converter.DateTimeFormat = "dd/MM/yyyy";
                jSonString = JsonConvert.SerializeObject(listPermits, _converter);
            }
            jSonString = "{\"data\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }

        private void Sel_ByType_ByStatus(HttpContext context) {
            String jSonString = "";
            PermitsBO permitsBO = new PermitsBO();
            int type = Convert.ToInt32(context.Request.QueryString["Type"]);
            int status = Convert.ToInt32(context.Request.QueryString["Status"]);
            bool disable = !String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                ? Convert.ToBoolean(context.Request.QueryString["Disable"])
                : false;
            List<Permits> listPermits =
                String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                    ? permitsBO.Sel_ByType_ByStatus(type, status)
                    : permitsBO.Sel_ByType_ByStatus(type, status, disable);

            if (listPermits.Any()) {
                _converter.DateTimeFormat = "dd/MM/yyyy";
                jSonString = JsonConvert.SerializeObject(listPermits, _converter);
            }
            jSonString = "{\"data\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }

        private void Ins(HttpContext context) {
            String jSonString = "";
            try {
                Permits permits = new Permits {
                    Name = !String.IsNullOrEmpty(context.Request.Form["txtName"])
                        ? Convert.ToString(context.Request.Form["txtName"])
                        : "",
                    IsAdmin = !String.IsNullOrEmpty(context.Request.Form["cbbIsAdmin"])
                        ? Convert.ToBoolean(context.Request.Form["cbbIsAdmin"])
                        : false,
                    IsContent = !String.IsNullOrEmpty(context.Request.Form["cbbIsContent"])
                        ? Convert.ToBoolean(context.Request.Form["cbbIsContent"])
                        : false,
                    IsPartner = !String.IsNullOrEmpty(context.Request.Form["cbbIsPartner"])
                        ? Convert.ToBoolean(context.Request.Form["cbbIsPartner"])
                        : false,
                    Type = !String.IsNullOrEmpty(context.Request.Form["cbbType"])
                        ? Convert.ToInt32(context.Request.Form["cbbType"])
                        : 0,
                    Status = !String.IsNullOrEmpty(context.Request.Form["cbbStatus"])
                        ? Convert.ToInt32(context.Request.Form["cbbStatus"])
                        : 0,
                    SystemKey = !String.IsNullOrEmpty(context.Request.Form["txtSystemKey"])
                        ? Convert.ToString(context.Request.Form["txtSystemKey"])
                        : "",
                    Disable = !String.IsNullOrEmpty(context.Request.Form["cbbDisable"])
                        ? Convert.ToBoolean(context.Request.Form["cbbDisable"])
                        : false
                };

                PermitsBO permitsBo = new PermitsBO();
                int ret = permitsBo.Ins(permits);


                if (ret != 0)
                    jSonString = "{\"status\": \"success\"}";
                if (ret == 0)
                    jSonString = "{\"status\":\"error|" + ret + "\"}";
            }
            catch (Exception ex) {
                jSonString = "{\"status\":\"error\" ,\"message\":\"" + ex.Message + "\"}";
            }
            finally {
                context.Response.Write(jSonString);
            }
        }

        private void Ins_ListPermits(HttpContext context) {
            throw new NotImplementedException();
        }

        private void Upd_ByID(HttpContext context) {
            String jSonString = "";
            try {
                Permits aPermits = new Permits();
                int idPermits = Convert.ToInt32(context.Request.Form["txtID"]);

                aPermits.ID = idPermits;

                aPermits.Name = !String.IsNullOrEmpty(context.Request.Form["txtName"])
                    ? Convert.ToString(context.Request.Form["txtName"])
                    : aPermits.Name;

                aPermits.SystemKey = !String.IsNullOrEmpty(context.Request.Form["txtSystemKey"])
                    ? Convert.ToString(context.Request.Form["txtSystemKey"])
                    : aPermits.SystemKey;

                aPermits.IsAdmin = !String.IsNullOrEmpty(context.Request.Form["cbbIsAdmin"])
                    ? Convert.ToBoolean(context.Request.Form["cbbIsAdmin"])
                    : aPermits.IsAdmin;

                aPermits.IsContent = !String.IsNullOrEmpty(context.Request.Form["cbbIsContent"])
                    ? Convert.ToBoolean(context.Request.Form["cbbIsContent"])
                    : aPermits.IsContent;

                aPermits.IsPartner = !String.IsNullOrEmpty(context.Request.Form["cbbIsPartner"])
                    ? Convert.ToBoolean(context.Request.Form["cbbIsPartner"])
                    : aPermits.IsPartner;

                aPermits.Type = !String.IsNullOrEmpty(context.Request.Form["cbbType"])
                    ? Convert.ToInt32(context.Request.Form["cbbType"])
                    : aPermits.Type;

                aPermits.Status = !String.IsNullOrEmpty(context.Request.Form["cbbStatus"])
                    ? Convert.ToInt32(context.Request.Form["cbbStatus"])
                    : aPermits.Status;
                aPermits.Disable = !String.IsNullOrEmpty(context.Request.Form["cbbStatus"])
                    ? Convert.ToBoolean(context.Request.Form["cbbDisable"])
                    : aPermits.Disable;

                PermitsBO aPermitsBo = new PermitsBO();
                int ret = aPermitsBo.Upd(aPermits);

                if (ret != 0)
                    jSonString = "{\"status\": \"success\"}";
                if (ret == 0)
                    jSonString = "{\"status\":\"error|" + ret + "\"}";
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
                PermitsBO permitsBO = new PermitsBO();
                int id = Convert.ToInt32(context.Request.QueryString["ID"]);
                int type = Convert.ToInt32(context.Request.QueryString["Type"]);
                int ret = permitsBO.Upd_Type(id, type);
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
                PermitsBO permitsBO = new PermitsBO();
                int id = Convert.ToInt32(context.Request.QueryString["ID"]);
                int status = Convert.ToInt32(context.Request.QueryString["Status"]);
                int ret = permitsBO.Upd_Status(id, status);
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
                PermitsBO permitsBO = new PermitsBO();
                int id = Convert.ToInt32(context.Request.QueryString["ID"]);
                bool disable = Convert.ToBoolean(context.Request.QueryString["Type"]);
                int ret = permitsBO.Upd_Disable(id, disable);
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
                int id = Convert.ToInt32(context.Request.QueryString["ID"]);

                PermitsBO aPermitsBo = new PermitsBO();
                int ret = aPermitsBo.Del_ByID(id);

                if (ret != 0)
                    jSonString = "{\"status\": \"success\"}";
                if (ret == 0)
                    jSonString = "{\"status\":\"error|" + ret + "\"}";
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