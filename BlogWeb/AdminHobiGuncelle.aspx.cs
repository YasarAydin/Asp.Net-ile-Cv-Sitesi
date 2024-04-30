using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminHobiGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);
            TextBoxID.Enabled = false;
            TextBoxID.Text = id.ToString();


            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TBLHOBILERTableAdapter dt =
                new DataSet1TableAdapters.TBLHOBILERTableAdapter();
                TextBoxHobi.Text = dt.HobiGetir(Convert.ToInt16(id))[0].HOBI;
            }
        }

        protected void ButtonHobiGuncelle_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLHOBILERTableAdapter dt =
                new DataSet1TableAdapters.TBLHOBILERTableAdapter();
            dt.HobiGuncelle(TextBoxHobi.Text, Convert.ToInt16(TextBoxID.Text));
            Response.Redirect("AdminHobiler.aspx");
        }
    }
}