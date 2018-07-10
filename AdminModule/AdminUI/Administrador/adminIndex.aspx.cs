﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdminUI {
    public partial class adminIndex : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (new ControlUsuarioLogin().verificaAdmin() == true)
            {
                Response.Redirect("~/Login/login.aspx");
            }
        }
    }
}