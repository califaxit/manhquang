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
    /// Handler for PermitDetails. 
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
    public class PermitDetailsAction : IAction {
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
                    case "Ins_ListPermitDetails":
                        Ins_ListPermitDetails(context);
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
            PermitDetailsBO permitDetailsBO = new PermitDetailsBO();

            bool disable = !String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                ? Convert.ToBoolean(context.Request.QueryString["Disable"])
                : false;
            List<PermitDetails> listPermitDetails =
                String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                    ? permitDetailsBO.Sel()
                    : permitDetailsBO.Sel(disable);

            if (listPermitDetails.Any()) {
                _converter.DateTimeFormat = "dd/MM/yyyy";
                jSonString = JsonConvert.SerializeObject(listPermitDetails, _converter);
            }
            jSonString = "{\"data\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }

        private void Sel_ByID(HttpContext context) {
            String jSonString = "";
            PermitDetailsBO permitDetailsBO = new PermitDetailsBO();

            int id = Convert.ToInt32(context.Request.QueryString["ID"]);
            bool disable = !String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                ? Convert.ToBoolean(context.Request.QueryString["Disable"])
                : false;
            PermitDetails permitDetails =
                String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                    ? permitDetailsBO.Sel_ByID(id)
                    : permitDetailsBO.Sel_ByID(id, disable);
            if (permitDetails != null) {
                _converter.DateTimeFormat = "dd/MM/yyyy";
                jSonString = JsonConvert.SerializeObject(permitDetails, _converter);
            }
            jSonString = "{\"data\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }

        private void Sel_ByType(HttpContext context) {
            String jSonString = "";
            PermitDetailsBO permitDetailsBO = new PermitDetailsBO();

            int type = Convert.ToInt32(context.Request.QueryString["Type"]);
            bool disable = !String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                ? Convert.ToBoolean(context.Request.QueryString["Disable"])
                : false;
            List<PermitDetails> listPermitDetails =
                String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                    ? permitDetailsBO.Sel_ByType(type)
                    : permitDetailsBO.Sel_ByType(type, disable);
            if (listPermitDetails.Any()) {
                _converter.DateTimeFormat = "dd/MM/yyyy";
                jSonString = JsonConvert.SerializeObject(listPermitDetails, _converter);
            }
            jSonString = "{\"data\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }

        private void Sel_ByStatus(HttpContext context) {
            String jSonString = "";
            PermitDetailsBO permitDetailsBO = new PermitDetailsBO();

            int status = Convert.ToInt32(context.Request.QueryString["Status"]);
            bool disable = !String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                ? Convert.ToBoolean(context.Request.QueryString["Disable"])
                : false;
            List<PermitDetails> listPermitDetails =
                String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                    ? permitDetailsBO.Sel_ByStatus(status)
                    : permitDetailsBO.Sel_ByStatus(status, disable);
            if (listPermitDetails.Any()) {
                _converter.DateTimeFormat = "dd/MM/yyyy";
                jSonString = JsonConvert.SerializeObject(listPermitDetails, _converter);
            }
            jSonString = "{\"data\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }

        private void Sel_ByType_ByStatus(HttpContext context) {
            String jSonString = "";
            PermitDetailsBO permitDetailsBO = new PermitDetailsBO();

            int type = Convert.ToInt32(context.Request.QueryString["Type"]);
            int status = Convert.ToInt32(context.Request.QueryString["Status"]);
            bool disable = !String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                ? Convert.ToBoolean(context.Request.QueryString["Disable"])
                : false;
            List<PermitDetails> listPermitDetails =
                String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                    ? permitDetailsBO.Sel_ByType_ByStatus(type, status)
                    : permitDetailsBO.Sel_ByType_ByStatus(type, status, disable);
            if (listPermitDetails.Any()) {
                _converter.DateTimeFormat = "dd/MM/yyyy";
                jSonString = JsonConvert.SerializeObject(listPermitDetails, _converter);
            }
            jSonString = "{\"data\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }

        private void Upd_ByID(HttpContext context) {
            String jSonString = "";
            try {
                PermitDetails aPermitDetails = new PermitDetails();
                PermitDetailsBO aPermitDetailsBo = new PermitDetailsBO();
                int idPermitDetails = Convert.ToInt32(context.Request.Form["txtID"]);

                aPermitDetails.ID = idPermitDetails;
                aPermitDetails.IDPermit = !String.IsNullOrEmpty(context.Request.Form["cbbIDPermit"])
                    ? Convert.ToInt32(context.Request.Form["cbbIDPermit"])
                    : aPermitDetails.IDPermit;
                aPermitDetails.Name = !String.IsNullOrEmpty(context.Request.Form["txtName"])
                    ? Convert.ToString(context.Request.Form["txtName"])
                    : aPermitDetails.Name;
                aPermitDetails.PageURL = !String.IsNullOrEmpty(context.Request.Form["txtPageURL"])
                    ? Convert.ToString(context.Request.Form["txtPageURL"])
                    : aPermitDetails.PageURL;
                aPermitDetails.Type = !String.IsNullOrEmpty(context.Request.Form["cbbType"])
                    ? Convert.ToInt32(context.Request.Form["cbbType"])
                    : aPermitDetails.Type;
                aPermitDetails.Status = !String.IsNullOrEmpty(context.Request.Form["cbbStatus"])
                    ? Convert.ToInt32(context.Request.Form["cbbStatus"])
                    : aPermitDetails.Status;
                aPermitDetails.Disable = !String.IsNullOrEmpty(context.Request.Form["cbbDisable"])
                    ? Convert.ToBoolean(context.Request.Form["cbbDisable"])
                    : aPermitDetails.Disable;
                int ret = aPermitDetailsBo.Upd(aPermitDetails);

                if (ret > 0)
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
                PermitDetailsBO permitDetailsBO = new PermitDetailsBO();
                int id = Convert.ToInt32(context.Request.QueryString["ID"]);
                int type = Convert.ToInt32(context.Request.QueryString["Type"]);
                int ret = permitDetailsBO.Upd_Type(id, type);
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
                PermitDetailsBO permitDetailsBO = new PermitDetailsBO();
                int id = Convert.ToInt32(context.Request.QueryString["ID"]);
                int status = Convert.ToInt32(context.Request.QueryString["Status"]);
                int ret = permitDetailsBO.Upd_Status(id, status);
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
                PermitDetailsBO permitDetailsBO = new PermitDetailsBO();
                int id = Convert.ToInt32(context.Request.QueryString["ID"]);
                bool disable = Convert.ToBoolean(context.Request.QueryString["Status"]);
                int ret = permitDetailsBO.Upd_Disable(id, disable);
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

        private void Ins(HttpContext context) {
            String jSonString = "";
            try {
                PermitDetails aPermitDetails = new PermitDetails();
                PermitDetailsBO aPermitDetailsBo = new PermitDetailsBO();

                aPermitDetails.IDPermit = !String.IsNullOrEmpty(context.Request.Form["cbbIDPermit"])
                    ? Convert.ToInt32(context.Request.Form["cbbIDPermit"])
                    : 0;
                aPermitDetails.Name = !String.IsNullOrEmpty(context.Request.Form["txtName"])
                    ? Convert.ToString(context.Request.Form["txtName"])
                    : "";
                aPermitDetails.PageURL = !String.IsNullOrEmpty(context.Request.Form["txtPageURL"])
                    ? Convert.ToString(context.Request.Form["txtPageURL"])
                    : "";
                aPermitDetails.Type = !String.IsNullOrEmpty(context.Request.Form["cbbType"])
                    ? Convert.ToInt32(context.Request.Form["cbbType"])
                    : 0;
                aPermitDetails.Status = !String.IsNullOrEmpty(context.Request.Form["cbbStatus"])
                    ? Convert.ToInt32(context.Request.Form["cbbStatus"])
                    : 0;
                aPermitDetails.Disable = !String.IsNullOrEmpty(context.Request.Form["cbbDisable"])
                    ? Convert.ToBoolean(context.Request.Form["cbbStatus"])
                    : false;
                int ret = aPermitDetailsBo.Ins(aPermitDetails);

                if (ret > 0)
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

        private void Ins_ListPermitDetails(HttpContext context) {
            throw new NotImplementedException();
        }

        private void Del_ByID(HttpContext context) {
            String jSonString = "";
            try {
                int id = Convert.ToInt32(context.Request.QueryString["id"]);
                PermitDetailsBO aPermitDetailsBo = new PermitDetailsBO();
                int ret = aPermitDetailsBo.Del_ByID(id);

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