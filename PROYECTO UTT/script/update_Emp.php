<?php
    error_reporting(E_ALL  ^ E_NOTICE);
    header('Content-type: application/json');
    
    include_once("datos.php");
    
    extract($_POST);
    
    try{
        $Datos=new Datos();
        $Datos->Conectar();
        $Datos->Update("UPDATE empleados
                        SET
                            Nombre = '$nombre',
                            Apellidos = '$apellidos',
                            Direccion = '$direccion',
                            Sueldo_base = '$sueldo_base',
                            Tipo_Emp_id = (SELECT id FROM tipo_emp
                                                WHERE NombreTipo = '$TipoEmp'
                                                OR id = '$TipoEmp'
                                                LIMIT 1),
                            usuarios = '$user',
                            pass = '$pass'
                        WHERE id = '$idEmp'");
        $Datos->Desconectar();
        echo true;  
        }
    
    catch (Exception $ex)
    {
        echo NULL;
    
    
    }
?>