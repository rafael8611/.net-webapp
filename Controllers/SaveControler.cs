using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class SaveController : Controller
    {
      private readonly BlobStorageService _blobStorageService;
        
        public SaveController(BlobStorageService blobStorageService)
        {
            _blobStorageService = blobStorageService;

        }

        [HttpPost]
        public async Task<IActionResult> Post(ModelPost post)
        {
            if (!string.IsNullOrEmpty(post.Imagen.FileName))
            {
                // Crear un flujo de memoria para el archivo
                
                {
                   

                    // Llamar al servicio para subir la imagen
                 //   var imageUrl = await _blobStorageService.UploadImageAsync(post.Imagen.FileName);

                    // Aquí puedes redirigir a otra acción o mostrar un mensaje de éxito
                    return RedirectToAction("Index", "Home"); ; // Suponiendo que tengas un método Index que maneje la vista
                }
            }

                return RedirectToAction("Index", "Home");
            }
        }



    }

