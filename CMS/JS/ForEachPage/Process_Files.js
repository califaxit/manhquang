/*############################################################################*/
/*  PROCESSING PROCESSING PROCESSING PROCESSING PROCESSING PROCESSING         */
/*____________________________________________________________________________*/
// Code: Do Quang Quy
// Date: 14/06/2015
// Template:
/*____________________________________________________________________________*/
// Info: Xu ly Load 
/*############################################################################*/
/////////////dddd//////////////////

function Init_LotusTable() {
    

    InitLotusTable("#checkBll1",
        {

            'url': sys_CommonType.URL_CMS + '/Action/ProcessBackendAction.ashx?ActionObject=Files&action=Sel_ByIDLang&IDLang=' + sys_CUR_LANG,
            'Col_Key': 'Files_Code',
            'Col_Image': 'Files_Image',
            'Path_Image': sys_CommonType.URL_CMS + '/Action/ProcessImageServiceAction.ashx?W=60&H=60&Scale=crop&Img=',
            'pageLength': 14,

            columns: [

                        { data: 'Files_Title' },
                        { data: 'Albums_Title' },
                        { data: 'Files_Code' },
                        { data: 'Albums_Code' }

            ]
        }
        );


}
/*###########################################################################*/
function LotusTable_AddRow() {
    // Đưa các hàm cần gọi vào hàm callback để các hàm chạy theo thứ tự lần lượt thay vì settimeout không có lợi
    var callbacks = $.Callbacks();
    callbacks.add(sys_LoadPage('Ins_Files.htm'));
    callbacks.add(FillAlbumsDataToDropdowList('#Div_CodeAlbum'));
    callbacks.add(Init_Dialog_Ins());
    callbacks.fire();
}

function LotusTable_EditRow(KeyRow) {
    if (KeyRow > 0) {
        var data = FilesBO.Sel_ByCode(KeyRow);
     

        var callbacks = $.Callbacks();
        callbacks.add(sys_LoadPage('Upd_Files.htm', data));
        // alert(data.data[0].CodeAlbums);
        //callbacks.add(FillAlbumsDataToDropdowList_EditForm('#Div_CodeAlbum', data[0].data.CodeAlbums));
       
        callbacks.add(Init_Dialog_Upd('#Div_CodeAlbum', data.data[0].CodeAlbums));
        callbacks.fire();

    }
}
/*###########################################################################*/
function LotusTable_RemoveRow(Key) {

    var conf = confirm('Bạn có chắc muốn xóa record này không ?');
    if (conf) {

        Del_ByCode(Key);
    }

}
/*###########################################################################*/
function Init_Dialog_Ins(divCategoryLevel1) {

    $('#divtabs').LotusTabs();
    $('select, .check, .check :checkbox, input:radio, input:file').uniform();
    $("#txtDateCreated").datepicker({
        appendText: '(dd-mm-yyyy)',
        dateFormat: 'dd-mm-yy'
    });

    $(".datepicker").datepicker({
        appendText: '(dd-mm-yyyy)',
        dateFormat: 'dd-mm-yy'
    });

    $('.txtInfo').LotusEditor();  // Phai dat cuoi cung vi dang loi, cau lenh dat sau khong chay nua
}
//function Init_Dialog_Ins(divListIDAlbum) {
//    FillAlbumsDataToDropdowList(divListIDAlbum);
//    setTimeout('$("#tabs").tabs();', 1000);
//    setTimeout('Change_Multi_TextareaToTinyMCE(".txt_Info");', 2000);

//    $("#txt_UploadDate").datepicker({ dateFormat: 'dd/mm/yy' });
//    setTimeout('InputNumber("#txt_Width", "#lbWarning_NumTableStandard");', 1000);
//    setTimeout('InputNumber("#txt_Height", "#lbWarning_NumTableStandard");', 1000);
//    //setTimeout('Change_Multi_TextareaToTinyMCE(".txt_Info");', 2000);
//}
/*###########################################################################*/

function Init_Dialog_Upd(divListIDAlbum, CodeAlbum) {
 
    //var CodeAlbum = $(divCodeAlbum).val();
    alert(CodeAlbum);
    FillAlbumsDataToDropdowList_EditForm(divListIDAlbum, CodeAlbum);// them vao de chay dropdowlist
    // them vao de chay tab
    $('#divtabs').LotusTabs();
    $('select, .check, .check :checkbox, input:radio, input:file').uniform();
     // date time de sau uniform
    $("#txtDateCreated").datepicker({
        appendText: '(dd-mm-yyyy)',
        dateFormat: 'dd-mm-yy'
    });

    $(".datepicker").datepicker({
        appendText: '(dd-mm-yyyy)',
        dateFormat: 'dd-mm-yy'
    });
    $('.txtInfo').LotusEditor();  // Active Text editer
    setTimeout('InputNumber("#txt_Height", "#lbWarning_NumTableStandard");', 1000);
    setTimeout('InputNumber("#txt_Width", "#lbWarning_NumTableStandard");', 1000);
    //setTimeout('Change_Multi_TextareaToTinyMCE(".txt_Info");', 2000);
}
/*###########################################################################*/
function FillAlbumsDataToDropdowList_ForLoadImage(div, type) {
    if (1 > 0) {
        jQuery.ajax({
            url: "/Action/ProcessBackendAction.ashx?ActionObject=Albums&action=Sel_all_ByIDLang",
            type: "POST",
            dataType: "json",
            data: "",
            success: function (data, dataStatus) {
                shtml = "<select id='txt_AlbumID' name='txt_AlbumID' style='width:200px'>";
                if (type == "[Show All]") {
                    shtml += "<option value='0' onclick='Reload_Flexgrid_ByAlbumID(0);' >[Show All]</option>";

                }
                if (data.Albums_Group.length >= 1) {
                    $(data.Albums_Group).each(function (i, item) {
                        shtml += "<option value='{0}'  onclick='Reload_Flexgrid_ByAlbumID({1});' >{2}</option>".format(item.Code, item.ID, item.Title);
                    });

                }
                $(div).html(shtml);
                shtml += "</select>";
            },
            timeout: 3000,
            error: function (request, error) {
            }
        });
    }
}
/*###########################################################################*/
function Reload_Flexgrid_ByAlbumID(AlbumID) {

    if (AlbumID == 0) //Load toan bo Image
    {
        $(".flexgripFiles").flexOptions({ url: "/Action/ProcessBackendAction.ashx?ActionObject=Files&action=Sel_Page_ForFlexigrid" });
        $(".flexgripFiles").flexReload();
    }
    else {

        var urlGetData = "/Action/ProcessBackendAction.ashx?ActionObject=Files&action=Sel_Page_ForFlexigrid_ByCode&AlbumsID={0}".format(AlbumID);
        $(".flexgripFiles").flexOptions({ url: urlGetData });
        $(".flexgripFiles").flexReload();

    }

}
/*###########################################################################*/
function FillAlbumsDataToDropdowList(div) {
    if (1 > 0) {
        jQuery.ajax({
            url: "/Action/ProcessBackendAction.ashx?ActionObject=Albums&action=Sel_ByAll",
            type: "POST",
            dataType: "json",
            data: "",
            success: function (data, dataStatus) {
                shtml = "<select id='txt_CodeAlbums' name='txt_CodeAlbums' style='width:200px'>";
                if (data.data.length >= 1) {
                    $(data.data).each(function (i, item) {
                        shtml += "<option value='{0}'>{1}</option>".format(item.Code, item.Title);
                    });

                }
                else {
                    shtml += "<option value='-1'>Chưa có Album</option>"
                }
                $(div).html(shtml);
                shtml += "</select>";
            },
            timeout: 3000,
            error: function (request, error) {
            }
        });
    }
}
/*###########################################################################*/
// khong can phai lay du lieu tu view
function FillAlbumsDataToDropdowList_EditForm(div, CodeAlbum) {
 
    if (1 > 0) {
        jQuery.ajax({
            url: "/Action/ProcessBackendAction.ashx?ActionObject=Albums&action=Sel_ByIDLang&IDLang=" + sys_CUR_LANG,
            type: "POST",
            dataType: "json",
            data: "",
            success: function (data, dataStatus) {
              
                shtml = "<select id='txt_CodeAlbums' name='txt_CodeAlbums' style='width:200px'>";
                if (data.data.length >= 1) {
                    $(data.data).each(function (i, item) {
                        if (item.Code == CodeAlbum) {

                            shtml += "<option value='"+item.Code+"'selected='selected'>"+item.Title+"</option>";//.format(item.Code, item.Title);
                        }
                        else
                            shtml += "<option value='" + item.Code + "'>"+item.Title+"</option>";//.format(item.Code, item.Title);
                    });

                }
                else { shtml += "<option value='-1'>Chưa có Album</option>"; }
                $(div).html(shtml);
                shtml += "</select>";
            },
            timeout: 3000,
            error: function (request, error) {
            }
        });
    }
}
/*###########################################################################*/
function OpenDialog_Ins_Files() {
    var title = "";
    var width = 1200;
    var height = 1350;
    if ($("#PositionShowDialog").length <= 0) {
        $("body").append('<div id="#PositionShowDialog" style="display:none; overflow-x:hidden; overflow-y:scroll;" title="' + title + '"></div>');
    }

    $("#PositionShowDialog").setTemplateURL('../../Templates/Ins_Files.htm');
    $("#PositionShowDialog").setParam('NumLang', sys_NumLang); //sys_NumLang : trong file SystemConfig.js
    $("#PositionShowDialog").setParam('Lang', sys_Lang);
    $("#PositionShowDialog").processTemplate();

    $("#PositionShowDialog").dialog({
        modal: true,
        width: width,
        height: height,
        resizable: false,
        //open: setTimeout('Change_TextareaToTinyMCE_OnPopup("#txt_InfoAlbumLang1");Change_TextareaToTinyMCE_OnPopup("#txt_InfoAlbumLang2");Change_TextareaToTinyMCE_OnPopup("#txt_InfoAlbumLang3");', 2000), // Cần phải có settimeout,

        show: {
            effect: "clip",
            duration: 1000
        },
        hide: {
            effect: "explode",
            duration: 1000
        },

        buttons: {
            'Cancel': function () {
                $(this).dialog("close");
            },

            'Save': function () {
                Save_Multi_TinyMCE("txt_Info_Lang", sys_NumLang);
                Ins_Files();
                $(this).dialog("close");
            }
        },
        close: function () {

        }
    });
}
/*____________________________________________________________________________*/
// Code: BUI MINH NGOC
// Date: 30/04/2013
// Template:
/*____________________________________________________________________________*/
// Info: Xu ly insert 
/*############################################################################*/
function Ins_Files() {
   
    FilesBO.Ins();
}
function Upd_Files() {

    FilesBO.Upd();
    alert("ok");
}
function Del_ByCode(Code) {

    FilesBO.Del_ByCode(Code);
}

function OpenDialog_Upd_Files(IDFiles) {
    var title = "";
    var width = 1200;
    var height = 1350;
    if ($("#PositionShowDialog").length <= 0) {
        $("body").append('<div id="PositionShowDialog" style="display:none; overflow-x:hidden; overflow-y:scroll;" title="' + title + '"></div>');
    }

    Fill_Files_Dialog_Upd(IDFiles);

    $("#PositionShowDialog").dialog({
        modal: true,
        width: width,
        //open: setTimeout('Change_TextareaToTinyMCE_OnPopup("#txt_InfoAlbumLang1")', 2000), // Cần phải có settimeout,
        
        height: height,
        resizable: false,
        show: {
            effect: "clip",
            duration: 1000
        },
        hide: {
            effect: "explode",
            duration: 1000
        },

        buttons: {
            'Đóng': function () {
                $(this).dialog('close');
            },
            'Sửa': function () {
                Save_Multi_TinyMCE("txt_Info_Lang", sys_NumLang);
                Upd_Files(IDFiles);
                
                $(this).dialog('close');
            }
        },
        close: function () {

        }
    });
}

/*======================================================================================*/
/*======================================================================================*/
function Fill_Files_Dialog_Upd(IDFiles) {

    if (IDFiles > 0) {
        jQuery.ajax({
            url: "/Action/ProcessBackendAction.ashx?ActionObject=Files&action=Sel_ByCode&IDFiles=" + IDFiles,
            type: "POST",
            dataType: "json",
            data: "",
            success: function (data, dataStatus) {

                $("#PositionShowDialog").setTemplateURL('../../Templates/Upd_Files.htm');
                $("#PositionShowDialog").setParam('NumLang', sys_NumLang); //sys_NumLang : trong file SystemConfig.js
                $("#PositionShowDialog").setParam('Lang', sys_Lang);

                $("#PositionShowDialog").processTemplate(data);
                html = $("#PositionShowDialog").html();
                html = Encoder.htmlDecode(html);
                $("#PositionShowDialog").html(html);

            },
            timeout: 30000,
            error: function (request, error) {
            }
        });
    }
}
/*======================================================================================*/
/*======================================================================================*/
