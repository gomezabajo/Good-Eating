using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Menu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Common.Usuario == null)
        {
            Common.SessionAbandon();
            return;
        }
        if ((Common.Usuario.Login == string.Empty) || (Usuario.Sistema.Contains(Common.Usuario) == false))
        {
            Common.SessionAbandon();
            return;
        }
    }
}
