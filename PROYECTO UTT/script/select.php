<?php
    error_reporting(E_ALL ^ E_NOTICE);
	header('Content-type: application/json');
	
	include_once("datos.php");
	
    extract($_POST);

	$Datos=new Datos();
	$Datos->Conectar();
	$data=$Datos->Select();
	foreach ($data as $row)
			{			
				$valor =$row['key'];
			}
	$Datos->Desconectar();
?>