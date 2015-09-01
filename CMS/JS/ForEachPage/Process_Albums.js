/*############################################################################*/
/*  PROCESSING PROCESSING PROCESSING PROCESSING PROCESSING PROCESSING         */
/*____________________________________________________________________________*/
// Code: QuyDq
// Date: 21/06/2015
// Template:
/*____________________________________________________________________________*/
// Info: View 
/*############################################################################*/
function Init_LotusTable() {

    //oTable.fnDestroy();
    InitLotusTable("#checkBll_Albums",
        {
            'url': sys_CommonType.URL_CMS + '/Action/ProcessBackendAction.ashx?ActionObject=Albums&action=Sel_ByIDLang&IDLang=' + sys_CUR_LANG,
            'Col_Key': 'Code',
            'Col_Image': 'Image',

            'Path_Image': sys_CommonType.URL_CMS + '/Action/ProcessImageServiceAction.ashx?W=60&H=60&Scale=crop&Img=',
            'pageLength': 14,

            columns: [
                { data: 'Title' },
                { data: 'IDLang' },
                { data: 'Code' },
                { data: 'Status' }
            ]
        }
    );


}

function LotusTable_AddRow() {
    // Đưa các hàm cần gọi vào hàm callback để các hàm chạy theo thứ tự lần lượt thay vì settimeout không có lợi
    var callbacks = $.Callbacks();
    callbacks.add(sys_LoadPage('Ins_Albums.htm'));
    //callbacks.add(FillCategoryLevel1DataToDropdowList('#Div_CategoryLevel1'));
    //callbacks.add(FillAlbumDataToDropdowList('#Div_CodeAlbum'));
    callbacks.add(Init_Dialog_Ins());
    callbacks.fire();
}

function LotusTable_EditRow(KeyRow) {
    if (KeyRow > 0) {
        var data = AlbumsBO.Sel_ByCode(KeyRow);


        var callbacks = $.Callbacks();
        callbacks.add(sys_LoadPage('Upd_Albums.htm', data));
        // alert(data.data[0].CodeAlbums);
        //callbacks.add(FillAlbumsDataToDropdowList_EditForm('#Div_CodeAlbum', data[0].data.CodeAlbums));
        callbacks.add(Init_Dialog_Upd());
        callbacks.fire();

    }
}

function LotusTable_RemoveRow(Key) {

    var conf = confirm('Bạn có chắc muốn xóa record này không ?');
    if (conf) {

        Del_Albums_ByCode(Key);
    }

}

function LotusTable_RemoveSelectedRows(ListIDRow) {

    var conf = confirm('Bạn có chắc muốn xóa những record này không ?');
    if (conf) {
        //Del_Albums(IDRow);
        alert("LotusTable_RemoveSelectedRows : " + ListIDRow);
    }

}

function Init_Dialog_Ins() {
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
    $('.txtInfo').LotusEditor();
}

function Init_Dialog_Upd() {
    $('#divtabs').LotusTabs();
    $('select, .check, .check :checkbox, input:radio, input:file').uniform();
    $("#dtpDateCreated").datepicker({
        appendText: '(dd-mm-yyyy)',
        dateFormat: 'dd-mm-yy'
    });

    $(".datepicker").datepicker({
        appendText: '(dd-mm-yyyy)',
        dateFormat: 'dd-mm-yy'
    });
    $('.txtInfo').LotusEditor();
    setTimeout('$("#tabs").tabs();', 1000);
    setTimeout('Change_Multi_TextareaToTinyMCE(".txt_Info");', 2000);
    setTimeout('$("#txt_CreateDate").datepicker({ dateFormat: "dd/mm/yy" });', 1000);
}

function OpenDialog_Ins_Albums() {
    var title = "";
    var width = 1200;
    var height = 600;
    if ($("#PositionShowDialog").length <= 0) {
        $("body").append('<div id="#PositionShowDialog" style="display:none; overflow-x:hidden; overflow-y:scroll;" title="' + title + '"></div>');
    }

    $("#PositionShowDialog").setTemplateURL('../../Templates/Ins_Albums.htm');
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
            'Cancel': function() {
                $(this).dialog("close");
            },

            'Save': function() {
                Save_Multi_TinyMCE("txt_Info_Lang", sys_NumLang);
                Ins_Albums();
                $(this).dialog("close");
            }
        },
        close: function() {

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
function Ins_Albums() {
    AlbumsBO.Ins();
}

function Upd_Albums() {
    AlbumsBO.Upd_ByCode();
}

function Del_Albums_ByCode(key) {
    AlbumsBO.Del_ByCode(key);
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

function OpenDialog_Upd_Albums(IDAlbums) {
    var title = "";
    var width = 1200;
    var height = 1350;
    if ($("#PositionShowDialog").length <= 0) {
        $("body").append('<div id="PositionShowDialog" style="display:none; overflow-x:hidden; overflow-y:scroll;" title="' + title + '"></div>');
    }

    Fill_Albums_Dialog_Upd(IDAlbums);

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
            'Đóng': function() {
                $(this).dialog('close');
            },
            'Sửa': function() {
                Save_Multi_TinyMCE("txt_Info_Lang", sys_NumLang);
                Upd_Albums(IDAlbums);

                $(this).dialog('close');
            }
        },
        close: function() {

        }
    });
}

function Fill_Albums_Dialog_Upd(IDAlbums) {

    if (IDAlbums > 0) {
        jQuery.ajax({
            url: "/Action/ProcessBackendAction.ashx?ActionObject=Albums&action=Sel_all_ByCode&IDAlbums=" + IDAlbums,
            type: "POST",
            dataType: "json",
            data: "",
            success: function(data, dataStatus) {
                $("#PositionShowDialog").html();
                $("#PositionShowDialog").setTemplateURL('../../Templates/Upd_Albums.htm');
                $("#PositionShowDialog").setParam('NumLang', sys_NumLang); //sys_NumLang : trong file SystemConfig.js

                $("#PositionShowDialog").setParam('Lang', sys_Lang);

                $("#PositionShowDialog").processTemplate(data);
            },
            timeout: 30000,
            error: function(request, error) {
            }
        });
    }
}