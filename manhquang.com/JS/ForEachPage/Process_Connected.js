//Load menu right
function LoadMenuLeft(div) {
    var html = "";

    html = html + "	<ul id='list1'>						";
    html = html + "{#foreach $T.data as aContents}";
    //Begin li
    html = html + "	                        <li class='link1'>						";
    html = html + "	                            <p><a href='Detail.aspx?Code={$T.aContents.Contents_Code}'>{$T.aContents.Contents_Title}</a></p>						";
    html = html + "	                            <span class='entypo-home'></span>						";
    html = html + "	                        </li>						";
    //end li
    html = html + "{#/for}";
    html = html + "	                    </ul>						";

    $(div).html(html);
    var data = ContentsBO.Sel_Ext_ByKeyCodeCategoryLevel1_ByIDLang("EN_CAT1_MENULEFT", 100, 140);
    $(div).setTemplate(html);
    $(div).processTemplate(data);
}
//Load footer1
function LoadBlockFooter1(div) {
    var html = "";

    html = html + "	<div class='block fl'>	";
    html = html + "	                    <h3>Giới thiệu</h3>	";
    html = html + "	                    <ul>	";
    html = html + "{#foreach $T.data as aContents}";
    html = html + "	                        <li id='menu-item-755' class='menu-item menu-item-type-post_type menu-item-object-page menu-item-755'><a href='Detail.aspx?Code={$T.aContents.Contents_Code}'>{$T.aContents.Contents_Title}</a></li>	";
    html = html + "{#/for}";
    html = html + "	                    </ul>	";
    html = html + "	                </div>	";

    $(div).html(html);


    var data = ContentsBO.Sel_Ext_ByKeyCodeCategoryLevel1_ByIDLang("EN_CAT1_BLOCKFOOTER1", 40, 140, 4, 'Contents_Code', true, sys_CUR_LANG);

    $(div).setTemplate(html);
    $(div).processTemplate(data);
}
//Load footer2
function LoadBlockFooter2(div) {
    var html = "";

    html = html + "	<div id='divBlockF2' class='block fl'>	";
    html = html + "	                    <h3>Khóa học Tiếng Anh</h3>	";
    html = html + "	                    <ul>	";
    html = html + "{#foreach $T.data as aContents}";
    html = html + "	                        <li id='menu-item-800' class='menu-item menu-item-type-post_type menu-item-object-page menu-item-800'><a href='Detail.aspx?Code={$T.aContents.Contents_Code}'>{$T.aContents.Contents_Title}</a></li>	";
    html = html + "{#/for}";
    html = html + "	                    </ul>	";
    html = html + "	                </div>	";

    $(div).html(html);
    var data = ContentsBO.Sel_Ext_ByKeyCodeCategoryLevel1_ByIDLang("EN_CAT1_BLOCKFOOTER2", 40, 140, 4, 'Contents_Code', true, sys_CUR_LANG);

    $(div).setTemplate(html);
    $(div).processTemplate(data);
}

//Load footer3
function LoadBlockFooter3(div) {
    var html = "";

    html = html + "	<div id='divBlockF3' class='block fl'>	";
    html = html + "	                    <h3>Góc EC</h3>	";
    html = html + "	                    <ul>	";
    html = html + "{#foreach $T.data as aContents}";
    html = html + "	                        <li id='menu-item-650' class='menu-item menu-item-type-post_type menu-item-object-page menu-item-650'><a href='Detail.aspx?Code={$T.aContents.Contents_Code}'>{$T.aContents.Contents_Title}</a></li>	";
    html = html + "{#/for}";
    html = html + "	                    </ul>	";
    html = html + "	                </div>	";

    $(div).html(html);

    var data = ContentsBO.Sel_Ext_ByKeyCodeCategoryLevel1_ByIDLang("EN_CAT1_BLOCKFOOTER3", 40, 140, 4, 'Contents_Code', true, sys_CUR_LANG);

    $(div).setTemplate(html);
    $(div).processTemplate(data);
}

//Load footer4
function LoadBlockFooter4(div) {
    var html = "";

    html = html + "	<div id='divBlockF4' class='block fl'>	";
    html = html + "	                    <h3>Kết nối EC</h3>	";
    html = html + "	                    <ul>	";
    html = html + "{#foreach $T.data as aContents}";
    html = html + "	                        <li id='menu-item-350' class='menu-item menu-item-type-post_type menu-item-object-page menu-item-350'><a href='Detail.aspx?Code={$T.aContents.Contents_Code}'>{$T.aContents.Contents_Title}</a></li>	";
    html = html + "{#/for}";
    html = html + "	                    </ul>	";
    html = html + "	                </div>	";

    $(div).html(html);

    var data = ContentsBO.Sel_Ext_ByKeyCodeCategoryLevel1_ByIDLang("EN_CAT1_BLOCKFOOTER4", 40, 140, 4, 'Contents_Code', true, sys_CUR_LANG);

    $(div).setTemplate(html);
    $(div).processTemplate(data);
}

//Load footer5
function LoadBlockFooter5(div) {
    var html = "";

    html = html + "	<div id='divBlockF5' class='block fl'>	";
    html = html + "	                    <h3>Tuyển dụng</h3>	";
    html = html + "	                    <ul>	";
    html = html + "{#foreach $T.data as aContents}";
    html = html + "	                        <li id='menu-item-940' class='menu-item menu-item-type-post_type menu-item-object-page menu-item-350'><a href='Detail.aspx?Code={$T.aContents.Contents_Code}'>{$T.aContents.Contents_Title}</a></li>	";
    html = html + "{#/for}";
    html = html + "	                    </ul>	";
    html = html + "	                </div>	";

    $(div).html(html);

    var data = ContentsBO.Sel_Ext_ByKeyCodeCategoryLevel1_ByIDLang("EN_CAT1_BLOCKFOOTER5", 40, 140, 4, 'Contents_Code', true, sys_CUR_LANG);

    $(div).setTemplate(html);
    $(div).processTemplate(data);
}

function SendMail(idForm) {

    SystemUsersBO.SendMail(idForm);
}
// load sản phẩm
//function LoadContent(div)
//{ 
//    var html = "";

//    html = html +"<div class='pav-inner'>"+  "<div class='row row-level-1 '>"+
//                "<div class='row-inner  clearfix'>"+
//                    "<div class='col-inner'>"+
//                        "<div class='pav-col col-lg-12 col-md-12 col-sm-12 col-xs-12  no-padding'>"+

//                            "<ul class='nav nav-pills box-heading' id='producttabs12546287958'>"+

//                               " <li class='active' style='padding:0px;'><a style='font-size:14px;' href='#tab-latest12546287958' data-toggle='tab'>SẢN PHẨM MỚI NHẤT</a></li>"+

//                            "</ul>"+
//                        "</div>"+
//                    "</div>";
//    html = html + "{#foreach $T.data as aContents}";
//    //Begin li
//    html = html + "<div class='pav-col col-lg-8 col-md-12 col-sm-12 col-xs-12  no-padding '>"+
//                        "<div class='col-inner'>"+
//                            "<div class='box producttabs box-center box-left' style='padding-left:9px;'>"+
//                                "<div class='module-desc hidden'>"+
//                                    "<p><br></p>"+
//                                "</div>"
//                                "<div class='tab-content box-content'>"+
//                                    "<div class='tab-pane box-products  tabcarousel4545454545 slide' id='tab-latest4545454545' style='display:block;'>"+

//                                        "<div class='carousel-controls'>"+
//                                            "<a class='carousel-control left' href='#tab-latest4545454545' data-slide='prev'>"+
//                                                "<i class='fa fa-angle-left'></i>"+
//                                            "</a>"+
//                                            "<a class='carousel-control right' href='#tab-latest4545454545' data-slide='next'>"+
//                                                "<i class='fa fa-angle-right'></i>"+
//                                            "</a>"+
//                                        "</div>"+
//                                        "<div class='carousel-inner products-block'>"+
//                                            "<div class='item active products-block'>"+
//                                                "<div class='row products-row last'>"+
//                                                    "<div class='col-lg-4 col-sm-4 col-xs-12  product-col'>"+
//                                                        "<div class='product-block item-default clearfix' itemtype='http://schema.org/Product' itemscope>"+
                                
//                                                            "<div class='images clearfix'>"+
//                                                                "<a class='img' itemprop='url' title='15428' href='#chitiet'>"+
//                                                                   " <img class='img-responsive' itemprop='image' src='../images/Content_Product/Intro/dong_son_trang.jpg' title='15428' alt='15428' />"+
//                                                               "</a>"+

//                                                               "<a class='pav-colorbox btn btn-inverse iframe-link' data-toggle='tooltip' href='#chitiet' title='Xem nhanh'><i class='fa fa-eye'></i></a>"+

//                                                                "<a href='../images/Content_Product/Intro/dong_son_trang.jpg' class='btn btn-inverse colorbox product-zoom cboxElement' title='15428'><i class='fa fa-search-plus'></i></a>"+
//                                                            "</div>"+

//                                                            "<div class='product-meta'>"+
//                                                                "<div class='product-meta-inner'>"+
//                                                                    "<div class='left'>"+
//                                                                        "<div class='review clearfix>"+
//                                                                            "<h3 class='name' itemprop='name'><a href=''>15428</a></h3>"+

//                                                                           "<div class='rating'>"+
//                                                                                "<span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>"+
//                                                                                "<span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>"+
//                                                                                "<span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>"+
//                                                                                "<span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>"+
//                                                                                "<span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>"+
//                                                                            "</div>"+
//                                                                        "</div>"+

//                                                                        "<div class='price clearfix' itemtype='http://schema.org/Offer' itemscope itemprop='offers'>"+
//                                                                           "<span class='special-price'>$125,00</span>"+
//                                                                           " <meta content='125,00' itemprop='price'>"+

//                                                                             " <meta content='' itemprop='priceCurrency'>"+
//                                                                        "</div>"+

//                                                                        "<div class='clearfix'></div>"+
//                                                                        "<p class='description' itemprop='description'>"+
//                                                                            "Nội dung đang được cập nhật...."+
//                                                                            "..."+
//                                                                        "</p>"+
//                                                                    "</div>"+
//                                                                    "<div class='right'>"+
//                                                                       " <div class='action'>"+
//                                                                           " <div class='cart'>"+
//                                                                                "<button data-loading-text='Loading...' class='btn btn-outline' type='button' onclick='cart.addcart('2174');'>"+
//                                                                                    "<i class='fa fa-shopping-cart'></i>"+
//                                                                                    "<span>Thêm vào giỏ</span>"+
//                                                                                "</button>"+
//                                                                            "</div>"+
//                                                                            "<div class='wishlist'>";
//                                                                                <a onclick='wishlist.addwishlist('2174');' title='Thêm Yêu thích' class='btn btn-outline-inverse' data-toggle='tooltip'>
//                                                                                    <i class='fa fa-heart'></i>
//                                                                                    <span>Thêm Yêu thích</span>
//                                                                                </a>
//                                                                            </div>
//                                                                            <div class='compare'>
//                                                                                <a class='btn btn-outline-inverse' onclick='compare.addcompare('2174');' title='Thêm so sánh' data-toggle='tooltip'>
//                                                                                    <i class='fa fa-refresh'></i>
//                                                                                    <span>Thêm so sánh</span>
//                                                                                </a>
//                                                                            </div>
//                                                                        </div>
//                                                                    </div>
//                                                                </div>
//                                                            </div>
//                                                        </div>
//                                                    </div>
//                                                    <div class='col-lg-4 col-sm-4 col-xs-12  product-col'>
//                                                        <div class='product-block item-default clearfix' itemtype='http://schema.org/Product' itemscope>


//                                                            <div class='images clearfix'>
//                                                                <a class='img' itemprop='url' title='15428' href='indexe33d.html?route=product/product&amp;product_id=2159'>
//                                                                    <img class='img-responsive' itemprop='image' src='../images/Content_Product/Intro/dong_son_trang.jpg' title='15428' alt='15428' />
//                                                                </a>

//                                                                <a class='pav-colorbox btn btn-inverse iframe-link' data-toggle='tooltip' href='index301b.html?route=themecontrol/product&amp;product_id=2159' title='Xem nhanh'><i class='fa fa-eye'></i></a>

//                                                                <a href='../images/Content_Product/Intro/dong_son_trang.jpg' class='btn btn-inverse colorbox product-zoom cboxElement' title='15428'><i class='fa fa-search-plus'></i></a>
//                                                            </div>

//                                                            <div class='product-meta'>
//                                                                <div class='product-meta-inner'>
//                                                                    <div class='left'>
//                                                                        <div class='review clearfix'>
//                                                                            <h3 class='name' itemprop='name'><a href='indexe33d.html?route=product/product&amp;product_id=2159'>15428</a></h3>

//                                                                            <div class='rating'>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                            </div>
//                                                                        </div>

//                                                                        <div class='price clearfix' itemtype='http://schema.org/Offer' itemscope itemprop='offers'>
//                                                                            <span class='special-price'>$125,00</span>
//                                                                            <meta content='125,00' itemprop='price'>

//                                                                            <meta content='' itemprop='priceCurrency'>
//                                                                        </div>

//                                                                        <div class='clearfix'></div>
//                                                                        <p class='description' itemprop='description'>
//                                                                            BÁT BỘ SƠN TRANG ( TÁM TƯỚNG SƠN TRANG)
//                                                                            Tục thờ Sơn Trang là một tục thờ tối cổ của người Việt, ra đời từ thời Âu Lạc. Trước khi tín ngưỡng Tứ Phủ ra đời thì đây là một tín ngưỡng riêng biệt, là một dòng thờ riêng và tác...
//                                                                        </p>
//                                                                    </div>
//                                                                    <div class='right'>
//                                                                        <div class='action'>
//                                                                            <div class='cart'>
//                                                                                <button data-loading-text='Loading...' class='btn btn-outline' type='button' onclick='cart.addcart('2159');'>
//                                                                                    <i class='fa fa-shopping-cart'></i>
//                                                                                    <span>Thêm vào giỏ</span>
//                                                                                </button>
//                                                                            </div>
//                                                                            <div class='wishlist'>
//                                                                                <a onclick='wishlist.addwishlist('2159');' title='Thêm Yêu thích' class='btn btn-outline-inverse' data-toggle='tooltip'>
//                                                                                    <i class='fa fa-heart'></i>
//                                                                                    <span>Thêm Yêu thích</span>
//                                                                                </a>
//                                                                            </div>
//                                                                            <div class='compare'>
//                                                                                <a class='btn btn-outline-inverse' onclick='compare.addcompare('2159');' title='Thêm so sánh' data-toggle='tooltip'>
//                                                                                    <i class='fa fa-refresh'></i>
//                                                                                    <span>Thêm so sánh</span>
//                                                                                </a>
//                                                                            </div>
//                                                                        </div>
//                                                                    </div>
//                                                                </div>
//                                                            </div>
//                                                        </div>
//                                                    </div>
//                                                    <div class='col-lg-4 col-sm-4 col-xs-12 last product-col'>
//                                                        <div class='product-block item-default clearfix' itemtype='http://schema.org/Product' itemscope>


//                                                            <div class='images clearfix'>
//                                                                <a class='img' itemprop='url' title='15428' href='index047a.html?route=product/product&amp;product_id=2158'>
//                                                                    <img class='img-responsive' itemprop='image' src='../images/Content_Product/Intro/dong_son_trang.jpg' title='15428' alt='15428' />
//                                                                </a>

//                                                                <a class='pav-colorbox btn btn-inverse iframe-link' data-toggle='tooltip' href='indexeaa9.html?route=themecontrol/product&amp;product_id=2158' title='Xem nhanh'><i class='fa fa-eye'></i></a>

//                                                                <a href='../images/Content_Product/Intro/dong_son_trang.jpg' class='btn btn-inverse colorbox product-zoom cboxElement' title='15428'><i class='fa fa-search-plus'></i></a>
//                                                            </div>

//                                                            <div class='product-meta'>
//                                                                <div class='product-meta-inner'>
//                                                                    <div class='left'>
//                                                                        <div class='review clearfix'>
//                                                                            <h3 class='name' itemprop='name'><a href='index047a.html?route=product/product&amp;product_id=2158'>15428</a></h3>

//                                                                            <div class='rating'>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                            </div>
//                                                                        </div>

//                                                                        <div class='price clearfix' itemtype='http://schema.org/Offer' itemscope itemprop='offers'>
//                                                                            <span class='special-price'>$125,00</span>
//                                                                            <meta content='125,00' itemprop='price'>

//                                                                            <meta content='' itemprop='priceCurrency'>
//                                                                        </div>

//                                                                        <div class='clearfix'></div>
//                                                                        <p class='description' itemprop='description'>Hạc l&agrave; lo&agrave;i đứng đầu trong họ l&ocirc;ng vũ, được gọi l&agrave; &quot;nhất phẩm điểu&quot;&nbsp;c&oacute; t&iacute;nh c&aacute;ch của một người qu&acirc;n tử, thanh cao. V&igrave; vậy hạc được đặt tr&ecirc;...</p>
//                                                                    </div>
//                                                                    <div class='right'>
//                                                                        <div class='action'>
//                                                                            <div class='cart'>
//                                                                                <button data-loading-text='Loading...' class='btn btn-outline' type='button' onclick='cart.addcart('2158');'>
//                                                                                    <i class='fa fa-shopping-cart'></i>
//                                                                                    <span>Thêm vào giỏ</span>
//                                                                                </button>
//                                                                            </div>
//                                                                            <div class='wishlist'>
//                                                                                <a onclick='wishlist.addwishlist('2158');' title='Thêm Yêu thích' class='btn btn-outline-inverse' data-toggle='tooltip'>
//                                                                                    <i class='fa fa-heart'></i>
//                                                                                    <span>Thêm Yêu thích</span>
//                                                                                </a>
//                                                                            </div>
//                                                                            <div class='compare'>
//                                                                                <a class='btn btn-outline-inverse' onclick='compare.addcompare('2158');' title='Thêm so sánh' data-toggle='tooltip'>
//                                                                                    <i class='fa fa-refresh'></i>
//                                                                                    <span>Thêm so sánh</span>
//                                                                                </a>
//                                                                            </div>
//                                                                        </div>
//                                                                    </div>
//                                                                </div>
//                                                            </div>
//                                                        </div>
//                                                    </div>
//                                                </div>
//                                            </div>
//                                            <div class='item  products-block'>
//                                                <div class='row products-row last'>
//                                                    <div class='col-lg-4 col-sm-4 col-xs-12  product-col'>
//                                                        <div class='product-block item-default clearfix' itemtype='http://schema.org/Product' itemscope>


//                                                            <div class='images clearfix'>
//                                                                <a class='img' itemprop='url' title='15428' href='index8266.html?route=product/product&amp;product_id=2174'>
//                                                                    <img class='img-responsive' itemprop='image' src='../images/Content_Product/Intro/dong_son_trang.jpg' title='15428' alt='15428' />
//                                                                </a>

//                                                                <a class='pav-colorbox btn btn-inverse iframe-link' data-toggle='tooltip' href='indexb494.html?route=themecontrol/product&amp;product_id=2174' title='Xem nhanh'><i class='fa fa-eye'></i></a>

//                                                                <a href='../images/Content_Product/Intro/dong_son_trang.jpg' class='btn btn-inverse colorbox product-zoom cboxElement' title='15428'><i class='fa fa-search-plus'></i></a>
//                                                            </div>

//                                                            <div class='product-meta'>
//                                                                <div class='product-meta-inner'>
//                                                                    <div class='left'>
//                                                                        <div class='review clearfix'>
//                                                                            <h3 class='name' itemprop='name'><a href='index8266.html?route=product/product&amp;product_id=2174'>15428</a></h3>

//                                                                            <div class='rating'>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                            </div>
//                                                                        </div>

//                                                                        <div class='price clearfix' itemtype='http://schema.org/Offer' itemscope itemprop='offers'>
//                                                                            <span class='special-price'>$125,00</span>
//                                                                            <meta content='125,00' itemprop='price'>

//                                                                            <meta content='' itemprop='priceCurrency'>
//                                                                        </div>

//                                                                        <div class='clearfix'></div>
//                                                                        <p class='description' itemprop='description'>
//                                                                            Nội dung đang được cập nhật....
//                                                                            ...
//                                                                        </p>
//                                                                    </div>
//                                                                    <div class='right'>
//                                                                        <div class='action'>
//                                                                            <div class='cart'>
//                                                                                <button data-loading-text='Loading...' class='btn btn-outline' type='button' onclick='cart.addcart('2174');'>
//                                                                                    <i class='fa fa-shopping-cart'></i>
//                                                                                    <span>Thêm vào giỏ</span>
//                                                                                </button>
//                                                                            </div>
//                                                                            <div class='wishlist'>
//                                                                                <a onclick='wishlist.addwishlist('2174');' title='Thêm Yêu thích' class='btn btn-outline-inverse' data-toggle='tooltip'>
//                                                                                    <i class='fa fa-heart'></i>
//                                                                                    <span>Thêm Yêu thích</span>
//                                                                                </a>
//                                                                            </div>
//                                                                            <div class='compare'>
//                                                                                <a class='btn btn-outline-inverse' onclick='compare.addcompare('2174');' title='Thêm so sánh' data-toggle='tooltip'>
//                                                                                    <i class='fa fa-refresh'></i>
//                                                                                    <span>Thêm so sánh</span>
//                                                                                </a>
//                                                                            </div>
//                                                                        </div>
//                                                                    </div>
//                                                                </div>
//                                                            </div>
//                                                        </div>
//                                                    </div>
//                                                    <div class='col-lg-4 col-sm-4 col-xs-12  product-col'>
//                                                        <div class='product-block item-default clearfix' itemtype='http://schema.org/Product' itemscope>


//                                                            <div class='images clearfix'>
//                                                                <a class='img' itemprop='url' title='15428' href='indexe33d.html?route=product/product&amp;product_id=2159'>
//                                                                    <img class='img-responsive' itemprop='image' src='../images/Content_Product/Intro/dong_son_trang.jpg' title='15428' alt='15428' />
//                                                                </a>

//                                                                <a class='pav-colorbox btn btn-inverse iframe-link' data-toggle='tooltip' href='index301b.html?route=themecontrol/product&amp;product_id=2159' title='Xem nhanh'><i class='fa fa-eye'></i></a>

//                                                                <a href='../images/Content_Product/Intro/dong_son_trang.jpg' class='btn btn-inverse colorbox product-zoom cboxElement' title='15428'><i class='fa fa-search-plus'></i></a>
//                                                            </div>

//                                                            <div class='product-meta'>
//                                                                <div class='product-meta-inner'>
//                                                                    <div class='left'>
//                                                                        <div class='review clearfix'>
//                                                                            <h3 class='name' itemprop='name'><a href='indexe33d.html?route=product/product&amp;product_id=2159'>15428</a></h3>

//                                                                            <div class='rating'>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                            </div>
//                                                                        </div>

//                                                                        <div class='price clearfix' itemtype='http://schema.org/Offer' itemscope itemprop='offers'>
//                                                                            <span class='special-price'>$125,00</span>
//                                                                            <meta content='125,00' itemprop='price'>

//                                                                            <meta content='' itemprop='priceCurrency'>
//                                                                        </div>

//                                                                        <div class='clearfix'></div>
//                                                                        <p class='description' itemprop='description'>
//                                                                            BÁT BỘ SƠN TRANG ( TÁM TƯỚNG SƠN TRANG)
//                                                                            Tục thờ Sơn Trang là một tục thờ tối cổ của người Việt, ra đời từ thời Âu Lạc. Trước khi tín ngưỡng Tứ Phủ ra đời thì đây là một tín ngưỡng riêng biệt, là một dòng thờ riêng và tác...
//                                                                        </p>
//                                                                    </div>
//                                                                    <div class='right'>
//                                                                        <div class='action'>
//                                                                            <div class='cart'>
//                                                                                <button data-loading-text='Loading...' class='btn btn-outline' type='button' onclick='cart.addcart('2159');'>
//                                                                                    <i class='fa fa-shopping-cart'></i>
//                                                                                    <span>Thêm vào giỏ</span>
//                                                                                </button>
//                                                                            </div>
//                                                                            <div class='wishlist'>
//                                                                                <a onclick='wishlist.addwishlist('2159');' title='Thêm Yêu thích' class='btn btn-outline-inverse' data-toggle='tooltip'>
//                                                                                    <i class='fa fa-heart'></i>
//                                                                                    <span>Thêm Yêu thích</span>
//                                                                                </a>
//                                                                            </div>
//                                                                            <div class='compare'>
//                                                                                <a class='btn btn-outline-inverse' onclick='compare.addcompare('2159');' title='Thêm so sánh' data-toggle='tooltip'>
//                                                                                    <i class='fa fa-refresh'></i>
//                                                                                    <span>Thêm so sánh</span>
//                                                                                </a>
//                                                                            </div>
//                                                                        </div>
//                                                                    </div>
//                                                                </div>
//                                                            </div>
//                                                        </div>
//                                                    </div>
//                                                    <div class='col-lg-4 col-sm-4 col-xs-12 last product-col'>
//                                                        <div class='product-block item-default clearfix' itemtype='http://schema.org/Product' itemscope>


//                                                            <div class='images clearfix'>
//                                                                <a class='img' itemprop='url' title='15428' href='index047a.html?route=product/product&amp;product_id=2158'>
//                                                                    <img class='img-responsive' itemprop='image' src='../images/Content_Product/Intro/dong_son_trang.jpg' title='15428' alt='15428' />
//                                                                </a>

//                                                                <a class='pav-colorbox btn btn-inverse iframe-link' data-toggle='tooltip' href='indexeaa9.html?route=themecontrol/product&amp;product_id=2158' title='Xem nhanh'><i class='fa fa-eye'></i></a>

//                                                                <a href='../images/Content_Product/Intro/dong_son_trang.jpg' class='btn btn-inverse colorbox product-zoom cboxElement' title='15428'><i class='fa fa-search-plus'></i></a>
//                                                            </div>

//                                                            <div class='product-meta'>
//                                                                <div class='product-meta-inner'>
//                                                                    <div class='left'>
//                                                                        <div class='review clearfix'>
//                                                                            <h3 class='name' itemprop='name'><a href='index047a.html?route=product/product&amp;product_id=2158'>15428</a></h3>

//                                                                            <div class='rating'>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                            </div>
//                                                                        </div>

//                                                                        <div class='price clearfix' itemtype='http://schema.org/Offer' itemscope itemprop='offers'>
//                                                                            <span class='special-price'>$125,00</span>
//                                                                            <meta content='125,00' itemprop='price'>

//                                                                            <meta content='' itemprop='priceCurrency'>
//                                                                        </div>

//                                                                        <div class='clearfix'></div>
//                                                                        <p class='description' itemprop='description'>Hạc l&agrave; lo&agrave;i đứng đầu trong họ l&ocirc;ng vũ, được gọi l&agrave; &quot;nhất phẩm điểu&quot;&nbsp;c&oacute; t&iacute;nh c&aacute;ch của một người qu&acirc;n tử, thanh cao. V&igrave; vậy hạc được đặt tr&ecirc;...</p>
//                                                                    </div>
//                                                                    <div class='right'>
//                                                                        <div class='action'>
//                                                                            <div class='cart'>
//                                                                                <button data-loading-text='Loading...' class='btn btn-outline' type='button' onclick='cart.addcart('2158');'>
//                                                                                    <i class='fa fa-shopping-cart'></i>
//                                                                                    <span>Thêm vào giỏ</span>
//                                                                                </button>
//                                                                            </div>
//                                                                            <div class='wishlist'>
//                                                                                <a onclick='wishlist.addwishlist('2158');' title='Thêm Yêu thích' class='btn btn-outline-inverse' data-toggle='tooltip'>
//                                                                                    <i class='fa fa-heart'></i>
//                                                                                    <span>Thêm Yêu thích</span>
//                                                                                </a>
//                                                                            </div>
//                                                                            <div class='compare'>
//                                                                                <a class='btn btn-outline-inverse' onclick='compare.addcompare('2158');' title='Thêm so sánh' data-toggle='tooltip'>
//                                                                                    <i class='fa fa-refresh'></i>
//                                                                                    <span>Thêm so sánh</span>
//                                                                                </a>
//                                                                            </div>
//                                                                        </div>
//                                                                    </div>
//                                                                </div>
//                                                            </div>
//                                                        </div>
//                                                    </div>
//                                                </div>
//                                            </div>
//                                            <div class='item  products-block'>
//                                                <div class='row products-row last'>
//                                                    <div class='col-lg-4 col-sm-4 col-xs-12  product-col'>
//                                                        <div class='product-block item-default clearfix' itemtype='http://schema.org/Product' itemscope>


//                                                            <div class='images clearfix'>
//                                                                <a class='img' itemprop='url' title='15428' href='index8266.html?route=product/product&amp;product_id=2174'>
//                                                                    <img class='img-responsive' itemprop='image' src='../images/Content_Product/Intro/dong_son_trang.jpg' title='15428' alt='15428' />
//                                                                </a>

//                                                                <a class='pav-colorbox btn btn-inverse iframe-link' data-toggle='tooltip' href='indexb494.html?route=themecontrol/product&amp;product_id=2174' title='Xem nhanh'><i class='fa fa-eye'></i></a>

//                                                                <a href='../images/Content_Product/Intro/dong_son_trang.jpg' class='btn btn-inverse colorbox product-zoom cboxElement' title='15428'><i class='fa fa-search-plus'></i></a>
//                                                            </div>

//                                                            <div class='product-meta'>
//                                                                <div class='product-meta-inner'>
//                                                                    <div class='left'>
//                                                                        <div class='review clearfix'>
//                                                                            <h3 class='name' itemprop='name'><a href='index8266.html?route=product/product&amp;product_id=2174'>15428</a></h3>

//                                                                            <div class='rating'>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                            </div>
//                                                                        </div>

//                                                                        <div class='price clearfix' itemtype='http://schema.org/Offer' itemscope itemprop='offers'>
//                                                                            <span class='special-price'>$125,00</span>
//                                                                            <meta content='125,00' itemprop='price'>

//                                                                            <meta content='' itemprop='priceCurrency'>
//                                                                        </div>

//                                                                        <div class='clearfix'></div>
//                                                                        <p class='description' itemprop='description'>
//                                                                            Nội dung đang được cập nhật....
//                                                                            ...
//                                                                        </p>
//                                                                    </div>
//                                                                    <div class='right'>
//                                                                        <div class='action'>
//                                                                            <div class='cart'>
//                                                                                <button data-loading-text='Loading...' class='btn btn-outline' type='button' onclick='cart.addcart('2174');'>
//                                                                                    <i class='fa fa-shopping-cart'></i>
//                                                                                    <span>Thêm vào giỏ</span>
//                                                                                </button>
//                                                                            </div>
//                                                                            <div class='wishlist'>
//                                                                                <a onclick='wishlist.addwishlist('2174');' title='Thêm Yêu thích' class='btn btn-outline-inverse' data-toggle='tooltip'>
//                                                                                    <i class='fa fa-heart'></i>
//                                                                                    <span>Thêm Yêu thích</span>
//                                                                                </a>
//                                                                            </div>
//                                                                            <div class='compare'>
//                                                                                <a class='btn btn-outline-inverse' onclick='compare.addcompare('2174');' title='Thêm so sánh' data-toggle='tooltip'>
//                                                                                    <i class='fa fa-refresh'></i>
//                                                                                    <span>Thêm so sánh</span>
//                                                                                </a>
//                                                                            </div>
//                                                                        </div>
//                                                                    </div>
//                                                                </div>
//                                                            </div>
//                                                        </div>
//                                                    </div>
//                                                    <div class='col-lg-4 col-sm-4 col-xs-12  product-col'>
//                                                        <div class='product-block item-default clearfix' itemtype='http://schema.org/Product' itemscope>


//                                                            <div class='images clearfix'>
//                                                                <a class='img' itemprop='url' title='15428' href='indexe33d.html?route=product/product&amp;product_id=2159'>
//                                                                    <img class='img-responsive' itemprop='image' src='../images/Content_Product/Intro/dong_son_trang.jpg' title='15428' alt='15428' />
//                                                                </a>

//                                                                <a class='pav-colorbox btn btn-inverse iframe-link' data-toggle='tooltip' href='index301b.html?route=themecontrol/product&amp;product_id=2159' title='Xem nhanh'><i class='fa fa-eye'></i></a>

//                                                                <a href='../images/Content_Product/Intro/dong_son_trang.jpg' class='btn btn-inverse colorbox product-zoom cboxElement' title='15428'><i class='fa fa-search-plus'></i></a>
//                                                            </div>

//                                                            <div class='product-meta'>
//                                                                <div class='product-meta-inner'>
//                                                                    <div class='left'>
//                                                                        <div class='review clearfix'>
//                                                                            <h3 class='name' itemprop='name'><a href='indexe33d.html?route=product/product&amp;product_id=2159'>15428</a></h3>

//                                                                            <div class='rating'>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                            </div>
//                                                                        </div>

//                                                                        <div class='price clearfix' itemtype='http://schema.org/Offer' itemscope itemprop='offers'>
//                                                                            <span class='special-price'>$125,00</span>
//                                                                            <meta content='125,00' itemprop='price'>

//                                                                            <meta content='' itemprop='priceCurrency'>
//                                                                        </div>

//                                                                        <div class='clearfix'></div>
//                                                                        <p class='description' itemprop='description'>
//                                                                            BÁT BỘ SƠN TRANG ( TÁM TƯỚNG SƠN TRANG)
//                                                                            Tục thờ Sơn Trang là một tục thờ tối cổ của người Việt, ra đời từ thời Âu Lạc. Trước khi tín ngưỡng Tứ Phủ ra đời thì đây là một tín ngưỡng riêng biệt, là một dòng thờ riêng và tác...
//                                                                        </p>
//                                                                    </div>
//                                                                    <div class='right'>
//                                                                        <div class='action'>
//                                                                            <div class='cart'>
//                                                                                <button data-loading-text='Loading...' class='btn btn-outline' type='button' onclick='cart.addcart('2159');'>
//                                                                                    <i class='fa fa-shopping-cart'></i>
//                                                                                    <span>Thêm vào giỏ</span>
//                                                                                </button>
//                                                                            </div>
//                                                                            <div class='wishlist'>
//                                                                                <a onclick='wishlist.addwishlist('2159');' title='Thêm Yêu thích' class='btn btn-outline-inverse' data-toggle='tooltip'>
//                                                                                    <i class='fa fa-heart'></i>
//                                                                                    <span>Thêm Yêu thích</span>
//                                                                                </a>
//                                                                            </div>
//                                                                            <div class='compare'>
//                                                                                <a class='btn btn-outline-inverse' onclick='compare.addcompare('2159');' title='Thêm so sánh' data-toggle='tooltip'>
//                                                                                    <i class='fa fa-refresh'></i>
//                                                                                    <span>Thêm so sánh</span>
//                                                                                </a>
//                                                                            </div>
//                                                                        </div>
//                                                                    </div>
//                                                                </div>
//                                                            </div>
//                                                        </div>
//                                                    </div>
//                                                    <div class='col-lg-4 col-sm-4 col-xs-12 last product-col'>
//                                                        <div class='product-block item-default clearfix' itemtype='http://schema.org/Product' itemscope>


//                                                            <div class='images clearfix'>
//                                                                <a class='img' itemprop='url' title='15428' href='index047a.html?route=product/product&amp;product_id=2158'>
//                                                                    <img class='img-responsive' itemprop='image' src='../images/Content_Product/Intro/dong_son_trang.jpg' title='15428' alt='15428' />
//                                                                </a>

//                                                                <a class='pav-colorbox btn btn-inverse iframe-link' data-toggle='tooltip' href='indexeaa9.html?route=themecontrol/product&amp;product_id=2158' title='Xem nhanh'><i class='fa fa-eye'></i></a>

//                                                                <a href='../images/Content_Product/Intro/dong_son_trang.jpg' class='btn btn-inverse colorbox product-zoom cboxElement' title='15428'><i class='fa fa-search-plus'></i></a>
//                                                            </div>

//                                                            <div class='product-meta'>
//                                                                <div class='product-meta-inner'>
//                                                                    <div class='left'>
//                                                                        <div class='review clearfix'>
//                                                                            <h3 class='name' itemprop='name'><a href='index047a.html?route=product/product&amp;product_id=2158'>15428</a></h3>

//                                                                            <div class='rating'>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                            </div>
//                                                                        </div>

//                                                                        <div class='price clearfix' itemtype='http://schema.org/Offer' itemscope itemprop='offers'>
//                                                                            <span class='special-price'>$125,00</span>
//                                                                            <meta content='125,00' itemprop='price'>

//                                                                            <meta content='' itemprop='priceCurrency'>
//                                                                        </div>

//                                                                        <div class='clearfix'></div>
//                                                                        <p class='description' itemprop='description'>Hạc l&agrave; lo&agrave;i đứng đầu trong họ l&ocirc;ng vũ, được gọi l&agrave; &quot;nhất phẩm điểu&quot;&nbsp;c&oacute; t&iacute;nh c&aacute;ch của một người qu&acirc;n tử, thanh cao. V&igrave; vậy hạc được đặt tr&ecirc;...</p>
//                                                                    </div>
//                                                                    <div class='right'>
//                                                                        <div class='action'>
//                                                                            <div class='cart'>
//                                                                                <button data-loading-text='Loading...' class='btn btn-outline' type='button' onclick='cart.addcart('2158');'>
//                                                                                    <i class='fa fa-shopping-cart'></i>
//                                                                                    <span>Thêm vào giỏ</span>
//                                                                                </button>
//                                                                            </div>
//                                                                            <div class='wishlist'>
//                                                                                <a onclick='wishlist.addwishlist('2158');' title='Thêm Yêu thích' class='btn btn-outline-inverse' data-toggle='tooltip'>
//                                                                                    <i class='fa fa-heart'></i>
//                                                                                    <span>Thêm Yêu thích</span>
//                                                                                </a>
//                                                                            </div>
//                                                                            <div class='compare'>
//                                                                                <a class='btn btn-outline-inverse' onclick='compare.addcompare('2158');' title='Thêm so sánh' data-toggle='tooltip'>
//                                                                                    <i class='fa fa-refresh'></i>
//                                                                                    <span>Thêm so sánh</span>
//                                                                                </a>
//                                                                            </div>
//                                                                        </div>
//                                                                    </div>
//                                                                </div>
//                                                            </div>
//                                                        </div>
//                                                    </div>
//                                                </div>
//                                            </div>
//                                            <div class='item  products-block'>
//                                                <div class='row products-row last'>
//                                                    <div class='col-lg-4 col-sm-4 col-xs-12  product-col'>
//                                                        <div class='product-block item-default clearfix' itemtype='http://schema.org/Product' itemscope>


//                                                            <div class='images clearfix'>
//                                                                <a class='img' itemprop='url' title='15428' href='index8266.html?route=product/product&amp;product_id=2174'>
//                                                                    <img class='img-responsive' itemprop='image' src='../images/Content_Product/Intro/dong_son_trang.jpg' title='15428' alt='15428' />
//                                                                </a>

//                                                                <a class='pav-colorbox btn btn-inverse iframe-link' data-toggle='tooltip' href='indexb494.html?route=themecontrol/product&amp;product_id=2174' title='Xem nhanh'><i class='fa fa-eye'></i></a>

//                                                                <a href='../images/Content_Product/Intro/dong_son_trang.jpg' class='btn btn-inverse colorbox product-zoom cboxElement' title='15428'><i class='fa fa-search-plus'></i></a>
//                                                            </div>

//                                                            <div class='product-meta'>
//                                                                <div class='product-meta-inner'>
//                                                                    <div class='left'>
//                                                                        <div class='review clearfix'>
//                                                                            <h3 class='name' itemprop='name'><a href='index8266.html?route=product/product&amp;product_id=2174'>15428</a></h3>

//                                                                            <div class='rating'>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                            </div>
//                                                                        </div>

//                                                                        <div class='price clearfix' itemtype='http://schema.org/Offer' itemscope itemprop='offers'>
//                                                                            <span class='special-price'>$125,00</span>
//                                                                            <meta content='125,00' itemprop='price'>

//                                                                            <meta content='' itemprop='priceCurrency'>
//                                                                        </div>

//                                                                        <div class='clearfix'></div>
//                                                                        <p class='description' itemprop='description'>
//                                                                            Nội dung đang được cập nhật....
//                                                                            ...
//                                                                        </p>
//                                                                    </div>
//                                                                    <div class='right'>
//                                                                        <div class='action'>
//                                                                            <div class='cart'>
//                                                                                <button data-loading-text='Loading...' class='btn btn-outline' type='button' onclick='cart.addcart('2174');'>
//                                                                                    <i class='fa fa-shopping-cart'></i>
//                                                                                    <span>Thêm vào giỏ</span>
//                                                                                </button>
//                                                                            </div>
//                                                                            <div class='wishlist'>
//                                                                                <a onclick='wishlist.addwishlist('2174');' title='Thêm Yêu thích' class='btn btn-outline-inverse' data-toggle='tooltip'>
//                                                                                    <i class='fa fa-heart'></i>
//                                                                                    <span>Thêm Yêu thích</span>
//                                                                                </a>
//                                                                            </div>
//                                                                            <div class='compare'>
//                                                                                <a class='btn btn-outline-inverse' onclick='compare.addcompare('2174');' title='Thêm so sánh' data-toggle='tooltip'>
//                                                                                    <i class='fa fa-refresh'></i>
//                                                                                    <span>Thêm so sánh</span>
//                                                                                </a>
//                                                                            </div>
//                                                                        </div>
//                                                                    </div>
//                                                                </div>
//                                                            </div>
//                                                        </div>
//                                                    </div>
//                                                    <div class='col-lg-4 col-sm-4 col-xs-12  product-col'>
//                                                        <div class='product-block item-default clearfix' itemtype='http://schema.org/Product' itemscope>


//                                                            <div class='images clearfix'>
//                                                                <a class='img' itemprop='url' title='15428' href='indexe33d.html?route=product/product&amp;product_id=2159'>
//                                                                    <img class='img-responsive' itemprop='image' src='../images/Content_Product/Intro/dong_son_trang.jpg' title='15428' alt='15428' />
//                                                                </a>

//                                                                <a class='pav-colorbox btn btn-inverse iframe-link' data-toggle='tooltip' href='index301b.html?route=themecontrol/product&amp;product_id=2159' title='Xem nhanh'><i class='fa fa-eye'></i></a>

//                                                                <a href='../images/Content_Product/Intro/dong_son_trang.jpg' class='btn btn-inverse colorbox product-zoom cboxElement' title='15428'><i class='fa fa-search-plus'></i></a>
//                                                            </div>

//                                                            <div class='product-meta'>
//                                                                <div class='product-meta-inner'>
//                                                                    <div class='left'>
//                                                                        <div class='review clearfix'>
//                                                                            <h3 class='name' itemprop='name'><a href='indexe33d.html?route=product/product&amp;product_id=2159'>15428</a></h3>

//                                                                            <div class='rating'>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                            </div>
//                                                                        </div>

//                                                                        <div class='price clearfix' itemtype='http://schema.org/Offer' itemscope itemprop='offers'>
//                                                                            <span class='special-price'>$125,00</span>
//                                                                            <meta content='125,00' itemprop='price'>

//                                                                            <meta content='' itemprop='priceCurrency'>
//                                                                        </div>

//                                                                        <div class='clearfix'></div>
//                                                                        <p class='description' itemprop='description'>
//                                                                            BÁT BỘ SƠN TRANG ( TÁM TƯỚNG SƠN TRANG)
//                                                                            Tục thờ Sơn Trang là một tục thờ tối cổ của người Việt, ra đời từ thời Âu Lạc. Trước khi tín ngưỡng Tứ Phủ ra đời thì đây là một tín ngưỡng riêng biệt, là một dòng thờ riêng và tác...
//                                                                        </p>
//                                                                    </div>
//                                                                    <div class='right'>
//                                                                        <div class='action'>
//                                                                            <div class='cart'>
//                                                                                <button data-loading-text='Loading...' class='btn btn-outline' type='button' onclick='cart.addcart('2159');'>
//                                                                                    <i class='fa fa-shopping-cart'></i>
//                                                                                    <span>Thêm vào giỏ</span>
//                                                                                </button>
//                                                                            </div>
//                                                                            <div class='wishlist'>
//                                                                                <a onclick='wishlist.addwishlist('2159');' title='Thêm Yêu thích' class='btn btn-outline-inverse' data-toggle='tooltip'>
//                                                                                    <i class='fa fa-heart'></i>
//                                                                                    <span>Thêm Yêu thích</span>
//                                                                                </a>
//                                                                            </div>
//                                                                            <div class='compare'>
//                                                                                <a class='btn btn-outline-inverse' onclick='compare.addcompare('2159');' title='Thêm so sánh' data-toggle='tooltip'>
//                                                                                    <i class='fa fa-refresh'></i>
//                                                                                    <span>Thêm so sánh</span>
//                                                                                </a>
//                                                                            </div>
//                                                                        </div>
//                                                                    </div>
//                                                                </div>
//                                                            </div>
//                                                        </div>
//                                                    </div>
//                                                    <div class='col-lg-4 col-sm-4 col-xs-12 last product-col'>
//                                                        <div class='product-block item-default clearfix' itemtype='http://schema.org/Product' itemscope>


//                                                            <div class='images clearfix'>
//                                                                <a class='img' itemprop='url' title='15428' href='index047a.html?route=product/product&amp;product_id=2158'>
//                                                                    <img class='img-responsive' itemprop='image' src='../images/Content_Product/Intro/dong_son_trang.jpg' title='15428' alt='15428' />
//                                                                </a>

//                                                                <a class='pav-colorbox btn btn-inverse iframe-link' data-toggle='tooltip' href='indexeaa9.html?route=themecontrol/product&amp;product_id=2158' title='Xem nhanh'><i class='fa fa-eye'></i></a>

//                                                                <a href='../images/Content_Product/Intro/dong_son_trang.jpg' class='btn btn-inverse colorbox product-zoom cboxElement' title='15428'><i class='fa fa-search-plus'></i></a>
//                                                            </div>

//                                                            <div class='product-meta'>
//                                                                <div class='product-meta-inner'>
//                                                                    <div class='left'>
//                                                                        <div class='review clearfix'>
//                                                                            <h3 class='name' itemprop='name'><a href='index047a.html?route=product/product&amp;product_id=2158'>15428</a></h3>

//                                                                            <div class='rating'>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                                <span class='fa fa-stack'><i class='fa fa-star-o fa-stack-2x'></i></span>
//                                                                            </div>
//                                                                        </div>

//                                                                        <div class='price clearfix' itemtype='http://schema.org/Offer' itemscope itemprop='offers'>
//                                                                            <span class='special-price'>$125,00</span>
//                                                                            <meta content='125,00' itemprop='price'>

//                                                                            <meta content='' itemprop='priceCurrency'>
//                                                                        </div>

//                                                                        <div class='clearfix'></div>
//                                                                        <p class='description' itemprop='description'>Hạc l&agrave; lo&agrave;i đứng đầu trong họ l&ocirc;ng vũ, được gọi l&agrave; &quot;nhất phẩm điểu&quot;&nbsp;c&oacute; t&iacute;nh c&aacute;ch của một người qu&acirc;n tử, thanh cao. V&igrave; vậy hạc được đặt tr&ecirc;...</p>
//                                                                    </div>
//                                                                    <div class='right'>
//                                                                        <div class='action'>
//                                                                            <div class='cart'>
//                                                                                <button data-loading-text='Loading...' class='btn btn-outline' type='button' onclick='cart.addcart('2158');'>
//                                                                                    <i class='fa fa-shopping-cart'></i>
//                                                                                    <span>Thêm vào giỏ</span>
//                                                                                </button>
//                                                                            </div>
//                                                                            <div class='wishlist'>
//                                                                                <a onclick='wishlist.addwishlist('2158');' title='Thêm Yêu thích' class='btn btn-outline-inverse' data-toggle='tooltip'>
//                                                                                    <i class='fa fa-heart'></i>
//                                                                                    <span>Thêm Yêu thích</span>
//                                                                                </a>
//                                                                            </div>
//                                                                            <div class='compare'>
//                                                                                <a class='btn btn-outline-inverse' onclick='compare.addcompare('2158');' title='Thêm so sánh' data-toggle='tooltip'>
//                                                                                   " <i class='fa fa-refresh'></i>
//                                                                                    "<span>Thêm so sánh</span>"+
//                                                                                "</a>"+
//                                                                            </div>
//                                                                        </div>
//                                                                    </div>
//                                                                </div>
//                                                            </div>
//                                                        </div>
//                                                    "</div>"+
//                                                "</div>"+
//                                            "</div>"+   

//                                      "  </div>"+

//                                    "</div>"+
//                               " </div>"+
//                            "</div>"+

//                            "<script>"+
//                                "$(function () {
//                                    "$('#producttabs4545454545 a:first').tab('show');"
//                                "})"+
//    "$('.tabcarousel4545454545').carousel({interval:false,auto:false,pause:'hover'});"+
//    "</script>"+
//"</div>"+
//"</div>";
                          
//    //end li
//    html = html + "{#/for}";
//    html = html + "						";

//    $(div).html(html);
//    var data = ContentsBO.Sel_Ext_ByKeyCodeCategoryLevel1_ByIDLang("EN_CAT1_MENULEFT", 100, 140);
//    $(div).setTemplate(html);
//    $(div).processTemplate(data);
//};
function sys_LoadPage(filename, data) {


    if (filename.toLowerCase().indexOf("lst") >= 0) {
        $("#PageContent").load('../../Templates/' + filename, function () {
            // $("#PageContent").processTemplate();
        });
    }
    else if (filename.toLowerCase().indexOf("ins") >= 0) {
        $("#PageContent").setTemplateURL('../../Templates/' + filename);
        $("#PageContent").processTemplate();
    }
    else if (filename.toLowerCase().indexOf("upd") >= 0) {
        $("#PageContent").setTemplateURL('../../Templates/' + filename);
        $("#PageContent").processTemplate(data);
    }
    else {
        alert("Bạn đặt tên file không đúng nguyên tắc");
    }
    //var html = $("#PageContent").html();

    //$("#PageContent").setTemplateURL('../../Templates/' + filename);
    //$("#PageContent").setParam('NumLang', sys_NUMLANG);
    //$("#PageContent").setParam('Lang', sys_CUR_LANG);
    //$("#PageContent").processTemplate();

    //$("#PageContent").setTemplateURL('../../Templates/' + filename);
    //$("#PageContent").setParam('NumLang', sys_NUMLANG); //sys_NumLang : trong file SystemConfig.js
    //$("#PageContent").setParam('Lang', sys_CUR_LANG);
    //$("#PageContent").processTemplate();

    //$("#PageContent").setTemplateURL('../../Templates/' + filename);
    //$("#PageContent").processTemplate();
}