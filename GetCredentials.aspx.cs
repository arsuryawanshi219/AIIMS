using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Web.Security;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Configuration;
using System.Collections.Specialized;
using System.Web.Configuration;
using System.IO;
using System.Xml;

public partial class GetCredentials : System.Web.UI.Page
{
    Class1 cls = new Class1();

    protected void Page_Load(object sender, EventArgs e)
    {
        divdetails.Visible = false;
    }

    protected void btnclick_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        ds = cls.GetDataSetWithQuery("GetId");


        divdetails.Visible = true;
        lblMock.Text = Convert.ToString(ds.Tables[0].Rows[0]["Mockid"]);
    }

    protected void btnexam_Click(object sender, EventArgs e)
    {
        Response.Redirect("http://mockserver.cbtexam.in/conductexam");
    }

}