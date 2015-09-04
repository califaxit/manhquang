
// load menu top 
function Load_MenuTopVer(div)
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
    htmlver += "		                        </div>";
   
    
    jQuery(div).setTemplate(htmlver);

    jQuery(div).processTemplate(datacategory2);
   

  
   
   
   
}
function Load_MenuTopHoz(div)
{
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
 function LoadSubMenuTopHoz(CodeCateGoryLevel2,div)
{
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
     return true;

 }
 function LoadSubMenuTopVer(CodeCateGoryLevel2,div)
 {
     var data = CategoryLevel1BO.Sel_Ext_ByCodeCategoryLevel2_ByIDLang(CodeCateGoryLevel2);
     var html ="";
     html += "		                                                               {#foreach $T.data as record}";
     html += "		                                                                    <li class=' '><a href='#'><span class='menu-title'>{$T.record.CategoryLevel1_CategoryNameLevel1}{$T.record.CategoryLevel1_ID}</span></a></li> ";
     html += "		                                                               {#/for} ";
     jQuery(div).setTemplate(html);

     jQuery(div).processTemplate(data);
 }
//end menu

//1. LoadCateGoryLv2
 function LoadCateGoryLevel2(div)
 {
     var html = "";
     var datacategory2 = CategoryLevel2BO.Sel_ByIDLang_ByDisable(1, false);
     for (var i = 0; i < datacategory2.data.length; i++) {

         //begin categorylv2									
         html += "<div class='box pav-verticalcategorytabs clearfix box-blue'>";
         html += "     <div class='box-wapper box-blue clearfix'>";
         //categorylv1_categoryleve2        															
         html += "	        <div class='tab-heading box-heading clearfix nopadding k-nomargin'>";
         html += "	            <div class='nav-header navbar-brand'>";
         html +=  datacategory2.data[i].CategoryNameLevel2;
         html += "	            </div>	";
                                           //menu cate 1
         html += "	            <ul class='nav nav-pills k-right nopadding' id='pav-categorytabs'>";
         html += LoadcategoryLevel1(datacategory2.data[i].Code);
         //html += "	               <li class='k-left'><a class='k-color-white' href='#tab378-cat62' role='tab' data-toggle='tab'>Loại 2</a></li>";
         html += "	             </ul>";
                                        // end menucate 1
         html += "	           </div>";
         //end categorylv1
         /// anh  cate2

         html += "	<div class='tab-nav tabs-x tabs-left'>";
         html += "	   <div class='banner-image hidden-md hidden-sm hidden-xs k-img-banner'>";
         html += "	     <a class='img-banner' href='#' data-toggle='tab'>";
         html += "	      <img class='img-responsive' src='" + sys_CommonType.URL_CMS + "/Action/ProcessImageServiceAction.ashx?W=249&H=348&Scale=crop&Img="+datacategory2.data[i].Image+"' alt='Sản phẩm mới' />";
         html += "	     </a>";
         html += "	     </div>";
         html += "	 </div>";

         // end anh cate 2
         /// tab san pham
         html +=  "<div class='tab-content'>";
         /// cac tab chua content category 1
         html += LoadcategoryLevel_Categorylv1ByCateLv2(datacategory2.data[i].Code);
         html+="   </div>"
         /// en tab san pham
         html += "	  </div>";
         html += "</div>	";
         html += "	<script>";
         html += "	$(function	()	{";
         html += "	$('.carousel378').carousel({interval:99999999999999,auto:false,pause:'hover'});";
         html += "	$('#pavo-categorytabs378	a:first').tab('show');";
         html += "	});	";
         html += "	</script>";

     }
       
     jQuery(div).html(html);
    
 }
 //ContentByCategory
 function LoadcategoryLevel1(CodeCateGoryLevel2) {

    
     var datap = CategoryLevel1BO.Sel_Ext_ByCodeCategoryLevel2_ByIDLang(CodeCateGoryLevel2);
   
     //alert($(div).html());
    
     var html = "";
     for (var i = 0; i < datap.data.length; i++) {
         html += " <li class='k-left'><a class='k-color-white' href='#tab" +  datap.data[i].CategoryLevel1_Code + "' role='tab' data-toggle='tab'>" + datap.data[i].CategoryLevel1_CategoryNameLevel1 + "</a></li> ";//{$T.record.CategoryLevel1_CategoryNameLevel1}
     }
     
   	                                                             
     
     return html;

 }
 function LoadcategoryLevel_Categorylv1ByCateLv2(CodeCateGoryLevel2) {


     var datap = CategoryLevel1BO.Sel_Ext_ByCodeCategoryLevel2_ByIDLang(CodeCateGoryLevel2);

     //alert($(div).html());

     var html = "";
     for (var i = 0; i < datap.data.length; i++) {
         if (i == 0)
         { html += "	<div class='tab-pane active' id='tab" + datap.data[i].CategoryLevel1_Code + "'>"; }
         else
         { html += "	<div class='tab-pane' id='tab" + datap.data[i].CategoryLevel1_Code + "'>"; }
        
         html += "	                                                            <!--control-->";
         html += "	                                                            <div class='carousel-controls'>";
         html += "	                                                                <a class='carousel-control left' href='#list378" + datap.data[i].CategoryLevel1_Code + "' data-slide='prev'><i class='fa fa-angle-left'></i></a>";
         html += "	                                                                <a class='carousel-control right' href='#list378" + datap.data[i].CategoryLevel1_Code + "' data-slide='next'><i class='fa fa-angle-right'></i></a>";
         html += "	                                                            </div>";
         html += "	                                                            <!--end control-->";
         html += "	                                                            <div class='carousel-inner carousel378 slide' id='list378" + datap.data[i].CategoryLevel1_Code + "'>";
         html += "	                                                                <!--tab1- active-->";
         //html += "	                                                                <div class='item active'>";
         //html += "	                                                                    <div class='row products-row last'>";
         //html += "	                                                                        <!--product-->";
         html += LoadContent(datap.data[i].CategoryLevel1_Code, 1);
         /////product
         //html += "	                                                                        <!--product-->";
         //html += "	                                                                    </div>";
         //html += "	                                                                </div>";
         //html += "																		";
         //html += "	                                                                <!--end tab1-->	";
         //html += "	                                                                <div class='item '>	";
         //html += "	                                                                    <div class='row products-row last'>";
         //html += LoadContent(datap.data[i].CategoryLevel1_Code, 1);
         //html += "	                                                                    </div>";
         //html += "	                                                                </div>	";
         html += "	                                                          </div>";//end tab
         html += "	                                                        </div>";
     }
     return html;

 }

 function LoadContent(CodeCategoryLevel1, IDLang)
{
    
     var data_contents = ContentsBO.Sel_Ext_ByCodeCategoryLevel1(CodeCategoryLevel1, IDLang);
     var html = "";
     html += "	                                                                <div class='item active'>";
     html += "	                                                                    <div class='row products-row last'>";
     
     var k = 0;
     for (var i = 0; i < data_contents.data.length; i++) {

         k++;
    
     html += "	                                                                        <div class='col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col'>";
     html += "	                                                                            <div class='product-block item-default clearfix' itemtype='#' itemscope>";
     html += "	                                                                                <span class='product-label ribbon label-special'><span class='product-label-special'>Giảm giá</span></span>	";
     html += "	                                                                                <div class='images clearfix'>";
     html += "	                                                                                    <a class='img' itemprop='url' title='Furabitur sedg' href='#chitiet'>";
     html += "	                                                                                        <img class='img-responsive' itemprop='image' src='" + sys_CommonType.URL_CMS + "/Action/ProcessImageServiceAction.ashx?W=600&H=600&Scale=crop&Img=" + data_contents.data[i].Contents_Image + "' title='" + data_contents.data[i].Contents_Title + "' alt='" + data_contents.data[i].Contents_Title + "' /> ";
     html += "	                                                                                    </a>";
     html += "	                                                                                    <a class='pav-colorbox btn btn-inverse iframe-link' data-toggle='tooltip' href='/Introdetail.html' title='Xem nhanh'>";
     html += "	                                                                                        <i class='fa fa-eye'></i>";
     html += "	                                                                                  </a>";
     html += "	                                                                                    <a href='" + sys_CommonType.URL_CMS + "/Action/ProcessImageServiceAction.ashx?W=600&H=600&Scale=crop&Img=" + data_contents.data[i].Contents_Image + "' title='" + data_contents.data[i].Contents_Title + "' class='btn btn-inverse colorbox product-zoom cboxElement' title='Furabitur sedg'> ";
     html += "	                                                                                    <i class='fa fa-search-plus'></i>";
     html += "	                                                                                    </a>";
     html += "	                                                                                </div>	";
     html += "	                                                                                <div class='product-meta'>	";
     html += "	                                                                                    <div class='product-meta-inner'>";
     html += "	                                                                                        <div class='left'>";
     html += "	                                                                                            <div class='review clearfix'>";
     html += "	                                                                                                <h3 class='name' itemprop='name'> <a href=''>" + data_contents.data[i].Contents_Title +"</a></h3>";
     html += "	                                                                                            </div>																	";
     html += "	                                                                                            <div class='price clearfix' itemtype='http://schema.org/Offer' itemscope itemprop='offers'>	";
     html += "	                                                                                                <span class='price-new'>$290,00</span>";
     html += "	                                                                                                <span class='price-old'>$300,00</span>";
     html += "	                                                                                            </div>";
     html += "	                                                                                            <div class='clearfix'></div>";
     html += "	                                                                                            <p class='description' itemprop='description'></p>";
     html += "	                                                                                        </div>";
     html += "	                                                                                    </div>";
     html += "	                                                                                </div>";
     html += "	                                                                            </div>";
     html += "	                                                                        </div>";
     if (i % 3 == 2)
     {
         
         if (i == data_contents.data.length)
         {
             html += "</div></div>";
             html += "";
         }
         else
         {
             html += "</div></div>";
             html += "	                                                                <div class='item'>";
             html += "	                                                                    <div class='row products-row '>";
         }
       

     }
     
    
     }
     
         html += "	                                                                    </div>";
         html += "	                                                                </div>";
     
    
     //
     //html += "	                                                                    </div>";
     //html += "	                                                                </div>";
     return html;
    
     
 }
// slider
//------------------------------sliderTop-------------------//
 function loadsliderTop()
 {

     var html = "";
     html+="	<div class='container-full'>															";
     html+="	        <div class='inner'>															";
     html+="	            <div class='row'>															";
     html+="	                <div class='col-lg-12 col-md-12  '>															";
     html+="	                    <div class='layerslider'>															";
     html+="	                        <div class='bannercontainer banner-fullwidth' style='padding: 0px 0px;margin: 0px 0px 0px;'>															";
     html+="	                            <div id='sliderlayer285765615' class='rev_slider fullwidthbanner' style='width:100%;height:480px; '>															";
     html+="																";
     html+="																";
     html+="	                               <ul>															";
     html+="	                                    <!--lặp 3 lần--> 															";
     html+="	                                    <li data-masterspeed='300' data-transition='random' data-slotamount='7' data-thumb='image/catalog/layerslider/slider-bg1.jpg'>															";
     html+="																";
     html+="																";
     html+="	                                        <img src='image/catalog/layerslider/slider-bg1.jpg' alt='Image 0' />															";
     html+="																";
     html+="																";
     html+="																";
     html+="																";
     html+="	                                        <!-- THE MAIN IMAGE IN THE SLIDE -->															";
     html+="																";
     html+="																";
     html+="	                                        <div class='caption big_great sft															";
     html+="												easeOutExpo   easeOutExpo				";
     html+="												"
     html+="                                                  data-x='112'";
     html+="	                                             data-y='77'															";
     html+="	                                             data-speed='300'															";
     html+="	                                             data-start='400'															";
     html+="	                                             data-easing='easeOutExpo'>															";
     html+="	                                            Get into new season															";
     html+="	                                        </div>															";
     html+="																";
     html+="																";
     html+="																";
     html+="																";
     html+="	                                        <!-- THE MAIN IMAGE IN THE SLIDE -->															";
     html+="																";
     html+="																";
     html+="	                                        <div class='caption big_red sft															";
     html+="												easeOutExpo   easeOutExpo				";
     html+="												"
     html+="                                                 data-x='123'";
     html+="	                                             data-y='171'															";
     html+="	                                             data-speed='300'															";
     html+="	                                             data-start='1053'															";
     html+="	                                             data-easing='easeOutExpo'>															";
     html+="	25															";
     html+="	                                        </div>															";
     html+="																";
     html+="																";
     html+="																";
     html+="																";
     html+="	                                        <!-- THE MAIN IMAGE IN THE SLIDE -->															";
     html+="																";
     html+="																";
     html+="	                                        <div class='caption small_red sft															";
     html+="												easeOutExpo   easeOutExpo				";
     html+="												"
     html+="                                                 data-x=231'";
     html+="	                                             data-y='179'															";
     html+="	                                             data-speed='300'															";
     html+="	                                             data-start='1497'															";
     html+="	                                             data-easing='easeOutExpo'>															";
     html+="	                                            %															";
     html+="	                                        </div>															";
     html+="																";
     html+="																";
     html+="																";
     html+="																";
     html+="	                                        <!-- THE MAIN IMAGE IN THE SLIDE -->															";
     html+="																";
     html+="																";
     html+="	                                        <div class='caption big_black sfr															";
     html+="												easeOutExpo   easeOutExpo				";
     html+="												"
     html+="                                                 data-x=277'";
     html+="	                                             data-y='177'															";
     html+="	                                             data-speed='300'															";
     html+="	                                             data-start='2044'															";
     html+="	                                             data-easing='easeOutExpo'>															";
     html+="	                                            OFF															";
     html+="	                                        </div>															";
     html+="																";
     html+="																";
     html+="																";
     html+="																";
     html+="	                                        <!-- THE MAIN IMAGE IN THE SLIDE -->															";
     html+="																";
     html+="																";
     html+="	                                        <div class='caption medium_black sfb															";
     html+="												easeOutExpo   easeOutExpo				";
     html+="												"
     html+="                                                 data-x=112'";
     html+="	                                             data-y='266'															";
     html+="	                                             data-speed='300'															";
     html+="	                                             data-start='2771'															";
     html+="	                                             data-easing='easeOutExpo'>															";
     html+="	                                            Wash cool save energy a revolution in washing															";
     html+="	                                        </div>															";
     html+="																";
     html+="																";
     html+="																";
     html+="																";
     html+="	                                        <!-- THE MAIN IMAGE IN THE SLIDE -->															";
     html+="																";
     html+="																";
     html+="	                                        <div class='caption btn-links btn-inverse sfb															";
     html+="												easeOutExpo   easeOutExpo				";
     html+="												"
     html+="                                                 data-x=119'";
     html+="	                                             data-y='323'															";
     html+="	                                             data-speed='300'															";
     html+="	                                             data-start='3481'															";
     html+="	                                             data-easing='easeOutExpo'>															";
     html+="	                                            view collection															";
     html+="	                                        </div>															";
     html+="																";
     html+="																";
     html+="																";
     html+="																";
     html+="	                                        <!-- THE MAIN IMAGE IN THE SLIDE -->															";
     html+="																";
     html+="																";
     html+="	                                        <div class='caption  sfr															";
     html+="												easeOutExpo   easeOutExpo				";
     html+="												"
     html+="                                                 data-x=993'";
     html+="	                                             data-y='0'															";
     html+="	                                             data-speed='300'															";
     html+="	                                             data-start='3874'															";
     html+="	                                             data-easing='easeOutExpo'>															";
     html+="																";
     html+="	                                            <img src='image/catalog/layerslider/special-1.png' alt='catalog/layerslider/special-1.png' />															";
     html+="																";
     html+="	                                        </div>															";
     html+="																";
     html+="																";
     html+="	                                    </li>															";
     html+="																";
     html+="	                                     <!--End-->															";
     html+="	                                </ul>															";
     html+="																";
     html+="	                                <div class='tp-bannertimer tp-top'></div>															";
     html+="	                            </div>															";
     html+="	                        </div>															";
     html+="	                        <!--															";
     html+="	                        ##############################															";
     html+="	                         - ACTIVATE THE BANNER HERE -															";
     html+="	                        ##############################															";
     html+="	                        -->															";
     html+="	                        <script type='text/javascript'>															";
     html+="	                            var tpj = jQuery;															";
     html+="	                            if (tpj.fn.cssOriginal != undefined)															";
     html+="	                                tpj.fn.css = tpj.fn.cssOriginal;															";
     html+="																";
     html+="	                            tpj('#sliderlayer285765615').revolution(															";
     html+="	                                {															";
     html+="	                                    delay: 9000,															";
     html+="	                                    startheight: 480,															";
     html+="	                                    startwidth: 1170,															";
     html+="																";
     html+="																";
     html+="	                                    hideThumbs: 200,															";
     html+="																";
     html+="	                                    thumbWidth: 100,															";
     html+="	                                    thumbHeight: 50,															";
     html+="	                                    thumbAmount: 5,															";
     html+="																";
     html+="	                                    navigationType: 'none',															";
     html+="	                                    navigationArrows: 'verticalcentered',															";
     html+="	                                    navigationStyle: 'round',															";
     html+="																";
     html+="	                                    navOffsetHorizontal: 0,															";
     html+="	                                    navOffsetVertical: 20,															";
     html+="																";
     html+="	                                    touchenabled: 'on',															";
     html+="	                                    onHoverStop: 'on',															";
     html+="	                                    shuffle: 'off',															";
     html+="	                                    stopAtSlide: -1,															";
     html+="	                                    stopAfterLoops: -1,															";
     html+="																";
     html+="	                                    hideCaptionAtLimit: 0,															";
     html+="	                                    hideAllCaptionAtLilmit: 0,															";
     html+="	                                    hideSliderAtLimit: 0,															";
     html+="	                                    fullWidth: 'on',															";
     html+="	                                    shadow: 0															";
     html+="																";
     html+="	                                });															";
     html+="																";
     html+="	                        </script>															";
     html+="	                    </div>															";
     html+="	                </div>															";
     html+="	            </div>															";
     html+="	        </div>															";
     html+="	    </div>															";


 }
