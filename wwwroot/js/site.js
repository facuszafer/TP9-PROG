// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function VerDetalle(pPrecio) {
    $.ajax({
        type: 'POST',
        dataType: 'JSON',
        url: 'VerDetallePrecioAjax',
        data: {precio: pPrecio},
        success: function(response) {
            $("#precioMarca").html(pPrecio);
        }
    })
    
}


function AgregarMeGusta(pIdRopa) {
    $.ajax({
        type: 'POST',
        dataType: 'JSON',
        url: 'AgregarMeGustaAjax',
        data: { idRopa: pIdRopa },
        success: function(response) {
            $("#CantidadLikes").html(response);
        }
    })    
}


