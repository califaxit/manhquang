
var CategoryLevel1_CategoryLevel2BO = {
    Sel_ByCodeCategoryLevel1_ByIDLang: function (Code, IDLang) {
       // alert(Code);
       // alert(IDLang);

        if (typeof (IDLang) == 'undefine')
        {
            IDLang = sys_CUR_LANG;
        }
        var ret;
        jQuery.ajax({
            url: "/Action/ProcessBackendAction.ashx?ActionObject=CategoryLevel1_CategoryLevel2&action=Sel_ByCodeCategoryLevel1_ByIDLang&CodeCategoryLevel1=" + Code + "&IDLang=" + IDLang,
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