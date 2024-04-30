using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminDeneyimEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ButtonDeneyimEkle_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLDENEYIMTableAdapter dt =
                new DataSet1TableAdapters.TBLDENEYIMTableAdapter();
            dt.DeneyimEkle(TextBoxBaslik.Text, TextBoxAltBaslik.Text, TextBoxAciklama.Text, TextBoxTarih.Text);
            Response.Redirect("AdminDeneyimler.aspx");
        }
    }
}