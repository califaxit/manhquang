<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detail.aspx.cs" Inherits="manhquang.com.Detail" %>

<!DOCTYPE html>
<html dir="ltr" class="ltr" lang="vi">
<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Manh quang</title>
    <link href="images/favicon.ico" rel="icon" />
    <link href="css/stylesheet/bootstrap.css" rel="stylesheet" />
    <link href="css/stylesheet/stylesheet.css" rel="stylesheet" />
    <link href="css/stylesheet/font.css" rel="stylesheet" />
    <link href="css/stylesheet/paneltool.css" rel="stylesheet" />
    <link href="JS/Script/jquery/colorpicker/css/colorpicker.css" rel="stylesheet" />
    <link href="JS/Script/font-awesome/css/font-awesome.min.css" rel="stylesheet" />
    <link href="JS/Script/jquery/magnific/magnific-popup.css" rel="stylesheet" />
    <link href="css/stylesheet/homebuilder.css" rel="stylesheet" />
    <link href="css/stylesheet/pavproducttabs.css" rel="stylesheet" />
    <link href="css/stylesheet/pavverticalcategorytabs.css" rel="stylesheet" />
    <link href="css/stylesheet/bootstrap-tabs-x.css" rel="stylesheet" />
    <link href="css/stylesheet/pavcarousel.css" rel="stylesheet" />
    <link href="css/stylesheet/pavnewsletter.css" rel="stylesheet" />
    <link href="css/stylesheet/pavmap.css" rel="stylesheet" />
    <link href="css/stylesheet/pavreassurance.css" rel="stylesheet" />
    <link href="css/stylesheet/sliderlayer/css/typo.css" rel="stylesheet" />
    <script src="JS/Script/jquery/jquery-2.1.1.min.js"></script>
    <script src="JS/Script/jquery/magnific/jquery.magnific-popup.min.js"></script>
    <script src="JS/Script/bootstrap/js/bootstrap.min.js"></script>
    <script src="JS/Script/common.js"></script>
    <script src="css/javascript/common.js"></script>
    <script src="JS/Script/jquery/colorpicker/js/colorpicker.js"></script>
    <script type="text/javascript" src="https://maps.googleapis.com/maps/api/js?v=3.exp&amp;sensor=false&amp;language=en"></script>
    <script src="JS/Script/gmap/gmap3.min.js"></script>
    <script src="JS/Script/gmap/gmap3.infobox.js"></script>
    <script src="JS/Script/layerslider/jquery.themepunch.plugins.min.js"></script>
    <script src="JS/Script/layerslider/jquery.themepunch.revolution.min.js"></script>
    <script src="JS/Common/jquery-jtemplates.js"></script>
    <script src="JS/FRAMEWORK/SystemConfig.js"></script>
    <script src="JS/Script/jquery/elevatezoom/elevatezoom-min.js"></script>
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
                                        <form action="http://dothotuongphat.com/index.php?route=common/currency/currency" method="post" enctype="multipart/form-data" id="currency">
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
                    <header id="header">
                        <div id="header-main" class="hasverticalmenu">
                            <div class="container">
                                <div class="row">
                                    <div class="logo inner  col-lg-3 col-md-3 col-sm-3 col-xs-12">
                                        <div id="logo-theme" class="logo-store pull-left">
                                            <a href="index9328.html?route=common/home">
                                                <span>Nhông xích Yamaha</span>
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
                                                            <option value="67">Cosmetics</option>
                                                            <option value="68">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Bath &amp; Body</option>
                                                            <option value="69">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Eye Shadow</option>
                                                            <option value="70">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Hair color</option>
                                                            <option value="72">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Shampoo</option>
                                                            <option value="71">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Styling</option>
                                                            <option value="73">Fashion</option>
                                                            <option value="74">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Beauty</option>
                                                            <option value="75">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Clothing</option>
                                                            <option value="76">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Dresses</option>
                                                            <option value="77">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Sport</option>
                                                            <option value="78">Food</option>
                                                            <option value="81">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Healthy eating</option>
                                                            <option value="79">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Nutrition</option>
                                                            <option value="82">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Snack Cookies</option>
                                                            <option value="80">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Snack Foods</option>
                                                            <option value="83">Infant toys</option>
                                                            <option value="84">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Baby Bath</option>
                                                            <option value="85">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Baby Rattles</option>
                                                            <option value="86">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Musical Toys</option>
                                                            <option value="87">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Toddler Toys</option>
                                                            <option value="88">Không gian chùa</option>
                                                            <option value="89">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Boat Shoe</option>
                                                            <option value="90">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Boots</option>
                                                            <option value="91">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Foot Rasps</option>
                                                            <option value="92">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Running Shoe</option>
                                                            <option value="93">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Spa Slippers</option>
                                                            <option value="20">Không gian đình</option>
                                                            <option value="60">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Blender</option>
                                                            <option value="59">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Toaster</option>
                                                            <option value="26">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;LED TVs</option>
                                                            <option value="27">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Fridge Freezers</option>
                                                            <option value="18">Phòng thờ tư gia</option>
                                                            <option value="61">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Ipad</option>
                                                            <option value="46">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Iphone</option>
                                                            <option value="62">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Samsung</option>
                                                            <option value="45">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Tablets</option>
                                                            <option value="57">Không gian nhà thờ</option>
                                                            <option value="25">Tượng phật</option>
                                                            <option value="29">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Mice and Trackballs</option>
                                                            <option value="28">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Monitors</option>
                                                            <option value="30">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Printers</option>
                                                            <option value="31">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Scanners</option>
                                                            <option value="32">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Web Cameras</option>
                                                            <option value="17">Không gian điện</option>
                                                            <option value="24">Không gian đền</option>
                                                            <option value="33">Không gian thờ cúng</option>
                                                            <option value="34">Electronics</option>
                                                            <option value="64">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Accessories</option>
                                                            <option value="65">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;LED TVs</option>
                                                            <option value="66">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Others</option>
                                                            <option value="63">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Washing</option>
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
                                            <script type="text/javascript">

                                                /* Autocomplete */
                                                (function($) {
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
                                                        focus: function() {
                                                            this.request();
                                                        },
                                                        blur: function() {
                                                            setTimeout(function(object) {
                                                                object.hide();
                                                            }, 200, this);
                                                        },
                                                        click: function(event) {
                                                            event.preventDefault();
                                                            value = $(event.target).parent().attr("href");
                                                            if (value) {
                                                                window.location = value.replace(/&amp;/gi,'&');
                                                            }
                                                        },
                                                        keydown: function(event) {
                                                            switch(event.keyCode) {
                                                                case 27: // escape
                                                                    this.hide();
                                                                    break;
                                                                default:
                                                                    this.request();
                                                                    break;
                                                            }
                                                        },
                                                        show: function() {
                                                            var pos = $(this.element).position();

                                                            $(this.element).siblings('ul.dropdown-menu').css({
                                                                top: pos.top + $(this.element).outerHeight(),
                                                                left: pos.left
                                                            });

                                                            $(this.element).siblings('ul.dropdown-menu').show();
                                                        },
                                                        hide: function() {
                                                            $(this.element).siblings('ul.dropdown-menu').hide();
                                                        },
                                                        request: function() {
                                                            clearTimeout(this.timer);

                                                            this.timer = setTimeout(function(object) {
                                                                object.options.source($(object.element).val(), $.proxy(object.response, object));
                                                            }, 200, this);
                                                        },
                                                        response: function(json) {
                                                            console.log(json);
                                                            html = '';

                                                            if (json.length) {
                                                                for (i = 0; i < json.length; i++) {
                                                                    this.items[json[i]['value']] = json[i];
                                                                }

                                                                for (i = 0; i < json.length; i++) {
                                                                    if (!json[i]['category']) {
                                                                        html += '<li class="media" data-value="' + json[i]['value'] + '">';
                                                                        if(json[i]['simage']) {
                                                                            html += '	<a class="media-left" href="' + json[i]['link'] + '"><img  src="' + json[i]['image'] + '"></a>';
                                                                        }
                                                                        html += '<div class="media-body">';
                                                                        html += '	<a  href="' + json[i]['link'] + '"><span>' + json[i]['label'] + '</span></a>';
                                                                        if(json[i]['sprice']){
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

                                                    $.fn.autocomplete1 = function(option) {
                                                        return this.each(function() {
                                                            var data = $(this).data('autocomplete');
                                                            if (!data) {
                                                                data = new Autocomplete1(this, option);
                                                                $(this).data('autocomplete', data);
                                                            }
                                                        });
                                                    }
                                                })(window.jQuery);
                                                $(document).ready(function() {
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
                                                        source: function(request, response) {
                                                            var category_id = $(".category_filter select[name=\"category_id\"]").first().val();
                                                            if(typeof(category_id) == 'undefined')
                                                                category_id = 0;
                                                            var limit = 5;
                                                            var search_sub_category = search_sub_category?'&sub_category=true':'';
                                                            var search_description = search_description?'&description=true':'';
                                                            $.ajax({
                                                                url: 'index.php?route=module/pavautosearch/autocomplete&filter_category_id='+category_id+'&width='+width+'&height='+height+'&limit='+limit+search_sub_category+search_description+'&filter_name='+encodeURIComponent(request),
                                                                dataType: 'json',
                                                                success: function(json) {
                                                                    response($.map(json, function(item) {
                                                                        if($('.pavautosearch_result')){
                                                                            $('.pavautosearch_result').first().html("");
                                                                        }
                                                                        total = 0;
                                                                        if(item.total){
                                                                            total = item.total;
                                                                        }
                                                                        return {
                                                                            price:   item.price,
                                                                            speical: item.special,
                                                                            tax:     item.tax,
                                                                            label:   item.name,
                                                                            image:   item.image,
                                                                            link:    item.link,
                                                                            value:   item.product_id,
                                                                            sprice:  show_price,
                                                                            simage:  show_image,
                                                                        }
                                                                    }));
                                                                }
                                                            });
                                                        },
                                                    }); // End Autocomplete

                                                });// End document.ready

                                            </script>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </header>
                    <section id="pav-masshead" class="pav-masshead aligned-right">
                        <div class="container">
                            <div class="inner row clearfix">
                                <!--menu doc-->
                                <div id="hideverticalmenu" class="col-lg-3 col-md-3 col-sm-4 hidden-xs">
                                    <div id="pav-verticalmenu" class="pav-verticalmenu hasicon box box-highlighted hidden-xs">
                                        <div class="box-heading">
                                            <span>Danh Mục</span>
                                        </div>
                                        <div class="box-content">
                                            <div id="verticalmenu" class="verticalmenus" role="navigation">
                                                <div class="navbar navbar-vertical">
                                                    <a href="javascript:;" data-target=".navbar-collapse" data-toggle="collapse" class="navbar-toggle">
                                                        <span class="icon-bar"></span>
                                                    </a>
                                                    <div class="collapse navbar-collapse navbar-ex1-collapse" style="height:auto;">
                                                        <ul class="nav navbar-nav verticalmenu">






                                                            <li class="parent dropdown ">
                                                                <a class="dropdown-toggle" data-toggle="dropdown" href="#"><span class="menu-icon" style="background:url('image/catalog/icon-verticalmenu/icon08.png') no-repeat;"><span class="menu-title">Nhông xích</span><b class="caret"></b></span></a><div class="dropdown-menu level1">
                                                                    <div class="dropdown-menu-inner">
                                                                        <div class="row">
                                                                            <div class="mega-col col-md-12" data-type="menu">
                                                                                <div class="mega-col-inner">
                                                                                    <ul>
                                                                                        <li class=" "><a href="#"><span class="menu-title">Yamaha</span></a></li>
                                                                                        <li class=" "><a href="#"><span class="menu-title">Honda </span></a></li>
                                                                                        <li class=" "><a href="#"><span class="menu-title">Suzuki</span></a></li>
                                                                                        <li class=" "><a href="#"><span class="menu-title">Swm</span></a></li>

                                                                                    </ul>
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </li>
                                                            <li class="parent dropdown ">
                                                                <a class="dropdown-toggle" data-toggle="dropdown" href="#"><span class="menu-icon" style="background:url('image/catalog/icon-verticalmenu/icon08.png') no-repeat;"><span class="menu-title">Đĩa</span><b class="caret"></b></span></a><div class="dropdown-menu level1">
                                                                    <div class="dropdown-menu-inner">
                                                                        <div class="row">
                                                                            <div class="mega-col col-md-12" data-type="menu">
                                                                                <div class="mega-col-inner">
                                                                                    <ul>
                                                                                        <li class=" "><a href="#"><span class="menu-title">Yamaha</span></a></li>
                                                                                        <li class=" "><a href="#"><span class="menu-title">Honda </span></a></li>
                                                                                        <li class=" "><a href="#"><span class="menu-title">Suzuki</span></a></li>
                                                                                        <li class=" "><a href="#"><span class="menu-title">Swm</span></a></li>

                                                                                    </ul>
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </li>






                                                        </ul>
                                                    </div>
                                                </div>
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
                                                        <li class="home"><a href="index9328-2.html?route=common/home"><span class=""></span><span class="menu-title">Trang chủ</span></a></li>
                                                        <li class=" aligned-fullwidth parent dropdown ">
                                                            <a href="index1647.html?route=product/category&amp;path=25" class="dropdown-toggle" data-toggle="dropdown"><span class=""></span><span class="menu-title">Sản phẩm</span><b class="caret"></b></a><div class="dropdown-menu" style="width:1170px">
                                                                <div class="dropdown-menu-inner">
                                                                    <div class="row">
                                                                        <div class="mega-col col-xs-12 col-sm-12 col-md-3 ">
                                                                            <div class="mega-col-inner">
                                                                                <div class="pavo-widget" id="pavowid-26">
                                                                                    <div class="pavo-widget" id="pavowid-735143602">
                                                                                        <h4 class="widget-heading title">Nhômg xích</h4>

                                                                                        <div class="">
                                                                                            <ul class="content">
                                                                                                <li>
                                                                                                    <a href="indexc219.html?route=product/category&amp;path=25_29">
                                                                                                        <span>HonDa</span>
                                                                                                    </a>
                                                                                                </li>
                                                                                                <li>
                                                                                                    <a href="indexe177.html?route=product/category&amp;path=25_28">
                                                                                                        <span>Yamaha</span>
                                                                                                    </a>
                                                                                                </li>
                                                                                                <li>
                                                                                                    <a href="index68a7.html?route=product/category&amp;path=25_30">
                                                                                                        <span>SWM</span>
                                                                                                    </a>
                                                                                                </li>
                                                                                                <li>
                                                                                                    <a href="indexf3db.html?route=product/category&amp;path=25_31">
                                                                                                        <span>Suzuki</span>
                                                                                                    </a>
                                                                                                </li>

                                                                                            </ul>
                                                                                        </div>
                                                                                    </div>
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                        <div class="mega-col col-xs-12 col-sm-12 col-md-3 ">
                                                                            <div class="mega-col-inner">
                                                                                <div class="pavo-widget" id="pavowid-26">
                                                                                    <div class="pavo-widget" id="pavowid-735143602">
                                                                                        <h4 class="widget-heading title">Đĩa</h4>

                                                                                        <div class="">
                                                                                            <ul class="content">
                                                                                                <li>
                                                                                                    <a href="indexc219.html?route=product/category&amp;path=25_29">
                                                                                                        <span>HonDa</span>
                                                                                                    </a>
                                                                                                </li>
                                                                                                <li>
                                                                                                    <a href="indexe177.html?route=product/category&amp;path=25_28">
                                                                                                        <span>Yamaha</span>
                                                                                                    </a>
                                                                                                </li>
                                                                                                <li>
                                                                                                    <a href="index68a7.html?route=product/category&amp;path=25_30">
                                                                                                        <span>SWM</span>
                                                                                                    </a>
                                                                                                </li>
                                                                                                <li>
                                                                                                    <a href="indexf3db.html?route=product/category&amp;path=25_31">
                                                                                                        <span>Suzuki</span>
                                                                                                    </a>
                                                                                                </li>

                                                                                            </ul>
                                                                                        </div>
                                                                                    </div>
                                                                                </div>
                                                                            </div>
                                                                        </div>



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
            <div id="columns">
                <div class="container">
                    <ul class="breadcrumb">
                        <li><a href="index9328.html?route=common/home">Trang chủ</a></li>
                        <li><a href="indexffe5.html?route=product/product&amp;product_id=2134">Nhông xích Yamaha</a></li>
                    </ul>  <div class="row">
                        <aside id="sidebar-left" class="col-md-3">
                            <column id="column-left" class="hidden-xs sidebar">

                                <div class="category box box-highlights theme">
                                    <div class="box-heading"><span>Danh Mục</span></div>
                                    <div class="box-content tree-menu">
                                        <ul id="1011211586accordion" class="box-category box-panel">
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

                            </column>
                        </aside>

                        <section id="sidebar-main" class="col-md-9">
                            <div id="contents" class="wrappers clearfix">

                                <div class="product-info">
                                    <div class="row">
                                        <div class="col-lg-5 col-md-5 col-sm-5 col-xs-12 image-container">
                                            <div class="image">


                                                <a href="images/Content_Product/Detail/1a.jpg" title="Nhông xích Yamaha" class="imagezoom">
                                                    <img itemprop="image" src="images/Content_Product/Detail/1a.jpg" title="Nhông xích Yamaha" alt="Nhông xích Yamaha" id="image" data-zoom-image="http://dothotuongphat.com/image/cache/catalog/demo/electronic/4a-500x515.jpg" class="product-image-zoom img-responsive" />
                                                </a>

                                            </div>
                                            <div class="thumbs-preview">
                                                <div class="image-additional slide carousel " id="image-additional">
                                                    <div id="image-additional-carousel" class="carousel-inner">
                                                        <div class="item clearfix">
                                                            <a href="images/Content_Product/Detail/1a.jpg" title="Nhông xích Yamaha" class="imagezoom" data-zoom-image="images/Content_Product/Detail/1a.jpg" data-image="images/Content_Product/Detail/1a.jpg">
                                                                <img src="images/Content_Product/Detail/1a.jpg" style="max-width:75px" title="Nhông xích Yamaha" alt="Nhông xích Yamaha" data-zoom-image="images/Content_Product/Detail/1a.jpg" class="product-image-zoom img-responsive" />
                                                            </a>
                                                            <a href="images/Content_Product/Detail/1a.jpg" title="Nhông xích Yamaha" class="imagezoom" data-zoom-image="images/Content_Product/Detail/1a.jpg" data-image="image/cache/catalog/demo/electronic/4b-500x515.jpg">
                                                                <img src="images/Content_Product/Detail/1a.jpg" style="max-width:75px" title="Nhông xích Yamaha" alt="Nhông xích Yamaha" data-zoom-image="images/Content_Product/Detail/1a.jpg" class="product-image-zoom img-responsive" />
                                                            </a>
                                                        </div>
                                                    </div>

                                                    <!-- Controls -->
                                                </div>
                                                <script type="text/javascript">
                                                    $('#image-additional .item:first').addClass('active');
                                                    $('#image-additional').carousel({ interval: false })
                                                </script>
                                            </div>
                                        </div>

                                        <div class="col-xs-12 col-sm-7 col-md-7 col-lg-7 product-view">
                                            <h1 class="name">Nhông xích Yamaha</h1>
                                            <div class="rating">
                                                <p>
                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-1x"></i></span>
                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-1x"></i></span>
                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-1x"></i></span>
                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-1x"></i></span>
                                                    <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-1x"></i></span>
                                                    <a href="#review-form" class="popup-with-form" onclick="$('a[href=\'#tab-review\']').trigger('click'); return false;">0 đánh giá</a> / <a href="#review-form" class="popup-with-form" onclick="$('a[href=\'#tab-review\']').trigger('click'); return false;">Viết đánh giá</a>
                                                </p>
                                                <hr>

                                            </div>

                                            <div class="product-extra">
                                                <ul class="list-unstyled description no-padding">
                                                    <li><i class="fa fa-chevron-down"></i><b>Nhà sản xuất:</b> <a href="index98fa.html?route=product/manufacturer/info&amp;manufacturer_id=8">Apple</a></li>
                                                    <li><i class="fa fa-chevron-down"></i><b>Mã sản phẩm:</b> electrical</li>
                                                    <li><i class="fa fa-chevron-down"></i><b>Tình trạng:</b> Còn hàng</li>
                                                </ul>
                                            </div>
                                            <div class="price">
                                                <ul class="list-unstyled">

                                                    <li class="price-gruop">
                                                        <span class="price-new">$525,00</span>
                                                    </li>
                                                    <li class="other-price price-tax">Giá chưa VAT: $525,00</li>

                                                </ul>
                                            </div>




                                            <!-- AddThis Button BEGIN -->
                                            
                                            <!-- AddThis Button END -->
                                        </div>
                                    </div>
                                </div>
                                <div class="tabs-group box">
                                    <ul class="nav nav-tabs clearfix">
                                        <li class="active"><a href="#tab-description" data-toggle="tab">Mô tả</a></li>
                                        <li><a href="#tab-review" data-toggle="tab">Đánh giá (0)</a></li>
                                    </ul>
                                    <div class="tab-content">
                                        <div class="tab-pane active" id="tab-description">
                                            <p>
                                                Praesent id libero rhoncus, dignissim enim in, ultricies erat. Maecenas
                                                vel lacus hendrerit, lobortis ligula sit amet, condimentum turpis.
                                                Aenean ac vulputate mauris. Fusce nunc ante, vulputate ac viverra ut,
                                                mollis et augue. Sed a est vel lacus rhoncus maximus tristique vitae
                                                sem. Cras pretium, est sagittis ullamcorper pharetra, eros est convallis
                                                odio, hendrerit tempor justo lectus et augue. Aenean rutrum venenatis
                                                tellus et condimentum. Aenean euismod risus dolor, ut euismod lacus
                                                bibendum ac. Suspendisse potenti.
                                            </p>
                                            <p>
                                                Donec eu leo dapibus, rutrum arcu non, consequat justo. Curabitur
                                                venenatis justo in lectus cursus feugiat. Nulla vehicula ligula tortor,
                                                non sollicitudin nulla tristique ac. Duis facilisis tortor nulla, sit
                                                amet ullamcorper leo malesuada sit amet. Sed ac libero ligula. Nam
                                                blandit tellus facilisis mi varius, nec placerat arcu posuere. Proin et
                                                erat sit amet purus lobortis commodo sit amet sagittis metus. Etiam
                                                pellentesque eros tincidunt purus malesuada aliquam. Ut in turpis vitae
                                                ligula sagittis cursus a non dolor. Nunc mollis quis odio non semper.
                                            </p>
                                            <p>
                                                Fusce a pellentesque magna. Nhông xích Yamaha, vulputate vel vestibulum
                                                ac, rutrum ut tortor. Praesent quis blandit sem, non ultrices lectus.
                                                Sed vitae est ligula. Morbi imperdiet, risus aliquet ornare faucibus,
                                                orci diam mollis odio, nec rhoncus massa purus eget odio. Curabitur
                                                lobortis neque et ultricies auctor. Proin auctor dapibus rutrum.
                                            </p>
                                        </div>

                                        <div class="tab-pane" id="tab-review">

                                            <div id="review"></div>
                                            <p> <a href="#review-form" class="popup-with-form btn btn-sm btn-inverse" onclick="$('a[href=\'#tab-review\']').trigger('click'); return false;">Viết đánh giá</a></p>

                                            <div class="hide">
                                                <div id="review-form" class="panel">
                                                    <div class="panel-body">
                                                        <form class="form-horizontal ">

                                                            <h2>Viết đánh giá</h2>
                                                            <div class="form-group required">
                                                                <div class="col-sm-12">
                                                                    <label class="control-label" for="input-name">Tên bạn:</label>
                                                                    <input type="text" name="name" value="" id="input-name" class="form-control" />
                                                                </div>
                                                            </div>
                                                            <div class="form-group required">
                                                                <div class="col-sm-12">
                                                                    <label class="control-label" for="input-review">Đánh giá của bạn:</label>
                                                                    <textarea name="text" rows="5" id="input-review" class="form-control"></textarea>
                                                                    <div class="help-block"><span style="color: #FF0000;">Lưu ý:</span> không hỗ trợ HTML!</div>
                                                                </div>
                                                            </div>
                                                            <div class="form-group required">
                                                                <div class="col-sm-12">
                                                                    <label class="control-label">Bình chọn:</label>
                                                                    &nbsp;&nbsp;&nbsp; Xấu&nbsp;
                                                                    <input type="radio" name="rating" value="1" />
                                                                    &nbsp;
                                                                    <input type="radio" name="rating" value="2" />
                                                                    &nbsp;
                                                                    <input type="radio" name="rating" value="3" />
                                                                    &nbsp;
                                                                    <input type="radio" name="rating" value="4" />
                                                                    &nbsp;
                                                                    <input type="radio" name="rating" value="5" />
                                                                    &nbsp;Tốt
                                                                </div>
                                                            </div>
                                                            <div class="form-group required">
                                                                <div class="col-sm-12">
                                                                    <label class="control-label" for="input-captcha">Nhập mã kiểm tra vào ô bên dưới:</label>
                                                                    <input type="text" name="captcha" value="" id="input-captcha" class="form-control" />
                                                                </div>
                                                            </div>
                                                            <div class="form-group">
                                                                <div class="col-sm-12"> <img src="indexc514.jpg?route=tool/captcha" alt="" id="captcha" /> </div>
                                                            </div>
                                                            <div class="buttons">
                                                                <div class="pull-right">
                                                                    <button type="button" id="button-review" data-loading-text="Đang xử lý..." class="btn btn-outline">Tiếp tục</button>
                                                                </div>
                                                            </div>
                                                        </form>
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
            <script type="text/javascript">
                var zoomCollection = '#image';
                $(zoomCollection).elevateZoom({
                    lensShape: "basic",
                    lensSize: 150,
                    easing: true,
                    gallery: 'image-additional-carousel',
                    cursor: 'pointer',
                    galleryActiveClass: "active"
                });

            </script>
            <!--
                content
            
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
                $(".background-images").each( function(){
                    var $parent = this;
                    var $input  = $(".input-setting", $parent );
                    $(".bi-wrapper > div",this).click( function(){
                        $input.val( $(this).data('val') );
                        $('.bi-wrapper > div', $parent).removeClass('active');
                        $(this).addClass('active');

                        if( $input.data('selector') ){
                            $($input.data('selector'), $($MAINCONTAINER) ).css( $input.data('attrs'),'url('+ $(this).data('image') +')' );
                        }
                    } );
                } );

                $(".clear-bg").click( function(){
                    var $parent = $(this).parent();
                    var $input  = $(".input-setting", $parent );
                    if( $input.val('') ) {
                        if( $parent.hasClass("background-images") ) {
                            $('.bi-wrapper > div',$parent).removeClass('active');
                            $($input.data('selector'),$("#main-preview iframe").contents()).css( $input.data('attrs'),'none' );
                        }else {
                            $input.attr( 'style','' )
                        }
                        $($input.data('selector'), $($MAINCONTAINER) ).css( $input.data('attrs'),'inherit' );

                    }
                    $input.val('');

                    return false;
                } );



                $('.accordion-group input.input-setting').each( function(){
                    var input = this;
                    $(input).attr('readonly','readonly');
                    $(input).ColorPicker({
                        onChange:function (hsb, hex, rgb) {
                            $(input).css('backgroundColor', '#' + hex);
                            $(input).val( hex );
                            if( $(input).data('selector') ){
                                $( $MAINCONTAINER ).find($(input).data('selector')).css( $(input).data('attrs'),"#"+$(input).val() )
                            }
                        }
                    });
                } );
                $('.accordion-group select.input-setting').change( function(){
                    var input = this;
                    if( $(input).data('selector') ){
                        var ex = $(input).data('attrs')=='font-size'?'px':"";
                        $( $MAINCONTAINER ).find($(input).data('selector')).css( $(input).data('attrs'), $(input).val() + ex);
                    }
                } );


            </script>
        </div>
        <!--slider bot-->
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
                                    <a href="#">Xích</a>
                                </li>
                                <li class="accordion-group clearfix">
                                    <a href="Nhông">Fashion (74)</a>
                                </li>                               
                            </ul>
                        </div>
                    </div>
                    <script type="text/javascript">
                        $(document).ready(function(){
                            var active = $('.collapse.in').attr('id');
                            $('span[data-target=#'+active+']').html("-");

                            $('.collapse').on('show.bs.collapse', function () {
                                $('span[data-target=#'+$(this).attr('id')+']').html("-");
                            });
                            $('.collapse').on('hide.bs.collapse', function () {
                                $('span[data-target=#'+$(this).attr('id')+']').html("+");
                            });
                        });
                    </script>

                </div>
                <div class="offcanvas-footer panel-footer">
                    <div class="input-group" id="offcanvas-search">
                        <input type="text" class="form-control" placeholder="Search" value="" name="search">
                        <span class="input-group-btn">
                            <button class="btn btn-default" type="button"><i class="fa fa-search"></i></button>
                        </span>
                    </div>
                </div>
            </div>
        </div>
        <!--end slider bot-->
    </div>
</body>
<!-- Mirrored from dothotuongphat.com/ by HTTrack Website Copier/3.x [XR&CO'2014], Tue, 23 Jun 2015 01:55:57 GMT -->
</html>