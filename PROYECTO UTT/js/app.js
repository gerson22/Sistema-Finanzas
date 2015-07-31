$(document).ready( function(){
    // HOME
    menu('../ajax/home.php','pag_home');
    // ALTA EMPLEADO
    menu('../ajax/regEmpleado.php','pag_gestion');
    // REPORTES
    menu('../ajax/reportes.php','pag_reportes');
    // NOTICIAS
    menu('../ajax/noticias.php','pag_extras');
    
});


function menu(urls,id){
    $('#'+id+'').click( function(){
       $.ajax({
           url: urls,
           success: function(data){
               $('#area_trabajo').html(data);
           }
       });
    });
}

function soloNum(e){
    
    key = e.keyCode || e.which;
    teclado = String.fromCharCode(key);
    numeros = "0123456789";
    especiales = "8-37-38-46";
    teclado_especial = false;
    
    for(var i in especiales){
        
        if(key==especiales[i])
        {
            teclado_especial=true;
        }
    }
    
    if(numeros.indexOf(teclado)==-1 && !teclado_especial)
    {
        return false;
    }
}

function abc_Empleado(urls){
    $.ajax({
        url: urls,
        type: 'POST',
        dataType: 'JSON',
        data: $('#validareg').serialize(),
        success: function(Datos){
            switch(Datos){
                case 1:{
                    mostrarEmple('../script/selectjson_Emp.php');
                    $('input').val('');

                    break;
                }
                case 0:{
                    alert("ERROR");
                    break;
                }
            }
        }
    });
}


function mostrarEmple(urls){
    $.ajax({
        url: urls,
        success: function(data){
            $('#empleados tbody').empty();
            $.each(data ,function(index,Contenido){
                $('#empleados tbody').append('<tr>'+
                    '<td>'+Contenido.id+'</td>'+
                    '<td>'+Contenido.Nombre+'</td>'+
                    '<td>'+Contenido.Apellidos+'</td>'+
                    '<td>'+Contenido.Direccion+'</td>'+
                    '<td>'+Contenido.Sueldo_base+'</td>'+
                    '<td>'+Contenido.NombreTipo+'</td>'+
                    '<td>'+Contenido.usuarios+'</td>'+
                    '<td>'+Contenido.pass+'</td>'+
                '</tr>');
            });
        }
    });
}

function tipo_Emp(urls){
    $.ajax({
        url: urls,
        success: function(data){
            $('#Tipo_emp').empty();
            $('#Tipo_emp').append('<option value="null">tipo_Emp</option>');
            $.each(data, function(index, Contenido){
                $('#Tipo_emp').append('<option value="'+Contenido.id+'">'+Contenido.NombreTipo+'</option>');
            });
        }
    });
}

function login(urls){
    $.ajax({
        url: urls,
        type: 'POST',
        dataType: 'JSON',
        data: $('#validaUsuario').serialize(),
        success: function(Datos){
            switch(Datos){
                case null:{
                    alert("Usuario No Valido");
                    $('input').val('');
                    break;
                }
                case true:{
                    window.location=Datos;
                    break;
                }
                default:
                {
                    window.location=Datos;
                    break;
                }
            }
        }
    });
}

function seleccionar(){
    $('#empleados tbody').on('click', 'tr', function(){
        if ( $(this).hasClass('seleccion') ) {
            $(this).removeClass('seleccion');

            $('#reg_emp').prop("disabled" , false);
            $('#edit_emp').prop("disabled" , true);
            $('#elim_emp').prop("disabled" , true);
            $('input').val(''); 
            
            
        } else {
            $('tr .seleccion').removeClass('seleccion');
            $(this).addClass('seleccion');
                
            $('#reg_emp').prop("disabled" , true);
            $('#edit_emp').prop("disabled" , false);
            $('#elim_emp').prop("disabled" , false);
            
            $('#empleados tbody .seleccion').each(function(index1){
                var id, Nombre, Apellidos, sueldo_base, Direccion, Tipo_Emp_id, usuarios, pass;
                $(this).children('td').each(function(index2){
                    switch (index2){
                        case 0:
                            id = $(this).text();
                        break;
                        case 1:
                            Nombre = $(this).text();
                        break;
                        case 2:
                            Apellidos = $(this).text();
                        break;
                        case 3:
                            Direccion = $(this).text();
                        break;
                        case 4:
                            Tipo_Emp_id = $(this).text();
                        break;
                        case 5:
                            sueldo_base = $(this).text();
                        break;
                        case 6:
                            usuarios = $(this).text();
                        break;
                        case 7:
                            pass = $(this).text();
                        break;
                    }
                });
                
                $('#idEmp').val(id);
                $('#nombre').val(Nombre);
                $('#apellidos').val(Apellidos);
                $('#direccion').val(Direccion);
                $('#TipoEmp option:selected').text(Tipo_Emp_id);
                $('#TipoEmp option:selected').val(Tipo_Emp_id);
                $('#sueldo_base').val(sueldo_base);
                $('#user').val(usuarios);
                $('#pass').val(pass);
                
               
            });
        };
    });
}








