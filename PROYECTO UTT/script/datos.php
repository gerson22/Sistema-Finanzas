<?php

//aqui encontramos una serie de codio qe es estandar se usa para establecer 
//las consutas con la base de datos atraves del metod PDO 
//con ella podemos mandar a llamar metodos como Conectar, Desconectar, Insert,
//Select, Delete, Update y SelectJson este ultimo lo utilizamos para 
//mostrar en una aplicacion Json o servicio con el cual podemos mostrar 
//en una una tabla atraves de ajax
    include_once ("conection.php");
	
	class Datos
	{
		private $PDOLocal;
		private $Rows;
		private $Datos;
		
		function Conectar()
		{
			try
			{
				$StringConn= new Conexion();
				$this->PDOLocal=new  PDO($StringConn->Servidor, $StringConn->Usuario,$StringConn->Pass);
			}
			catch(PDOException $e)
			{
				echo "Error ".$e->getMessage();
			}
		}
		
		function Desconectar()
		{
			$this->PDOLocal=NULL;
		}
		
		function Insert($Query)
		{
			try
			{
				$Resultado=$this->PDOLocal->query($Query);
			}
			catch(PDOException $e)
			{
				echo "Error: ".$e->getMessage();
			}
		}
		
		function Select($Query)
		{
			try
			{
				$Resultado=$this->PDOLocal->query($Query);
				while($Row=$Resultado->fetch(PDO::FETCH_ASSOC))
				{
					$Datos[]=$Row;
				}
				return $Datos;
			}
			catch(PDOException $e)
			{
				return $Datos;
			}
		}
		
		function Delete($Query)
		{
			$this->Select($Query);
		}
		
		function Update($Query)
		{
			$this->Select($Query);
		}
		
		function SelectJson($Query)
		{
			return json_encode($this->Select($Query));
		}
	}
?>