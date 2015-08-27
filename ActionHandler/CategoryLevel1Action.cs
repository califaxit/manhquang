using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;
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
    public class CategoryLevel1Action : IAction
    {


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

                    case "Sel_ByCode_ByIDLang":
                        Sel_ByCode_ByIDLang(context);
                        break;
                    case "Sel_ByID":
                        this.Sel_ByID(context);
                        break;
                    case "Sel_ByIDLang":
                        this.Sel_ByIDLang(context);
                        break;
                    case "Sel_Ext_ByIDLang":
                        this.Sel_Ext_ByIDLang(context);
                        break;

                    case "Sel_ByType_ByIDLang":
                        Sel_ByType_ByIDLang(context);
                        break;
                    case "Sel_ByStatus_ByIDLang":
                        Sel_ByStatus_ByIDLang(context);
                        break;

                    case "Sel_ByType_ByStatus_ByIDLang":
                        Sel_ByType_ByStatus_ByIDLang(context);
                        break;

                    case "Sel_ByIDAlbum":
                        Sel_ByIDAlbum(context);
                        break;

                    case "Sel_ByIDAlbum_ByIDLang":
                        Sel_ByIDAlbum_ByIDLang(context);
                        break;
                    //=====================================================
                    case "Sel_Ext_ByCodeCategoryLevel2_ByIDLang":
                        Sel_Ext_ByCodeCategoryLevel2_ByIDLang(context);
                        break;
                    case "Sel_Ext_ByCode":
                        this.Sel_Ext_ByCode(context);
                        break;
                    case "Sel_ByKeyCodeCategoryLevel2_ByIDLang":
                        this.Sel_ByKeyCodeCategoryLevel2_ByIDLang(context);
                        break;
                    case "Sel_ByKeyCodeCategoryLevel1_ByIDLang":
                        this.Sel_ByKeyCodeCategoryLevel1_ByIDLang(context);
                        break;
                    //=====================================================
                    case "Ins":
                        Ins(context, CORE_Language.sys_NUM_LANG);
                        break;
                    //=====================================================
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
                    //=======================================

                    case "Del_ByCode_ByIDLang":
                        Del_ByCode_ByIDLang(context);
                        break;
                    case "Del_ByCode":
                        this.Del_ByCode(context);
                        break;
                    case "Del_ByID":
                        Del_ByID(context);
                        break;
                    default:
                        context.Response.Write("Can't find action");
                        break;
                }
            }
        }



        private IsoDateTimeConverter _converter = new IsoDateTimeConverter();

        #region SELECT DATABASE
        public void Sel_ByID(HttpContext context)
        {

            String jSonString = "";
            int IDCategoryLevel1 = int.Parse(context.Request.QueryString["IDCategoryLevel1"]);
            bool Disable = !String.IsNullOrEmpty(context.Request.QueryString["Disable"])
             ? Convert.ToBoolean(context.Request.QueryString["Disable"])
             : false;
            CategoryLevel1BO aCategoryLevel1BO = new CategoryLevel1BO();
            CategoryLevel1 obj = String.IsNullOrEmpty(context.Request.QueryString["Disable"]) ?
            aCategoryLevel1BO.Sel_ByID(IDCategoryLevel1) :
            aCategoryLevel1BO.Sel_ByID(IDCategoryLevel1, Disable);

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
            bool Disable = !String.IsNullOrEmpty(context.Request.QueryString["Disable"])
              ? Convert.ToBoolean(context.Request.QueryString["Disable"])
              : false;

            CategoryLevel1BO aCategoryLevel1BO = new CategoryLevel1BO();
            List<CategoryLevel1> obj = String.IsNullOrEmpty(context.Request.QueryString["Disable"]) ?
                aCategoryLevel1BO.Sel_ByCode(Code) : aCategoryLevel1BO.Sel_ByCode(Code, Disable);
            if (obj != null)
            {
                _converter.DateTimeFormat = "dd/MM/yyyy";

                jSonString = JsonConvert.SerializeObject(obj, _converter);
            }
            jSonString = "{\"data\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }


        public void Sel_ByType_ByIDLang(HttpContext context)
        {
            String jSonString = "";
            int Type = Convert.ToInt32(context.Request.QueryString["Type"]);
            int IDLang = !string.IsNullOrEmpty(context.Request.QueryString["IDLang"].ToString()) ? int.Parse(context.Request.QueryString["IDLang"]) : 1;

            bool Disable = !String.IsNullOrEmpty(context.Request.QueryString["Disable"])
             ? Convert.ToBoolean(context.Request.QueryString["Disable"])
             : false;


            CategoryLevel1BO aCategoryLevel1BO = new CategoryLevel1BO();
            List<CategoryLevel1> obj = String.IsNullOrEmpty(context.Request.QueryString["Disable"]) ?
            aCategoryLevel1BO.Sel_ByType_ByIDLang(Type, IDLang) : aCategoryLevel1BO.Sel_ByType_ByIDLang(Type, IDLang, Disable);

            if (obj != null)
            {
                _converter.DateTimeFormat = "dd/MM/yyyy";

                jSonString = JsonConvert.SerializeObject(obj, _converter);
            }
            jSonString = "{\"data\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }


        public void Sel_ByStatus_ByIDLang(HttpContext context)
        {
            String jSonString = "";
            int Status = Convert.ToInt32(context.Request.QueryString["Status"]);
            bool Disable = !String.IsNullOrEmpty(context.Request.QueryString["Disable"])
          ? Convert.ToBoolean(context.Request.QueryString["Disable"])
          : false;

            int IDLang = !string.IsNullOrEmpty(context.Request.QueryString["IDLang"].ToString()) ? int.Parse(context.Request.QueryString["IDLang"]) : 1;
            CategoryLevel1BO aCategoryLevel1BO = new CategoryLevel1BO();
            List<CategoryLevel1> obj = String.IsNullOrEmpty(context.Request.QueryString["Disable"]) ?
                aCategoryLevel1BO.Sel_ByStatus_ByIDLang(Status, IDLang) : aCategoryLevel1BO.Sel_ByStatus_ByIDLang(Status, IDLang, Disable);

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

            int IDLang = !string.IsNullOrEmpty(context.Request.QueryString["IDLang"].ToString()) ? int.Parse(context.Request.QueryString["IDLang"]) : 1;
            CategoryLevel1BO aCategoryLevel1BO = new CategoryLevel1BO();
            CategoryLevel1 obj = String.IsNullOrEmpty(context.Request.QueryString["Disable"]) ? aCategoryLevel1BO.Sel_ByCode_ByIDLang(Code, IDLang) : aCategoryLevel1BO.Sel_ByCode_ByIDLang(Code, IDLang, Disable);

            if (obj != null)
            {
                _converter.DateTimeFormat = "dd/MM/yyyy";

                jSonString = JsonConvert.SerializeObject(obj, _converter);
            }
            jSonString = "{\"data\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }


        //===============================================================
        public void Sel_ByType_ByStatus_ByIDLang(HttpContext context)
        {
            String jSonString = "";
            int Type = Convert.ToInt32(context.Request.QueryString["Code"]);
            int Status = Convert.ToInt32(context.Request.QueryString["Status"]);

            bool Disable = !String.IsNullOrEmpty(context.Request.QueryString["Disable"])
            ? Convert.ToBoolean(context.Request.QueryString["Disable"])
            : false;
            int IDLang = !string.IsNullOrEmpty(context.Request.QueryString["IDLang"].ToString()) ? int.Parse(context.Request.QueryString["IDLang"]) : 1;

            CategoryLevel1BO aCategoryLevel1BO = new CategoryLevel1BO();
            List<CategoryLevel1> obj = String.IsNullOrEmpty(context.Request.QueryString["Disable"]) ?

                aCategoryLevel1BO.Sel_ByType_ByStatus_ByIDLang(Type, Status, IDLang) : aCategoryLevel1BO.Sel_ByType_ByStatus_ByIDLang(Type, Status, IDLang, Disable);
            if (obj != null)
            {
                _converter.DateTimeFormat = "dd/MM/yyyy";

                jSonString = JsonConvert.SerializeObject(obj, _converter);
            }
            jSonString = "{\"data\":" + jSonString + "}";
            context.Response.Write(jSonString);

        }
        //==========================================================


        public void Sel_ByIDLang(HttpContext context)
        {

            String jSonString = "";
            CategoryLevel1BO aCategoryLevel1BO = new CategoryLevel1BO();
            bool Disable =!String.IsNullOrEmpty(context.Request.QueryString["Disable"])?Convert.ToBoolean(context.Request.QueryString["Disable"]):false;
            int IDLang = !string.IsNullOrEmpty(context.Request.QueryString["IDLang"].ToString()) ? int.Parse(context.Request.QueryString["IDLang"]) : 1;

            List<CategoryLevel1> obj = String.IsNullOrEmpty(context.Request.QueryString["Disable"]) ?
            aCategoryLevel1BO.Sel_ByIDLang(IDLang).ToList() : aCategoryLevel1BO.Sel_ByIDLang(IDLang, Disable).ToList();

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
            CategoryLevel1BO aCategoryLevel1BO = new CategoryLevel1BO();

            int IDLang = !string.IsNullOrEmpty(context.Request.QueryString["IDLang"].ToString()) ? int.Parse(context.Request.QueryString["IDLang"]) : 1;

            bool Disable = !String.IsNullOrEmpty(context.Request.QueryString["Disable"]) ? Convert.ToBoolean(context.Request.QueryString["Disable"]) : false;

            List<vw_CategoryLevel1ViewAll> obj = String.IsNullOrEmpty(context.Request.QueryString["Disable"]) ?
                aCategoryLevel1BO.Sel_Ext_ByIDLang(IDLang).ToList() : aCategoryLevel1BO.Sel_Ext_ByIDLang(IDLang, Disable);


            if (obj != null)
            {
                _converter.DateTimeFormat = "dd/MM/yyyy";

                jSonString = JsonConvert.SerializeObject(obj, _converter);
            }
            jSonString = "{\"data\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }

        public void Sel_Ext_ByCodeCategoryLevel2_ByIDLang(HttpContext context)   // Load ra danh sách các CategoryLevel1 bằng CodeCategpryLevel2 va IDLang
        {

            String jSonString = "";
            bool Disable = !String.IsNullOrEmpty(context.Request.QueryString["Disable"])
               ? Convert.ToBoolean(context.Request.QueryString["Disable"])
               : false;
            string CodeCategoryLevel2 = context.Request.QueryString["CodeCategoryLevel2"] != null && context.Request.QueryString["CodeCategoryLevel2"] != "undefined" ? context.Request.QueryString["CodeCategoryLevel2"] : "-1";
            int TitleLenght = context.Request.QueryString["TitleLenght"] != null && context.Request.QueryString["TitleLenght"] != "undefined" ? int.Parse(context.Request.QueryString["TitleLenght"]) : 100;
            int Limit = context.Request.QueryString["Limit"] != null && context.Request.QueryString["Limit"] != "undefined" ? int.Parse(context.Request.QueryString["Limit"]) : 100;
            string Order = context.Request.QueryString["Order"] != null && context.Request.QueryString["Order"] != "undefined" ? context.Request.QueryString["Order"] : "CategoryLevel1_CategoryNameLevel1";
            string IsDesc = context.Request.QueryString["IsDesc"] != null && context.Request.QueryString["IsDesc"] != "undefined" ? context.Request.QueryString["IsDesc"] : "true";

            int IDLang = !string.IsNullOrEmpty(context.Request.QueryString["IDLang"]) ? int.Parse(context.Request.QueryString["IDLang"]) : 1;

            CategoryLevel1BO aCategoryLevel1BO = new CategoryLevel1BO();
            List<vw_CategoryLevel1ViewAll> obj = String.IsNullOrEmpty(context.Request.QueryString["Disable"]) ?
                aCategoryLevel1BO.Sel_Ext_ByCodeCategoryLevel2_ByIDLang(CodeCategoryLevel2, IDLang).ToList() :
                aCategoryLevel1BO.Sel_Ext_ByCodeCategoryLevel2_ByIDLang(CodeCategoryLevel2, IDLang, Disable).ToList();
            List<vw_CategoryLevel1ViewAll> ObjOrder = new List<vw_CategoryLevel1ViewAll>();

            switch (Order)
            {
                case "CategoryLevel1_CategoryNameLevel1":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.CategoryLevel1_CategoryNameLevel1).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CategoryLevel1_CategoryNameLevel1).ToList();
                    }
                    break;
                case "CategoryLevel2_CategoryNameLevel2":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.CategoryLevel2_CategoryNameLevel2).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CategoryLevel2_CategoryNameLevel2).ToList();
                    }
                    break;
                case "CategoryLevel1_ID":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.CategoryLevel1_ID).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CategoryLevel1_ID).ToList();
                    }
                    break;
                default:
                    ObjOrder = obj;
                    break;
            }

            for (int i = 0; i < ObjOrder.Count; i++)
            {
                if ((TitleLenght > -1) & (ObjOrder[i].CategoryLevel1_CategoryNameLevel1.Length > TitleLenght))
                {
                    ObjOrder[i].CategoryLevel1_CategoryNameLevel1 = ObjOrder[i].CategoryLevel1_CategoryNameLevel1.Substring(0, TitleLenght - 1);
                }
            }
            List<vw_CategoryLevel1ViewAll> ObjOrderLimit = new List<vw_CategoryLevel1ViewAll>();
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
        //===================================================================

        public void Sel_ByIDAlbum(HttpContext context)
        {
            String jSonString = "";
            int IDAlbum = Convert.ToInt32(context.Request.QueryString["IDAlbum"]);
            bool Disable = !String.IsNullOrEmpty(context.Request.QueryString["Disable"])
          ? Convert.ToBoolean(context.Request.QueryString["Disable"])
          : false;
            CategoryLevel1BO aCategoryLevel1BO = new CategoryLevel1BO();
            List<CategoryLevel1> obj = String.IsNullOrEmpty(context.Request.QueryString["Disable"]) ?
                aCategoryLevel1BO.Sel_ByIDAlbum(IDAlbum) : aCategoryLevel1BO.Sel_ByIDAlbum(IDAlbum, Disable);
            if (obj != null)
            {
                _converter.DateTimeFormat = "dd/MM/yyyy";

                jSonString = JsonConvert.SerializeObject(obj, _converter);
            }
            jSonString = "{\"data\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }
        public void Sel_ByIDAlbum_ByIDLang(HttpContext context)
        {
            String jSonString = "";
            int IDAlbum = Convert.ToInt32(context.Request.QueryString["IDAlbum"]);
            bool Disable = !String.IsNullOrEmpty(context.Request.QueryString["Disable"])
        ? Convert.ToBoolean(context.Request.QueryString["Disable"])
        : false;
            int IDLang = !string.IsNullOrEmpty(context.Request.QueryString["IDLang"].ToString()) ? int.Parse(context.Request.QueryString["IDLang"]) : 1;
            CategoryLevel1BO aCategoryLevel1BO = new CategoryLevel1BO();
            List<CategoryLevel1> obj = String.IsNullOrEmpty(context.Request.QueryString["Disable"]) ?

                aCategoryLevel1BO.Sel_ByIDAlbum_ByIDLang(IDAlbum, IDLang) : aCategoryLevel1BO.Sel_ByIDAlbum_ByIDLang(IDAlbum, IDLang, Disable);
            if (obj != null)
            {
                _converter.DateTimeFormat = "dd/MM/yyyy";

                jSonString = JsonConvert.SerializeObject(obj, _converter);
            }
            jSonString = "{\"data\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }





        public void Sel_ByCodeCategoryLevel2(HttpContext context, int IDLang)
        {
            ConfigsBO aConfigsBO = new ConfigsBO();
            String jSonString = "";
            string CodeCategoryLevel2 = "";
            CodeCategoryLevel2 = context.Request.QueryString["CodeCat2"];

            CategoryLevel1BO aCategoryLevel1BO = new CategoryLevel1BO();


            //List<CategoryLevel1> obj = aCategoryLevel1BO.Sel_ByIDLang(IDLang).Where(p => !p.CodeCategoryLevel2.Contains(CodeCategoryLevel2)).ToList<CategoryLevel1>();
            List<vw_CategoryLevel1ViewAll> obj = aCategoryLevel1BO.Sel_Ext_ByCodeCategoryLevel2(CodeCategoryLevel2).ToList();

            if (obj != null)
            {
                _converter.DateTimeFormat = "dd/MM/yyyy";

                jSonString = JsonConvert.SerializeObject(obj, _converter);
            }
            jSonString = "{\"CategoryLevel1s\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }

        public void Sel_ByKeyCodeCategoryLevel2_ByIDLang(HttpContext context)   // Load ra danh sách các contact bằng IDLang
        {

            String jSonString = "";

            string KeyCodeCategoryLevel2 = context.Request.QueryString["KeyCodeCategoryLevel2"] != null && context.Request.QueryString["KeyCodeCategoryLevel2"] != "undefined" ? context.Request.QueryString["KeyCodeCategoryLevel2"] : "";
            int IDLang = context.Request.QueryString["IDLang"] != null && context.Request.QueryString["IDLang"] != "undefined" ? int.Parse(context.Request.QueryString["IDLang"]) : 1;

            bool Disable = !String.IsNullOrEmpty(context.Request.QueryString["Disable"])
               ? Convert.ToBoolean(context.Request.QueryString["Disable"])
               : false;

            int InfoLenght = context.Request.QueryString["IntroLenght"] != null && context.Request.QueryString["IntroLenght"] != "undefined" ? int.Parse(context.Request.QueryString["IntroLenght"]) : -1;
            int TitleLenght = context.Request.QueryString["TitleLenght"] != null && context.Request.QueryString["TitleLenght"] != "undefined" ? int.Parse(context.Request.QueryString["TitleLenght"]) : -1;
            int Limit = context.Request.QueryString["Limit"] != null && context.Request.QueryString["Limit"] != "undefined" ? int.Parse(context.Request.QueryString["Limit"]) : -1;
            string Order = context.Request.QueryString["Order"] != null && context.Request.QueryString["Order"] != "undefined" ? context.Request.QueryString["Order"] : "-1";
            string IsDesc = context.Request.QueryString["IsDesc"] != null && context.Request.QueryString["IsDesc"] != "undefined" ? context.Request.QueryString["IsDesc"] : "-1";

            CategoryLevel1BO aCategoryLevel1BO = new CategoryLevel1BO();
            List<vw_CategoryLevel1ViewAll> obj = String.IsNullOrEmpty(context.Request.QueryString["Disable"]) ?
                aCategoryLevel1BO.Sel_ByKeyCodeCategoryLevel1_ByIDLang(KeyCodeCategoryLevel2, IDLang) :
                aCategoryLevel1BO.Sel_ByKeyCodeCategoryLevel1_ByIDLang(KeyCodeCategoryLevel2, IDLang, Disable);
            List<vw_CategoryLevel1ViewAll> ObjOrder = new List<vw_CategoryLevel1ViewAll>();

            switch (Order)
            {
                case "CategoryLevel1_Code":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.CategoryLevel1_Code).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CategoryLevel1_Code).ToList();
                    }
                    break;

                case "CategoryLevel2_Code":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.CategoryLevel2_Code).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CategoryLevel2_Code).ToList();
                    }
                    break;

                case "CountContentDisable":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.CountContentDisable).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CountContentDisable).ToList();
                    }
                    break;
                case "CountContentEnable":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.CountContentEnable).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CountContentEnable).ToList();
                    }
                    break;
                case "CountContent":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.CountContent).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CountContent).ToList();
                    }
                    break;
                case "CategoryLevel2_Status":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.CategoryLevel2_Status).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CategoryLevel2_Status).ToList();
                    }
                    break;
                case "CategoryLevel2_ID":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.CategoryLevel2_ID).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CategoryLevel2_ID).ToList();
                    }
                    break;
                case "CategoryLevel1_ViewCount":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.CategoryLevel1_ViewCount).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CategoryLevel1_ViewCount).ToList();
                    }
                    break;
                case "CategoryLevel1_Type":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.CategoryLevel1_Type).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CategoryLevel1_Type).ToList();
                    }
                    break;
                case "CategoryLevel1_Status":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.CategoryLevel1_Status).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CategoryLevel1_Status).ToList();
                    }
                    break;
                case "CategoryLevel1_ID":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.CategoryLevel1_ID).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CategoryLevel1_ID).ToList();
                    }
                    break;
                case "CategoryLevel1_CategoryLevel2_Disable":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.CategoryLevel1_CategoryLevel2_Disable).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CategoryLevel1_CategoryLevel2_Disable).ToList();
                    }
                    break;
                default:
                    ObjOrder = obj;
                    break;
            }

            for (int i = 0; i < ObjOrder.Count; i++)
            {
                if ((TitleLenght > -1) & (ObjOrder[i].CategoryLevel1_CategoryNameLevel1.Length > TitleLenght))
                {
                    ObjOrder[i].CategoryLevel1_CategoryNameLevel1 = ObjOrder[i].CategoryLevel1_CategoryNameLevel1.Substring(0, TitleLenght - 1);
                }
                if ((InfoLenght > -1) & (ObjOrder[i].CategoryLevel1_Info.Length > InfoLenght))
                {
                    ObjOrder[i].CategoryLevel1_Info = ObjOrder[i].CategoryLevel1_Info.Substring(0, InfoLenght - 1);
                }
            }
            List<vw_CategoryLevel1ViewAll> ObjOrderLimit = new List<vw_CategoryLevel1ViewAll>();
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
            jSonString = "{\"CategoryLevel1\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }

        public void Sel_ByKeyCodeCategoryLevel1_ByIDLang(HttpContext context)   // Load ra danh sách các contact bằng IDLang
        {
            String jSonString = "";


            string KeyCodeCategoryLevel1 = context.Request.QueryString["KeyCodeCategoryLevel1"] != null && context.Request.QueryString["KeyCodeCategoryLevel1"] != "undefined" ? context.Request.QueryString["KeyCodeCategoryLevel1"] : "";
            bool Disable = !String.IsNullOrEmpty(context.Request.QueryString["Disable"])
               ? Convert.ToBoolean(context.Request.QueryString["Disable"])
               : false;

            int IDLang = string.IsNullOrEmpty(context.Request.QueryString["IDLang"]) == false && context.Request.QueryString["IDLang"] != "undefined" ? int.Parse(context.Request.QueryString["IDLang"]) : 1;

            int IntroLenght = context.Request.QueryString["IntroLenght"] != null && context.Request.QueryString["IntroLenght"] != "undefined" ? int.Parse(context.Request.QueryString["IntroLenght"]) : -1;
            int TitleLenght = context.Request.QueryString["TitleLenght"] != null && context.Request.QueryString["TitleLenght"] != "undefined" ? int.Parse(context.Request.QueryString["TitleLenght"]) : -1;
            int Limit = context.Request.QueryString["Limit"] != null && context.Request.QueryString["Limit"] != "undefined" ? int.Parse(context.Request.QueryString["Limit"]) : -1;
            string Order = context.Request.QueryString["Order"] != null && context.Request.QueryString["Order"] != "undefined" ? context.Request.QueryString["Order"] : "-1";
            string IsDesc = context.Request.QueryString["IsDesc"] != null && context.Request.QueryString["IsDesc"] != "undefined" ? context.Request.QueryString["IsDesc"] : "-1";

            CategoryLevel1BO aCategoryLevel1BO = new CategoryLevel1BO();
            List<vw_CategoryLevel1ViewAll> obj = String.IsNullOrEmpty(context.Request.QueryString["Disable"]) ?
            aCategoryLevel1BO.Sel_ByKeyCodeCategoryLevel1_ByIDLang(KeyCodeCategoryLevel1, IDLang) :
            aCategoryLevel1BO.Sel_ByKeyCodeCategoryLevel1_ByIDLang(KeyCodeCategoryLevel1, IDLang, Disable);

            List<vw_CategoryLevel1ViewAll> ObjOrder = new List<vw_CategoryLevel1ViewAll>();

            switch (Order)
            {
                case "CategoryLevel1_Code":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.CategoryLevel1_Code).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CategoryLevel1_Code).ToList();
                    }
                    break;

                case "CategoryLevel2_Code":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.CategoryLevel2_Code).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CategoryLevel2_Code).ToList();
                    }
                    break;

                case "CountContentDisable":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.CountContentDisable).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CountContentDisable).ToList();
                    }
                    break;
                case "CountContentEnable":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.CountContentEnable).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CountContentEnable).ToList();
                    }
                    break;
                case "CountContent":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.CountContent).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CountContent).ToList();
                    }
                    break;
                case "CategoryLevel2_Status":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.CategoryLevel2_Status).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CategoryLevel2_Status).ToList();
                    }
                    break;
                case "CategoryLevel2_ID":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.CategoryLevel2_ID).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CategoryLevel2_ID).ToList();
                    }
                    break;
                case "CategoryLevel1_ViewCount":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.CategoryLevel1_ViewCount).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CategoryLevel1_ViewCount).ToList();
                    }
                    break;
                case "CategoryLevel1_Type":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.CategoryLevel1_Type).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CategoryLevel1_Type).ToList();
                    }
                    break;
                case "CategoryLevel1_Status":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.CategoryLevel1_Status).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CategoryLevel1_Status).ToList();
                    }
                    break;
                case "CategoryLevel1_ID":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.CategoryLevel1_ID).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CategoryLevel1_ID).ToList();
                    }
                    break;
                case "CategoryLevel1_CategoryLevel2_Disable":
                    if (IsDesc == "False")
                    {
                        ObjOrder = obj.OrderBy(a => a.CategoryLevel1_CategoryLevel2_Disable).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CategoryLevel1_CategoryLevel2_Disable).ToList();
                    }
                    break;
                default:
                    ObjOrder = obj;
                    break;
            }

            for (int i = 0; i < ObjOrder.Count; i++)
            {
                if ((TitleLenght > -1) & (ObjOrder[i].CategoryLevel1_CategoryNameLevel1.Length > TitleLenght))
                {
                    ObjOrder[i].CategoryLevel1_CategoryNameLevel1 = ObjOrder[i].CategoryLevel1_CategoryNameLevel1.Substring(0, TitleLenght - 1);
                }
                if ((IntroLenght > -1) & (ObjOrder[i].CategoryLevel1_Info.Length > IntroLenght))
                {
                    ObjOrder[i].CategoryLevel1_Info = ObjOrder[i].CategoryLevel1_Info.Substring(0, IntroLenght - 1);
                }
            }
            List<vw_CategoryLevel1ViewAll> ObjOrderLimit = new List<vw_CategoryLevel1ViewAll>();
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
            jSonString = "{\"CategoryLevel1\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }



        public void Sel_Ext_ByCode(HttpContext context)   // Load ra danh sách các contact bằng IDLang
        {

            String jSonString = "";

            string Code = context.Request.QueryString["Code"] != null && context.Request.QueryString["Code"] != "undefined" ? context.Request.QueryString["Code"] : "";
            int IDLang = context.Request.QueryString["IDLang"] != null && context.Request.QueryString["IDLang"] != "undefined" ? int.Parse(context.Request.QueryString["IDLang"]) : 1;

            bool Disable = !String.IsNullOrEmpty(context.Request.QueryString["Disable"]) ? Convert.ToBoolean(context.Request.QueryString["Disable"]) : false;

            int IntroLenght = context.Request.QueryString["IntroLenght"] != null && context.Request.QueryString["IntroLenght"] != "undefined" ? int.Parse(context.Request.QueryString["IntroLenght"]) : -1;
            int TitleLenght = context.Request.QueryString["TitleLenght"] != null && context.Request.QueryString["TitleLenght"] != "undefined" ? int.Parse(context.Request.QueryString["TitleLenght"]) : -1;
            int Limit = context.Request.QueryString["Limit"] != null && context.Request.QueryString["Limit"] != "undefined" ? int.Parse(context.Request.QueryString["Limit"]) : 50;
            string Order = context.Request.QueryString["Order"] != null && context.Request.QueryString["Order"] != "undefined" ? context.Request.QueryString["Order"] : "CategoryLevel1_ID";
            bool IsDesc = context.Request.QueryString["IsDesc"] != null && context.Request.QueryString["IsDesc"] != "undefined" ? bool.Parse(context.Request.QueryString["IsDesc"]) : true;

            CategoryLevel1BO aCategoryLevel1BO = new CategoryLevel1BO();
            List<vw_CategoryLevel1ViewAll> obj = String.IsNullOrEmpty(context.Request.QueryString["Disable"]) ?
                aCategoryLevel1BO.Sel_Ext_ByCode(Code) : aCategoryLevel1BO.Sel_Ext_ByCode(Code, Disable);
            List<vw_CategoryLevel1ViewAll> ObjOrder = new List<vw_CategoryLevel1ViewAll>();

            switch (Order)
            {
                case "CategoryLevel1_Code":
                    if (IsDesc == false)
                    {
                        ObjOrder = obj.OrderBy(a => a.CategoryLevel1_Code).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CategoryLevel1_Code).ToList();
                    }
                    break;

                case "CategoryLevel2_Code":
                    if (IsDesc ==false)
                    {
                        ObjOrder = obj.OrderBy(a => a.CategoryLevel2_Code).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CategoryLevel2_Code).ToList();
                    }
                    break;

                case "CountContentDisable":
                    if (IsDesc ==false)
                    {
                        ObjOrder = obj.OrderBy(a => a.CountContentDisable).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CountContentDisable).ToList();
                    }
                    break;
                case "CountContentEnable":
                    if (IsDesc == false)
                    {
                        ObjOrder = obj.OrderBy(a => a.CountContentEnable).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CountContentEnable).ToList();
                    }
                    break;
                case "CountContent":
                    if (IsDesc == false)
                    {
                        ObjOrder = obj.OrderBy(a => a.CountContent).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CountContent).ToList();
                    }
                    break;
                case "CategoryLevel2_Status":
                    if (IsDesc == false)
                    {
                        ObjOrder = obj.OrderBy(a => a.CategoryLevel2_Status).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CategoryLevel2_Status).ToList();
                    }
                    break;
                case "CategoryLevel2_ID":
                    if (IsDesc == false)
                    {
                        ObjOrder = obj.OrderBy(a => a.CategoryLevel2_ID).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CategoryLevel2_ID).ToList();
                    }
                    break;
                case "CategoryLevel1_ViewCount":
                    if (IsDesc == false)
                    {
                        ObjOrder = obj.OrderBy(a => a.CategoryLevel1_ViewCount).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CategoryLevel1_ViewCount).ToList();
                    }
                    break;
                case "CategoryLevel1_Type":
                    if (IsDesc == false)
                    {
                        ObjOrder = obj.OrderBy(a => a.CategoryLevel1_Type).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CategoryLevel1_Type).ToList();
                    }
                    break;
                case "CategoryLevel1_Status":
                    if (IsDesc == false)
                    {
                        ObjOrder = obj.OrderBy(a => a.CategoryLevel1_Status).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CategoryLevel1_Status).ToList();
                    }
                    break;
                case "CategoryLevel1_ID":
                    if (IsDesc == false)
                    {
                        ObjOrder = obj.OrderBy(a => a.CategoryLevel1_ID).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CategoryLevel1_ID).ToList();
                    }
                    break;
                case "CategoryLevel1_CategoryLevel2_Disable":
                    if (IsDesc == false)
                    {
                        ObjOrder = obj.OrderBy(a => a.CategoryLevel1_CategoryLevel2_Disable).ToList();
                    }
                    else
                    {
                        ObjOrder = obj.OrderByDescending(a => a.CategoryLevel1_CategoryLevel2_Disable).ToList();
                    }
                    break;
                default:
                    ObjOrder = obj;
                    break;
            }


            for (int i = 0; i < ObjOrder.Count; i++)
            {
                if ((TitleLenght > -1) & (ObjOrder[i].CategoryLevel1_CategoryNameLevel1.Length > TitleLenght))
                {
                    ObjOrder[i].CategoryLevel1_CategoryNameLevel1 = ObjOrder[i].CategoryLevel1_CategoryNameLevel1.Substring(0, TitleLenght - 1);
                }
                if ((IntroLenght > -1) & (ObjOrder[i].CategoryLevel1_Info.Length > IntroLenght))
                {
                    ObjOrder[i].CategoryLevel1_Info = ObjOrder[i].CategoryLevel1_Info.Substring(0, IntroLenght - 1);
                }
            }
            List<vw_CategoryLevel1ViewAll> ObjOrderLimit = new List<vw_CategoryLevel1ViewAll>();
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
            jSonString = "{\"CategoryLevel1\":" + jSonString + "}";
            context.Response.Write(jSonString);
        }



        public void Sel_Ext_ByCodeCategoryLevel2(HttpContext context, int IDLang)
        {
            ConfigsBO aConfigsBO = new ConfigsBO();
            String jSonString = "";
            string CodeCategoryLevel2 = "";
            CodeCategoryLevel2 = context.Request.QueryString["CodeCat2"];

            CategoryLevel1BO aCategoryLevel1BO = new CategoryLevel1BO();


            //List<CategoryLevel1> obj = aCategoryLevel1BO.Sel_ByIDLang(IDLang).Where(p => !p.CodeCategoryLevel2.Contains(CodeCategoryLevel2)).ToList<CategoryLevel1>();
            List<vw_CategoryLevel1ViewAll> obj = aCategoryLevel1BO.Sel_Ext_ByCodeCategoryLevel2(CodeCategoryLevel2).ToList();

            if (obj != null)
            {
                _converter.DateTimeFormat = "dd/MM/yyyy";

                jSonString = JsonConvert.SerializeObject(obj, _converter);
            }
            jSonString = "{\"CategoryLevel1s\":" + jSonString + "}";
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
                CategoryLevel1 aCategoryLevel1 = new CategoryLevel1();

                aCategoryLevel1.Status = !String.IsNullOrEmpty(context.Request.Form["cbbStatus"]) ? Convert.ToInt32(context.Request.Form["cbbStatus"]) : 0;
                aCategoryLevel1.Disable = !String.IsNullOrEmpty(context.Request.Form["cbbDisable"]) ? Convert.ToBoolean(context.Request.Form["cbbDisable"]) : false;
                // aCategoryLevel1.CodeCategoryLevel2 = !String.IsNullOrEmpty(context.Request.Form["txt_CodeCategoryLevel2"]) ? Convert.ToString(context.Request.Form["txt_CodeCategoryLevel2"]) : "";

                aCategoryLevel1.Type = !String.IsNullOrEmpty(context.Request.Form["cbbType"]) ? Convert.ToInt32(context.Request.Form["cbbType"]) : 0;
                aCategoryLevel1.IDAlbum = !String.IsNullOrEmpty(context.Request.Form["ddlAlbum"]) ? Convert.ToInt32(context.Request.Form["ddlAlbum"]) : 0;
                aCategoryLevel1.Image = !String.IsNullOrEmpty(context.Request.Form["txtImage_1"]) ? Convert.ToString(context.Request.Form["txtImage_1"]) : "";
                aCategoryLevel1.Image1 = !String.IsNullOrEmpty(context.Request.Form["txtImage_2"]) ? Convert.ToString(context.Request.Form["txtImage_2"]) : "";
                aCategoryLevel1.Image2 = !String.IsNullOrEmpty(context.Request.Form["txtImage_3"]) ? Convert.ToString(context.Request.Form["txtImage_3"]) : "";
                aCategoryLevel1.Image3 = !String.IsNullOrEmpty(context.Request.Form["txtImage_4"]) ? Convert.ToString(context.Request.Form["txtImage_4"]) : "";
                aCategoryLevel1.Tag = !String.IsNullOrEmpty(context.Request.Form["txtTag"]) ? Convert.ToString(context.Request.Form["txtTag"]) : "";

                aCategoryLevel1.ViewCount = !String.IsNullOrEmpty(context.Request.Form["txtViewCount"]) ? Convert.ToInt32(context.Request.Form["txtViewCount"]) : 0;
                long a = DateTime.Now.Ticks;
                TimeSpan Codespan = new TimeSpan(a);
                aCategoryLevel1.Code = Math.Floor(Codespan.TotalSeconds).ToString();

                for (int i = 1; i <= NUM_LANG; i++)
                {
                    aCategoryLevel1.IDLang = !String.IsNullOrEmpty(context.Request.Form["IDLang_" + i]) ? Convert.ToInt32(context.Request.Form["IDLang_" + i]) : 0;

                    aCategoryLevel1.Note = !String.IsNullOrEmpty(context.Request.Form["txtNote_Lang" + i]) ? Convert.ToString(context.Request.Form["txtNote_Lang" + i]) : "";
                    aCategoryLevel1.CategoryNameLevel1 = !String.IsNullOrEmpty(context.Request.Form["txtCategoryNameLevel1_Lang" + i]) ? Convert.ToString(context.Request.Form["txtCategoryNameLevel1_Lang" + i]) : "";
                    aCategoryLevel1.Intro = !String.IsNullOrEmpty(context.Request.Form["txtIntro_Lang" + i]) ? Convert.ToString(HttpUtility.HtmlDecode(context.Request.Form["txtIntro_Lang" + i])) : "";
                    aCategoryLevel1.Info = !String.IsNullOrEmpty(context.Request.Form["txtInfo_Lang" + i]) ? Convert.ToString(HttpUtility.HtmlDecode(context.Request.Form["txtInfo_Lang" + i])) : "";
                    CategoryLevel1BO aCategoryLevel1BO = new CategoryLevel1BO();
                    ret = aCategoryLevel1BO.Ins(aCategoryLevel1);
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
        //tqtrung
        public void Ins_CategoryLevel1_CategoryLevel2(HttpContext context, int NUM_LANG)
        {
            int ret = -1;
            String jSonString = "";
            try
            {
                CategoryLevel1_CategoryLevel2 aCategoryLevel1_CategoryLevel2 = new CategoryLevel1_CategoryLevel2();

                for (int i = 1; i <= NUM_LANG; i++)
                {
                    aCategoryLevel1_CategoryLevel2.IDLang = !String.IsNullOrEmpty(context.Request.Form["IDLang_" + i]) ? Convert.ToInt32(context.Request.Form["IDLang_" + i]) : 0;

                    aCategoryLevel1_CategoryLevel2.Status = !String.IsNullOrEmpty(context.Request.Form["cbbStatus"]) ? Convert.ToInt32(context.Request.Form["cbbStatus"]) : 0;

                    aCategoryLevel1_CategoryLevel2.Disable = !String.IsNullOrEmpty(context.Request.Form["cbbDisable"]) ? Convert.ToBoolean(context.Request.Form["cbbDisable"]) : false;

                    // aCategoryLevel1.CodeCategoryLevel2 = !String.IsNullOrEmpty(context.Request.Form["txt_CodeCategoryLevel2"]) ? Convert.ToString(context.Request.Form["txt_CodeCategoryLevel2"]) : "";

                    aCategoryLevel1_CategoryLevel2.Type = !String.IsNullOrEmpty(context.Request.Form["cbbType"]) ? Convert.ToInt32(context.Request.Form["cbbType"]) : 0;

                    aCategoryLevel1_CategoryLevel2.CodeCategoryLevel1 = !String.IsNullOrEmpty(context.Request.Form["txtCodeCategoryLevel1"]) ? Convert.ToString(context.Request.Form["txtCodeCategoryLevel1"]) : "";
                    aCategoryLevel1_CategoryLevel2.CodeCategoryLevel2 = !String.IsNullOrEmpty(context.Request.Form["txtCodeCategoryLevel2"]) ? Convert.ToString(context.Request.Form["txtCodeCategoryLevel2"]) : "";

                    CategoryLevel1BO aCategoryLevel1BO = new CategoryLevel1BO();
                    ret = aCategoryLevel1BO.InsCategoryLevel1_CategoryLevel2(aCategoryLevel1_CategoryLevel2);
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
                List<CategoryLevel1> aListCategoryLevel1 = new List<CategoryLevel1>();
                CategoryLevel1BO aCategoryLevel1BO = new CategoryLevel1BO();
                String Code = context.Request.Form["txtCode"];

                aListCategoryLevel1 = aCategoryLevel1BO.Sel_ByCode(Code);
                int LoopUpdate = 0;

                if (aListCategoryLevel1.Count <= NUM_LANG)
                {
                    LoopUpdate = aListCategoryLevel1.Count;
                    for (int i = 0; i < LoopUpdate; i++)
                    {

                        aListCategoryLevel1[i].ID = aListCategoryLevel1[i].ID;
                        aListCategoryLevel1[i].Code = aListCategoryLevel1[i].Code;
                        aListCategoryLevel1[i].IDLang = aListCategoryLevel1[i].IDLang;
                        aListCategoryLevel1[i].Type = !String.IsNullOrEmpty(context.Request.Form["cbbType"]) ? Convert.ToInt32(context.Request.Form["cbbType"]) : aListCategoryLevel1[i].Type;
                        aListCategoryLevel1[i].ViewCount = !String.IsNullOrEmpty(context.Request.Form["txtViewCount"]) ? Convert.ToInt64(context.Request.Form["txtViewCount"]) : 0;
                        aListCategoryLevel1[i].Status = !String.IsNullOrEmpty(context.Request.Form["cbbStatus"]) ? Convert.ToInt32(context.Request.Form["cbbStatus"]) : aListCategoryLevel1[i].Status;
                        aListCategoryLevel1[i].Disable = !String.IsNullOrEmpty(context.Request.Form["cbbDisable"]) ? Convert.ToBoolean(context.Request.Form["cbbDisable"]) : aListCategoryLevel1[i].Disable;
                        aListCategoryLevel1[i].Tag = !String.IsNullOrEmpty(context.Request.Form["txtTag"]) ? Convert.ToString(context.Request.Form["txtTag"]) : aListCategoryLevel1[i].Tag;
                        aListCategoryLevel1[i].IDAlbum = !String.IsNullOrEmpty(context.Request.Form["cbbIDAlbum"]) ? Convert.ToInt32(context.Request.Form["cbbIDAlbum"]) : aListCategoryLevel1[i].IDAlbum;
                        aListCategoryLevel1[i].Image = !String.IsNullOrEmpty(context.Request.Form["txtImage_1"]) ? Convert.ToString(context.Request.Form["txtImage_1"]) : "";
                        aListCategoryLevel1[i].Image1 = !String.IsNullOrEmpty(context.Request.Form["txtImage_2"]) ? Convert.ToString(context.Request.Form["txtImage_2"]) : "";
                        aListCategoryLevel1[i].Image2 = !String.IsNullOrEmpty(context.Request.Form["txtImage_3"]) ? Convert.ToString(context.Request.Form["txtImage_3"]) : "";
                        aListCategoryLevel1[i].Image3 = !String.IsNullOrEmpty(context.Request.Form["txtImage_4"]) ? Convert.ToString(context.Request.Form["txtImage_4"]) : "";

                        aListCategoryLevel1[i].CategoryNameLevel1 = !String.IsNullOrEmpty(context.Request.Form["txtCategoryNameLevel1_Lang" + (i + 1)]) ? Convert.ToString(context.Request.Form["txtCategoryNameLevel1_Lang" + (i + 1)]) : aListCategoryLevel1[i].CategoryNameLevel1;
                        aListCategoryLevel1[i].Note = !String.IsNullOrEmpty(context.Request.Form["txtNote_Lang" + (i + 1)]) ? Convert.ToString(context.Request.Form["txtNote_Lang" + (i + 1)]) : aListCategoryLevel1[i].Note;
                        aListCategoryLevel1[i].Intro = !String.IsNullOrEmpty(context.Request.Form["txtIntro_Lang" + (i + 1)]) ? Convert.ToString(context.Request.Form["txtIntro_Lang" + (i + 1)]) : aListCategoryLevel1[i].Intro;
                        aListCategoryLevel1[i].Info = !String.IsNullOrEmpty(context.Request.Form["txtInfo_Lang" + (i + 1)]) ? Convert.ToString(context.Request.Form["txtInfo_Lang" + (i + 1)]) : aListCategoryLevel1[i].Info;


                        ret = aCategoryLevel1BO.Upd(aListCategoryLevel1);
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
        //=================================================================================================
        public void Upd_Disable(HttpContext context)
        {
            int ret = -1;
            String jSonString = "";
            try
            {
                CategoryLevel1BO aCategoryLevel1BO = new CategoryLevel1BO();
                List<CategoryLevel1> listCategoryLevel1 = new List<CategoryLevel1>();
                string Code = aCategoryLevel1BO.Sel_ByID(int.Parse(context.Request.QueryString["IDCategoryLevel1"])).Code;

                for (int i = 0; i < listCategoryLevel1.Count; i++)
                {
                    listCategoryLevel1[i].Disable = true;
                    ret = aCategoryLevel1BO.Upd(listCategoryLevel1[i]);
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
        // =========================================================================
        public void Upd_Status_ByID(HttpContext context)
        {
            int ret = -1;
            String jSonString = "";
            try
            {
                CategoryLevel1BO aCategoryLevel1BO = new CategoryLevel1BO();
                int ID = int.Parse(context.Request.QueryString["IDCategoryLevel1"]);
                int Status = int.Parse(context.Request.QueryString["Status"]);
                ret = aCategoryLevel1BO.Upd_Status_ByID(Status, ID);
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
                CategoryLevel1BO aCategoryLevel1BO = new CategoryLevel1BO();
                int ID = int.Parse(context.Request.QueryString["IDCategoryLevel1"]);
                int Type = int.Parse(context.Request.QueryString["Type"]);
                ret = aCategoryLevel1BO.Upd_Status_ByID(Type, ID);
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
                CategoryLevel1BO aCategoryLevel1BO = new CategoryLevel1BO();
                int ID = int.Parse(context.Request.QueryString["IDCategoryLevel1"]);
                bool Disable = Convert.ToBoolean(context.Request.QueryString["Disable"]);
                ret = aCategoryLevel1BO.Upd_Disable_ByID(Disable, ID);
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
                CategoryLevel1BO aCategoryLevel1BO = new CategoryLevel1BO();
                List<CategoryLevel1> listCategoryLevel1 = new List<CategoryLevel1>();
                string Code = context.Request.QueryString["Code"];
                int Status = Convert.ToInt32(context.Request.QueryString["Status"]);

                ret = aCategoryLevel1BO.Upd_Status_ByCode(Status, Code);
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
                CategoryLevel1BO aCategoryLevel1BO = new CategoryLevel1BO();
                List<CategoryLevel1> listCategoryLevel1 = new List<CategoryLevel1>();
                string Code = context.Request.QueryString["Code"];
                int Type = Convert.ToInt32(context.Request.QueryString["Type"]);

                ret = aCategoryLevel1BO.Upd_Type_ByCode(Type, Code);
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
                CategoryLevel1BO aCategoryLevel1BO = new CategoryLevel1BO();
                List<CategoryLevel1> listCategoryLevel1 = new List<CategoryLevel1>();
                string Code = context.Request.QueryString["Code"];
                bool Disable = Convert.ToBoolean(context.Request.QueryString["Disable"]);

                ret = aCategoryLevel1BO.Upd_Disable_ByCode(Disable, Code);
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
                CategoryLevel1BO aCategoryLevel1BO = new CategoryLevel1BO();
                string Code = context.Request.QueryString["Code"];
                int Status = int.Parse(context.Request.QueryString["Status"]);
                int IDLang = !string.IsNullOrEmpty(context.Request.QueryString["IDLang"].ToString()) ? int.Parse(context.Request.QueryString["IDLang"]) : 1;
                ret = aCategoryLevel1BO.Upd_Status_ByCode_ByIDLang(Status, Code, IDLang);
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
                CategoryLevel1BO aCategoryLevel1BO = new CategoryLevel1BO();
                string Code = context.Request.QueryString["Code"];
                int Type = int.Parse(context.Request.QueryString["Type"]);
                int IDLang = !string.IsNullOrEmpty(context.Request.QueryString["IDLang"].ToString()) ? int.Parse(context.Request.QueryString["IDLang"]) : 1;
                ret = aCategoryLevel1BO.Upd_Type_ByCode_ByIDLang(Type, Code, IDLang);
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
                CategoryLevel1BO aCategoryLevel1BO = new CategoryLevel1BO();
                string Code = context.Request.QueryString["Code"];
                bool Disable = Convert.ToBoolean(context.Request.QueryString["Disable"]);
                int IDLang = !string.IsNullOrEmpty(context.Request.QueryString["IDLang"].ToString()) ? int.Parse(context.Request.QueryString["IDLang"]) : 1;
                ret = aCategoryLevel1BO.Upd_Disable_ByCode_ByIDLang(Disable, Code, IDLang);
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

        #region DEL DATABASE
        public void Del(HttpContext context)
        {

            String jSonString = "";
            int IDCategoryLevel1 = Convert.ToInt32(context.Request.QueryString["IDCategoryLevel1"]);

            CategoryLevel1BO aCategoryLevel1BO = new CategoryLevel1BO();
            //int ret = aCategoryLevel1BO.Del(IDCategoryLevel1);


            //if (ret != 0)
            //{ jSonString = "{\"status\": \"success\"}"; }

            //if (ret == 0)
            //{ jSonString = "{\"status\":\"error|" + ret.ToString() + "\"}"; }


            context.Response.Write(jSonString);
        }

        public void Del_ByCode(HttpContext context)
        {
            CategoryLevel1BO aCategoryLevel1BO = new CategoryLevel1BO();
            String jSonString = "";
            string Code = context.Request.QueryString["Code"].ToString();
            int ret = aCategoryLevel1BO.Del_ByCode(Code);


            if (ret > 0)
            { jSonString = "{\"status\": \"success\"}"; }

            if (ret <= 0)
            { jSonString = "{\"status\":\"error\" ,\"message\":\"" + ret.ToString() + "\"}"; }


            context.Response.Write(jSonString);
        }

        public void Del_ByCode_ByIDLang(HttpContext context)
        {
            CategoryLevel1BO aCategoryLevel1BO = new CategoryLevel1BO();
            String jSonString = "";
            string Code = context.Request.QueryString["Code"].ToString();
            int IDLang = !string.IsNullOrEmpty(context.Request.QueryString["IDLang"].ToString()) ? int.Parse(context.Request.QueryString["IDLang"]) : 1;
            int ret = aCategoryLevel1BO.Del_ByCode_ByIDLang(Code, IDLang);


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
            int ID = Convert.ToInt32(context.Request.QueryString["ID"].ToString());
            int ret = aCategoryLevel2BO.Del_ByID(ID);


            if (ret > 0)
            { jSonString = "{\"status\": \"success\"}"; }

            if (ret <= 0)
            { jSonString = "{\"status\":\"error\" ,\"message\":\"" + ret.ToString() + "\"}"; }


            context.Response.Write(jSonString);

        }
        #endregion

        private List<CategoryLevel1> ConvertList(List<CategoryLevel1> ListCategoryLevel1, int InfoLenght, int IntroLenght, int Limit, string Order, bool IsDesc)
        {
            if ((Limit == null) || (Limit <= 0))
            {
                Limit = ListCategoryLevel1.Count;
            }
            if (Limit > ListCategoryLevel1.Count)
            {
                Limit = ListCategoryLevel1.Count;
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
                case "CategoryNameLevel1":
                    if (IsDesc == false)
                    {
                        ListCategoryLevel1 = ListCategoryLevel1.OrderBy(a => a.CategoryNameLevel1).ToList();
                    }
                    else
                    {
                        ListCategoryLevel1 = ListCategoryLevel1.OrderByDescending(a => a.CategoryNameLevel1).ToList();
                    }
                    break;
                case "Status":
                    if (IsDesc == false)
                    {
                        ListCategoryLevel1 = ListCategoryLevel1.OrderBy(a => a.Status).ToList();
                    }
                    else
                    {
                        ListCategoryLevel1 = ListCategoryLevel1.OrderByDescending(a => a.Status).ToList();
                    }
                    break;
                case "Disable":
                    if (IsDesc == false)
                    {
                        ListCategoryLevel1 = ListCategoryLevel1.OrderBy(a => a.Disable).ToList();
                    }
                    else
                    {
                        ListCategoryLevel1 = ListCategoryLevel1.OrderByDescending(a => a.Disable).ToList();
                    }
                    break;
                case "Code":
                    if (IsDesc == false)
                    {
                        ListCategoryLevel1 = ListCategoryLevel1.OrderBy(a => a.Code).ToList();
                    }
                    else
                    {
                        ListCategoryLevel1 = ListCategoryLevel1.OrderByDescending(a => a.Code).ToList();
                    }
                    break;
                //==============================================================================
                case "IDLang":
                    if (IsDesc == false)
                    {
                        ListCategoryLevel1 = ListCategoryLevel1.OrderBy(a => a.IDLang).ToList();
                    }
                    else
                    {
                        ListCategoryLevel1 = ListCategoryLevel1.OrderByDescending(a => a.IDLang).ToList();
                    }
                    break;
                //==============================================================================
                case "ID":
                    if (IsDesc == false)
                    {
                        ListCategoryLevel1 = ListCategoryLevel1.OrderBy(a => a.ID).ToList();
                    }
                    else
                    {
                        ListCategoryLevel1 = ListCategoryLevel1.OrderByDescending(a => a.ID).ToList();
                    }
                    break;
                //==============================================================================
                case "Type":
                    if (IsDesc == false)
                    {
                        ListCategoryLevel1 = ListCategoryLevel1.OrderBy(a => a.Type).ToList();
                    }
                    else
                    {
                        ListCategoryLevel1 = ListCategoryLevel1.OrderByDescending(a => a.Type).ToList();
                    }
                    break;
                //==============================================================================
                case "Note":
                    if (IsDesc == false)
                    {
                        ListCategoryLevel1 = ListCategoryLevel1.OrderBy(a => a.Note).ToList();
                    }
                    else
                    {
                        ListCategoryLevel1 = ListCategoryLevel1.OrderByDescending(a => a.Note).ToList();
                    }
                    break;
                //==============================================================================
                case "ViewCount":
                    if (IsDesc == false)
                    {
                        ListCategoryLevel1 = ListCategoryLevel1.OrderBy(a => a.ViewCount).ToList();
                    }
                    else
                    {
                        ListCategoryLevel1 = ListCategoryLevel1.OrderByDescending(a => a.ViewCount).ToList();
                    }
                    break;
                //==============================================================================
                case "Info":
                    if (IsDesc == false)
                    {
                        ListCategoryLevel1 = ListCategoryLevel1.OrderBy(a => a.Info).ToList();
                    }
                    else
                    {
                        ListCategoryLevel1 = ListCategoryLevel1.OrderByDescending(a => a.Info).ToList();
                    }
                    break;
                //==============================================================================

                case "Intro":
                    if (IsDesc == false)
                    {
                        ListCategoryLevel1 = ListCategoryLevel1.OrderBy(a => a.Intro).ToList();
                    }
                    else
                    {
                        ListCategoryLevel1 = ListCategoryLevel1.OrderByDescending(a => a.Intro).ToList();
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
                if (ListCategoryLevel1[i].CategoryNameLevel1.Length < InfoLenght_Tempt)
                {
                    InfoLenght_Tempt = ListCategoryLevel1[i].Info.Length;
                }
                if (ListCategoryLevel1[i].Intro.Length < IntroLenght_Tempt)
                {
                    IntroLenght_Tempt = ListCategoryLevel1[i].Intro.Length;
                }

                //if (TitleLenght == 0) { TitleLenght = 1; }
                //if (IntroLenght == 0) { IntroLenght = 1; }

                ListCategoryLevel1[i].Info = ListCategoryLevel1[i].Info.Substring(0, InfoLenght_Tempt);
                ListCategoryLevel1[i].Intro = ListCategoryLevel1[i].Intro.Substring(0, IntroLenght_Tempt);

                InfoLenght_Tempt = InfoLenght;
                IntroLenght_Tempt = IntroLenght;
            }



            ListCategoryLevel1 = ListCategoryLevel1.GetRange(0, Limit).ToList();
            return ListCategoryLevel1;
            //=========================
        }

    }
}
