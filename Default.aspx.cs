using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    Button b = null;
    Label l = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        b = new Button();
        b.Text = "show";
        l = new Label();
        b.Click += new EventHandler(lko);
        Panel1.Controls.Add(b);
        Panel1.Controls.Add(l);
    }
    protected void lko(object sender, EventArgs e)
    {
        l.Text = "hello world";
    }
}