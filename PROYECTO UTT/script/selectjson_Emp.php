<?php
    error_reporting(E_ALL ^ E_NOTICE);
	header('Content-type: application/json');
	
	include_once("datos.php");
	
    extract($_POST);

	$Datos=new Datos();
	$Datos->Conectar();
	$data=$Datos->SelectJson("SELECT
    empleados.id,
    Nombre,
    Apellidos,
    Direccion,
    Sueldo_base,
    tipo_emp.NombreTipo,
    usuarios,
    pass FROM empleados,tipo_emp WHERE empleados.Tipo_Emp_id = tipo_emp.id 
    and status = 'Activo'");
	echo $data;
	$Datos->Desconectar();
?>