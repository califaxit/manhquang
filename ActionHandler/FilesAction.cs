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


namespace ActionHandler
{

       public class FilesAction : IAction
       {
            public SystemUsers aCurrentSystemUsers = new SystemUsers();
            public void Do(HttpContext context)
        {
            string action = context.Request["action"].ToString();
            if (!String.IsNullOrEmpty(action))
            {
                switch (action)
                {
                    case "Sel_ByIDLang":
                        Sel_ByIDLang(context, CORE_Language.sys_CUR_LANG);
                      break;
                    case "Sel_ByCode":
                        Sel_ByCode(context);
                       break;
                    case "Sel_Files_ByCodeAlbums":

                       Sel_Files_ByCodeAlbums(context, CORE_Language.sys_CUR_LANG);
                       break;
                    case "Sel_File_ByCodeContents":

                       Sel_File_ByCodeContents(context, CORE_Language.sys_CUR_LANG);
                       break;
                    case "Sel_ByID":
                       Sel_ByID(context);
                       break;
                    case "Sel_ByCodeAlbum_ByIDLang":
                        Sel_ByCodeAlbum_ByIDLang(context);
                        break;
                    case "Sel_ByCode_ByIDLang":
                        Sel_ByCode_ByIDLang(context);
                        break;
                    case"Sel_ByType_ByIDLang":
                        Sel_ByType_ByIDLang(context);
                        break;
                    case "Sel_ByType_ByStatus_ByIDLang":
                        Sel_ByType_ByStatus_ByIDLang(context);
                        break;
                    case"Sel_Ext_ByKeyCodeFiles_ByIDLang":
                        Sel_Ext_ByKeyCodeFiles_ByIDLang(context);
                        break;
                    case "Sel_Ext_ByKeyCodeAlbums_ByIDLang":
                        Sel_Ext_ByKeyCodeAlbums_ByIDLang(context);
                        break;                   
                    case "Upd_ByCode":
                        Upd_ByCode(context, CORE_Language.sys_NUM_LANG);
                        break;
                    case "Upd_ByID_ByStatus":
                        Upd_ByID_ByStatus(context);
                        break;             
                    case "Upd_ByID_ByType":
                        Upd_ByID_ByType(context);
                        break;
                    case "Upd_ByID_ByDisable":
                        Upd_ByID_ByDisable(context);
                        break;
                    case "Upd_Disable":
                        Upd_Disable(context);
                        break;
                    case"Upd_Status_ByCode_ByLang":
                        Upd_Status_ByCode_ByLang(context);
                        break;
                    case "Upd_Type_ByCode_ByLang":
                        Upd_Type_ByCode_ByLang(context);
                        break;
                    case "Upd_Disable_ByCode_ByLang":
                         Upd_Disable_ByCode_ByLang(context);
                         break;
                    case "Ins":
                        Ins(context, CORE_Language.sys_NUM_LANG);
                        break;
                    case "Del_ByCode":
                        Del_ByCode(context);
                        break;
                    default:
                        context.Response.Write("Can't find action");
                        break;
                }
            }
        }
           /// <summary>
           ///  sửa public thành private
           ///  10/7/2015
           /// </summary>
            private IsoDateTimeConverter _converter = new IsoDateTimeConverter();
            IFormatProvider culture = new CultureInfo("es-ES", true);
            private void Sel_File_ByCodeContents(HttpContext context, int IDLang)
        {

            String jSonString = "";

            string CodeContents = context.Request.QueryString["CodeContents"];

            ContentsBO aContentsBO = new ContentsBO();
            //List<Contents> aListContents = aContentsBO.Sel_all_ByIDLang(IDLang).Where(p => p.Code == CodeContents).ToList();
            //string[] arrImageName = new string[0];
            //List<Files> obj = new List<Files>();

            //if (aListContents.Count > 0)
            //{
            //    int? IDAlbum = aListContents[0].IDAlbum;
            //    AlbumsBO aAlbumBO = new AlbumsBO();
            //    Albums aAlbums = new Albums();
            //    aAlbums = aAlbumBO.Sel(IDAlbum.GetValueOrDefault(0));
            //    if (aAlbums != null)
            //    {
            //        string CodeAlbums = aAlbumBO.Sel(IDAlbum.GetValueOrDefault(0)).Code;
            //        FilesBO aFilesBO = new FilesBO();
            //        obj = aFilesBO.Sel_all_ByIDLang(IDLang).Where(p => p.CodeAlbums == CodeAlbums).ToList();
            //        arrImageName = new string[obj.Count];

            //        for (int ii = 0; ii < obj.Count; ii++)
            //        {
            //            arrImageName[ii] = obj[ii].Image;
            //        }
            //    }
            //    if (obj != null)
            //    {
            //        _converter.DateTimeFormat = "dd/MM/yyyy";

            //        jSonString = JsonConvert.SerializeObject(arrImageName, _converter);
            //    }
            //    jSonString = "{\"Files\":" + jSonString + "}";
            //    context.Response.Write(jSonString);

            //}
            //else
            //{
            //    jSonString = "{\"Files\":" + jSonString + "}";
            //    context.Response.Write(jSonString);
            //}


            context.Response.Write(jSonString);
        }
            private void Sel_ByID(HttpContext context)
          {
            try
            {
                bool Disable = !String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))
                    ? Convert.ToBoolean(context.Request.QueryString["Disable"])
                    : false;
                int ID = Convert.ToInt32( context.Request.QueryString["ID"]);
               
                FilesBO aFilesBO = new FilesBO();
                Files obj = new Files();
                 obj=  String.IsNullOrEmpty(Convert.ToString(context.Request.QueryString["Disable"]))?aFilesBO.Sel_ByID(ID):aFilesBO.Sel_ByID(ID,Disable);


                String jSonString = "";

                //int IDLang = string.IsNullOrEmpty(context.Request.QueryString["IDLang"]) ? CORE_Language.sys_CUR_LANG : int.Parse(context.Request.QueryString["IDLang"]);
              
                
                if (obj != null)
                {
                    _converter.DateTimeFormat = "dd/MM/yyyy";
                    jSonString = JsonConvert.SerializeObject(obj, _converter);
                }

                jSonString = "{\"data\":" + jSonString + "}";
                context.Response.Write(jSonString);

            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("FilesAction.Sel_ByCodeAlbum: {0}", ex.Message));
            }
        }
            private void Sel_ByCode(HttpContext context)
            {
              

                    FilesBO aFilesBO = new FilesBO();
                    List<Files> obj = new List<Files>();

                    string Code = context.Request.QueryString["Code"];
                    String jSonString = "";


                    if (string.IsNullOrEmpty(context.Request.QueryString["Disable"]))
                    {
                        obj = aFilesBO.Sel_ByCode(Code);
                    }
                    else
                    {
                        obj = aFilesBO.Sel_ByCode(Code, bool.Parse(context.Request.QueryString["Disable"]));
                    }


                    int count = obj.Count;

                    for (int i = 0; i < obj.Count; i++)
                    {
                        obj[i].Intro = HttpUtility.HtmlDecode(obj[i].Intro);
                        // obj[i].Contents_Intro = HttpUtility.HtmlDecode(obj[i].Intro);
                    }
                    if (obj != null)
                    {
                        _converter.DateTimeFormat = "dd/MM/yyyy";
                        jSonString = JsonConvert.SerializeObject(obj, _converter);
                    }

                    jSonString = "{\"data\":" + jSonString + "}";
                    context.Response.Write(jSonString);
                }
            private void Sel_ByCode_ByIDLang(HttpContext context)
            {
                FilesBO aFilesBO = new FilesBO();
                List<Files> obj = new List<Files>();

                string Code = context.Request.QueryString["Code"];
                int IDLang = int.Parse(context.Request.QueryString["IDLang"]);
                String jSonString = "";


                if (string.IsNullOrEmpty(context.Request.QueryString["Disable"]))
                {
                    obj = aFilesBO.Sel_ByCode_ByIDLang(Code,IDLang);
                }
                else
                {
                    obj = aFilesBO.Sel_ByCode_ByIDLang(Code,IDLang, bool.Parse(context.Request.QueryString["Disable"]));
                }


                int count = obj.Count;

                for (int i = 0; i < obj.Count; i++)
                {
                    obj[i].Intro = HttpUtility.HtmlDecode(obj[i].Intro);
                    // obj[i].Contents_Intro = HttpUtility.HtmlDecode(obj[i].Intro);
                }
                if (obj != null)
                {
                    _converter.DateTimeFormat = "dd/MM/yyyy";
                    jSonString = JsonConvert.SerializeObject(obj, _converter);
                }

                jSonString = "{\"data\":" + jSonString + "}";
                context.Response.Write(jSonString);
            }
            private void Sel_ByIDLang(HttpContext context, int IDLang)
           {
            try
            {

                FilesBO aFilesBO = new FilesBO();
                List<vw_FilesViewAll> obj = new List<vw_FilesViewAll>();


                String jSonString = "";

                
                if (string.IsNullOrEmpty(context.Request.QueryString["Disable"]))
                {
                    obj = aFilesBO.Sel_Ext_ByIDLang(IDLang);
                }
                else
                {
                    obj = aFilesBO.Sel_Ext_ByIDLang(IDLang, bool.Parse(context.Request.QueryString["Disable"]));
                }


                int count = obj.Count;

                for (int i = 0; i < obj.Count; i++)
                {
                    obj[i].Files_Intro = HttpUtility.HtmlDecode(obj[i].Files_Intro);
                    // obj[i].Contents_Intro = HttpUtility.HtmlDecode(obj[i].Intro);
                }
                if (obj != null)
                {
                    _converter.DateTimeFormat = "dd/MM/yyyy";
                    jSonString = JsonConvert.SerializeObject(obj, _converter);
                }

                jSonString = "{\"data\":" + jSonString + "}";
                context.Response.Write(jSonString);

            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("FilesAction.Sel_ByCodeAlbum: {0}", ex.Message));
            }
        }      
            private void Sel_ByStatus_ByIDLang(HttpContext context)
            {

                try
                {

                    FilesBO aFilesBO = new FilesBO();
                    List<Files> obj = new List<Files>();
                    int IDLang =int.Parse(context.Request.QueryString["IDLang"]);
                    int Status =int.Parse(context.Request.QueryString["Status"]);
                    String jSonString = "";
                    if (string.IsNullOrEmpty(context.Request.QueryString["Disable"]))
                    {
                        obj = aFilesBO.Sel_ByStatus_ByIDLang(Status,IDLang);
                    }
                    else
                    {
                        obj = aFilesBO.Sel_ByStatus_ByIDLang(Status,IDLang, bool.Parse(context.Request.QueryString["Disable"]));
                    }


                    int count = obj.Count;

                   
                    if (obj != null)
                    {
                        _converter.DateTimeFormat = "dd/MM/yyyy";
                        jSonString = JsonConvert.SerializeObject(obj, _converter);
                    }

                    jSonString = "{\"data\":" + jSonString + "}";
                    context.Response.Write(jSonString);

                }
                catch (Exception ex)
                {
                    throw new Exception(String.Format("FilesAction.Sel_ByCodeAlbum: {0}", ex.Message));
                }
            }
            private void Sel_ByType_ByIDLang(HttpContext context)
            {
                try
                {
                    int IDLang =int.Parse(context.Request.QueryString["IDLang"]);
                    FilesBO aFilesBO = new FilesBO();
                    List<Files> obj = new List<Files>();
                    int Type = int.Parse(context.Request.QueryString["Type"]);
                    String jSonString = "";
                    if (string.IsNullOrEmpty(context.Request.QueryString["Disable"]))
                    {
                        obj = aFilesBO.Sel_ByType_ByIDLang(Type, IDLang);
                    }
                    else
                    {
                        obj = aFilesBO.Sel_ByType_ByIDLang(Type, IDLang, bool.Parse(context.Request.QueryString["Disable"]));
                    }


                    int count = obj.Count;

                   
                    if (obj != null)
                    {
                        _converter.DateTimeFormat = "dd/MM/yyyy";
                        jSonString = JsonConvert.SerializeObject(obj, _converter);
                    }

                    jSonString = "{\"data\":" + jSonString + "}";
                    context.Response.Write(jSonString);

                }
                catch (Exception ex)
                {
                    throw new Exception(String.Format("FilesAction.Sel_ByCodeAlbum: {0}", ex.Message));
                }
            }
            private void Sel_ByType_ByStatus_ByIDLang(HttpContext context)
            {
                try
                {
                    int IDLang = int.Parse(context.Request.QueryString["IDLang"]);
                    FilesBO aFilesBO = new FilesBO();
                    List<Files> obj = new List<Files>();
                    int Type = int.Parse(context.Request.QueryString["Type"]);
                    int Status = int.Parse(context.Request.QueryString["Status"]);
                    String jSonString = "";
                    if (string.IsNullOrEmpty(context.Request.QueryString["Disable"]))
                    {
                        obj = aFilesBO.Sel_ByType_ByStatus_ByIDLang(Type, Status, IDLang);
                    }
                    else
                    {
                        obj = aFilesBO.Sel_ByType_ByStatus_ByIDLang(Type,Status,IDLang, bool.Parse(context.Request.QueryString["Disable"]));
                    }


                    int count = obj.Count;


                    if (obj != null)
                    {
                        _converter.DateTimeFormat = "dd/MM/yyyy";
                        jSonString = JsonConvert.SerializeObject(obj, _converter);
                    }

                    jSonString = "{\"data\":" + jSonString + "}";
                    context.Response.Write(jSonString);

                }
                catch (Exception ex)
                {
                    throw new Exception(String.Format("FilesAction.Sel_ByCodeAlbum: {0}", ex.Message));
                }
            }
            private void Sel_ByCodeAlbum_ByIDLang(HttpContext context)
           {
            try
            {
                int IDLang = int.Parse(context.Request.QueryString["IDLang"]);
                FilesBO aFilesBO = new FilesBO();
                List<vw_FilesViewAll> aListvw_FilesViewAll = new List<vw_FilesViewAll>();
               

                String jSonString = "";
                string CodeAlbum = context.Request.QueryString["CodeAlbum"];
                IDLang = int.Parse(context.Request.QueryString["IDLang"]);
                if (string.IsNullOrEmpty(context.Request.QueryString["Disable"]))
                {
                    aListvw_FilesViewAll = aFilesBO.Sel_Ext_ByCodeAlbums(CodeAlbum, IDLang);
                }
                else
                {
                    aListvw_FilesViewAll = aFilesBO.Sel_Ext_ByCodeAlbums(CodeAlbum,IDLang,bool.Parse(context.Request.QueryString["Disable"]));
                }
                aListvw_FilesViewAll = aFilesBO.Sel_Ext_ByCodeAlbums(CodeAlbum,IDLang);
                _converter.DateTimeFormat = "dd/MM/yyyy";
                jSonString = JsonConvert.SerializeObject(aListvw_FilesViewAll, _converter);
                jSonString = "{\"Files\":" + jSonString + "}";
                context.Response.Write(jSonString);

            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("FilesAction.Sel_ByCodeAlbum: {0}", ex.Message));
            }
        }      
            private void Sel_Files_ByCodeAlbums(HttpContext context, int IDLang)
            {

                String jSonString = "";

                string CodeAlbums = context.Request.QueryString["CodeAlbums"];

                FilesBO aFilesBO = new FilesBO();
                List<Files> obj = aFilesBO.Sel_ByIDLang(IDLang).Where(p => p.CodeAlbums == CodeAlbums).ToList();
                if (obj.Count > 0)
                {
                  

                    if (obj != null)
                    {
                        _converter.DateTimeFormat = "dd/MM/yyyy";

                        jSonString = JsonConvert.SerializeObject(obj, _converter);
                    }
                    jSonString = "{\"total\":" + obj.Count + ",\"file\":" + jSonString + "}";

                }
                else
                {
                    jSonString = "{\"total\":0,\"file\":" + jSonString + "}";
                }


                context.Response.Write(jSonString);
            }
            private void Sel_Files_ByCodeAlbums_ByType(HttpContext context, int IDLang)
            {

                String jSonString = "";

                string CodeAlbums = context.Request.QueryString["CodeAlbums"];
                int Type =Convert.ToInt32(context.Request.QueryString["Type"]);

                FilesBO aFilesBO = new FilesBO();
                List<Files> obj = aFilesBO.Sel_ByIDLang(IDLang).Where(p => p.CodeAlbums == CodeAlbums).Where(p=>p.Type==Type).ToList();
                if (obj.Count > 0)
                {


                    if (obj != null)
                    {
                        _converter.DateTimeFormat = "dd/MM/yyyy";

                        jSonString = JsonConvert.SerializeObject(obj, _converter);
                    }
                    jSonString = "{\"total\":" + obj.Count + ",\"file\":" + jSonString + "}";

                }
                else
                {
                    jSonString = "{\"total\":0,\"file\":" + jSonString + "}";
                }


                context.Response.Write(jSonString);
            }
            private void Sel_Ext_ByKeyCodeFiles_ByIDLang (HttpContext context)
            {
                
                try
                {
                    string Key = context.Request.QueryString["CodeFiles"];
                    FilesBO aFilesBO = new FilesBO();
                    List<vw_FilesViewAll> obj = new List<vw_FilesViewAll>();
                    int IDLang = int.Parse(context.Request.QueryString["IDLang"]);
                    String jSonString = "";
                    if (string.IsNullOrEmpty(context.Request.QueryString["Disable"]))
                    {
                        obj = aFilesBO.Sel_Ext_ByKeyCodeFiles_ByIDLang(Key,IDLang);
                    }
                    else
                    {
                        obj = aFilesBO.Sel_Ext_ByKeyCodeFiles_ByIDLang(Key, IDLang, bool.Parse(context.Request.QueryString["Disable"]));
                    }


                    int count = obj.Count;


                    if (obj != null)
                    {
                        _converter.DateTimeFormat = "dd/MM/yyyy";
                        jSonString = JsonConvert.SerializeObject(obj, _converter);
                    }

                    jSonString = "{\"data\":" + jSonString + "}";
                    context.Response.Write(jSonString);

                }
                catch (Exception ex)
                {
                    throw new Exception(String.Format("FilesAction.Sel_ByCodeAlbum: {0}", ex.Message));
                }
            }
            private void Sel_Ext_ByKeyCodeAlbums_ByIDLang(HttpContext context)
            {

                try
                {
                    string Key = context.Request.QueryString["CodeAlbums"];
                    FilesBO aFilesBO = new FilesBO();
                    List<vw_FilesViewAll> obj = new List<vw_FilesViewAll>();
                    int IDLang = int.Parse(context.Request.QueryString["IDLang"]);
                    String jSonString = "";
                    if (string.IsNullOrEmpty(context.Request.QueryString["Disable"]))
                    {
                        obj = aFilesBO.Sel_Ext_ByKeyCodeAlbums_ByIDLang(Key, IDLang);
                    }
                    else
                    {
                        obj = aFilesBO.Sel_Ext_ByKeyCodeAlbums_ByIDLang(Key, IDLang, bool.Parse(context.Request.QueryString["Disable"]));
                    }


                    int count = obj.Count;


                    if (obj != null)
                    {
                        _converter.DateTimeFormat = "dd/MM/yyyy";
                        jSonString = JsonConvert.SerializeObject(obj, _converter);
                    }

                    jSonString = "{\"data\":" + jSonString + "}";
                    context.Response.Write(jSonString);

                }
                catch (Exception ex)
                {
                    throw new Exception(String.Format("FilesAction.Sel_ByCodeAlbum: {0}", ex.Message));
                }
            }
            private void Sel_Ext_ByKeyCodeFiles(HttpContext context)
            {

                try
                {
                    string Key = context.Request.QueryString["CodeFiles"];
                    FilesBO aFilesBO = new FilesBO();
                    List<vw_FilesViewAll> obj = new List<vw_FilesViewAll>();
                   
                    String jSonString = "";
                    if (string.IsNullOrEmpty(context.Request.QueryString["Disable"]))
                    {
                        obj = aFilesBO.Sel_Ext_ByKeyCodeFiles(Key);
                    }
                    else
                    {
                        obj = aFilesBO.Sel_Ext_ByKeyCodeFiles(Key, bool.Parse(context.Request.QueryString["Disable"]));
                    }


                    int count = obj.Count;


                    if (obj != null)
                    {
                        _converter.DateTimeFormat = "dd/MM/yyyy";
                        jSonString = JsonConvert.SerializeObject(obj, _converter);
                    }

                    jSonString = "{\"data\":" + jSonString + "}";
                    context.Response.Write(jSonString);

                }
                catch (Exception ex)
                {
                    throw new Exception(String.Format("FilesAction.Sel_ByCodeAlbum: {0}", ex.Message));
                }
            }
            private void Ins(HttpContext context, int NUM_LANG)
            {
                List<Files> aListFiles = new List<Files>();
                int ret = -1;
                String jSonString = "";
                TimeSpan Codespan = new TimeSpan(DateTime.Now.Ticks);
                string Code = Math.Floor(Codespan.TotalSeconds).ToString();
                try
                {
                   


                   

                    for (int i = 1; i <= NUM_LANG; i++)
                    {
                        Files aFiles = new Files();
                        aFiles.CodeAlbums = !String.IsNullOrEmpty(context.Request.Form["txt_CodeAlbums"]) ? Convert.ToString(context.Request.Form["txt_CodeAlbums"]) : "";
                        aFiles.Image = !String.IsNullOrEmpty(context.Request.Form["txtImage_1"]) ? Convert.ToString(context.Request.Form["txtImage_1"]) : "";

                        aFiles.UploadDate = DateTime.Now;
                        //aFiles.CreateByIDUser = !String.IsNullOrEmpty(context.Request.Form["txt_CreateByIDUser"]) ? Convert.ToInt64(context.Request.Form["txt_CreateByIDUser"]) : aFiles.CreateByIDUser;

                        aFiles.Status = !String.IsNullOrEmpty(context.Request.Form["cbbStatus"]) ? Convert.ToInt32(context.Request.Form["cbbStatus"]) : 0;

                        aFiles.Type = !String.IsNullOrEmpty(context.Request.Form["cbbType"]) ? Convert.ToInt32(context.Request.Form["cbbType"]) : 0;

                        aFiles.Disable = !String.IsNullOrEmpty(context.Request.Form["cbbDisable"]) ? Convert.ToBoolean(context.Request.Form["cbbDisable"]) : false;

                        aFiles.Width = !String.IsNullOrEmpty(context.Request.Form["txtWidth"]) ? Convert.ToInt32(context.Request.Form["txt_Width"]) : 0;

                        aFiles.Height = !String.IsNullOrEmpty(context.Request.Form["txtHeight"]) ? Convert.ToInt32(context.Request.Form["txt_Height"]) : 0;
                        aFiles.Code = Code;
                        aFiles.Image1 = !String.IsNullOrEmpty(context.Request.Form["txtImage_2"]) ? Convert.ToString(context.Request.Form["txtImage_2"]) : "";
                        aFiles.Image2 = !String.IsNullOrEmpty(context.Request.Form["txtImage_3"]) ? Convert.ToString(context.Request.Form["txtImage_3"]) : "";
                        aFiles.Image3 = !String.IsNullOrEmpty(context.Request.Form["txtImage_4"]) ? Convert.ToString(context.Request.Form["txtImage_4"]) : "";
                        aFiles.IDLang = !String.IsNullOrEmpty(context.Request.Form["IDLang_"+i]) ? Convert.ToInt32(context.Request.Form["IDLang_" + i]) : 0;
                        aFiles.Title = !String.IsNullOrEmpty(context.Request.Form["txtTitle_Lang" + i]) ? Convert.ToString(HttpUtility.HtmlEncode(context.Request.Form["txtTitle_Lang" + i])) : "";

                        aFiles.Intro = !String.IsNullOrEmpty(context.Request.Form["txtIntro_Lang" + i]) ? Convert.ToString(HttpUtility.HtmlEncode(context.Request.Form["txtIntro_Lang" + i])) : "";
                        aFiles.Info = !String.IsNullOrEmpty(context.Request.Form["txtInfo_Lang" + i]) ? Convert.ToString(HttpUtility.HtmlEncode(context.Request.Form["txtInfo_Lang" + i])) : "";

                      aListFiles.Add(aFiles);
                    }
                        
                    FilesBO aFilesBO=new FilesBO();


                    ret = aFilesBO.Ins(ref aListFiles);
                    if (ret < aListFiles.Count)
                    {
                      
                     jSonString = "{\"status\":\"error\" ,\"message\":\"" + ret.ToString() + "\"}";
                       aFilesBO.Del(aListFiles);
                        return;
                    }
                    else
                    {
                        jSonString = "{\"status\": \"success\"}";
                    }
                       
                       
                    }
                catch (Exception ex)
                {
                    jSonString = "{\"status\":\"error\" ,\"message\":\"" + ex.Message.ToString() + "\"}";
                }
                finally
                {
                    context.Response.Write(jSonString);
                }
            }
            private void Upd_ByCode(HttpContext context, int NUM_LANG)
            {
                int ret = -1;
                String jSonString = "";
                try
                {
                    if (NUM_LANG < 1)
                    {
                        NUM_LANG = 1;
                    }
                    List<Files> aFiles = new List<Files>();
                    FilesBO aFilesBO = new FilesBO();
                    String Code = context.Request.Form["txtCode"];

                    aFiles = aFilesBO.Sel_ByCode(Code);

                    int LoopUpdate = 0;

                    if (aFiles.Count <= NUM_LANG)
                    {
                        LoopUpdate = aFiles.Count;
                        for (int i = 0; i < LoopUpdate; i++)
                        {

                            aFiles[i].ID = aFiles[i].ID;

                            aFiles[i].Code = aFiles[i].Code;
                            aFiles[i].IDLang = aFiles[i].IDLang;

                            aFiles[i].CodeAlbums = !String.IsNullOrEmpty(context.Request.Form["txt_CodeAlbums"]) ? Convert.ToString(context.Request.Form["txt_CodeAlbums"]) : aFiles[i].CodeAlbums;

                            aFiles[i].Image = !String.IsNullOrEmpty(context.Request.Form["txtImage_1"]) ? Convert.ToString(context.Request.Form["txtImage_1"]) : aFiles[i].Image;
                            aFiles[i].Image1= !String.IsNullOrEmpty(context.Request.Form["txtImage_2"]) ? Convert.ToString(context.Request.Form["txtImage_2"]) : aFiles[i].Image;
                            aFiles[i].Image2= !String.IsNullOrEmpty(context.Request.Form["txtImage_3"]) ? Convert.ToString(context.Request.Form["txtImage_3"]) : aFiles[i].Image;
                            aFiles[i].Image3= !String.IsNullOrEmpty(context.Request.Form["txtImage_4"]) ? Convert.ToString(context.Request.Form["txtImage_4"]) : aFiles[i].Image;

                            aFiles[i].Info = !String.IsNullOrEmpty(context.Request.Form["txtInfo_Lang" + (i + 1)]) ? Convert.ToString(context.Request.Form["txtInfo_Lang" + (i + 1)]) : aFiles[i].Info;

                            aFiles[i].Intro = !String.IsNullOrEmpty(context.Request.Form["txtIntro_Lang" + (i + 1)]) ? Convert.ToString(context.Request.Form["txtIntro_Lang" + (i + 1)]) : aFiles[i].Intro;

                            aFiles[i].Title = !String.IsNullOrEmpty(context.Request.Form["txtTitle_Lang" + (i + 1)]) ? Convert.ToString(context.Request.Form["txtTitle_Lang" + (i + 1)]) : aFiles[i].Title;


                            aFiles[i].UploadDate = !String.IsNullOrEmpty(context.Request.Form["dtpPublishDate"]) ? DateTime.ParseExact(context.Request.Form["dtpPublishDate"], "dd/MM/yyyy", culture) : aFiles[i].UploadDate;


                            aFiles[i].Status = !String.IsNullOrEmpty(context.Request.Form["cbbStatus"]) ? Convert.ToInt32(context.Request.Form["cbbStatus"]) : aFiles[i].Status;

                            aFiles[i].Type = !String.IsNullOrEmpty(context.Request.Form["cbbType"]) ? Convert.ToInt32(context.Request.Form["cbbType"]) : aFiles[i].Type;

                            aFiles[i].Disable = !String.IsNullOrEmpty(context.Request.Form["cbbDisable"]) ? Convert.ToBoolean(context.Request.Form["cbbDisable"]) : aFiles[i].Disable;

                            aFiles[i].Width = !String.IsNullOrEmpty(context.Request.Form["txtWidth"]) ? Convert.ToInt32(context.Request.Form["txtWidth"]) : aFiles[i].Width;

                            aFiles[i].Height = !String.IsNullOrEmpty(context.Request.Form["txtHeight"]) ? Convert.ToInt32(context.Request.Form["txtHeight"]) : aFiles[i].Height;

                           // aFiles[i].Code = !String.IsNullOrEmpty(context.Request.Form["Code"]) ? Convert.ToString(context.Request.Form["txt_Code"]) : aFiles[i].Code;

                            //aFiles[i].IDLang = !String.IsNullOrEmpty(context.Request.Form["txt_IDLang"]) ? Convert.ToInt32(context.Request.Form["txt_IDLang"]) : aFiles[i].IDLang;



                            ret = aFilesBO.Upd(aFiles[i]);
                            if (ret == 0)
                            {
                                jSonString = "{\"status\":\"error|" + ret.ToString() + "\"}";
                                break;
                            }

                        }
                    }
                    if (ret != 0)
                    { jSonString = "{\"status\": \"success\"}"; }
                }
                catch (Exception ex)
                {
                    jSonString = "{\"status\":\"error\" ,\"message\":\"" + ex.Message.ToString() + "\"}";
                }
                finally
                {
                    context.Response.Write(jSonString);
                }
            }
            private void Upd_ByID_ByStatus(HttpContext context)
            {
                int ret = -1;
                String jSonString = "";
                try
                {
                    Files aFiles = new Files();
                    FilesBO aFilesBO = new FilesBO();
                    int ID = int.Parse(context.Request.Form["ID"]);
                    int Status = Convert.ToInt32(context.Request.Form["cbbStatus"]);
                    //aFiles.Type = !String.IsNullOrEmpty(context.Request.Form["cbbType"]) ? Convert.ToInt32(context.Request.Form["cbbType"]) : aFiles.Type;
                    //aFiles.Disable = !String.IsNullOrEmpty(context.Request.Form["cbbDisable"]) ? Convert.ToBoolean(context.Request.Form["cbbDisable"]) : aFiles.Disable;                           
                    ret = aFilesBO.Upd_Status_ByID(ID,Status);
                    if (ret != 0)
                    { jSonString = "{\"status\": \"success\"}"; }
                }
                catch (Exception ex)
                {
                    jSonString = "{\"status\":\"error\" ,\"message\":\"" + ex.Message.ToString() + "\"}";
                }
                finally
                {
                    context.Response.Write(jSonString);
                }
            }
            private void Upd_ByID_ByType(HttpContext context)
            {
                int ret = -1;
                String jSonString = "";
                try
                {
                    Files aFiles = new Files();
                    FilesBO aFilesBO = new FilesBO();
                    int ID = int.Parse(context.Request.Form["ID"]);
                    //int Status = Convert.ToInt32(context.Request.Form["cbbStatus"]);
                    int Type =  Convert.ToInt32(context.Request.Form["cbbType"]) ;
                    //Disable =  Convert.ToBoolean(context.Request.Form["cbbDisable"]) ;                           
                    ret = aFilesBO.Upd_Type_ByID(ID,Type);
                    if (ret != 0)
                    { jSonString = "{\"status\": \"success\"}"; }
                }
                catch (Exception ex)
                {
                    jSonString = "{\"status\":\"error\" ,\"message\":\"" + ex.Message.ToString() + "\"}";
                }
                finally
                {
                    context.Response.Write(jSonString);
                }
            }
            private void Upd_ByID_ByDisable(HttpContext context)
            {
                int ret = -1;
                String jSonString = "";
                try
                {
                    Files aFiles = new Files();
                    FilesBO aFilesBO = new FilesBO();
                    int ID = int.Parse(context.Request.Form["ID"]);
                    //int Status = Convert.ToInt32(context.Request.Form["cbbStatus"]);
                    // int Type = Convert.ToInt32(context.Request.Form["cbbType"]);
                    bool Disable =  Convert.ToBoolean(context.Request.Form["cbbDisable"]) ;                           
                    ret = aFilesBO.Upd_Disable_ByID(ID,Disable);
                    if (ret != 0)
                    { jSonString = "{\"status\": \"success\"}"; }
                }
                catch (Exception ex)
                {
                    jSonString = "{\"status\":\"error\" ,\"message\":\"" + ex.Message.ToString() + "\"}";
                }
                finally
                {
                    context.Response.Write(jSonString);
                }
            }
            private void Upd_Disable(HttpContext context)
            {
                int ret = -1;
                String jSonString = "";
                try
                {
                    FilesBO aFilesBO = new FilesBO();
                    Files aFiles = new Files();
                    int IDFiles = Convert.ToInt32(context.Request.QueryString["IDFiles"]);
                    aFiles = aFilesBO.Sel_ByID(IDFiles);

                    aFiles.Disable = true;

                    ret = aFilesBO.Upd(aFiles);
                    if (ret != 0)
                    {
                        jSonString = "{\"status\":\"error|" + ret.ToString() + "\"}";

                    }

                    if (ret == 0)
                    { jSonString = "{\"status\": \"success\"}"; }
                }
                catch (Exception ex)
                {
                    jSonString = "{\"status\":\"error\" ,\"message\":\"" + ex.Message.ToString() + "\"}";
                }
                finally
                {
                    context.Response.Write(jSonString);
                }
            }
            private void Upd_Status_ByCode_ByLang(HttpContext context)
            {
                int ret = -1;
                String jSonString = "";
                try
                {
                    Files aFiles = new Files();
                    FilesBO aFilesBO = new FilesBO();
                    string Code = context.Request.Form["Code"];
                    int IDLang=int.Parse(context.Request.QueryString["IDLang"]);
                    int Status = Convert.ToInt32(context.Request.Form["cbbStatus"]);
                    // int Type = Convert.ToInt32(context.Request.Form["cbbType"]);
                    //bool Disable = Convert.ToBoolean(context.Request.Form["cbbDisable"]);
                    ret = aFilesBO.Upd_Status_ByCode_ByLang(Code,Status,IDLang);
                    if (ret != 0)
                    { jSonString = "{\"status\": \"success\"}"; }
                  
                }
                catch (Exception ex)
                {
                    jSonString = "{\"status\":\"error\" ,\"message\":\"" + ex.Message.ToString() + "\"}";
                }
                finally
                {
                    context.Response.Write(jSonString);
                }

            }
            private void Upd_Type_ByCode_ByLang(HttpContext context)
            {
                int ret = -1;
                String jSonString = "";
                try
                {
                    Files aFiles = new Files();
                    FilesBO aFilesBO = new FilesBO();
                    string Code = context.Request.Form["Code"];
                    int IDLang = int.Parse(context.Request.QueryString["IDLang"]);
                    //int Status = Convert.ToInt32(context.Request.Form["cbbStatus"]);
                     int Type = Convert.ToInt32(context.Request.Form["cbbType"]);
                    //bool Disable = Convert.ToBoolean(context.Request.Form["cbbDisable"]);
                    ret = aFilesBO.Upd_Type_ByCode_ByLang(Code, Type, IDLang);
                    if (ret != 0)
                    { jSonString = "{\"status\": \"success\"}"; }

                }
                catch (Exception ex)
                {
                    jSonString = "{\"status\":\"error\" ,\"message\":\"" + ex.Message.ToString() + "\"}";
                }
                finally
                {
                    context.Response.Write(jSonString);
                }

            }
            private void Upd_Disable_ByCode_ByLang(HttpContext context)
            {
                int ret = -1;
                String jSonString = "";
                try
                {
                    Files aFiles = new Files();
                    FilesBO aFilesBO = new FilesBO();
                    string Code = context.Request.Form["Code"];
                    int IDLang = int.Parse(context.Request.QueryString["IDLang"]);
                    //int Status = Convert.ToInt32(context.Request.Form["cbbStatus"]);
                   // int Type = Convert.ToInt32(context.Request.Form["cbbType"]);
                    bool Disable = Convert.ToBoolean(context.Request.Form["cbbDisable"]);
                    ret = aFilesBO.Upd_Disable_ByCode_ByLang(Code, Disable, IDLang);
                    if (ret != 0)
                    { jSonString = "{\"status\": \"success\"}"; }

                }
                catch (Exception ex)
                {
                    jSonString = "{\"status\":\"error\" ,\"message\":\"" + ex.Message.ToString() + "\"}";
                }
                finally
                {
                    context.Response.Write(jSonString);
                }

            }
            private void Del_ByCode(HttpContext context)
            {
                FilesBO aFilesBO = new FilesBO();
                String jSonString = "";
                String Code = context.Request.QueryString["Code"].ToString();
                int ret = aFilesBO.Del_ByCode(Code);


                if (ret >0)
                { jSonString = "{\"status\": \"success\"}"; }

                if (ret == 0)
                { jSonString = "{\"status\":\"error|" + ret.ToString() + "\"}"; }


                context.Response.Write(jSonString);
            }
        }
}
