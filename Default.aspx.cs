using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    public string compName;
    protected void Page_Load(object sender, EventArgs e)
    {
        this.compName = System.Environment.GetEnvironmentVariables()["COMPUTERNAME"].ToString();

    }
}