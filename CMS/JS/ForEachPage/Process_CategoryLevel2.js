//============================================================================//
function Init_LotusTable() {
    //oTable.fnDestroy();

    InitLotusTable("#checkBll",
        {

            'url': sys_CommonType.URL_CMS + '/Action/ProcessBackendAction.ashx?ActionObject=CategoryLevel2&action=Sel_Ext_ByIDLang&IDLang=' + sys_CUR_LANG,
            'Col_Key': 'Code',
            'Col_Image': 'Image',
            'Path_Image': sys_CommonType.URL_CMS + '/Action/ProcessImageServiceAction.ashx?W=60&H=60&Scale=crop&Img=',
            'pageLength': 14,

            columns: [

                        { data: 'CategoryNameLevel2' },
                        { data: 'Info' },
                        { data: 'Code' },
                        { data: 'Type' }
            ]
        }
        );
}

function LotusTable_AddRow() {
    // Đưa các hàm cần gọi vào hàm callback để các hàm chạy theo thứ tự lần lượt thay vì settimeout không có lợi
    var callbacks = $.Callbacks();
    callbacks.add(sys_LoadPage('Ins_CategoryLevel2.htm'));
    callbacks.add(Init_Dialog_Ins());
    callbacks.fire();
}
function LotusTable_EditRow(KeyRow) {
    if (KeyRow > 0) {

        //alert("ok 1");

        var Data = CategoryLevel2BO.Sel_ByCode(KeyRow);
        var callbacks = $.Callbacks();
        callbacks.add(sys_LoadPage('Upd_CategoryLevel2.htm', Data));
        var IDAlbum = Data.data[0].IDAlbum;
       // alert("IDAlbum " + IDAlbum);

        callbacks.add(FillAlbumDataToComBoBox('#Div_Album', IDAlbum));
        // alert("ok 2");

        callbacks.add(Init_Dialog_Upd());
        callbacks.fire();

       // alert("ok 3");
    }
}

function LotusTable_RemoveRow(Key) {

    //alert("xoa ok 111111111111");
    // alert("Key process "+Key);

    var conf = confirm('Bạn có chắc muốn xóa record này không ?');
    if (conf) {
        CategoryLevel2BO.Del_ByCode(Key);
    }
}

function FillAlbumDataToComBoBox(div, FocusID) {
    // alert("focusID "+ FocusID);
    // alert("bbbbbbbbbbbbb ccccccccc");

    //  alert("FocusID" + FocusID);
    if (1 > 0) {
        jQuery.ajax({
            url: "/Action/ProcessBackendAction.ashx?ActionObject=Albums&action=Sel_ByIDLang",
            type: "POST",
            dataType: "json",
            data: "",
            success: function (data, dataStatus) {
                shtml = "<select id='cbbIDAlbum' name='cbbIDAlbum' style='width:200px'>";
                if (data.Albums_Group.length >= 1) {

                    shtml += "<option value='0'>[Chọn Album tài liệu]</option>";
                    $(data.Albums_Group).each(function (i, item) {

                        // alert("item album id " + item.ID);

                        if (item.ID == FocusID) {
                            shtml += "<option value='{0}' selected='selected'>{1}</option>".format(item.ID, item.Title);
                        }
                        else {
                            shtml += "<option value='{0}'>{1}</option>".format(item.ID, item.Title);
                        }
                    });
                }
                else {
                    shtml += "<option value='-1'>Chưa có Album</option>";
                }
                shtml += "</select>";
                //Div_ListIDRoom
                $(div).html(shtml);
            },
            timeout: 3000,
            error: function (request, error) {
            }
        });
    }
}

//============================================================================//
function Init_Dialog_Ins() {
    $('#divtabs').LotusTabs();
    $('.txtInfo').LotusEditor();
}
function Init_Dialog_Upd() {  

    $('#divtabs').LotusTabs();
    //  $('select, .check, .check :checkbox, input:radio, input:file').uniform();
    $('.txtInfo').LotusEditor();  // Active Text editer 
   
}

function OpenDialog_Ins_CategoryLevel2() {
    var title = "";
    var width = 1200;
    var height = 900;
    //if ($("#PositionShowDialog").length <= 0) {
    //    $("body").append('<div id="#PositionShowDialog" style="display:none; overflow-x:hidden; overflow-y:scroll;" title="' + title + '"></div>');
    //}
  
    $("#content > .wrapper").setTemplateURL('../../Templates/Ins_CategoryLevel2-1.htm');

    $("#content > .wrapper").setParam('NumLang', sys_NumLang); //sys_NumLang : trong file SystemConfig.js
    $("#content > .wrapper").setParam('Lang', sys_Lang);
    $("#content > .wrapper").processTemplate();
   

    //$("#PositionShowDialog").dialog({
    //    modal: true,
    //    width: width,
    //    height: height,
    //    resizable: false,
    //    //open: setTimeout('Change_TextareaToTinyMCE_OnPopup("#txt_InfoAlbumLang1");Change_TextareaToTinyMCE_OnPopup("#txt_InfoAlbumLang2");Change_TextareaToTinyMCE_OnPopup("#txt_InfoAlbumLang3");', 2000), // Cần phải có settimeout,
        
    //    show: {
    //        effect: "clip",
    //        duration: 1000
    //    },
    //    hide: {
    //        effect: "explode",
    //        duration: 1000
    //    },

    //    buttons: {
    //        'Cancel': function () {
    //            $(this).dialog("close");
    //        },

    //        'Save': function () {
    //            Save_Multi_TinyMCE("txt_Info_Lang", sys_NumLang);
    //            Ins_CategoryLevel2();
    //            $(this).dialog("close");
    //        }
    //    },
    //    close: function () {
          
    //    }
    //});

}

/*############################################################################*/
/*  PROCESSING PROCESSING PROCESSING PROCESSING PROCESSING PROCESSING         */
/*____________________________________________________________________________*/
// Code: BUI MINH NGOC
// Date: 30/04/2013
// Template:
/*____________________________________________________________________________*/
// Info: Xu ly insert 
/*############################################################################*/
function Ins_CategoryLevel2() {
  //  ShowLoading("#frmIns_CategoryLevel2");
    CategoryLevel2BO.Ins();

}
/*############################################################################*/
/*   FORM FORM FORM FORM FORM FORM FORM FORM FORM FORM FORM FORM FORM FORM    */
/*____________________________________________________________________________*/
// Code: BUI MINH NGOC
// Date: 30/04/2013
// Template:
/*____________________________________________________________________________*/
// Info: Mo form insert 
/*############################################################################*/

function OpenDialog_Upd_CategoryLevel2(IDCategoryLevel2) {
    var title = "";
    var width = 1200;
    var height = 900;
    if ($("#PositionShowDialog").length <= 0) {
        $("body").append('<div id="PositionShowDialog" style="display:none; overflow-x:hidden; overflow-y:scroll;" title="' + title + '"></div>');
    }   
    Fill_CategoryLevel2_Dialog_Upd(IDCategoryLevel2);    
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
                Upd_CategoryLevel2(IDCategoryLevel2);
                
                $(this).dialog('close');
            }
        },
        close: function () {

        }
    });
}

/*======================================================================================*/
/*======================================================================================*/
function Fill_CategoryLevel2_Dialog_Upd(IDCategoryLevel2) {

    if (IDCategoryLevel2 > 0) {
        jQuery.ajax({
            url: "/Action/ProcessBackendAction.ashx?ActionObject=CategoryLevel2&action=Sel_ByCode&IDCategoryLevel2=" + IDCategoryLevel2,
            type: "POST",
            dataType: "json",
            data: "",
            success: function (data, dataStatus) {

                $("#PositionShowDialog").setTemplateURL('../../Templates/Upd_CategoryLevel2.htm');
                $("#PositionShowDialog").setParam('NumLang', sys_NumLang); //sys_NumLang : trong file SystemConfig.js
                $("#PositionShowDialog").setParam('Lang', sys_Lang);
                $("#PositionShowDialog").processTemplate(data);
                
            },
            timeout: 30000,
            error: function (request, error) {
            }
        });
    }
}
/*======================================================================================*/
function FillAlbumDataToDropdowList(div, FocusID) {    
    if (1 > 0) {
        jQuery.ajax({
            url: "/Action/ProcessBackendAction.ashx?ActionObject=Albums&action=Sel_all_ByIDLang",
            type: "POST",
            dataType: "json",
            data: "",
            success: function (data, dataStatus) {

                shtml = "<select id='txt_IDAlbum' name='txt_IDAlbum' style='width:200px'>";
                if (data.Albums_Group.length >= 1) {

                    shtml += "<option value='0'>[Chọn Album tài liệu]</option>";                   
                    $(data.Albums_Group).each(function (i, item) {

                        if (item.ID == FocusID) {
                            shtml += "<option value='{0}' selected='selected'>{1}</option>".format(item.ID, item.Title);
                        }
                        else {
                            shtml += "<option value='{0}'>{1}</option>".format(item.ID, item.Title);
                        }

                    });
                }
                else {
                    shtml += "<option value='-1'>Chưa có Album</option>";
                }
                
                shtml += "</select>";

                //Div_ListIDRoom
                $(div).html(shtml);
                $("#txt_IDAlbum").uniform();
            },
            timeout: 3000,
            error: function (request, error) {
            }
        });
    }
}
/*======================================================================================*/
/*======================================================================================*/
function Upd_CategoryLevel2(IDCategoryLevel2) {
    CategoryLevel2BO.Upd(IDCategoryLevel2);

}
/*======================================================================================*/
/*======================================================================================*/

/*======================================================================================*/
/*======================================================================================*/

function Del_CategoryLevel2(IDCategoryLevel2) {

    CategoryLevel2BO.Del(IDCategoryLevel2);
}
function Dis_CategoryLevel2(IDCategoryLevel2) {

    CategoryLevel2BO.Dis(IDCategoryLevel2);
}
/*Khoi Ins CategoryLevel1*/
function FillAlbumDataToDropdowList(div) {
    $.ajax({
        type: "POST",
        url: "/Action/ProcessBackendAction.ashx?ActionObject=Albums&action=Sel_ByIDLang",
        dataType: "json",
        data: "",
        success: function (data) {
            $.each(data.Albums_Group, function (key, value) {
                $(div).append($('<option></option>').val(value.ID).html(value.Title));
            });
        },
        timeout: 3000,
        error: function (request, error) {
        }
    });
}
// Khoi UpdateByCode
function Upd_ByCode() {
    CategoryLevel2BO.Upd_ByCode();
}



