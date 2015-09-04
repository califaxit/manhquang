/**
 * @author: Do Quang Quy
 * @created: 08/07/15
 * @modified 10/07/15 Nam Chu
 *  -add several select and update methods
 *  -reformat and optimize code
 */
var AlbumsBO = {
    LoadListFile_ByCodeAlbum: function (CodeAlbum, Type, TitleLenght, IntroLenght, Limit, Order, IsDesc) {

        var ret;
        jQuery.ajax({
            url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Sel_File_ByCodeAlbum&CodeAlbum=" + CodeAlbum + "&Limit=" + Limit + "&IsDesc=" + IsDesc + "&Order=" + Order,
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
    SelectListAlbums_ByListCodeAlbums: function (CodeAlbum, Type, TitleLenght, IntroLenght, Limit, Order, IsDesc) {

        var ret;
        jQuery.ajax({
            url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=SelectListAlbums_ByListCodeAlbums&CodeAlbum=" + CodeAlbum + "&Limit=" + Limit + "&IsDesc=" + IsDesc + "&Order=" + Order,
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

    Sel: function (disable) {
        var ret;
        if (disable == undefined) {
            jQuery.ajax({
                url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Sel",
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
        } else {
            jQuery.ajax({
                url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Sel&Disable=" + disable,
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
        }
    },
    Sel_ByID: function (id, disable) {
        var ret;
        if (disable == undefined) {
            jQuery.ajax({
                url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Sel_ByID&ID=" + id + "",
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
        } else {
            jQuery.ajax({
                url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Sel_ByID&ID=" + id + "&Disable =" + disable,
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
        }
        return ret;
    },
    Sel_ByIDLang: function (idLang, disable) {
        var ret;
        if (disable == undefined) {
            jQuery.ajax({
                url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Sel_ByIDLang&IDLang=" + idLang + "",
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
        } else {
            jQuery.ajax({
                url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Sel_ByIDLang&IDLang=" + idLang + "&Disable =" + disable,
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
        }
        return ret;
    },
    Sel_ByCode: function (code, disable) {
        var ret;
        if (disable == undefined) {
            jQuery.ajax({
                url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Sel_ByCode&Code=" + code,
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
        } else {
            jQuery.ajax({
                url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Sel_ByCode&Code=" + code + "&Disable =" + disable,
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
        }
        return ret;
    },
    Sel_ByType: function (type, disable) {
        var ret;
        if (disable == undefined) {
            jQuery.ajax({
                url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Sel_ByType&Type=" + type,
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
        } else {
            jQuery.ajax({
                url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Sel_ByType&Type=" + type + "&Disable =" + disable,
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
        }
        return ret;
    },
    Sel_ByStatus: function (status, disable) {
        var ret;
        if (disable == undefined) {
            jQuery.ajax({
                url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Sel_ByStatus&Status=" + status,
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
        } else {
            jQuery.ajax({
                url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Sel_ByStatus&Status=" + status + "&Disable =" + disable,
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
        }
        return ret;
    },
    Sel_ByCode_ByIDLang: function (code, idLang, disable) {
        var ret;
        if (disable == undefined) {
            jQuery.ajax({
                url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Sel_ByCode_ByIDLang&Code=" + code + "&IDLang=" + idLang,
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
        } else {
            jQuery.ajax({
                url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Sel_ByCode_ByIDLang&Code=" + code + "&IDLang=" + idLang + "&Disable =" + disable,
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
        }
        return ret;
    },
    Sel_ByType_ByIDLang: function (type, idLang, disable) {
        var ret;
        if (disable == undefined) {
            jQuery.ajax({
                url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Sel_ByType_ByIDLang&Type=" + type + "&IDLang=" + idLang,
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
        } else {
            jQuery.ajax({
                url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Sel_ByType_ByIDLang&Type=" + type + "&IDLang=" + idLang + "&Disable =" + disable,
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
        }
        return ret;
    },
    Sel_ByStatus_ByIDLang: function (status, idLang, disable) {
        var ret;
        if (disable == undefined) {
            jQuery.ajax({
                url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Sel_ByStatus_ByIDLang&Status=" + status + "&IDLang=" + idLang,
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
        } else {
            jQuery.ajax({
                url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Sel_ByStatus_ByIDLang&Status=" + status + "&IDLang=" + idLang + "&Disable =" + disable,
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
        }
        return ret;
    },
    Sel_ByType_ByCode: function (type, code, disable) {
        var ret;
        if (disable == undefined) {
            jQuery.ajax({
                url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Sel_ByType_ByCode&Type=" + type + "&Code=" + code,
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
        } else {
            jQuery.ajax({
                url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Sel_ByType_ByIDLang&Type=" + type + "&Code=" + code + "&Disable =" + disable,
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
        }
        return ret;
    },
    Sel_ByStatus_ByCode: function (status, code, disable) {
        var ret;
        if (disable == undefined) {
            jQuery.ajax({
                url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Sel_ByStatus_ByCode&Status=" + status + "&Code=" + code + "",
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
        } else {
            jQuery.ajax({
                url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Sel_ByStatus_ByCode&Status=" + status + "&Code=" + code + "&Disable =" + disable,
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
        }
        return ret;
    },
    Sel_ByType_ByStatus_ByIDLang: function (type, status, idLang, disable) {
        var ret;
        if (disable == undefined) {
            jQuery.ajax({
                url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Sel_ByType_ByStatus_ByIDLang&Type=" + type + "Status=" + status + "&IDLang=" + idLang,
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
        } else {
            jQuery.ajax({
                url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Sel_ByType_ByStatus_ByIDLang&Type=" + type + "Status=" + status + "&IDLang=" + idLang + "&Disable =" + disable,
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
        }
        return ret;
    },

    Upd_ByID: function () {
        EnableLoading();
        $.ajax({
            url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Upd_ByID",
            type: "POST",
            dataType: "json",
            data: $("#frmUpd_Albums").serialize(),
            success: function (data) {
                if (data.status == "success")
                    alert("Update Albums thành công.");

                else if (data.status != "success")
                    alert("Update Albums lỗi: <font style='font-size:9px'>" + data.message + "</font>");

                DisableLoading();
            },
            error: function (ex) {
            }
        });
    },
    Upd_ByCode: function () {
        EnableLoading();
        $.ajax({
            url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Upd_ByCode",
            type: "POST",
            dataType: "json",
            data: $("#frmUpd_Albums").serialize(),
            success: function (data) {
                if (data.status == "success")
                    alert("Update Albums thành công.");
                else if (data.status != "success")
                    alert("Update Albums lỗi: <font style='font-size:9px'>" + data.message + "</font>");
                DisableLoading();
            },
            error: function (ex) {
            }
        });
    },
    Upd_Status_ByID: function () {
        EnableLoading();
        $.ajax({
            url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Upd_Status_ByID",
            type: "POST",
            dataType: "json",
            data: $("#").serialize(),
            success: function (data) {
                if (data.status == "success") {
                    alert("Update Albums thành công.");

                } else if (data.status != "success") {
                    alert("Update Albums lỗi: <font style='font-size:9px'>" + data.message + "</font>");

                }
                DisableLoading();
            },
            error: function (ex) {
            }
        });
    },
    Upd_Type_ByID: function () {
        EnableLoading();
        $.ajax({
            url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Upd_Type_ByID",
            type: "POST",
            dataType: "json",
            data: $("#").serialize(),
            success: function (data) {
                if (data.status == "success") {
                    alert("Update Albums thành công.");

                } else if (data.status != "success") {
                    alert("Update Albums lỗi: <font style='font-size:9px'>" + data.message + "</font>");

                }
                DisableLoading();
            },
            error: function (ex) {
            }
        });
    },
    Upd_Disable_ByID: function () {
        EnableLoading();
        $.ajax({
            url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Upd_Disable_ByID",
            type: "POST",
            dataType: "json",
            data: $("#").serialize(),
            success: function (data) {
                if (data.status == "success")
                    alert("Update Albums thành công.");

                else if (data.status != "success")
                    alert("Update Albums lỗi: <font style='font-size:9px'>" + data.message + "</font>");

                DisableLoading();
            },
            error: function (ex) {
            }
        });
    },
    Upd_Status_ByCode: function () {
        EnableLoading();
        $.ajax({
            url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Upd_Status_ByCode",
            type: "POST",
            dataType: "json",
            data: $("#").serialize(),
            success: function (data) {
                if (data.status == "success")
                    alert("Update Albums thành công.");

                else if (data.status != "success")
                    alert("Update Albums lỗi: <font style='font-size:9px'>" + data.message + "</font>");

                DisableLoading();
            },
            error: function (ex) {
            }
        });
    },
    Upd_Type_ByCode: function () {
        EnableLoading();
        $.ajax({
            url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Upd_Type_ByCode",
            type: "POST",
            dataType: "json",
            data: $("#").serialize(),
            success: function (data) {
                if (data.status == "success")
                    alert("Update Albums thành công.");

                else if (data.status != "success")
                    alert("Update Albums lỗi: <font style='font-size:9px'>" + data.message + "</font>");

                DisableLoading();
            },
            error: function (ex) {
            }
        });
    },
    Upd_Disable_ByCode: function () {
        EnableLoading();
        $.ajax({
            url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Upd_Disable_ByCode",
            type: "POST",
            dataType: "json",
            data: $("#").serialize(),
            success: function (data) {
                if (data.status == "success")
                    alert("Update Albums thành công.");

                else if (data.status != "success")
                    alert("Update Albums lỗi: <font style='font-size:9px'>" + data.message + "</font>");

                DisableLoading();
            },
            error: function (ex) {
            }
        });
    },
    Upd_Status_ByCode_ByIDLang: function () {
        EnableLoading();
        $.ajax({
            url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Upd_Status_ByCode_ByIDLang",
            type: "POST",
            dataType: "json",
            data: $("#").serialize(),
            success: function (data) {
                if (data.status == "success")
                    alert("Update Albums thành công.");

                else if (data.status != "success")
                    alert("Update Albums lỗi: <font style='font-size:9px'>" + data.message + "</font>");

                DisableLoading();
            },
            error: function (ex) {
            }
        });
    },
    Upd_Type_ByCode_ByIDLang: function () {
        EnableLoading();
        $.ajax({
            url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Upd_Type_ByCode_ByIDLang",
            type: "POST",
            dataType: "json",
            data: $("#").serialize(),
            success: function (data) {
                if (data.status == "success")
                    alert("Update Albums thành công.");

                else if (data.status != "success")
                    alert("Update Albums lỗi: <font style='font-size:9px'>" + data.message + "</font>");

                DisableLoading();
            },
            error: function (ex) {
            }
        });
    },
    Upd_Disable_ByCode_ByIDLang: function () {
        EnableLoading();
        $.ajax({
            url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Upd_Disable_ByCode_ByIDLang",
            type: "POST",
            dataType: "json",
            data: $("#").serialize(),
            success: function (data) {
                if (data.status == "success")
                    alert("Update Albums thành công.");

                else if (data.status != "success")
                    alert("Update Albums lỗi: <font style='font-size:9px'>" + data.message + "</font>");

                DisableLoading();
            },
            error: function (ex) {
            }
        });
    },

    Ins: function () {
        EnableLoading();
        $.ajax({
            url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Ins",
            type: "POST",
            dataType: "json",
            data: $("#frmIns_Albums").serialize(),

            success: function (data) {
                if (data.status == "success")
                    alert("Thêm Albums thành công.");

                else if (data.status != "success")
                    alert("Thêm Albums lỗi: <font style='font-size:9px'>" + data.message + "</font>");
                DisableLoading();
            },
            error: function (ex) {
            }
        });
    },

    Del_ByID: function (id) {
        EnableLoading();
        $.ajax({
            url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Del_ByID&IDAlbums=" + id,
            type: "POST",
            dataType: "json",
            data: $("#frmUpd_Albums").serialize(),
            success: function (data) {
                if (data.status == "success")
                    alert("Delete thành công.");

                else if (data.status != "success")
                    alert("Delete lỗi: <font style='font-size:9px'>" + data.message + "</font>");
                DisableLoading();
            },
            error: function (ex) {
            }
        });
    },
    Del_ByCode: function (code) {
        EnableLoading();
        $.ajax({
            url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Del_ByCode&Code=" + code,
            type: "POST",
            dataType: "json",
            data: $("#frmUpd_Albums").serialize(),
            success: function (data) {
                if (data.status == "success")
                    alert("Delete thành công.");

                else if (data.status != "success")
                    alert("Delete lỗi: <font style='font-size:9px'>" + data.message + "</font>");
                DisableLoading();

            },
            error: function (ex) {
            }
        });
    },
    Del_ByIDLang: function (idLang) {
        EnableLoading();
        $.ajax({
            url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Del_ByIDLang&IDLang=" + idLang,
            type: "POST",
            dataType: "json",
            data: $("#frmUpd_Albums").serialize(),
            success: function (data) {
                if (data.status == "success") alert("Delete thành công.");
                else if (data.status != "success") alert("Delete lỗi: <font style='font-size:9px'>" + data.message + "</font>");
                DisableLoading();
            },
            error: function (ex) {
            }
        });
    }
}