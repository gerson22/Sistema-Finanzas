<link rel="stylesheet" type="text/css" href="../css/formularios.css">
<script src="../js/app.js" type="text/javascript"></script>
                <div class="row">
                    <div class="col-md-4">
                     <form id="validareg"> 
                         <div class="form-group" id="input_idEmp">
                            <input type="hidden" class="form-control" id="idEmp" name="idEmp" placeholder="ID empleado">
                            </div>
                            <div class="form-group">
                                <label for="nombre">Nombre: </label>
                                <input type="text" maxlength="20" class="form-control" id="nombre" placeholder="nombre empleado" required="true" name="nombre">
                            </div>

                            <div class="form-group">
                                <label for="apellidos">Apellidos: </label>
                                <input type="text" maxlength="30" class="form-control" id="apellidos" placeholder="apellidos empleado" required="true" name="apellidos">
                            </div>

                            <div class="form-group">
                                <label for="direccion">Dirección: </label>
                                <input type="text" class="form-control" id="direccion" placeholder="dirección empleado" required="true" name="direccion">
                            </div>
                            <label>Tipo empleado: </label>
                             <div class="input-group">
                                <span class="input-group-btn">
                                  <button type="button" class="btn btn-primary" id="add_TipoEmp"><span class="glyphicon glyphicon-plus"></span></button>
                                 </span>
                                <select class="form-control" id="Tipo_emp" name="TipoEmp">
                    
                                </select>
                            </div>
                            <div class="form-group">
                                <input id="sueldo_base" name="sueldo_base" class="form-control" type="hidden" placeholder="sueldo base">
                            </div>
                            <div class="form-group"><br>
                                <label for="user">Usuario: </label>
                                <input id="user" name="user" maxlength="10" class="form-control" type="text" placeholder="nombre usuario">
                            </div>

                            <div class="form-group">
                                <label for="pass">Password: </label>
                                <input id="pass" maxlength="8" name="pass" class="form-control" type="password" placeholder="contraseña">
                            </div>

                            <div id="btn-ing">
                                <button type="button" class="btn btn-danger" id="reg_emp">Registrar</button>
                                <button type="button" class="btn btn-danger" id="edit_emp">Editar</button>
                                <button type="button" class="btn btn-danger" id="elim_emp">Eliminar</button>
                            </div>
                        </form>
                    </div>
                    
                    <div class="col-md-4 col-md-offset-2"><br><br>
                        <h2 class="titulo">Empleados Registrados</h2>
                    </div>
                    <div class="col-md-8">
                        <table class="table" id="empleados">
                         <thead>
                               <tr>
                                   <td>id_Emp.</td>
                                   <td>Nombre</td>
                                   <td>Apellidos</td>
                                   <td>Dirección</td>
                                   <td>Sueldo_base</td>
                                   <td>Tipo_Emp.</td>
                                   <td>Usuario</td>
                                   <td>Pass</td>
                               </tr>
                         </thead>
                         <tbody>

                         </tbody>
                     </table>
                    </div>
                </div>
<script type="text/javascript">
    mostrarEmple('../script/selectjson_Emp.php');
    tipo_Emp('../script/tipo_Emp.php');
    seleccionar();
    
    $('#reg_emp').click(function () {
        abc_Empleado('../script/insertar_Emp.php');
        
        alert("Empleado registrados !!");
    });
    
    $('#edit_emp').click(function(){
        abc_Empleado('../script/update_Emp.php');
        
        alert("Editado exitoso !!");
        
    });

    $('#elim_emp').click(function(){
        abc_Empleado('../script/delete_Emp.php');
       
        alert("Empleado dado de baja !!");
        
    });
</script>