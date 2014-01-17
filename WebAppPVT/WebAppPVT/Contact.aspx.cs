using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebAppPVT
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Sendbtn_Click(object sender, EventArgs e)
        {
            File.AppendAllText(@"C:\Users\Pivgin\Source\Repos\PVT\WebAppPVT\WebAppPVT\posts.txt",
                DateTime.Now.ToUniversalTime() + Environment.NewLine 
                + EmailBox.Text + Environment.NewLine + MessageBox.Text 
                + Environment.NewLine + Environment.NewLine);
            MessageBox.Text = string.Empty;
            EmailBox.Text = string.Empty;
        }
    }
}