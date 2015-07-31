<?php
    session_start();
if( $_SESSION['Tipo']= 1)
{
?>


<!DOCTYPE html>
<html>
    <head>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <link rel="icon" href="../img/favicon.ico">
        <title>Martí</title>

        <link href="../css/bootstrap.css" rel="stylesheet">
        <link href="../css/sistema.css" rel="stylesheet">

        <script src="../js/jquery-2.1.3.js"></script>
        <script src="../js/bootstrap.js"></script>
        <script src="../js/app.js"></script>
    </head>
    <body>

        <!-- Barra de Navegacion -->
        <nav class="navbar navbar navbar-fixed-top" id="barsuper">
            <div class="container-fluid">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle collapsed" data-toggle="collapsed" data-target="#barra" aria-expanded="false" aria-controls="navbar">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <img id="logo" src="../img/logo-marti.png" alt="logo">
                </div>
                <div id="barra" class="navbar-collapse collapse">
                    <ul class="nav navbar-nav navbar-right">
                    <li>
                        <h1 id="titSistem">Sistema Martí</h1>
                    </li>
                        <li>
                            <img id="imguser1" class="center-block img-circle" src="../img/user3.png" alt="usuario" style="max-width:40px;">
                        </li>
                        <li class="dropdown" id="exit">
                            <a id="salir" href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-expanded="false"><?php echo $_SESSION['Usuario'] ?><span class="caret"></span></a>
                            <ul class="dropdown-menu" role="menu">
                                <li><a href="../script/logout.php" id="salir">Salir</a></li>
                            </ul>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
        <div class="container-fluid">
            <div class="row">
                <div class="col-sm-2 col-md-2 sidebar">
                    <ul class="nav nav-sidebar">
                        <li>
                            <a id="pag_home" class="active glyphicon glyphicon-home"> HOME</a>
                        </li>
                        <li>
                            <a href="#Menu1" data-toggle="collapse" data-parent="#MainMenu"><span class="glyphicon glyphicon-list-alt"></span> Noticias</a>
                        </li>

                        <div class="collapse" id="Menu1">
                            <li><a id="pag_extras" class="list-group-item">Extras</a></li>
                        </div>

                        <li>
                            <a href="#Menu2" data-toggle="collapse" data-parent="#MainMenu"><span class="glyphicon glyphicon-user"></span> Empleados</a>
                        </li>
                        <div class="collapse" id="Menu2">
                            <li><a id="pag_gestion" class="list-group-item">Gestión</a></li>
                        </div>

                         <li>
                            <a href="#Menu4" data-toggle="collapse" data-parent="#MainMenu"><span class="glyphicon glyphicon-pushpin"></span> Reportes</a>
                        </li>
                        <div class="collapse" id="Menu4">
                            <li><a id="pag_reportes" class="list-group-item">Ingreso y Egreso</a></li>
                        </div>


                    </ul>
                </div>
                <div id="principal" class="col-sm-9 col-sm-offset-3 col-md-10 col-md-offset-2">
                    <div id="area_trabajo">
                        <br>
                        <br>
                        <div class="jumbotron">
                            <h2 class="sistMarti">BIENVENIDO AL SISTEMA MARTI</h2>
                             <p>El sistema ofrece la gestión de los empleados que actualmente trabajan para Martí
                            así como tener la facilidad de revisar o consultar los reportes de ventas, ingresos y egresos
                            y todo ello en la fecha que tu desees.
                            <br><br>
                            Panel de control es el siguiente:<br><br>
                            1ero. "Pestaña HOME": <img src="../img/home.png"><br>es sencilla, al dar click en ella, te manada a esta misma pagina
                            como desde el comienzo.<br><br>
                            2do. "Pestaña Noticias": <img src="../img/noticias.png"><br>esta pestaña te enviara a una sección donde se presentan algunas
                            de las noticias mas relevantes de la semana entorno a nuestra empresa Martí.<br><br>
                            3ro. "Pestaña Empleados": <img src="../img/empleados.png"><br>esta pestaña abre el proceso de gestión de los empleados donde 
                            desde ella podrás dar de alta, baja y editar a los empleados registrados, para posteriormente
                            los cambios sean autorizados desde la aplicación y la actualización se haga valida.<br><br>
                            4to. "Pestaña Reportes": <img src="../img/reportes.png"><br>en ella podrás determinar las fechas en las que quieras revisar 
                            los reportes de los ingresos y egresos o en automatico los reportes se presentaran en periodos
                            trimestrales.<br><br>
                            Ahora ya conoces el funcionamiento, comenzemos !!
                            </p>
                         </div>
                    </div>
                </div>
            </div>
        </div>
    </body>
</html>

<?php
}
else
{
    session_destroy();
    header("Location:script/logout.php");
}
    ?>
