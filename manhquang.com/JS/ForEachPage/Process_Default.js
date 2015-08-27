
// load menu top 
function Load_MenuTop(div1,div2)
{
    
    //var datacategory1 = CategoryLevel1BO.Sel_ByIDLang_ByDisable(1, false);
    var datacategory2 = CategoryLevel2BO.Sel_ByIDLang_ByDisable(1, false);
   

    //sys_LoadPage('Lst_MenuTop.htmlver', data, "#pav-masshead");        
    var htmlver = "";
    htmlver+="		                        <div class='navbar navbar-vertical'> ";
    htmlver +="		                            <a href='javascript:;' data-target='.navbar-collapse' data-toggle='collapse' class='navbar-toggle'> ";
    htmlver +="		                                <span class='icon-bar'></span> ";
    htmlver += "		                            </a> ";
    htmlver += "		                            <div class='collapse navbar-collapse navbar-ex1-collapse' style='height:auto;'> ";
    htmlver += "		                                <ul class='nav navbar-nav verticalmenu'> ";   
    htmlver += "		                                   {#foreach $T.data as record}";        
    htmlver += "		                                    <li onmousemove=\"LoadSubMenuTopVer({$T.record.Code},'#{$T.record.Code}')\" class='parent dropdown'>";
    htmlver+="		                                           <a class='dropdown-toggle' data-toggle='dropdown' href='#'>";
    htmlver += "		                                            <span class='menu-icon' style='background:url('image/catalog/icon-verticalmenu/icon08.png') no-repeat;'> ";
    htmlver += "		                                            <span class='menu-title'>{$T.record.CategoryNameLevel2}</span><b class='caret'></b></span> ";
    htmlver += "		                                           </a> ";
    htmlver += "		                                            <div class='dropdown-menu level1'> ";
    htmlver += "		                                            <div class='dropdown-menu-inner'> ";
    htmlver +="		                                                <div class='row'> ";
    htmlver +="		                                                    <div class='mega-col col-md-12' data-type='menu'> ";
    htmlver +="		                                                        <div class='mega-col-inner'> ";
    htmlver +="		                                                               <ul id='{$T.record.Code}'> ";
    //htmlver += "		                                                               {#foreach $T.data as record}{#if $T.record.Type==2}{#if $T.record.Status==$P.x}";  
    // htmlver +="		                                                                    <li class=' ' onclick='LoadSubMenuTop()'><a href='#'><span class='menu-title'>12</span></a></li> ";
    //htmlver += "		                                                               {#/if}{#/if}{#/for} ";
    htmlver += "		                                                            </ul> ";
    htmlver += "		                                                        </div> ";
    htmlver += "		                                                    </div> ";
    htmlver += "		                                                </div> ";
    htmlver += "		                                            </div> ";
    htmlver += "		                                        </div> ";
    htmlver += "		                                    </li> ";
    htmlver += "		                                   {#/for}";
    htmlver += "		                               </ul> ";
    htmlver += "		                            </div> ";
    htmlver += "		                        </div> ";
    // htmlver += "<script type='text/javascript'>LoadSubMenuTop('{$T.record.Code}','#{$T.record.Code}')<script>";
    // htmlver += "		                        <script><script> ";
   
 
    //alert(htmlver);
    jQuery(div1).setTemplate(htmlver);

    jQuery(div1).processTemplate(datacategory2);
    var htmlhoz = "";

    htmlhoz += "		<div class='collapse navbar-collapse' id='bs-megamenu'>";
    htmlhoz += "		                            <ul class='nav navbar-nav megamenu'>";
    htmlhoz += "		                                <li class='home'><a href='/'><span class=''></span><span class='menu-title'>Trang chủ</span></a></li>";
    htmlhoz += "		                                <li class=' aligned-fullwidth parent dropdown '>";
    htmlhoz += "		                                    <a href='product.aspx' class='dropdown-toggle' data-toggle='dropdown'>";
    htmlhoz += "		                                        <span class=''></span>";
    htmlhoz += "		                                        <span class='menu-title'>Sản phẩm</span><b class='caret'></b></a>";
    htmlhoz += "		                                        <div class='dropdown-menu'>";
    htmlhoz += "		                                        <div class='dropdown-menu-inner'>";
    htmlhoz += "		                                            <div class='row'>";
    htmlhoz += "		                                                <%--menu cha--%>";
    htmlhoz += "		                                                <div class='mega-col col-xs-12 col-sm-12 col-md-3 '>";
    htmlhoz += "		                                                    <div class='mega-col-inner'>";
    htmlhoz += "		                                                        <div class='pavo-widget' id='pavowid-26'>";
    htmlhoz += "		                                                            <div class='pavo-widget' id='pavowid-735143602'>";
    htmlhoz += "		                                                                <h4 class='widget-heading title'>2</h4>";
    htmlhoz += "		                                                                <div class=''>";
    htmlhoz += "		                                                                    <ul class='content'>";
    htmlhoz += "		                                                                       <%--con--%> ";
    htmlhoz += "		                                                                        <li>";
    htmlhoz += "		                                                                            <a href='#'>";
    htmlhoz += "		                                                                                <span>21</span>";
    htmlhoz += "		                                                                            </a>";
    htmlhoz += "		                                                                        </li>";
    htmlhoz += "		                                                                       ";
    htmlhoz += "		                                                                        <%--end con--%>";
    htmlhoz += "		                                                                    </ul>";
    htmlhoz += "		                                                                </div>";
    htmlhoz += "		                                                            </div>";
    htmlhoz += "		                                                        </div>";
    htmlhoz += "		                                                    </div>";
    htmlhoz += "		                                                </div>";
    htmlhoz += "		                                               <%--end cha--%>";
    htmlhoz += "		                                            </div>";
    htmlhoz += "		                                        </div>";
    htmlhoz += "		                                    </div>";
    htmlhoz += "		                                </li>";
    htmlhoz += "		                                <li class=''><a href='#'><span class=''></span><span class='menu-title'>Giới Thiệu</span></a></li>";
    htmlhoz += "		                                <li class=''><a href='#'><span class=''></span><span class='menu-title'>Liên Hệ</span></a></li>";
    htmlhoz += "		                            </ul>";
    htmlhoz += "		                        </div>";

    jQuery(div2).setTemplate(htmlhoz);

    jQuery(div2).processTemplate(datacategory2);
   
}
 function LoadSubMenuTopVer(CodeCateGoryLevel2,div)
{

     //alert(CodeCateGoryLevel2);
     var data = CategoryLevel1BO.Sel_Ext_ByCodeCategoryLevel2_ByIDLang(CodeCateGoryLevel2);
     var html = "";
         html += "		                                                               {#foreach $T.data as record}";  
         html += "		                                                                   <li>";
        html+= "		                                                                            <a href='#'>";
        html += "		                                                                                <span>{$T.record.CategoryLevel1_CategoryNameLevel1}{$T.record.CategoryLevel1_ID}</span>";
        html += "		                                                                            </a>";
        html += "		                                                                        </li>";
        html += "		                                                               {#/for} ";
   
    
     jQuery(div).setTemplate(html);

     jQuery(div).processTemplate(data);

 }
 function LoadSubMenuTopVer(CodeCateGoryLevel2,div)
 {
     var data = CategoryLevel1BO.Sel_Ext_ByCodeCategoryLevel2_ByIDLang(CodeCateGoryLevel2);
     var html = "";
     html += "		                                                               {#foreach $T.data as record}";
     html += "		                                                                    <li class=' '><a href='#'><span class='menu-title'>{$T.record.CategoryLevel1_CategoryNameLevel1}{$T.record.CategoryLevel1_ID}</span></a></li> ";
     html += "		                                                               {#/for} ";


     jQuery(div).setTemplate(html);

     jQuery(div).processTemplate(data);
 }
//end menu
function LoadContent()
{
    
    var data_contents = ContentsBO.Sel_ByIDLang();
   
    //sys_LoadPage('Lst_Content.htmlver', data_contents, "#columns");
   
}
 function LoadCategoryLevel1()
{
     //var data_Content_category = CategoryLevel1BO.Sel_CategoryLevel1_ByIDLang_ByDisable(sys_CUR_LANG,);
     //alert(1);
     //sys_LoadPage('Lst_Content_Category.htmlver', data_Content_category, "#pav-categorytabs");
 }

