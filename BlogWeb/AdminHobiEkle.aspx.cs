using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminHobiEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonHobiEkle_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLHOBILERTableAdapter dt =
                new DataSet1TableAdapters.TBLHOBILERTableAdapter();
            dt.HobiEkle(TextBoxHobi.Text);
            Response.Redirect("AdminHobiler.aspx");
        }
    }
}