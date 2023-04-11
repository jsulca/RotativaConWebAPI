using Microsoft.AspNetCore.Mvc;
using Rotativa.AspNetCore;

namespace RotativaConWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReporteController : ControllerBase
    {
        [HttpGet("factura")]
        public async Task<IActionResult> Factura()
        {
            ViewAsPdf vista = new("~/Views/Reporte/Boleta.cshtml");
            byte[] datos = await vista.BuildFile(ControllerContext);
            
            return new FileContentResult(datos, "application/pdf")
            {
                FileDownloadName = "Boleta.pdf"
            };
        }

    }
}
