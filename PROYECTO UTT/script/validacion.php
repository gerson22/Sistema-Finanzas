<?php
	class Validacion{
		
		public function __construct()
		{
		}
		
		public function Limpia($valor)
		{
			$valor=str_replace("'","",$valor);
			$valor=stripslashes($valor);
			$valor=htmlspecialchars($valor);
			
			return $valor;
		}
		
		public function Redireccion($tipo){
			switch($tipo)
			{
				case 1:
				{
					return "ajax/empleados.php";
					break;
				}
                case "Usuario":
				{
					return "pages/usuario.php";
					break;
				}
			}
		}
		
		public function __destruct()
		{
		}
	}
?>