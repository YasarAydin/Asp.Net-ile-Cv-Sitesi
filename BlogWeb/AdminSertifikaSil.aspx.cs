﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminSertifikaSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);
            DataSet1TableAdapters.TBLSERTIFIKALARTableAdapter dt =
                new DataSet1TableAdapters.TBLSERTIFIKALARTableAdapter();
            dt.SertifikaSil(Convert.ToInt16(id));
            Response.Redirect("AdminSertifikalar.aspx");
        }
    }
}