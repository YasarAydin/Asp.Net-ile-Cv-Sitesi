using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminEgitimGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);
            TextBoxID.Enabled = false;
            TextBoxID.Text = id.ToString();


            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TBLEGITIMTableAdapter dt =
                new DataSet1TableAdapters.TBLEGITIMTableAdapter();
                TextBoxBaslik.Text = dt.EgitimGetir(Convert.ToInt16(id))[0].BASLIK;
                TextBoxAltBaslik.Text = dt.EgitimGetir(Convert.ToInt16(id))[0].ALTBASLIK;
                TextBoxAciklama.Text = dt.EgitimGetir(Convert.ToInt16(id))[0].ACIKLAMA;
                TextBoxGnot.Text = dt.EgitimGetir(Convert.ToInt16(id))[0].GNOT;
                TextBoxTarih.Text = dt.EgitimGetir(Convert.ToInt16(id))[0].TARIH;
            }
        }

        protected void ButtonEgitimGuncelle_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLEGITIMTableAdapter dt =
                new DataSet1TableAdapters.TBLEGITIMTableAdapter();
            dt.EgitimGuncelle(TextBoxBaslik.Text, TextBoxAltBaslik.Text, 
                TextBoxAciklama.Text, TextBoxGnot.Text, TextBoxTarih.Text, 
                Convert.ToInt16(TextBoxID.Text));
            Response.Redirect("AdminEgitimler.aspx");
        }
    }
}