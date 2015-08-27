using CORE;
using DataAccess;
using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace CMS
{
    public partial class Main : CORE.CORE_Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CORE_Language.Load_Language("CMS");
            this.CheckRedirectPage();
            
        }

    }
}