using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppPVT
{
    public partial class Chat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ChatSendbtn_Click(object sender, EventArgs e)
        {
            //string srt;
            //OutputText.InnerText = ChatBox.Text + Environment.NewLine;

            //Response.Write(ChatBox.Text + Environment.NewLine);
            ChatBox.Text = string.Empty;
        }
    }
}