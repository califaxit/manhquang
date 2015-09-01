﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs"   Inherits="CMS.Main" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0" />
    <title>LOTUS</title>

    <%--================================================================================================================--%>
    <link href='http://fonts.googleapis.com/css?family=Roboto+Condensed:400,300,300italic,400italic,700,700italic&subset=latin,vietnamese' rel='stylesheet' type='text/css'>

    <script src="/JS/FRAMEWORK/Include.JS.Base.js" type="text/javascript"></script>
    <script src="/JS/FRAMEWORK/Include.JS.Framework.js" type="text/javascript"></script>
    <script src="/JS/FRAMEWORK/Include.JS.Library.js" type="text/javascript"></script>
    <script src="/JS/FRAMEWORK/Include.JS.Extend.js" type="text/javascript"></script>

        <script type="text/javascript">
            Init_System_CMS();
            jQuery(document).ready(function () {
                setTimeout("Module_CurrentUser('#divCurrentUser');", 1000);
                setTimeout("InitMenu('#divMenuLevel1', '#divMenuLevel2');", 1000);

            });
    </script>
    <script type="text/javascript">
      
    </script>

</head>

<body>
    <!-- =================Position show form===========================-->
    <div id="ImageListBox" style="width: 600px">
    </div>
    <div id="PositionShowDialog" style="width: 500px">
    </div>
    <div id="PositionLoading" style="" title="">
    </div>
    <div id="PositionConfigs">
        <input type="hidden" id="txtNUM_LANG" name="txtNUM_LANG" />

        <input type="hidden" id="txtCURRENT_USER" name="txtCURRENT_USER"/>

        <input type="hidden" id="txtCUR_LANG" name="txtCUR_LANG"/>

        <input type="hidden" id="txtDEF_LANG" name="txtDEF_LANG"/>

        <input type="hidden" id="txtLIST_IDLANG" name="txtLIST_IDLANG"/>

        <input type="hidden" id="txtDATA_LANG_STATIC" name="txtDATA_LANG_STATIC"/>
      
        <input type="hidden" id="txtDATA_LANG" name="txtDATA_LANG"/>

    </div>
    <!-- =================Position show form===========================-->

    <!-- Top line begins -->
    <div id="top">
        <div class="wrapper">
            <a href="index.html" title="" class="logo">
                <img src="/Images/logo.png" alt="" /></a>

            <!-- Right top nav -->
            <div class="topNav">
                <ul class="userNav">
                    <li><a title="" class="search"></a></li>
                    <li><a href="#" title="" class="screen"></a></li>
                    <li><a href="#" title="" class="settings"></a></li>
                    <li><a href="#" title="" class="logout"></a></li>
                    <li class="showTabletP"><a href="#" title="" class="sidebar"></a></li>
                </ul>
                <a title="" class="iButton"></a>
                <a title="" class="iTop"></a>
                <div class="topSearch">
                    <div class="topDropArrow"></div>
                    <form action="">
                        <input type="text" placeholder="search..." name="topSearch" />
                        <input type="submit" value="" />
                    </form>
                </div>
            </div>

            <!-- Responsive nav -->
            <ul class="altMenu">
                <li><a href="index.html" title="">Dashboard</a></li>
                <li><a title="" class="exp">UI elements1</a>
                    <ul>
                        <li><a href="ui.html">General elements</a></li>
                        <li><a href="ui_icons.html">Icons</a></li>
                        <li><a href="ui_buttons.html">Button sets</a></li>
                        <li><a href="ui_grid.html">Grid</a></li>
                        <li><a href="ui_custom.html">Custom elements</a></li>
                        <li><a href="ui_experimental.html">Experimental</a></li>
                    </ul>
                </li>
                <li><a href="forms.html" title="" class="exp">Forms stuff</a>
                    <ul>
                        <li><a href="forms.html">Inputs &amp; elements</a></li>
                        <li><a href="form_validation.html">Validation</a></li>
                        <li><a href="form_editor.html">File uploads &amp; editor</a></li>
                        <li><a href="form_wizards.html">Form wizards</a></li>
                    </ul>
                </li>
                <li><a href="messages.html" title="">Messages</a></li>
                <li><a href="statistics.html" title="">Statistics</a></li>
                <li><a href="tables.html" title="" class="exp" id="current">Tables</a>
                    <ul>
                        <li><a href="tables.html">Standard tables</a></li>
                        <li><a href="tables_dynamic.html" class="active">Dynamic tables</a></li>
                        <li><a href="tables_control.html">Tables with control</a></li>
                        <li><a href="tables_sortable.html">Sortable &amp; resizable</a></li>
                    </ul>
                </li>
                <li><a href="other_calendar.html" title="" class="exp">Other pages</a>
                    <ul>
                        <li><a href="other_calendar.html">Calendar</a></li>
                        <li><a href="other_gallery.html">Images gallery</a></li>
                        <li><a href="other_file_manager.html">File manager</a></li>
                        <li><a href="other_404.html">Sample error page</a></li>
                        <li><a href="other_typography.html">Typography</a></li>
                    </ul>
                </li>
            </ul>
            <div class="clear"></div>
        </div>
    </div>
    <!-- Top line ends -->


    <!-- Sidebar begins -->
    <div id="sidebar">
        <div class="mainNav">
            <div class="user" id="divCurrentUser">
            </div>

            <!-- Responsive nav -->
            <div class="altNav">
                <div class="userSearch">
                    <form action="">
                        <input type="text" placeholder="search..." name="userSearch" />
                        <input type="submit" value="" />
                    </form>
                </div>

                <!-- User nav -->
                <ul class="userNav">
                    <li><a href="#" title="" class="profile"></a></li>
                    <li><a href="#" title="" class="messages"></a></li>
                    <li><a href="#" title="" class="settings"></a></li>
                    <li><a href="#" title="" class="logout"></a></li>
                </ul>
            </div>

            <!-- Main nav -->
            <ul class="nav" id="divMenuLevel1">
            </ul>
        </div>

        <!-- Secondary nav -->
        <div class="secNav">
            <div class="secWrapper">
                <div class="secTop">
                    <div class="balance">
                        <div class="balInfo">1Balance:<span>Apr 21 2012</span></div>
                        <div class="balAmount">
                            <span class="balBars">
                                <!--5,10,15,20,18,16,14,20,15,16,12,10-->
                            </span><span>$58,990</span>
                        </div>
                    </div>
                    <a href="#" class="triangle-red"></a>
                </div>
                <div class="tab-container" id="divMenuLevel2"></div>
       
            </div>
            <div class="clear"></div>
        </div>
    </div>
    <!-- Sidebar ends -->


    <!-- Content begins -->
    <div id="content">
        <div class="contentTop">
            <span class="pageTitle"><span class="icon-loop_alt1"></span>Dynamic tables</span>
            <ul class="quickStats">
                <li>
                    <a href="" class="blueImg">
                        <img src="/Images/icons/quickstats/plus.png" alt="" /></a>
                    <div class="floatR"><strong class="blue">5489</strong><span>visits</span></div>
                </li>
                <li>
                    <a href="" class="redImg">
                        <img src="/Images/icons/quickstats/user.png" alt="" /></a>
                    <div class="floatR"><strong class="blue">4658</strong><span>users</span></div>
                </li>
                <li>
                    <a href="" class="greenImg">
                        <img src="/Images/icons/quickstats/money.png" alt="" /></a>
                    <div class="floatR"><strong class="blue">1289</strong><span>orders</span></div>
                </li>
            </ul>
            <div class="clear"></div>
        </div>

        <!-- Breadcrumbs line -->
        <div class="breadLine">
            <div class="bc">
                <ul id="breadcrumbs" class="breadcrumbs">
                    <li><a href="index.html">Dashboard1</a></li>
                    <li><a href="tables.html">Tables</a>
                        <ul>
                            <li><a href="tables.html" title="">Standard tables</a></li>
                            <li><a href="tables_control.html" title="">Tables with control</a></li>
                            <li><a href="tables_sortable.html" title="">Sortable and resizable</a></li>
                        </ul>
                    </li>
                    <li class="current"><a href="tables_dynamic.html" title="">Dynamic table</a></li>
                </ul>
            </div>

            <div class="breadLinks">
                <ul>
                    <li><a href="#" title=""><i class="icos-list"></i><span>Orders</span> <strong>(+58)</strong></a></li>
                    <li><a href="#" title=""><i class="icos-check"></i><span>Tasks</span> <strong>(+12)</strong></a></li>
                    <li class="has">
                        <a title="">
                            <i class="icos-money3"></i>
                            <span>Invoices</span>
                            <span>
                                <img src="/Images/elements/control/hasddArrow.png" alt="" /></span>
                        </a>
                        <ul>
                            <li><a href="#" title=""><span class="icos-add"></span>New invoice</a></li>
                            <li><a href="#" title=""><span class="icos-archive"></span>History</a></li>
                            <li><a href="#" title=""><span class="icos-printer"></span>Print invoices</a></li>
                        </ul>
                    </li>
                </ul>
                <div class="clear"></div>
            </div>
        </div>

        <!-- Main content -->
        <div class="wrapper">
            <form id="form1" runat="server">
                <div style="padding-top: 30px;" id="PageContent">
                </div>
                <div style="padding-top: 30px;" id="EditContent">
                </div>
                <div style="padding-top: 30px;" id="AddContent">
                </div>

            </form>
        </div>
        <!-- Main content ends -->

    </div>
    <!-- Content ends -->


</body>
</html>