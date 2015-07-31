<?php
    error_reporting(E_ALL  ^ E_NOTICE);
    header('Content-type: application/json');
    
    include_once("datos.php");
    
    extract($_POST);
    
    try{
        $Datos=new Datos();
        $Datos->Conectar();
        $Datos->Update("UPDATE empleados
                        SET status = 'Pendiente' WHERE id = '$idEmp'");
        $Datos->Desconectar();
        echo true;  
        }
    
    catch (Exception $ex)
    {
        echo NULL;
    
    
    }
?>