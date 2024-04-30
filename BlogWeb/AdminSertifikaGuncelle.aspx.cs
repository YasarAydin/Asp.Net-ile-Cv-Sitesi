using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminSertifikaGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);
            TextBoxID.Enabled = false;
            TextBoxID.Text = id.ToString();


            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TBLSERTIFIKALARTableAdapter dt =
                new DataSet1TableAdapters.TBLSERTIFIKALARTableAdapter();
                TextBoxSertifika.Text = dt.SertifikaGetir(Convert.ToInt16(id))[0].SERTIFIKAAD;
            }
        }

        protected void ButtonSertifikaGuncelle_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLSERTIFIKALARTableAdapter dt =
                new DataSet1TableAdapters.TBLSERTIFIKALARTableAdapter();
            dt.SertifikaGuncelle(TextBoxSertifika.Text, Convert.ToInt16(TextBoxID.Text));
            Response.Redirect("AdminSertifikalar.aspx");
        }
    }
}