//===========================================================================================*/
function Init_LotusTable() {
    //oTable.fnDestroy();

    InitLotusTable("#checkBll",
        {

            'url': sys_CommonType.URL_CMS + '/Action/ProcessBackendAction.ashx?ActionObject=CategoryLevel1&action=Sel_Ext_ByIDLang&IDLang=' + sys_CUR_LANG,
            'Col_Key': 'CategoryLevel1_Code',
            'Col_Image': 'CategoryLevel1_Image',
            'Path_Image': sys_CommonType.URL_CMS + '/Action/ProcessImageServiceAction.ashx?W=60&H=60&Scale=crop&Img=',
            'pageLength': 14,

            columns: [

                        { data: 'CategoryLevel1_CategoryNameLevel1' },
                        { data: 'CategoryLevel1_Info' },
                        { data: 'CategoryLevel1_Code' },
                        { data: 'CategoryLevel1_Type' }

            ]
        }
        );
}

function LotusTable_AddRow() {
    // Đưa các hàm cần gọi vào hàm callback để các hàm chạy theo thứ tự lần lượt thay vì settimeout không có lợi
    var callbacks = $.Callbacks();
    callbacks.add(sys_LoadPage('Ins_CategoryLevel1.htm'));
    callbacks.add(FillCategoryLevel2DataToDropdowList("#Div_CategoryLevel1"));
    callbacks.add(Init_Dialog_Ins());
    callbacks.fire();
}
function LotusTable_EditRow(KeyRow) {
    if (KeyRow > 0) {

        //alert("ok 1");
        var Data = CategoryLevel1BO.Sel_ByCode(KeyRow);
        var callbacks = $.Callbacks();
        callbacks.add(sys_LoadPage('Upd_CategoryLevel1.htm', Data));
        var IDAlbum = Data.data[0].IDAlbum;
       // alert("IDAlbum "+IDAlbum);

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
        CategoryLevel1BO.Del_ByCode(Key);
    }
}
//*==========================================================================================*/
function Init_Dialog_Upd() { 
    $('#divtabs').LotusTabs();
  //  $('select, .check, .check :checkbox, input:radio, input:file').uniform();
    $('.txtInfo').LotusEditor();  // Active Text editer
}
/*======================================================================================*/
function Init_Dialog_Ins() {
    $('#divtabs').LotusTabs();
    $('.txtInfo').LotusEditor();
}
//function FillCategoryLevel2DataToDropdowList(div) {

//  //  alert("ok 1 222222222222222");

//    if (1 > 0) {
//        jQuery.ajax({
//            url: "/Action/ProcessBackendAction.ashx?ActionObject=CategoryLevel2&action=Sel_ByIDLang",
//            type: "POST",
//            dataType: "json",
//            data: "",
//            success: function (data, dataStatus) {
//                if (data.data.length >= 1) {
//                    shtml = "<select id='txt_CodeCategoryLevel2' name='txt_CodeCategoryLevel2' style='width:200px'>";

//                    $(data.data).each(function (i, item) {
//                        shtml += "<option value='{0}'>{1}</option>".format(item.Code, item.CategoryNameLevel2);
//                    });
//                    shtml += "</select>";
//                   // alert("shtml 99999999999999999999"+shtml);
//                    $(div).html(shtml);

//                }
//            },
//            timeout: 3000,
//            error: function (request, error) {
//            }
//        });
//    }
   
//}
/*======================================================================================*/
/*KhoiDT*/

function FillCategoryLevel2DataToDropdowList(div, CodeCategoryLevel1) {


    CodeCategoryLevel1 = '63512594178';
    var data = CategoryLevel2BO.Sel_ByIDLang(sys_CUR_LANG);
    var Focus = CategoryLevel1_CategoryLevel2BO.Sel_ByCodeCategoryLevel1_ByIDLang(CodeCategoryLevel1, sys_CUR_LANG);

    $(div).LotusCheckList({
        'Div': div,
        'DataName': 'ckbCodeCategoryLevel2',
        'Data': data.data,
        'Col_Title': 'CategoryNameLevel2',
        'Col_Key': 'Code',
        'Col_Image': 'Image',
        'Path_Image': sys_CommonType.URL + '/Action/ProcessImageServiceAction.ashx?W=60&H=60&Scale=crop&Img=',
        'PageLength': 14,
        'Focus': Focus.data,
        'KeyFocus': 'CodeCategoryLevel2'
    });
}
/*======================================================================================*/
function FillCategoryLevel2DataToDropdowList_EditForm(div, divCodeCategoryLevel2) {
    jQuery.ajax({
        url: "/Action/ProcessBackendAction.ashx?ActionObject=CategoryLevel2&action=Sel_ByIDLang",
        type: "POST",
        dataType: "json",
        data: "",
        success: function (data, dataStatus) {
            if (data.CategoryLevel2_Group.length >= 1) {
                shtml = "<select id='txt_CodeCategoryLevel2' name='txt_CodeCategoryLevel2' style='width:200px'>";

                $(data.CategoryLevel2_Group).each(function (i, item) {
                    if (item.Code == divCodeCategoryLevel2) {
                        shtml += "<option value='{0}' selected='selected'>{1}</option>".format(item.Code, item.CategoryNameLevel2);
                    }
                    else {
                        shtml += "<option value='{0}'>{1}</option>".format(item.Code, item.CategoryNameLevel2);
                    }
                });
                shtml += "</select>";
                $(div).html(shtml);
            }
        },
        timeout: 3000,
        error: function (request, error) {
        }
    });
}
/*======================================================================================*/
function FillAlbumDataToDropdowList(div, FocusID) {

   // alert("111111111111 99999999999999");

    if (1 > 0) {
        jQuery.ajax({
            url: "/Action/ProcessBackendAction.ashx?ActionObject=Albums&action=Sel_ByIDLang",
            type: "POST",
            dataType: "json",
            data: "",
            success: function (data, dataStatus) {
                shtml = "<select id='txt_IDAlbum' name='txt_IDAlbum' style='width:200px'>";
                if (data.Albums_Group.length >= 1) {

                    shtml += "<option value='0'>[Chọn Album tài liệu]</option>";
                    $(data.Albums_Group).each(function (i, item) {

                        if (item.ID == FocusID) {
                            shtml += "<option value='{0}' selected='selected'>{1}</option>".format(item.ID, item.Name);
                        }
                        else {
                            shtml += "<option value='{0}'>{1}</option>".format(item.ID, item.Name);
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
/*======================================================================================*/

function OpenDialog_Ins_CategoryLevel1() {
    var title = "";
    var width = 1200;
    var height = 900;
    if ($("#PositionShowDialog").length <= 0) {
        $("body").append('<div id="#PositionShowDialog" style="display:none; overflow-x:hidden; overflow-y:scroll;" title="' + title + '"></div>');
    }
 
    $("#PositionShowDialog").setTemplateURL('../../Templates/Ins_CategoryLevel1.htm');
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
                Ins_CategoryLevel1();
                $(this).dialog("close");
            }
        },
        close: function () {
          
        }
    });
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
function Ins_CategoryLevel1() {
  //  ShowLoading("#frmIns_CategoryLevel1");
    CategoryLevel1BO.Ins();

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

function OpenDialog_Upd_CategoryLevel1(IDCategoryLevel1) {
    var title = "";
    var width = 1200;
    var height = 1350;
    if ($("#PositionShowDialog").length <= 0) {
        $("body").append('<div id="PositionShowDialog" style="display:none; overflow-x:hidden; overflow-y:scroll;" title="' + title + '"></div>');
    }

    Fill_CategoryLevel1_Dialog_Upd(IDCategoryLevel1);

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
                Upd_CategoryLevel1(IDCategoryLevel1);
                
                $(this).dialog('close');
            }
        },
        close: function () {

        }
    });
}

/*======================================================================================*/
/*======================================================================================*/
function Fill_CategoryLevel1_Dialog_Upd(IDCategoryLevel1) {

    if (IDCategoryLevel1 > 0) {
        jQuery.ajax({
            url: "/Action/ProcessBackendAction.ashx?ActionObject=CategoryLevel1&action=Sel_ByCode&IDCategoryLevel1=" + IDCategoryLevel1,
            type: "POST",
            dataType: "json",
            data: "",
            success: function (data, dataStatus) {

                $("#PositionShowDialog").setTemplateURL('../../Templates/Upd_CategoryLevel1.htm');
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
/*======================================================================================*/
function Upd_CategoryLevel1(IDCategoryLevel1) {
    CategoryLevel1BO.Upd(IDCategoryLevel1);
}
/*======================================================================================*/
/*======================================================================================*/

/*======================================================================================*/
/*======================================================================================*/

function Del_CategoryLevel1(IDCategoryLevel1) {
    CategoryLevel1BO.Del(IDCategoryLevel1);
  
}
function Dis_CategoryLevel1(IDCategoryLevel1) {
    CategoryLevel1BO.Dis(IDCategoryLevel1);    
}
/*=======================================================================================*/

/*=======================================================================================*/
function FillAlbumDataToComBoBox(div, FocusID)
{
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

/*Khoi FillAlbumDataToDropdowList form Insert CategoryLevel1 */
//======================================================================================
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

/*=======================================================================================*/
function Upd_ByCode() {
    CategoryLevel1BO.Upd_ByCode();
}
