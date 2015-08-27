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

function Init_PermitDetailsTable() {
    InitLotusTable("#checkBll",
    {
        'url': sys_CommonType.URL_CMS + '/Action/ProcessBackendAction.ashx?ActionObject=PermitDetails&action=Sel',
        'Col_Key': 'ID',
        'pageLength': 14,
        columns: [
            { data: 'ID' },
            { data: 'IDPermit' },
            { data: 'Name' },
            { data: 'PageURL' },
            { data: 'Type' },
            { data: 'Status' }
        ]
    });
}

function LotusTable_AddRow() {
    var callbacks = $.Callbacks();
    callbacks.add(sys_LoadPage('Ins_PermitDetails.htm'));
    callbacks.add(Fill_Permit_DropdownList_Add_Form('#divPermit'));
    callbacks.add(Init_Dialog_Ins());
    callbacks.fire();
}

function LotusTable_EditRow(keyRow) {
    if (keyRow > 0) {
        var data = PermitDetailsBO.Sel_ByID(keyRow);
        //var permitsData = PermitsBO.Sel_All();
        var callbacks = $.Callbacks();
        callbacks.add(sys_LoadPage('Upd_PermitDetails.htm', data));
        callbacks.add(Fill_Permit_DropdownList_Upd_Form('#divPermit', data.data.IDPermit));
        callbacks.add(Init_Dialog_Upd());
        callbacks.fire();
    }
}

function LotusTable_RemoveRow(keyRow) {
    var conf = confirm('Bạn có chắc muốn xóa record này không ?' + keyRow);
    if (conf) {
        PermitDetailsBO.Del_ByID(keyRow);
    }
}

function Fill_Permit_DropdownList_Add_Form(div) {
    var data = PermitsBO.Sel();

    var shtml = "<select id='cbbIDPermit' name='cbbIDPermit' style='width:100%'>";
    if (data.data.length >= 1) {
        $(data.data).each(function(i, item) {
            shtml += "<option value='{0}'>ID:{1}-Name:{2}</option>".format(item.ID, item.ID, item.Name);
        });
    } else {
        shtml += "<option value='0'>[Chưa có thông tin]</option>";
    }
    shtml += "</select>";
    $(div).html(shtml);
}

function Fill_Permit_DropdownList_Upd_Form(div, idPermits) {
    var data = PermitsBO.Sel();
    var shtml = "<select id='cbbIDPermit' name='cbbIDPermit' style='width:100%'>";
    if (data.data.length >= 1) {
        $(data.data).each(function(i, item) {
            if (item.ID == idPermits) {
                shtml += "<option value='{0}' selected=\"selected\">ID:{1}-Name:{2}</option>".format(item.ID, item.ID, item.Name);
            } else {
                shtml += "<option value='{0}'>ID:{1}-Name:{2}</option>".format(item.ID, item.ID, item.Name);
            }
        });
    } else {
        shtml += "<option value='0'>[Chưa có thông tin]</option>";
    }
    shtml += "</select>";
    $(div).html(shtml);
}