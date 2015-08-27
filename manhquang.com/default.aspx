﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="manhquang.com._default" %>

<!DOCTYPE html>
<html dir="ltr" class="ltr" lang="vi">
<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Mạnh Quang</title>
    <link href="images/favicon.ico" rel="icon" />  
    <script src="JS/FRAMEWORK/Include.JS.Base.js"></script>
    <script src="JS/FRAMEWORK/Include.JS.Framework.js"></script>
    <script src="JS/FRAMEWORK/Include.JS.Extend.js"></script>
    
     <script type="text/javascript">
         // khởi tạo ngôn ngữ mặc định
         Init_System_WEB();

         window.onload = function () {
     
             Load_MenuTop("#verticalmenu");

         
         };
          </script>
  
</head>
<body class="main-menu-fixed common-home page-home layout-fullwidth">
    <div class="row-offcanvas row-offcanvas-left">
        <div id="page">
            <section id="header-top">
                <div id="topbar">
                    <div class="container">
                        <div class="show-desktop">

                            <!--Button -->
                            <div class="quick-top-link  links pull-right">
                                <!-- language -->
                                <div class="btn-group box-language">
                                </div>
                                <!-- currency -->
                                <div class="btn-group box-currency">
                                    <div class="quick-access">
                                        <form action="#" method="post" enctype="multipart/form-data" id="currency">
                                            <div class="btn-groups">
                                                <div class="dropdown-toggle" data-toggle="dropdown">
                                                    <span>Ngôn Ngữ</span>
                                                    <i class="fa fa-angle-down"></i>
                                                </div>
                                                <div class="dropdown-menu ">
                                                    <div class="box-currency inner">
                                                        <a href="javascript:void(0);" class="currency-select" id="EUR">
                                                            <span>VN</span>
                                                        </a>
                                                        <a href="javascript:void(0);" class="currency-select" id="GBP">
                                                            <span>EN</span>
                                                        </a>
                                                        <a href="javascript:void(0);" class="currency-select" id="USD">
                                                            <span>JP</span>
                                                        </a>
                                                    </div>
                                                </div>
                                            </div>
                                            <input type="hidden" name="code" value="" />
                                            <input type="hidden" name="redirect" value="index9328.html?route=common/home" />
                                        </form>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
                <!-- header -->
                <div class="has-verticalmenu">
                    <%--logo--%>
                    <header id="header">
                        <div id="header-main" class="hasverticalmenu">
                            <div class="container">
                                <div class="row">
                                    <div class="logo inner  col-lg-3 col-md-3 col-sm-3 col-xs-12">
                                        <div id="logo-theme" class="logo-store pull-left">
                                            <a href="/">
                                                <span>Mạnh Quang</span>
                                            </a>
                                        </div>
                                    </div>
                                    <div class="inner col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                        <div id="search-auto" class=" search-box search-wrapper clearfix clearfix">
                                            <div class=" search_block">
                                                <form method="GET" action="http://dothotuongphat.com/index.php" class="input-group search-box">
                                                    <div class="filter_type category_filter input-group-addon group-addon-select icon-select">
                                                        <select name="category_id" class="no-border">
                                                            <option value="0">Tất cả Danh Mục</option>
                                                            <option value="67">Nhông</option>                                                           
                                                            <option value="73">Xích</option>
                                                        </select>
                                                    </div>
                                                    <div id="search0" class="search-input-wrapper clearfix clearfixs input-group">
                                                        <input type="text" value="" size="35" autocomplete="off" placeholder="Tìm" name="search" class="form-control input-lg input-search">

                                                        <span class="input-group-addon input-group-search">
                                                            <button class="fa fa-search"></button>
                                                            <button class="button-search ">
                                                                Tìm
                                                            </button>
                                                        </span>
                                                    </div>
                                                    <input type="hidden" name="sub_category" value="1" class="sub_category" />
                                                    <input type="hidden" name="route" value="product/search" />
                                                    <input type="hidden" name="sub_category" value="true" class="sub_category" />
                                                    <input type="hidden" name="description" value="true" id="description" />
                                                </form>
                                                <div class="clear clr"></div>
                                            </div>
                                            <%--<script type="text/javascript">

                                                /* Autocomplete */
                                                (function ($) {
                                                    function Autocomplete1(element, options) {
                                                        this.element = element;
                                                        this.options = options;
                                                        this.timer = null;
                                                        this.items = new Array();

                                                        $(element).attr('autocomplete', 'off');
                                                        $(element).on('focus', $.proxy(this.focus, this));
                                                        $(element).on('blur', $.proxy(this.blur, this));
                                                        $(element).on('keydown', $.proxy(this.keydown, this));

                                                        $(element).after('<ul class="dropdown-menu autosearch"></ul>');
                                                        $(element).siblings('ul.dropdown-menu').delegate('a', 'click', $.proxy(this.click, this));
                                                    }

                                                    Autocomplete1.prototype = {
                                                        focus: function () {
                                                            this.request();
                                                        },
                                                        blur: function () {
                                                            setTimeout(function (object) {
                                                                object.hide();
                                                            }, 200, this);
                                                        },
                                                        click: function (event) {
                                                            event.preventDefault();
                                                            value = $(event.target).parent().attr("href");
                                                            if (value) {
                                                                window.location = value.replace(/&amp;/gi, '&');
                                                            }
                                                        },
                                                        keydown: function (event) {
                                                            switch (event.keyCode) {
                                                                case 27: // escape
                                                                    this.hide();
                                                                    break;
                                                                default:
                                                                    this.request();
                                                                    break;
                                                            }
                                                        },
                                                        show: function () {
                                                            var pos = $(this.element).position();

                                                            $(this.element).siblings('ul.dropdown-menu').css({
                                                                top: pos.top + $(this.element).outerHeight(),
                                                                left: pos.left
                                                            });

                                                            $(this.element).siblings('ul.dropdown-menu').show();
                                                        },
                                                        hide: function () {
                                                            $(this.element).siblings('ul.dropdown-menu').hide();
                                                        },
                                                        request: function () {
                                                            clearTimeout(this.timer);

                                                            this.timer = setTimeout(function (object) {
                                                                object.options.source($(object.element).val(), $.proxy(object.response, object));
                                                            }, 200, this);
                                                        },
                                                        response: function (json) {
                                                            console.log(json);
                                                            html = '';

                                                            if (json.length) {
                                                                for (i = 0; i < json.length; i++) {
                                                                    this.items[json[i]['value']] = json[i];
                                                                }

                                                                for (i = 0; i < json.length; i++) {
                                                                    if (!json[i]['category']) {
                                                                        html += '<li class="media" data-value="' + json[i]['value'] + '">';
                                                                        if (json[i]['simage']) {
                                                                            html += '	<a class="media-left" href="' + json[i]['link'] + '"><img  src="' + json[i]['image'] + '"></a>';
                                                                        }
                                                                        html += '<div class="media-body">';
                                                                        html += '	<a  href="' + json[i]['link'] + '"><span>' + json[i]['label'] + '</span></a>';
                                                                        if (json[i]['sprice']) {
                                                                            html += '	<div>';
                                                                            if (!json[i]['special']) {
                                                                                html += json[i]['price'];
                                                                            } else {
                                                                                html += '<span class="price-old">' + json[i]['price'] + '</span><span class="price-new">' + json[i]['special'] + '</span>';
                                                                            }
                                                                            if (json[i]['tax']) {
                                                                                html += '<br />';
                                                                                html += '<span class="price-tax">text_tax : ' + json[i]['tax'] + '</span>';
                                                                            }
                                                                            html += '	</div> </div>';
                                                                        }
                                                                        html += '</li>';
                                                                    }
                                                                }
                                                                //html += '<li><a href="index.php?route=product/search&search='+g.term+'&category_id='+category_id+'&sub_category=true&description=true" onclick="window.location=this.href">'+text_view_all+'</a></li>';

                                                                // Get all the ones with a categories
                                                                var category = new Array();
                                                                for (i = 0; i < json.length; i++) {
                                                                    if (json[i]['category']) {
                                                                        if (!category[json[i]['category']]) {
                                                                            category[json[i]['category']] = new Array();
                                                                            category[json[i]['category']]['name'] = json[i]['category'];
                                                                            category[json[i]['category']]['item'] = new Array();
                                                                        }
                                                                        category[json[i]['category']]['item'].push(json[i]);
                                                                    }
                                                                }
                                                                for (i in category) {
                                                                    html += '<li class="dropdown-header">' + category[i]['name'] + '</li>';
                                                                    for (j = 0; j < category[i]['item'].length; j++) {
                                                                        html += '<li data-value="' + category[i]['item'][j]['value'] + '"><a href="#">&nbsp;&nbsp;&nbsp;' + category[i]['item'][j]['label'] + '</a></li>';
                                                                    }
                                                                }
                                                            }
                                                            if (html) {
                                                                this.show();
                                                            } else {
                                                                this.hide();
                                                            }
                                                            $(this.element).siblings('ul.dropdown-menu').html(html);
                                                        }
                                                    };

                                                    $.fn.autocomplete1 = function (option) {
                                                        return this.each(function () {
                                                            var data = $(this).data('autocomplete');
                                                            if (!data) {
                                                                data = new Autocomplete1(this, option);
                                                                $(this).data('autocomplete', data);
                                                            }
                                                        });
                                                    }
                                                })(window.jQuery);
                                                $(document).ready(function () {
                                                    var selector = '#search0';
                                                    var total = 0;
                                                    var show_image = true;
                                                    var show_price = true;
                                                    var search_sub_category = true;
                                                    var search_description = true;
                                                    var width = 102;
                                                    var height = 102;

                                                    $(selector).find('input[name=\'search\']').autocomplete1({
                                                        delay: 500,
                                                        source: function (request, response) {
                                                            var category_id = $(".category_filter select[name=\"category_id\"]").first().val();
                                                            if (typeof (category_id) == 'undefined')
                                                                category_id = 0;
                                                            var limit = 5;
                                                            var search_sub_category = search_sub_category ? '&sub_category=true' : '';
                                                            var search_description = search_description ? '&description=true' : '';
                                                            $.ajax({
                                                                url: 'index.php?route=module/pavautosearch/autocomplete&filter_category_id=' + category_id + '&width=' + width + '&height=' + height + '&limit=' + limit + search_sub_category + search_description + '&filter_name=' + encodeURIComponent(request),
                                                                dataType: 'json',
                                                                success: function (json) {
                                                                    response($.map(json, function (item) {
                                                                        if ($('.pavautosearch_result')) {
                                                                            $('.pavautosearch_result').first().html("");
                                                                        }
                                                                        total = 0;
                                                                        if (item.total) {
                                                                            total = item.total;
                                                                        }
                                                                        return {
                                                                            price: item.price,
                                                                            speical: item.special,
                                                                            tax: item.tax,
                                                                            label: item.name,
                                                                            image: item.image,
                                                                            link: item.link,
                                                                            value: item.product_id,
                                                                            sprice: show_price,
                                                                            simage: show_image,
                                                                        }
                                                                    }));
                                                                }
                                                            });
                                                        },
                                                    }); // End Autocomplete

                                                });// End document.ready

                                            </script>--%>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </header>
                    <%--end logo--%>
                    <section id="pav-masshead" class="pav-masshead aligned-right">
                        <!--menu-->
                        <div class="container">
    <div class="inner row clearfix">
        <!--menu doc-->
        <div id="hideverticalmenu" class="col-lg-3 col-md-3 col-sm-4 hidden-xs">
            <div id="pav-verticalmenu" class="pav-verticalmenu hasicon box box-highlighted hidden-xs">
                <div class="box-heading">
                    <span>Danh Mục</span>
                </div>
                <div class="box-content">
                   <%--bat dau menu do--%>
                    <div id="verticalmenu" class="verticalmenus" role="navigation">
                        
                    </div>
                </div>
            </div>
        </div>
        <!--end menu doc-->
        <!--menu-->
        <div id="pav-mainnav" class="col-lg-9 col-md-9 col-sm-12">
            <div class="pav-megamenu">
                <div class="navbar navbar-mega" role="navigation">
                    <div id="mainmenutop" class="megamenu" role="navigation">
                        <div class="show-mobile hidden-lg hidden-md">
                            <div class="quick-access pull-left">
                                <button data-toggle="offcanvas" class="btn btn-outline visible-xs visible-sm" type="button"><span class="fa fa-bars"></span></button>
                            </div>
                        </div>
                        <div class="collapse navbar-collapse" id="bs-megamenu">
                            <ul class="nav navbar-nav megamenu">
                                <li class="home"><a href="/"><span class=""></span><span class="menu-title">Trang chủ</span></a></li>
                                <li class=" aligned-fullwidth parent dropdown ">
                                    <a href="product.aspx" class="dropdown-toggle" data-toggle="dropdown">
                                        <span class=""></span>
                                        <span class="menu-title">Sản phẩm</span><b class="caret"></b></a>
                                        <div class="dropdown-menu">
                                        <div class="dropdown-menu-inner">
                                            <div class="row">
                                                <%--menu cha--%>
                                                <div class="mega-col col-xs-12 col-sm-12 col-md-3 ">
                                                    <div class="mega-col-inner">
                                                        <div class="pavo-widget" id="pavowid-26">
                                                            <div class="pavo-widget" id="pavowid-735143602">
                                                                <h4 class="widget-heading title">2</h4>
                                                                <div class="">
                                                                    <ul class="content">
                                                                       <%--con--%> 
                                                                        <li>
                                                                            <a href="#">
                                                                                <span>21</span>
                                                                            </a>
                                                                        </li>
                                                                       
                                                                        <%--end con--%>
                                                                    </ul>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                               <%--end cha--%>
                                            </div>
                                        </div>
                                    </div>
                                </li>
                                <li class=""><a href="#"><span class=""></span><span class="menu-title">Giới Thiệu</span></a></li>
                                <li class=""><a href="#"><span class=""></span><span class="menu-title">Liên Hệ</span></a></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!--end menu-->
    </div>
</div>
                    </section>
                </div>
                <!-- /header -->
            </section>
            <!-- sys-notification -->
            <div id="sys-notification">
                <div class="container">
                    <div id="notification"></div>
                </div>
            </div>
            <!-- /sys-notification -->
            <div class="slideshow " id="pavo-slideshow">
                <div class="container-full">
                    <div class="inner">
                        <div class="row">
                            <div class="col-lg-12 col-md-12  ">
                                <div class="layerslider">
                                    <div class="bannercontainer banner-fullwidth" style="padding: 0px 0px;margin: 0px 0px 0px;">
                                        <div id="sliderlayer" class="rev_slider fullwidthbanner" style="width:100%;height:480px; ">
                                            <ul>
                                                <li data-masterspeed="300" data-transition="random" data-slotamount="7" data-thumb="images/Slider/Top/slider-bg1.jpg">
                                                    <img src="images/Slider/Top/slider-bg1.jpg" alt="Image 0" />
                                                    <!-- THE MAIN IMAGE IN THE SLIDE -->


                                                    <div class="caption big_great sft
											easeOutExpo   easeOutExpo
											"
                                                         data-x="112"
                                                         data-y="77"
                                                         data-speed="300"
                                                         data-start="400"
                                                         data-easing="easeOutExpo">
                                                        Get into new season
                                                    </div>




                                                    <!-- THE MAIN IMAGE IN THE SLIDE -->


                                                    <div class="caption big_red sft
											easeOutExpo   easeOutExpo
											"
                                                         data-x="123"
                                                         data-y="171"
                                                         data-speed="300"
                                                         data-start="1053"
                                                         data-easing="easeOutExpo">
                                                        25
                                                    </div>




                                                    <!-- THE MAIN IMAGE IN THE SLIDE -->


                                                    <div class="caption small_red sft
											easeOutExpo   easeOutExpo
											"
                                                         data-x="231"
                                                         data-y="179"
                                                         data-speed="300"
                                                         data-start="1497"
                                                         data-easing="easeOutExpo">
                                                        %
                                                    </div>




                                                    <!-- THE MAIN IMAGE IN THE SLIDE -->


                                                    <div class="caption big_black sfr
											easeOutExpo   easeOutExpo
											"
                                                         data-x="277"
                                                         data-y="177"
                                                         data-speed="300"
                                                         data-start="2044"
                                                         data-easing="easeOutExpo">
                                                        OFF
                                                    </div>




                                                    <!-- THE MAIN IMAGE IN THE SLIDE -->


                                                    <div class="caption medium_black sfb
											easeOutExpo   easeOutExpo
											"
                                                         data-x="112"
                                                         data-y="266"
                                                         data-speed="300"
                                                         data-start="2771"
                                                         data-easing="easeOutExpo">
                                                        Wash cool save energy a revolution in washing
                                                    </div>




                                                    <!-- THE MAIN IMAGE IN THE SLIDE -->


                                                    <div class="caption btn-links btn-inverse sfb
											easeOutExpo   easeOutExpo
											"
                                                         data-x="119"
                                                         data-y="323"
                                                         data-speed="300"
                                                         data-start="3481"
                                                         data-easing="easeOutExpo">
                                                        view collection
                                                    </div>




                                                    <!-- THE MAIN IMAGE IN THE SLIDE -->


                                                    <div class="caption  sfr
											easeOutExpo   easeOutExpo
											"
                                                         data-x="993"
                                                         data-y="0"
                                                         data-speed="300"
                                                         data-start="3874"
                                                         data-easing="easeOutExpo">

                                                      <%--  <img src="images/Slider/Top/special-1.png" alt="special" />--%>

                                                    </div>


                                                </li>



                                                <li data-masterspeed="300" data-transition="random" data-slotamount="7" data-thumb="images/Slider/Top/slide_06.JPG">


                                                    <img src="images/Slider/Top/slide_06.JPG" alt="Image 1" />




                                                    <!-- THE MAIN IMAGE IN THE SLIDE -->


                                                    <div class="caption big_great sft
											easeOutExpo   easeOutExpo
											"
                                                         data-x="717"
                                                         data-y="17"
                                                         data-speed="300"
                                                         data-start="400"
                                                         data-easing="easeOutExpo">
                                                        Get into new season
                                                    </div>




                                                    <!-- THE MAIN IMAGE IN THE SLIDE -->


                                                    <div class="caption big_red sft
											easeOutExpo   easeOutExpo
											"
                                                         data-x="722"
                                                         data-y="100"
                                                         data-speed="300"
                                                         data-start="1053"
                                                         data-easing="easeOutExpo">
                                                        25
                                                    </div>




                                                    <!-- THE MAIN IMAGE IN THE SLIDE -->


                                                    <div class="caption small_red sft
											easeOutExpo   easeOutExpo
											"
                                                         data-x="823"
                                                         data-y="113"
                                                         data-speed="300"
                                                         data-start="1497"
                                                         data-easing="easeOutExpo">
                                                        %
                                                    </div>




                                                    <!-- THE MAIN IMAGE IN THE SLIDE -->


                                                    <div class="caption big_black sfr
											easeOutExpo   easeOutExpo
											"
                                                         data-x="880"
                                                         data-y="104"
                                                         data-speed="300"
                                                         data-start="2044"
                                                         data-easing="easeOutExpo">
                                                        OFF
                                                    </div>




                                                    <!-- THE MAIN IMAGE IN THE SLIDE -->


                                                    <div class="caption medium_roboto_white sfb
											easeOutExpo   easeOutExpo
											"
                                                         data-x="722"
                                                         data-y="188"
                                                         data-speed="300"
                                                         data-start="2771"
                                                         data-easing="easeOutExpo">
                                                        Wash cool save energy a revolution in washing
                                                    </div>




                                                    <!-- THE MAIN IMAGE IN THE SLIDE -->


                                                    <div class="caption btn-links btn-inverse sfb
											easeOutExpo   easeOutExpo
											"
                                                         data-x="732"
                                                         data-y="241"
                                                         data-speed="300"
                                                         data-start="3481"
                                                         data-easing="easeOutExpo">
                                                        view collection
                                                    </div>


                                                </li>



                                                <li data-masterspeed="300" data-transition="random" data-slotamount="7" data-thumb="images/Slider/Top/slider-bg2.JPG">


                                                    <img src="images/Slider/Top/slider-bg2.JPG" alt="Image 2" />




                                                    <!-- THE MAIN IMAGE IN THE SLIDE -->


                                                    <div class="caption big_great_white sft
											easeOutExpo   easeOutExpo
											"
                                                         data-x="112"
                                                         data-y="77"
                                                         data-speed="300"
                                                         data-start="400"
                                                         data-easing="easeOutExpo">
                                                        Get into new season
                                                    </div>




                                                    <!-- THE MAIN IMAGE IN THE SLIDE -->


                                                    <div class="caption big_red sft
											easeOutExpo   easeOutExpo
											"
                                                         data-x="123"
                                                         data-y="171"
                                                         data-speed="300"
                                                         data-start="1053"
                                                         data-easing="easeOutExpo">
                                                        25
                                                    </div>




                                                    <!-- THE MAIN IMAGE IN THE SLIDE -->


                                                    <div class="caption small_red sft
											easeOutExpo   easeOutExpo
											"
                                                         data-x="231"
                                                         data-y="179"
                                                         data-speed="300"
                                                         data-start="1497"
                                                         data-easing="easeOutExpo">
                                                        %
                                                    </div>




                                                    <!-- THE MAIN IMAGE IN THE SLIDE -->


                                                    <div class="caption big_white sfr
											easeOutExpo   easeOutExpo
											"
                                                         data-x="277"
                                                         data-y="177"
                                                         data-speed="300"
                                                         data-start="2044"
                                                         data-easing="easeOutExpo">
                                                        OFF
                                                    </div>




                                                    <!-- THE MAIN IMAGE IN THE SLIDE -->


                                                    <div class="caption medium_roboto_white sfb
											easeOutExpo   easeOutExpo
											"
                                                         data-x="112"
                                                         data-y="266"
                                                         data-speed="300"
                                                         data-start="2771"
                                                         data-easing="easeOutExpo">
                                                        Wash cool save energy a revolution in washing
                                                    </div>




                                                    <!-- THE MAIN IMAGE IN THE SLIDE -->


                                                    <div class="caption btn-links btn-outline sfb
											easeOutExpo   easeOutExpo
											"
                                                         data-x="119"
                                                         data-y="323"
                                                         data-speed="300"
                                                         data-start="3481"
                                                         data-easing="easeOutExpo">
                                                        view collection
                                                    </div>




                                                    <!-- THE MAIN IMAGE IN THE SLIDE -->


                                                    <div class="caption  sft
											easeOutExpo   easeOutExpo
											"
                                                         data-x="676"
                                                         data-y="0"
                                                         data-speed="300"
                                                         data-start="4208"
                                                         data-easing="easeOutExpo">

                                                        <%--<img src="image/catalog/layerslider/special-1.png" alt="catalog/layerslider/special-1.png" />--%>

                                                    </div>


                                                </li>






                                            </ul>
                                            <div class="tp-bannertimer tp-top"></div>
                                        </div>
                                    </div>
                                    <!--
                                    ##############################
                                     - ACTIVATE THE BANNER HERE -
                                    ##############################
                                    -->
                                    <script type="text/javascript">
                                        var tpj = jQuery;
                                        if (tpj.fn.cssOriginal != undefined)
                                            tpj.fn.css = tpj.fn.cssOriginal;

                                        tpj('#sliderlayer').revolution(
                                            {
                                                delay: 9000,
                                                startheight: 480,
                                                startwidth: 1170,


                                                hideThumbs: 200,

                                                thumbWidth: 100,
                                                thumbHeight: 50,
                                                thumbAmount: 5,

                                                navigationType: "none",
                                                navigationArrows: "verticalcentered",
                                                navigationStyle: "round",

                                                navOffsetHorizontal: 0,
                                                navOffsetVertical: 20,

                                                touchenabled: "on",
                                                onHoverStop: "on",
                                                shuffle: "off",
                                                stopAtSlide: -1,
                                                stopAfterLoops: -1,

                                                hideCaptionAtLimit: 0,
                                                hideAllCaptionAtLilmit: 0,
                                                hideSliderAtLimit: 0,
                                                fullWidth: "on",
                                                shadow: 0



                                            });





                                    </script>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <section class="promotion " id="pavo-promotion">
                <div class="container">
                    <div class="inner">
                        <div class="row">
                            <div class="col-lg-12 col-md-12  ">
                                <div class="box box-module-pavreassurances ">
                                    <div class="box-content">
                                        <div class="row box-outer">
                                            <div class="col-lg-3 col-md-3 col-sm-3 col-xs-12 column">
                                                <div class="reassurances-left">
                                                    <span class="icon-name pull-left fa fa-truck"></span>
                                                    <div class="description media-body">
                                                        <h4>Chính sách giao hàng</h4>
                                                        <p>Miễn phí vận chuyển<br></p>                                            <!-- Button trigger modal -->
                                                        <a href="javascript:void(0);" class="pavreassurances arrow" data-toggle="modal" data-target="#myModal1"></a>
                                                        <div class="mask" style="display:none;">
                                                            <div class="title_detail"><div class="description"><p class="MsoNormal"></p><div><span style="font-weight: bold;">CHÍNH SÁCH GIAO HÀNG</span></div><div><br></div><ul><li>Miễn phí cước vận chuyển đối với những đơn hàng trong nội thành Hà Nội</li><li>Miễn phí cước vận chuyển 50km đầu tiên cho các đơn hàng có giá trị trên 10 triệu đồng.</li></ul><p></p><p class="MsoNormal">Mọi thắc mắc xin liên hệ theo số điện thoại: <span style="font-weight: bold;">090 696 1286</span></p><p class="MsoNormal">Xin chân thành cảm ơn!</p></div></div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <!-- Modal -->
                                            <div class="modal fade" id="myModal1" tabindex="-1" role="dialog">
                                                <div class="modal-dialog">
                                                    <div class="modal-content">
                                                        <div class="modal-body">
                                                            <div class="title_detail"><div class="description"><p class="MsoNormal"></p><div><span style="font-weight: bold;">CHÍNH SÁCH GIAO HÀNG</span></div><div><br></div><ul><li>Miễn phí cước vận chuyển đối với những đơn hàng trong nội thành Hà Nội</li><li>Miễn phí cước vận chuyển 50km đầu tiên cho các đơn hàng có giá trị trên 10 triệu đồng.</li></ul><p></p><p class="MsoNormal">Mọi thắc mắc xin liên hệ theo số điện thoại: <span style="font-weight: bold;">090 696 1286</span></p><p class="MsoNormal">Xin chân thành cảm ơn!</p></div></div>
                                                        </div>
                                                        <div class="modal-footer">
                                                            <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-md-3 col-sm-3 col-xs-12 column">
                                                <div class="reassurances-left">
                                                    <span class="icon-name pull-left fa fa-money"></span>
                                                    <div class="description media-body">
                                                        <h4>Hỗ trợ sau bán hàng</h4>
                                                        <p>Sẵn sàng 24/7</p>                                            <!-- Button trigger modal -->
                                                        <a href="javascript:void(0);" class="pavreassurances arrow" data-toggle="modal" data-target="#myModal2"></a>
                                                        <div class="mask" style="display:none;">
                                                            <div class="title_detail"><div class="icon-name fa fa-life-ring pull-left">&nbsp;</div><div class="description"><h4><b style="font-size: 12px; line-height: 17.142858505249px; text-indent: -24px;"><span style="font-family: 'Times New Roman', serif;"><span style="font-weight: normal; font-stretch: normal; font-size: 7pt; line-height: normal; font-family: 'Times New Roman';">&nbsp; &nbsp;&nbsp;</span></span></b><b style="font-size: 12px; line-height: 17.142858505249px; text-indent: -24px;"><span style="font-family: 'Times New Roman', serif;">HỖ TRỢ SAU BÁN HÀNG</span></b></h4><h4><span style="font-family: 'Times New Roman', serif; line-height: 1.42857143; text-indent: -18pt; font-size: 12px;">Vấn đề hỗ trợ sau bán hàng&nbsp;sẽ quyết định đến sự hài lòng và mong muốn quay lại của các bạn đối với Siêu thị đồ thờ tượng phật Sơn Đồng.&nbsp;</span><span style="font-family: 'Times New Roman', serif; line-height: 1.42857143; font-size: 12px;">Hiểu được điều này, chúng tôi luôn sẵn sàng hỗ trợ khách hàng các vấn đề khi sử dụng sản phẩm đồ thờ của chúng tôi mọi lúc, bất kể khi nào quý khách cần.</span></h4><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">Quý khách cần một phương vị tốt nhất trong nhà để bày trí, một thời điểm thích hợp theo phong thủy&nbsp;để “an vị”, các lưu ý, những điều cần tránh, cách bảo quản, cáo mẹo hữu ích…tất cả đều không thành vấn đề.<o:p></o:p></span></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">Đừng ngần ngại gọi đến các số hotline của chúng tôi nếu bạn cần tư vấn, chuyên gia của chúng tôi sẽ đáp ứng mọi thắc mắc của quý khách.<o:p></o:p></span></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">Gọi 24/24 vào hotline: 0906961286 (Mr.Cương) hoặc 01677900901 (Mr.Hoàng)<o:p></o:p></span></p><p class="MsoNormal"><i style="line-height: 1.42857143;"><span style="font-size:11.0pt;line-height:115%;font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-fareast-font-family:&quot;Times New Roman&quot;;mso-fareast-theme-font:minor-fareast;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin;mso-ansi-language:VI;mso-fareast-language:VI;mso-bidi-language:AR-SA">Siêu thị đồ thờ tượng phật Sơn Đồng luôn sẵn sàng để phục vụ quý khách<b>!</b></span></i></p></div></div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <!-- Modal -->
                                            <div class="modal fade" id="myModal2" tabindex="-1" role="dialog">
                                                <div class="modal-dialog">
                                                    <div class="modal-content">
                                                        <div class="modal-body">
                                                            <div class="title_detail"><div class="icon-name fa fa-life-ring pull-left">&nbsp;</div><div class="description"><h4><b style="font-size: 12px; line-height: 17.142858505249px; text-indent: -24px;"><span style="font-family: 'Times New Roman', serif;"><span style="font-weight: normal; font-stretch: normal; font-size: 7pt; line-height: normal; font-family: 'Times New Roman';">&nbsp; &nbsp;&nbsp;</span></span></b><b style="font-size: 12px; line-height: 17.142858505249px; text-indent: -24px;"><span style="font-family: 'Times New Roman', serif;">HỖ TRỢ SAU BÁN HÀNG</span></b></h4><h4><span style="font-family: 'Times New Roman', serif; line-height: 1.42857143; text-indent: -18pt; font-size: 12px;">Vấn đề hỗ trợ sau bán hàng&nbsp;sẽ quyết định đến sự hài lòng và mong muốn quay lại của các bạn đối với Siêu thị đồ thờ tượng phật Sơn Đồng.&nbsp;</span><span style="font-family: 'Times New Roman', serif; line-height: 1.42857143; font-size: 12px;">Hiểu được điều này, chúng tôi luôn sẵn sàng hỗ trợ khách hàng các vấn đề khi sử dụng sản phẩm đồ thờ của chúng tôi mọi lúc, bất kể khi nào quý khách cần.</span></h4><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">Quý khách cần một phương vị tốt nhất trong nhà để bày trí, một thời điểm thích hợp theo phong thủy&nbsp;để “an vị”, các lưu ý, những điều cần tránh, cách bảo quản, cáo mẹo hữu ích…tất cả đều không thành vấn đề.<o:p></o:p></span></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">Đừng ngần ngại gọi đến các số hotline của chúng tôi nếu bạn cần tư vấn, chuyên gia của chúng tôi sẽ đáp ứng mọi thắc mắc của quý khách.<o:p></o:p></span></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">Gọi 24/24 vào hotline: 0906961286 (Mr.Cương) hoặc 01677900901 (Mr.Hoàng)<o:p></o:p></span></p><p class="MsoNormal"><i style="line-height: 1.42857143;"><span style="font-size:11.0pt;line-height:115%;font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-fareast-font-family:&quot;Times New Roman&quot;;mso-fareast-theme-font:minor-fareast;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin;mso-ansi-language:VI;mso-fareast-language:VI;mso-bidi-language:AR-SA">Siêu thị đồ thờ tượng phật Sơn Đồng luôn sẵn sàng để phục vụ quý khách<b>!</b></span></i></p></div></div>
                                                        </div>
                                                        <div class="modal-footer">
                                                            <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-md-3 col-sm-3 col-xs-12 column">
                                                <div class="reassurances-left">
                                                    <span class="icon-name pull-left fa fa-smile-o"></span>
                                                    <div class="description media-body">
                                                        <h4>Hướng dẫn</h4>
                                                        <p>Mua hàng &amp; Thanh toán</p>                                            <!-- Button trigger modal -->
                                                        <a href="javascript:void(0);" class="pavreassurances arrow" data-toggle="modal" data-target="#myModal3"></a>
                                                        <div class="mask" style="display:none;">
                                                            <div class="title_detail"><div class="icon-name fa fa-smile-o pull-left">&nbsp;</div><div class="description"><h4>Mua hàng &amp; Thanh toán</h4><h1 class="title" style="margin-bottom: 20px; padding: 0px; border: 0px; outline: 0px; font-size: 16px; vertical-align: baseline; font-family: Arial, Helvetica, Arial, sans-serif; color: rgb(51, 51, 51); position: relative; line-height: 15px; background: rgb(255, 255, 255);">Hướng Dẫn</h1><div class="entry" style="margin: 0px; padding: 0px; border: 0px; outline: 0px; vertical-align: baseline; color: rgb(0, 0, 0); font-family: Arial, Helvetica, sans-serif; line-height: 18px; background: rgb(255, 255, 255);"><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">1. Mua hàng trực tiếp và thanh toán bằng tiền mặt<o:p></o:p></span></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">Dùng cho hình thức mua hàng tại xưởng hoặc giao hàng tận nơi tạiHà Nội. Bạn thanh toán trực tiếp cho nhân viên giao hàng sau khi nhận hàng.<o:p></o:p></span></p><p class="MsoNormal"><i><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">Miễn phí giaohàng cho các đơn hàng trên 10 triệu!</span></i></p><p class="MsoNormal"><i><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin"><o:p><br></o:p></span></i></p><p class="MsoNormal"><span style="font-family: 'Times New Roman', serif;">2. Mua hàng từ xa và thanh toán bằng chuyển khoản qua Ngân Hàng (hoặc thẻ ATM)</span><br></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">Áp dụng đối với các khách hàng ở tỉnh xa hoặc việc đi lại, giao nhậnhàng thông thường gặp khó khăn<o:p></o:p></span></p><p class="MsoListParagraph" style="margin-left:25.1pt;mso-add-space:auto;text-indent:-18.0pt;mso-list:l0 level1 lfo1;tab-stops:list 25.1pt left 157.25pt"><!--[if !supportLists]--><span style="font-size:10.0pt;mso-bidi-font-size:11.0pt;line-height:115%;font-family:Wingdings;mso-fareast-font-family:Wingdings;mso-bidi-font-family:Wingdings">v<span style="font-stretch: normal; font-size: 7pt; line-height: normal; font-family: 'Times New Roman';">&nbsp; </span></span><!--[endif]--><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">Tại ngân hàngVietcombank (Ngân hàng Ngoại thương Việt Nam)<o:p></o:p></span></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">+ Tên chủ TK: Nguyễn Doãn Cương<o:p></o:p></span></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">+ Tài khoản số: 0011004240078<o:p></o:p></span></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">+ Ngân hàng Vietcombank, chi nhánh Hà Tây (Tp.Hà Nội)<o:p></o:p></span></p><p class="MsoListParagraph" style="margin-left:25.1pt;mso-add-space:auto;text-indent:-18.0pt;mso-list:l0 level1 lfo1;tab-stops:list 25.1pt"><!--[if !supportLists]--><span style="font-size:10.0pt;mso-bidi-font-size:11.0pt;line-height:115%;font-family:Wingdings;mso-fareast-font-family:Wingdings;mso-bidi-font-family:Wingdings">v<span style="font-stretch: normal; font-size: 7pt; line-height: normal; font-family: 'Times New Roman';">&nbsp; </span></span><!--[endif]--><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">Tại ngân hàngVietinbank (Ngân hàng Công Thương Việt Nam)<o:p></o:p></span></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">+ Tên chủ TK: Nguyễn Doãn Cương<o:p></o:p></span></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">+ Tài khoản số: 711AC0599593<o:p></o:p></span></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">+ Ngân hàng Vietinbank, Chi nhánh Tây Hà Nội (Tp.Hà Nội)<o:p></o:p></span></p><p class="MsoListParagraph" style="margin-left:25.1pt;mso-add-space:auto;text-indent:-18.0pt;mso-list:l0 level1 lfo1;tab-stops:list 25.1pt"><!--[if !supportLists]--><span style="font-size:10.0pt;mso-bidi-font-size:11.0pt;line-height:115%;font-family:Wingdings;mso-fareast-font-family:Wingdings;mso-bidi-font-family:Wingdings">v<span style="font-stretch: normal; font-size: 7pt; line-height: normal; font-family: 'Times New Roman';">&nbsp; </span></span><!--[endif]--><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">Tại ngân hàngTienPhongBank (Ngân hàng TMCP Tiên Phong)<o:p></o:p></span></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">+ Tên chủ TK: Nguyễn Doãn Cương<o:p></o:p></span></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">+ Tài khoản số: 00018766001<o:p></o:p></span></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">+ Ngân hàng TienPhongBank, Chi nhánh Phạm Hùng (Tp.Hà Nội)</span></p><p class="MsoNormal"><i><span style="font-family: 'Times New Roman', serif;">Miễn phí giao hàng 40km đầu tiên cho các đơn hàng trên 10 triệu!</span></i></p></div></div></div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <!-- Modal -->
                                            <div class="modal fade" id="myModal3" tabindex="-1" role="dialog">
                                                <div class="modal-dialog">
                                                    <div class="modal-content">
                                                        <div class="modal-body">
                                                            <div class="title_detail"><div class="icon-name fa fa-smile-o pull-left">&nbsp;</div><div class="description"><h4>Mua hàng &amp; Thanh toán</h4><h1 class="title" style="margin-bottom: 20px; padding: 0px; border: 0px; outline: 0px; font-size: 16px; vertical-align: baseline; font-family: Arial, Helvetica, Arial, sans-serif; color: rgb(51, 51, 51); position: relative; line-height: 15px; background: rgb(255, 255, 255);">Hướng Dẫn</h1><div class="entry" style="margin: 0px; padding: 0px; border: 0px; outline: 0px; vertical-align: baseline; color: rgb(0, 0, 0); font-family: Arial, Helvetica, sans-serif; line-height: 18px; background: rgb(255, 255, 255);"><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">1. Mua hàng trực tiếp và thanh toán bằng tiền mặt<o:p></o:p></span></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">Dùng cho hình thức mua hàng tại xưởng hoặc giao hàng tận nơi tạiHà Nội. Bạn thanh toán trực tiếp cho nhân viên giao hàng sau khi nhận hàng.<o:p></o:p></span></p><p class="MsoNormal"><i><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">Miễn phí giaohàng cho các đơn hàng trên 10 triệu!</span></i></p><p class="MsoNormal"><i><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin"><o:p><br></o:p></span></i></p><p class="MsoNormal"><span style="font-family: 'Times New Roman', serif;">2. Mua hàng từ xa và thanh toán bằng chuyển khoản qua Ngân Hàng (hoặc thẻ ATM)</span><br></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">Áp dụng đối với các khách hàng ở tỉnh xa hoặc việc đi lại, giao nhậnhàng thông thường gặp khó khăn<o:p></o:p></span></p><p class="MsoListParagraph" style="margin-left:25.1pt;mso-add-space:auto;text-indent:-18.0pt;mso-list:l0 level1 lfo1;tab-stops:list 25.1pt left 157.25pt"><!--[if !supportLists]--><span style="font-size:10.0pt;mso-bidi-font-size:11.0pt;line-height:115%;font-family:Wingdings;mso-fareast-font-family:Wingdings;mso-bidi-font-family:Wingdings">v<span style="font-stretch: normal; font-size: 7pt; line-height: normal; font-family: 'Times New Roman';">&nbsp; </span></span><!--[endif]--><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">Tại ngân hàngVietcombank (Ngân hàng Ngoại thương Việt Nam)<o:p></o:p></span></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">+ Tên chủ TK: Nguyễn Doãn Cương<o:p></o:p></span></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">+ Tài khoản số: 0011004240078<o:p></o:p></span></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">+ Ngân hàng Vietcombank, chi nhánh Hà Tây (Tp.Hà Nội)<o:p></o:p></span></p><p class="MsoListParagraph" style="margin-left:25.1pt;mso-add-space:auto;text-indent:-18.0pt;mso-list:l0 level1 lfo1;tab-stops:list 25.1pt"><!--[if !supportLists]--><span style="font-size:10.0pt;mso-bidi-font-size:11.0pt;line-height:115%;font-family:Wingdings;mso-fareast-font-family:Wingdings;mso-bidi-font-family:Wingdings">v<span style="font-stretch: normal; font-size: 7pt; line-height: normal; font-family: 'Times New Roman';">&nbsp; </span></span><!--[endif]--><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">Tại ngân hàngVietinbank (Ngân hàng Công Thương Việt Nam)<o:p></o:p></span></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">+ Tên chủ TK: Nguyễn Doãn Cương<o:p></o:p></span></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">+ Tài khoản số: 711AC0599593<o:p></o:p></span></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">+ Ngân hàng Vietinbank, Chi nhánh Tây Hà Nội (Tp.Hà Nội)<o:p></o:p></span></p><p class="MsoListParagraph" style="margin-left:25.1pt;mso-add-space:auto;text-indent:-18.0pt;mso-list:l0 level1 lfo1;tab-stops:list 25.1pt"><!--[if !supportLists]--><span style="font-size:10.0pt;mso-bidi-font-size:11.0pt;line-height:115%;font-family:Wingdings;mso-fareast-font-family:Wingdings;mso-bidi-font-family:Wingdings">v<span style="font-stretch: normal; font-size: 7pt; line-height: normal; font-family: 'Times New Roman';">&nbsp; </span></span><!--[endif]--><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">Tại ngân hàngTienPhongBank (Ngân hàng TMCP Tiên Phong)<o:p></o:p></span></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">+ Tên chủ TK: Nguyễn Doãn Cương<o:p></o:p></span></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">+ Tài khoản số: 00018766001<o:p></o:p></span></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">+ Ngân hàng TienPhongBank, Chi nhánh Phạm Hùng (Tp.Hà Nội)</span></p><p class="MsoNormal"><i><span style="font-family: 'Times New Roman', serif;">Miễn phí giao hàng 40km đầu tiên cho các đơn hàng trên 10 triệu!</span></i></p></div></div></div>
                                                        </div>
                                                        <div class="modal-footer">
                                                            <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-md-3 col-sm-3 col-xs-12 column">
                                                <div class="reassurances-left">
                                                    <span class="icon-name pull-left fa fa-comments-o"></span>
                                                    <div class="description media-body">
                                                        <h4>090 696 1286</h4>
                                                        <p>Tư vấn hỗ trợ</p>                                            <!-- Button trigger modal -->
                                                        <a href="javascript:void(0);" class="pavreassurances arrow" data-toggle="modal" data-target="#myModal4"></a>
                                                        <div class="mask" style="display:none;">
                                                            <div class="title_detail"><div class="icon-name fa fa-smile-o pull-left">&nbsp;</div><div class="description"><h4>TƯ VẤN HỖ TRỢ</h4><p>Khách hàng gọi theo số hotline&nbsp;090 696 1286 hoặc 01677900901.</p><p>Các chuyên gia tư vấn của Siêu thị đồ thờ tượng phật Sơn Đồng luôn sẵn sàng giải đắp mọi thắc mắc của quý khách hàng 24/24!</p><p><br></p><p style="background-image: initial; background-attachment: initial; background-size: initial; background-origin: initial; background-clip: initial; background-position: initial; background-repeat: initial;"><span style="font-weight: bold;">SIÊUTHỊ ĐỒ THỜ, TƯỢNG PHẬT SƠN ĐỒNG </span><o:p></o:p></p><p class="MsoNormal" style="margin-top:9.6pt;mso-para-margin-top:.8gd">Địa chỉ: Hà Nội.<o:p></o:p></p><p class="MsoNormal" style="margin-top:9.6pt;mso-para-margin-top:.8gd">Email: tuvan@dothotuongphat.com<b><span style="font-family: 'Times New Roman', serif;"><o:p></o:p></span></b></p></div></div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <!-- Modal -->
                                            <div class="modal fade" id="myModal4" tabindex="-1" role="dialog">
                                                <div class="modal-dialog">
                                                    <div class="modal-content">
                                                        <div class="modal-body">
                                                            <div class="title_detail"><div class="icon-name fa fa-smile-o pull-left">&nbsp;</div><div class="description"><h4>TƯ VẤN HỖ TRỢ</h4><p>Khách hàng gọi theo số hotline&nbsp;090 696 1286 hoặc 01677900901.</p><p>Các chuyên gia tư vấn của Siêu thị đồ thờ tượng phật Sơn Đồng luôn sẵn sàng giải đắp mọi thắc mắc của quý khách hàng 24/24!</p><p><br></p><p style="background-image: initial; background-attachment: initial; background-size: initial; background-origin: initial; background-clip: initial; background-position: initial; background-repeat: initial;"><span style="font-weight: bold;">SIÊUTHỊ ĐỒ THỜ, TƯỢNG PHẬT SƠN ĐỒNG </span><o:p></o:p></p><p class="MsoNormal" style="margin-top:9.6pt;mso-para-margin-top:.8gd">Địa chỉ: Khu đô thị Tân Tây Đô- Quốc lộ 32- Đan Phượng – Hà Nội.<o:p></o:p></p><p class="MsoNormal" style="margin-top:9.6pt;mso-para-margin-top:.8gd">Email: tuvan@dothotuongphat.com<b><span style="font-family: 'Times New Roman', serif;"><o:p></o:p></span></b></p></div></div>
                                                        </div>
                                                        <div class="modal-footer">
                                                            <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>





                            </div>
                        </div>
                    </div>
                </div>
            </section>
            <div id="columns">
               <!--content-->
              <div class="container">
             <div class="row">

        <section id="sidebar-main" class="col-md-12">
            <div id="content">

                <div id="pav-homebuilder1729929104" class="homebuilder clearfix">
                    <!--tat cả các tab-->
                    <div class="pav-container ">
                        <div class="pav-inner">
                            <div class="row row-level-1 ">
                                <div class="row-inner  clearfix">
                                    <div class="pav-col col-lg-12 col-md-12 col-sm-12 col-xs-12   ">
                                        <div class="col-inner">
                                            <!--Tab con-->                                          
                                            <div class="box pav-verticalcategorytabs clearfix box-blue">
                                                <div class="box-wapper box-blue clearfix">
                                                    <div class="tab-heading box-heading clearfix nopadding k-nomargin" id="Content_Category">
                                                        <div class="nav-header navbar-brand">
                                                           tieu de
                                                        </div>
                                                        <ul class="nav nav-pills k-right nopadding" id="pav-categorytabs">
                                            
                                                        </ul>
                                                        <!-- end div.tab-heading -->
                                                    </div>
                                                    <!--banertab-->
                                                    <div class="tab-nav tabs-x tabs-left">
                                                        <div class="banner-image hidden-md hidden-sm hidden-xs k-img-banner">
                                                            <a class="img-banner" href="#" data-toggle="tab">
                                                                <img class="img-responsive" src="../images/baner/banner1.jpg" alt="Sản phẩm mới" />
                                                            </a>
                                                        </div>
                                                    </div>
                                                    <!--end baner tab-->
                                                    <!--tab sản phẩm mới-->
                                                    <div class="tab-content">
                                                        <div class="tab-pane active " id="tab378-cat61">
                                                            <!--control-->
                                                            <div class="carousel-controls">
                                                                <a class="carousel-control left" href="#list378-cat61" data-slide="prev"><i class="fa fa-angle-left"></i></a>
                                                                <a class="carousel-control right" href="#list378-cat61" data-slide="next"><i class="fa fa-angle-right"></i></a>
                                                            </div>
                                                            <!--end control-->
                                                            <div class="carousel-inner carousel378 slide" id="list378-cat61">
                                                                <!--tab1- active-->
                                                                <div class="item active">
                                                                    <div class="row products-row last">
                                                                        <!--product-->
                                                                        <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col">
                                                                            <div class="product-block item-default clearfix" itemtype="#" itemscope>


                                                                                <span class="product-label ribbon label-special"><span class="product-label-special">Giảm giá</span></span>
                                                                                <div class="images clearfix">
                                                                                    <a class="img" itemprop="url" title="Furabitur sedg" href="#chitiet">
                                                                                        <img class="img-responsive" itemprop="image" src="../images/Content_Product/Intro/dong_son_trang.jpg" title="sp1" alt="sp1" />
                                                                                    </a>

                                                                                    <a class="pav-colorbox btn btn-inverse iframe-link" data-toggle="tooltip" href="/Introdetail.html" title="Xem nhanh"><i class="fa fa-eye"></i></a>

                                                                                    <a href="../images/Content_Product/Intro/dong_son_trang.jpg" class="btn btn-inverse colorbox product-zoom cboxElement" title="Furabitur sedg"><i class="fa fa-search-plus"></i></a>
                                                                                </div>

                                                                                <div class="product-meta">
                                                                                    <div class="product-meta-inner">
                                                                                        <div class="left">
                                                                                            <div class="review clearfix">
                                                                                                <h3 class="name" itemprop="name"><a href="index5e3d.html?route=product/product&amp;product_id=136">Furabitur sedg</a></h3>

                                                                                                <div class="rating">
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                </div>
                                                                                            </div>

                                                                                            <div class="price clearfix" itemtype="http://schema.org/Offer" itemscope itemprop="offers">
                                                                                                <span class="price-new">$290,00</span>
                                                                                                <span class="price-old">$300,00</span>

                                                                                            </div>


                                                                                            <div class="clearfix"></div>
                                                                                            <p class="description" itemprop="description">	HTC Touch - in High Definition. Watch music videos and streaming content in awe-inspiring high defi.....</p>
                                                                                        </div>

                                                                                    </div>
                                                                                </div>
                                                                            </div>
                                                                        </div>

                                                                        <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col">
                                                                            <div class="product-block item-default clearfix" itemtype="#" itemscope>


                                                                                <span class="product-label ribbon label-special"><span class="product-label-special">Giảm giá</span></span>
                                                                                <div class="images clearfix">
                                                                                    <a class="img" itemprop="url" title="Furabitur sedg" href="#chitiet">
                                                                                        <img class="img-responsive" itemprop="image" src="../images/Content_Product/Intro/dong_son_trang.jpg" title="sp1" alt="sp1" />
                                                                                    </a>

                                                                                    <a class="pav-colorbox btn btn-inverse iframe-link" data-toggle="tooltip" href="/Introdetail.html" title="Xem nhanh"><i class="fa fa-eye"></i></a>

                                                                                    <a href="../images/Content_Product/Intro/dong_son_trang.jpg" class="btn btn-inverse colorbox product-zoom cboxElement" title="Furabitur sedg"><i class="fa fa-search-plus"></i></a>
                                                                                </div>

                                                                                <div class="product-meta">
                                                                                    <div class="product-meta-inner">
                                                                                        <div class="left">
                                                                                            <div class="review clearfix">
                                                                                                <h3 class="name" itemprop="name"><a href="index5e3d.html?route=product/product&amp;product_id=136">Furabitur sedg</a></h3>

                                                                                                <div class="rating">
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                </div>
                                                                                            </div>

                                                                                            <div class="price clearfix" itemtype="http://schema.org/Offer" itemscope itemprop="offers">
                                                                                                <span class="price-new">$290,00</span>
                                                                                                <span class="price-old">$300,00</span>

                                                                                            </div>


                                                                                            <div class="clearfix"></div>
                                                                                            <p class="description" itemprop="description">	HTC Touch - in High Definition. Watch music videos and streaming content in awe-inspiring high defi.....</p>
                                                                                        </div>

                                                                                    </div>
                                                                                </div>
                                                                            </div>
                                                                        </div>

                                                                        <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col">
                                                                            <div class="product-block item-default clearfix" itemtype="#" itemscope>


                                                                                <span class="product-label ribbon label-special"><span class="product-label-special">Giảm giá</span></span>
                                                                                <div class="images clearfix">
                                                                                    <a class="img" itemprop="url" title="Furabitur sedg" href="#chitiet">
                                                                                        <img class="img-responsive" itemprop="image" src="../images/Content_Product/Intro/dong_son_trang.jpg" title="sp1" alt="sp1" />
                                                                                    </a>

                                                                                    <a class="pav-colorbox btn btn-inverse iframe-link" data-toggle="tooltip" href="/Introdetail.html" title="Xem nhanh"><i class="fa fa-eye"></i></a>

                                                                                    <a href="../images/Content_Product/Intro/dong_son_trang.jpg" class="btn btn-inverse colorbox product-zoom cboxElement" title="Furabitur sedg"><i class="fa fa-search-plus"></i></a>
                                                                                </div>

                                                                                <div class="product-meta">
                                                                                    <div class="product-meta-inner">
                                                                                        <div class="left">
                                                                                            <div class="review clearfix">
                                                                                                <h3 class="name" itemprop="name"><a href="index5e3d.html?route=product/product&amp;product_id=136">Furabitur sedg</a></h3>

                                                                                                <div class="rating">
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                </div>
                                                                                            </div>

                                                                                            <div class="price clearfix" itemtype="http://schema.org/Offer" itemscope itemprop="offers">
                                                                                                <span class="price-new">$290,00</span>
                                                                                                <span class="price-old">$300,00</span>

                                                                                            </div>


                                                                                            <div class="clearfix"></div>
                                                                                            <p class="description" itemprop="description">	HTC Touch - in High Definition. Watch music videos and streaming content in awe-inspiring high defi.....</p>
                                                                                        </div>

                                                                                    </div>
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>

                                                                <!--end tab1-->
                                                                <div class="item ">
                                                                    <div class="row products-row ">
                                                                        <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col">
                                                                            <div class="product-block item-default clearfix" itemtype="#" itemscope>


                                                                                <span class="product-label ribbon label-special"><span class="product-label-special">Giảm giá</span></span>
                                                                                <div class="images clearfix">
                                                                                    <a class="img" itemprop="url" title="Furabitur sedg" href="#chitiet">
                                                                                        <img class="img-responsive" itemprop="image" src="../images/Content_Product/Intro/dong_son_trang.jpg" title="sp1" alt="sp1" />
                                                                                    </a>

                                                                                    <a class="pav-colorbox btn btn-inverse iframe-link" data-toggle="tooltip" href="/Introdetail.html" title="Xem nhanh"><i class="fa fa-eye"></i></a>

                                                                                    <a href="../images/Content_Product/Intro/dong_son_trang.jpg" class="btn btn-inverse colorbox product-zoom cboxElement" title="Furabitur sedg"><i class="fa fa-search-plus"></i></a>
                                                                                </div>

                                                                                <div class="product-meta">
                                                                                    <div class="product-meta-inner">
                                                                                        <div class="left">
                                                                                            <div class="review clearfix">
                                                                                                <h3 class="name" itemprop="name"><a href="index5e3d.html?route=product/product&amp;product_id=136">Furabitur sedg</a></h3>

                                                                                                <div class="rating">
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                </div>
                                                                                            </div>

                                                                                            <div class="price clearfix" itemtype="http://schema.org/Offer" itemscope itemprop="offers">
                                                                                                <span class="price-new">$290,00</span>
                                                                                                <span class="price-old">$300,00</span>

                                                                                            </div>


                                                                                            <div class="clearfix"></div>
                                                                                            <p class="description" itemprop="description">	HTC Touch - in High Definition. Watch music videos and streaming content in awe-inspiring high defi.....</p>
                                                                                        </div>

                                                                                    </div>
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                        <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col">
                                                                            <div class="product-block item-default clearfix" itemtype="#" itemscope>


                                                                                <span class="product-label ribbon label-special"><span class="product-label-special">Giảm giá</span></span>
                                                                                <div class="images clearfix">
                                                                                    <a class="img" itemprop="url" title="Furabitur sedg" href="#chitiet">
                                                                                        <img class="img-responsive" itemprop="image" src="../images/Content_Product/Intro/dong_son_trang.jpg" title="sp1" alt="sp1" />
                                                                                    </a>

                                                                                    <a class="pav-colorbox btn btn-inverse iframe-link" data-toggle="tooltip" href="/Introdetail.html" title="Xem nhanh"><i class="fa fa-eye"></i></a>

                                                                                    <a href="../images/Content_Product/Intro/dong_son_trang.jpg" class="btn btn-inverse colorbox product-zoom cboxElement" title="Furabitur sedg"><i class="fa fa-search-plus"></i></a>
                                                                                </div>

                                                                                <div class="product-meta">
                                                                                    <div class="product-meta-inner">
                                                                                        <div class="left">
                                                                                            <div class="review clearfix">
                                                                                                <h3 class="name" itemprop="name"><a href="index5e3d.html?route=product/product&amp;product_id=136">Furabitur sedg</a></h3>

                                                                                                <div class="rating">
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                </div>
                                                                                            </div>

                                                                                            <div class="price clearfix" itemtype="http://schema.org/Offer" itemscope itemprop="offers">
                                                                                                <span class="price-new">$290,00</span>
                                                                                                <span class="price-old">$300,00</span>

                                                                                            </div>


                                                                                            <div class="clearfix"></div>
                                                                                            <p class="description" itemprop="description">	HTC Touch - in High Definition. Watch music videos and streaming content in awe-inspiring high defi.....</p>
                                                                                        </div>

                                                                                    </div>
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                        <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col">
                                                                            <div class="product-block item-default clearfix" itemtype="#" itemscope>


                                                                                <span class="product-label ribbon label-special"><span class="product-label-special">Giảm giá</span></span>
                                                                                <div class="images clearfix">
                                                                                    <a class="img" itemprop="url" title="Furabitur sedg" href="#chitiet">
                                                                                        <img class="img-responsive" itemprop="image" src="../images/Content_Product/Intro/dong_son_trang.jpg" title="sp1" alt="sp1" />
                                                                                    </a>

                                                                                    <a class="pav-colorbox btn btn-inverse iframe-link" data-toggle="tooltip" href="/Introdetail.html" title="Xem nhanh"><i class="fa fa-eye"></i></a>

                                                                                    <a href="../images/Content_Product/Intro/dong_son_trang.jpg" class="btn btn-inverse colorbox product-zoom cboxElement" title="Furabitur sedg"><i class="fa fa-search-plus"></i></a>
                                                                                </div>

                                                                                <div class="product-meta">
                                                                                    <div class="product-meta-inner">
                                                                                        <div class="left">
                                                                                            <div class="review clearfix">
                                                                                                <h3 class="name" itemprop="name"><a href="index5e3d.html?route=product/product&amp;product_id=136">Furabitur sedg</a></h3>

                                                                                                <div class="rating">
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                </div>
                                                                                            </div>

                                                                                            <div class="price clearfix" itemtype="http://schema.org/Offer" itemscope itemprop="offers">
                                                                                                <span class="price-new">$290,00</span>
                                                                                                <span class="price-old">$300,00</span>

                                                                                            </div>


                                                                                            <div class="clearfix"></div>
                                                                                            <p class="description" itemprop="description">	HTC Touch - in High Definition. Watch music videos and streaming content in awe-inspiring high defi.....</p>
                                                                                        </div>

                                                                                    </div>
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </div><!-- end div.carousel-content-->

                                                        </div><!-- end div.tab-panel-->
                                                        <div class="tab-pane" id="tab378-cat62">
                                                            <!--control-->
                                                            <div class="carousel-controls">
                                                                <a class="carousel-control left" href="#list378-cat62" data-slide="prev"><i class="fa fa-angle-left"></i></a>
                                                                <a class="carousel-control right" href="#list378-cat62" data-slide="next"><i class="fa fa-angle-right"></i></a>
                                                            </div>
                                                            <!--end control-->
                                                            <div class="carousel-inner carousel378 slide" id="list378-cat62">
                                                                <!--tab1- active-->
                                                                <div class="item active">
                                                                    <div class="row products-row last">
                                                                        <!--product-->
                                                                        <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col">
                                                                            <div class="product-block item-default clearfix" itemtype="#" itemscope>


                                                                                <span class="product-label ribbon label-special"><span class="product-label-special">Giảm giá</span></span>
                                                                                <div class="images clearfix">
                                                                                    <a class="img" itemprop="url" title="Furabitur sedg" href="#chitiet">
                                                                                        <img class="img-responsive" itemprop="image" src="../images/Content_Product/Intro/dong_son_trang.jpg" title="sp1" alt="sp1" />
                                                                                    </a>

                                                                                    <a class="pav-colorbox btn btn-inverse iframe-link" data-toggle="tooltip" href="/Introdetail.html" title="Xem nhanh"><i class="fa fa-eye"></i></a>

                                                                                    <a href="../images/Content_Product/Intro/dong_son_trang.jpg" class="btn btn-inverse colorbox product-zoom cboxElement" title="Furabitur sedg"><i class="fa fa-search-plus"></i></a>
                                                                                </div>

                                                                                <div class="product-meta">
                                                                                    <div class="product-meta-inner">
                                                                                        <div class="left">
                                                                                            <div class="review clearfix">
                                                                                                <h3 class="name" itemprop="name"><a href="#chitiet">Furabitur sed213g</a></h3>

                                                                                                <div class="rating">
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                </div>
                                                                                            </div>

                                                                                            <div class="price clearfix" itemtype="http://schema.org/Offer" itemscope itemprop="offers">
                                                                                                <span class="price-new">$290,00</span>
                                                                                                <span class="price-old">$300,00</span>

                                                                                            </div>


                                                                                            <div class="clearfix"></div>
                                                                                            <p class="description" itemprop="description">	HTC Touch - in High Definition. Watch music videos and streaming content in awe-inspiring high defi.....</p>
                                                                                        </div>

                                                                                    </div>
                                                                                </div>
                                                                            </div>
                                                                        </div>

                                                                        <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col">
                                                                            <div class="product-block item-default clearfix" itemtype="#" itemscope>


                                                                                <span class="product-label ribbon label-special"><span class="product-label-special">Giảm giá</span></span>
                                                                                <div class="images clearfix">
                                                                                    <a class="img" itemprop="url" title="Furabitur sedg" href="#chitiet">
                                                                                        <img class="img-responsive" itemprop="image" src="../images/Content_Product/Intro/dong_son_trang.jpg" title="sp1" alt="sp1" />
                                                                                    </a>

                                                                                    <a class="pav-colorbox btn btn-inverse iframe-link" data-toggle="tooltip" href="/Introdetail.html" title="Xem nhanh"><i class="fa fa-eye"></i></a>

                                                                                    <a href="../images/Content_Product/Intro/dong_son_trang.jpg" class="btn btn-inverse colorbox product-zoom cboxElement" title="Furabitur sedg"><i class="fa fa-search-plus"></i></a>
                                                                                </div>

                                                                                <div class="product-meta">
                                                                                    <div class="product-meta-inner">
                                                                                        <div class="left">
                                                                                            <div class="review clearfix">
                                                                                                <h3 class="name" itemprop="name"><a href="index5e3d.html?route=product/product&amp;product_id=136">Furabitur sedg</a></h3>

                                                                                                <div class="rating">
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                </div>
                                                                                            </div>

                                                                                            <div class="price clearfix" itemtype="http://schema.org/Offer" itemscope itemprop="offers">
                                                                                                <span class="price-new">$290,00</span>
                                                                                                <span class="price-old">$300,00</span>

                                                                                            </div>


                                                                                            <div class="clearfix"></div>
                                                                                            <p class="description" itemprop="description">	HTC Touch - in High Definition. Watch music videos and streaming content in awe-inspiring high defi.....</p>
                                                                                        </div>

                                                                                    </div>
                                                                                </div>
                                                                            </div>
                                                                        </div>

                                                                        <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col">
                                                                            <div class="product-block item-default clearfix" itemtype="#" itemscope>


                                                                                <span class="product-label ribbon label-special"><span class="product-label-special">Giảm giá</span></span>
                                                                                <div class="images clearfix">
                                                                                    <a class="img" itemprop="url" title="Furabitur sedg" href="#chitiet">
                                                                                        <img class="img-responsive" itemprop="image" src="../images/Content_Product/Intro/dong_son_trang.jpg" title="sp1" alt="sp1" />
                                                                                    </a>

                                                                                    <a class="pav-colorbox btn btn-inverse iframe-link" data-toggle="tooltip" href="/Introdetail.html" title="Xem nhanh"><i class="fa fa-eye"></i></a>

                                                                                    <a href="../images/Content_Product/Intro/dong_son_trang.jpg" class="btn btn-inverse colorbox product-zoom cboxElement" title="Furabitur sedg"><i class="fa fa-search-plus"></i></a>
                                                                                </div>

                                                                                <div class="product-meta">
                                                                                    <div class="product-meta-inner">
                                                                                        <div class="left">
                                                                                            <div class="review clearfix">
                                                                                                <h3 class="name" itemprop="name"><a href="index5e3d.html?route=product/product&amp;product_id=136">Furabitur sedg</a></h3>

                                                                                                <div class="rating">
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                </div>
                                                                                            </div>

                                                                                            <div class="price clearfix" itemtype="http://schema.org/Offer" itemscope itemprop="offers">
                                                                                                <span class="price-new">$290,00</span>
                                                                                                <span class="price-old">$300,00</span>

                                                                                            </div>


                                                                                            <div class="clearfix"></div>
                                                                                            <p class="description" itemprop="description">	HTC Touch - in High Definition. Watch music videos and streaming content in awe-inspiring high defi.....</p>
                                                                                        </div>

                                                                                    </div>
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>

                                                                <!--end tab1-->
                                                                <div class="item ">
                                                                    <div class="row products-row ">
                                                                        <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col">
                                                                            <div class="product-block item-default clearfix" itemtype="#" itemscope>


                                                                                <span class="product-label ribbon label-special"><span class="product-label-special">Giảm giá</span></span>
                                                                                <div class="images clearfix">
                                                                                    <a class="img" itemprop="url" title="Furabitur sedg" href="#chitiet">
                                                                                        <img class="img-responsive" itemprop="image" src="../images/Content_Product/Intro/dong_son_trang.jpg" title="sp1" alt="sp1" />
                                                                                    </a>

                                                                                    <a class="pav-colorbox btn btn-inverse iframe-link" data-toggle="tooltip" href="/Introdetail.html" title="Xem nhanh"><i class="fa fa-eye"></i></a>

                                                                                    <a href="../images/Content_Product/Intro/dong_son_trang.jpg" class="btn btn-inverse colorbox product-zoom cboxElement" title="Furabitur sedg"><i class="fa fa-search-plus"></i></a>
                                                                                </div>

                                                                                <div class="product-meta">
                                                                                    <div class="product-meta-inner">
                                                                                        <div class="left">
                                                                                            <div class="review clearfix">
                                                                                                <h3 class="name" itemprop="name"><a href="index5e3d.html?route=product/product&amp;product_id=136">Furabitur sedg</a></h3>

                                                                                                <div class="rating">
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                </div>
                                                                                            </div>

                                                                                            <div class="price clearfix" itemtype="http://schema.org/Offer" itemscope itemprop="offers">
                                                                                                <span class="price-new">$290,00</span>
                                                                                                <span class="price-old">$300,00</span>

                                                                                            </div>


                                                                                            <div class="clearfix"></div>
                                                                                            <p class="description" itemprop="description">	HTC Touch - in High Definition. Watch music videos and streaming content in awe-inspiring high defi.....</p>
                                                                                        </div>

                                                                                    </div>
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                        <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col">
                                                                            <div class="product-block item-default clearfix" itemtype="#" itemscope>


                                                                                <span class="product-label ribbon label-special"><span class="product-label-special">Giảm giá</span></span>
                                                                                <div class="images clearfix">
                                                                                    <a class="img" itemprop="url" title="Furabitur sedg" href="#chitiet">
                                                                                        <img class="img-responsive" itemprop="image" src="../images/Content_Product/Intro/dong_son_trang.jpg" title="sp1" alt="sp1" />
                                                                                    </a>

                                                                                    <a class="pav-colorbox btn btn-inverse iframe-link" data-toggle="tooltip" href="/Introdetail.html" title="Xem nhanh"><i class="fa fa-eye"></i></a>

                                                                                    <a href="../images/Content_Product/Intro/dong_son_trang.jpg" class="btn btn-inverse colorbox product-zoom cboxElement" title="Furabitur sedg"><i class="fa fa-search-plus"></i></a>
                                                                                </div>

                                                                                <div class="product-meta">
                                                                                    <div class="product-meta-inner">
                                                                                        <div class="left">
                                                                                            <div class="review clearfix">
                                                                                                <h3 class="name" itemprop="name"><a href="index5e3d.html?route=product/product&amp;product_id=136">Furabitur sedg</a></h3>

                                                                                                <div class="rating">
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                </div>
                                                                                            </div>

                                                                                            <div class="price clearfix" itemtype="http://schema.org/Offer" itemscope itemprop="offers">
                                                                                                <span class="price-new">$290,00</span>
                                                                                                <span class="price-old">$300,00</span>

                                                                                            </div>


                                                                                            <div class="clearfix"></div>
                                                                                            <p class="description" itemprop="description">	HTC Touch - in High Definition. Watch music videos and streaming content in awe-inspiring high defi.....</p>
                                                                                        </div>

                                                                                    </div>
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                        <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col">
                                                                            <div class="product-block item-default clearfix" itemtype="#" itemscope>


                                                                                <span class="product-label ribbon label-special"><span class="product-label-special">Giảm giá</span></span>
                                                                                <div class="images clearfix">
                                                                                    <a class="img" itemprop="url" title="Furabitur sedg" href="#chitiet">
                                                                                        <img class="img-responsive" itemprop="image" src="../images/Content_Product/Intro/dong_son_trang.jpg" title="sp1" alt="sp1" />
                                                                                    </a>

                                                                                    <a class="pav-colorbox btn btn-inverse iframe-link" data-toggle="tooltip" href="/Introdetail.html" title="Xem nhanh"><i class="fa fa-eye"></i></a>

                                                                                    <a href="../images/Content_Product/Intro/dong_son_trang.jpg" class="btn btn-inverse colorbox product-zoom cboxElement" title="Furabitur sedg"><i class="fa fa-search-plus"></i></a>
                                                                                </div>

                                                                                <div class="product-meta">
                                                                                    <div class="product-meta-inner">
                                                                                        <div class="left">
                                                                                            <div class="review clearfix">
                                                                                                <h3 class="name" itemprop="name"><a href="index5e3d.html?route=product/product&amp;product_id=136">Furabitur sedg</a></h3>

                                                                                                <div class="rating">
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                </div>
                                                                                            </div>

                                                                                            <div class="price clearfix" itemtype="http://schema.org/Offer" itemscope itemprop="offers">
                                                                                                <span class="price-new">$290,00</span>
                                                                                                <span class="price-old">$300,00</span>

                                                                                            </div>


                                                                                            <div class="clearfix"></div>
                                                                                            <p class="description" itemprop="description">	HTC Touch - in High Definition. Watch music videos and streaming content in awe-inspiring high defi.....</p>
                                                                                        </div>

                                                                                    </div>
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </div><!-- end div.carousel-content-->

                                                        </div><!-- end div.tab-panel-->
                                                        <div class="tab-pane" id="tab378-cat63">
                                                            <!--control-->
                                                            <div class="carousel-controls">
                                                                <a class="carousel-control left" href="#list378-cat63" data-slide="prev"><i class="fa fa-angle-left"></i></a>
                                                                <a class="carousel-control right" href="#list378-cat63" data-slide="next"><i class="fa fa-angle-right"></i></a>
                                                            </div>
                                                            <!--end control-->
                                                            <div class="carousel-inner carousel378 slide" id="list378-cat63">
                                                                <!--tab1- active-->
                                                                <div class="item active">
                                                                    <div class="row products-row last">
                                                                        <!--product-->
                                                                        <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col">
                                                                            <div class="product-block item-default clearfix" itemtype="#" itemscope>


                                                                                <span class="product-label ribbon label-special"><span class="product-label-special">Giảm giá</span></span>
                                                                                <div class="images clearfix">
                                                                                    <a class="img" itemprop="url" title="Furabitur sedg" href="#chitiet">
                                                                                        <img class="img-responsive" itemprop="image" src="../images/Content_Product/Intro/dong_son_trang.jpg" title="sp1" alt="sp1" />
                                                                                    </a>

                                                                                    <a class="pav-colorbox btn btn-inverse iframe-link" data-toggle="tooltip" href="/Introdetail.html" title="Xem nhanh"><i class="fa fa-eye"></i></a>

                                                                                    <a href="../images/Content_Product/Intro/dong_son_trang.jpg" class="btn btn-inverse colorbox product-zoom cboxElement" title="Furabitur sedg"><i class="fa fa-search-plus"></i></a>
                                                                                </div>

                                                                                <div class="product-meta">
                                                                                    <div class="product-meta-inner">
                                                                                        <div class="left">
                                                                                            <div class="review clearfix">
                                                                                                <h3 class="name" itemprop="name"><a href="index5e3d.html?route=product/product&amp;product_id=136">Furabitur sedg</a></h3>

                                                                                                <div class="rating">
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                </div>
                                                                                            </div>

                                                                                            <div class="price clearfix" itemtype="http://schema.org/Offer" itemscope itemprop="offers">
                                                                                                <span class="price-new">$290,00</span>
                                                                                                <span class="price-old">$300,00</span>

                                                                                            </div>


                                                                                            <div class="clearfix"></div>
                                                                                            <p class="description" itemprop="description">	HTC Touch - in High Definition. Watch music videos and streaming content in awe-inspiring high defi.....</p>
                                                                                        </div>

                                                                                    </div>
                                                                                </div>
                                                                            </div>
                                                                        </div>

                                                                        <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col">
                                                                            <div class="product-block item-default clearfix" itemtype="#" itemscope>


                                                                                <span class="product-label ribbon label-special"><span class="product-label-special">Giảm giá</span></span>
                                                                                <div class="images clearfix">
                                                                                    <a class="img" itemprop="url" title="Furabitur sedg" href="#chitiet">
                                                                                        <img class="img-responsive" itemprop="image" src="../images/Content_Product/Intro/dong_son_trang.jpg" title="sp1" alt="sp1" />
                                                                                    </a>

                                                                                    <a class="pav-colorbox btn btn-inverse iframe-link" data-toggle="tooltip" href="/Introdetail.html" title="Xem nhanh"><i class="fa fa-eye"></i></a>

                                                                                    <a href="../images/Content_Product/Intro/dong_son_trang.jpg" class="btn btn-inverse colorbox product-zoom cboxElement" title="Furabitur sedg"><i class="fa fa-search-plus"></i></a>
                                                                                </div>

                                                                                <div class="product-meta">
                                                                                    <div class="product-meta-inner">
                                                                                        <div class="left">
                                                                                            <div class="review clearfix">
                                                                                                <h3 class="name" itemprop="name"><a href="index5e3d.html?route=product/product&amp;product_id=136">Furabitur sedg</a></h3>

                                                                                                <div class="rating">
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                </div>
                                                                                            </div>

                                                                                            <div class="price clearfix" itemtype="http://schema.org/Offer" itemscope itemprop="offers">
                                                                                                <span class="price-new">$290,00</span>
                                                                                                <span class="price-old">$300,00</span>

                                                                                            </div>


                                                                                            <div class="clearfix"></div>
                                                                                            <p class="description" itemprop="description">	HTC Touch - in High Definition. Watch music videos and streaming content in awe-inspiring high defi.....</p>
                                                                                        </div>

                                                                                    </div>
                                                                                </div>
                                                                            </div>
                                                                        </div>

                                                                        <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col">
                                                                            <div class="product-block item-default clearfix" itemtype="#" itemscope>


                                                                                <span class="product-label ribbon label-special"><span class="product-label-special">Giảm giá</span></span>
                                                                                <div class="images clearfix">
                                                                                    <a class="img" itemprop="url" title="Furabitur sedg" href="#chitiet">
                                                                                        <img class="img-responsive" itemprop="image" src="../images/Content_Product/Intro/dong_son_trang.jpg" title="sp1" alt="sp1" />
                                                                                    </a>

                                                                                    <a class="pav-colorbox btn btn-inverse iframe-link" data-toggle="tooltip" href="/Introdetail.html" title="Xem nhanh"><i class="fa fa-eye"></i></a>

                                                                                    <a href="../images/Content_Product/Intro/dong_son_trang.jpg" class="btn btn-inverse colorbox product-zoom cboxElement" title="Furabitur sedg"><i class="fa fa-search-plus"></i></a>
                                                                                </div>

                                                                                <div class="product-meta">
                                                                                    <div class="product-meta-inner">
                                                                                        <div class="left">
                                                                                            <div class="review clearfix">
                                                                                                <h3 class="name" itemprop="name"><a href="index5e3d.html?route=product/product&amp;product_id=136">Furabitur sedg</a></h3>

                                                                                                <div class="rating">
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                </div>
                                                                                            </div>

                                                                                            <div class="price clearfix" itemtype="http://schema.org/Offer" itemscope itemprop="offers">
                                                                                                <span class="price-new">$290,00</span>
                                                                                                <span class="price-old">$300,00</span>

                                                                                            </div>


                                                                                            <div class="clearfix"></div>
                                                                                            <p class="description" itemprop="description">	HTC Touch - in High Definition. Watch music videos and streaming content in awe-inspiring high defi.....</p>
                                                                                        </div>

                                                                                    </div>
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>

                                                                <!--end tab1-->
                                                                <div class="item ">
                                                                    <div class="row products-row ">
                                                                        <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col">
                                                                            <div class="product-block item-default clearfix" itemtype="#" itemscope>


                                                                                <span class="product-label ribbon label-special"><span class="product-label-special">Giảm giá</span></span>
                                                                                <div class="images clearfix">
                                                                                    <a class="img" itemprop="url" title="Furabitur sedg" href="#chitiet">
                                                                                        <img class="img-responsive" itemprop="image" src="../images/Content_Product/Intro/dong_son_trang.jpg" title="sp1" alt="sp1" />
                                                                                    </a>

                                                                                    <a class="pav-colorbox btn btn-inverse iframe-link" data-toggle="tooltip" href="/Introdetail.html" title="Xem nhanh"><i class="fa fa-eye"></i></a>

                                                                                    <a href="../images/Content_Product/Intro/dong_son_trang.jpg" class="btn btn-inverse colorbox product-zoom cboxElement" title="Furabitur sedg"><i class="fa fa-search-plus"></i></a>
                                                                                </div>

                                                                                <div class="product-meta">
                                                                                    <div class="product-meta-inner">
                                                                                        <div class="left">
                                                                                            <div class="review clearfix">
                                                                                                <h3 class="name" itemprop="name"><a href="index5e3d.html?route=product/product&amp;product_id=136">Furabitur sedg</a></h3>

                                                                                                <div class="rating">
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                </div>
                                                                                            </div>

                                                                                            <div class="price clearfix" itemtype="http://schema.org/Offer" itemscope itemprop="offers">
                                                                                                <span class="price-new">$290,00</span>
                                                                                                <span class="price-old">$300,00</span>

                                                                                            </div>


                                                                                            <div class="clearfix"></div>
                                                                                            <p class="description" itemprop="description">	HTC Touch - in High Definition. Watch music videos and streaming content in awe-inspiring high defi.....</p>
                                                                                        </div>

                                                                                    </div>
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                        <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col">
                                                                            <div class="product-block item-default clearfix" itemtype="#" itemscope>


                                                                                <span class="product-label ribbon label-special"><span class="product-label-special">Giảm giá</span></span>
                                                                                <div class="images clearfix">
                                                                                    <a class="img" itemprop="url" title="Furabitur sedg" href="#chitiet">
                                                                                        <img class="img-responsive" itemprop="image" src="../images/Content_Product/Intro/dong_son_trang.jpg" title="sp1" alt="sp1" />
                                                                                    </a>

                                                                                    <a class="pav-colorbox btn btn-inverse iframe-link" data-toggle="tooltip" href="/Introdetail.html" title="Xem nhanh"><i class="fa fa-eye"></i></a>

                                                                                    <a href="../images/Content_Product/Intro/dong_son_trang.jpg" class="btn btn-inverse colorbox product-zoom cboxElement" title="Furabitur sedg"><i class="fa fa-search-plus"></i></a>
                                                                                </div>

                                                                                <div class="product-meta">
                                                                                    <div class="product-meta-inner">
                                                                                        <div class="left">
                                                                                            <div class="review clearfix">
                                                                                                <h3 class="name" itemprop="name"><a href="index5e3d.html?route=product/product&amp;product_id=136">Furabitur sedg</a></h3>

                                                                                                <div class="rating">
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                </div>
                                                                                            </div>

                                                                                            <div class="price clearfix" itemtype="http://schema.org/Offer" itemscope itemprop="offers">
                                                                                                <span class="price-new">$290,00</span>
                                                                                                <span class="price-old">$300,00</span>

                                                                                            </div>


                                                                                            <div class="clearfix"></div>
                                                                                            <p class="description" itemprop="description">	HTC Touch - in High Definition. Watch music videos and streaming content in awe-inspiring high defi.....</p>
                                                                                        </div>

                                                                                    </div>
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                        <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col">
                                                                            <div class="product-block item-default clearfix" itemtype="#" itemscope>


                                                                                <span class="product-label ribbon label-special"><span class="product-label-special">Giảm giá</span></span>
                                                                                <div class="images clearfix">
                                                                                    <a class="img" itemprop="url" title="Furabitur sedg" href="#chitiet">
                                                                                        <img class="img-responsive" itemprop="image" src="../images/Content_Product/Intro/dong_son_trang.jpg" title="sp1" alt="sp1" />
                                                                                    </a>

                                                                                    <a class="pav-colorbox btn btn-inverse iframe-link" data-toggle="tooltip" href="/Introdetail.html" title="Xem nhanh"><i class="fa fa-eye"></i></a>

                                                                                    <a href="../images/Content_Product/Intro/dong_son_trang.jpg" class="btn btn-inverse colorbox product-zoom cboxElement" title="Furabitur sedg"><i class="fa fa-search-plus"></i></a>
                                                                                </div>

                                                                                <div class="product-meta">
                                                                                    <div class="product-meta-inner">
                                                                                        <div class="left">
                                                                                            <div class="review clearfix">
                                                                                                <h3 class="name" itemprop="name"><a href="index5e3d.html?route=product/product&amp;product_id=136">Furabitur sedg</a></h3>

                                                                                                <div class="rating">
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                </div>
                                                                                            </div>

                                                                                            <div class="price clearfix" itemtype="http://schema.org/Offer" itemscope itemprop="offers">
                                                                                                <span class="price-new">$290,00</span>
                                                                                                <span class="price-old">$300,00</span>

                                                                                            </div>


                                                                                            <div class="clearfix"></div>
                                                                                            <p class="description" itemprop="description">	HTC Touch - in High Definition. Watch music videos and streaming content in awe-inspiring high defi.....</p>
                                                                                        </div>

                                                                                    </div>
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </div><!-- end div.carousel-content-->

                                                        </div><!-- end div.tab-panel-->
                                                        <div class="tab-pane " id="tab378-cat64">
                                                            <!--control-->
                                                            <div class="carousel-controls">
                                                                <a class="carousel-control left" href="#list378-cat64" data-slide="prev"><i class="fa fa-angle-left"></i></a>
                                                                <a class="carousel-control right" href="#list378-cat64" data-slide="next"><i class="fa fa-angle-right"></i></a>
                                                            </div>
                                                            <!--end control-->
                                                            <div class="carousel-inner carousel378 slide" id="list378-cat64">
                                                                <!--tab1- active-->
                                                                <div class="item active">
                                                                    <div class="row products-row last">
                                                                        <!--product-->
                                                                        <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col">
                                                                            <div class="product-block item-default clearfix" itemtype="#" itemscope>


                                                                                <span class="product-label ribbon label-special"><span class="product-label-special">Giảm giá</span></span>
                                                                                <div class="images clearfix">
                                                                                    <a class="img" itemprop="url" title="Furabitur sedg" href="#chitiet">
                                                                                        <img class="img-responsive" itemprop="image" src="../images/Content_Product/Intro/dong_son_trang.jpg" title="sp1" alt="sp1" />
                                                                                    </a>

                                                                                    <a class="pav-colorbox btn btn-inverse iframe-link" data-toggle="tooltip" href="/Introdetail.html" title="Xem nhanh"><i class="fa fa-eye"></i></a>

                                                                                    <a href="../images/Content_Product/Intro/dong_son_trang.jpg" class="btn btn-inverse colorbox product-zoom cboxElement" title="Furabitur sedg"><i class="fa fa-search-plus"></i></a>
                                                                                </div>

                                                                                <div class="product-meta">
                                                                                    <div class="product-meta-inner">
                                                                                        <div class="left">
                                                                                            <div class="review clearfix">
                                                                                                <h3 class="name" itemprop="name"><a href="index5e3d.html?route=product/product&amp;product_id=136">Furabitur sedg</a></h3>

                                                                                                <div class="rating">
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                </div>
                                                                                            </div>

                                                                                            <div class="price clearfix" itemtype="http://schema.org/Offer" itemscope itemprop="offers">
                                                                                                <span class="price-new">$290,00</span>
                                                                                                <span class="price-old">$300,00</span>

                                                                                            </div>


                                                                                            <div class="clearfix"></div>
                                                                                            <p class="description" itemprop="description">	HTC Touch - in High Definition. Watch music videos and streaming content in awe-inspiring high defi.....</p>
                                                                                        </div>

                                                                                    </div>
                                                                                </div>
                                                                            </div>
                                                                        </div>

                                                                        <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col">
                                                                            <div class="product-block item-default clearfix" itemtype="#" itemscope>


                                                                                <span class="product-label ribbon label-special"><span class="product-label-special">Giảm giá</span></span>
                                                                                <div class="images clearfix">
                                                                                    <a class="img" itemprop="url" title="Furabitur sedg" href="#chitiet">
                                                                                        <img class="img-responsive" itemprop="image" src="../images/Content_Product/Intro/dong_son_trang.jpg" title="sp1" alt="sp1" />
                                                                                    </a>

                                                                                    <a class="pav-colorbox btn btn-inverse iframe-link" data-toggle="tooltip" href="/Introdetail.html" title="Xem nhanh"><i class="fa fa-eye"></i></a>

                                                                                    <a href="../images/Content_Product/Intro/dong_son_trang.jpg" class="btn btn-inverse colorbox product-zoom cboxElement" title="Furabitur sedg"><i class="fa fa-search-plus"></i></a>
                                                                                </div>

                                                                                <div class="product-meta">
                                                                                    <div class="product-meta-inner">
                                                                                        <div class="left">
                                                                                            <div class="review clearfix">
                                                                                                <h3 class="name" itemprop="name"><a href="index5e3d.html?route=product/product&amp;product_id=136">Furabitur sedg</a></h3>

                                                                                                <div class="rating">
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                </div>
                                                                                            </div>

                                                                                            <div class="price clearfix" itemtype="http://schema.org/Offer" itemscope itemprop="offers">
                                                                                                <span class="price-new">$290,00</span>
                                                                                                <span class="price-old">$300,00</span>

                                                                                            </div>


                                                                                            <div class="clearfix"></div>
                                                                                            <p class="description" itemprop="description">	HTC Touch - in High Definition. Watch music videos and streaming content in awe-inspiring high defi.....</p>
                                                                                        </div>

                                                                                    </div>
                                                                                </div>
                                                                            </div>
                                                                        </div>

                                                                        <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col">
                                                                            <div class="product-block item-default clearfix" itemtype="#" itemscope>


                                                                                <span class="product-label ribbon label-special"><span class="product-label-special">Giảm giá</span></span>
                                                                                <div class="images clearfix">
                                                                                    <a class="img" itemprop="url" title="Furabitur sedg" href="#chitiet">
                                                                                        <img class="img-responsive" itemprop="image" src="../images/Content_Product/Intro/dong_son_trang.jpg" title="sp1" alt="sp1" />
                                                                                    </a>

                                                                                    <a class="pav-colorbox btn btn-inverse iframe-link" data-toggle="tooltip" href="/Introdetail.html" title="Xem nhanh"><i class="fa fa-eye"></i></a>

                                                                                    <a href="../images/Content_Product/Intro/dong_son_trang.jpg" class="btn btn-inverse colorbox product-zoom cboxElement" title="Furabitur sedg"><i class="fa fa-search-plus"></i></a>
                                                                                </div>

                                                                                <div class="product-meta">
                                                                                    <div class="product-meta-inner">
                                                                                        <div class="left">
                                                                                            <div class="review clearfix">
                                                                                                <h3 class="name" itemprop="name"><a href="index5e3d.html?route=product/product&amp;product_id=136">Furabitur sedg</a></h3>

                                                                                                <div class="rating">
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                </div>
                                                                                            </div>

                                                                                            <div class="price clearfix" itemtype="http://schema.org/Offer" itemscope itemprop="offers">
                                                                                                <span class="price-new">$290,00</span>
                                                                                                <span class="price-old">$300,00</span>

                                                                                            </div>


                                                                                            <div class="clearfix"></div>
                                                                                            <p class="description" itemprop="description">	HTC Touch - in High Definition. Watch music videos and streaming content in awe-inspiring high defi.....</p>
                                                                                        </div>

                                                                                    </div>
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>

                                                                <!--end tab1-->
                                                                <div class="item ">
                                                                    <div class="row products-row ">
                                                                        <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col">
                                                                            <div class="product-block item-default clearfix" itemtype="#" itemscope>


                                                                                <span class="product-label ribbon label-special"><span class="product-label-special">Giảm giá</span></span>
                                                                                <div class="images clearfix">
                                                                                    <a class="img" itemprop="url" title="Furabitur sedg" href="#chitiet">
                                                                                        <img class="img-responsive" itemprop="image" src="../images/Content_Product/Intro/dong_son_trang.jpg" title="sp1" alt="sp1" />
                                                                                    </a>

                                                                                    <a class="pav-colorbox btn btn-inverse iframe-link" data-toggle="tooltip" href="/Introdetail.html" title="Xem nhanh"><i class="fa fa-eye"></i></a>

                                                                                    <a href="../images/Content_Product/Intro/dong_son_trang.jpg" class="btn btn-inverse colorbox product-zoom cboxElement" title="Furabitur sedg"><i class="fa fa-search-plus"></i></a>
                                                                                </div>

                                                                                <div class="product-meta">
                                                                                    <div class="product-meta-inner">
                                                                                        <div class="left">
                                                                                            <div class="review clearfix">
                                                                                                <h3 class="name" itemprop="name"><a href="index5e3d.html?route=product/product&amp;product_id=136">Furabitur sedg</a></h3>

                                                                                                <div class="rating">
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                </div>
                                                                                            </div>

                                                                                            <div class="price clearfix" itemtype="http://schema.org/Offer" itemscope itemprop="offers">
                                                                                                <span class="price-new">$290,00</span>
                                                                                                <span class="price-old">$300,00</span>

                                                                                            </div>


                                                                                            <div class="clearfix"></div>
                                                                                            <p class="description" itemprop="description">	HTC Touch - in High Definition. Watch music videos and streaming content in awe-inspiring high defi.....</p>
                                                                                        </div>

                                                                                    </div>
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                        <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col">
                                                                            <div class="product-block item-default clearfix" itemtype="#" itemscope>


                                                                                <span class="product-label ribbon label-special"><span class="product-label-special">Giảm giá</span></span>
                                                                                <div class="images clearfix">
                                                                                    <a class="img" itemprop="url" title="Furabitur sedg" href="#chitiet">
                                                                                        <img class="img-responsive" itemprop="image" src="../images/Content_Product/Intro/dong_son_trang.jpg" title="sp1" alt="sp1" />
                                                                                    </a>

                                                                                    <a class="pav-colorbox btn btn-inverse iframe-link" data-toggle="tooltip" href="/Introdetail.html" title="Xem nhanh"><i class="fa fa-eye"></i></a>

                                                                                    <a href="../images/Content_Product/Intro/dong_son_trang.jpg" class="btn btn-inverse colorbox product-zoom cboxElement" title="Furabitur sedg"><i class="fa fa-search-plus"></i></a>
                                                                                </div>

                                                                                <div class="product-meta">
                                                                                    <div class="product-meta-inner">
                                                                                        <div class="left">
                                                                                            <div class="review clearfix">
                                                                                                <h3 class="name" itemprop="name"><a href="index5e3d.html?route=product/product&amp;product_id=136">Furabitur sedg</a></h3>

                                                                                                <div class="rating">
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                </div>
                                                                                            </div>

                                                                                            <div class="price clearfix" itemtype="http://schema.org/Offer" itemscope itemprop="offers">
                                                                                                <span class="price-new">$290,00</span>
                                                                                                <span class="price-old">$300,00</span>

                                                                                            </div>


                                                                                            <div class="clearfix"></div>
                                                                                            <p class="description" itemprop="description">	HTC Touch - in High Definition. Watch music videos and streaming content in awe-inspiring high defi.....</p>
                                                                                        </div>

                                                                                    </div>
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                        <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col">
                                                                            <div class="product-block item-default clearfix" itemtype="#" itemscope>


                                                                                <span class="product-label ribbon label-special"><span class="product-label-special">Giảm giá</span></span>
                                                                                <div class="images clearfix">
                                                                                    <a class="img" itemprop="url" title="Furabitur sedg" href="#chitiet">
                                                                                        <img class="img-responsive" itemprop="image" src="../images/Content_Product/Intro/dong_son_trang.jpg" title="sp1" alt="sp1" />
                                                                                    </a>

                                                                                    <a class="pav-colorbox btn btn-inverse iframe-link" data-toggle="tooltip" href="/Introdetail.html" title="Xem nhanh"><i class="fa fa-eye"></i></a>

                                                                                    <a href="../images/Content_Product/Intro/dong_son_trang.jpg" class="btn btn-inverse colorbox product-zoom cboxElement" title="Furabitur sedg"><i class="fa fa-search-plus"></i></a>
                                                                                </div>

                                                                                <div class="product-meta">
                                                                                    <div class="product-meta-inner">
                                                                                        <div class="left">
                                                                                            <div class="review clearfix">
                                                                                                <h3 class="name" itemprop="name"><a href="index5e3d.html?route=product/product&amp;product_id=136">Furabitur sedg</a></h3>

                                                                                                <div class="rating">
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                                                </div>
                                                                                            </div>

                                                                                            <div class="price clearfix" itemtype="http://schema.org/Offer" itemscope itemprop="offers">
                                                                                                <span class="price-new">$290,00</span>
                                                                                                <span class="price-old">$300,00</span>

                                                                                            </div>


                                                                                            <div class="clearfix"></div>
                                                                                            <p class="description" itemprop="description">	HTC Touch - in High Definition. Watch music videos and streaming content in awe-inspiring high defi.....</p>
                                                                                        </div>

                                                                                    </div>
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </div><!-- end div.carousel-content-->

                                                        </div><!-- end div.tab-panel-->
                                                    </div><!-- end div.tab-content -->

                                                </div><!-- end div.box-wapper -->
                                            </div>
                                            <!-- end div.box -->
                                            <script>
                                                $(function () {
                                                    $('.carousel378').carousel({interval:99999999999999,auto:false,pause:'hover'});
                                                    $('#pavo-categorytabs378 a:first').tab('show');
                                                });
                                            </script>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!--end tat cat các tab-->
                    <!--slider bot-->
                    <div class="pav-container ">
                        <div class="pav-inner">

                            <div class="row row-level-1 ">
                                <div class="row-inner  clearfix">
                                    <div class="pav-col col-lg-12 col-md-12 col-sm-12 col-xs-12   ">
                                        <div class="col-inner">
                                            <div id="pavcarousel6" class="box carousel slide pavcarousel  hidden-sm hidden-xs">
                                                <div class="box-heading">
                                                    <span>Đối tác</span>
                                                </div>
                                                <div class="box-content">
                                                    <div class="carousel-inner">

                                                        <div class="item active">
                                                            <div class="row">

                                                                <div class="col-lg-2 col-xs-6 col-sm-2">
                                                                    <div class="item-inner">
                                                                        <a href="#"><img src="image/cache/catalog/carousel/3-logo_brand-153x51.jpg" alt="Banner 1" class="img-responsive" /></a>
                                                                    </div>
                                                                </div>


                                                                <div class="col-lg-2 col-xs-6 col-sm-2">
                                                                    <div class="item-inner">
                                                                        <a href="#"><img src="image/cache/catalog/carousel/4-logo_brand-153x51.jpg" alt="Banner 2" class="img-responsive" /></a>
                                                                    </div>
                                                                </div>


                                                                <div class="col-lg-2 col-xs-6 col-sm-2">
                                                                    <div class="item-inner">
                                                                        <a href="#"><img src="image/cache/catalog/carousel/5-logo_brand-153x51.jpg" alt="Banner 3" class="img-responsive" /></a>
                                                                    </div>
                                                                </div>


                                                                <div class="col-lg-2 col-xs-6 col-sm-2">
                                                                    <div class="item-inner">
                                                                        <a href="#"><img src="image/cache/catalog/carousel/6-logo_brand-153x51.jpg" alt="Banner 4" class="img-responsive" /></a>
                                                                    </div>
                                                                </div>


                                                                <div class="col-lg-2 col-xs-6 col-sm-2">
                                                                    <div class="item-inner">
                                                                        <a href="#"><img src="image/cache/catalog/carousel/7-logo_brand-153x51.jpg" alt="Banner 5" class="img-responsive" /></a>
                                                                    </div>
                                                                </div>


                                                                <div class="col-lg-2 col-xs-6 col-sm-2">
                                                                    <div class="item-inner">
                                                                        <a href="#"><img src="image/cache/catalog/carousel/8-logo_brand-153x51.jpg" alt="Banner 6" class="img-responsive" /></a>
                                                                    </div>
                                                                </div>

                                                            </div>
                                                        </div>
                                                        <div class="item ">
                                                            <div class="row">

                                                                <div class="col-lg-2 col-xs-6 col-sm-2">
                                                                    <div class="item-inner">
                                                                        <a href="#"><img src="image/cache/catalog/carousel/6-logo_brand-153x51.jpg" alt="Banner 7" class="img-responsive" /></a>
                                                                    </div>
                                                                </div>


                                                                <div class="col-lg-2 col-xs-6 col-sm-2">
                                                                    <div class="item-inner">
                                                                        <a href="#"><img src="image/cache/catalog/carousel/4-logo_brand-153x51.jpg" alt="Banner 8" class="img-responsive" /></a>
                                                                    </div>
                                                                </div>


                                                                <div class="col-lg-2 col-xs-6 col-sm-2">
                                                                    <div class="item-inner">
                                                                        <a href="#"><img src="image/cache/catalog/carousel/5-logo_brand-153x51.jpg" alt="Banner 9" class="img-responsive" /></a>
                                                                    </div>
                                                                </div>


                                                                <div class="col-lg-2 col-xs-6 col-sm-2">
                                                                    <div class="item-inner">
                                                                        <a href="#"><img src="image/cache/catalog/carousel/3-logo_brand-153x51.jpg" alt="Banner 10" class="img-responsive" /></a>
                                                                    </div>
                                                                </div>


                                                                <div class="col-lg-2 col-xs-6 col-sm-2">
                                                                    <div class="item-inner">
                                                                        <a href="#"><img src="image/cache/catalog/carousel/7-logo_brand-153x51.jpg" alt="Banne 11" class="img-responsive" /></a>
                                                                    </div>
                                                                </div>


                                                                <div class="col-lg-2 col-xs-6 col-sm-2">
                                                                    <div class="item-inner">
                                                                        <a href="#"><img src="image/cache/catalog/carousel/6-logo_brand-153x51.jpg" alt="Banne 12" class="img-responsive" /></a>
                                                                    </div>
                                                                </div>

                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="carousel-controls">
                                                        <a class="carousel-control left" href="#pavcarousel6" data-slide="prev">
                                                            <em class="fa fa-angle-left"></em>
                                                        </a>
                                                        <a class="carousel-control right" href="#pavcarousel6" data-slide="next">
                                                            <em class="fa fa-angle-right"></em>
                                                        </a>
                                                    </div>
                                                </div>
                                            </div>
                                            <script type="text/javascript">
<!--
                                                $('#pavcarousel6').carousel({interval:3000});
                                                </script>


                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!--endslider-->
                    <!--new letter-->
                    <div class="pav-container " style="background-color:#3a3a3a">
                        <div class="pav-inner">

                            <div class="row row-level-1 ">
                                <div class="row-inner  clearfix">
                                    <div class="pav-col col-lg-12 col-md-12 col-sm-12 col-xs-12   ">
                                        <div class="col-inner">
                                            <div class="box">
                                                <div class="box-heading hidden">Newsletter</div>
                                                <div class="box-content no-bg">
                                                    <div class=" pav-newsletter  clearfix" id="newsletter_1158092619">
                                                        <form id="formNewLestter" method="post" action="http://dothotuongphat.com/index.php?route=module/pavnewsletter/subscribe" class="formNewLestter">
                                                            <span class="pull-left"></span>
                                                            <div class="explain"><p><strong>ĐĂNG KÍ NHẬN  THÔNG TIN SẢN PHẨM  </strong></p></div>
                                                            <div class="clearfix input-group input-newsletter">
                                                                <div class="input-group">
                                                                    <input type="text" class="form-control email input-inverse input-lg inputNew" onblur="javascript:if(this.value=='')this.value='Your email address';" onfocus="javascript:if(this.value=='Your email address')this.value='';" value="Your email address" size="18" name="email">
                                                                    <span class="input-group-btn">
                                                                        <button type="submit" name="submitNewsletter" class="btn btn-newsletter">Subscribe</button>
                                                                    </span>
                                                                </div>
                                                                <input type="hidden" value="1" name="action">
                                                                <div class="valid"></div>
                                                            </div>
                                                        </form>

                                                    </div>
                                                </div>
                                            </div>



                                            <script type="text/javascript">


                                                $( document ).ready(function() {
                                                    var id = 'newsletter_1158092619';
                                                    $('#'+id+' .box-heading').bind('click', function(){
                                                        $('#'+id).toggleClass('active');
                                                    });

                                                    $('#formNewLestter').on('submit', function() {
                                                        var email = $('.inputNew').val();
                                                        $(".success_inline, .warning_inline, .error").remove();
                                                        if(!isValidEmailAddress(email)) {
                                                            $('.valid').html("<div class=\"error alert alert-danger\">Email is not valid!<button type=\"button\" class=\"close\" data-dismiss=\"alert\">×</button></div></div>");
                                                            $('.inputNew').focus();
                                                            return false;
                                                        }
                                                        var url = "indexa811.html?route=module/pavnewsletter/subscribe";
                                                        $.ajax({
                                                            type: "post",
                                                            url: url,
                                                            data: $("#formNewLestter").serialize(),
                                                            dataType: 'json',
                                                            success: function(json)
                                                            {
                                                                $(".success_inline, .warning_inline, .error").remove();
                                                                if (json['error']) {
                                                                    $('.valid').html("<div class=\"warning_inline alert alert-danger\">"+json['error']+"<button type=\"button\" class=\"close\" data-dismiss=\"alert\">×</button></div>");
                                                                }
                                                                if (json['success']) {
                                                                    $('.valid').html("<div class=\"success_inline alert alert-success\">"+json['success']+"<button type=\"button\" class=\"close\" data-dismiss=\"alert\">×</button></div>");
                                                                }
                                                            }
                                                        });
                                                        return false;
                                                    });
                                                });

                                                function isValidEmailAddress(emailAddress) {
                                                    var pattern = new RegExp(/^(("[\w-\s]+")|([\w-]+(?:\.[\w-]+)*)|("[\w-\s]+")([\w-]+(?:\.[\w-]+)*))(@((?:[\w-]+\.)*\w[\w-]{0,66})\.([a-z]{2,6}(?:\.[a-z]{2})?)$)|(@\[?((25[0-5]\.|2[0-4][0-9]\.|1[0-9]{2}\.|[0-9]{1,2}\.))((25[0-5]|2[0-4][0-9]|1[0-9]{2}|[0-9]{1,2})\.){2}(25[0-5]|2[0-4][0-9]|1[0-9]{2}|[0-9]{1,2})\]?$)/i);
                                                    return pattern.test(emailAddress);
                                                }
                                                </script>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>

    </div>
</div> 
            </div>
            <!--
             $ospans: allow overrides width of columns base on thiers indexs. format array( column-index=>span number ), example array( 1=> 3 )[value from 1->12]
            -->
            <!--footer-->
        <footer id="footer">
        <section class="footer-top " id="pavo-footer-top">
                    <div class="container">
                        <div class="inner">
                            <div class="row">
                                <div class="col-md-3 col-sm-12">
                                    <p><img src="css/image/logo.png" alt="logo"></p>
                                    <p><span>Hãy đến với chúng tôi nhông xích mạnh quang</span></p>
                                </div>
                                <div class="col-md-2 col-sm-4">
                                    <h5 class="box-heading"><span>Chăm sóc khách hàng</span></h5>
                                    <ul class="list-unstyled">
                                        <li><a href="index2724.html?route=information/contact">Liên hệ</a></li>
                                        <li><a href="index71ba.html?route=account/return/add">Trả hàng</a></li>
                                        <li><a href="index7cb2.html?route=information/sitemap">Sơ đồ trang</a></li>
                                    </ul>
                                </div>
                                <div class="col-md-2 col-sm-4">
                                    <h5 class="box-heading"><span>Chức năng khác</span></h5>
                                    <ul class="list-unstyled">
                                        <li><a href="indexd773.html?route=product/manufacturer">Thương hiệu</a></li>
                                        <li><a href="index4dd2.html?route=account/voucher">Phiếu quà tặng</a></li>
                                        <li><a href="index3d18.html?route=affiliate/account">Cộng Tác Bán Hàng</a></li>
                                        <li><a href="indexf110.html?route=product/special">Khuyến mãi</a></li>
                                    </ul>
                                </div>
                                <div class="col-md-2 col-sm-4">
                                    <h5 class="box-heading"><span>Đơn hàng</span></h5>
                                    <ul class="list-unstyled">
                                        <li><a href="#">Lịch sử đơn hàng</a></li>
                                        <li><a href="#">Danh sách yêu thích</a></li>
                                        <li><a href="#">Thư thông báo</a></li>
                                    </ul>
                                </div>
                                <div class="col-md-3 col-sm-12">
                                    <div class="box pav-custom  ">                                        <div class="box-heading">Mạnh Quang</div>                                        <div class="box-content">                                            <div class="address"><div class="box-addres"><div class="link-address icon"><span class="fa fa-map-marker">&nbsp;</span><span> &nbsp;Hà Nội, VN</span></div>                                                    <div class="link-mobile icon">                                                        <span class="fa fa-phone">&nbsp;</span><span>Phone: +84 0912456789</span></div>                                                    <div class="link-mail icon">                                                        <span class="fa fa-envelope">&nbsp;</span>                                                        <span>Email:Califaxit@gmail.com</span></div>                                                </div>                                            </div>                                        </div>                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </section>
                <div class="footer-center " id="pavo-footer-center">
                    <div class="container">
                        <div class="inner">
                            <div class="row">
                                <div class="col-lg-12 col-md-12  ">
                                    <div class="box pavgooglemap">
                                        <div class="box-heading">
                                            <span>pavo googlemap</span>
                                        </div>
                                        <div class="box-content">
                                            <div class="description"><p><br></p></div>
                                            <div class="pavmap">
                                                <div id="directory-main-bar-1" class="gmap"></div>
                                            </div>
                                        </div>
                                    </div>

                                    <script type="text/javascript">
                                        var mapDiv, map, infobox;
                                        jQuery(document).ready(function ($) {
                                            mapDiv = $("#directory-main-bar-1");
                                            mapDiv.height(330).gmap3({

                                                map: {
                                                    options: {
                                                        "draggable": true
                                                        , "mapTypeControl": true
                                                        , "mapTypeId": google.maps.MapTypeId.ROADMAP
                                                        , "scrollwheel": false //Alow scroll zoom in, zoom out
                                                        , "panControl": true
                                                        , "rotateControl": false
                                                        , "scaleControl": true
                                                        , "streetViewControl": true
                                                        , "zoomControl": true
                                                        , "scrollwheel": false
                                                    }
                                                }
                                                        , marker: {
                                                            values: [
                                                                                                {
                                                                                                    latLng: [21.066628841454087, 105.71351500138849],
                                                                                                    options: {
                                                                                                        icon: "",
                                                                                                        //shadow: "icon-shadow.png",
                                                                                                    },
                                                                                                    data: '<div class="marker-holder"><div class="marker-content with-image"><img src="http://dothotuongphat.com/image/cache/catalog/dothotuongphat-icon-120x160.png" alt=""><div class="map-item-info"><div class="title">' + "Siêu thị đồ thờ tượng phật" + '</div><div class="address">' + "Quốc lộ 32, Trạm Trôi, Hoài Đức, Hà Nội, Việt Nam" + '</div><div class="description">' + "Khu đô thị Tân Tây Đô,  Hà Nội, VN" + '</div><a href="' + "#" + '" class="more-button">' + "Xem thêm" + '</a></div><div class="arrow"></div><div class="close"></div></div></div></div>'
                                                                                                },
                                                                                                {
                                                                                                    latLng: [21.06867574878018, 105.71244416912532],
                                                                                                    options: {
                                                                                                        icon: "http://dothotuongphat.com/image/cache/data/pavmap/icons/default-49x56.png",
                                                                                                        //shadow: "icon-shadow.png",
                                                                                                    },
                                                                                                    data: '<div class="marker-holder"><div class="marker-content with-image"><img src="http://dothotuongphat.com/image/cache/data/pavmap/address/1-120x160.jpg" alt=""><div class="map-item-info"><div class="title">' + "Đồ thờ tượng phật" + '</div><div class="address">' + "Quốc lộ 32, Trạm Trôi, Hoài Đức, Hà Nội, Việt Nam" + '</div><div class="description">' + "Khu đô thị Tân Tây Đô,  Hà Nội, VN" + '</div><a href="' + "https://www.google.com/maps/place/Chung+c%C6%B0+T%C3%A2n+T%C3%A2y+%C4%90%C3%B4/@21.074348,105.701588,17z/data=!3m1!4b1!4m7!1m4!3m3!1s0x313455ce1f4315c3:0xe37771ad4d362bc7!2zQ2h1bmcgY8awIFTDom4gVMOieSDEkMO0!3b1!3m1!1s0x313455ce1f4315c3:0xe37771ad4d362bc7" + '" class="more-button">' + "Xem thêm" + '</a></div><div class="arrow"></div><div class="close"></div></div></div></div>'
                                                                                                },
                                                            ],
                                                            options: {
                                                                draggable: false, //Alow move icon location
                                                            },
                                                            cluster: {
                                                                radius: 20,
                                                                // This style will be used for clusters with more than 0 markers
                                                                0: {
                                                                    content: "<div class='cluster cluster-1'>CLUSTER_COUNT</div>",
                                                                    width: 90,
                                                                    height: 80
                                                                },
                                                                // This style will be used for clusters with more than 20 markers
                                                                20: {
                                                                    content: "<div class='cluster cluster-2'>CLUSTER_COUNT</div>",
                                                                    width: 90,
                                                                    height: 80
                                                                },
                                                                // This style will be used for clusters with more than 50 markers
                                                                50: {
                                                                    content: "<div class='cluster cluster-3'>CLUSTER_COUNT</div>",
                                                                    width: 90,
                                                                    height: 80
                                                                },
                                                                events: {
                                                                    click: function (cluster) {
                                                                        map.panTo(cluster.main.getPosition());
                                                                        map.setZoom(map.getZoom() + 2);
                                                                    }
                                                                }
                                                            },
                                                            events: {
                                                                click: function (marker, event, context) {
                                                                    map.panTo(marker.getPosition());

                                                                    infobox.setContent(context.data);
                                                                    infobox.open(map, marker);

                                                                    // if map is small
                                                                    var iWidth = 260;
                                                                    var iHeight = 300;
                                                                    if ((mapDiv.width() / 2) < iWidth) {
                                                                        var offsetX = iWidth - (mapDiv.width() / 2);
                                                                        map.panBy(offsetX, 0);
                                                                    }
                                                                    if ((mapDiv.height() / 2) < iHeight) {
                                                                        var offsetY = -(iHeight - (mapDiv.height() / 2));
                                                                        map.panBy(0, offsetY);
                                                                    }

                                                                }
                                                            }
                                                        }
                                            }, "autofit");

                                            map = mapDiv.gmap3("get");


                                            var classhtml = $('html').attr('dir');

                                            if (classhtml == 'rtl') {
                                                infobox = new InfoBox({
                                                    pixelOffset: new google.maps.Size(220, -65),
                                                    closeBoxURL: '',
                                                    enableEventPropagation: true,
                                                    maxWidth: 150,
                                                });
                                            } else {
                                                infobox = new InfoBox({
                                                    pixelOffset: new google.maps.Size(-50, -65),
                                                    closeBoxURL: '',
                                                    enableEventPropagation: true,
                                                    maxWidth: 150,
                                                });
                                            }


                                            mapDiv.delegate('.infoBox .close', 'click', function () {
                                                infobox.close();
                                            });
                                        });
                                    </script>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </footer>
            <div id="powered">
                <div class="container">
                    <div class="inner">
                        <div id="top"><a class="scrollup" href="#"><i class="fa fa-angle-up"></i>Top</a></div>
                        <div class="copyright">
                            Bản quyền &copy; 2015.
                            Designed by <a href="index.html" title="Califaxit" target="_blank">Califaxit</a>
                        </div>
                        <div class="paypal">
                            <img src="image/data/paypal.png" alt="paypal">
                        </div>
                    </div>
                </div>
            </div>
            <!--end footer-->
            <div class="outsite">
            </div>
            <script type="text/javascript">
                $('#myTab a').click(function (e) {
                    e.preventDefault();
                    $(this).tab('show');
                })
                $('#myTab a:first').tab('show');


                var $MAINCONTAINER = $("html");

                /**
                 * BACKGROUND-IMAGE SELECTION
                 */
                $(".background-images").each(function () {
                    var $parent = this;
                    var $input = $(".input-setting", $parent);
                    $(".bi-wrapper > div", this).click(function () {
                        $input.val($(this).data('val'));
                        $('.bi-wrapper > div', $parent).removeClass('active');
                        $(this).addClass('active');

                        if ($input.data('selector')) {
                            $($input.data('selector'), $($MAINCONTAINER)).css($input.data('attrs'), 'url(' + $(this).data('image') + ')');
                        }
                    });
                });

                $(".clear-bg").click(function () {
                    var $parent = $(this).parent();
                    var $input = $(".input-setting", $parent);
                    if ($input.val('')) {
                        if ($parent.hasClass("background-images")) {
                            $('.bi-wrapper > div', $parent).removeClass('active');
                            $($input.data('selector'), $("#main-preview iframe").contents()).css($input.data('attrs'), 'none');
                        } else {
                            $input.attr('style', '')
                        }
                        $($input.data('selector'), $($MAINCONTAINER)).css($input.data('attrs'), 'inherit');

                    }
                    $input.val('');

                    return false;
                });



                $('.accordion-group input.input-setting').each(function () {
                    var input = this;
                    $(input).attr('readonly', 'readonly');
                    $(input).ColorPicker({
                        onChange: function (hsb, hex, rgb) {
                            $(input).css('backgroundColor', '#' + hex);
                            $(input).val(hex);
                            if ($(input).data('selector')) {
                                $($MAINCONTAINER).find($(input).data('selector')).css($(input).data('attrs'), "#" + $(input).val())
                            }
                        }
                    });
                });
                $('.accordion-group select.input-setting').change(function () {
                    var input = this;
                    if ($(input).data('selector')) {
                        var ex = $(input).data('attrs') == 'font-size' ? 'px' : "";
                        $($MAINCONTAINER).find($(input).data('selector')).css($(input).data('attrs'), $(input).val() + ex);
                    }
                });


            </script>
        </div>
        <!--danh muc reponsive-->
        <div class="sidebar-offcanvas  visible-xs visible-sm">
            <div class="offcanvas-inner panel panel-offcanvas">
                <div class="offcanvas-heading">
                    <button type="button" class="btn btn-outline btn-close " data-toggle="offcanvas"> <span class="fa fa-times"></span></button>
                </div>
                <div class="offcanvas-body panel-body">
                    <div class="category box box-highlights theme">
                        <div class="box-heading"><span>Danh Mục</span></div>
                        <div class="box-content tree-menu">
                            <ul id="791747336accordion" class="box-category box-panel">
                                <li class="accordion-group clearfix">
                                    <a href="#">Nhông</a>
                                </li>
                                <li class="accordion-group clearfix">
                                    <a href="#">Xích</a>
                                </li>
                                
                            </ul>
                        </div>
                    </div>
                    <script type="text/javascript">
                        $(document).ready(function () {
                            var active = $('.collapse.in').attr('id');
                            $('span[data-target=#' + active + ']').html("-");

                            $('.collapse').on('show.bs.collapse', function () {
                                $('span[data-target=#' + $(this).attr('id') + ']').html("-");
                            });
                            $('.collapse').on('hide.bs.collapse', function () {
                                $('span[data-target=#' + $(this).attr('id') + ']').html("+");
                            });
                        });
                    </script>

                </div>
               
            </div>
        </div>
        <!--end slider bot-->
    </div>
</body>
</html>