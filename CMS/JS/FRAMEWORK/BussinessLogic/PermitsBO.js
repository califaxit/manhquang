﻿/**
 * @author Nam Chu
 * @created 02/0/15
 * 
 * @modified Nam Chu 08/07/15
 * -add some methods to work with ActionHandler
 * -add disable to Sel methods
 * -reformat and optimize code
 */
//TODO: Upd_Type, Upd_Status, Upd_Disable are NOT available
var PermitsBO = {
    Sel: function(disable) {
        var ret;
        if (disable == undefined) {
            jQuery.ajax({
                url: "/Action/ProcessBackendAction.ashx?ActionObject=Permits&action=Sel",
                type: "POST",
                dataType: "json",
                data: "",
                success: function(data, dataStatus) {
                    ret = data;
                },
                timeout: 30000,
                async: false,
                error: function(request, error) {}
            });
        } else {
            jQuery.ajax({
                url: "/Action/ProcessBackendAction.ashx?ActionObject=Permits&action=Sel&Disable=" + disable,
                type: "POST",
                dataType: "json",
                data: "",
                success: function(data, dataStatus) {
                    ret = data;
                },
                timeout: 30000,
                async: false,
                error: function(request, error) {}
            });
        }
        return ret;
    },

    Sel_ByID: function(id, disable) {
        var ret;
        if (disable == undefined) {
            jQuery.ajax({
                url: "/Action/ProcessBackendAction.ashx?ActionObject=Permits&action=Sel_ByID&ID=" + id,
                type: "POST",
                dataType: "json",
                data: "",
                success: function(data, dataStatus) {
                    ret = data;
                },
                timeout: 30000,
                async: false,
                error: function(request, error) {}
            });
        } else {
            jQuery.ajax({
                url: "/Action/ProcessBackendAction.ashx?ActionObject=Permits&action=Sel_ByID&ID=" + id + "&Disable=" + disable,
                type: "POST",
                dataType: "json",
                data: "",
                success: function(data, dataStatus) {
                    ret = data;
                },
                timeout: 30000,
                async: false,
                error: function(request, error) {}
            });
        }
        return ret;
    },

    Sel_ByType: function(type, disable) {
        var ret;
        if (disable == undefined) {
            jQuery.ajax({
                url: "/Action/ProcessBackendAction.ashx?ActionObject=Permits&action=Sel_ByType&Type=" + type,
                type: "POST",
                dataType: "json",
                data: "",
                success: function(data, dataStatus) {
                    ret = data;
                },
                timeout: 30000,
                async: false,
                error: function(request, error) {}
            });
        } else {
            jQuery.ajax({
                url: "/Action/ProcessBackendAction.ashx?ActionObject=Permits&action=Sel_ByType&Type=" + type + "&Disable=" + disable,
                type: "POST",
                dataType: "json",
                data: "",
                success: function(data, dataStatus) {
                    ret = data;
                },
                timeout: 30000,
                async: false,
                error: function(request, error) {}
            });
        }
        return ret;
    },

    Sel_ByStatus: function(status, disable) {
        var ret;
        if (disable == undefined) {
            jQuery.ajax({
                url: "/Action/ProcessBackendAction.ashx?ActionObject=Permits&action=Sel_ByStatus&Status=" + status,
                type: "POST",
                dataType: "json",
                data: "",
                success: function(data, dataStatus) {
                    ret = data;
                },
                timeout: 30000,
                async: false,
                error: function(request, error) {}
            });
        } else {
            jQuery.ajax({
                url: "/Action/ProcessBackendAction.ashx?ActionObject=Permits&action=Sel_ByStatus&Status=" + status + "&Disable=" + disable,
                type: "POST",
                dataType: "json",
                data: "",
                success: function(data, dataStatus) {
                    ret = data;
                },
                timeout: 30000,
                async: false,
                error: function(request, error) {}
            });
        }
        return ret;
    },

    Sel_ByType_ByStatus: function(type, status, disable) {
        var ret;
        if (disable == undefined) {
            jQuery.ajax({
                url: "/Action/ProcessBackendAction.ashx?ActionObject=Permits&action=Sel_ByType_ByStatus&Type=" + type + "&Status=" + status,
                type: "POST",
                dataType: "json",
                data: "",
                success: function(data, dataStatus) {
                    ret = data;
                },
                timeout: 30000,
                async: false,
                error: function(request, error) {}
            });
        } else {
            jQuery.ajax({
                url: "/Action/ProcessBackendAction.ashx?ActionObject=Permits&action=Sel_ByType_ByStatus&Type=" + type + "&Status=" + status + "&Disable=" + disable,
                type: "POST",
                dataType: "json",
                data: "",
                success: function(data, dataStatus) {
                    ret = data;
                },
                timeout: 30000,
                async: false,
                error: function(request, error) {}
            });
        }
        return ret;
    },

    Ins: function () {
        EnableLoading();
        jQuery.ajax({
            url: "/Action/ProcessBackendAction.ashx?ActionObject=Permits&action=Ins",
            type: "POST",
            dataType: "json",
            data: $("#frmIns_Permits").serialize(),

            success: function(data) {
                if (data.status == "success")
                    alert("Thêm Permits thành công.");
                else if (data.status != "success")
                    alert("Thêm Permits lỗi: <font style='font-size:9px'>" + data.message + "</font>");
                DisableLoading();
            },
            error: function(ex) {}
        });
    },

    Ins_ListPermits: function() {
        alert("Function Not Implemented");
    },

    Upd_ByID: function () {
        EnableLoading();
        jQuery.ajax({
            url: "/Action/ProcessBackendAction.ashx?ActionObject=Permits&action=Upd_ByID",
            type: "POST",
            dataType: "json",
            data: $("#frmUpd_Permits").serialize(),
            success: function(data) {
                if (data.status == "success")
                    alert("Update Permits thành công.");
                else if (data.status != "success")
                    alert("Update Permits lỗi: <font style='font-size:9px'>" + data.message + "</font>");
                DisableLoading();
            },
            error: function(ex) {}
        });
    },

    Upd_Type_ByID: function () {
        alert("Function Not Implemented");
    },

    Upd_Status_ByID: function () {
        alert("Function Not Implemented");
    },

    Upd_Disable_ByID: function () {
        alert("Function Not Implemented");
    },

    Del_ByID: function (id) {
        EnableLoading();
        jQuery.ajax({
            url: "/Action/ProcessBackendAction.ashx?ActionObject=Permits&action=Del_ByID&ID=" + id,
            type: "POST",
            dataType: "json",
            data: $("#frmUpd_Permits").serialize(),
            success: function(data) {
                if (data.status == "success")
                    alert("Delete Permits thành công.");
                else if (data.status != "success")
                    alert("Delete Permits lỗi: <font style='font-size:9px'>" + data.message + "</font>");
                DisableLoading();
            },
            error: function(ex) {}
        });
    },

    Del_ByListID: function() {
        alert("Function Not Implemented");
    }
}