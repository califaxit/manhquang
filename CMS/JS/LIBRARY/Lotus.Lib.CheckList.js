
$(function () {

    jQuery.fn.LotusCheckList = function (options) {
        var settings = $.extend({}, { default: 0 }, options);
        var dataName = settings.DataName;
        var url = settings.URL;
        var div = settings.Div;
        var data = settings.Data;
        
        if(data!= null) {
            var shtml = "";
            if (data.length >= 1) {
                shtml = "<div class='Lotus_Scrollbar'><div class='Checklistbox'>";
                shtml += "<input type='Checkbox' value='0' name='{0}[]'><label >Tất cả</label></br>".format(dataName);
                for (var i = 0; i < data.length; i++) {
                    if (settings.Focus.length >= 1) {
                        var isChecked = false;
                        for (var ii = 0; ii < settings.Focus.length; ii++) {
                            if (data[i].Code == settings.Focus[ii].CodeCategoryLevel1) {
                                isChecked = true;
                                break;
                            }
                        }
                        if(isChecked)
                            shtml += "<input type='Checkbox' checked='checked' value='" + data[i].Code + "' name='" + dataName + "[]' style='margin-right:5px;'/><label style='margin-top:-3'>" + data[i].CategoryNameLevel1 + " </label></br>";
                        else
                            shtml += "<input type='Checkbox' value='" + data[i].Code + "' name='" + dataName + "[]' style='margin-right:5px;'/><label style='margin-top:-3'>" + data[i].CategoryNameLevel1 + " </label></br>";
                    } else {
                        shtml += "<input type='Checkbox' value='" + data[i].Code + "' name='" + dataName + "[]' style='margin-right:5px;'/><label style='margin-top:-3'>" + data[i].CategoryNameLevel1 + " </label></br>";
                    }
                }
                
                shtml += "</div></div>";
            }
            $(div).setTemplate(shtml);
            $(div).processTemplate();
        } else {
            if ((typeof (url) === 'undefined') && (url === null)) {
                alert("Chưa gán nguồn dữ liệu");
            }
            else {
                data = LoadData(url);
            }
        }
    }
});

function LoadData(url) {

    alert(url);
}


////################################################################3
//<div class='Lotus_Scrollbar'>
//    <div class='Checklistbox'>
//         <input type='Checkbox' value='0' name='ckbCodeCategoryLevel2[]'><label >Tất cả</label></br>

//         {#foreach $T as Row}
//                {#if $T.Row.Code == $P.data[0].CodeCategoryLevel2}<input type='Checkbox' checked='checked' value='{$T.Row.Code}' name='ckbCodeCategoryLevel2[]' style='margin-right:5px;'/><label style='margin-top:-3'>{$T.Row.CategoryNameLevel2} </label></br>
//                {#else}<input type='Checkbox' value='{$T.Row.Code}' name='ckbCodeCategoryLevel2[]' style='margin-right:5px;'/><label style='margin-top:-3'>{$T.Row.CategoryNameLevel2} </label></br>

//                {#/if}{#if $T.Row.Code == $P.data[1].CodeCategoryLevel2}<input type='Checkbox' checked='checked' value='{$T.Row.Code}' name='ckbCodeCategoryLevel2[]' style='margin-right:5px;'/><label style='margin-top:-3'>{$T.Row.CategoryNameLevel2} </label></br>
//                {#else}<input type='Checkbox' value='{$T.Row.Code}' name='ckbCodeCategoryLevel2[]' style='margin-right:5px;'/><label style='margin-top:-3'>{$T.Row.CategoryNameLevel2} </label></br>

//                {#/if}{#if $T.Row.Code == $P.data[2].CodeCategoryLevel2}<input type='Checkbox' checked='checked' value='{$T.Row.Code}' name='ckbCodeCategoryLevel2[]' style='margin-right:5px;'/><label style='margin-top:-3'>{$T.Row.CategoryNameLevel2} </label></br>
//                {#else}<input type='Checkbox' value='{$T.Row.Code}' name='ckbCodeCategoryLevel2[]' style='margin-right:5px;'/><label style='margin-top:-3'>{$T.Row.CategoryNameLevel2} </label></br>

//                {#/if}

//          {#/for}

//        </div></div>