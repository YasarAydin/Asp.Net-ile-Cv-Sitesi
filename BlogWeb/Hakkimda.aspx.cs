using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class Hakkimda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TBLHAKKIMDATableAdapter dt =
                new DataSet1TableAdapters.TBLHAKKIMDATableAdapter();
                TextBoxAd.Text = dt.HakkimdaListele()[0].AD;
                TextBoxSoyad.Text = dt.HakkimdaListele()[0].SOYAD;
                TextBoxAdres.Text = dt.HakkimdaListele()[0].ADRES;
                TextBoxMail.Text = dt.HakkimdaListele()[0].MAIL;
                TextBoxTelefon.Text = dt.HakkimdaListele()[0].TELEFON;
                TextBoxKısaNot.Text = dt.HakkimdaListele()[0].KISANOT;
                TextBoxFotograf.Text = dt.HakkimdaListele()[0].FOTOGRAF;
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLHAKKIMDATableAdapter dt =
                new DataSet1TableAdapters.TBLHAKKIMDATableAdapter();
            dt.HakkimdaGuncelle(TextBoxAd.Text, TextBoxSoyad.Text, TextBoxAdres.Text,
                TextBoxMail.Text, TextBoxTelefon.Text, TextBoxKısaNot.Text,
                TextBoxFotograf.Text);
            Response.Redirect("Default.aspx");
        }
    }
}