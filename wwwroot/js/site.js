// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
     

function VerDetalleRopa(idRopa)
{
    var desc=$("#DescripcionOculta_"+idRopa).html();
    $("#descripcionRopa").html(desc);
}



function AgregarMeGusta(pIdRopa) {
    $.ajax({
        type: 'POST',
        dataType: 'JSON',
        url: 'AgregarMeGustaAjax',
        data: { idRopa: pIdRopa },
        success: function(response) {
            
            $("#CantidadLikes_"+pIdRopa).html("❤ " + response);
        }
    })    
}

function EliminarJugador(pIdRopa) {
    $.ajax({
        type: 'POST',
        dataType: 'JSON',
        url: '/Home/EliminarPrenda',
        data: { idRopa: pIdRopa },
        success: function(response) {
            $("#EliminarPrenda")
        }
    })    
}
