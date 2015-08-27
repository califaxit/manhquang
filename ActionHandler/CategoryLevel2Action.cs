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
    public class CategoryLevel2Action : IAction
    {
        //  DatabaseDA aDatabaseDA = new DatabaseDA();

        //================
        //KhoiDT cat2_18_6
        //================================
        public void Do(HttpContext context)
        {
            string action = context.Request["action"].ToString();
            if (!String.IsNullOrEmpty(action))
            {
                switch (action)
                {


                    case "Sel_ByCode":
                        Sel_ByCode(context);
                        break;
                    case "Sel_ByDisable":
                        Sel_ByDisable(context);
                        break;
                    case "Sel_ByCode_ByIDLang":
                        Sel_ByCode_ByIDLang(context);
                        break;
                    case "Sel_ByIDLang":
                        Sel_ByIDLang(context);
                        break;
                    case "Sel_Ext_ByIDLang":
                        Sel_Ext_ByIDLang(context);
                        break;
                    case "Sel_ByID":
                        Sel_ByID(context);
                        break;
                    case "Sel_ByCodeCategoryLevel1":
                        Sel_ByCodeCategoryLevel1(context);
                        break;
                    case "Sel_ByCodeCategoryLevel1_ByIDLang":
                        Sel_ByCodeCategoryLevel1_ByIDLang(context);
                        break;
                    case "Sel_Ext_ByCodeCategoryLevel1":
                        Sel_Ext_ByCodeCategoryLevel1(context);
                        break;
                    //=====================================================
                    case "Sel_Ext_ByCodeCategoryLevel1_ByIDLang":
                        Sel_Ext_ByCodeCategoryLevel1_ByIDLang(context);
                        break;
                    case "Sel_ListCategoryLevel2_ByType_ByIDLang":
                        Sel_ListCategoryLevel2_ByType_ByIDLang(context);
                        break;
                    case "Sel_Ext_ByCode":
                        this.Sel_Ext_ByCode(context);
                        break;
                    case "Sel_ByKeyCodeCategoryLevel2_ByIDLang":
                        this.Sel_ByKeyCodeCategoryLevel2_ByIDLang(context);
                        break;
                    //====================================================
                    case "Upd_ByCode":
                        Upd_ByCode(context, CORE_Language.sys_NUM_LANG);
                        break;
                    case "Upd_Disable":
                        Upd_Disable(context);
                        break;
                    case "Upd_Status_ByID":
                        Upd_Status_ByID(context);
                        break;
                    case "Upd_Type_ByID":
                        Upd_Type_ByID(context);
                        break;
                    case "Upd_Disable_ByID":
                        Upd_Disable_ByID(context);
                        break;
                    case "Upd_Status_ByCode":
                        Upd_Status_ByCode(context);
                        break;
                    case "Upd_Type_ByCode":
                        Upd_Type_ByCode(context);
                        break;
                    case "Upd_Disable_ByCode":
                        Upd_Disable_ByCode(context);
                        break;
                    case "Upd_Status_ByCode_ByIDLang":
                        Upd_Status_ByCode_ByIDLang(context);
                        break;
                    case "Upd_Type_ByCode_ByIDLang":
                        Upd_Type_ByCode_ByIDLang(context);
                        break;
                    case "Upd_Disable_ByCode_ByIDLang":
                        Upd_Disable_ByCode_ByIDLang(context);
                        break;
                    //===========================================
                    case "Ins":
                        Ins(context, CORE_Language.sys_NUM_LANG);
                        break;
                    //===========================================
                    case "Del_ByCode":
                        Del_ByCode(context);
                        break;
                    case "Del_ByCode_ByIDLang":
                        Del_ByCode_ByIDLang(context);
                        break;
                    case "Del_ByID":
                        Del_ByID(context);
                        break;
                    //case "Del_ByListCode":
                    //    Del_ByListCode(context);
                    //    break;
                    default:
                        context.Response.Write("Can't find action");
                        break;
                    //==============================================================


                }
            }
        }



        private IsoDateTimeConverter _converter = new IsoDateTimeConverter();
        //====================================================================
        #region SELECT DATABASE

        public void Sel_ByDisable(HttpContext context)
        {
            String jSonString = "";
            bool Disable = Convert.ToBoolean(context.Request.QueryString["Disable"]);

            int Limit = context.Request.QueryString["Limit"] != null && context.Request.QueryString["Limit"] != "undefined" ? int.Parse(context.Request.QueryString["Limit"]) : 50;
            int IntroLenght = context.Request.QueryString["IntroLenght"] != null && context.Request.QueryString["IntroLenght"] != "undefined" ? int.Parse(context.Request.QueryString["IntroLenght"]) : 100;
            int InfoLenght = context.Request.QueryString["InfoLenght"] != null && context.Request.QueryString["InfoLenght"] != "undefined" ? int.Parse(context.Request.QueryString["InfoLenght"]) : 100;
            string Order = string.IsNullOrEmpty(context.Request.QueryString["Order"]) == false ? context.Request.QueryString["Order"] : "CategoryNameLevel2_ID";
            bool IsDesc = context.Request.QueryString["IsDesc"] != null && context.Request.QueryString["IsDesc"] != "undefined" ? bool.Parse(context.Request.QueryString["IsDesc"]) : true;

            CategoryLevel2BO aCategoryLevel2BO = new CategoryLevel2BO();
            List<CategoryLevel2> obj = aCategoryLevel2BO.Sel_ByDisable(Disable);
            obj = this.ConvertList(obj, InfoLenght, IntroLenght, Limit, Order, IsDesc);


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

        public void Sel_Ext_ByIDLang(HttpContext context)
        {
            String jSonString = "";
            CategoryLevel2BO aCategoryLevel2BO = new CategoryLevel2BO();
            int IDLang = string.IsNullOrEmpty(context.Request.QueryString["IDLang"]) ? CORE_Language.sys_CUR_LANG : int.Parse(context.Request.QueryString["IDLang"]);

            List<vw_CategoryLevel2ViewAll> obj = aCategoryLevel2BO.Sel_Ext_ByIDLang(IDLang).ToList();
            /*for (int i = 0; i < NUM_LANG; i++)
            {
                obj[i].Info = HttpUtility.HtmlDecode(obj[i].Info);
                obj[i].Intro = HttpUtility.HtmlDecode(obj[i].Intro);
            }*/
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

            bool Disable = !String.IsNullOrEmpty(context.Request.QueryString["Disable"])
              ? Convert.ToBoolean(context.Request.QueryString["Disable"])
              : false;

            //-----------------------------------------------------------
            int IDLang = !string.IsNullOrEmpty(context.Request.QueryString["IDLang"].ToString()) ? int.Parse(context.Request.QueryString["IDLang"]) : 1;
            CategoryLevel2BO aCategoryLevel2BO = new CategoryLevel2BO();
            CategoryLevel2 obj = String.IsNullOrEmpty(context.Request.QueryString["Disable"])
            ? aCategoryLevel2BO.Sel_ByCode_ByIDLang(Code, IDLang)
            : aCategoryLevel2BO.Sel_ByCode_ByIDLang(Code, IDLang, Disable);

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
            int ID = Convert.ToInt32(context.Request.QueryString["ID"]);
            //---
            bool Disable = !String.IsNullOrEmpty(context.Request.QueryString["Disable"])
                ? Convert.ToBoolean(context.Request.QueryString["Disable"])
                : false;

            int Limit = context.Request.QueryString["Limit"] != null && context.Request.QueryString["Limit"] != "undefined" ? int.Parse(context.Request.QueryString["Limit"]) : 50;
            int IntroLenght = context.Request.QueryString["IntroLenght"] != null && context.Request.QueryString["IntroLenght"] != "undefined" ? int.Parse(context.Request.QueryString["IntroLenght"]) : 100;
            int InfoLenght = context.Request.QueryString["InfoLenght"] != null && context.Request.QueryString["InfoLenght"] != "undefined" ? int.Parse(context.Request.QueryString["InfoLenght"]) : 100;
            string Order = string.IsNullOrEmpty(context.Request.QueryString["Order"]) == false ? context.Request.QueryString["Order"] : "CategoryNameLevel2_ID";
            bool IsDesc = context.Request.QueryString["IsDesc"] != null && context.Request.QueryString["IsDesc"] != "undefined" ? bool.Parse(context.Request.QueryString["IsDesc"]) : true;

            CategoryLevel2BO aCategoryLevel2BO = new CategoryLevel2BO();

            //--
            CategoryLevel2 obj = String.IsNullOrEmpty(context.Request.QueryString["Disable"])
                ? aCategoryLevel2BO.Sel_ByID(ID)
                : aCategoryLevel2BO.Sel_ByID(ID, Disable);

            if (obj != null)
            {
                _converter.DateTimeFormat = "dd/MM/yyyy";

                jSonString = JsonConvert.SerializeObject(obj, _converter);
            }
            jSonString = "{\"data\":" + jSonString + "}";
            context.Response.Write(jSonString);

        }

        public void Sel_ByCodeCategoryLevel1(HttpContext context)
        {
            String jSonString = "";
            CategoryLevel2BO aCategoryLevel2BO = new CategoryLevel2BO();

            string CodeCategoryLevel1 = context.Request.QueryString["CodeCategoryLevel1"] != null && context.Request.QueryString["CodeCategoryLevel1"] != "undefined" ? context.Request.QueryString["CodeCategoryLevel1"] : "";

            bool Disable = !String.IsNullOrEmpty(context.Request.QueryString["Disable"])
                ? Convert.ToBoolean(context.Request.QueryString["Disable"])
                : false;

            List<CategoryLevel2> obj = String.IsNullOrEmpty(context.Request.QueryString["Disable"])
                ? aCategoryLevel2BO.Sel_ByCodeCategoryLevel1(CodeCategoryLevel1)
                : aCategoryLevel2BO.Sel_ByCodeCategoryLevel1(CodeCategoryLevel1, Disable);
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
            //---
            bool Disable = !String.IsNullOrEmpty(context.Request.QueryString["Disable"])
                ? Convert.ToBoolean(context.Request.QueryString["Disable"])
                : false;

            int Limit = context.Request.QueryString["Limit"] != null && context.Request.QueryString["Limit"] != "undefined" ? int.Parse(context.Request.QueryString["Limit"]) : 50;
            int IntroLenght = context.Request.QueryString["IntroLenght"] != null && context.Request.QueryString["IntroLenght"] != "undefined" ? int.Parse(context.Request.QueryString["IntroLenght"]) : 100;
            int InfoLenght = context.Request.QueryString["InfoLenght"] != null && context.Request.QueryString["InfoLenght"] != "undefined" ? int.Parse(context.Request.QueryString["InfoLenght"]) : 100;
            string Order = string.IsNullOrEmpty(context.Request.QueryString["Order"]) == false ? context.Request.QueryString["Order"] : "CategoryNameLevel2_ID";
            bool IsDesc = context.Request.QueryString["IsDesc"] != null && context.Request.QueryString["IsDesc"] != "undefined" ? bool.Parse(context.Request.QueryString["IsDesc"]) : true;

            CategoryLevel2BO aCategoryLevel2BO = new CategoryLevel2BO();

            //--
            List<CategoryLevel2> obj = String.IsNullOrEmpty(context.Request.QueryString["Disable"])
                ? aCategoryLevel2BO.Sel_ByCode(Code)
                : aCategoryLevel2BO.Sel_ByCode(Code, Disable);

            obj = this.ConvertList(obj, InfoLenght, IntroLenght, Limit, Order, IsDesc);


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

        public void Sel_ByIDLang(HttpContext context)
        {

            String jSonString = "";
            CategoryLevel2BO aCategoryLevel2BO = new CategoryLevel2BO();
            int IDLang = string.IsNullOrEmpty(context.Request.QueryString["IDLang"]) ? CORE_Language.sys_CUR_LANG : int.Parse(context.Request.QueryString["IDLang"]);

            List<CategoryLevel2> obj = aCategoryLevel2BO.Sel_ByIDLang(IDLang).ToList();
            /*for (int i = 0; i < NUM_LANG; i++)
            {
                obj[i].Info = HttpUtility.HtmlDecode(obj[i].Info);
                obj[i].Intro = HttpUtility.HtmlDecode(obj[i].Intro);
            }*/
            if (obj != null)
            {
                _converter.DateTimeFormat = "dd/MM/yyyy";

                jSonString = JsonConvert.SerializeObject(obj, _converter);
            }
            jSonString = "{\"data\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }

        public void Sel_Ext_ByCode(HttpContext context)   // Load ra danh sách các contact bằng IDLang
        {

            String jSonString = "";

            string Code = context.Request.QueryString["Code"] != null && context.Request.QueryString["Code"] != "undefined" ? context.Request.QueryString["Code"] : "";
            int IDLang = context.Request.QueryString["IDLang"] != null && context.Request.QueryString["IDLang"] != "undefined" ? int.Parse(context.Request.QueryString["IDLang"]) : 1;

            int IntroLenght = context.Request.QueryString["IntroLenght"] != null && context.Request.QueryString["IntroLenght"] != "undefined" ? int.Parse(context.Request.QueryString["IntroLenght"]) : -1;
            int TitleLenght = context.Request.QueryString["TitleLenght"] != null && context.Request.QueryString["TitleLenght"] != "undefined" ? int.Parse(context.Request.QueryString["TitleLenght"]) : -1;
            int Limit = context.Request.QueryString["Limit"] != null && context.Request.QueryString["Limit"] != "undefined" ? int.Parse(context.Request.QueryString["Limit"]) : -1;
            string Order = context.Request.QueryString["Order"] != null && context.Request.QueryString["Order"] != "undefined" ? context.Request.QueryString["Order"] : "-1";
            string IsDesc = context.Request.QueryString["IsDesc"] != null && context.Request.QueryString["IsDesc"] != "undefined" ? context.Request.QueryString["IsDesc"] : "-1";

            CategoryLevel2BO aCategoryLevel2BO = new CategoryLevel2BO();
            List<vw_CategoryLevel2ViewAll> obj = aCategoryLevel2BO.Sel_Ext_ByCode(Code);

            List<vw_CategoryLevel2ViewAll> ObjOrder = new List<vw_CategoryLevel2ViewAll>();

            switch (Order)
            {
                case "Code":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.Code).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.Code).ToList();
                    }
                    break;

                case "CategoryNameLevel2":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.CategoryNameLevel2).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CategoryNameLevel2).ToList();
                    }
                    break;

                case "CountCategoryLeve1":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.CountCategoryLeve1).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CountCategoryLeve1).ToList();
                    }
                    break;
                case "CountCategoryLeve1Disable":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.CountCategoryLeve1Disable).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CountCategoryLeve1Disable).ToList();
                    }
                    break;
                case "CountCategoryLeve1Enable":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.CountCategoryLeve1Enable).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CountCategoryLeve1Enable).ToList();
                    }
                    break;
                case "Disable":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.Disable).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.Disable).ToList();
                    }
                    break;
                case "ID":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.ID).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.ID).ToList();
                    }
                    break;
                case "IDAlbum":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.IDAlbum).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.IDAlbum).ToList();
                    }
                    break;
                case "IDLang":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.IDLang).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.IDLang).ToList();
                    }
                    break;

                case "Status":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.Status).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.Status).ToList();
                    }
                    break;
                case "Tag":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.Tag).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.Tag).ToList();
                    }
                    break;
                case "Type":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.Type).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.Type).ToList();
                    }
                    break;
                case "ViewCount":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.ViewCount).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.ViewCount).ToList();
                    }
                    break;

                default:
                    ObjOrder = obj;
                    break;
            }


            for (int i = 0; i < ObjOrder.Count; i++)
            {
                if ((TitleLenght > -1) & (ObjOrder[i].CategoryNameLevel2.Length > TitleLenght))
                {
                    ObjOrder[i].CategoryNameLevel2 = ObjOrder[i].CategoryNameLevel2.Substring(0, TitleLenght - 1);
                }
                if ((IntroLenght > -1) & (ObjOrder[i].Info.Length > IntroLenght))
                {
                    ObjOrder[i].Info = ObjOrder[i].Info.Substring(0, IntroLenght - 1);
                }
            }
            List<vw_CategoryLevel2ViewAll> ObjOrderLimit = new List<vw_CategoryLevel2ViewAll>();
            if ((Limit > -1) & (ObjOrder.Count > Limit))
            {
                ObjOrderLimit = ObjOrder.GetRange(0, Limit).ToList();
                _converter.DateTimeFormat = "dd/MM/yyyy";
                jSonString = JsonConvert.SerializeObject(ObjOrderLimit, _converter);
            }
            else
            {
                if (ObjOrder != null)
                {
                    _converter.DateTimeFormat = "dd/MM/yyyy";
                    jSonString = JsonConvert.SerializeObject(ObjOrder, _converter);
                }
            }
            jSonString = "{\"CategoryLevel2\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }


        public void Sel_ByKeyCodeCategoryLevel2_ByIDLang(HttpContext context)   // Load ra danh sách các contact bằng IDLang
        {
            String jSonString = "";

            bool Disable = !String.IsNullOrEmpty(context.Request.QueryString["Disable"])
              ? Convert.ToBoolean(context.Request.QueryString["Disable"])
              : false;

            string KeyCodeCategoryLevel2 = context.Request.QueryString["KeyCodeCategoryLevel2"] != null && context.Request.QueryString["KeyCodeCategoryLevel2"] != "undefined" ? context.Request.QueryString["KeyCodeCategoryLevel2"] : "";
            int IDLang = string.IsNullOrEmpty(context.Request.QueryString["IDLang"]) == false && context.Request.QueryString["IDLang"] != "undefined" ? int.Parse(context.Request.QueryString["IDLang"]) : 1;

            int IntroLenght = context.Request.QueryString["IntroLenght"] != null && context.Request.QueryString["IntroLenght"] != "undefined" ? int.Parse(context.Request.QueryString["IntroLenght"]) : -1;
            int TitleLenght = context.Request.QueryString["TitleLenght"] != null && context.Request.QueryString["TitleLenght"] != "undefined" ? int.Parse(context.Request.QueryString["TitleLenght"]) : -1;
            int Limit = context.Request.QueryString["Limit"] != null && context.Request.QueryString["Limit"] != "undefined" ? int.Parse(context.Request.QueryString["Limit"]) : -1;
            string Order = context.Request.QueryString["Order"] != null && context.Request.QueryString["Order"] != "undefined" ? context.Request.QueryString["Order"] : "-1";
            string IsDesc = context.Request.QueryString["IsDesc"] != null && context.Request.QueryString["IsDesc"] != "undefined" ? context.Request.QueryString["IsDesc"] : "-1";

            CategoryLevel2BO aCategoryLevel2BO = new CategoryLevel2BO();
            List<vw_CategoryLevel2ViewAll> obj = String.IsNullOrEmpty(context.Request.QueryString["Disable"])
            ? aCategoryLevel2BO.Sel_ByKeyCodeCategoryLevel2_ByIDLang(KeyCodeCategoryLevel2, IDLang)
            : aCategoryLevel2BO.Sel_ByKeyCodeCategoryLevel2_ByIDLang(KeyCodeCategoryLevel2, IDLang, Disable);
            List<vw_CategoryLevel2ViewAll> ObjOrder = new List<vw_CategoryLevel2ViewAll>();

            switch (Order)
            {
                case "Code":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.Code).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.Code).ToList();
                    }
                    break;

                case "CategoryNameLevel2":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.CategoryNameLevel2).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CategoryNameLevel2).ToList();
                    }
                    break;

                case "CountCategoryLeve1":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.CountCategoryLeve1).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CountCategoryLeve1).ToList();
                    }
                    break;
                case "CountCategoryLeve1Disable":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.CountCategoryLeve1Disable).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CountCategoryLeve1Disable).ToList();
                    }
                    break;
                case "CountCategoryLeve1Enable":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.CountCategoryLeve1Enable).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CountCategoryLeve1Enable).ToList();
                    }
                    break;
                case "Status":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.Status).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.Status).ToList();
                    }
                    break;
                case "ID":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.ID).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.ID).ToList();
                    }
                    break;
                case "ViewCount":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.ViewCount).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.ViewCount).ToList();
                    }
                    break;
                case "Type":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.Type).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.Type).ToList();
                    }
                    break;
                case "Tag":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.Tag).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.Tag).ToList();
                    }
                    break;
                case "Note":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.Note).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.Note).ToList();
                    }
                    break;

                default:
                    ObjOrder = obj;
                    break;
            }

            for (int i = 0; i < ObjOrder.Count; i++)
            {
                if ((TitleLenght > -1) & (ObjOrder[i].CategoryNameLevel2.Length > TitleLenght))
                {
                    ObjOrder[i].CategoryNameLevel2 = ObjOrder[i].CategoryNameLevel2.Substring(0, TitleLenght - 1);
                }
                if ((IntroLenght > -1) & (ObjOrder[i].Info.Length > IntroLenght))
                {
                    ObjOrder[i].Info = ObjOrder[i].Info.Substring(0, IntroLenght - 1);
                }
            }
            List<vw_CategoryLevel2ViewAll> ObjOrderLimit = new List<vw_CategoryLevel2ViewAll>();
            if ((Limit > -1) & (ObjOrder.Count > Limit))
            {
                ObjOrderLimit = ObjOrder.GetRange(0, Limit).ToList();
                _converter.DateTimeFormat = "dd/MM/yyyy";
                jSonString = JsonConvert.SerializeObject(ObjOrderLimit, _converter);
            }
            else
            {
                if (ObjOrder != null)
                {
                    _converter.DateTimeFormat = "dd/MM/yyyy";
                    jSonString = JsonConvert.SerializeObject(ObjOrder, _converter);
                }
            }
            jSonString = "{\"data\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }


        public void Sel_ListCategoryLevel2_ByType_ByIDLang(HttpContext context)
        {
            String jSonString = "";

            int Type = context.Request.QueryString["Type"] != null && context.Request.QueryString["Type"] != "undefined" ? int.Parse(context.Request.QueryString["Type"]) : -1;
            int IDLang = string.IsNullOrEmpty(context.Request.QueryString["IDLang"]) == false && context.Request.QueryString["IDLang"] != "undefined" ? int.Parse(context.Request.QueryString["IDLang"]) : 1;
            int IntroLenght = context.Request.QueryString["IntroLenght"] != null && context.Request.QueryString["IntroLenght"] != "undefined" ? int.Parse(context.Request.QueryString["IntroLenght"]) : -1;
            int TitleLenght = context.Request.QueryString["TitleLenght"] != null && context.Request.QueryString["TitleLenght"] != "undefined" ? int.Parse(context.Request.QueryString["TitleLenght"]) : -1;
            int Limit = context.Request.QueryString["Limit"] != null && context.Request.QueryString["Limit"] != "undefined" ? int.Parse(context.Request.QueryString["Limit"]) : -1;
            string Order = context.Request.QueryString["Order"] != null && context.Request.QueryString["Order"] != "undefined" ? context.Request.QueryString["Order"] : "-1";
            string IsDesc = context.Request.QueryString["IsDesc"] != null && context.Request.QueryString["IsDesc"] != "undefined" ? context.Request.QueryString["IsDesc"] : "-1";

            CategoryLevel2BO aCategoryLevel2BO = new CategoryLevel2BO();
            List<CategoryLevel2> obj = aCategoryLevel2BO.Sel_ByType_ByIDLang(Type, IDLang);
            List<CategoryLevel2> ObjOrder = new List<CategoryLevel2>();

            switch (Order)
            {
                case "Code":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.Code).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.Code).ToList();
                    }
                    break;
                case "CategoryNameLevel2":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.CategoryNameLevel2).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CategoryNameLevel2).ToList();
                    }
                    break;


                case "ViewCount":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.ViewCount).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.ViewCount).ToList();
                    }
                    break;

                default:
                    ObjOrder = obj;
                    break;
            }
            for (int i = 0; i < ObjOrder.Count; i++)
            {
                if ((TitleLenght > -1) & (ObjOrder[i].CategoryNameLevel2.Length > TitleLenght))
                {
                    ObjOrder[i].CategoryNameLevel2 = ObjOrder[i].CategoryNameLevel2.Substring(0, TitleLenght - 1);
                }


            }
            List<CategoryLevel2> ObjOrderLimit = new List<CategoryLevel2>();
            if ((Limit > -1) & (ObjOrder.Count > Limit))
            {
                ObjOrderLimit = ObjOrder.GetRange(0, Limit).ToList();
                _converter.DateTimeFormat = "dd/MM/yyyy";
                jSonString = JsonConvert.SerializeObject(ObjOrderLimit, _converter);
            }
            else
            {
                if (ObjOrder != null)
                {
                    _converter.DateTimeFormat = "dd/MM/yyyy";
                    jSonString = JsonConvert.SerializeObject(ObjOrder, _converter);
                }
            }
            jSonString = "{\"CategoryLevel2\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }
        //===============================================================================
        public void Sel_ByCodeCategoryLevel1_ByIDLang(HttpContext context)
        {

            String jSonString = "";
            string CodeCategoryLevel1 = context.Request.QueryString["CodeCategoryLevel1"];
            bool Disable = !String.IsNullOrEmpty(context.Request.QueryString["Disable"])
               ? Convert.ToBoolean(context.Request.QueryString["Disable"])
               : false;
            int IDLang = 1;
            CategoryLevel2BO aCategoryLevel2BO = new CategoryLevel2BO();
            List<CategoryLevel2> lstCategoryLevel2 = String.IsNullOrEmpty(context.Request.QueryString["Disable"])
            ? aCategoryLevel2BO.Sel_ByCodeCategoryLevel1_ByIDLang(CodeCategoryLevel1, 1)
            : aCategoryLevel2BO.Sel_ByCodeCategoryLevel1_ByIDLang(CodeCategoryLevel1, IDLang, Disable);
            if (lstCategoryLevel2 != null)
            {
                _converter.DateTimeFormat = "dd/MM/yyyy";

                jSonString = JsonConvert.SerializeObject(lstCategoryLevel2, _converter);
            }
            jSonString = "{\"CategoryLevel2\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }
        public void Sel_Ext_ByCodeCategoryLevel1(HttpContext context)
        {
            String jSonString = "";
            string CodeCategoryLevel1 = context.Request.QueryString["CodeCategoryLevel1"];

            bool Disable = !String.IsNullOrEmpty(context.Request.QueryString["Disable"])
             ? Convert.ToBoolean(context.Request.QueryString["Disable"])
             : false;

            CategoryLevel2BO aCategoryLevel2BO = new CategoryLevel2BO();
            List<vw_CategoryLevel2ViewAll> lstCategoryLevel2 = String.IsNullOrEmpty(context.Request.QueryString["Disable"])
               ? aCategoryLevel2BO.Sel_Ext_ByCodeCategoryLevel1(CodeCategoryLevel1)
               : aCategoryLevel2BO.Sel_Ext_ByCodeCategoryLevel1(CodeCategoryLevel1, Disable);
            if (lstCategoryLevel2 != null)
            {
                _converter.DateTimeFormat = "dd/MM/yyyy";

                jSonString = JsonConvert.SerializeObject(lstCategoryLevel2, _converter);
            }
            jSonString = "{\"CategoryLevel2\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }
        //======================================================================
        public void Sel_Ext_ByCodeCategoryLevel1_ByIDLang(HttpContext context)
        {
            String jSonString = "";
            string CodeCategoryLevel1 = context.Request.QueryString["CodeCategoryLevel1"];
            int IDLang = string.IsNullOrEmpty(context.Request.QueryString["IDLang"]) == false && context.Request.QueryString["IDLang"] != "undefined" ? int.Parse(context.Request.QueryString["IDLang"]) : 1;


            bool Disable = !String.IsNullOrEmpty(context.Request.QueryString["Disable"])
             ? Convert.ToBoolean(context.Request.QueryString["Disable"])
             : false;

            CategoryLevel2BO aCategoryLevel2BO = new CategoryLevel2BO();
            List<vw_CategoryLevel2ViewAll> lstCategoryLevel2 = String.IsNullOrEmpty(context.Request.QueryString["Disable"])
               ? aCategoryLevel2BO.Sel_Ext_ByCodeCategoryLevel1_ByIDLang(CodeCategoryLevel1, IDLang)
               : aCategoryLevel2BO.Sel_Ext_ByCodeCategoryLevel1_ByIDLang(CodeCategoryLevel1, IDLang, Disable);
            if (lstCategoryLevel2 != null)
            {
                _converter.DateTimeFormat = "dd/MM/yyyy";

                jSonString = JsonConvert.SerializeObject(lstCategoryLevel2, _converter);
            }
            jSonString = "{\"CategoryLevel2\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }


        #endregion

        #region INSERT DATABASE
        public void Ins(HttpContext context, int NUM_LANG)
        {
            int ret = -1;
            String jSonString = "";
            try
            {
                CategoryLevel2BO aCategoryLevel2BO = new CategoryLevel2BO();
                CategoryLevel2 aCategoryLevel2 = new CategoryLevel2();

                aCategoryLevel2.Status = !String.IsNullOrEmpty(context.Request.Form["cbbStatus"]) ? Convert.ToInt32(context.Request.Form["cbbStatus"]) : 0;

                aCategoryLevel2.Disable = !String.IsNullOrEmpty(context.Request.Form["cbbDisable"]) ? Convert.ToBoolean(context.Request.Form["cbbDisable"]) : false;

                aCategoryLevel2.Type = !String.IsNullOrEmpty(context.Request.Form["cbbType"]) ? Convert.ToInt32(context.Request.Form["cbbType"]) : 0;
                aCategoryLevel2.IDAlbum = !String.IsNullOrEmpty(context.Request.Form["ddlAlbum"]) ? Convert.ToInt32(context.Request.Form["ddlAlbum"]) : 0;
                aCategoryLevel2.Image = !String.IsNullOrEmpty(context.Request.Form["txtImage"]) ? Convert.ToString(context.Request.Form["txtImage"]) : "";
                aCategoryLevel2.Image1 = !String.IsNullOrEmpty(context.Request.Form["txtImage_1"]) ? Convert.ToString(context.Request.Form["txtImage_1"]) : "";
                aCategoryLevel2.Image2 = !String.IsNullOrEmpty(context.Request.Form["txtImage_2"]) ? Convert.ToString(context.Request.Form["txtImage_2"]) : "";
                aCategoryLevel2.Image3 = !String.IsNullOrEmpty(context.Request.Form["txtImage_3"]) ? Convert.ToString(context.Request.Form["txtImage_3"]) : "";
                aCategoryLevel2.Tag = !String.IsNullOrEmpty(context.Request.Form["txtTag"]) ? Convert.ToString(context.Request.Form["txtTag"]) : "";


                aCategoryLevel2.ViewCount = !String.IsNullOrEmpty(context.Request.Form["txtViewCount"]) ? Convert.ToInt32(context.Request.Form["txtViewCount"]) : 0;


                long a = DateTime.Now.Ticks;
                TimeSpan Codespan = new TimeSpan(a);
                aCategoryLevel2.Code = Math.Floor(Codespan.TotalSeconds).ToString();

                for (int i = 1; i <= NUM_LANG; i++)
                {
                    aCategoryLevel2.IDLang = !String.IsNullOrEmpty(context.Request.Form["IDLang_" + i]) ? Convert.ToInt32(context.Request.Form["IDLang_" + i]) : 0;

                    aCategoryLevel2.Note = !String.IsNullOrEmpty(context.Request.Form["txtNote_Lang" + i]) ? Convert.ToString(context.Request.Form["txtNote_Lang" + i]) : "";
                    aCategoryLevel2.CategoryNameLevel2 = !String.IsNullOrEmpty(context.Request.Form["txtCategoryNameLevel2_Lang" + i]) ? Convert.ToString(context.Request.Form["txtCategoryNameLevel2_Lang" + i]) : "";
                    aCategoryLevel2.Info = !String.IsNullOrEmpty(context.Request.Form["txtInfo_Lang" + i]) ? Convert.ToString((context.Request.Form["txtInfo_Lang" + i])) : "";
                    aCategoryLevel2.Intro = !String.IsNullOrEmpty(context.Request.Form["txtIntro_Lang" + i]) ? Convert.ToString((context.Request.Form["txtIntro_Lang" + i])) : "";

                    ret = aCategoryLevel2BO.Ins(aCategoryLevel2);
                    if (ret == 0)
                    {
                        jSonString = "{\"status\":\"error|" + ret.ToString() + "\"}";
                        break;
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

        #endregion

        #region UPDATE DATABASE
        public void Upd_ByCode(HttpContext context, int NUM_LANG)
        {
            int ret = -1;
            String jSonString = "";
            try
            {
                if (NUM_LANG < 1)
                {
                    NUM_LANG = 1;
                }
                List<CategoryLevel2> aListCategoryLevel2 = new List<CategoryLevel2>();
                CategoryLevel2BO aCategoryLevel1BO = new CategoryLevel2BO();
                String Code = context.Request.Form["txtCode"];

                aListCategoryLevel2 = aCategoryLevel1BO.Sel_ByCode(Code);
                int LoopUpdate = 0;

                if (aListCategoryLevel2.Count <= NUM_LANG)
                {
                    LoopUpdate = aListCategoryLevel2.Count;
                    for (int i = 0; i < LoopUpdate; i++)
                    {

                        aListCategoryLevel2[i].ID = aListCategoryLevel2[i].ID;
                        aListCategoryLevel2[i].Code = aListCategoryLevel2[i].Code;
                        aListCategoryLevel2[i].IDLang = aListCategoryLevel2[i].IDLang;
                        aListCategoryLevel2[i].Type = !String.IsNullOrEmpty(context.Request.Form["cbbType"]) ? Convert.ToInt32(context.Request.Form["cbbType"]) : aListCategoryLevel2[i].Type;
                        aListCategoryLevel2[i].ViewCount = !String.IsNullOrEmpty(context.Request.Form["txtViewCount"]) ? Convert.ToInt64(context.Request.Form["txtViewCount"]) : 0;
                        aListCategoryLevel2[i].Status = !String.IsNullOrEmpty(context.Request.Form["cbbStatus"]) ? Convert.ToInt32(context.Request.Form["cbbStatus"]) : aListCategoryLevel2[i].Status;
                        aListCategoryLevel2[i].Disable = !String.IsNullOrEmpty(context.Request.Form["cbbDisable"]) ? Convert.ToBoolean(context.Request.Form["cbbDisable"]) : aListCategoryLevel2[i].Disable;
                        aListCategoryLevel2[i].Tag = !String.IsNullOrEmpty(context.Request.Form["txtTag"]) ? Convert.ToString(context.Request.Form["txtTag"]) : aListCategoryLevel2[i].Tag;
                        aListCategoryLevel2[i].IDAlbum = !String.IsNullOrEmpty(context.Request.Form["cbbIDAlbum"]) ? Convert.ToInt32(context.Request.Form["cbbIDAlbum"]) : aListCategoryLevel2[i].IDAlbum;
                        aListCategoryLevel2[i].Image = !String.IsNullOrEmpty(context.Request.Form["txtImage_1"]) ? Convert.ToString(context.Request.Form["txtImage_1"]) : "";
                        aListCategoryLevel2[i].Image1 = !String.IsNullOrEmpty(context.Request.Form["txtImage_2"]) ? Convert.ToString(context.Request.Form["txtImage_2"]) : "";
                        aListCategoryLevel2[i].Image2 = !String.IsNullOrEmpty(context.Request.Form["txtImage_3"]) ? Convert.ToString(context.Request.Form["txtImage_3"]) : "";
                        aListCategoryLevel2[i].Image3 = !String.IsNullOrEmpty(context.Request.Form["txtImage_4"]) ? Convert.ToString(context.Request.Form["txtImage_4"]) : "";
                        aListCategoryLevel2[i].CategoryNameLevel2 = !String.IsNullOrEmpty(context.Request.Form["txtCategoryNameLevel2_Lang" + (i + 1)]) ? Convert.ToString(context.Request.Form["txtCategoryNameLevel2_Lang" + (i + 1)]) : aListCategoryLevel2[i].CategoryNameLevel2;
                        aListCategoryLevel2[i].Note = !String.IsNullOrEmpty(context.Request.Form["txtNote_Lang" + (i + 1)]) ? Convert.ToString(context.Request.Form["txtNote_Lang" + (i + 1)]) : aListCategoryLevel2[i].Note;
                        aListCategoryLevel2[i].Intro = !String.IsNullOrEmpty(context.Request.Form["txtIntro_Lang" + (i + 1)]) ? Convert.ToString(context.Request.Form["txtIntro_Lang" + (i + 1)]) : aListCategoryLevel2[i].Intro;
                        aListCategoryLevel2[i].Info = !String.IsNullOrEmpty(context.Request.Form["txtInfo_Lang" + (i + 1)]) ? Convert.ToString(context.Request.Form["txtInfo_Lang" + (i + 1)]) : aListCategoryLevel2[i].Info;

                        ret = aCategoryLevel1BO.Upd(aListCategoryLevel2);
                        if (ret == 0)
                        {
                            jSonString = "{\"status\":\"error|" + ret.ToString() + "\"}";
                            break;
                        }
                    }
                    if (ret != 0)
                    { jSonString = "{\"status\": \"success\"}"; }
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
        public void Upd_Disable(HttpContext context)
        {
            int ret = -1;
            String jSonString = "";
            try
            {
                CategoryLevel2BO aCategoryLevel2BO = new CategoryLevel2BO();
                List<CategoryLevel2> listCategoryLevel2 = new List<CategoryLevel2>();
                string Code = aCategoryLevel2BO.Sel_ByID(int.Parse(context.Request.QueryString["IDCategoryLevel2"])).Code;

                for (int i = 0; i < listCategoryLevel2.Count; i++)
                {
                    listCategoryLevel2[i].Disable = true;
                    ret = aCategoryLevel2BO.Upd(listCategoryLevel2[i]);
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

        public void Upd_Status_ByID(HttpContext context)
        {
            int ret = -1;
            String jSonString = "";
            try
            {
                CategoryLevel2BO aCategoryLevel2BO = new CategoryLevel2BO();
                int ID = int.Parse(context.Request.QueryString["IDCategoryLevel2"]);
                int Status = int.Parse(context.Request.QueryString["Status"]);
                ret = aCategoryLevel2BO.Upd_Status_ByID(Status, ID);
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

        public void Upd_Type_ByID(HttpContext context)
        {
            int ret = -1;
            String jSonString = "";
            try
            {
                CategoryLevel2BO aCategoryLevel2BO = new CategoryLevel2BO();
                int ID = int.Parse(context.Request.QueryString["IDCategoryLevel2"]);
                int Type = int.Parse(context.Request.QueryString["Type"]);
                ret = aCategoryLevel2BO.Upd_Status_ByID(Type, ID);
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
        public void Upd_Disable_ByID(HttpContext context)
        {
            int ret = -1;
            String jSonString = "";
            try
            {
                CategoryLevel2BO aCategoryLevel2BO = new CategoryLevel2BO();
                int ID = int.Parse(context.Request.QueryString["IDCategoryLevel2"]);
                bool Disable = Convert.ToBoolean(context.Request.QueryString["Disable"]);
                ret = aCategoryLevel2BO.Upd_Disable_ByID(Disable, ID);
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
        public void Upd_Status_ByCode(HttpContext context)
        {
            int ret = -1;
            String jSonString = "";
            try
            {
                CategoryLevel2BO aCategoryLevel2BO = new CategoryLevel2BO();
                List<CategoryLevel2> listCategoryLevel2 = new List<CategoryLevel2>();
                string Code = context.Request.QueryString["Code"];
                int Status = Convert.ToInt32(context.Request.QueryString["Status"]);

                ret = aCategoryLevel2BO.Upd_Status_ByCode(Status, Code);
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
        public void Upd_Type_ByCode(HttpContext context)
        {
            int ret = -1;
            String jSonString = "";
            try
            {
                CategoryLevel2BO aCategoryLevel2BO = new CategoryLevel2BO();
                List<CategoryLevel2> listCategoryLevel2 = new List<CategoryLevel2>();
                string Code = context.Request.QueryString["Code"];
                int Type = Convert.ToInt32(context.Request.QueryString["Type"]);

                ret = aCategoryLevel2BO.Upd_Type_ByCode(Type, Code);
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
        public void Upd_Disable_ByCode(HttpContext context)
        {
            int ret = -1;
            String jSonString = "";
            try
            {
                CategoryLevel2BO aCategoryLevel2BO = new CategoryLevel2BO();
                List<CategoryLevel2> listCategoryLevel2 = new List<CategoryLevel2>();
                string Code = context.Request.QueryString["Code"];
                bool Disable = Convert.ToBoolean(context.Request.QueryString["Disable"]);

                ret = aCategoryLevel2BO.Upd_Disable_ByCode(Disable, Code);
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
        public void Upd_Status_ByCode_ByIDLang(HttpContext context)
        {
            int ret = -1;
            String jSonString = "";
            try
            {
                CategoryLevel2BO aCategoryLevel2BO = new CategoryLevel2BO();
                string Code = context.Request.QueryString["Code"];
                int Status = int.Parse(context.Request.QueryString["Status"]);
                int IDLang = !string.IsNullOrEmpty(context.Request.QueryString["IDLang"].ToString()) ? int.Parse(context.Request.QueryString["IDLang"]) : 1;
                ret = aCategoryLevel2BO.Upd_Status_ByCode_ByIDLang(Status, Code, IDLang);
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
        public void Upd_Type_ByCode_ByIDLang(HttpContext context)
        {
            int ret = -1;
            String jSonString = "";
            try
            {
                CategoryLevel2BO aCategoryLevel2BO = new CategoryLevel2BO();
                string Code = context.Request.QueryString["Code"];
                int Type = int.Parse(context.Request.QueryString["Type"]);
                int IDLang = !string.IsNullOrEmpty(context.Request.QueryString["IDLang"].ToString()) ? int.Parse(context.Request.QueryString["IDLang"]) : 1;
                ret = aCategoryLevel2BO.Upd_Type_ByCode_ByIDLang(Type, Code, IDLang);
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
        public void Upd_Disable_ByCode_ByIDLang(HttpContext context)
        {
            int ret = -1;
            String jSonString = "";
            try
            {
                CategoryLevel2BO aCategoryLevel2BO = new CategoryLevel2BO();
                string Code = context.Request.QueryString["Code"];
                bool Disable = Convert.ToBoolean(context.Request.QueryString["Disable"]);
                int IDLang = !string.IsNullOrEmpty(context.Request.QueryString["IDLang"].ToString()) ? int.Parse(context.Request.QueryString["IDLang"]) : 1;
                ret = aCategoryLevel2BO.Upd_Disable_ByCode_ByIDLang(Disable, Code, IDLang);
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
        #endregion

        #region DELETE DATABASE
        public void Del_ByCode(HttpContext context)
        {
            CategoryLevel2BO aCategoryLevel2BO = new CategoryLevel2BO();
            String jSonString = "";
            string Code = context.Request.QueryString["Code"].ToString();
            int ret = aCategoryLevel2BO.Del_ByCode(Code);


            if (ret > 0)
            { jSonString = "{\"status\": \"success\"}"; }

            if (ret <= 0)
            { jSonString = "{\"status\":\"error\" ,\"message\":\"" + ret.ToString() + "\"}"; }


            context.Response.Write(jSonString);
        }
        public void Del_ByID(HttpContext context)
        {

            CategoryLevel2BO aCategoryLevel2BO = new CategoryLevel2BO();
            String jSonString = "";
            int ID = Convert.ToInt32(context.Request.QueryString["IDCategoryLevel2"].ToString());
            int ret = aCategoryLevel2BO.Del_ByID(ID);


            if (ret > 0)
            { jSonString = "{\"status\": \"success\"}"; }

            if (ret <= 0)
            { jSonString = "{\"status\":\"error\" ,\"message\":\"" + ret.ToString() + "\"}"; }


            context.Response.Write(jSonString);
        }

        public void Del_ByCode_ByIDLang(HttpContext context)
        {
            CategoryLevel2BO aCategoryLevel2BO = new CategoryLevel2BO();
            String jSonString = "";
            string Code = context.Request.QueryString["Code"].ToString();
            int IDLang = !string.IsNullOrEmpty(context.Request.QueryString["IDLang"].ToString()) ? int.Parse(context.Request.QueryString["IDLang"]) : 1;
            int ret = aCategoryLevel2BO.Del_ByCode_ByIDLang(Code, IDLang);


            if (ret > 0)
            { jSonString = "{\"status\": \"success\"}"; }

            if (ret <= 0)
            { jSonString = "{\"status\":\"error\" ,\"message\":\"" + ret.ToString() + "\"}"; }


            context.Response.Write(jSonString);
        }

        //public void Del_ByListCode(HttpContext context) 
        //{
        //    DatabaseDA data=new DatabaseDA();
        //    CategoryLevel2BO aCategoryLevel2BO = new CategoryLevel2BO();
        //    List<CategoryLevel2>cate2= (from  p  in data.CategoryLevel2  select p).ToList();
        //    List<string> Code = context.Request.Params.
        //    String jSonString = "";


        //    int ret = aCategoryLevel2BO.Del_ByListCode(Code);


        //    if (ret > 0)
        //    { jSonString = "{\"status\": \"success\"}"; }

        //    if (ret <= 0)
        //    { jSonString = "{\"status\":\"error\" ,\"message\":\"" + ret.ToString() + "\"}"; }


        //    context.Response.Write(jSonString);

        //}
        #endregion
        private List<CategoryLevel2> ConvertList(List<CategoryLevel2> ListCategoryLevel2, int InfoLenght, int IntroLenght, int Limit, string Order, bool IsDesc)
        {
            if ((Limit == null) || (Limit <= 0))
            {
                Limit = ListCategoryLevel2.Count;
            }
            if (Limit > ListCategoryLevel2.Count)
            {
                Limit = ListCategoryLevel2.Count;
            }

            if ((InfoLenght == null) || (InfoLenght <= 0))
            {
                InfoLenght = 1000;
            }
            if ((IntroLenght == null) || (IntroLenght <= 0))
            {
                IntroLenght = 1000;
            }

            //=========================

            switch (Order)
            {
                case "Code":
                    if (IsDesc == false)
                    {
                        ListCategoryLevel2 = ListCategoryLevel2.OrderBy(a => a.Code).ToList();
                    }
                    else
                    {
                        ListCategoryLevel2 = ListCategoryLevel2.OrderByDescending(a => a.Code).ToList();
                    }
                    break;
                case "CategoryNameLevel2":
                    if (IsDesc == false)
                    {
                        ListCategoryLevel2 = ListCategoryLevel2.OrderBy(a => a.CategoryNameLevel2).ToList();
                    }
                    else
                    {
                        ListCategoryLevel2 = ListCategoryLevel2.OrderByDescending(a => a.CategoryNameLevel2).ToList();
                    }
                    break;
                case "Status":
                    if (IsDesc == false)
                    {
                        ListCategoryLevel2 = ListCategoryLevel2.OrderBy(a => a.Status).ToList();
                    }
                    else
                    {
                        ListCategoryLevel2 = ListCategoryLevel2.OrderByDescending(a => a.Status).ToList();
                    }
                    break;
                case "Disable":
                    if (IsDesc == false)
                    {
                        ListCategoryLevel2 = ListCategoryLevel2.OrderBy(a => a.Disable).ToList();
                    }
                    else
                    {
                        ListCategoryLevel2 = ListCategoryLevel2.OrderByDescending(a => a.Disable).ToList();
                    }
                    break;
                //==============================================================================
                case "IDLang":
                    if (IsDesc == false)
                    {
                        ListCategoryLevel2 = ListCategoryLevel2.OrderBy(a => a.IDLang).ToList();
                    }
                    else
                    {
                        ListCategoryLevel2 = ListCategoryLevel2.OrderByDescending(a => a.IDLang).ToList();
                    }
                    break;
                //==============================================================================
                case "ID":
                    if (IsDesc == false)
                    {
                        ListCategoryLevel2 = ListCategoryLevel2.OrderBy(a => a.ID).ToList();
                    }
                    else
                    {
                        ListCategoryLevel2 = ListCategoryLevel2.OrderByDescending(a => a.ID).ToList();
                    }
                    break;
                //==============================================================================
                case "Type":
                    if (IsDesc == false)
                    {
                        ListCategoryLevel2 = ListCategoryLevel2.OrderBy(a => a.Type).ToList();
                    }
                    else
                    {
                        ListCategoryLevel2 = ListCategoryLevel2.OrderByDescending(a => a.Type).ToList();
                    }
                    break;
                //==============================================================================
                case "Note":
                    if (IsDesc == false)
                    {
                        ListCategoryLevel2 = ListCategoryLevel2.OrderBy(a => a.Note).ToList();
                    }
                    else
                    {
                        ListCategoryLevel2 = ListCategoryLevel2.OrderByDescending(a => a.Note).ToList();
                    }
                    break;
                //==============================================================================
                case "Image":
                    if (IsDesc == false)
                    {
                        ListCategoryLevel2 = ListCategoryLevel2.OrderBy(a => a.Image).ToList();
                    }
                    else
                    {
                        ListCategoryLevel2 = ListCategoryLevel2.OrderByDescending(a => a.Image).ToList();
                    }
                    break;
                //==============================================================================
                case "Image1":
                    if (IsDesc == false)
                    {
                        ListCategoryLevel2 = ListCategoryLevel2.OrderBy(a => a.Image1).ToList();
                    }
                    else
                    {
                        ListCategoryLevel2 = ListCategoryLevel2.OrderByDescending(a => a.Image1).ToList();
                    }
                    break;
                //==============================================================================
                case "Image2":
                    if (IsDesc == false)
                    {
                        ListCategoryLevel2 = ListCategoryLevel2.OrderBy(a => a.Image2).ToList();
                    }
                    else
                    {
                        ListCategoryLevel2 = ListCategoryLevel2.OrderByDescending(a => a.Image2).ToList();
                    }
                    break;
                //==============================================================================
                case "Image3":
                    if (IsDesc == false)
                    {
                        ListCategoryLevel2 = ListCategoryLevel2.OrderBy(a => a.Image3).ToList();
                    }
                    else
                    {
                        ListCategoryLevel2 = ListCategoryLevel2.OrderByDescending(a => a.Image3).ToList();
                    }
                    break;
                //==============================================================================
                case "Tag":
                    if (IsDesc == false)
                    {
                        ListCategoryLevel2 = ListCategoryLevel2.OrderBy(a => a.Tag).ToList();
                    }
                    else
                    {
                        ListCategoryLevel2 = ListCategoryLevel2.OrderByDescending(a => a.Tag).ToList();
                    }
                    break;
                //==============================================================================
                case "Info":
                    if (IsDesc == false)
                    {
                        ListCategoryLevel2 = ListCategoryLevel2.OrderBy(a => a.Info).ToList();
                    }
                    else
                    {
                        ListCategoryLevel2 = ListCategoryLevel2.OrderByDescending(a => a.Info).ToList();
                    }
                    break;
                //==============================================================================
                case "Intro":
                    if (IsDesc == false)
                    {
                        ListCategoryLevel2 = ListCategoryLevel2.OrderBy(a => a.Intro).ToList();
                    }
                    else
                    {
                        ListCategoryLevel2 = ListCategoryLevel2.OrderByDescending(a => a.Intro).ToList();
                    }
                    break;

                //==============================================================================
                case "IDAlbum":
                    if (IsDesc == false)
                    {
                        ListCategoryLevel2 = ListCategoryLevel2.OrderBy(a => a.IDAlbum).ToList();
                    }
                    else
                    {
                        ListCategoryLevel2 = ListCategoryLevel2.OrderByDescending(a => a.IDAlbum).ToList();
                    }
                    break;

                //==============================================================================
                case "ViewCount":
                    if (IsDesc == false)
                    {
                        ListCategoryLevel2 = ListCategoryLevel2.OrderBy(a => a.ViewCount).ToList();
                    }
                    else
                    {
                        ListCategoryLevel2 = ListCategoryLevel2.OrderByDescending(a => a.ViewCount).ToList();
                    }
                    break;
                //==============================================================================
                default:

                    break;
            }
            //###############################################################################
            int InfoLenght_Tempt = InfoLenght;
            int IntroLenght_Tempt = IntroLenght;

            for (int i = 0; i < Limit; i++)
            {
                if (ListCategoryLevel2[i].Info.Length < InfoLenght)
                {
                    InfoLenght_Tempt = ListCategoryLevel2[i].Info.Length;
                }
                if (ListCategoryLevel2[i].Intro.Length < IntroLenght_Tempt)
                {
                    IntroLenght_Tempt = ListCategoryLevel2[i].Intro.Length;
                }

                //if (TitleLenght == 0) { TitleLenght = 1; }
                //if (IntroLenght == 0) { IntroLenght = 1; }

                ListCategoryLevel2[i].Info = ListCategoryLevel2[i].Info.Substring(0, InfoLenght_Tempt);
                ListCategoryLevel2[i].Intro = ListCategoryLevel2[i].Intro.Substring(0, IntroLenght_Tempt);

                InfoLenght_Tempt = InfoLenght;
                IntroLenght_Tempt = IntroLenght;
            }



            ListCategoryLevel2 = ListCategoryLevel2.GetRange(0, Limit).ToList();
            return ListCategoryLevel2;
            //=========================
        }
        //=================================================================================================


    }
}
