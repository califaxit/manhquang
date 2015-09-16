﻿
var ContentsBO = {

    Sel_ByCode: function (Code, TitleLenght, IntroLenght, Limit, Order, IsDesc)
    { 
        var ret;
        jQuery.ajax({
            url: "/Action/ProcessFrontendAction.ashx?ActionObject=Contents&action=Sel_ByCode&Code=" + Code + "&TitleLenght=" + TitleLenght + "&IntroLenght=" + IntroLenght + "&Limit=" + Limit + "&IsDesc=" + IsDesc + "&Order=" + Order ,
            type: "POST",
            dataType: "json",
            data: "",
            success: function (data, dataStatus) {
                ret = data;
            },
            timeout: 30000,
            async: false,
            error: function (request, error) {
            }
        });
        return ret;
    },
   //#############################################################################
    // NgocBM
    Sel_Ext_ByKeyCodeContent_ByIDLang: function (KeyCodeContent, TitleLenght, IntroLenght, Limit, Order, IsDesc, IDLang) {
        if ((typeof (IDLang) == 'undefined') || (IDLang == '')) {
            IDLang = sys_CUR_LANG;
        }
        var ret;
        jQuery.ajax({
            url: "/Action/ProcessFrontendAction.ashx?ActionObject=Contents&action=Sel_Ext_ByKeyCodeContent_ByIDLang" + "&KeyCodeContent=" + KeyCodeContent + "&TitleLenght=" + TitleLenght + "&IntroLenght=" + IntroLenght + "&Limit=" + Limit + "&IsDesc=" + IsDesc + "&Order=" + Order + "&IDLang=" + IDLang,
            type: "POST",
            dataType: "json",
            data: "",
            success: function (data, dataStatus) {
                ret = data;
            },
            timeout: 30000,
            async: false,
            error: function (request, error) {
            }
        });
        return ret;
    },
    Sel_Ext_ByKeyCodeContent: function (KeyCodeContent, TitleLenght, IntroLenght, Limit, Order, IsDesc) {
        var ret;
        jQuery.ajax({
            url: "/Action/ProcessFrontendAction.ashx?ActionObject=Contents&action=Sel_Ext_ByKeyCodeContent" + "&KeyCodeContent=" + KeyCodeContent + "&TitleLenght=" + TitleLenght + "&IntroLenght=" + IntroLenght + "&Limit=" + Limit + "&IsDesc=" + IsDesc + "&Order=" + Order,
            type: "POST",
            dataType: "json",
            data: "",
            success: function (data, dataStatus) {
                ret = data;
            },
            timeout: 30000,
            async: false,
            error: function (request, error) {
            }
        });
        return ret;
    },
    //#############################################################################
    Sel_Ext_ByKeyCodeCategoryLevel1_ByIDLang: function (KeyCodeCategoryLevel1, TitleLenght, IntroLenght, Limit, Order, IsDesc, IDLang) {
        if ((typeof (IDLang) == 'undefined') || (IDLang == '')) {
            IDLang = sys_CUR_LANG;
        }
        var ret;
        jQuery.ajax({
            url: "/Action/ProcessFrontendAction.ashx?ActionObject=Contents&action=Sel_Ext_ByKeyCodeCategoryLevel1_ByIDLang&KeyCodeCategoryLevel1=" + KeyCodeCategoryLevel1 + "&TitleLenght=" + TitleLenght + "&IntroLenght=" + IntroLenght + "&Limit=" + Limit + "&IsDesc=" + IsDesc + "&Order=" + Order + "&IDLang=" + IDLang,
            type: "POST",
            dataType: "json",
            data: "",
            success: function (data, dataStatus) {
                ret = data;
            },
            timeout: 30000,
            async: false,
            error: function (request, error) {
            }
        });
        return ret;
    },
    Sel_Ext_ByKeyCodeCategoryLevel1: function (KeyCodeCategoryLevel1, TitleLenght, IntroLenght, Limit, Order, IsDesc) {
        
    var ret;
    jQuery.ajax({
        url: "/Action/ProcessFrontendAction.ashx?ActionObject=Contents&action=Sel_Ext_ByKeyCodeCategoryLevel1" + "&KeyCodeCategoryLevel1=" + KeyCodeCategoryLevel1 + "&TitleLenght=" + TitleLenght + "&IntroLenght=" + IntroLenght + "&Limit=" + Limit + "&IsDesc=" + IsDesc + "&Order=" + Order,
        type: "POST",
        dataType: "json",
        data: "",
        success: function (data, dataStatus) {
            ret = data;
        },
        timeout: 30000,
        async: false,
        error: function (request, error) {
        }
    });
    return ret;
    },
    //#############################################################################
    Sel_Ext_ByCodeCategoryLevel1_ByIDLang: function (CodeCategoryLevel1, TitleLenght, IntroLenght, Limit, Order, IsDesc, IDLang) {
    if ((typeof (IDLang) == 'undefined') || (IDLang == ''))
    {
        IDLang = sys_CUR_LANG;
    }
    var ret;
    jQuery.ajax({
        url: "/Action/ProcessFrontendAction.ashx?ActionObject=Contents&action=Sel_Ext_ByCodeCategoryLevel1_ByIDLang&CodeCategoryLevel1=" + CodeCategoryLevel1 + "&Type=NormalContents&TitleLenght=" + TitleLenght + "&IntroLenght=" + IntroLenght + "&Limit=" + Limit + "&IsDesc=" + IsDesc + "&Order=" + Order + "&IDLang=" + IDLang,
        type: "POST",
        dataType: "json",
        data: "",
        success: function (data, dataStatus) {
            ret = data;
        },
        timeout: 30000,
        async: false,
        error: function (request, error) {
        }
    });
    return ret;
    },
    Sel_Ext_ByCodeCategoryLevel1: function (CodeCategoryLevel1,IDLang,Limit, IsDesc, TitleLenght, IntroLenght,Order) {
        if ((typeof (IDLang) == 'undefined') || (IDLang == '')) {
            IDLang = sys_CUR_LANG;
        }
        var ret;
        jQuery.ajax({
            url: "/Action/ProcessFrontendAction.ashx?ActionObject=Contents&action=Sel_Ext_ByCodeCategoryLevel1&CodeCategoryLevel1=" + CodeCategoryLevel1 + "&TitleLenght=" + TitleLenght + "&IntroLenght=" + IntroLenght + "&Limit=" + Limit + "&IsDesc=" + IsDesc + "&Order=" + Order + "&IDLang=" + IDLang,
            type: "POST",
            dataType: "json",
            data: "",
            success: function (data, dataStatus) {
                ret = data;
            },
            timeout: 30000,
            async: false,
            error: function (request, error) {
            }
        });
        return ret;
    },
    Sel_ByIDLang: function (IDLang)
    {
        if ((typeof (IDLang) == 'undefined') || (IDLang == '')) {
            IDLang = sys_CUR_LANG;
        }
        var ret;
        jQuery.ajax({
            url: "/Action/ProcessFrontendAction.ashx?ActionObject=Contents&action=Sel_ByIDLang&IDLang=" + IDLang,
            type: "POST",
            dataType: "json",
            data: "",
            success: function (data, dataStatus) {
                ret = data;
            },
            timeout: 30000,
            async: false,
            error: function (request, error) {
            }
        });
        return ret;
    }
    //############################################################################################################################
   
}