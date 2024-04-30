using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace BlogWeb
{
    public partial class GirisYap : System.Web.UI.Page
    {

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-694144I\SQLEXPRESS;Initial Catalog=BlogWebDB;Integrated Security=True;");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLADMIN" +
                " where KULLANICI = @P1 AND SIFRE = @P2", baglanti);
            komut.Parameters.AddWithValue("@P1", TextBoxAd.Text);
            komut.Parameters.AddWithValue("@P2", TextBoxSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Response.Redirect("AdminDeneyimler.aspx");
            }
            else
            {
                Response.Write("Hatalı Giriş");
            }
        }
    }
}