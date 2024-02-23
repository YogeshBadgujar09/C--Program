using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnOp_Click(object sender, EventArgs e)
    {
        int a;
        int b;
        int c;

        a = Convert.ToInt16(txtNo1.Text);
        b = Convert.ToInt16(txtNo2.Text);

        c = a + b;
        txtAdd.Text = Convert.ToString(c);

        c = a - b;
        txtSub.Text = Convert.ToString(c);

        c = a * b;
        txtMul.Text = Convert.ToString(c);

        c = a / b;
        txtDiv.Text = Convert.ToString(c);
    }
}

