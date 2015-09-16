
// load menu top 
function Load_MenuTopVer(div) {

    //var datacategory1 = CategoryLevel1BO.Sel_ByIDLang_ByDisable(1, false);
    var datacategory2 = CategoryLevel2BO.Sel_ByIDLang_ByDisable(1, false);


    //sys_LoadPage('Lst_MenuTop.htmlver', data, "#pav-masshead");        
    var htmlver = "";
    htmlver += "		                        <div class='navbar navbar-vertical'> ";
    htmlver += "		                            <a href='javascript:;' data-target='.navbar-collapse' data-toggle='collapse' class='navbar-toggle'> ";
    htmlver += "		                                <span class='icon-bar'></span> ";
    htmlver += "		                            </a> ";
    htmlver += "		                            <div class='collapse navbar-collapse navbar-ex1-collapse' style='height:auto;'> ";
    htmlver += "		                                <ul class='nav navbar-nav verticalmenu'> ";
    htmlver += "		                                   {#foreach $T.data as record}";
    htmlver += "		                                    <li onmousemove=\"LoadSubMenuTopVer({$T.record.Code},'#{$T.record.Code}')\" class='parent dropdown'>";
    htmlver += "		                                           <a class='dropdown-toggle' data-toggle='dropdown' href='#'>";
    htmlver += "		                                            <span class='menu-icon' style='background:url('image/catalog/icon-verticalmenu/icon08.png') no-repeat;'> ";
    htmlver += "		                                            <span class='menu-title'>{$T.record.CategoryNameLevel2}</span><b class='caret'></b></span> ";
    htmlver += "		                                           </a> ";
    htmlver += "		                                            <div class='dropdown-menu level1'> ";
    htmlver += "		                                            <div class='dropdown-menu-inner'> ";
    htmlver += "		                                                <div class='row'> ";
    htmlver += "		                                                    <div class='mega-col col-md-12' data-type='menu'> ";
    htmlver += "		                                                        <div class='mega-col-inner'> ";
    htmlver += "		                                                               <ul id='{$T.record.Code}'> ";
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
    htmlver += "		                        </div>";


    jQuery(div).setTemplate(htmlver);

    jQuery(div).processTemplate(datacategory2);






}
function Load_MenuTopHoz(div) {
    var datacategory2 = CategoryLevel2BO.Sel_ByIDLang_ByDisable(1, false);
    var htmlhoz = "";

    // htmlhoz += "		<div class='collapse navbar-collapse' id='bs-megamenu'>";
    htmlhoz += "		                            <ul class='nav navbar-nav megamenu'>";
    htmlhoz += "		                                <li class='home'><a href='/'><span class=''></span><span class='menu-title'>Trang chủ</span></a></li>";
    htmlhoz += "		                                <li class='aligned-fullwidth parent dropdown'>";
    htmlhoz += "		                                    <a href='product.aspx' class='dropdown-toggle' data-toggle='dropdown'>";
    htmlhoz += "		                                        <span class=''></span>";
    htmlhoz += "		                                        <span class='menu-title'>Sản phẩm</span><b class='caret'></b></a>";
    htmlhoz += "		                                        <div class='dropdown-menu'>";
    htmlhoz += "		                                        <div class='dropdown-menu-inner'>";
    htmlhoz += "		                                            <div class='row'>";
    htmlhoz += "		                                                 {#foreach $T.data as record}{#param name=x value=$T.record.Code}";
    htmlhoz += "		                                                <div class='mega-col col-xs-12 col-sm-12 col-md-3 ' onmousemove=\" LoadSubMenuTopHoz({$P.x},'#hoz{$P.x}')\">";
    htmlhoz += "		                                                    <div class='mega-col-inner'>";
    htmlhoz += "		                                                        <div class='pavo-widget' id='pavowid-26'>";
    htmlhoz += "		                                                            <div class='pavo-widget' id='pavowid-735143602'>";
    htmlhoz += "		                                                                <h4 class='widget-heading title'>{$T.record.CategoryNameLevel2}</h4>";
    htmlhoz += "		                                                                <div class=''>";
    htmlhoz += "		                                                                    <ul class='content' id='hoz{$T.record.Code}'}'>";
    htmlhoz += "		                                                                    </ul>";
    htmlhoz += "		                                                                </div>";
    htmlhoz += "		                                                            </div>";
    htmlhoz += "		                                                        </div>";
    htmlhoz += "		                                                    </div>";
    htmlhoz += "		                                            </div>";
    htmlhoz += "		                                             {#/for}";
    htmlhoz += "		                                            </div>";
    htmlhoz += "		                                        </div>";
    htmlhoz += "		                                    </div>";
    htmlhoz += "		                                </li>";
    htmlhoz += "		                                <li class=''><a href='#'><span class=''></span><span class='menu-title'>Giới Thiệu</span></a></li>";
    htmlhoz += "		                                <li class=''><a href='#'><span class=''></span><span class='menu-title'>Liên Hệ</span></a></li>";
    htmlhoz += "		                            </ul>";

    jQuery(div).setTemplate(htmlhoz);
    // jQuery(div).setParam("hoz", LoadSubMenuTopHoz);
    jQuery(div).processTemplate(datacategory2);
}
function LoadSubMenuTopHoz(CodeCateGoryLevel2, div) {
    var data = CategoryLevel1BO.Sel_Ext_ByCodeCategoryLevel2_ByIDLang(CodeCateGoryLevel2);
    var html = "";
    html += "		                                                               {#foreach $T.data as record}";
    html += "		                                                                   <li>";
    html += "		                                                                            <a href='#'>";
    html += "		                                                                                <span>{$T.record.CategoryLevel1_CategoryNameLevel1}{$T.record.CategoryLevel1_ID}</span>";
    html += "		                                                                            </a>";
    html += "		                                                                        </li>";
    html += "		                                                               {#/for} ";


    jQuery(div).setTemplate(html);

    jQuery(div).processTemplate(data);
    return true;

}
function LoadSubMenuTopVer(CodeCateGoryLevel2, div) {
    var data = CategoryLevel1BO.Sel_Ext_ByCodeCategoryLevel2_ByIDLang(CodeCateGoryLevel2);
    var html = "";
    html += "		                                                               {#foreach $T.data as record}";
    html += "		                                                                    <li class=' '><a href='#'><span class='menu-title'>{$T.record.CategoryLevel1_CategoryNameLevel1}{$T.record.CategoryLevel1_ID}</span></a></li> ";
    html += "		                                                               {#/for} ";
    jQuery(div).setTemplate(html);

    jQuery(div).processTemplate(data);
}
//end menu

//1. LoadCateGoryLv2
function LoadCateGoryLevel2(div) {
    var html = "";
    var datacategory2 = CategoryLevel2BO.Sel_ByIDLang_ByDisable(1, false);
    //$.each(datacategory2, function (i, item) {
    //    alert(item.CategoryNameLevel2);
    //})
    //alert(datacategory2.data.length);
    //html += "{#foreach $T.data as record}";
    for (var i = 0; i < datacategory2.data.length; i++) {


        //categorylv2
        html += "	  <div class='box pav-verticalcategorytabs clearfix box-blue'> ";
        html += "	                                                <div class='box-wapper box-blue clearfix'> ";
        html += "	                                                    <div class='tab-heading box-heading clearfix nopadding k-nomargin' id='Content_Category'> ";
        html += "	                                                        <div class='nav-header navbar-brand'> ";
        html += "	  " + datacategory2.data[i].CategoryNameLevel2 + "                                                        ";//{$T.record.CategoryNameLevel2}
        html += "	                                                        </div> ";                                                                        //category1  id pav-categorytabs  onmousemove=\" LoadcategoryLevel1({$T.record.Code},'#pav{$T.record.Code}')\"
        html += "	                                                        <ul class='nav nav-pills k-right nopadding' id='pav-categorytabs'> ";
        //categorylv1
        html += " " + LoadcategoryLevel1(datacategory2.data[i].Code) + " ";
        html += "	                                                        </ul> ";                                                                        // end cate 1
        html += "	                                                        <!-- end div.tab-heading --> ";
        html += "	                                                    </div> ";
        html += "	                                                    <!--banertab--> ";
        html += "	                                                    <div class='tab-nav tabs-x tabs-left'> ";
        html += "	                                                        <div class='banner-image hidden-md hidden-sm hidden-xs k-img-banner'> ";
        html += "	                                                            <a class='img-banner' href='#' data-toggle='tab'> ";
        html += "	                                                                <img class='img-responsive' src='../images/baner/banner1.jpg' alt='Sản phẩm mới' /> ";
        html += "	                                                            </a> ";
        html += "	                                                        </div> ";
        html += "	                                                    </div> ";
        html += "	                                                    <!--end baner tab--> ";
        html += "	                                                    <!--tab sản phẩm mới--> ";
        //product
        html += LoadContent(LoadcategoryLevel1_Content(datacategory2.data[i].Code).data[i].CategoryLevel1_Code, 1);
        //end product
        html += "	                                                        ";
        html += "	                                                    </div><!-- end div.tab-content --> ";
        // html += " 	";
        html += "	                                                </div><!-- end div.box-wapper --> ";
        html += "	                                            </div> ";
        html += "	                                            <!-- end div.box --> ";
        for (var j = 0; j < LoadcategoryLevel1_Content(datacategory2.data[i].Code).data.length; j++) {
            html += "	                                            <script>";
            html += "	                                                $(function () { ";
            html += "	                                                    $('." + LoadcategoryLevel1_Content(datacategory2.data[i].Code).data[j].CategoryLevel1_Code + "').carousel({interval:99999999999999,auto:false,pause:'hover'}); ";
            html += "	                                                    $('#pavo-categorytabs378 a:first').tab('show');";
            html += "	                                                });";
            html += "	                                            </script> ";
        }

    }
    // html += "{#/for}";

    // end cate 2

    //for (var i = 0; i < datacategory2.data.length; i++) {


    //}
    //  alert(datacategory2.data[0].CategoryNameLevel2);//chú ý đoạn này
    jQuery(div).html(html);
    //alert(LoadContent(LoadcategoryLevel1.data[0].CategoryLevel1_Code, 1));


    // jQuery(div).processTemplate(datacategory2);
    // var data_Content = LoadContent("63512594180", 1);
    //alert(data_Content.data.length);

}
//ContentByCategory
function LoadcategoryLevel1(CodeCateGoryLevel2) {


    var datap = CategoryLevel1BO.Sel_Ext_ByCodeCategoryLevel2_ByIDLang(CodeCateGoryLevel2);

    //alert($(div).html());

    var html = "";
    for (var i = 0; i < datap.data.length; i++) {
        html += " <li class='k-left'><a class='k-color-white' href='#tab-" + datap.data[i].CategoryLevel1_Code + "' role='tab' data-toggle='tab'>" + datap.data[i].CategoryLevel1_CategoryNameLevel1 + "</a></li> ";//{$T.record.CategoryLevel1_CategoryNameLevel1}
    }



    return html;

}
function LoadcategoryLevel1_Content(CodeCateGoryLevel2) {


    var datap = CategoryLevel1BO.Sel_Ext_ByCodeCategoryLevel2_ByIDLang(CodeCateGoryLevel2);




    return datap;

}

function LoadContent(CodeCategoryLevel1, IDLang) {

    var data_contents = ContentsBO.Sel_Ext_ByCodeCategoryLevel1(CodeCategoryLevel1, IDLang);
    var html = "";
    html += "	                                                    <div class='tab-content'> ";
    html += "	                                                        <div class='tab-pane active' id='tab-" + CodeCategoryLevel1 + "'> ";
    html += "	                                                            <!--control--> ";
    html += "	                                                            <div class='carousel-controls'> ";
    html += "	                                                                <a class='carousel-control left' href='#list-" + CodeCategoryLevel1 + "' data-slide='prev'> ";
    html += "	                                                                  <i class='fa fa-angle-left'></i> ";
    html += "	                                                                </a> ";
    html += "	                                                                <a class='carousel-control right' href='#list-" + CodeCategoryLevel1 + "' data-slide='next'> ";
    html += "	                                                                    <i class='fa fa-angle-right'></i> ";
    html += "	                                                                </a> ";
    html += "	                                                            </div> ";
    html += "	                                                            <!--end control--> ";
    html += "	                                                            <div class='carousel-inner " + CodeCategoryLevel1 + " slide' id='list-" + CodeCategoryLevel1 + "'> ";
    // tab active
    html += "	                                                                <div class='item active'> ";
    html += "	                                                                    <div class='row products-row last'> ";
    for (var i = 0; i < 4; i++) {
        html += "	                                                                        <!--product--> ";
        html += "	                                                                        <div class='col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col'> ";
        html += "	                                                                            <div class='product-block item-default clearfix' itemtype='#' itemscope> ";
        //html += " 	";
        //html += " 	";
        // html += "	                                                                                <span class='product-label ribbon label-special'><span class='product-label-special'>Giảm giá</span></span> ";
        html += "	                                                                                <div class='images clearfix'> ";
        html += "	                                                                                    <a class='img' itemprop='url' title='Furabitur sedg' href='#chitiet'> ";
        html += "	                                                                                        <img class='img-responsive' itemprop='image' src='" + sys_CommonType.URL_CMS + "/Action/ProcessImageServiceAction.ashx?W=600&H=600&Scale=crop&Img=" + data_contents.data[i].Contents_Image + "' title='" + data_contents.data[i].Contents_Title + "' alt='" + data_contents.data[i].Contents_Title + "' /> ";
        html += "	                                                                                    </a> ";
        html += " 	";
        html += "	                                                                                    <a class='pav-colorbox btn btn-inverse iframe-link' data-toggle='tooltip' href='/Introdetail.html' title='Xem nhanh'> ";
        html += "	                                                                                        <i class='fa fa-eye'></i> ";
        html += "	                                                                                    </a> ";
        html += " 	";
        html += "	                                                                                    <a href='" + sys_CommonType.URL_CMS + "/Action/ProcessImageServiceAction.ashx?W=600&H=600&Scale=crop&Img=" + data_contents.data[i].Contents_Image + "' title='" + data_contents.data[i].Contents_Title + "' class='btn btn-inverse colorbox product-zoom cboxElement' title='Furabitur sedg'> ";
        html += "	                                                                                       <i class='fa fa-search-plus'></i> ";
        html += "	                                                                                    </a> ";
        html += "	                                                                                </div> ";
        html += " 	";
        html += "	                                                                                <div class='product-meta'> ";
        html += "	                                                                                    <div class='product-meta-inner'> ";
        html += "	                                                                                        <div class='left'> ";
        html += "	                                                                                            <div class='review clearfix'> ";
        html += "	                                                                                                <h3 class='name' itemprop='name'> ";
        html += "	                                                                                                    <a href=''>" + data_contents.data[i].Contents_Title + "</a> ";
        html += " 	";
        html += "	                                                                                                </h3> ";
        html += " 	";
        html += "	                                                                                            </div> ";
        html += " 	";
        html += "	                                                                                            <div class='price clearfix' itemtype='http://schema.org/Offer' itemscope itemprop='offers'> ";
        html += "	                                                                                                <span class='price-new'>290,00VND</span> ";
        html += "	                                                                                                <span class='price-old'></span> ";
        html += " 	";
        html += "	                                                                                            </div> ";
        html += " 	";
        html += " 	";
        html += "	                                                                                            <div class='clearfix'></div> ";
        html += "	                                                                                            <p class='description' itemprop='description'>ManhQuang</p>																		";
        html += "	                                                                                        </div> ";
        html += " 	";
        html += "	                                                                                    </div> ";
        html += "	                                                                                </div> ";
        html += "	                                                                            </div> ";
        html += "	                                                                        </div> ";
        html += "";

        if (i % 3 == 2) {
            //html += "	                                                                         ";
            //html += " 	";
            //html += "	                                                                     ";
            //Đóng 
            html += "	                                                                    </div> ";
            html += "	                                                                </div> ";

        }

        ////đóng
        //html += "	                                                                    </div> ";
        //html += "	                                                                </div> ";
        //mở tab

        html += "	                                                                <div class='item'> ";
        html += "	                                                                    <div class='row products-row last'> ";
        //    html += "	                                                                        <!--product--> ";
        //    html += "	                                                                        <div class='col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col'> ";
        //    html += "	                                                                            <div class='product-block item-default clearfix' itemtype='#' itemscope> ";
        //    //html += " 	";
        //    //html += " 	";
        //    html += "	                                                                                <span class='product-label ribbon label-special'><span class='product-label-special'>Giảm giá</span></span> ";
        //    html += "	                                                                                <div class='images clearfix'> ";
        //    html += "	                                                                                    <a class='img' itemprop='url' title='Furabitur sedg' href='#chitiet'> ";
        //    html += "	                                                                                        <img class='img-responsive' itemprop='image' src='../images/Content_Product/Intro/dong_son_trang.jpg' title='sp1' alt='sp1' /> ";
        //    html += "	                                                                                    </a> ";
        //    html += " 	";
        //    html += "	                                                                                    <a class='pav-colorbox btn btn-inverse iframe-link' data-toggle='tooltip' href='/Introdetail.html' title='Xem nhanh'> ";
        //    html += "	                                                                                        <i class='fa fa-eye'></i> ";
        //    html += "	                                                                                    </a> ";
        //    html += " 	";
        //    html += "	                                                                                    <a href='../images/Content_Product/Intro/dong_son_trang.jpg' class='btn btn-inverse colorbox product-zoom cboxElement' title='Furabitur sedg'> ";
        //    html += "	                                                                                       <i class='fa fa-search-plus'></i> ";
        //    html += "	                                                                                    </a> ";
        //    html += "	                                                                                </div> ";
        //    html += " 	";
        //    html += "	                                                                                <div class='product-meta'> ";
        //    html += "	                                                                                    <div class='product-meta-inner'> ";
        //    html += "	                                                                                        <div class='left'> ";
        //    html += "	                                                                                            <div class='review clearfix'> ";
        //    html += "	                                                                                                <h3 class='name' itemprop='name'> ";
        //    html += "	                                                                                                    <a href='index5e3d.html?route=product/product&amp;product_id=136'>Furabitur sedg</a> ";
        //    html += " 	";
        //    html += "	                                                                                                </h3> ";
        //    html += " 	";
        //    html += "	                                                                                                <div class='rating'> ";
        //    html += "	                                                                                                    <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span> ";
        //    html += "	                                                                                                    <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span> ";
        //    html += "	                                                                                                    <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span> ";
        //    html += "	                                                                                                    <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span> ";
        //    html += "	                                                                                                    <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span> ";
        //    html += "	                                                                                                </div> ";
        //    html += "	                                                                                            </div> ";
        //    html += " 	";
        //    html += "	                                                                                            <div class='price clearfix' itemtype='http://schema.org/Offer' itemscope itemprop='offers'> ";
        //    html += "	                                                                                                <span class='price-new'>$290,00</span> ";
        //    html += "	                                                                                                <span class='price-old'>$300,00</span> ";
        //    html += " 	";
        //    html += "	                                                                                            </div> ";
        //    html += " 	";
        //    html += " 	";
        //    html += "	                                                                                            <div class='clearfix'></div> ";
        //    html += "	                                                                                            <p class='description' itemprop='description'>	HTC Touch - in High Definition. Watch music videos and streaming content in awe-inspiring high defi.....</p>																		";
        //    html += "	                                                                                        </div> ";
        //    html += " 	";
        //    html += "	                                                                                    </div> ";
        //    html += "	                                                                                </div> ";
        //    html += "	                                                                            </div> ";
        //    html += "	                                                                        </div> ";
        //    html += " 	";
        //    //đóng
        //    html += "	                                                                    </div> ";
        //    html += "	                                                                </div> ";
        ////html += "	                                                                    </div> ";
        ////html += "	                                                                </div> ";
        ////html += " 	";
        //html += "	                                                                <!--end tab1--> ";
        //html += "	                                                                <div class='item '> ";
        //html += "	                                                                    <div class='row products-row '> ";
        //html += "	                                                                        <div class='col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col'> ";
        //html += "	                                                                            <div class='product-block item-default clearfix' itemtype='#' itemscope> ";
        //html += " 	";
        //html += " 	";
        //html += "	                                                                                <span class='product-label ribbon label-special'><span class='product-label-special'>Giảm giá</span></span> ";
        //html += "	                                                                                <div class='images clearfix'> ";
        //html += "	                                                                                    <a class='img' itemprop='url' title='Furabitur sedg' href='#chitiet'> ";
        //html += "	                                                                                        <img class='img-responsive' itemprop='image' src='../images/Content_Product/Intro/dong_son_trang.jpg' title='sp1' alt='sp1' /> ";
        //html += "	                                                                                    </a> ";
        //html += " 	";
        //html += "	                                                                                    <a class='pav-colorbox btn btn-inverse iframe-link' data-toggle='tooltip' href='/Introdetail.html' title='Xem nhanh'><i class='fa fa-eye'></i></a> ";
        //html += " 	";
        //html += "	                                                                                    <a href='../images/Content_Product/Intro/dong_son_trang.jpg' class='btn btn-inverse colorbox product-zoom cboxElement' title='Furabitur sedg'> ";
        //html += "	                                                                                        <i class='fa fa-search-plus'></i> ";
        //html += " 	";
        //html += "	                                                                                    </a> ";
        //html += "	                                                                                </div> ";
        //html += " 	";
        //html += "	                                                                                <div class='product-meta'> ";
        //html += "	                                                                                    <div class='product-meta-inner'> ";
        //html += "	                                                                                        <div class='left'> ";
        //html += "	                                                                                            <div class='review clearfix'> ";
        //html += "	                                                                                                <h3 class='name' itemprop='name'><a href='index5e3d.html?route=product/product&amp;product_id=136'>Furabitur sedg</a></h3> ";
        //html += " 	";
        //html += "	                                                                                                <div class='rating'> ";
        //html += "	                                                                                                    <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span> ";
        //html += "	                                                                                                    <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span> ";
        //html += "	                                                                                                    <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span> ";
        //html += "	                                                                                                    <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span> ";
        //html += "	                                                                                                    <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span> ";
        //html += "	                                                                                                </div> ";
        //html += "	                                                                                            </div> ";
        //html += " 	";
        //html += "	                                                                                            <div class='price clearfix' itemtype='http://schema.org/Offer' itemscope itemprop='offers'> ";
        //html += "	                                                                                                <span class='price-new'>$290,00</span> ";
        //html += "	                                                                                                <span class='price-old'>$300,00</span> ";
        //html += " 	";
        //html += "	                                                                                            </div> ";
        //html += " 	";
        //html += " 	";
        //html += "	                                                                                            <div class='clearfix'></div> ";
        //html += "	                                                                                            <p class='description' itemprop='description'>	HTC Touch - in High Definition. Watch music videos and streaming content in awe-inspiring high defi.....</p>																		";
        //html += "	                                                                                        </div> ";
        //html += " 	";
        //html += "	                                                                                    </div> ";
        //html += "	                                                                                </div> ";
        //html += "	                                                                            </div> ";
        //html += "	                                                                        </div> ";

        //html += "	                                                                    </div> ";
        //html += "	                                                                </div> ";
    }
    html += "	                                                                    </div> ";
    html += "	                                                                </div> ";

    html += "	                                                            </div><!-- end div.carousel-content--> ";
    html += " 	";
    html += "	                                                        </div><!-- end div.tab-panel--> ";
    return html;




}
