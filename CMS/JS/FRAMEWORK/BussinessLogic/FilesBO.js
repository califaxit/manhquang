
var FilesBO = {
    LoadListFile_ByCodeAlbum: function(CodeAlbum, Type, TitleLenght, IntroLenght, Limit, Order, IsDesc) {

        var ret;
        jQuery.ajax({
            url: "/Action/ProcessFrontendAction.ashx?ActionObject=Files&action=Sel_File_ByCodeAlbum&CodeAlbum=" + CodeAlbum + "&Limit=" + Limit + "&IsDesc=" + IsDesc + "&Order=" + Order,
            type: "POST",
            dataType: "json",
            data: "",
            success: function(data, dataStatus) {
                ret = data;
            },
            timeout: 30000,
            async: false,
            error: function(request, error) {
            }
        });
        return ret;
    },
    LoadListFile_ByCodeContents: function(CodeContents, Limit, Order, IsDesc) {

        var ret;
        jQuery.ajax({
            url: "/Action/ProcessFrontendAction.ashx?ActionObject=Files&action=Sel_File_ByCodeContents&CodeContents=" + CodeContents + "&Limit=" + Limit + "&IsDesc=" + IsDesc + "&Order=" + Order,
            type: "POST",
            dataType: "json",
            data: "",
            success: function(data, dataStatus) {
                ret = data;
            },
            timeout: 30000,
            async: false,
            error: function(request, error) {
            }
        });
        return ret;
    },
    // insert files
    Ins: function() {
        EnableLoading();
        $.ajax({
            url: "/Action/ProcessBackendAction.ashx?ActionObject=Files&action=Ins",
            type: "POST",
            dataType: "json",
            data: $("#frmIns_Files").serialize(),

            success: function(data) {
                if (data.status == "success") {
                    // $(".flexgripFiles").flexReload();
                    alert("Thêm file thành công.");

                } else if (data.status != "success") {
                    alert(1111);
                    //alert("Thêm Files lỗi: <font style='font-size:9px'>" + data.message + "</font>");

                }
                DisableLoading();
            },
            error: function(ex) {
            }
        });
    },
    Upd: function () {
        EnableLoading();
        $.ajax({
            url: "/Action/ProcessBackendAction.ashx?ActionObject=Files&action=Upd_ByCode",
            type: "POST",
            dataType: "json",
            data: $("#frmUpd_Files").serialize(),
            success: function(data) {
                if (data.status == "success") {
                    //$(".flexgripFiles").flexReload();
                    alert("Update Files thành công.");

                } else if (data.status != "success") {
                    alert("Update Files lỗi: <font style='font-size:9px'>" + data.message + "</font>");

                }
                DisableLoading();
            },
            error: function(ex) {
            }
        });
    },
    Del: function (ID) {
        EnableLoading();
        $.ajax({
            url: "/Action/ProcessBackendAction.ashx?ActionObject=Files&action=Del&IDFiles=" + ID,
            type: "POST",
            dataType: "json",
            data: $("#frmUpd_Files").serialize(),
            success: function(data) {
                if (data.status == "success") {
                    // $(".flexgripFiles").flexReload();
                    alert("Delete thành công.");

                } else if (data.status != "success") {
                    alert("Delete lỗi: <font style='font-size:9px'>" + data.message + "</font>");

                }
                DisableLoading();
            },
            error: function(ex) {
            }
        });
    },
    Sel_ByAllIDlang: function() {
        var ret;
        jQuery.ajax({
            url: "/Action/ProcessFrontendAction.ashx?ActionObject=Files&action=Sel_ByIDLang",
            type: "POST",
            dataType: "json",
            data: "",
            success: function(data, dataStatus) {
                ret = data;
            },
            timeout: 30000,
            async: false,
            error: function(request, error) {
            }
        });
    },
    Sel_ByCode_ByIDLang: function(Code, IDLang) {
        $.ajax({
            url: "/Action/ProcessBackendAction.ashx?ActionObject=Files&action=Sel_ByCode_ByIDLang&Code=" + Key + "&IDLang=" + IDLang,
            type: "POST",
            dataType: "json",
            data: $("#frmUpd_Files").serialize(),
            success: function(data) {
                if (data.status == "success") {
                } else if (data.status != "success") {
                    alert("lỗi: <font style='font-size:9px'>" + data.message + "</font>");

                }
            },
            error: function(ex) {
            }
        });
    },
    Sel_Files_ByCodeAlbums: function(CodeAlbums) {
        $.ajax({
            url: "/Action/ProcessBackendAction.ashx?ActionObject=Files&action=Sel_Files_ByCodeAlbums&Code=" + CodeAlbums,
            type: "POST",
            dataType: "json",
            data: $("#frmUpd_Files").serialize(),
            success: function(data) {
                if (data.status == "success") {
                } else if (data.status != "success") {
                    alert("lỗi: <font style='font-size:9px'>" + data.message + "</font>");

                }
            },
            error: function(ex) {
            }
        });
    },
    Sel_File_ByCodeContents: function(CodeContent) {
        $.ajax({
            url: "/Action/ProcessBackendAction.ashx?ActionObject=Files&action=Sel_File_ByCodeContents&Code=" + CodeContent,
            type: "POST",
            dataType: "json",
            data: $("#frmUpd_Files").serialize(),
            success: function(data) {
                if (data.status == "success") {
                } else if (data.status != "success") {
                    alert("lỗi: <font style='font-size:9px'>" + data.message + "</font>");

                }
            },
            error: function(ex) {
            }
        });
    },
    Sel_ByCodeAlbum_ByIDLang: function(CodeContent, IDLang) {
        $.ajax({
            url: "/Action/ProcessBackendAction.ashx?ActionObject=Files&action=Sel_ByCodeAlbum_ByIDLang&Code=" + CodeContent + "&IDLang=" + IDLang,
            type: "POST",
            dataType: "json",
            data: $("#frmUpd_Files").serialize(),
            success: function(data) {
                if (data.status == "success") {
                } else if (data.status != "success") {
                    alert("lỗi: <font style='font-size:9px'>" + data.message + "</font>");

                }
            },
            error: function(ex) {
            }
        });
    },
    Sel_ByType_ByIDLang: function(Type, IDLang) {
        $.ajax({
            url: "/Action/ProcessBackendAction.ashx?ActionObject=Files&action=Sel_ByType_ByIDLang&Type=" + Type + "&IDLang=" + IDLang,
            type: "POST",
            dataType: "json",
            data: $("#frmUpd_Files").serialize(),
            success: function(data) {
                if (data.status == "success") {
                } else if (data.status != "success") {
                    alert("lỗi: <font style='font-size:9px'>" + data.message + "</font>");

                }
            },
            error: function(ex) {
            }
        });
    },
    Sel_ByType_ByStatus_ByIDLang: function(Status, IDLang) {
        $.ajax({
            url: "/Action/ProcessBackendAction.ashx?ActionObject=Files&action=Sel_ByType_ByStatus_ByIDLang&Status=" + Status + "&IDLang=" + IDLang,
            type: "POST",
            dataType: "json",
            data: $("#frmUpd_Files").serialize(),
            success: function(data) {
                if (data.status == "success") {
                } else if (data.status != "success") {
                    alert("lỗi: <font style='font-size:9px'>" + data.message + "</font>");

                }
            },
            error: function(ex) {
            }
        });
    },
    Sel_Ext_ByKeyCodeFiles_ByIDLang: function(KeyCode, IDLang) {
        $.ajax({
            url: "/Action/ProcessBackendAction.ashx?ActionObject=Files&action=Sel_Ext_ByKeyCodeFiles_ByIDLang&KeyCode=" + KeyCode + "&IDLang=" + IDLang,
            type: "POST",
            dataType: "json",
            data: $("#frmUpd_Files").serialize(),
            success: function(data) {
                if (data.status == "success") {
                } else if (data.status != "success") {
                    alert("lỗi: <font style='font-size:9px'>" + data.message + "</font>");

                }
            },
            error: function(ex) {
            }
        });
    },
    Sel_Ext_ByKeyCodeAlbums_ByIDLang: function(KeyCodeAlbums, IDLang) {
        $.ajax({
            url: "/Action/ProcessBackendAction.ashx?ActionObject=Files&action=Sel_Ext_ByKeyCodeAlbums_ByIDLang&KeyCodeAlbums=" + KeyCodeAlbums + "&IDLang=" + IDLang,
            type: "POST",
            dataType: "json",
            data: $("#frmUpd_Files").serialize(),
            success: function(data) {
                if (data.status == "success") {
                } else if (data.status != "success") {
                    alert("lỗi: <font style='font-size:9px'>" + data.message + "</font>");

                }
            },
            error: function(ex) {
            }
        });
    },
    Upd_ByID_ByStatus: function (ID, Status) {
        EnableLoading();
        $.ajax({
            url: "/Action/ProcessBackendAction.ashx?ActionObject=Files&action=Upd_ByID_ByStatus&ID=" + ID + "&Status=" + Status,
            type: "POST",
            dataType: "json",
            data: $("#frmUpd_Files").serialize(),
            success: function(data) {
                if (data.status == "success") {
                } else if (data.status != "success") {
                    alert("lỗi: <font style='font-size:9px'>" + data.message + "</font>");

                }
                DisableLoading();
            },
            error: function(ex) {
            }
        });
    },
    Upd_ByID_ByType: function (ID, Type) {
        EnableLoading();
        $.ajax({
            url: "/Action/ProcessBackendAction.ashx?ActionObject=Files&action=Upd_ByID_ByType&ID=" + ID + "&Status=" + Status,
            type: "POST",
            dataType: "json",
            data: $("#frmUpd_Files").serialize(),
            success: function(data) {
                if (data.status == "success") {
                } else if (data.status != "success") {
                    alert("lỗi: <font style='font-size:9px'>" + data.message + "</font>");

                }
                DisableLoading();
            },
            error: function(ex) {
            }
        });
    },
    Upd_ByID_ByDisable: function (ID, Disable) {
        EnableLoading();
        $.ajax({
            url: "/Action/ProcessBackendAction.ashx?ActionObject=Files&action=Upd_ByID_ByDisable&ID=" + ID + "&Disable=" + Disable,
            type: "POST",
            dataType: "json",
            data: $("#frmUpd_Files").serialize(),
            success: function(data) {
                if (data.status == "success") {
                } else if (data.status != "success") {
                    alert("lỗi: <font style='font-size:9px'>" + data.message + "</font>");

                }
                DisableLoading();
            },
            error: function(ex) {
            }
        });
    },
    Upd_Status_ByCode_ByLang: function (Status, Code, IDLang) {
        EnableLoading();
        $.ajax({
            url: "/Action/ProcessBackendAction.ashx?ActionObject=Files&action=Upd_Status_ByCode_ByLang&Status=" + Status + "&Code=" + Code + "&IDLang=" + IDLang,
            type: "POST",
            dataType: "json",
            data: $("#frmUpd_Files").serialize(),
            success: function(data) {
                if (data.status == "success") {
                } else if (data.status != "success") {
                    alert("lỗi: <font style='font-size:9px'>" + data.message + "</font>");

                }
                DisableLoading();
            },
            error: function(ex) {
            }
        });
    },
    Upd_Type_ByCode_ByLang: function (Type, Code, IDLang) {
        EnableLoading();
        $.ajax({
            url: "/Action/ProcessBackendAction.ashx?ActionObject=Files&action=Upd_Type_ByCode_ByLang&Type=" + Type + "&Code=" + Code + "&IDLang=" + IDLang,
            type: "POST",
            dataType: "json",
            data: $("#frmUpd_Files").serialize(),
            success: function(data) {
                if (data.status == "success") {
                } else if (data.status != "success") {
                    alert("lỗi: <font style='font-size:9px'>" + data.message + "</font>");

                }
                DisableLoading();
            },
            error: function(ex) {
            }
        });
    },
    Upd_Disable_ByCode_ByLang: function (Disable, Code, IDLang) {
        EnableLoading();
        $.ajax({
            url: "/Action/ProcessBackendAction.ashx?ActionObject=Files&action=Upd_Disable_ByCode_ByLang&Disable=" + Disable + "&Code=" + Code + "&IDLang=" + IDLang,
            type: "POST",
            dataType: "json",
            data: $("#frmUpd_Files").serialize(),
            success: function(data) {
                if (data.status == "success") {
                } else if (data.status != "success") {
                    alert("lỗi: <font style='font-size:9px'>" + data.message + "</font>");

                }
                DisableLoading();
            },
            error: function(ex) {
            }
        });
    },
    Del_ByCode: function (Key) {
        EnableLoading();
        $.ajax({
            url: "/Action/ProcessBackendAction.ashx?ActionObject=Files&action=Del_ByCode&Code=" + Key,
            type: "POST",
            dataType: "json",
            data: $("#frmUpd_Files").serialize(),
            success: function(data) {
                if (data.status == "success") {
                    // $(".flexgripFiles").flexReload();
                    alert("Delete thành công.");

                } else if (data.status != "success") {
                    alert("Delete lỗi: <font style='font-size:9px'>" + data.message + "</font>");

                }
                DisableLoading();
            },
            error: function(ex) {
            }
        });
    },
    Sel_ByID: function(ID) {
        $.ajax({
            url: "/Action/ProcessBackendAction.ashx?ActionObject=Files&action=Del&IDFiles=" + ID,
            type: "POST",
            dataType: "json",
            data: $("#frmUpd_Files").serialize(),
            success: function(data) {
                if (data.status == "success") {
                    // $(".flexgripFiles").flexReload();
                    alert("Delete thành công.");

                } else if (data.status != "success") {
                    alert("Delete lỗi: <font style='font-size:9px'>" + data.message + "</font>");

                }
            },
            error: function(ex) {
            }
        });
    },
    //chu y return du lieu
    Sel_ByCode: function(Code) {
        var ret;
        jQuery.ajax({
            url: "/Action/ProcessBackendAction.ashx?ActionObject=Files&action=Sel_ByCode&Code=" + Code + "",
            type: "POST",
            dataType: "json",
            data: "",
            success: function(data, dataStatus) {
                ret = data;

            },
            timeout: 30000,
            async: false,
            error: function(request, error) {
            }
        });
        return ret;
    },
}