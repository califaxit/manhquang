<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="product.aspx.cs" Inherits="manhquang.com.product" %>

<!DOCTYPE html>
<html dir="ltr" class="ltr" lang="vi">
<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Manh quang</title>
    <link href="images/favicon.ico" rel="icon" />
    <script src="JS/FRAMEWORK/Include.JS.Base.js"></script>
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
                                            <script type="text/javascript">

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
                                                    <div class="collapse navbar-collapse navbar-ex1-collapse" style="height: auto;">
                                                        <ul class="nav navbar-nav verticalmenu">
                                                            <li class="parent dropdown ">
                                                                <a class="dropdown-toggle" data-toggle="dropdown" href="#"><span class="menu-icon" style="background: url('image/catalog/icon-verticalmenu/icon08.png') no-repeat;"><span class="menu-title">Nhông xích</span><b class="caret"></b></span></a><div class="dropdown-menu level1">
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
                                                                <a class="dropdown-toggle" data-toggle="dropdown" href="#"><span class="menu-icon" style="background: url('image/catalog/icon-verticalmenu/icon08.png') no-repeat;"><span class="menu-title">Đĩa</span><b class="caret"></b></span></a><div class="dropdown-menu level1">
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
                                                            <a href="index1647.html?route=product/category&amp;path=25" class="dropdown-toggle" data-toggle="dropdown"><span class=""></span><span class="menu-title">Sản phẩm</span><b class="caret"></b></a><div class="dropdown-menu" style="width: 1170px">
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



                                                        <li class=""><a href="index1766.html?route=information/information&amp;information_id=6"><span class=""></span><span class="menu-title">Giới Thiệu</span></a></li>
                                                        <li class=""><a href="index2724.html?route=information/contact"><span class=""></span><span class="menu-title">Liên Hệ</span></a></li>
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
                        <li><a href="#">Nhông</a></li>
                    </ul>
                    <div class="row">
                        <aside id="sidebar-left" class="col-md-3">
                            <column id="column-left" class="hidden-xs sidebar">    
<div class="category box box-highlights theme">
    <div class="box-heading"><span>Danh Mục</span></div>
    <div class="box-content tree-menu">
        <ul id="366439906accordion" class="box-category box-panel">
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
                            <div id="content">
                                <h1 class="heading-category">Nhông</h1>
                                <div class="box category-info ">
                                    <div class="image">
                                        <img src="#" alt="ảnh category" title="Nhông" class="img-responsive" />
                                    </div>
                                    <div class="category-description">
                                    </div>
                                </div>

                                <div class="product-filter ">
                                    <div class="inner clearfix">
                                        <div class="display">
                                            <div class="btn-group group-switch">
                                                <button type="button" id="list-view" class="btn btn-switch list" data-toggle="tooltip" title="List">
                                                    <i class="fa fa-th-list"></i>
                                                </button>
                                                <button type="button" id="grid-view" class="btn btn-switch grid active" data-toggle="tooltip" title="Grid">
                                                    <i class="fa fa-th-large"></i>
                                                </button>
                                            </div>
                                        </div>
                                        <div class="filter-right">
                                            <%--<div class="product-compare pull-right"><a href="index6431.html?route=product/compare" class="btn btn-default" id="compare-total">So sánh sản phẩm (0)</a></div>--%>
                                            <%--<div class="sort pull-right">
                                                <span for="input-sort">Sắp xếp theo:</span>
                                                <select id="input-sort" class="form-control" onchange="location = this.value;">
                                                    <option value="http://dothotuongphat.com/noi-that-phong-tho-tu-gia?sort=p.sort_order&amp;order=ASC" selected="selected">Mặc định</option>
                                                    <option value="noi-that-phong-tho-tu-gia3631.html?sort=pd.name&amp;order=ASC">Tên (A - Z)</option>
                                                    <option value="noi-that-phong-tho-tu-giaf933.html?sort=pd.name&amp;order=DESC">Tên (Z - A)</option>
                                                    <option value="noi-that-phong-tho-tu-giab721.html?sort=p.price&amp;order=ASC">Giá (Thấp &gt; Cao)</option>
                                                    <option value="noi-that-phong-tho-tu-gia44ca.html?sort=p.price&amp;order=DESC">Giá (Cao &gt; Thấp)</option>
                                                    <option value="noi-that-phong-tho-tu-giaf2b6.html?sort=rating&amp;order=DESC">Đánh giá (Cao nhất)</option>
                                                    <option value="noi-that-phong-tho-tu-gia23e8.html?sort=rating&amp;order=ASC">Đánh giá (Thấp nhất)</option>
                                                    <option value="noi-that-phong-tho-tu-gia950c.html?sort=p.model&amp;order=ASC">Kiểu (A - Z)</option>
                                                    <option value="noi-that-phong-tho-tu-gia942a.html?sort=p.model&amp;order=DESC">Kiểu (Z - A)</option>
                                                </select>
                                            </div>--%>

                                            <%--<div class="limit pull-right">
                                                <span for="input-limit">Hiển thị:</span>
                                                <select id="input-limit" class="form-control" onchange="location = this.value;">
                                                    <option value="http://dothotuongphat.com/noi-that-phong-tho-tu-gia?limit=15" selected="selected">15</option>
                                                    <option value="noi-that-phong-tho-tu-gia6195.html?limit=25">25</option>
                                                    <option value="noi-that-phong-tho-tu-gia3204.html?limit=50">50</option>
                                                    <option value="noi-that-phong-tho-tu-gia8538.html?limit=75">75</option>
                                                    <option value="noi-that-phong-tho-tu-giaa03f.html?limit=100">100</option>
                                                </select>
                                            </div>--%>
                                        </div>

                                    </div>
                                </div>


                                <div id="products" class="product-grid">
                                    <div class="products-block">
                                        <div class="row products-row">
                                            <%--đang bóc tách--%>
                                            <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col col-fullwidth">
                                                <div class="product-block item-default clearfix" itemtype="http://schema.org/Product" itemscope>
                                                    <div class="images clearfix">
                                                        <a class="img" itemprop="url" title="1234" href="Detail.aspx">
                                                            <img class="img-responsive" itemprop="image" src="images/Content_Product/Detail/dong_son_trang-200x200.jpg" title="123" alt="1234" />
                                                        </a>
                                                        <a class="pav-colorbox btn btn-inverse iframe-link" data-toggle="tooltip" href="#" title="Xem nhanh">
                                                            <i class="fa fa-eye"></i>
                                                        </a>
                                                        <a href="images/Content_Product/Detail/dong_son_trang-200x200.jpg" class="btn btn-inverse colorbox product-zoom cboxElement" title="123i">
                                                        <i class="fa fa-search-plus"></i>
                                                       </a>
                                                    </div>
                                                    <div class="product-meta">
                                                        <div class="product-meta-inner">
                                                            <div class="left">
                                                                <div class="review clearfix">
                                                                    <h3 class="name" itemprop="name"><a href="noi-that-phong-tho-tu-gia/an-gian.html">Án gian</a></h3>
                                                                </div>
                                                                <div class="price clearfix" itemtype="http://schema.org/Offer" itemscope itemprop="offers">
                                                                    <span class="special-price">12.900.000 VNĐ</span>
                                                                    <meta content="12.900" itemprop="price">
                                                                    <meta content="" itemprop="priceCurrency">
                                                                </div>
                                                                <div class="clearfix"></div>
                                                                <p class="description" itemprop="description">Nội dung đang được cập nhật.........</p>
                                                            </div>
                                                            <div class="right">
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>

                                            </div>
                                            <%--kết thúc bóc tách--%>
                                            <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col col-fullwidth">
                                                <div class="product-block item-default clearfix" itemtype="http://schema.org/Product" itemscope>


                                                    <div class="images clearfix">
                                                        <a class="img" itemprop="url" title="1234" href="Detail.aspx">
                                                            <img class="img-responsive" itemprop="image" src="images/Content_Product/Detail/dong_son_trang-200x200.jpg" title="123" alt="1234" />
                                                        </a>

                                                        <a class="pav-colorbox btn btn-inverse iframe-link" data-toggle="tooltip" href="#" title="Xem nhanh"><i class="fa fa-eye"></i></a>

                                                        <a href="images/Content_Product/Detail/dong_son_trang-200x200.jpg" class="btn btn-inverse colorbox product-zoom cboxElement" title="123i" class="fa fa-search-plus"></i></a>
                                                    </div>

                                                    <div class="product-meta">
                                                        <div class="product-meta-inner">
                                                            <div class="left">
                                                                <div class="review clearfix">
                                                                    <h3 class="name" itemprop="name"><a href="noi-that-phong-tho-tu-gia/an-gian.html">Án gian</a></h3>

                                                                    <div class="rating">
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                    </div>
                                                                </div>

                                                                <div class="price clearfix" itemtype="http://schema.org/Offer" itemscope itemprop="offers">
                                                                    <span class="special-price">12.900.000 VNĐ</span>
                                                                    <meta content="12.900" itemprop="price">

                                                                    <meta content="" itemprop="priceCurrency">
                                                                </div>

                                                                <div class="clearfix"></div>
                                                                <p class="description" itemprop="description">Nội dung đang được cập nhật.........</p>
                                                            </div>
                                                            <div class="right">
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>

                                            </div>
                                            <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col col-fullwidth">
                                                <div class="product-block item-default clearfix" itemtype="http://schema.org/Product" itemscope>


                                                    <div class="images clearfix">
                                                        <a class="img" itemprop="url" title="1234" href="Detail.aspx">
                                                            <img class="img-responsive" itemprop="image" src="images/Content_Product/Detail/dong_son_trang-200x200.jpg" title="123" alt="1234" />
                                                        </a>

                                                        <a class="pav-colorbox btn btn-inverse iframe-link" data-toggle="tooltip" href="#" title="Xem nhanh"><i class="fa fa-eye"></i></a>

                                                        <a href="images/Content_Product/Detail/dong_son_trang-200x200.jpg" class="btn btn-inverse colorbox product-zoom cboxElement" title="123i" class="fa fa-search-plus"></i></a>
                                                    </div>

                                                    <div class="product-meta">
                                                        <div class="product-meta-inner">
                                                            <div class="left">
                                                                <div class="review clearfix">
                                                                    <h3 class="name" itemprop="name"><a href="noi-that-phong-tho-tu-gia/an-gian.html">Án gian</a></h3>

                                                                    <div class="rating">
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                    </div>
                                                                </div>

                                                                <div class="price clearfix" itemtype="http://schema.org/Offer" itemscope itemprop="offers">
                                                                    <span class="special-price">12.900.000 VNĐ</span>
                                                                    <meta content="12.900" itemprop="price">

                                                                    <meta content="" itemprop="priceCurrency">
                                                                </div>

                                                                <div class="clearfix"></div>
                                                                <p class="description" itemprop="description">Nội dung đang được cập nhật.........</p>
                                                            </div>
                                                            <div class="right">
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>

                                            </div>
                                        </div>
                                        <div class="row products-row">
                                            <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col col-fullwidth">
                                                <div class="product-block item-default clearfix" itemtype="http://schema.org/Product" itemscope>


                                                    <div class="images clearfix">
                                                        <a class="img" itemprop="url" title="1234" href="Detail.aspx">
                                                            <img class="img-responsive" itemprop="image" src="images/Content_Product/Detail/dong_son_trang-200x200.jpg" title="123" alt="1234" />
                                                        </a>

                                                        <a class="pav-colorbox btn btn-inverse iframe-link" data-toggle="tooltip" href="#" title="Xem nhanh"><i class="fa fa-eye"></i></a>

                                                        <a href="images/Content_Product/Detail/dong_son_trang-200x200.jpg" class="btn btn-inverse colorbox product-zoom cboxElement" title="123i" class="fa fa-search-plus"></i></a>
                                                    </div>

                                                    <div class="product-meta">
                                                        <div class="product-meta-inner">
                                                            <div class="left">
                                                                <div class="review clearfix">
                                                                    <h3 class="name" itemprop="name"><a href="noi-that-phong-tho-tu-gia/an-gian.html">Án gian</a></h3>

                                                                    <div class="rating">
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                    </div>
                                                                </div>

                                                                <div class="price clearfix" itemtype="http://schema.org/Offer" itemscope itemprop="offers">
                                                                    <span class="special-price">12.900.000 VNĐ</span>
                                                                    <meta content="12.900" itemprop="price">

                                                                    <meta content="" itemprop="priceCurrency">
                                                                </div>

                                                                <div class="clearfix"></div>
                                                                <p class="description" itemprop="description">Nội dung đang được cập nhật.........</p>
                                                            </div>
                                                            <div class="right">
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>

                                            </div>
                                            <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col col-fullwidth">
                                                <div class="product-block item-default clearfix" itemtype="http://schema.org/Product" itemscope>


                                                    <div class="images clearfix">
                                                        <a class="img" itemprop="url" title="1234" href="Detail.aspx">
                                                            <img class="img-responsive" itemprop="image" src="images/Content_Product/Detail/dong_son_trang-200x200.jpg" title="123" alt="1234" />
                                                        </a>

                                                        <a class="pav-colorbox btn btn-inverse iframe-link" data-toggle="tooltip" href="#" title="Xem nhanh"><i class="fa fa-eye"></i></a>

                                                        <a href="images/Content_Product/Detail/dong_son_trang-200x200.jpg" class="btn btn-inverse colorbox product-zoom cboxElement" title="123i" class="fa fa-search-plus"></i></a>
                                                    </div>

                                                    <div class="product-meta">
                                                        <div class="product-meta-inner">
                                                            <div class="left">
                                                                <div class="review clearfix">
                                                                    <h3 class="name" itemprop="name"><a href="noi-that-phong-tho-tu-gia/an-gian.html">Án gian</a></h3>

                                                                    <div class="rating">
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                    </div>
                                                                </div>

                                                                <div class="price clearfix" itemtype="http://schema.org/Offer" itemscope itemprop="offers">
                                                                    <span class="special-price">12.900.000 VNĐ</span>
                                                                    <meta content="12.900" itemprop="price">

                                                                    <meta content="" itemprop="priceCurrency">
                                                                </div>

                                                                <div class="clearfix"></div>
                                                                <p class="description" itemprop="description">Nội dung đang được cập nhật.........</p>
                                                            </div>
                                                            <div class="right">
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>

                                            </div>
                                            <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col col-fullwidth">
                                                <div class="product-block item-default clearfix" itemtype="http://schema.org/Product" itemscope>


                                                    <div class="images clearfix">
                                                        <a class="img" itemprop="url" title="1234" href="Detail.aspx">
                                                            <img class="img-responsive" itemprop="image" src="images/Content_Product/Detail/dong_son_trang-200x200.jpg" title="123" alt="1234" />
                                                        </a>

                                                        <a class="pav-colorbox btn btn-inverse iframe-link" data-toggle="tooltip" href="#" title="Xem nhanh"><i class="fa fa-eye"></i></a>

                                                        <a href="images/Content_Product/Detail/dong_son_trang-200x200.jpg" class="btn btn-inverse colorbox product-zoom cboxElement" title="123i" class="fa fa-search-plus"></i></a>
                                                    </div>

                                                    <div class="product-meta">
                                                        <div class="product-meta-inner">
                                                            <div class="left">
                                                                <div class="review clearfix">
                                                                    <h3 class="name" itemprop="name"><a href="noi-that-phong-tho-tu-gia/an-gian.html">Án gian</a></h3>

                                                                    <div class="rating">
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                    </div>
                                                                </div>

                                                                <div class="price clearfix" itemtype="http://schema.org/Offer" itemscope itemprop="offers">
                                                                    <span class="special-price">12.900.000 VNĐ</span>
                                                                    <meta content="12.900" itemprop="price">

                                                                    <meta content="" itemprop="priceCurrency">
                                                                </div>

                                                                <div class="clearfix"></div>
                                                                <p class="description" itemprop="description">Nội dung đang được cập nhật.........</p>
                                                            </div>
                                                            <div class="right">
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>

                                            </div>
                                        </div>
                                        <div class="row products-row">
                                            <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col col-fullwidth">
                                                <div class="product-block item-default clearfix" itemtype="http://schema.org/Product" itemscope>


                                                    <div class="images clearfix">
                                                        <a class="img" itemprop="url" title="1234" href="Detail.aspx">
                                                            <img class="img-responsive" itemprop="image" src="images/Content_Product/Detail/dong_son_trang-200x200.jpg" title="123" alt="1234" />
                                                        </a>

                                                        <a class="pav-colorbox btn btn-inverse iframe-link" data-toggle="tooltip" href="#" title="Xem nhanh"><i class="fa fa-eye"></i></a>

                                                        <a href="images/Content_Product/Detail/dong_son_trang-200x200.jpg" class="btn btn-inverse colorbox product-zoom cboxElement" title="123i" class="fa fa-search-plus"></i></a>
                                                    </div>

                                                    <div class="product-meta">
                                                        <div class="product-meta-inner">
                                                            <div class="left">
                                                                <div class="review clearfix">
                                                                    <h3 class="name" itemprop="name"><a href="noi-that-phong-tho-tu-gia/an-gian.html">Án gian</a></h3>

                                                                    <div class="rating">
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                    </div>
                                                                </div>

                                                                <div class="price clearfix" itemtype="http://schema.org/Offer" itemscope itemprop="offers">
                                                                    <span class="special-price">12.900.000 VNĐ</span>
                                                                    <meta content="12.900" itemprop="price">

                                                                    <meta content="" itemprop="priceCurrency">
                                                                </div>

                                                                <div class="clearfix"></div>
                                                                <p class="description" itemprop="description">Nội dung đang được cập nhật.........</p>
                                                            </div>
                                                            <div class="right">
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>

                                            </div>
                                            <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col col-fullwidth">
                                                <div class="product-block item-default clearfix" itemtype="http://schema.org/Product" itemscope>


                                                    <div class="images clearfix">
                                                        <a class="img" itemprop="url" title="1234" href="Detail.aspx">
                                                            <img class="img-responsive" itemprop="image" src="images/Content_Product/Detail/dong_son_trang-200x200.jpg" title="123" alt="1234" />
                                                        </a>

                                                        <a class="pav-colorbox btn btn-inverse iframe-link" data-toggle="tooltip" href="#" title="Xem nhanh"><i class="fa fa-eye"></i></a>

                                                        <a href="images/Content_Product/Detail/dong_son_trang-200x200.jpg" class="btn btn-inverse colorbox product-zoom cboxElement" title="123i" class="fa fa-search-plus"></i></a>
                                                    </div>

                                                    <div class="product-meta">
                                                        <div class="product-meta-inner">
                                                            <div class="left">
                                                                <div class="review clearfix">
                                                                    <h3 class="name" itemprop="name"><a href="noi-that-phong-tho-tu-gia/an-gian.html">Án gian</a></h3>

                                                                    <div class="rating">
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                    </div>
                                                                </div>

                                                                <div class="price clearfix" itemtype="http://schema.org/Offer" itemscope itemprop="offers">
                                                                    <span class="special-price">12.900.000 VNĐ</span>
                                                                    <meta content="12.900" itemprop="price">

                                                                    <meta content="" itemprop="priceCurrency">
                                                                </div>

                                                                <div class="clearfix"></div>
                                                                <p class="description" itemprop="description">Nội dung đang được cập nhật.........</p>
                                                            </div>
                                                            <div class="right">
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>

                                            </div>
                                            <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col col-fullwidth">
                                                <div class="product-block item-default clearfix" itemtype="http://schema.org/Product" itemscope>


                                                    <div class="images clearfix">
                                                        <a class="img" itemprop="url" title="1234" href="Detail.aspx">
                                                            <img class="img-responsive" itemprop="image" src="images/Content_Product/Detail/dong_son_trang-200x200.jpg" title="123" alt="1234" />
                                                        </a>

                                                        <a class="pav-colorbox btn btn-inverse iframe-link" data-toggle="tooltip" href="#" title="Xem nhanh"><i class="fa fa-eye"></i></a>

                                                        <a href="images/Content_Product/Detail/dong_son_trang-200x200.jpg" class="btn btn-inverse colorbox product-zoom cboxElement" title="123i" class="fa fa-search-plus"></i></a>
                                                    </div>

                                                    <div class="product-meta">
                                                        <div class="product-meta-inner">
                                                            <div class="left">
                                                                <div class="review clearfix">
                                                                    <h3 class="name" itemprop="name"><a href="noi-that-phong-tho-tu-gia/an-gian.html">Án gian</a></h3>

                                                                    <div class="rating">
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                    </div>
                                                                </div>

                                                                <div class="price clearfix" itemtype="http://schema.org/Offer" itemscope itemprop="offers">
                                                                    <span class="special-price">12.900.000 VNĐ</span>
                                                                    <meta content="12.900" itemprop="price">

                                                                    <meta content="" itemprop="priceCurrency">
                                                                </div>

                                                                <div class="clearfix"></div>
                                                                <p class="description" itemprop="description">Nội dung đang được cập nhật.........</p>
                                                            </div>
                                                            <div class="right">
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>

                                            </div>
                                        </div>
                                        <div class="row products-row">
                                            <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col col-fullwidth">
                                                <div class="product-block item-default clearfix" itemtype="http://schema.org/Product" itemscope>


                                                    <div class="images clearfix">
                                                        <a class="img" itemprop="url" title="1234" href="Detail.aspx">
                                                            <img class="img-responsive" itemprop="image" src="images/Content_Product/Detail/dong_son_trang-200x200.jpg" title="123" alt="1234" />
                                                        </a>

                                                        <a class="pav-colorbox btn btn-inverse iframe-link" data-toggle="tooltip" href="#" title="Xem nhanh"><i class="fa fa-eye"></i></a>

                                                        <a href="images/Content_Product/Detail/dong_son_trang-200x200.jpg" class="btn btn-inverse colorbox product-zoom cboxElement" title="123i" class="fa fa-search-plus"></i></a>
                                                    </div>

                                                    <div class="product-meta">
                                                        <div class="product-meta-inner">
                                                            <div class="left">
                                                                <div class="review clearfix">
                                                                    <h3 class="name" itemprop="name"><a href="noi-that-phong-tho-tu-gia/an-gian.html">Án gian</a></h3>

                                                                    <div class="rating">
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                    </div>
                                                                </div>

                                                                <div class="price clearfix" itemtype="http://schema.org/Offer" itemscope itemprop="offers">
                                                                    <span class="special-price">12.900.000 VNĐ</span>
                                                                    <meta content="12.900" itemprop="price">

                                                                    <meta content="" itemprop="priceCurrency">
                                                                </div>

                                                                <div class="clearfix"></div>
                                                                <p class="description" itemprop="description">Nội dung đang được cập nhật.........</p>
                                                            </div>
                                                            <div class="right">
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>

                                            </div>
                                            <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col col-fullwidth">
                                                <div class="product-block item-default clearfix" itemtype="http://schema.org/Product" itemscope>


                                                    <div class="images clearfix">
                                                        <a class="img" itemprop="url" title="1234" href="Detail.aspx">
                                                            <img class="img-responsive" itemprop="image" src="images/Content_Product/Detail/dong_son_trang-200x200.jpg" title="123" alt="1234" />
                                                        </a>

                                                        <a class="pav-colorbox btn btn-inverse iframe-link" data-toggle="tooltip" href="#" title="Xem nhanh"><i class="fa fa-eye"></i></a>

                                                        <a href="images/Content_Product/Detail/dong_son_trang-200x200.jpg" class="btn btn-inverse colorbox product-zoom cboxElement" title="123i" class="fa fa-search-plus"></i></a>
                                                    </div>

                                                    <div class="product-meta">
                                                        <div class="product-meta-inner">
                                                            <div class="left">
                                                                <div class="review clearfix">
                                                                    <h3 class="name" itemprop="name"><a href="noi-that-phong-tho-tu-gia/an-gian.html">Án gian</a></h3>

                                                                    <div class="rating">
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                    </div>
                                                                </div>

                                                                <div class="price clearfix" itemtype="http://schema.org/Offer" itemscope itemprop="offers">
                                                                    <span class="special-price">12.900.000 VNĐ</span>
                                                                    <meta content="12.900" itemprop="price">

                                                                    <meta content="" itemprop="priceCurrency">
                                                                </div>

                                                                <div class="clearfix"></div>
                                                                <p class="description" itemprop="description">Nội dung đang được cập nhật.........</p>
                                                            </div>
                                                            <div class="right">
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>

                                            </div>
                                            <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col col-fullwidth">
                                                <div class="product-block item-default clearfix" itemtype="http://schema.org/Product" itemscope>


                                                    <div class="images clearfix">
                                                        <a class="img" itemprop="url" title="1234" href="Detail.aspx">
                                                            <img class="img-responsive" itemprop="image" src="images/Content_Product/Detail/dong_son_trang-200x200.jpg" title="123" alt="1234" />
                                                        </a>

                                                        <a class="pav-colorbox btn btn-inverse iframe-link" data-toggle="tooltip" href="#" title="Xem nhanh"><i class="fa fa-eye"></i></a>

                                                        <a href="images/Content_Product/Detail/dong_son_trang-200x200.jpg" class="btn btn-inverse colorbox product-zoom cboxElement" title="123i" class="fa fa-search-plus"></i></a>
                                                    </div>

                                                    <div class="product-meta">
                                                        <div class="product-meta-inner">
                                                            <div class="left">
                                                                <div class="review clearfix">
                                                                    <h3 class="name" itemprop="name"><a href="noi-that-phong-tho-tu-gia/an-gian.html">Án gian</a></h3>

                                                                    <div class="rating">
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                    </div>
                                                                </div>

                                                                <div class="price clearfix" itemtype="http://schema.org/Offer" itemscope itemprop="offers">
                                                                    <span class="special-price">12.900.000 VNĐ</span>
                                                                    <meta content="12.900" itemprop="price">

                                                                    <meta content="" itemprop="priceCurrency">
                                                                </div>

                                                                <div class="clearfix"></div>
                                                                <p class="description" itemprop="description">Nội dung đang được cập nhật.........</p>
                                                            </div>
                                                            <div class="right">
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>

                                            </div>
                                        </div>
                                        <div class="row products-row">
                                            <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col col-fullwidth">
                                                <div class="product-block item-default clearfix" itemtype="http://schema.org/Product" itemscope>


                                                    <div class="images clearfix">
                                                        <a class="img" itemprop="url" title="1234" href="Detail.aspx">
                                                            <img class="img-responsive" itemprop="image" src="images/Content_Product/Detail/dong_son_trang-200x200.jpg" title="123" alt="1234" />
                                                        </a>

                                                        <a class="pav-colorbox btn btn-inverse iframe-link" data-toggle="tooltip" href="#" title="Xem nhanh"><i class="fa fa-eye"></i></a>

                                                        <a href="images/Content_Product/Detail/dong_son_trang-200x200.jpg" class="btn btn-inverse colorbox product-zoom cboxElement" title="123i" class="fa fa-search-plus"></i></a>
                                                    </div>

                                                    <div class="product-meta">
                                                        <div class="product-meta-inner">
                                                            <div class="left">
                                                                <div class="review clearfix">
                                                                    <h3 class="name" itemprop="name"><a href="noi-that-phong-tho-tu-gia/an-gian.html">Án gian</a></h3>

                                                                    <div class="rating">
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                    </div>
                                                                </div>

                                                                <div class="price clearfix" itemtype="http://schema.org/Offer" itemscope itemprop="offers">
                                                                    <span class="special-price">12.900.000 VNĐ</span>
                                                                    <meta content="12.900" itemprop="price">

                                                                    <meta content="" itemprop="priceCurrency">
                                                                </div>

                                                                <div class="clearfix"></div>
                                                                <p class="description" itemprop="description">Nội dung đang được cập nhật.........</p>
                                                            </div>
                                                            <div class="right">
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>

                                            </div>
                                            <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col col-fullwidth">
                                                <div class="product-block item-default clearfix" itemtype="http://schema.org/Product" itemscope>


                                                    <div class="images clearfix">
                                                        <a class="img" itemprop="url" title="1234" href="Detail.aspx">
                                                            <img class="img-responsive" itemprop="image" src="images/Content_Product/Detail/dong_son_trang-200x200.jpg" title="123" alt="1234" />
                                                        </a>

                                                        <a class="pav-colorbox btn btn-inverse iframe-link" data-toggle="tooltip" href="#" title="Xem nhanh"><i class="fa fa-eye"></i></a>

                                                        <a href="images/Content_Product/Detail/dong_son_trang-200x200.jpg" class="btn btn-inverse colorbox product-zoom cboxElement" title="123i" class="fa fa-search-plus"></i></a>
                                                    </div>

                                                    <div class="product-meta">
                                                        <div class="product-meta-inner">
                                                            <div class="left">
                                                                <div class="review clearfix">
                                                                    <h3 class="name" itemprop="name"><a href="noi-that-phong-tho-tu-gia/an-gian.html">Án gian</a></h3>

                                                                    <div class="rating">
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                    </div>
                                                                </div>

                                                                <div class="price clearfix" itemtype="http://schema.org/Offer" itemscope itemprop="offers">
                                                                    <span class="special-price">12.900.000 VNĐ</span>
                                                                    <meta content="12.900" itemprop="price">

                                                                    <meta content="" itemprop="priceCurrency">
                                                                </div>

                                                                <div class="clearfix"></div>
                                                                <p class="description" itemprop="description">Nội dung đang được cập nhật.........</p>
                                                            </div>
                                                            <div class="right">
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>

                                            </div>
                                            <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col col-fullwidth">
                                                <div class="product-block item-default clearfix" itemtype="http://schema.org/Product" itemscope>


                                                    <div class="images clearfix">
                                                        <a class="img" itemprop="url" title="1234" href="Detail.aspx">
                                                            <img class="img-responsive" itemprop="image" src="images/Content_Product/Detail/dong_son_trang-200x200.jpg" title="123" alt="1234" />
                                                        </a>

                                                        <a class="pav-colorbox btn btn-inverse iframe-link" data-toggle="tooltip" href="#" title="Xem nhanh"><i class="fa fa-eye"></i></a>

                                                        <a href="images/Content_Product/Detail/dong_son_trang-200x200.jpg" class="btn btn-inverse colorbox product-zoom cboxElement" title="123i" class="fa fa-search-plus"></i></a>
                                                    </div>

                                                    <div class="product-meta">
                                                        <div class="product-meta-inner">
                                                            <div class="left">
                                                                <div class="review clearfix">
                                                                    <h3 class="name" itemprop="name"><a href="noi-that-phong-tho-tu-gia/an-gian.html">Án gian</a></h3>

                                                                    <div class="rating">
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                        <span class="fa fa-stack"><i class="fa fa-star-o fa-stack-2x"></i></span>
                                                                    </div>
                                                                </div>

                                                                <div class="price clearfix" itemtype="http://schema.org/Offer" itemscope itemprop="offers">
                                                                    <span class="special-price">12.900.000 VNĐ</span>
                                                                    <meta content="12.900" itemprop="price">

                                                                    <meta content="" itemprop="priceCurrency">
                                                                </div>

                                                                <div class="clearfix"></div>
                                                                <p class="description" itemprop="description">Nội dung đang được cập nhật.........</p>
                                                            </div>
                                                            <div class="right">
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>

                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="paginations paging clearfix">
                                    <ul class="pagination">
                                        <li class="active"><span>1</span></li>
                                        <li><a href="noi-that-phong-tho-tu-gia4658.html?page=2">2</a></li>
                                        <li><a href="noi-that-phong-tho-tu-gia9ba9.html?page=3">3</a></li>
                                        <li><a href="noi-that-phong-tho-tu-gia4658.html?page=2">&gt;</a></li>
                                        <li><a href="noi-that-phong-tho-tu-gia9ba9.html?page=3">&gt;|</a></li>
                                    </ul>
                                    <div class="results">Hiển thị từ 1 đến 15 của 34 (3 Trang)</div>
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
                                    <p>
                                        <img src="css/image/logo.png" alt="logo">
                                    </p>
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
                                    <div class="box pav-custom  ">
                                        <div class="box-heading">Mạnh Quang</div>
                                        <div class="box-content">
                                            <div class="address">
                                                <div class="box-addres">
                                                    <div class="link-address icon"><span class="fa fa-map-marker">&nbsp;</span><span> &nbsp;Hà Nội, VN</span></div>
                                                    <div class="link-mobile icon"><span class="fa fa-phone">&nbsp;</span><span>Phone: +84 0912456789</span></div>
                                                    <div class="link-mail icon"><span class="fa fa-envelope">&nbsp;</span>                                                        <span>Email:Califaxit@gmail.com</span></div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
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
                                            <div class="description">
                                                <p>
                                                    <br>
                                                </p>
                                            </div>
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
                                                                                                    latLng: [20.9963266, 105.8358646],
                                                                                                    options: {
                                                                                                        icon: "",
                                                                                                        //shadow: "icon-shadow.png",
                                                                                                    },
                                                                                                    data: '<div class="marker-holder"><div class="marker-content with-image"><img src="http://manhquang.com/image/page1/logo-header.png" alt=""><div class="map-item-info"><div class="title">' + "Mạnh Quang" + '</div><div class="address">' + "Đường Kim Giang, Thanh Liệt, Thanh Trì, Hà Nội " + '</div><div class="description">' + "Đường Kim Giang, Thanh Liệt, Thanh Trì, Hà Nội " + '</div><a href="' + "#" + '" class="more-button">' + "Xem thêm" + '</a></div><div class="arrow"></div><div class="close"></div></div></div></div>'
                                                                                                },
                                                                                                {
                                                                                                    latLng: [20.9963266, 105.8358646],
                                                                                                    options: {
                                                                                                        icon: "http://manhquang.com/image/page1/logo-header.png",
                                                                                                        //shadow: "icon-shadow.png",
                                                                                                    },
                                                                                                    data: '<div class="marker-holder"><div class="marker-content with-image"><img src="http://manhquang.com/image/page1/logo-header.png" alt=""><div class="map-item-info"><div class="title">' + "Mạnh Quang" + '</div><div class="address">' + "Đường Kim Giang, Thanh Liệt, Thanh Trì, Hà Nội " + '</div><div class="description">' + "Đường Kim Giang, Thanh Liệt, Thanh Trì, Hà Nội " + '</div><a href="' + "https://www.google.com/maps/place/C%C3%B4ng+Ty+Tnhh+Sx+Ph%E1%BB%A5+T%C3%B9ng+Xe+M%C3%A1y+M%E1%BA%A1nh+Quang/@20.9963266,105.8358646,14z/data=!4m5!1m2!2m1!1scong+ty+tnhh+manh+quang+kim+giang!3m1!1s0x3135acf1a3d19795:0xec8fe39130743001" + '" class="more-button">' + "Xem thêm" + '</a></div><div class="arrow"></div><div class="close"></div></div></div></div>'
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
                    <button type="button" class="btn btn-outline btn-close " data-toggle="offcanvas"><span class="fa fa-times"></span></button>
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
