<?php
    error_reporting(E_ALL ^ E_NOTICE);
	header('Content-type: application/json');
	
	include_once("datos.php");
	
    extract($_POST);

	$Datos=new Datos();
	$Datos->Conectar();
	$data=$Datos->SelectJson("SELECT id,NombreTipo FROM tipo_emp");
	echo $data;
	$Datos->Desconectar();
?>