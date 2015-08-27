using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Web;
using BussinessLogic;
using CORE;
using DataAccess;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ActionHandler {
    /// <summary>
    /// Albums Action Handler
    /// </summary>
    /// <author>Do Quang Quy</author>
    /// <created>09/07/15</created>
    /// <modified>
    /// Nam Chu
    /// 10/07/15
    /// 
    /// -add select and update methods
    /// -fix bugs, reformat and optimize code
    /// </modified>

    [SuppressMessage("ReSharper", "SimplifyConditionalTernaryExpression")]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class AlbumsAction : IAction {
        private SystemUsers currentSystemUsers = new SystemUsers();

        public void Do(HttpContext context) {
            string action = context.Request["action"];
            if (!String.IsNullOrEmpty(action)) {
                currentSystemUsers = (SystemUsers) context.Session["LoginAccount"];
                switch (action) {
                    case "Sel":
                        Sel(context);
                        break;
                    case "Sel_ByID":
                        Sel_ByID(context);
                        break;
                    case "Sel_ByIDLang":
                        Sel_ByIDLang(context);
                        break;
                    case "Sel_ByCode":
                        Sel_ByCode(context);
                        break;
                    case "Sel_ByType":
                        Sel_ByType(context);
                        break;
                    case "Sel_ByStatus":
                        Sel_ByStatus(context);
                        break;
                    case "Sel_ByCode_ByIDLang":
                        Sel_ByCode_ByIDLang(context);
                        break;
                    case "Sel_ByType_ByIDLang":
                        Sel_ByType_ByIDLang(context);
                        break;
                    case "Sel_ByStatus_ByIDLang":
                        Sel_ByStatus_ByIDLang(context);
                        break;
                    case "Sel_ByType_ByCode":
                        Sel_ByType_ByCode(context);
                        break;
                    case "Sel_ByStatus_ByCode":
                        Sel_ByStatus_ByCode(context);
                        break;
                    case "Sel_ByType_ByStatus_ByIDLang":
                        Sel_ByType_ByStatus_ByIDLang(context);
                        break;
                    case "Upd_ByID":
                        Upd_ByID(context);
                        break;
                    case "Upd_ByCode":
                        Upd_ByCode(context, CORE_Language.sys_NUM_LANG);
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
                    case "Upd_Type_ByCode":
                        Upd_Type_ByCode(context);
                        break;
                    case "Upd_Status_ByCode":
                        Upd_Status_ByCode(context);
                        break;
                    case "Upd_Disable_ByCode":
                        Upd_Disable_ByCode(context);
                        break;
                    case "Upd_Type_ByCode_ByIDLang":
                        Upd_Type_ByCode_ByIDLang(context);
                        break;
                    case "Upd_Status_ByCode_ByIDLang":
                        Upd_Status_ByCode_ByIDLang(context);
                        break;
                    case "Upd_Disable_ByCode_ByIDLang":
                        Upd_Disable_ByCode_ByIDLang(context);
                        break;



                    case "Ins":
                        Ins(context, CORE_Language.sys_NUM_LANG);
                        break;

                    case "Del_ByID":
                        Del_ByID(context);
                        break;
                    case "Del_ByCode":
                        Del_ByCode(context);
                        break;
                    case "Del_ByIDLang":
                        Del_ByIDLang(context);
                        break;
                    default:
                        context.Response.Write("Can't find action");
                        break;
                }
            }
        }

        private readonly IsoDateTimeConverter _converter = new IsoDateTimeConverter();

        private readonly IFormatProvider _culture = new CultureInfo("es-ES", true);

        #region SELECT
        private void Sel(HttpContext context) {
            AlbumsBO albumsBO = new AlbumsBO();
            String jSonString = "";

            bool disable = !String.IsNullOrEmpty(context.Request.QueryString["Disable"])
                ? Convert.ToBoolean(context.Request.QueryString["Disable"])
                : false;

            List<Albums> listAlbums =
                String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                    ? albumsBO.Sel()
                    : albumsBO.Sel(disable);

            if (listAlbums.Any()) {
                _converter.DateTimeFormat = "dd/MM/yyyy";

                jSonString = JsonConvert.SerializeObject(listAlbums, _converter);
            }

            jSonString = "{\"data\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }

        private void Sel_ByID(HttpContext context) {
            String jSonString = "";
            AlbumsBO albumsBO = new AlbumsBO();
            int id = Convert.ToInt32(context.Request.QueryString["IDAlbums"]);
            bool disable = !String.IsNullOrEmpty(context.Request.QueryString["Disable"])
                ? Convert.ToBoolean(context.Request.QueryString["Disable"])
                : false;
            Albums albums = String.IsNullOrEmpty(context.Request.QueryString["Disable"])
                ? albumsBO.Sel_ByID(id)
                : albumsBO.Sel_ByID(id, disable);
            if (albums != null) {
                _converter.DateTimeFormat = "dd/MM/yyyy";
                jSonString = JsonConvert.SerializeObject(albums, _converter);
            }
            jSonString = "{\"data\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }

        private void Sel_ByIDLang(HttpContext context) {
            String jSonString = string.Empty;
            AlbumsBO albumsBO = new AlbumsBO();

            int idLang = string.IsNullOrEmpty(context.Request.QueryString["IDLang"])
                ? CORE_Language.sys_CUR_LANG
                : int.Parse(context.Request.QueryString["IDLang"]);

            bool disable = !String.IsNullOrEmpty(context.Request.QueryString["Disable"])
                ? Convert.ToBoolean(context.Request.QueryString["Disable"])
                : false;

            List<Albums> listAlbums =
                String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                    ? albumsBO.Sel_ByIDLang(idLang)
                    : albumsBO.Sel_ByIDLang(idLang, disable);

            if (listAlbums.Any()) {
                _converter.DateTimeFormat = "dd/MM/yyyy";

                jSonString = JsonConvert.SerializeObject(listAlbums, _converter);
            }

            jSonString = "{\"data\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }

        private void Sel_ByCode(HttpContext context) {
            String jSonString = string.Empty;
            AlbumsBO albumsBO = new AlbumsBO();

            String code = Convert.ToString(context.Request.QueryString["Code"]);

            bool disable = !String.IsNullOrEmpty(context.Request.QueryString["Disable"])
                ? Convert.ToBoolean(context.Request.QueryString["Disable"])
                : false;

            List<Albums> listAlbums =
                String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                    ? albumsBO.Sel_ByCode(code)
                    : albumsBO.Sel_ByCode(code, disable);

            if (listAlbums.Any()) {
                _converter.DateTimeFormat = "dd/MM/yyyy";
                jSonString = JsonConvert.SerializeObject(listAlbums, _converter);
            }

            jSonString = "{\"data\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }

        private void Sel_ByType(HttpContext context) {
            String jSonString = string.Empty;
            AlbumsBO albumsBO = new AlbumsBO();

            int type = Convert.ToInt32(context.Request.QueryString["Type"]);

            bool disable = !String.IsNullOrEmpty(context.Request.QueryString["Disable"])
                ? Convert.ToBoolean(context.Request.QueryString["Disable"])
                : false;

            List<Albums> listAlbums =
                String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                    ? albumsBO.Sel_ByType(type)
                    : albumsBO.Sel_ByType(type, disable);

            if (listAlbums.Any()) {
                _converter.DateTimeFormat = "dd/MM/yyyy";
                jSonString = JsonConvert.SerializeObject(listAlbums, _converter);
            }

            jSonString = "{\"data\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }

        private void Sel_ByStatus(HttpContext context) {
            String jSonString = string.Empty;
            AlbumsBO albumsBO = new AlbumsBO();

            int status = Convert.ToInt32(context.Request.QueryString["Status"]);

            bool disable = !String.IsNullOrEmpty(context.Request.QueryString["Disable"])
                ? Convert.ToBoolean(context.Request.QueryString["Disable"])
                : false;

            List<Albums> listAlbums =
                String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                    ? albumsBO.Sel_ByStatus(status)
                    : albumsBO.Sel_ByStatus(status, disable);

            if (listAlbums.Any()) {
                _converter.DateTimeFormat = "dd/MM/yyyy";
                jSonString = JsonConvert.SerializeObject(listAlbums, _converter);
            }

            jSonString = "{\"data\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }

        private void Sel_ByCode_ByIDLang(HttpContext context) {
            String jSonString = string.Empty;
            AlbumsBO albumsBO = new AlbumsBO();

            int idLang = string.IsNullOrEmpty(context.Request.QueryString["IDLang"])
                ? CORE_Language.sys_CUR_LANG
                : int.Parse(context.Request.QueryString["IDLang"]);

            string code = Convert.ToString(context.Request.QueryString["Code"]);

            bool disable = !String.IsNullOrEmpty(context.Request.QueryString["Disable"])
                ? Convert.ToBoolean(context.Request.QueryString["Disable"])
                : false;

            Albums albums =
                String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                    ? albumsBO.Sel_ByCode_ByIDLang(code, idLang)
                    : albumsBO.Sel_ByCode_ByIDLang(code, idLang, disable);

            if (albums != null) {
                _converter.DateTimeFormat = "dd/MM/yyyy";
                jSonString = JsonConvert.SerializeObject(albums, _converter);
            }

            jSonString = "{\"data\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }

        private void Sel_ByType_ByIDLang(HttpContext context) {
            String jSonString = string.Empty;
            AlbumsBO albumsBO = new AlbumsBO();

            int idLang = string.IsNullOrEmpty(context.Request.QueryString["IDLang"])
                ? CORE_Language.sys_CUR_LANG
                : int.Parse(context.Request.QueryString["IDLang"]);

            int type = Convert.ToInt32(context.Request.QueryString["Type"]);

            bool disable = !String.IsNullOrEmpty(context.Request.QueryString["Disable"])
                ? Convert.ToBoolean(context.Request.QueryString["Disable"])
                : false;

            List<Albums> listAlbums =
                String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                    ? albumsBO.Sel_ByType_ByIDLang(type, idLang)
                    : albumsBO.Sel_ByType_ByIDLang(type, idLang, disable);

            if (listAlbums.Any()) {
                _converter.DateTimeFormat = "dd/MM/yyyy";
                jSonString = JsonConvert.SerializeObject(listAlbums, _converter);
            }

            jSonString = "{\"data\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }

        private void Sel_ByStatus_ByIDLang(HttpContext context) {
            String jSonString = string.Empty;
            AlbumsBO albumsBO = new AlbumsBO();

            int idLang = string.IsNullOrEmpty(context.Request.QueryString["IDLang"])
                ? CORE_Language.sys_CUR_LANG
                : int.Parse(context.Request.QueryString["IDLang"]);

            int status = Convert.ToInt32(context.Request.QueryString["Status"]);

            bool disable = !String.IsNullOrEmpty(context.Request.QueryString["Disable"])
                ? Convert.ToBoolean(context.Request.QueryString["Disable"])
                : false;

            List<Albums> listAlbums =
                String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                    ? albumsBO.Sel_ByStatus_ByIDLang(status, idLang)
                    : albumsBO.Sel_ByStatus_ByIDLang(status, idLang, disable);

            if (listAlbums.Any()) {
                _converter.DateTimeFormat = "dd/MM/yyyy";
                jSonString = JsonConvert.SerializeObject(listAlbums, _converter);
            }

            jSonString = "{\"data\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }

        private void Sel_ByType_ByCode(HttpContext context) {
            String jSonString = string.Empty;
            AlbumsBO albumsBO = new AlbumsBO();

            String code = Convert.ToString(context.Request.QueryString["Code"]);

            int type = Convert.ToInt32(context.Request.QueryString["Type"]);

            bool disable = !String.IsNullOrEmpty(context.Request.QueryString["Disable"])
                ? Convert.ToBoolean(context.Request.QueryString["Disable"])
                : false;

            List<Albums> listAlbums =
                String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                    ? albumsBO.Sel_ByType_ByCode(type, code)
                    : albumsBO.Sel_ByType_ByCode(type, code, disable);

            if (listAlbums.Any()) {
                _converter.DateTimeFormat = "dd/MM/yyyy";
                jSonString = JsonConvert.SerializeObject(listAlbums, _converter);
            }

            jSonString = "{\"data\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }

        private void Sel_ByStatus_ByCode(HttpContext context) {
            String jSonString = string.Empty;
            AlbumsBO albumsBO = new AlbumsBO();

            String code = Convert.ToString(context.Request.QueryString["Code"]);

            int status = Convert.ToInt32(context.Request.QueryString["Status"]);

            bool disable = !String.IsNullOrEmpty(context.Request.QueryString["Disable"])
                ? Convert.ToBoolean(context.Request.QueryString["Disable"])
                : false;

            List<Albums> listAlbums =
                String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                    ? albumsBO.Sel_ByStatus_ByCode(status, code)
                    : albumsBO.Sel_ByStatus_ByCode(status, code, disable);

            if (listAlbums.Any()) {
                _converter.DateTimeFormat = "dd/MM/yyyy";
                jSonString = JsonConvert.SerializeObject(listAlbums, _converter);
            }

            jSonString = "{\"data\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }

        private void Sel_ByType_ByStatus_ByIDLang(HttpContext context) {
            String jSonString = string.Empty;
            AlbumsBO albumsBO = new AlbumsBO();

            int idLang = string.IsNullOrEmpty(context.Request.QueryString["IDLang"])
                ? CORE_Language.sys_CUR_LANG
                : int.Parse(context.Request.QueryString["IDLang"]);

            int type = Convert.ToInt32(context.Request.QueryString["Type"]);

            int status = Convert.ToInt32(context.Request.QueryString["Status"]);

            bool disable = !String.IsNullOrEmpty(context.Request.QueryString["Disable"])
                ? Convert.ToBoolean(context.Request.QueryString["Disable"])
                : false;

            List<Albums> listAlbums =
                String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                    ? albumsBO.Sel_ByType_ByStatus_ByIDLang(type, status, idLang)
                    : albumsBO.Sel_ByType_ByStatus_ByIDLang(type, status, idLang, disable);

            if (listAlbums.Any()) {
                _converter.DateTimeFormat = "dd/MM/yyyy";
                jSonString = JsonConvert.SerializeObject(listAlbums, _converter);
            }

            jSonString = "{\"data\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }
        #endregion

        #region UPDATE
        private void Upd_ByID(HttpContext context) {
            string jSonString = string.Empty;
            try {
                AlbumsBO albumsBO = new AlbumsBO();
                int id = Convert.ToInt32(context.Request.Form["txtID"]);
                Albums albums = albumsBO.Sel_ByID(id);

                albums.ID = albums.ID;

                albums.Title = !String.IsNullOrEmpty(context.Request.Form["txtTitle_Lang"])
                    ? Convert.ToString(context.Request.Form["txtTitle_Lang"])
                    : albums.Title;

                albums.Info = !String.IsNullOrEmpty(context.Request.Form["txtInfo_Lang"])
                    ? Convert.ToString(HttpUtility.HtmlDecode(context.Request.Form["txtInfo_Lang"]))
                    : albums.Info;

                albums.Intro = !String.IsNullOrEmpty(context.Request.Form["txtIntro_Lang"])
                    ? Convert.ToString(context.Request.Form["txtIntro_Lang"])
                    : albums.Intro;

                albums.Status = !String.IsNullOrEmpty(context.Request.Form["cbbStatus"])
                    ? Convert.ToInt32(context.Request.Form["cbbStatus"])
                    : albums.Status;

                albums.Disable = !String.IsNullOrEmpty(context.Request.Form["cbbDisable"])
                    ? Convert.ToBoolean(context.Request.Form["txt_Disable"])
                    : albums.Disable;

                albums.CreateDate = !String.IsNullOrEmpty(context.Request.Form["dtpPublishDate"])
                    ? DateTime.ParseExact(context.Request.Form["dtpPublishDate"], "dd/MM/yyyy", _culture)
                    : albums.CreateDate;

                albums.CreateByIDUser = currentSystemUsers.ID;

                albums.Image = !String.IsNullOrEmpty(context.Request.Form["txtImage_1"])
                    ? Convert.ToString(context.Request.Form["txtImage_1"])
                    : albums.Image;

                albums.Image1 = !String.IsNullOrEmpty(context.Request.Form["txtImage_2"])
                    ? Convert.ToString(context.Request.Form["txtImage_2"])
                    : albums.Image1;
                albums.Image2 = !String.IsNullOrEmpty(context.Request.Form["txtImage_3"])
                    ? Convert.ToString(context.Request.Form["txtImage_3"])
                    : albums.Image2;
                albums.Image3 = !String.IsNullOrEmpty(context.Request.Form["txtImage_4"])
                    ? Convert.ToString(context.Request.Form["txtImage_4"])
                    : albums.Image3;

                albums.Type = !String.IsNullOrEmpty(context.Request.Form["cbbType"])
                    ? Convert.ToInt32(context.Request.Form["cbbType"])
                    : albums.Type;

                albums.IDLang = !String.IsNullOrEmpty(context.Request.Form["IDLang_"])
                    ? Convert.ToInt32(context.Request.Form["IDLang_"])
                    : albums.IDLang;
                albums.ViewCount = !String.IsNullOrEmpty(context.Request.Form["txtViewCount"])
                    ? Convert.ToInt64(context.Request.Form["txtViewCount"])
                    : albums.ViewCount;
                albums.DownloadCount = !String.IsNullOrEmpty(context.Request.Form["txtDownloadCount"])
                    ? Convert.ToInt64(context.Request.Form["txtDownloadCount"])
                    : albums.DownloadCount;

                var ret = albumsBO.Upd_Albums(albums);
                if (ret == 0) jSonString = "{\"status\":\"error|" + ret + "\"}";
                else if (ret != 0) jSonString = "{\"status\": \"success\"}";
            }
            catch (Exception ex) {
                jSonString = "{\"status\":\"error\" ,\"message\":\"" + ex.Message + "\"}";
            }
            finally {
                context.Response.Write(jSonString);
            }
        }

        private void Upd_ByCode(HttpContext context, int NUM_LANG) {
            int ret = -1;
            string jSonString = string.Empty;
            try {
                if (NUM_LANG < 1)
                    NUM_LANG = 1;
                AlbumsBO albumsBO = new AlbumsBO();
                String Code = context.Request.Form["txtCode"];
                List<Albums> listAlbums = albumsBO.Sel_ByCode(Code);

                if (listAlbums.Count <= NUM_LANG) {
                    int LoopUpdate = listAlbums.Count;
                    for (int i = 0; i < LoopUpdate; i++) {
                        listAlbums[i].ID = listAlbums[i].ID;

                        listAlbums[i].Title = !String.IsNullOrEmpty(context.Request.Form["txtTitle_Lang" + (i + 1)])
                            ? Convert.ToString(context.Request.Form["txtTitle_Lang" + (i + 1)])
                            : listAlbums[i].Title;

                        listAlbums[i].Info = !String.IsNullOrEmpty(context.Request.Form["txtInfo_Lang" + (i + 1)])
                            ? Convert.ToString(HttpUtility.HtmlDecode(context.Request.Form["txtInfo_Lang" + (i + 1)]))
                            : listAlbums[i].Info;

                        listAlbums[i].Intro = !String.IsNullOrEmpty(context.Request.Form["txtIntro_Lang" + (i + 1)])
                            ? Convert.ToString(context.Request.Form["txtIntro_Lang" + (i + 1)])
                            : listAlbums[i].Intro;

                        listAlbums[i].Status = !String.IsNullOrEmpty(context.Request.Form["cbbStatus"])
                            ? Convert.ToInt32(context.Request.Form["cbbStatus"])
                            : listAlbums[i].Status;

                        listAlbums[i].Disable = !String.IsNullOrEmpty(context.Request.Form["cbbDisable"])
                            ? Convert.ToBoolean(context.Request.Form["txt_Disable"])
                            : listAlbums[i].Disable;

                        listAlbums[i].CreateDate = !String.IsNullOrEmpty(context.Request.Form["dtpPublishDate"])
                            ? DateTime.ParseExact(context.Request.Form["dtpPublishDate"], "dd/MM/yyyy", _culture)
                            : listAlbums[i].CreateDate;

                        listAlbums[i].CreateByIDUser = currentSystemUsers.ID;

                        listAlbums[i].Image = !String.IsNullOrEmpty(context.Request.Form["txtImage_1"])
                            ? Convert.ToString(context.Request.Form["txtImage_1"])
                            : listAlbums[i].Image;

                        listAlbums[i].Image1 = !String.IsNullOrEmpty(context.Request.Form["txtImage_2"])
                            ? Convert.ToString(context.Request.Form["txtImage_2"])
                            : listAlbums[i].Image1;
                        listAlbums[i].Image2 = !String.IsNullOrEmpty(context.Request.Form["txtImage_3"])
                            ? Convert.ToString(context.Request.Form["txtImage_3"])
                            : listAlbums[i].Image2;
                        listAlbums[i].Image3 = !String.IsNullOrEmpty(context.Request.Form["txtImage_4"])
                            ? Convert.ToString(context.Request.Form["txtImage_4"])
                            : listAlbums[i].Image3;

                        listAlbums[i].Type = !String.IsNullOrEmpty(context.Request.Form["cbbType"])
                            ? Convert.ToInt32(context.Request.Form["cbbType"])
                            : listAlbums[i].Type;

                        listAlbums[i].IDLang = !String.IsNullOrEmpty(context.Request.Form["IDLang_" + (i + 1)])
                            ? Convert.ToInt32(context.Request.Form["IDLang_" + (i + 1)])
                            : listAlbums[i].IDLang;
                        listAlbums[i].ViewCount = !String.IsNullOrEmpty(context.Request.Form["txtViewCount"])
                            ? Convert.ToInt64(context.Request.Form["txtViewCount"])
                            : listAlbums[i].ViewCount;
                        listAlbums[i].DownloadCount = !String.IsNullOrEmpty(context.Request.Form["txtDownloadCount"])
                            ? Convert.ToInt64(context.Request.Form["txtDownloadCount"])
                            : listAlbums[i].DownloadCount;

                        ret = albumsBO.Upd_Albums(listAlbums[i]);
                        if (ret == 0) {
                            jSonString = "{\"status\":\"error|" + ret + "\"}";
                            break;
                        }
                    }
                }
                if (ret != 0) {
                    jSonString = "{\"status\": \"success\"}";
                }
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
                AlbumsBO albumsBO = new AlbumsBO();
                int id = Convert.ToInt32(context.Request.QueryString["ID"]);
                int status = Convert.ToInt32(context.Request.QueryString["Status"]);
                int ret = albumsBO.Upd_Status_ByID(id, status);
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
                AlbumsBO albumsBO = new AlbumsBO();
                int id = Convert.ToInt32(context.Request.QueryString["ID"]);
                int type = Convert.ToInt32(context.Request.QueryString["Type"]);
                int ret = albumsBO.Upd_Type_ByID(id, type);
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
                AlbumsBO albumsBO = new AlbumsBO();
                int id = Convert.ToInt32(context.Request.QueryString["ID"]);
                bool disable = Convert.ToBoolean(context.Request.QueryString["Disable"]);
                int ret = albumsBO.Upd_Disable_ByID(id, disable);
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

        private void Upd_Status_ByCode(HttpContext context) {
            String jSonString = "";
            try {
                AlbumsBO albumsBO = new AlbumsBO();
                string code = Convert.ToString(context.Request.QueryString["Code"]);
                int status = Convert.ToInt32(context.Request.QueryString["Status"]);
                int ret = albumsBO.Upd_Status_ByCode(code, status);
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

        private void Upd_Type_ByCode(HttpContext context) {
            String jSonString = "";
            try {
                AlbumsBO albumsBO = new AlbumsBO();
                string code = Convert.ToString(context.Request.QueryString["Code"]);
                int type = Convert.ToInt32(context.Request.QueryString["Type"]);
                int ret = albumsBO.Upd_Type_ByCode(code, type);
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

        private void Upd_Disable_ByCode(HttpContext context) {
            String jSonString = "";
            try {
                AlbumsBO albumsBO = new AlbumsBO();
                string code = Convert.ToString(context.Request.QueryString["Code"]);
                bool disable = Convert.ToBoolean(context.Request.QueryString["Disable"]);
                int ret = albumsBO.Upd_Disable_ByCode(code, disable);
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

        private void Upd_Status_ByCode_ByIDLang(HttpContext context) {
            String jSonString = "";
            try {
                AlbumsBO albumsBO = new AlbumsBO();
                string code = Convert.ToString(context.Request.QueryString["Code"]);
                int idLang = Convert.ToInt32(context.Request.QueryString["IDLang"]);
                int status = Convert.ToInt32(context.Request.QueryString["Status"]);
                int ret = albumsBO.Upd_Status_ByCode_ByIDLang(code, idLang, status);
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

        private void Upd_Type_ByCode_ByIDLang(HttpContext context) {
            String jSonString = "";
            try {
                AlbumsBO albumsBO = new AlbumsBO();
                string code = Convert.ToString(context.Request.QueryString["Code"]);
                int idLang = Convert.ToInt32(context.Request.QueryString["IDLang"]);
                int type = Convert.ToInt32(context.Request.QueryString["Type"]);
                int ret = albumsBO.Upd_Type_ByCode_ByIDLang(code, idLang, type);
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

        private void Upd_Disable_ByCode_ByIDLang(HttpContext context) {
            String jSonString = "";
            try {
                AlbumsBO albumsBO = new AlbumsBO();
                string code = Convert.ToString(context.Request.QueryString["Code"]);
                int idLang = Convert.ToInt32(context.Request.QueryString["IDLang"]);
                bool disable = Convert.ToBoolean(context.Request.QueryString["Disable"]);
                int ret = albumsBO.Upd_Disable_ByCode_ByIDLang(code, idLang, disable);
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
#endregion

        private void Ins(HttpContext context, int NUM_LANG) {
            int ret = -1;
            String jSonString = "";
            try {
                long a = DateTime.Now.Ticks;
                TimeSpan Codespan = new TimeSpan(a);
                AlbumsBO albumsBO = new AlbumsBO();
                for (int i = 1; i <= NUM_LANG; i++) {
                    Albums aAlbums = new Albums();
                    aAlbums.Code = Math.Floor(Codespan.TotalSeconds).ToString();
                    aAlbums.Status = !String.IsNullOrEmpty(context.Request.Form["cbbStatus"])
                        ? Convert.ToInt32(context.Request.Form["cbbStatus"])
                        : 1;

                    aAlbums.Disable = !String.IsNullOrEmpty(context.Request.Form["cbbDisable"])
                        ? Convert.ToBoolean(context.Request.Form["cbbDisable"])
                        : false;

                    aAlbums.CreateDate = DateTime.Now;

                    aAlbums.CreateByIDUser = currentSystemUsers.ID;
                    aAlbums.Image = !String.IsNullOrEmpty(context.Request.Form["txtImage_1"])
                        ? Convert.ToString(context.Request.Form["txtImage_1"])
                        : "";

                    aAlbums.Image1 = !String.IsNullOrEmpty(context.Request.Form["txtImage_2"])
                        ? Convert.ToString(context.Request.Form["txtImage_2"])
                        : "";
                    aAlbums.Image2 = !String.IsNullOrEmpty(context.Request.Form["txtImage_3"])
                        ? Convert.ToString(context.Request.Form["txtImage_3"])
                        : "";
                    aAlbums.Image3 = !String.IsNullOrEmpty(context.Request.Form["txtImage_4"])
                        ? Convert.ToString(context.Request.Form["txtImage_4"])
                        : "";

                    aAlbums.Type = !String.IsNullOrEmpty(context.Request.Form["cbbType"])
                        ? Convert.ToInt32(context.Request.Form["cbbType"])
                        : 0;

                    aAlbums.ViewCount = !String.IsNullOrEmpty(context.Request.Form["txtViewCount"])
                        ? Convert.ToInt64(context.Request.Form["txtViewCount"])
                        : 0;
                    aAlbums.DownloadCount = !String.IsNullOrEmpty(context.Request.Form["txtViewdowload"])
                        ? Convert.ToInt64(context.Request.Form["txtViewdowload"])
                        : 0;

                    aAlbums.IDLang = !String.IsNullOrEmpty(context.Request.Form["IDLang_" + i])
                        ? Convert.ToInt32(context.Request.Form["IDLang_" + i])
                        : 0;

                    aAlbums.Title = !String.IsNullOrEmpty(context.Request.Form["txtTitle_Lang" + i])
                        ? Convert.ToString(context.Request.Form["txtTitle_Lang" + i])
                        : "";

                    aAlbums.Info = !String.IsNullOrEmpty(context.Request.Form["txtInfo_Lang" + i])
                        ? Convert.ToString(HttpUtility.HtmlDecode(context.Request.Form["txtInfo_Lang" + i]))
                        : "";

                    aAlbums.Intro = !String.IsNullOrEmpty(context.Request.Form["txtIntro_Lang" + i])
                        ? Convert.ToString(context.Request.Form["txtIntro_Lang" + i])
                        : "";

                    ret = albumsBO.Ins(aAlbums);
                    if (ret == 0) {
                        jSonString = "{\"status\":\"error|" + ret + "\"}";
                        break;
                    }
                }
                if (ret != 0) {
                    jSonString = "{\"status\": \"success\"}";
                }
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
            int IDAlbums = Convert.ToInt32(context.Request.QueryString["IDAlbums"]);
            AlbumsBO albumsBO = new AlbumsBO();
            int ret = albumsBO.Del_ByID(IDAlbums);
            if (ret != 0) jSonString = "{\"status\": \"success\"}";
            else if (ret == 0) jSonString = "{\"status\":\"error|" + ret + "\"}";
            context.Response.Write(jSonString);
        }

        private void Del_ByCode(HttpContext context) {
            AlbumsBO albumsBO = new AlbumsBO();
            String jSonString = "";
            string Code = context.Request.QueryString["Code"]; 
            int ret = albumsBO.Del_ByCode(Code);
            if (ret != 0) jSonString = "{\"status\": \"success\"}";
            if (ret == 0) jSonString = "{\"status\":\"error|" + ret + "\"}";
            context.Response.Write(jSonString);
        }

        private void Del_ByIDLang(HttpContext context) {
            AlbumsBO albumsBO = new AlbumsBO();
            String jSonString = "";
            int idLang = Convert.ToInt32(context.Request.QueryString["IDLang"]);
            int ret = albumsBO.Del_ByIDLang(idLang);
            if (ret != 0) jSonString = "{\"status\": \"success\"}";
            if (ret == 0) jSonString = "{\"status\":\"error|" + ret + "\"}";
            context.Response.Write(jSonString);
        }
    }
}