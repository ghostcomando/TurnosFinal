using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Negocios;
using Entidades;

public partial class Usuarios_ConsultasTipoUsuarios : System.Web.UI.Page
{
    public EntUsuarios ObjEntUsuario = new EntUsuarios();
    public NegUsuario ObjNegUsuario = new NegUsuario();
    protected void Page_Load(object sender, EventArgs e)
    {
        LabelUsuario.Text = (string)Session["Usuario"];
        if (LabelUsuario.Text == string.Empty)
        {
            Response.Redirect("LoginUsuarios.aspx");
        }
        PanelCapturaCedula.Visible = false;
        PanelDatos.Visible = false;
        PanelGrabarDatos.Visible = false;
        PanelListarDatos.Visible = false;
        PanelModificarDatos.Visible = false; 
    }

    private void LimpiarTextBox()
    {
        TextBoxCedula.Text = "";
        TextBoxPrimerNombre.Text = "";
        TextBoxSegundoNombre.Text = "";
        TextBoxPrimerApellido.Text = "";
        TextBoxSegundoApellido.Text = "";
        TextBoxUsuario.Text = "";
        TextBoxTipoUsuario.Text = "";
        TextBoxContraseña.Text = "";
    }

    private void ObjToTextBox(DataSet ds)
    {
        TextBoxPrimerNombre.Text = ds.Tables[0].Rows[0]["PrimerNombre"].ToString();
        TextBoxSegundoNombre.Text = ds.Tables[0].Rows[0]["SegundoNombre"].ToString();
        TextBoxPrimerApellido.Text = ds.Tables[0].Rows[0]["PrimerApellido"].ToString();
        TextBoxSegundoApellido.Text = ds.Tables[0].Rows[0]["SegundoApellido"].ToString();
        TextBoxUsuario.Text = ds.Tables[0].Rows[0]["Usuario"].ToString();
        TextBoxTipoUsuario.Text = ds.Tables[0].Rows[0]["TipoUsuario"].ToString();
        TextBoxContraseña.Text = ds.Tables[0].Rows[0]["Contraseña"].ToString();
    }

    protected void ImgNuevo_Click(object sender, ImageClickEventArgs e)
    {
        ButtonConsulta.Visible = false;
        PanelCapturaCedula.Visible = true;
        PanelDatos.Visible = true;
        PanelGrabarDatos.Visible = true;
        PanelListarDatos.Visible = false;
        PanelModificarDatos.Visible = false;
        LimpiarTextBox();
    }

    protected void ImgImprimir_Click(object sender, ImageClickEventArgs e)
    {
        PanelListarDatos.Visible = true;
        DataSet ds = new DataSet();

        ds = ObjNegUsuario.ListadoUsuario();

        if (ds.Tables[0].Rows.Count > 0)
        {
            GridViewListadoUsuario.DataSource = ds.Tables[0];
            GridViewListadoUsuario.DataBind();
        }
        else
            Response.Write("<script>window.alert('Aviso: No existen personas inscritas')</script>");
    }

    protected void ImgEditar_Click(object sender, ImageClickEventArgs e)
    {
        ButtonConsulta.Visible = true;
        PanelCapturaCedula.Visible = true;
        PanelDatos.Visible = false;
        PanelModificarDatos.Visible = false;
        PanelGrabarDatos.Visible = false;
    }

    protected void ImgInicio_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("LoginUsuarios.aspx");
    }

    protected void ImgAceptarModificar_Click(object sender, ImageClickEventArgs e)
    {
        int Grabados = -1;
        TexBoxToObject();
        Grabados = ObjNegUsuario.ConsultaUsuario("MODIFICAR", ObjEntUsuario);
        if (Grabados != -1)
            Response.Write("<script>window.alert('AVISO: El usuario fue modificado correctamente')</script>");
        else
            Response.Write("<script>window.alert('AVISO: El usuario no fue modificado correctamente')</script>");
        LimpiarTextBox();
    }

    protected void ImgBorrarModificar_Click(object sender, ImageClickEventArgs e)
    {
        int Grabados = -1;
        TexBoxToObject();
        Grabados = ObjNegUsuario.ConsultaUsuario("BORRAR", ObjEntUsuario);
        if (Grabados != -1)
            Response.Write("<script>window.alert('AVISO: El usuario fue eliminado correctamente')</script>");
        else
            Response.Write("<script>window.alert('AVISO: El usuario no fue eliminado correctamente')</script>");
        LimpiarTextBox();
    }

    protected void ImgCancelarModificar_Click(object sender, ImageClickEventArgs e)
    {
        LimpiarTextBox();
        ButtonConsulta.Visible = true;
        PanelCapturaCedula.Visible = true;
        PanelDatos.Visible = false;
    }

    private void TexBoxToObject()
    {
        ObjEntUsuario.Cedula = TextBoxCedula.Text;
        ObjEntUsuario.PrimerNombre = TextBoxPrimerNombre.Text;
        ObjEntUsuario.SegundoNombre = TextBoxSegundoNombre.Text;
        ObjEntUsuario.PrimerApellido = TextBoxPrimerApellido.Text;
        ObjEntUsuario.SegundoApellido = TextBoxSegundoApellido.Text;
        ObjEntUsuario.LoginUsuario = TextBoxUsuario.Text;
        ObjEntUsuario.TipoUsuario = TextBoxTipoUsuario.Text;
        ObjEntUsuario.Contraseña = TextBoxContraseña.Text;
    }


    protected void ImgAceptarAgregar_Click(object sender, ImageClickEventArgs e)
    {
        int Grabados = -1;
        TexBoxToObject();
        Grabados = ObjNegUsuario.ConsultaUsuario("AGREGAR", ObjEntUsuario);
        if (Grabados != -1)
            Response.Write("<script>window.alert('AVISO: El usuario fue guardado correctamente')</script>");
        else
            Response.Write("<script>window.alert('AVISO: El usuario no fue guardado correctamente')</script>");
        LimpiarTextBox();
    }

    protected void ImgCancelarAgregar_Click(object sender, ImageClickEventArgs e)
    {
        LimpiarTextBox();
    }

    protected void ButtonConsulta_Click(object sender, EventArgs e)
    {
        PanelCapturaCedula.Visible = true;
        PanelDatos.Visible = true;
        PanelModificarDatos.Visible = true;
        DataSet ds = new DataSet();
        ObjEntUsuario.Cedula = TextBoxCedula.Text;

        ds = ObjNegUsuario.SeleccionUsuario(ObjEntUsuario.Cedula);
        
        if(ds.Tables[0].Rows.Count>0)
        {
            ObjToTextBox(ds);
        }
        else
        {
            LimpiarTextBox();
            Response.Write("<script>window.alert('AVISO: El usuario no existe')</script>");
        } 
    }

    protected void GridViewListadoUsuario_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        ObjEntUsuario.Cedula = (GridViewListadoUsuario.DataKeys[GridViewListadoUsuario.SelectedIndex].Value.ToString());

        ds = ObjNegUsuario.SeleccionUsuario(ObjEntUsuario.Cedula);
        

        if (ds.Tables[0].Rows.Count > 0)
        {
            ObjToTextBox(ds);
            PanelDatos.Visible = true;
            PanelModificarDatos.Visible = true;
        }
    }
}