using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MusicBox
{
    public partial class MainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SearchBox.Focus();
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void Searchbtn_Click(object sender, EventArgs e)
        {
            //if (Page.IsValid)
            //{
            //    Validationlbl.Text = string.Empty;
            //    Validationlbl.ForeColor = System.Drawing.Color.ForestGreen;
            //    Validationlbl.Text = "OK";
            //}
            //else
            //{
            //    Validationlbl.Text = string.Empty;
            //    Validationlbl.ForeColor = System.Drawing.Color.Red;
            //    Validationlbl.Text = "Data is invalid";
            //}
        }
    }
}