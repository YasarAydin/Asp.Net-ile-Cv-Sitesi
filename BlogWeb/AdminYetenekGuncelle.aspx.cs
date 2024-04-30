using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminYetenekGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);
            TextBoxID.Enabled = false;
            TextBoxID.Text = id.ToString();


            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TBLYETENEKLERTableAdapter dt =
                new DataSet1TableAdapters.TBLYETENEKLERTableAdapter();
                TextBoxYetenek.Text = dt.YetenekGetir(Convert.ToInt16(id))[0].YETENEK;
            }
        }

        protected void ButtonYetenekGuncelle_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLYETENEKLERTableAdapter dt =
                new DataSet1TableAdapters.TBLYETENEKLERTableAdapter();
            dt.YetenekGuncelle(TextBoxYetenek.Text, Convert.ToInt16(TextBoxID.Text));
            Response.Redirect("AdminYetenekler.aspx");
        }
    }
}