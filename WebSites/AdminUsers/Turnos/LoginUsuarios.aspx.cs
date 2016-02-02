using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Negocios;
using Entidades;

public partial class Usuarios_LoginUsuarios : System.Web.UI.Page
{
    public EntUsuarios ObjEntLoginUsuario = new EntUsuarios();
    public NegUsuario ObjNegLoginUsuario = new NegUsuario();
    protected void Page_Load(object sender, EventArgs e)
    {
    }

  
    protected void ImgAceptarAgregar_Click(object sender, ImageClickEventArgs e)
    {
        DataSet ds = new DataSet();
        ObjEntLoginUsuario.LoginUsuario = TextBoxUsuario.Text;
        ObjEntLoginUsuario.Contraseña = TextBoxContraseña.Text;

        ds = ObjNegLoginUsuario.LoginUsuario(ObjEntLoginUsuario.LoginUsuario, ObjEntLoginUsuario.Contraseña);
        if (ds.Tables[0].Rows.Count > 0)
        {
            if (ds.Tables[0].Rows[0]["TipoUsuario"].ToString() == "1")
            {
                string Usuario = TextBoxUsuario.Text;
                Session["Usuario"] = Usuario;
                Response.Redirect("ConsultasUsuarios.aspx");
            }
            else
            if (ds.Tables[0].Rows[0]["TipoUsuario"].ToString() == "2")
            {
                string Usuario = TextBoxUsuario.Text;
                Session["Usuario"] = Usuario;
                string Ventanilla = DropDownListVentanillas.SelectedValue.ToString();
                Session["Ventanilla"] = Ventanilla;
                Response.Redirect("Turnos.aspx");
            }
        }
        else
        {
            Response.Write("<script>window.alert('AVISO: Usuario o contraseña no valido')</script>");
        }
    }

    protected void ImgCancelarAgregar_Click(object sender, ImageClickEventArgs e)
    {

    }

}