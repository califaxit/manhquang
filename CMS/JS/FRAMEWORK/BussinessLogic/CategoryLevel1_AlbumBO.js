
var CategoryLevel1_AlbumBO = {
    Sel_ByCodeAlbum_ByIDLang: function (Code, IDLang) {
        if (typeof (IDLang) == 'undefine')
        {
            IDLang = sys_CUR_LANG;
        }
        var ret;
        jQuery.ajax({
            url: "/Action/ProcessBackendAction.ashx?ActionObject=Album_CategoryLevel1&action=Sel_ByCodeAlbum_ByIDLang&CodeContents=" + Code + "&IDLang=" + IDLang,
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
    }


}