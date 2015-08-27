

function InitMenu(div_MenuLevel1, div_MenuLevel2) {

    OpenMenuLevel1(div_MenuLevel1, div_MenuLevel2);
}

function Module_CurrentUser(div) {
    var html = "";
    html = html + "	<a title='' class='leftUserDrop'>	";
    html = html + "	   <img src='/Images/user.png' alt='' /><span><strong>3</strong></span></a><span>Eugene</span>	";
    html = html + "	<ul class='leftUser'>	";
    html = html + "	   <li><a href='#' title='' class='sProfile'>My profile</a></li>	";
    html = html + "	   <li><a href='#' title='' class='sMessages'>Messages</a></li>	";
    html = html + "	   <li><a href='#' title='' class='sSettings'>Settings</a></li>	";
    html = html + "	   <li><a href='#' title='' class='sLogout'>Logout</a></li>	";
    html = html + "	</ul>	";

    $(div).html(html);

}


function OpenMenuLevel1(divMenuLevel1, divMenuLevel2) {

    var html = "";
    html = html + '	            <li><a id="id1" onclick="OpenMenuLevel2_1(\'' + divMenuLevel2 + '\',\'#id1\' )" title="">	';
    html = html + '	                    <img src="/Images/icons/mainnav/dashboard.png" alt="" /><span>{sys_GetText(1,\'XXX\');}</span></a></li>	';
    html = html + '	            <li><a onclick="OpenMenuLevel2_2(\'' + divMenuLevel2 + '\')"  title="">	';
    html = html + '	                    <img src="/Images/icons/mainnav/ui.png" alt="" /><span>{sys_GetText_Static(2,\'XXX\')}</span></a>	';
    html = html + '	            </li>';
    html = html + '	            <li><a onclick="OpenMenuLevel2_3(\'' + divMenuLevel2 + '\')"  title="">	';
    html = html + '	                    <img src="/Images/icons/mainnav/forms.png" alt="" /><span>{sys_GetText_Static(3,\'XXX\')}</span></a>	';
    html = html + '	            </li>';
    html = html + '	            <li><a onclick="OpenMenuLevel2_4(\'' + divMenuLevel2 + '\')" title="">	';
    html = html + '	                    <img src="/Images/icons/mainnav/messages.png" alt="" /><span>{sys_GetText_Static(4,\'XXX\')}</span></a></li>	';
    html = html + '	            <li><a onclick="OpenMenuLevel2_5(\'' + divMenuLevel2 + '\')" title="">	';
    html = html + '	                    <img src="/Images/icons/mainnav/statistics.png" alt="" /><span>{sys_GetText_Static(5,\'XXX\')}</span></a></li>	';
    html = html + '	            <li><a onclick="OpenMenuLevel2_6(\'' + divMenuLevel2 + '\')" title="" class="active">	';
    html = html + '	                    <img src="/Images/icons/mainnav/tables.png" alt="" /><span>{sys_GetText_Static(6,\'XXX\')}</span></a>	';
    html = html + '	            </li>';
    html = html + '	            <li><a onclick="OpenMenuLevel2_7(\'' + divMenuLevel2 + '\')" title="">	';
    html = html + '	                    <img src="/Images/icons/mainnav/other.png" alt="" /><span>{sys_GetText_Static(7,\'XXX\')}</span></a>	';
    html = html + '	            </li>';


    $(divMenuLevel1).setTemplate(html);

    $(divMenuLevel1).processTemplate();



}

function OpenMenuLevel2_1(div) {
    $(div).hide();
    $(div).show(300);
    $(div).html();// xóa trắng
    var html = "";

    html = html + '	                    <div class="divider"><span></span></div>	';
    html = html + '	                    <div id="general">	';
    html = html + '	                        <ul class="subNav">	';
    html = html + '	                            <li><a onclick="sys_LoadPage(\'Lst_Contents.htm\');" title=""><span class="icos-frames"></span>Danh sách</a></li>	';
    html = html + '	                            <li><a onclick="sys_LoadPage(\'Ins_Contents.htm\');" title=""><span class="icos-frames"></span>{sys_GetText_Static(39,\'mặc định\')}</a></li>	';
    html = html + '	                            <li><a onclick="sys_LoadPage(\'Lst_CategoryLevel1.htm\');" title=""><span class="icos-frames"></span>Danh sách</a></li>	';
    html = html + '	                            <li><a href="/PagesAspx/CategoryLevel2_Manager.aspx" title=""><span class="icos-bullseye"></span>{sys_GetText_Static(10,\'XXX\')}</a></li>	';
    html = html + '	                            <li><a href="tables_sortable.html" title=""><span class="icos-transfer"></span>{sys_GetText_Static(11,\'XXX\')}</a></li>	';
    html = html + '	                        </ul>	';
    html = html + '	                        <div class="divider"><span></span></div>	';
    html = html + '	                    </div>	';


    $(div).setTemplate(html);

    $(div).processTemplate();


    var options = { percent: 0 };
    //$(div).toggle("Drop");
    
}
function OpenMenuLevel2_2(div) {
    $(div).hide();
    $(div).show(300);

    $(div).html();// xóa trắng

    var html = "";

    html = html + '	                    <div class="divider"><span></span></div>	';
    html = html + '	                    <div id="general">	';
    html = html + '	                        <ul class="subNav">	';
    html = html + '	                            <li><a onclick="sys_LoadPage(\'Lst_CategoryLevel1.htm\');" title=""><span class="icos-frames"></span>ListCat1</a></li>	';
    html = html + '	                            <li><a onclick="sys_LoadPage(\'Ins_CategoryLevel1.htm\');" title=""><span class="icos-frames"></span>Thêm mới</a></li>	';
    html = html + '	                            <li><a onclick="sys_LoadPage(\'\');" title=""><span class="icos-frames"></span>XXX</a></li>	';
    html = html + '	                            <li><a href="tables_sortable.html" title=""><span class="icos-transfer"></span>{sys_GetText_Master(43)}</a></li>	';
    html = html + '	                        </ul>	';
    html = html + '	                        <div class="divider"><span></span></div>	';
    html = html + '	                    </div>	';

    $(div).setTemplate(html);
    $(div).processTemplate();
    var options = { percent: 0 };
}
function OpenMenuLevel2_3(div) {
    $(div).hide();
    $(div).show(300);

    $(div).html();// xóa trắng
    var html = "";

    html = html + '	                    <div class="divider"><span></span></div>	';
    html = html + '	                    <div id="general">	';
    html = html + '	                        <ul class="subNav">	';
    html = html + '	                            <li><a onclick="sys_LoadPage(\'Lst_CategoryLevel2.htm\');" title=""><span class="icos-frames"></span>ListCat2</a></li>	';
    html = html + '	                            <li><a onclick="sys_LoadPage(\'Ins_CategoryLevel2.htm\');" title=""><span class="icos-frames"></span>Thêm mới</a></li>	';
    html = html + '	                            <li><a href="tables_control.html" title=""><span class="icos-bullseye"></span>{sys_GetText_Master(14)}</a></li>	';
    html = html + '	                            <li><a href="tables_sortable.html" title=""><span class="icos-transfer"></span>{sys_GetText_Master(15)}</a></li>	';
    html = html + '	                        </ul>	';
    html = html + '	                        <div class="divider"><span></span></div>	';
    html = html + '	                    </div>	';

    $(div).setTemplate(html);
    $(div).processTemplate();
    var options = { percent: 0 };
    //$(div).toggle("Drop");
}
function OpenMenuLevel2_4(div) {
    $(div).hide();
    $(div).show(300);
    $(div).html();// xóa trắng
    var html = "";

    html = html + '	                    <div class="divider"><span></span></div>	';
    html = html + '	                    <div id="general">	';
    html = html + '	                        <ul class="subNav">	';
    html = html + '	                            <li><a onclick="sys_LoadPage(\'Lst_Albums.htm\');" title=""><span class="icos-frames"></span>Danh sách Albums</a></li>	';
    html = html + '	                            <li><a href="tables_dynamic.html" title="" class="this"><span class="icos-refresh"></span>{sys_GetText_Master(17)}</a></li>	';
    html = html + '	                            <li><a href="tables_control.html" title=""><span class="icos-bullseye"></span>{sys_GetText_Master(18)}</a></li>	';
    html = html + '	                            <li><a href="tables_sortable.html" title=""><span class="icos-transfer"></span>{sys_GetText_Master(19)}</a></li>	';
    html = html + '	                        </ul>	';
    html = html + '	                        <div class="divider"><span></span></div>	';
    html = html + '	                    </div>	';

    $(div).setTemplate(html);
    $(div).processTemplate();
    var options = { percent: 0 };
    //$(div).toggle("Drop");
}
function OpenMenuLevel2_5(div) {
    if (!isOpen) {
        $(div).show(300);
        isOpen = true;
    } else {
        $(div).hide();
        $(div).show(300);
    }
    $(div).html();// xóa trắng
    var html = "";

    html = html + '	                    <div class="divider"><span></span></div>	';
    html = html + '	                    <div id="general">	';
    html = html + '	                        <ul class="subNav">	';
    html = html + '	                            <li><a onclick="sys_LoadPage(\'Lst_Files.htm\');" title=""><span class="icos-frames"></span>Danh sách</a></li>	';
    html = html + '	                            <li><a onclick="sys_LoadPage(\'Upd_Files.htm\');" title=""><span class="icos-frames"></span>Thêm mới</a></li>	';
    html = html + '	                            <li><a  onclick="" title=""><span class="icos-bullseye"></span>Sửa</a></li>	';
    html = html + '	                            <li><a href="tables_sortable.html" title=""><span class="icos-transfer"></span>{sys_GetText_Master(23)}</a></li>	';
    html = html + '	                        </ul>	';
    html = html + '	                        <div class="divider"><span></span></div>	';
    html = html + '	                    </div>	';

    $(div).setTemplate(html);
    $(div).processTemplate();
    var options = { percent: 0 };
    //$(div).toggle("Drop");
}
function OpenMenuLevel2_6(div) {
    $(div).hide();
    $(div).show(300);

    $(div).html();// xóa trắng
    var html = "";

    html = html + '	                    <div class="divider"><span></span></div>	';
    html = html + '	                    <div id="general">	';
    html = html + '	                        <ul class="subNav">	';
    html = html + '	                            <li><a onclick="sys_LoadPage(\'Lst_Languages.htm\');" title=""><span class="icos-frames"></span>Danh sách Languages</a></li>	';
    html = html + '	                            <li><a href="tables_dynamic.html" title="" class="this"><span class="icos-refresh"></span>{sys_GetText_Master(25)}</a></li>	';
    html = html + '	                            <li><a href="tables_control.html" title=""><span class="icos-bullseye"></span>{sys_GetText_Master(26)}</a></li>	';
    html = html + '	                            <li><a href="tables_sortable.html" title=""><span class="icos-transfer"></span>{sys_GetText_Master(27)}</a></li>	';
    html = html + '	                        </ul>	';
    html = html + '	                        <div class="divider"><span></span></div>	';
    html = html + '	                    </div>	';

    $(div).setTemplate(html);
    $(div).processTemplate();
    var options = { percent: 0 };
    //$(div).toggle("Drop");
}
function OpenMenuLevel2_7(div) {
    $(div).hide();
    $(div).show(300);
    $(div).html();// xóa trắng
    var html = "";

    html = html + '	                    <div class="divider"><span></span></div>	';
    html = html + '	                    <div id="general">	';
    html = html + '	                        <ul class="subNav">	';
    html = html + '	                            <li><a onclick="sys_LoadPage(\'Lst_Configs.htm\');" title=""><span class="icos-frames"></span>Configs</a></li>	';
    html = html + '	                            <li><a onclick="sys_LoadPage(\'Lst_PermitDetails.htm\');" title=""><span class="icos-frames"></span>PermitDetails</a></li>	';
    html = html + '	                            <li><a onclick="sys_LoadPage(\'Lst_Permits.htm\');" title=""><span class="icos-frames"></span>Permits</a></li>	';
    html = html + '	                            <li><a href="tables_sortable.html" title=""><span class="icos-transfer"></span>{sys_GetText_Master(31)}</a></li>	';
    html = html + '	                        </ul>	';
    html = html + '	                        <div class="divider"><span></span></div>	';
    html = html + '	                    </div>	';

    $(div).setTemplate(html);
    $(div).processTemplate();
    var options = { percent: 0 };
    //$(div).toggle("Drop");
}
function OpenMenuLevel2_8(div) {
    $(div).hide();
    $(div).show(300);

    $(div).html();// xóa trắng
    var html = "";

    html = html + '	                    <div class="divider"><span></span></div>	';
    html = html + '	                    <div id="general">	';
    html = html + '	                        <ul class="subNav">	';
    html = html + '	                            <li><a href="tables.html" title=""><span class="icos-frames"></span>{sys_GetText_Master(32)}</a></li>	';
    html = html + '	                            <li><a href="tables_dynamic.html" title="" class="this"><span class="icos-refresh"></span>{sys_GetText_Master(33)}</a></li>	';
    html = html + '	                            <li><a href="tables_control.html" title=""><span class="icos-bullseye"></span>{sys_GetText_Master(34)}</a></li>	';
    html = html + '	                            <li><a href="tables_sortable.html" title=""><span class="icos-transfer"></span>{sys_GetText_Master(35)}</a></li>	';
    html = html + '	                        </ul>	';
    html = html + '	                        <div class="divider"><span></span></div>	';
    html = html + '	                    </div>	';

    $(div).setTemplate(html);
    $(div).processTemplate();
    var options = { percent: 0 };
    //$(div).toggle("Drop");
}
function OpenMenuLevel2_9(div) {
    $(div).hide();
    $(div).show(300);
    $(div).html();// xóa trắng
    var html = "";

    html = html + '	                    <div class="divider"><span></span></div>	';
    html = html + '	                    <div id="general">	';
    html = html + '	                        <ul class="subNav">	';
    html = html + '	                            <li><a href="tables.html" title=""><span class="icos-frames"></span>{sys_GetText_Master(36)}</a></li>	';
    html = html + '	                            <li><a href="tables_dynamic.html" title="" class="this"><span class="icos-refresh"></span>{sys_GetText_Master(37)}</a></li>	';
    html = html + '	                            <li><a href="tables_control.html" title=""><span class="icos-bullseye"></span>{sys_GetText_Master(38)}</a></li>	';
    html = html + '	                            <li><a href="tables_sortable.html" title=""><span class="icos-transfer"></span>{sys_GetText_Master(39)}</a></li>	';
    html = html + '	                        </ul>	';
    html = html + '	                        <div class="divider"><span></span></div>	';
    html = html + '	                    </div>	';

    $(div).setTemplate(html);
    $(div).processTemplate();
    var options = { percent: 0 };
    //$(div).toggle("Drop");
}


//sua menu
var isOpen = false;