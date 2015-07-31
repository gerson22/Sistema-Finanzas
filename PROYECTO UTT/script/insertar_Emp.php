<?php
    error_reporting(E_ALL  ^ E_NOTICE);
    header('Content-type: application/json');
    
    include("datos.php");
    
    extract($_POST);
    
    try{
        $Datos=new Datos();
        $Datos->Conectar();
        $Datos->Insert("INSERT INTO empleados
                            (id,
                            Nombre,
                            Apellidos,
                            Direccion,
                            Sueldo_base,
                            Tipo_Emp_id,
                            usuarios,
                            pass)
                        VALUES
                            (null,
                            '$nombre',
                            '$apellidos',
                            '$direccion',
                            '0',
                            '$TipoEmp',
                            '$user',
                            '$pass')"); 
        
        echo true;
        $Datos->Desconectar();
        
        }
    
    catch (Exception $ex)
    {
        echo NULL;
    
    
    }
?>