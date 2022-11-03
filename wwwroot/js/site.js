// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function VerDetalle(pDescripcion) {
    
    $("#descripcionMarca").html(pDescripcion);
}
function AgregarMeGusta(pIdRopa) {
    $.ajax({
        type: 'POST',
        dataType: 'JSON',
        url: 'Home/AgregarMeGustaAjax',
        data: { idRopa: pIdRopa },
        success: function(response) {
            $("#CantidadLikes").html(response);
        }
    })    
}


