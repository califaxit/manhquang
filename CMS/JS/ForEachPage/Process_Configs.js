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

function Init_ConfigsTable() {
    InitLotusTable("#checkBll",
        {
            'url': sys_CommonType.URL_CMS + '/Action/ProcessBackendAction.ashx?ActionObject=Configs&action=Sel',
            'Col_Key': 'ID',
            'Col_Image': 'Image',
            'Path_Image': sys_CommonType.URL_CMS + '/Action/ProcessImageServiceAction.ashx?W=60&H=60&Scale=crop&Img=',
            'pageLength': 14,

            columns: [
                { data: 'ID' },
                { data: 'AccessKey' },
                { data: 'Value' },
                { data: 'Status' },
                { data: 'Type' },
                { data: 'Group' }
            ]
        }
    );
}

function LotusTable_EditRow(keyRow) {
    if (keyRow > 0) {
        var data = ConfigsBO.Sel_ByID(keyRow);
        var callbacks = $.Callbacks();
        callbacks.add(sys_LoadPage('Upd_Configs.htm', data));
        callbacks.add(Init_Dialog_Upd());
        callbacks.fire();
    }
}

function LotusTable_RemoveRow(keyRow) {

    var conf = confirm('Bạn có chắc muốn xóa record này không ?' + keyRow);
    if (conf) {
        ConfigsBO.Del_ByID(keyRow);
    }
}

function LotusTable_AddRow() {
    var callbacks = $.Callbacks();
    callbacks.add(sys_LoadPage('Ins_Configs.htm'));
    callbacks.add(Init_Dialog_Ins());
    callbacks.fire();
}