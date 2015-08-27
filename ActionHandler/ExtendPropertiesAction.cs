using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using BussinessLogic;
using CORE;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Globalization;

namespace ActionHandler
{
    public class ExtendPropertiesAction:IAction
    {
        public SystemUsers aCurrentSystemUsers = new SystemUsers();
        private IsoDateTimeConverter _converter = new IsoDateTimeConverter();
        private IFormatProvider culture = new CultureInfo("es-ES", true);
        public void Do(HttpContext context)
        {
            string action = context.Request["action"].ToString();
            if (!String.IsNullOrEmpty(action))
            {
                this.aCurrentSystemUsers = (SystemUsers)context.Session["LoginAccount"];

                switch (action)
                {
                    case "Sel_ByIDLang":
                        this.Sel_ByIDLang(context);
                        break;
                    case "Upd_ByCode":
                       this.Upd_ByCode(context, CORE_Language.sys_NUM_LANG);
                        break;
                    case "Ins":
                        this.Ins(context, CORE_Language.sys_NUM_LANG);
                        break;
                    case "Del_ByCode":
                       this.Del_ByCode(context);
                        break;
                    case "Sel_ByCode":
                        this.Sel_ByCode(context);
                      break;
                    case "Sel_ByID":
                       this.Sel_ByID(context);
                        break;
                    case "Sel_ByCode_ByIDLang":
                        this.Sel_ByCode_ByIDLang(context);
                        break;

                  
                    //-----------------------------------------------------------------------
                    default:
                        context.Response.Write("Can't find action");
                        break;
                }
            }
        }
        #region[select]
        public void Sel_ByIDLang(HttpContext context)
        {

            String jSonString = "";
            ExtendPropertiesBO aExtendPropertiesBO = new ExtendPropertiesBO();
            int IDLang = string.IsNullOrEmpty(context.Request.QueryString["IDLang"]) ? CORE_Language.sys_CUR_LANG : int.Parse(context.Request.QueryString["IDLang"]);


            List<ExtendProperties> obj = new List<ExtendProperties>();
            if (string.IsNullOrEmpty(context.Request.QueryString["Disable"]))
            {
                obj = aExtendPropertiesBO.Sel_ByIDLang(IDLang);
            }
            else
            {
                obj = aExtendPropertiesBO.Sel_ByIDLang(IDLang, bool.Parse(context.Request.QueryString["Disable"]));
            }


            int count = obj.Count;

            for (int i = 0; i < obj.Count; i++)
            {
                obj[i].Value = HttpUtility.HtmlDecode(obj[i].Value);
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
        public void Sel_ByID(HttpContext context)
        {
            String jSonString = "";
            int IDExtendProperties = int.Parse(context.Request.QueryString["IDExtendProperties"]);

            ExtendPropertiesBO aExtendPropertiesBO = new ExtendPropertiesBO();
            ExtendProperties obj = aExtendPropertiesBO.Sel_ByID(IDExtendProperties); 
            //obj.Info = HttpUtility.HtmlDecode(obj.Info);
            //obj.Intro = HttpUtility.HtmlDecode(obj.Intro);

            if (obj != null)
            {
                _converter.DateTimeFormat = "dd/MM/yyyy";

                jSonString = JsonConvert.SerializeObject(obj, _converter);
            }
            jSonString = "{\"data\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }
        public void Sel_ByCode(HttpContext context)
        {

            String jSonString = "";
            string Code = context.Request.QueryString["Code"];

             int Limit = context.Request.QueryString["Limit"] != null && context.Request.QueryString["Limit"] != "undefined" ? int.Parse(context.Request.QueryString["Limit"]) : 50;
             int ValueLenght = context.Request.QueryString["ValueLenght"] != null && context.Request.QueryString["ValueLenght"] != "undefined" ? int.Parse(context.Request.QueryString["ValueLenght"]) : 100;
             int NameLenght = context.Request.QueryString["NameLenght"] != null && context.Request.QueryString["NameLenght"] != "undefined" ? int.Parse(context.Request.QueryString["NameLenght"]) : 100;
            string Order = string.IsNullOrEmpty(context.Request.QueryString["Order"]) == false ? context.Request.QueryString["Order"] : "Contents_ID";
            bool IsDesc = context.Request.QueryString["IsDesc"] != null && context.Request.QueryString["IsDesc"] != "undefined" ? bool.Parse(context.Request.QueryString["IsDesc"]) : true;

            ExtendPropertiesBO aExtendPropertiesBO = new ExtendPropertiesBO();
            List<ExtendProperties> obj = aExtendPropertiesBO.Sel_ByCode(Code);
            obj = this.ConvertList(obj, NameLenght, ValueLenght, Limit, Order, IsDesc);


            //obj.Info = HttpUtility.HtmlDecode(obj.Info);
            //obj.Intro = HttpUtility.HtmlDecode(obj.Intro);

            if (obj != null)
            {
                _converter.DateTimeFormat = "dd/MM/yyyy";

                jSonString = JsonConvert.SerializeObject(obj, _converter);
            }
            jSonString = "{\"data\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }
        public void Sel_ByCode_ByIDLang(HttpContext context)
        {

            String jSonString = "";
            string Code = context.Request.QueryString["Code"];
            int IDLang = int.Parse(context.Request.QueryString["IDLang"]);
       
            ExtendPropertiesBO   aExtendPropertiesBO = new   ExtendPropertiesBO();
            List<ExtendProperties> obj = aExtendPropertiesBO.Sel_ByCode_ByIDLang(Code, IDLang);


            //obj.Info = HttpUtility.HtmlDecode(obj.Info);
            //obj.Intro = HttpUtility.HtmlDecode(obj.Intro);

            if (obj != null)
            {
                _converter.DateTimeFormat = "dd/MM/yyyy";

                jSonString = JsonConvert.SerializeObject(obj, _converter);
            }
            jSonString = "{\"data\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }
       
        #endregion
        #region [Insert Update Delete ]
        public void Ins(HttpContext context, int NUM_LANG)
        {
            ConfigsBO aConfigsBO = new ConfigsBO();

            //CodeCategoryLevel1 = Convert.ToString(context.Request.Form["txtCodeCategoryLevel1"]);


            String jSonString = "";
            try
            {
                List<ExtendProperties> aListExtendProperties = new List<ExtendProperties>();

                ExtendPropertiesBO aExtendPropertiesBO = new ExtendPropertiesBO();
                ExtendProperties aExtendProperties = new ExtendProperties();
                TimeSpan Codespan = new TimeSpan(DateTime.Now.Ticks);
                string Code = Math.Floor(Codespan.TotalSeconds).ToString();

                for (int i = 1; i <= NUM_LANG; i++)
                {
                    aExtendProperties = new ExtendProperties();
                    aExtendProperties.Code = Code;
                    //aContents.Data = null;
                    aExtendProperties.Name = !String.IsNullOrEmpty(context.Request.Form["txtName"]) ? Convert.ToString(context.Request.Form["txtName"]) : "";
                    aExtendProperties.Value = !String.IsNullOrEmpty(context.Request.Form["txtValue"]) ? Convert.ToString(context.Request.Form["txtValue"]) : "";
                    aExtendProperties.ValueType = !String.IsNullOrEmpty(context.Request.Form["cbbValueType"]) ? Convert.ToInt32(context.Request.Form["cbbValueType"]) : 0;
                    aExtendProperties.Image = !String.IsNullOrEmpty(context.Request.Form["txtImage"]) ? Convert.ToString(context.Request.Form["txtImage"]) : "";
                    aExtendProperties.Code = Code;
                    aExtendProperties.IDObject = !String.IsNullOrEmpty(context.Request.Form["cbbIDObject"]) ? Convert.ToInt32(context.Request.Form["cbbIDObject"]) : 0;
                    aExtendProperties.ObjectType = !String.IsNullOrEmpty(context.Request.Form["cbbObjectType"]) ? Convert.ToInt32(context.Request.Form["cbbObjectType"]) : 0;
                    aExtendProperties.IDLang = !String.IsNullOrEmpty(context.Request.Form["IDLang_" + i]) ? Convert.ToInt32(context.Request.Form["IDLang_" + i]) : 0;
                    aExtendProperties.Type = !String.IsNullOrEmpty(context.Request.Form["cbbType"]) ? Convert.ToInt32(context.Request.Form["cbbType"]) : 0;
                    aExtendProperties.Group = !String.IsNullOrEmpty(context.Request.Form["cbbGroup"]) ? Convert.ToInt32(context.Request.Form["cbbGroup"]) : 0;
                    aExtendProperties.Status = !String.IsNullOrEmpty(context.Request.Form["cbbStatus"]) ? Convert.ToInt32(context.Request.Form["cbbStatus"]) : 0;
                    aExtendProperties.CodeObject = !String.IsNullOrEmpty(context.Request.Form["cbbCodeObject"]) ? Convert.ToInt32(context.Request.Form["cbbCodeObject"]) : 0;

                    //aContents.CreatedBy = aCurrentSystemUsers.Username;

                    aExtendProperties.Disable = !String.IsNullOrEmpty(context.Request.Form["cbbDisable"]) ? Convert.ToBoolean(context.Request.Form["cbbDisable"]) : false;
                    //aContents.Tag = !String.IsNullOrEmpty(context.Request.Form["txtTag"]) ? Convert.ToString(context.Request.Form["txtTag"]) : "";
                    //aContents.DateCreated = !String.IsNullOrEmpty(context.Request.FormCodeObjecttxtDateCreated"]) ? DateTime.ParseExact(context.Request.Form["txtDateCreated"], "dd/MM/yyyy", culture) : DateTime.Now;

                    //aContents.DateEdited = !String.IsNullOrEmpty(context.Request.Form["txtDateEdited"]) ? DateTime.ParseExact(context.Request.Form["txtDateEdited"], "dd/MM/yyyy", culture) : DateTime.Now;
                    //aContents.UpdateBy = !String.IsNullOrEmpty(context.Request.Form["txtUpdateBy"]) ? Convert.ToString(context.Request.Form["txtUpdateBy"]) : "";
                    //aContents.PublishDate = !String.IsNullOrEmpty(context.Request.Form["txtPublishDate"]) ? DateTime.ParseExact(context.Request.Form["txtPublishDate"], "dd/MM/yyyy", culture) : DateTime.Now;

                    //aContents.ExpireDate = !String.IsNullOrEmpty(context.Request.Form["txtExpireDate"]) ? DateTime.ParseExact(context.Request.Form["txtExpireDate"], "dd/MM/yyyy", culture) : DateTime.Now;
                    //aContents.IDAlbum = !String.IsNullOrEmpty(context.Request.Form["txtIDAlbum"]) ? Convert.ToInt32(context.Request.Form["txtIDAlbum"]) : 0;
                    //aContents.ViewCount = !String.IsNullOrEmpty(context.Request.Form["txtViewCount"]) ? Convert.ToInt64(context.Request.Form["txtViewCount"]) : 0;

                    aExtendProperties.Image = !String.IsNullOrEmpty(context.Request.Form["txtImage"]) ? Convert.ToString(context.Request.Form["txtImage"]) : "";
                    //aContents.Image2 = !String.IsNullOrEmpty(context.Request.Form["txtImage_3"]) ? Convert.ToString(context.Request.Form["txtImage_3"]) : "";
                    //aContents.Image3 = !String.IsNullOrEmpty(context.Request.Form["txtImage_4"]) ? Convert.ToString(context.Request.Form["txtImage_4"]) : "";

                    //aContents.Title = !String.IsNullOrEmpty(context.Request.Form["txtTitle_Lang" + i]) ? Convert.ToString(context.Request.Form["txtTitle_Lang" + i]) : "";
                    //aContents.Intro = !String.IsNullOrEmpty(context.Request.Form["txtIntro_Lang" + i]) ? Convert.ToString(HttpUtility.HtmlDecode(context.Request.Form["txtIntro_Lang" + i])) : "";
                    //aContents.Info = !String.IsNullOrEmpty(context.Request.Form["txtInfo_Lang" + i]) ? Convert.ToString(HttpUtility.HtmlDecode(context.Request.Form["txtInfo_Lang" + i])) : "";

                    //aContents.ExtendProperties1 = !String.IsNullOrEmpty(context.Request.Form["txtExtendProperties1_Lang" + i]) ? Convert.ToString(context.Request.Form["txtExtendProperties1_Lang" + i]) : "";
                    //aContents.ExtendProperties2 = !String.IsNullOrEmpty(context.Request.Form["txtExtendProperties2_Lang" + i]) ? Convert.ToString(context.Request.Form["txtExtendProperties2_Lang" + i]) : "";
                    //aContents.ExtendProperties3 = !String.IsNullOrEmpty(context.Request.Form["txtExtendProperties3_Lang" + i]) ? Convert.ToString(context.Request.Form["txtExtendProperties3_Lang" + i]) : "";

                    //aContents.Image = !String.IsNullOrEmpty(context.Request.Form["txtImage_1"]) ? Convert.ToString(context.Request.Form["txtImage_1"]) : "";


                    aListExtendProperties.Add(aExtendProperties);
                }

                int Ret1 = -1;
                Ret1 = aExtendPropertiesBO.Ins(ref aListExtendProperties); 
                //if (Ret1 < aListExtendProperties.Count)
                //{
                //    jSonString = "{\"status\":\"error\" ,\"message\":\"" + Ret1.ToString() + "\"}";
                //     aExtendPropertiesBO.Del(aListExtendProperties);
                //    return;
                //}
                //else
                //{
                //    string ListTempt = !String.IsNullOrEmpty(context.Request.Form["ckbCodeCategoryLevel1[]"]) ? Convert.ToString(context.Request.Form["ckbCodeCategoryLevel1[]"]) : "";
                //    if (string.IsNullOrEmpty(ListTempt) == true)
                //    {
                //        CategoryLevel1BO aCategoryLevel1BO = new CategoryLevel1BO();
                //        List<CategoryLevel1> aListItem = aCategoryLevel1BO.Sel_ByCode("000");
                //        if (aListItem.Count > 0)
                //        {
                //            ListTempt = aListItem[0].Code;
                //        }
                //        else
                //        {
                //            this.CreateCategoryLevel1Default(context, "[Default]", NUM_LANG);
                //            ListTempt = "000";
                //        }
                //    }

                //    //else if (string.IsNullOrEmpty(ListTempt) == false)
                //    //{
                //    List<string> ListCodeCategoryLevel1 = ListTempt.Split(',').ToList();
                //    List<Contents_CategoryLevel1> aListContents_CategoryLevel1 = new List<Contents_CategoryLevel1>();
                //    Contents_CategoryLevel1 aContents_CategoryLevel1 = new Contents_CategoryLevel1();


                //    for (int ii = 0; ii < aListContents.Count; ii++)
                //    {
                //        for (int iii = 0; iii < ListCodeCategoryLevel1.Count; iii++)
                //        {
                //            aContents_CategoryLevel1 = new Contents_CategoryLevel1();

                //            aContents_CategoryLevel1.CodeCategoryLevel1 = ListCodeCategoryLevel1[iii].ToString();
                //            aContents_CategoryLevel1.CodeContents = aListContents[ii].Code.ToString();
                //            aContents_CategoryLevel1.Disable = aListContents[ii].Disable;
                //            aContents_CategoryLevel1.IDLang = aListContents[ii].IDLang;
                //            aContents_CategoryLevel1.Status = aListContents[ii].Status;
                //            aContents_CategoryLevel1.Type = aListContents[ii].Type;

                //            aListContents_CategoryLevel1.Add(aContents_CategoryLevel1);
                //        }
                //    }
                //    Contents_CategoryLevel1BO aContents_CategoryLevel1BO = new Contents_CategoryLevel1BO();
                //    int Ret2 = -1;
                //    Ret2 = aContents_CategoryLevel1BO.Ins(ref aListContents_CategoryLevel1);
                //    if (Ret2 < aListContents_CategoryLevel1.Count)
                //    {
                //        aContents_CategoryLevel1BO.Del(aListContents_CategoryLevel1);
                //        aContentsBO.Del(aListContents);
                //        jSonString = "{\"status\":\"error\" ,\"message\":\"" + Ret2.ToString() + "\"}";
                //        return;
                //    }
                //    //}
                //}

                jSonString = "{\"status\": \"success\"}";
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
        public void Upd_ByCode(HttpContext context, int NUM_LANG)
        {


            try
            {
                if (NUM_LANG < 1)
                {
                    NUM_LANG = 1;
                }
                List<ExtendProperties> aListExtendProperties = new List<ExtendProperties>();
                ExtendPropertiesBO aExtendPropertiesBO = new ExtendPropertiesBO();
                String Code = context.Request.Form["txtCode"];

                aListExtendProperties = aExtendPropertiesBO.Sel_ByCode(Code);

                if (aListExtendProperties.Count <= NUM_LANG)
                {
                    for (int i = 0; i < aListExtendProperties.Count; i++)
                    {
                        //aListExtendProperties[i].UpdateBy = aCurrentSystemUsers.Username;
                        aListExtendProperties[i].Name = !String.IsNullOrEmpty(context.Request.Form["txtName"]) ? Convert.ToString(context.Request.Form["txtName"]) : aListExtendProperties[i].Name;
                        aListExtendProperties[i].Value = !String.IsNullOrEmpty(context.Request.Form["txtValue"]) ? Convert.ToString(context.Request.Form["txtValue"]) : aListExtendProperties[i].Value;
                        aListExtendProperties[i].ValueType = !String.IsNullOrEmpty(context.Request.Form["cbbValueType"]) ? Convert.ToInt32(context.Request.Form["cbbValueType"]) : aListExtendProperties[i].ValueType;
                        aListExtendProperties[i].Image = !String.IsNullOrEmpty(context.Request.Form["txtImage"]) ? Convert.ToString(context.Request.Form["txtImage"]) : aListExtendProperties[i].Image;
                        aListExtendProperties[i].IDObject = !String.IsNullOrEmpty(context.Request.Form["cbbIDObject"]) ? Convert.ToInt32(context.Request.Form["cbbIDObject"]) : aListExtendProperties[i].IDObject;
                        aListExtendProperties[i].ObjectType = !String.IsNullOrEmpty(context.Request.Form["cbbObjectType"]) ? Convert.ToInt32(context.Request.Form["cbbObjectType"]) : aListExtendProperties[i].IDObject;
                        aListExtendProperties[i].IDLang = !String.IsNullOrEmpty(context.Request.Form["IDLanguage_Lang" + (i + 1)]) ? Convert.ToInt32(context.Request.Form["IDLanguage_Lang" + (i + 1)]) : aListExtendProperties[i].IDLang;
                        aListExtendProperties[i].Type = !String.IsNullOrEmpty(context.Request.Form["cbbType"]) ? Convert.ToInt32(context.Request.Form["cbbType"]) : aListExtendProperties[i].Type;
                        aListExtendProperties[i].Group = !String.IsNullOrEmpty(context.Request.Form["cbbGroup"]) ? Convert.ToInt32(context.Request.Form["cbbGroup"]) : aListExtendProperties[i].Group;
                        aListExtendProperties[i].Status = !String.IsNullOrEmpty(context.Request.Form["cbbStatus"]) ? Convert.ToInt32(context.Request.Form["cbbStatus"]) : aListExtendProperties[i].Status;
                        aListExtendProperties[i].CodeObject = !String.IsNullOrEmpty(context.Request.Form["cbbCodeObject"]) ? Convert.ToInt32(context.Request.Form["cbbCodeObject"]) : aListExtendProperties[i].CodeObject;
                        aListExtendProperties[i].Disable = !String.IsNullOrEmpty(context.Request.Form["cbbDisable"]) ? Convert.ToBoolean(context.Request.Form["cbbDisable"]) : aListExtendProperties[i].Disable;
                        //aListContents[i].Title = !String.IsNullOrEmpty(context.Request.Form["txtTitle_Lang" + (i + 1)]) ? Convert.ToString(context.Request.Form["txtTitle_Lang" + (i + 1)]) : aListContents[i].Title;

                        //aListContents[i].Info = !String.IsNullOrEmpty(context.Request.Form["txtInfo_Lang" + (i + 1)]) ? Convert.ToString(HttpUtility.HtmlDecode(context.Request.Form["txtInfo_Lang" + (i + 1)])) : aListContents[i].Info;

                        //aListContents[i].Intro = !String.IsNullOrEmpty(context.Request.Form["txtIntro_Lang" + (i + 1)]) ? Convert.ToString(HttpUtility.HtmlDecode(context.Request.Form["txtIntro_Lang" + (i + 1)])) : aListContents[i].Intro;

                        //aListContents[i].Status = !String.IsNullOrEmpty(context.Request.Form["ddlStatus"]) ? Convert.ToInt32(context.Request.Form["ddlStatus"]) : aListContents[i].Status;

                        //aListContents[i].CreatedBy = !String.IsNullOrEmpty(context.Request.Form["txtCreatedBy"]) ? Convert.ToString(context.Request.Form["txtCreatedBy"]) : aListContents[i].CreatedBy;

                        //aListContents[i].Disable = !String.IsNullOrEmpty(context.Request.Form["cbbDisable"]) ? Convert.ToBoolean(context.Request.Form["cbbDisable"]) : aListContents[i].Disable;

                        //aListContents[i].Tag = !String.IsNullOrEmpty(context.Request.Form["txtTag"]) ? Convert.ToString(context.Request.Form["txtTag"]) : aListContents[i].Tag;

                        //aListContents[i].DateCreated = !String.IsNullOrEmpty(context.Request.Form["dtpDateCreated"]) ? DateTime.ParseExact(context.Request.Form["dtpDateCreated"], "dd/MM/yyyy", culture) : aListContents[i].DateCreated;

                        //aListContents[i].DateEdited = !String.IsNullOrEmpty(context.Request.Form["dtpDateEdited"]) ? DateTime.ParseExact(context.Request.Form["dtpDateEdited"], "dd/MM/yyyy", culture) : aListContents[i].DateEdited;

                        //aListContents[i].PublishDate = !String.IsNullOrEmpty(context.Request.Form["dtpPublishDate"]) ? DateTime.ParseExact(context.Request.Form["dtpPublishDate"], "dd/MM/yyyy", culture) : aListContents[i].PublishDate;

                        //aListContents[i].ExpireDate = !String.IsNullOrEmpty(context.Request.Form["dtpExpireDate"]) ? DateTime.ParseExact(context.Request.Form["dtpExpireDate"], "dd/MM/yyyy", culture) : aListContents[i].ExpireDate;

                        //aListContents[i].Image = !String.IsNullOrEmpty(context.Request.Form["txtImage_1"]) ? Convert.ToString(context.Request.Form["txtImage_1"]) : "";
                        //aListContents[i].Image1 = !String.IsNullOrEmpty(context.Request.Form["txtImage_2"]) ? Convert.ToString(context.Request.Form["txtImage_2"]) : "";
                        //aListContents[i].Image2 = !String.IsNullOrEmpty(context.Request.Form["txtImage_3"]) ? Convert.ToString(context.Request.Form["txtImage_3"]) : "";
                        //aListContents[i].Image3 = !String.IsNullOrEmpty(context.Request.Form["txtImage_4"]) ? Convert.ToString(context.Request.Form["txtImage_4"]) : "";

                        //aListContents[i].IDAlbum = !String.IsNullOrEmpty(context.Request.Form["txtIDAlbum"]) ? Convert.ToInt32(context.Request.Form["txtIDAlbum"]) : aListContents[i].IDAlbum;

                        //aListContents[i].IDLang = !String.IsNullOrEmpty(context.Request.Form["IDLanguage_Lang" + (i + 1)]) ? Convert.ToInt32(context.Request.Form["IDLanguage_Lang" + (i + 1)]) : aListContents[i].IDLang;

                        //aListContents[i].Code = !String.IsNullOrEmpty(context.Request.Form["txtCode"]) ? Convert.ToString(context.Request.Form["txtCode"]) : aListContents[i].Code;

                        //aListContents[i].ExtendProperties1 = !String.IsNullOrEmpty(context.Request.Form["txtExtendProperties1_Lang" + (i + 1)]) ? Convert.ToString(context.Request.Form["txtExtendProperties1_Lang" + (i + 1)]) : aListContents[i].ExtendProperties1;

                        //aListContents[i].ExtendProperties2 = !String.IsNullOrEmpty(context.Request.Form["txtExtendProperties2_Lang" + (i + 1)]) ? Convert.ToString(context.Request.Form["txtExtendProperties2_Lang" + (i + 1)]) : aListContents[i].ExtendProperties2;

                        //aListContents[i].ExtendProperties3 = !String.IsNullOrEmpty(context.Request.Form["txtExtendProperties3_Lang" + (i + 1)]) ? Convert.ToString(context.Request.Form["txtExtendProperties3_Lang" + (i + 1)]) : aListContents[i].ExtendProperties3;

                        //aListContents[i].ViewCount = !String.IsNullOrEmpty(context.Request.Form["txtViewCount"]) ? Convert.ToInt64(context.Request.Form["txtViewCount"]) : 0;
                    }

                    int Ret1 = -1;
                    Ret1 = aExtendPropertiesBO.Upd(aListExtendProperties);
                    //String jSonString = "";



                    //string ListTempt = !String.IsNullOrEmpty(context.Request.Form["ckbCodeCategoryLevel1[]"]) ? Convert.ToString(context.Request.Form["ckbCodeCategoryLevel1[]"]) : "";

                //    if (string.IsNullOrEmpty(ListTempt) == false)
                //    {
                //        List<string> ListCodeCategoryLevel1 = ListTempt.Split(',').ToList();
                //        List<Contents_CategoryLevel1> aListContents_CategoryLevel1 = new List<Contents_CategoryLevel1>();
                //        List<Contents_CategoryLevel1> aListTempt = new List<Contents_CategoryLevel1>();

                //        Contents_CategoryLevel1 aContents_CategoryLevel1 = new Contents_CategoryLevel1();
                //        Contents_CategoryLevel1BO aContents_CategoryLevel1BO = new Contents_CategoryLevel1BO();
                //        for (int ii = 0; ii < aListContents.Count; ii++)
                //        {
                //            for (int iii = 0; iii < ListCodeCategoryLevel1.Count; iii++)
                //            {
                //                aListTempt = aContents_CategoryLevel1BO.Sel_ByCodeContents_ByIDLang(aListContents[ii].Code, aListContents[ii].IDLang.GetValueOrDefault(0)).Where(p => p.CodeCategoryLevel1 == ListCodeCategoryLevel1[iii]).ToList();
                //                if (aListTempt.Count > 0)
                //                {
                //                    aListTempt[0].Disable = aListContents[ii].Disable;
                //                    aListTempt[0].Status = aListContents[ii].Status;
                //                    aListTempt[0].Type = aListContents[ii].Type;

                //                    aListContents_CategoryLevel1.Add(aListTempt[0]);

                //                }
                //                else
                //                {
                //                    aContents_CategoryLevel1 = new Contents_CategoryLevel1();

                //                    aContents_CategoryLevel1.Disable = aListContents[ii].Disable;
                //                    aContents_CategoryLevel1.Status = aListContents[ii].Status;
                //                    aContents_CategoryLevel1.Type = aListContents[ii].Type;

                //                    aContents_CategoryLevel1.CodeContents = aListContents[ii].Code;
                //                    aContents_CategoryLevel1.CodeCategoryLevel1 = ListCodeCategoryLevel1[iii];
                //                    aContents_CategoryLevel1.IDLang = aListContents[ii].IDLang;

                //                    aListContents_CategoryLevel1.Add(aContents_CategoryLevel1);

                //                }

                //            }
                //        }

                //        int Ret2 = -1;
                //        Ret2 = aContents_CategoryLevel1BO.Upd(aListContents_CategoryLevel1);
                //        jSonString = "";

                //        if (Ret2 < aListContents.Count)
                //        {
                //            jSonString = "{\"status\":\"error\" ,\"message\":\"" + Ret2.ToString() + "\"}";

                //            return;
                //        }
                //    }
                //}
               }
            }
            catch (Exception e1)
            {
            }
        }
        public void Upd_Disable(HttpContext context)
        {
            int ret = -1;
            String jSonString = "";
            try
            {
                ExtendPropertiesBO aExtendPropertiesBO = new ExtendPropertiesBO();
                List<ExtendProperties> listExtendProperties = new List<ExtendProperties>();
                string Code = aExtendPropertiesBO.Sel_ByID(int.Parse(context.Request.QueryString["IDExtendProperties"])).Code;
                //listContents = aContentsBO.Sel_all_ByCode(Code);
                for (int i = 0; i < listExtendProperties.Count; i++)
                {
                    listExtendProperties[i].Disable = true;
                    ret = aExtendPropertiesBO.Upd(listExtendProperties[i]);
                }

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
        public void Del(HttpContext context)
        {
              
            String  jSonString = "";
            int IDExtendProperties = Convert.ToInt32(context.Request.QueryString["IDExtendProperties"]);

            ExtendPropertiesBO aExtendPropertiesBO = new ExtendPropertiesBO();
            int ret = aExtendPropertiesBO.Del_ByID(IDExtendProperties);


            if (ret > 0)
            { jSonString = "{\"status\": \"success\"}"; }

            if (ret <= 0)
            { jSonString = "{\"status\":\"error\" ,\"message\":\"" + ret.ToString() + "\"}"; }


            context.Response.Write(jSonString);
        }
        public void Del_ByCode(HttpContext context)
        {
            ExtendPropertiesBO aExtendPropertiesBO = new ExtendPropertiesBO();
            String jSonString = "";
            string Code = context.Request.QueryString["Code"].ToString();
            int ret = aExtendPropertiesBO.Del_ByCode(Code);


            if (ret > 0)
            { jSonString = "{\"status\": \"success\"}"; }

            if (ret <= 0)
            { jSonString = "{\"status\":\"error\" ,\"message\":\"" + ret.ToString() + "\"}"; }


            context.Response.Write(jSonString);
        }
        #endregion
        #region [function Sort]         
        private List<ExtendProperties> ConvertList(List<ExtendProperties> ListExtendProperties, int NameLenght, int ValueLenght, int Limit, string Order, bool IsDesc)
        {
            if ((Limit == null) || (Limit <= 0))
            {
                Limit = ListExtendProperties.Count;
            }
            if (Limit > ListExtendProperties.Count)
            {
                Limit = ListExtendProperties.Count;
            }

            if ((NameLenght == null) || (NameLenght <= 0))
            {
                NameLenght = 1000;
            }
            if ((ValueLenght == null) || (ValueLenght <= 0))
            {
                ValueLenght = 1000;
            }

            //=========================

            switch (Order)
            {
                case "Code":
                    if (IsDesc == false)
                    {
                        ListExtendProperties = ListExtendProperties.OrderBy(a => a.Code).ToList();
                    }
                    else
                    {
                        ListExtendProperties = ListExtendProperties.OrderByDescending(a => a.Code).ToList();
                    }
                    break;
                case "Name":
                    if (IsDesc == false)
                    {
                        ListExtendProperties = ListExtendProperties.OrderBy(a => a.Name).ToList();
                    }
                    else
                    {
                        ListExtendProperties = ListExtendProperties.OrderByDescending(a => a.Name).ToList();
                    }
                    break;
                case "Group":
                    if (IsDesc == false)
                    {
                        ListExtendProperties = ListExtendProperties.OrderBy(a => a.Group).ToList();
                    }
                    else
                    {
                        ListExtendProperties = ListExtendProperties.OrderByDescending(a => a.Group).ToList();
                    }
                    break;
              
                //==============================================================================
                 default:

                    break;
            }
            //###############################################################################
            int NameLenght_Tempt = NameLenght;
            int ValueLenght_Tempt = ValueLenght;

            for (int i = 0; i < Limit; i++)
            {
                if (ListExtendProperties[i].Name.Length < NameLenght_Tempt)
                {
                    NameLenght_Tempt = ListExtendProperties[i].Name.Length;
                }
                if (ListExtendProperties[i].Value.Length < ValueLenght_Tempt)
                {
                    ValueLenght_Tempt = ListExtendProperties[i].Value.Length;
                }

                //if (TitleLenght == 0) { TitleLenght = 1; }
                //if (IntroLenght == 0) { IntroLenght = 1; }

                ListExtendProperties[i].Name = ListExtendProperties[i].Name.Substring(0, NameLenght_Tempt);
                ListExtendProperties[i].Value = ListExtendProperties[i].Value.Substring(0, ValueLenght_Tempt);

                NameLenght_Tempt = NameLenght;
                ValueLenght_Tempt = ValueLenght;
            }



            ListExtendProperties = ListExtendProperties.GetRange(0, Limit).ToList();
            return ListExtendProperties;
            //=========================
        }
        
        #endregion



    }
}
