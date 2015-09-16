<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="manhquang.com._default" %>

<!DOCTYPE html>
<html dir="ltr" class="ltr" lang="vi">
<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Mạnh Quang</title>
    <link href="images/favicon.ico" rel="icon" />  
    <script src="JS/FRAMEWORK/Include.JS.Base.js"></script>
    <script src="JS/FRAMEWORK/Include.JS.Extend.js"></script> 
    <script src="JS/FRAMEWORK/Include.JS.Framework.js"></script>
    
     <script type="text/javascript">
         // khởi tạo ngôn ngữ mặc định
         Init_System_WEB();

         window.onload = function () {
             Load_MenuTopVer("#verticalmenu");
             Load_MenuTopHoz("#bs-megamenu");
             loadsliderTop("#pavo-slideshow");
             LoadCateGoryLevel2("#ContentCategory");
             loadsliderBot("#sliderbot");

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
                                                <form method="GET" action="" class="input-group search-box">
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
                        <%--menu ngang--%>
                        <div class="collapse navbar-collapse" id="bs-megamenu">
                            
                        </div>
                        <%--end menungang--%>
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
                                                        <p>Đang cập nhập<br></p>                                            <!-- Button trigger modal -->
                                                        <a href="javascript:void(0);" class="pavreassurances arrow" data-toggle="modal" data-target="#myModal1"></a>
                                                        <div class="mask" style="display:none;">
                                                            <div class="title_detail"><div class="description"><p class="MsoNormal"></p><div><span style="font-weight: bold;">Đang cập nhập</span></div><div><br></div><p></p><p class="MsoNormal">Mọi thắc mắc xin liên hệ theo số điện thoại: <span style="font-weight: bold;"></span></p><p class="MsoNormal">Xin chân thành cảm ơn!</p></div></div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <!-- Modal -->
                                            <div class="modal fade" id="myModal1" tabindex="-1" role="dialog">
                                                <div class="modal-dialog">
                                                    <div class="modal-content">
                                                        <div class="modal-body">
                                                            <div class="title_detail"><div class="description"><p class="MsoNormal"></p><div><span style="font-weight: bold;">Đang cập nhập</span></div><div><br></div><ul></ul><p></p><p class="MsoNormal">Mọi thắc mắc xin liên hệ theo số điện thoại: <span style="font-weight: bold;">Đang cập nhập</span></p><p class="MsoNormal">Xin chân thành cảm ơn!</p></div></div>
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
                                                        <p>Đang cập nhập</p>                                            <!-- Button trigger modal -->
                                                        <a href="javascript:void(0);" class="pavreassurances arrow" data-toggle="modal" data-target="#myModal2"></a>
                                                        <div class="mask" style="display:none;">
                                                            <div class="title_detail">
                                                                <div class="icon-name fa fa-life-ring pull-left">&nbsp;</div><div class="description"><h4><b style="font-size: 12px; line-height: 17.142858505249px; text-indent: -24px;"><span style="font-family: 'Times New Roman', serif;"><span style="font-weight: normal; font-stretch: normal; font-size: 7pt; line-height: normal; font-family: 'Times New Roman';">&nbsp; &nbsp;&nbsp;</span></span></b><b style="font-size: 12px; line-height: 17.142858505249px; text-indent: -24px;"><span style="font-family: 'Times New Roman', serif;">Đang cập nhập</span></b></h4><h4><span style="font-family: 'Times New Roman', serif; line-height: 1.42857143; text-indent: -18pt; font-size: 12px;"></span><span style="font-family: 'Times New Roman', serif; line-height: 1.42857143; font-size: 12px;"></span></h4><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin"><o:p></o:p></span></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin"><o:p></o:p></span></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin"><o:p></o:p></span></p><p class="MsoNormal"><i style="line-height: 1.42857143;"><span style="font-size:11.0pt;line-height:115%;font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-fareast-font-family:&quot;Times New Roman&quot;;mso-fareast-theme-font:minor-fareast;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin;mso-ansi-language:VI;mso-fareast-language:VI;mso-bidi-language:AR-SA"><b></b></span></i></p></div></div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <!-- Modal -->
                                            <div class="modal fade" id="myModal2" tabindex="-1" role="dialog">
                                                <div class="modal-dialog">
                                                    <div class="modal-content">
                                                        <div class="modal-body">
                                                            <%--<div class="title_detail"><div class="icon-name fa fa-life-ring pull-left">&nbsp;</div><div class="description"><h4><b style="font-size: 12px; line-height: 17.142858505249px; text-indent: -24px;"><span style="font-family: 'Times New Roman', serif;"><span style="font-weight: normal; font-stretch: normal; font-size: 7pt; line-height: normal; font-family: 'Times New Roman';">&nbsp; &nbsp;&nbsp;</span></span></b><b style="font-size: 12px; line-height: 17.142858505249px; text-indent: -24px;"><span style="font-family: 'Times New Roman', serif;">HỖ TRỢ SAU BÁN HÀNG</span></b></h4><h4><span style="font-family: 'Times New Roman', serif; line-height: 1.42857143; text-indent: -18pt; font-size: 12px;">Vấn đề hỗ trợ sau bán hàng&nbsp;sẽ quyết định đến sự hài lòng và mong muốn quay lại của các bạn đối với Siêu thị đồ thờ tượng phật Sơn Đồng.&nbsp;</span><span style="font-family: 'Times New Roman', serif; line-height: 1.42857143; font-size: 12px;">Hiểu được điều này, chúng tôi luôn sẵn sàng hỗ trợ khách hàng các vấn đề khi sử dụng sản phẩm đồ thờ của chúng tôi mọi lúc, bất kể khi nào quý khách cần.</span></h4><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">Quý khách cần một phương vị tốt nhất trong nhà để bày trí, một thời điểm thích hợp theo phong thủy&nbsp;để “an vị”, các lưu ý, những điều cần tránh, cách bảo quản, cáo mẹo hữu ích…tất cả đều không thành vấn đề.<o:p></o:p></span></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">Đừng ngần ngại gọi đến các số hotline của chúng tôi nếu bạn cần tư vấn, chuyên gia của chúng tôi sẽ đáp ứng mọi thắc mắc của quý khách.<o:p></o:p></span></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">Gọi 24/24 vào hotline: 0906961286 (Mr.Cương) hoặc 01677900901 (Mr.Hoàng)<o:p></o:p></span></p><p class="MsoNormal"><i style="line-height: 1.42857143;"><span style="font-size:11.0pt;line-height:115%;font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-fareast-font-family:&quot;Times New Roman&quot;;mso-fareast-theme-font:minor-fareast;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin;mso-ansi-language:VI;mso-fareast-language:VI;mso-bidi-language:AR-SA">Siêu thị đồ thờ tượng phật Sơn Đồng luôn sẵn sàng để phục vụ quý khách<b>!</b></span></i></p></div></div>--%>
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
                                                        <p>Mua hàng &amp; Thanh toán (Đang cập nhập)</p>                                            <!-- Button trigger modal -->
                                                        <a href="javascript:void(0);" class="pavreassurances arrow" data-toggle="modal" data-target="#myModal3"></a>
                                                        <div class="mask" style="display:none;">
                                                            
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <!-- Modal -->
                                            <div class="modal fade" id="myModal3" tabindex="-1" role="dialog">
                                                <div class="modal-dialog">
                                                    <div class="modal-content">
                                                        <div class="modal-body">
                                                            <%--<div class="title_detail"><div class="icon-name fa fa-smile-o pull-left">&nbsp;</div><div class="description"><h4>Mua hàng &amp; Thanh toán</h4><h1 class="title" style="margin-bottom: 20px; padding: 0px; border: 0px; outline: 0px; font-size: 16px; vertical-align: baseline; font-family: Arial, Helvetica, Arial, sans-serif; color: rgb(51, 51, 51); position: relative; line-height: 15px; background: rgb(255, 255, 255);">Hướng Dẫn</h1><div class="entry" style="margin: 0px; padding: 0px; border: 0px; outline: 0px; vertical-align: baseline; color: rgb(0, 0, 0); font-family: Arial, Helvetica, sans-serif; line-height: 18px; background: rgb(255, 255, 255);"><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">1. Mua hàng trực tiếp và thanh toán bằng tiền mặt<o:p></o:p></span></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">Dùng cho hình thức mua hàng tại xưởng hoặc giao hàng tận nơi tạiHà Nội. Bạn thanh toán trực tiếp cho nhân viên giao hàng sau khi nhận hàng.<o:p></o:p></span></p><p class="MsoNormal"><i><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">Miễn phí giaohàng cho các đơn hàng trên 10 triệu!</span></i></p><p class="MsoNormal"><i><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin"><o:p><br></o:p></span></i></p><p class="MsoNormal"><span style="font-family: 'Times New Roman', serif;">2. Mua hàng từ xa và thanh toán bằng chuyển khoản qua Ngân Hàng (hoặc thẻ ATM)</span><br></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">Áp dụng đối với các khách hàng ở tỉnh xa hoặc việc đi lại, giao nhậnhàng thông thường gặp khó khăn<o:p></o:p></span></p><p class="MsoListParagraph" style="margin-left:25.1pt;mso-add-space:auto;text-indent:-18.0pt;mso-list:l0 level1 lfo1;tab-stops:list 25.1pt left 157.25pt"><!--[if !supportLists]--><span style="font-size:10.0pt;mso-bidi-font-size:11.0pt;line-height:115%;font-family:Wingdings;mso-fareast-font-family:Wingdings;mso-bidi-font-family:Wingdings">v<span style="font-stretch: normal; font-size: 7pt; line-height: normal; font-family: 'Times New Roman';">&nbsp; </span></span><!--[endif]--><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">Tại ngân hàngVietcombank (Ngân hàng Ngoại thương Việt Nam)<o:p></o:p></span></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">+ Tên chủ TK: Nguyễn Doãn Cương<o:p></o:p></span></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">+ Tài khoản số: 0011004240078<o:p></o:p></span></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">+ Ngân hàng Vietcombank, chi nhánh Hà Tây (Tp.Hà Nội)<o:p></o:p></span></p><p class="MsoListParagraph" style="margin-left:25.1pt;mso-add-space:auto;text-indent:-18.0pt;mso-list:l0 level1 lfo1;tab-stops:list 25.1pt"><!--[if !supportLists]--><span style="font-size:10.0pt;mso-bidi-font-size:11.0pt;line-height:115%;font-family:Wingdings;mso-fareast-font-family:Wingdings;mso-bidi-font-family:Wingdings">v<span style="font-stretch: normal; font-size: 7pt; line-height: normal; font-family: 'Times New Roman';">&nbsp; </span></span><!--[endif]--><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">Tại ngân hàngVietinbank (Ngân hàng Công Thương Việt Nam)<o:p></o:p></span></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">+ Tên chủ TK: Nguyễn Doãn Cương<o:p></o:p></span></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">+ Tài khoản số: 711AC0599593<o:p></o:p></span></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">+ Ngân hàng Vietinbank, Chi nhánh Tây Hà Nội (Tp.Hà Nội)<o:p></o:p></span></p><p class="MsoListParagraph" style="margin-left:25.1pt;mso-add-space:auto;text-indent:-18.0pt;mso-list:l0 level1 lfo1;tab-stops:list 25.1pt"><!--[if !supportLists]--><span style="font-size:10.0pt;mso-bidi-font-size:11.0pt;line-height:115%;font-family:Wingdings;mso-fareast-font-family:Wingdings;mso-bidi-font-family:Wingdings">v<span style="font-stretch: normal; font-size: 7pt; line-height: normal; font-family: 'Times New Roman';">&nbsp; </span></span><!--[endif]--><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">Tại ngân hàngTienPhongBank (Ngân hàng TMCP Tiên Phong)<o:p></o:p></span></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">+ Tên chủ TK: Nguyễn Doãn Cương<o:p></o:p></span></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">+ Tài khoản số: 00018766001<o:p></o:p></span></p><p class="MsoNormal"><span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-ascii-theme-font:major-latin;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin">+ Ngân hàng TienPhongBank, Chi nhánh Phạm Hùng (Tp.Hà Nội)</span></p><p class="MsoNormal"><i><span style="font-family: 'Times New Roman', serif;">Miễn phí giao hàng 40km đầu tiên cho các đơn hàng trên 10 triệu!</span></i></p></div></div></div>--%> Đang cập nhập
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
                                                        <h4>Đang cập nhập</h4>
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
                                                            <%--<div class="title_detail"><div class="icon-name fa fa-smile-o pull-left">&nbsp;</div><div class="description"><h4>TƯ VẤN HỖ TRỢ</h4><p>Khách hàng gọi theo số hotline&nbsp;090 696 1286 hoặc 01677900901.</p><p>Các chuyên gia tư vấn của Siêu thị đồ thờ tượng phật Sơn Đồng luôn sẵn sàng giải đắp mọi thắc mắc của quý khách hàng 24/24!</p><p><br></p><p style="background-image: initial; background-attachment: initial; background-size: initial; background-origin: initial; background-clip: initial; background-position: initial; background-repeat: initial;"><span style="font-weight: bold;">SIÊUTHỊ ĐỒ THỜ, TƯỢNG PHẬT SƠN ĐỒNG </span><o:p></o:p></p><p class="MsoNormal" style="margin-top:9.6pt;mso-para-margin-top:.8gd">Địa chỉ: Khu đô thị Tân Tây Đô- Quốc lộ 32- Đan Phượng – Hà Nội.<o:p></o:p></p><p class="MsoNormal" style="margin-top:9.6pt;mso-para-margin-top:.8gd">Email: tuvan@dothotuongphat.com<b><span style="font-family: 'Times New Roman', serif;"><o:p></o:p></span></b></p></div></div>--%>Đang cập nhập
                                                        </div>
                                                        <div class="modal-footer">
                                                            <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-lg-3 col-md-3 col-sm-3 col-xs-12 column">
                                               
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
                                        <div class="col-inner" id="ContentCategory">
                                            <!--Tab con-->                                          
                                        
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
                                                    <div class="carousel-inner" id="sliderbot">                                                                                                       
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
                                                 jQuery("#pavcarousel6").carousel({ interval: 3000 });
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
                                          <%--  <script type="text/javascript">
                                              $(document).ready(function () {
                                                    var id = 'newsletter_1158092619';
                                                    $('#' + id + ' .box-heading').bind('click', function () {
                                                        $('#' + id).toggleClass('active');
                                                    });

                                                    $('#formNewLestter').on('submit', function () {
                                                        var email = $('.inputNew').val();
                                                        $(".success_inline, .warning_inline, .error").remove();
                                                        if (!isValidEmailAddress(email)) {
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
                                                            success: function (json) {
                                                                $(".success_inline, .warning_inline, .error").remove();
                                                                if (json['error']) {
                                                                    $('.valid').html("<div class=\"warning_inline alert alert-danger\">" + json['error'] + "<button type=\"button\" class=\"close\" data-dismiss=\"alert\">×</button></div>");
                                                                }
                                                                if (json['success']) {
                                                                    $('.valid').html("<div class=\"success_inline alert alert-success\">" + json['success'] + "<button type=\"button\" class=\"close\" data-dismiss=\"alert\">×</button></div>");
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
                                                </script>--%>
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
                                    <p><img src="css/image/logo.png" alt="logo" ></p>
                                    <p><span></span></p>
                                </div>
                                <div class="col-md-3 col-sm-6">
                                    <h5 class="box-heading"><span>Danh mục</span></h5>
                                    <ul class="list-unstyled">
                                        <li><a href="">sản phẩm</a></li>
                                        <li><a href="">Giới thiệu</a></li>
                                        <li><a href="">Liên hệ</a></li>
                                    </ul>
                                </div>
                                <div class="col-md-3 col-sm-6">
                                    <h5 class="box-heading"><span>Chức năng khác</span></h5>
                                    <ul class="list-unstyled">
                                        <li><a href="">Thương hiệu</a></li>
                                        <li><a href="">Phiếu quà tặng</a></li>
                                       
                                    </ul>
                                </div>
                                <div class="col-md-3 col-sm-12">
                                    <div class="box pav-custom  ">
                                        <div class="box-heading">Công Ty TNHH Mạnh Quang</div><div class="box-content">
                                            <div class="address"><div class="box-addres">
                                            <div class="link-address icon"><span class="fa fa-map-marker">&nbsp;</span><span>Thanh liệt ,Thanh Trì ,Hà Nội</span></div>
                                            <div class="link-mobile icon"><span class="fa fa-phone">&nbsp;</span><span>Phone: +84.4 36883376</span></div>
                                            <div class="link-mail icon"><span class="fa fa-envelope"></span><span style="font-size:12px;">Email:manhquangmq@manhquang.com </span></div>                                                </div>                                            </div>                                        </div>                                    </div>
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
                                                                                                    latLng: [20.9963266,105.8358646],
                                                                                                    options: {
                                                                                                        icon: "",
                                                                                                        zoom:5
                                                                                                        //shadow: "icon-shadow.png",
                                                                                                    },
                                                                                                    //data: '<div class="marker-holder"><div class="marker-content with-image"><img src="" alt=""><div class="map-item-info"><div class="title">' + "" + '</div><div class="address">' + "" + '</div><div class="description">' + "" + '</div><a href="' + "#" + '" class="more-button">' + "Xem thêm" + '</a></div><div class="arrow"></div><div class="close"></div></div></div></div>'
                                                                                                },
                                                                                                {
                                                                                                    latLng: [20.9963266,105.8358646],
                                                                                                    options: {
                                                                                                        icon: "",
                                                                                                        //shadow: "icon-shadow.png",
                                                                                                    },
                                                                                                    //data: '<div class="marker-holder"><div class="marker-content with-image"><img src="" alt=""><div class="map-item-info"><div class="title">' + "Đồ thờ tượng phật" + '</div><div class="address">' + "Quốc lộ 32, Trạm Trôi, Hoài Đức, Hà Nội, Việt Nam" + '</div><div class="description">' + "Khu đô thị Tân Tây Đô,  Hà Nội, VN" + '</div><a href="' + "https://www.google.com/maps/place/C%C3%B4ng+Ty+Tnhh+Sx+Ph%E1%BB%A5+T%C3%B9ng+Xe+M%C3%A1y+M%E1%BA%A1nh+Quang/@20.9861495,105.8354354,14z/data=!4m5!1m2!2m1!1sm%E1%BA%A1nh+quang+kim+giang!3m1!1s0x3135acf1a3d19795:0xec8fe39130743001" + '" class="more-button">' + "Xem thêm" + '</a></div><div class="arrow"></div><div class="close"></div></div></div></div>'
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
                           <%-- <img src="image/data/paypal.png" alt="paypal">--%>
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


                //var $MAINCONTAINER = $("html");

                /**
                 * BACKGROUND-IMAGE SELECTION
                 */
                //$(".background-images").each(function () {
                //    var $parent = this;
                //    var $input = $(".input-setting", $parent);
                //    $(".bi-wrapper > div", this).click(function () {
                //        $input.val($(this).data('val'));
                //        $('.bi-wrapper > div', $parent).removeClass('active');
                //        $(this).addClass('active');

                //        if ($input.data('selector')) {
                //            $($input.data('selector'), $($MAINCONTAINER)).css($input.data('attrs'), 'url(' + $(this).data('image') + ')');
                //        }
                //    });
                //});

                //$(".clear-bg").click(function () {
                //    var $parent = $(this).parent();
                //    var $input = $(".input-setting", $parent);
                //    if ($input.val('')) {
                //        if ($parent.hasClass("background-images")) {
                //            $('.bi-wrapper > div', $parent).removeClass('active');
                //            $($input.data('selector'), $("#main-preview iframe").contents()).css($input.data('attrs'), 'none');
                //        } else {
                //            $input.attr('style', '')
                //        }
                //        $($input.data('selector'), $($MAINCONTAINER)).css($input.data('attrs'), 'inherit');

                //    }
                //    $input.val('');

                //    return false;
                //});



                //$('.accordion-group input.input-setting').each(function () {
                //    var input = this;
                //    $(input).attr('readonly', 'readonly');
                //    $(input).ColorPicker({
                //        onChange: function (hsb, hex, rgb) {
                //            $(input).css('backgroundColor', '#' + hex);
                //            $(input).val(hex);
                //            if ($(input).data('selector')) {
                //                $($MAINCONTAINER).find($(input).data('selector')).css($(input).data('attrs'), "#" + $(input).val())
                //            }
                //        }
                //    });
                //});
                //$('.accordion-group select.input-setting').change(function () {
                //    var input = this;
                //    if ($(input).data('selector')) {
                //        var ex = $(input).data('attrs') == 'font-size' ? 'px' : "";
                //        $($MAINCONTAINER).find($(input).data('selector')).css($(input).data('attrs'), $(input).val() + ex);
                //    }
                //});


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