using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Negocios;
using Entidades;

public partial class Turnos_Turnos : System.Web.UI.Page
{
    public EntTurnos ObjEntTurnos = new EntTurnos();
    public NegTurnos ObjNegTurnos = new NegTurnos();

    public EntTurnosPreferencial ObjEntTurnosPreferencial = new EntTurnosPreferencial();
    public NegTurnosPreferencial ObjNegTurnosPreferencial = new NegTurnosPreferencial();

    protected void Page_Load(object sender, EventArgs e)
    {
        System.Threading.Thread.Sleep(60);
        LabelUsuario.Text = (string)Session["Usuario"];
        LabelVentanilla.Text = (string)Session["Ventanilla"];
        if (LabelUsuario.Text == string.Empty)
        {
            Response.Redirect("LoginUsuarios.aspx");
        }
            ConsultaTurnos();
        

    }

    private void ObjToTextBox(DataSet ds)
    {
        LabelTurnoActual.Text = (ds.Tables[0].Rows[0]["Turno"].ToString() + " " + ds.Tables[0].Rows[0]["Ventanilla"].ToString());

    }

    public void ConsultaTurnos()
    {
        DataSet dsListado = new DataSet();
        dsListado = ObjNegTurnos.ListadoTurnos();

        if (dsListado.Tables[0].Rows.Count > 0)
        {
            ObjToTextBox(dsListado);
            GridViewListadoTurnos.DataSource = dsListado.Tables[0];
            GridViewListadoTurnos.DataBind();
        }
        else
        {
            Response.Write("<script>window.alert('Aviso: No existen turnos')</script>");
        }
    }


    public void ConsultaTurnosPreferencial()
    {
        DataSet dsListado = new DataSet();
        dsListado = ObjNegTurnosPreferencial.ListadoTurnosPreferencial();

        if (dsListado.Tables[0].Rows.Count > 0)
        {
            ObjToTextBox(dsListado);
            GridViewListadoTurnos.DataSource = dsListado.Tables[0];
            GridViewListadoTurnos.DataBind();
        }
        else
        {
            Response.Write("<script>window.alert('Aviso: No existen turnos')</script>");
        }
    }

    protected void ButtonSiguienteTurno_Click(object sender, EventArgs e)
    {
        string Ventanilla = (string)Session["Ventanilla"];
        if(Ventanilla == "Preferencial")
        {
            AgregarTurnoPreferencial();
        }
        else
        {
            AgregarTurnoSimple();
        }
        
        

    }

    protected void Timer1_Tick(object sender, EventArgs e)
    {

    }

    protected void AgregarTurnoSimple()
    {
        DataSet dsSeleccion = new DataSet();
        dsSeleccion = ObjNegTurnos.SeleccionTurno();
        int Grabados = -1;
        string Contador = "0";
        if (dsSeleccion.Tables[0].Rows.Count > 0)
        {
            Contador = (dsSeleccion.Tables[0].Rows[0]["Turno"].ToString());
        }
        int ContadorNum = int.Parse(Contador);
        ContadorNum++;
        if (ContadorNum == 100)
        {
            ContadorNum = 1;
        }
        DateTime FechaHora = DateTime.Now;
        string NuevaFecha = string.Format("{0:yyyy-MM-dd HH:mm:ss.fff}", FechaHora);
        FechaHora = DateTime.Parse(NuevaFecha); 

        ObjEntTurnos.Turno = ContadorNum.ToString();
        ObjEntTurnos.Ventanilla = (string)Session["Ventanilla"];
        ObjEntTurnos.FechaHora = FechaHora;

        Grabados = ObjNegTurnos.AgregarTurno(ObjEntTurnos);
        if (Grabados != -1)
        {
            ConsultaTurnos();
        }

        else
            Response.Write("<script>window.alert('AVISO: El usuario no fue guardado correctamente')</script>");
        ConsultaTurnos();
    }

    protected void AgregarTurnoPreferencial()
    {
        DataSet dsSeleccion = new DataSet();
        dsSeleccion = ObjNegTurnosPreferencial.SeleccionTurnoPreferencial();
        int Grabados = -1;
        string Contador = "0";
        if (dsSeleccion.Tables[0].Rows.Count > 0)
        {
            Contador = (dsSeleccion.Tables[0].Rows[0]["Turno"].ToString());
        }
        int ContadorNum = int.Parse(Contador);
        ContadorNum++;
        if (ContadorNum == 100)
        {
            ContadorNum = 1;
        }
        DateTime FechaHora = DateTime.Now;
        string NuevaFecha = string.Format("{0:yyyy-MM-dd HH:mm:ss.fff}", FechaHora);
        FechaHora = DateTime.Parse(NuevaFecha);

        ObjEntTurnosPreferencial.Turno = ContadorNum.ToString();
        ObjEntTurnosPreferencial.Ventanilla = (string)Session["Ventanilla"];
        ObjEntTurnosPreferencial.FechaHora = FechaHora;

        Grabados = ObjNegTurnosPreferencial.AgregarTurnoPreferencial(ObjEntTurnosPreferencial);
        if (Grabados != -1)
        {
            ConsultaTurnos();
        }

        else
            Response.Write("<script>window.alert('AVISO: El usuario no fue guardado correctamente')</script>");
    }

}
