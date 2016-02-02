<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TurnosClienteFinal.aspx.cs" Inherits="Turnos_TurnosClienteFinal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>TURNOS</title>
    <link rel="stylesheet" href="../CSS/TurnosClienteFinal.css" />
</head>
<body style="background-color:#007DC0;" onload="reloj()">
    <form id="form1" runat="server">
        <script type="text/javascript">
        document.oncontextmenu = function(){return false}
        </script>
    <div id="Box">
        <div id="Gif">
            <img src="../Videos/Gif.gif" style="width:400px; height:400px;"/>
        </div>
        <div class="Subtitulo" style="top:30px; left:600px">
            <h1>TURNO</h1>
        </div>  
        <div class="Subtitulo" style="top:30px; left:900px">
            <h1>VENTANILLA</h1>
        </div>
        <asp:UpdatePanel ID="UpdatePanelTurnos" runat="server">
            <ContentTemplate>
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
                <asp:Timer ID="Timer1" runat="server" Interval="60">
                </asp:Timer>
                <div id="PanelTurnos">
                    <asp:Label ID="LabelTurno1" style="position:absolute;top:160px; background-color:white; border:2px dashed; border-radius:5px;" runat="server" Text="00"></asp:Label>
                    <br />                    
                    <asp:Label ID="LabelTurno2" style="position:absolute;top:240px; background-color:white; border:2px dashed; border-radius:5px;" runat="server" Text="00"></asp:Label>
                    <br />
                    <asp:Label ID="LabelTurno3" style="position:absolute;top:320px; background-color:white; border:2px dashed; border-radius:5px;" runat="server" Text="00"></asp:Label>
                    <br />
                    <asp:Label ID="LabelTurno4" style="position:absolute;top:400px; background-color:white; border:2px dashed; border-radius:5px;" runat="server" Text="00"></asp:Label>
                    <br />
                    <asp:Label ID="LabelTurno5" style="position:absolute;top:480px; background-color:white; border:2px dashed; border-radius:5px;" runat="server" Text="00"></asp:Label>
                    <br />
                </div>
                <div id="PanelVentanillas">
                    <asp:Label ID="LabelVentanilla1" style="position:absolute; top:160px;background-color:white; border:2px dashed; border-radius:5px;" runat="server" Text="00"></asp:Label>
                    <br />
                    <asp:Label ID="LabelVentanilla2" style="position:absolute; top:240px; background-color:white; border:2px dashed; border-radius:5px;" runat="server" Text="00"></asp:Label>
                    <br />
                    <asp:Label ID="LabelVentanilla3" style="position:absolute; top:320px; background-color:white; border:2px dashed; border-radius:5px;" runat="server" Text="00"></asp:Label>
                    <br />
                    <asp:Label ID="LabelVentanilla4" style="position:absolute; top:400px; background-color:white; border:2px dashed; border-radius:5px;" runat="server" Text="00"></asp:Label>
                    <br />
                    <asp:Label ID="LabelVentanilla5" style="position:absolute; top:480px; background-color:white; border:2px dashed; border-radius:5px;" runat="server" Text="00"></asp:Label>
                    <br />
                </div>                
            </ContentTemplate>
        </asp:UpdatePanel>
        <div id="Fecha">
        </div>    
        <div id="Clock">
        </div>        
    </div>
     <script type="text/javascript">
         var now = new Date();
         var dia = new Array(7);
         dia[0] = "Dom";
         dia[1] = "Lun";
         dia[2] = "Mar";
         dia[3] = "Mie";
         dia[4] = "Jue";
         dia[5] = "Vie";
         dia[6] = "Sab";
         var mes = new Array(12);
         mes[0] = "Ene";
         mes[1] = "Feb";
         mes[2] = "Mar";
         mes[3] = "Abr";
         mes[4] = "May";
         mes[5] = "Jun";
         mes[6] = "Jul";
         mes[7] = "Ago";
         mes[8] = "Sep";
         mes[9] = "Oct";
         mes[10] = "Nov";
         mes[11] = "Dic";
        function reloj()
        {
            var Fecha = new Date();
            var today = (dia[now.getDay()] + ", " + (now.getDate()) +  " " + mes[now.getMonth()] + " "+ " de " + (now.getFullYear()));
            if (Fecha.getHours() <= 9)
            {
                var Hora = "0" + Fecha.getHours();
            }
            else
            {
                var Hora = Fecha.getHours()
            }
            if (Fecha.getMinutes() <= 9)
            {
                var Min = "0" + Fecha.getMinutes();
            }
            else
            {
                var Min = Fecha.getMinutes()
            }
            if (Fecha.getSeconds() <= 9)
            {
                var Seg = "0" + Fecha.getSeconds();
            }
            else
            {
                var Seg = Fecha.getSeconds();
            }
            var recargar = setTimeout("reloj()", 1000);
            document.getElementById('Clock').innerHTML = Hora + " : " + Min + " : " + Seg;
            document.getElementById('Fecha').innerHTML = today;
        }

    </script>
    <div id="EscudoPonal">
        <img src="../Imagenes/EscudoPonal.png"  style="position:absolute;left:100px; width:150px; height:150px" />
    </div>
    <div id="EscudoSanidad">
        <img src="../Imagenes/EscudoSanidad.png"  style="position:absolute;left:1150px; width:150px; height:150px" />
    </div>
    </form>
</body>
</html>
