<?php
	error_reporting(E_ALL ^ E_NOTICE); 
	header('Content-type: application/json');

	extract($_POST); 

	include_once("datos.php");
	include_once("validacion.php");

	$validacion= new Validacion();

	$user=$validacion->Limpia($user);
	$pass=$validacion->Limpia($pass);
	
	$Datos=new Datos();
	$Datos->Conectar();
	$dat=$Datos->Select("SELECT Tipo_Emp_id,usuarios FROM empleados where usuarios='$usuarios' and pass='$pass'");
	
	$Datos->Desconectar();

	try
	{
		if(isset($dat))
		{
			session_start();
			
			foreach ($dat as $row)
			{			
				$_SESSION['Tipo']=$row['Tipo_Emp_id'];
                $_SESSION['Usuario']=$row['usuarios'];
			}

			echo json_encode($validacion->Redireccion($_SESSION['Tipo']));
		}
		else
		{
			echo json_encode(NULL);	
		}
	}
	catch(Exception $e)
	{
		echo json_encode(NULL);
	}
?>