/**
 * @author Nam Chu
 * @created 01/07/15
 */
function Init_Dialog_Ins() {
    setTimeout('$("#tabs").tabs();', 1000);
}

function Init_Dialog_Upd() {
    setTimeout('$("#tabs").tabs();', 1000);
}

function Init_LanguagesTable() {
    InitLotusTable("#checkBll",
        {
            'url': sys_CommonType.URL_CMS + '/Action/ProcessBackendAction.ashx?ActionObject=Languages&action=Sel',
            'Col_Key': 'ID',
            'Col_Image': 'Image',
            'Path_Image': sys_CommonType.URL_CMS + '/Action/ProcessImageServiceAction.ashx?W=60&H=60&Scale=crop&Img=',
            'pageLength': 14,
            columns: [
                { data: 'ID' },
                { data: 'NameLang' },
                { data: 'Directory' },
                { data: 'Filename' },
                { data: 'Status' },
                { data: 'Type' }
            ]
        });
}

function LotusTable_EditRow(keyRow) {
    if (keyRow > 0) {
        var data = LanguagesBO.Sel_ByID(keyRow);
        var callbacks = $.Callbacks();
        callbacks.add(sys_LoadPage('Upd_Languages.htm', data));
        callbacks.add(Init_Dialog_Upd());
        callbacks.fire();
    }
}

function LotusTable_RemoveRow(keyRow) {

    var conf = confirm('Bạn có chắc muốn xóa record này không ?' + keyRow);
    if (conf) {
        LanguagesBO.Del_ByID(keyRow);
    }
}

function LotusTable_AddRow() {
    var callbacks = $.Callbacks();
    callbacks.add(sys_LoadPage('Ins_Languages.htm'));
    callbacks.add(Init_Dialog_Ins());
    callbacks.fire();
}