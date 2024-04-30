using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminEgitimEkle : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonEgitimEkle_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLEGITIMTableAdapter dt =
                new DataSet1TableAdapters.TBLEGITIMTableAdapter();
            dt.EgitimEkle(TextBoxBaslik.Text, TextBoxAltBaslik.Text, TextBoxAciklama.Text, TextBoxGnot.Text, TextBoxTarih.Text);
            Response.Redirect("AdminEgitimler.aspx");            
        }

    }
}