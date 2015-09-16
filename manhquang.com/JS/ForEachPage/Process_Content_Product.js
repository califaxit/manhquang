//QuyDQ
//16-9-2015
//load content
function load_content(div,CodeCategory)
{
    var data_contents;

    if (typeof(CodeCategory) == "undefined")
{
    data_contents = ContentsBO.Sel_ByIDLang(1);
    
}
else
{
    data_contents = ContentsBO.Sel_Ext_ByCodeCategoryLevel1(CodeCategory, 1);
}
   
    var html = "";
    var k = 0;
    //data_contents.data.length
    																
    html += "<div class='products-block' id='products'> ";
    html += "<div class='row products-row'>";
    for (var i = 0; i <data_contents.data.length ; i++) {
    html+="	                                            <div class='col-lg-4 col-md-4 col-sm-4 col-xs-12 product-col col-fullwidth'>";
    html+="	                                                <div class='product-block item-default clearfix' itemtype='http://schema.org/Product' itemscope>";
    html+="	                                                    <div class='images clearfix'>";
    html+="	                                                        <a class='img' itemprop='url' title='1234' href='Detail.aspx'>";
    html+="	                                                            <img class='img-responsive' itemprop='image' src='"+sys_CommonType.URL_CMS + "/Action/ProcessImageServiceAction.ashx?W=200&H=200&Scale=crop&Img=" + data_contents.data[i].Contents_Image + "' title='" + data_contents.data[i].Contents_Title + "' title='123' alt='1234' />															";
    html+="	                                                        </a>															";
    html+="	                                                        <a class='pav-colorbox btn btn-inverse iframe-link' data-toggle='tooltip' href='#' title='Xem nhanh'><i class='fa fa-eye'></i></a>";
    html += "	                                                        <a href='" + sys_CommonType.URL_CMS + "/Action/ProcessImageServiceAction.ashx?W=200&H=200&Scale=crop&Img=" + data_contents.data[i].Contents_Image + "' title='" + data_contents.data[i].Contents_Title + "' class='btn btn-inverse colorbox product-zoom cboxElement' title='123i'class='fa fa-search-plus'></i></a>															";
    html+="	                                                    </div>";
    html+="	                                                    <div class='product-meta'>";
    html+="	                                                        <div class='product-meta-inner'>";
    html+="	                                                            <div class='left'>";
    html+="	                                                                <div class='review clearfix'>";
    html+="	                                                                    <h3 class='name' itemprop='name'><a href='noi-that-phong-tho-tu-gia/an-gian.html'>Án gian</a></h3>";
    html+="	                                                                </div>															";
    html+="	                                                                <div class='price clearfix' itemtype='http://schema.org/Offer' itemscope itemprop='offers'>";
    html+="	                                                                    <span class='special-price'>"+data_contents.data[i].Contents_ExtendProperties1+"vnđ</span>";
    html+="	                                                                    <meta content='12.900' itemprop='price'>";
    html+="	                                                                    <meta content='' itemprop='priceCurrency'>";
    html+="	                                                                </div>";
    html+="	                                                                <div class='clearfix'></div>";
    html+="	                                                                <p class='description' itemprop='description'>Nội dung đang được cập nhật.........</p>															";
    html+="	                                                            </div>";
    html+="	                                                            <div class='right'>";
    html+="	                                                            </div>";
    html+=" </div>";
    html+="</div>";
    html+="</div>";
    html+="</div>";


    if(i%3==2)
    {
        html += " </div>";
        html += "<div class='row products-row'>		";
    }
    }
    html+=" </div>";
    html+=" </div>";    
    jQuery(div).html(html);
    
   
   
   
}