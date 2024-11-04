// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


        // Actualizar la etiqueta del input de archivo
document.querySelector('#inputGroupFile02').addEventListener('change', function (e) {
            var fileName = e.target.files[0].name;
    var nextSibling = e.target.nextElementSibling;
    nextSibling.innerText = fileName;

    // Leer el archivo y mostrar la vista previa
    var reader = new FileReader();
    reader.onload = function (event) {
                var img = document.getElementById('preview');
    img.src = event.target.result; // Establece la fuente de la imagen
    img.style.display = 'block'; // Muestra la imagen
            }
    reader.readAsDataURL(e.target.files[0]); // Lee el archivo como una URL de datos
        });

