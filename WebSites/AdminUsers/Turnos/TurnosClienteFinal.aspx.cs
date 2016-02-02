using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Negocios;
using Entidades;

public partial class Turnos_TurnosClienteFinal : System.Web.UI.Page
{
    public EntTurnos ObjEntTurnos = new EntTurnos();
    public NegTurnos ObjNegTurnos = new NegTurnos();

    protected void Page_Load(object sender, EventArgs e)
    {
        System.Threading.Thread.Sleep(60);
        ConsultaTurnos();

    }

    private void ObjToTextBox(DataSet ds)
    {
        //LabelTurnoActual.Text = (ds.Tables[0].Rows[0]["Turno"].ToString() + " " + ds.Tables[0].Rows[0]["Ventanilla"].ToString());


        if (ds.Tables[0].Rows.Count < 1)
        {
            LabelTurno1.Text = "00";
        }
        else
        {
            if ((Int32.Parse(ds.Tables[0].Rows[0]["Turno"].ToString())) <= 9)
            {
                LabelTurno1.Text = "0" + (ds.Tables[0].Rows[0]["Turno"].ToString());
            }
            else
            {
                LabelTurno1.Text = (ds.Tables[0].Rows[0]["Turno"].ToString());
            }
        }




        if (ds.Tables[0].Rows.Count < 2)
        {
            LabelTurno2.Text = "00";
        }
        else
        {
            if ((Int32.Parse(ds.Tables[0].Rows[1]["Turno"].ToString())) <= 9)
            {
                LabelTurno2.Text = "0" + (ds.Tables[0].Rows[1]["Turno"].ToString());
            }
            else
            {
                LabelTurno2.Text = (ds.Tables[0].Rows[1]["Turno"].ToString());
            }
        }


        if (ds.Tables[0].Rows.Count < 3)
        {
            LabelTurno3.Text = "00";
        }
        else
        {
            if ((Int32.Parse(ds.Tables[0].Rows[2]["Turno"].ToString())) <= 9)
            {
                LabelTurno3.Text = "0" + (ds.Tables[0].Rows[2]["Turno"].ToString());
            }
            else
            {
                LabelTurno3.Text = (ds.Tables[0].Rows[2]["Turno"].ToString());
            }
        }



        if (ds.Tables[0].Rows.Count < 4)
        {
            LabelTurno4.Text = "00";
        }
        else
        {
            if ((Int32.Parse(ds.Tables[0].Rows[3]["Turno"].ToString())) <= 9)
            {
                LabelTurno4.Text = "0" + (ds.Tables[0].Rows[3]["Turno"].ToString());
            }
            else
            {
                LabelTurno4.Text = (ds.Tables[0].Rows[3]["Turno"].ToString());
            }
        }

        if(ds.Tables[0].Rows.Count < 5)
        {
            LabelTurno5.Text = "00";
        }
        else
        {
            if ((Int32.Parse(ds.Tables[0].Rows[4]["Turno"].ToString())) <= 9)
            {
                LabelTurno5.Text = "0" + (ds.Tables[0].Rows[4]["Turno"].ToString());
            }
            else
            {
                LabelTurno5.Text = (ds.Tables[0].Rows[4]["Turno"].ToString());
            }
        }


        if (ds.Tables[0].Rows.Count < 1)
        {
            LabelVentanilla1.Text = "00";
        }
        else
        {
            LabelVentanilla1.Text = (ds.Tables[0].Rows[0]["Ventanilla"].ToString());
        }

        if (ds.Tables[0].Rows.Count < 2)
        {
            LabelVentanilla2.Text = "00";
        }
        else
        {
            LabelVentanilla2.Text = (ds.Tables[0].Rows[1]["Ventanilla"].ToString());
        }

        if (ds.Tables[0].Rows.Count < 3)
        {
            LabelVentanilla3.Text = "00";
        }
        else
        {
            LabelVentanilla3.Text = (ds.Tables[0].Rows[2]["Ventanilla"].ToString());
        }

        if (ds.Tables[0].Rows.Count < 4)
        {
            LabelVentanilla4.Text = "00";
        }
        else
        {
            LabelVentanilla4.Text = (ds.Tables[0].Rows[3]["Ventanilla"].ToString());
        }

        if (ds.Tables[0].Rows.Count < 5)
        {
            LabelVentanilla5.Text = "00";
        }
        else
        {
            LabelVentanilla5.Text = (ds.Tables[0].Rows[4]["Ventanilla"].ToString());
        }
    }

    public void ConsultaTurnos()
    {
        DataSet dsListado = new DataSet();
        dsListado = ObjNegTurnos.ListadoTurnos();

        if (dsListado.Tables[0].Rows.Count > 0)
        {
            ObjToTextBox(dsListado);
            //GridViewListadoTurnos.DataSource = dsListado.Tables[0];
            //GridViewListadoTurnos.DataBind();
        }
        else
        {
            Response.Write("<script>window.alert('Aviso: No existen turnos')</script>");
        }
    }

    protected void ButtonSiguienteTurno_Click(object sender, EventArgs e)
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
        ObjEntTurnos.Turno = ContadorNum.ToString();
        ObjEntTurnos.Ventanilla = (string)Session["Ventanilla"];
        Grabados = ObjNegTurnos.AgregarTurno(ObjEntTurnos);
        if (Grabados != -1)
        {
            ConsultaTurnos();
        }

        else
            Response.Write("<script>window.alert('AVISO: El usuario no fue guardado correctamente')</script>");
    }
}