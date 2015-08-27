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

function Init_PermitsTable() {
    InitLotusTable("#checkBll",
    {
        'url': sys_CommonType.URL_CMS + '/Action/ProcessBackendAction.ashx?ActionObject=Permits&action=Sel',
        'Col_Key': 'ID',
        'pageLength': 14,
        columns: [
            { data: 'ID' },
            { data: 'Name' },
            { data: 'SystemKey' },
            { data: 'IsAdmin' },
            { data: 'IsContent' },
            { data: 'IsPartner' },
            { data: 'Type' },
            { data: 'Status' }
        ]
    });
}

function LotusTable_AddRow() {
    var callbacks = $.Callbacks();
    callbacks.add(sys_LoadPage('Ins_Permits.htm'));
    callbacks.add(Init_Dialog_Ins());
    callbacks.fire();
}

function LotusTable_EditRow(keyRow) {
    if (keyRow > 0) {
        var data = PermitsBO.Sel_ByID(keyRow);
        var callbacks = $.Callbacks();
        callbacks.add(sys_LoadPage('Upd_Permits.htm', data));
        callbacks.add(Init_Dialog_Upd());
        callbacks.fire();
    }
}

function LotusTable_RemoveRow(keyRow) {
    var conf = confirm('Bạn có chắc muốn xóa record này không ?' + keyRow);
    if (conf) {
        PermitsBO.Del_ByID(keyRow);
    }
}