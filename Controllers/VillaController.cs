using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApiPruebaPuntoNET.Modelos;
using ApiPruebaPuntoNET.Modelos.Dto;
using ApiPruebaPuntoNET.Datos;

namespace ApiPruebaPuntoNET.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VillaController : ControllerBase
    {

        [HttpGet]
        public ActionResult <IEnumerable<VillaDto>>GetVillas()//ActionResult espara usar Estados (Codigos [400,200,404,500,505,501])
        {
            
           return Ok(VillaStore.villaList); //Codigo 200 = ok, todo chido.
        }

        [HttpGet("id")]
        public ActionResult <VillaDto> GetVillaDto(int id) //Obtener datos mediante Json
        {

            if(id==0)
            {
                return BadRequest();
            }
            var villa=VillaStore.villaList.FirstOrDefault(v=> v.Id==id);
            
            if(villa==null)
            {
                return NotFound();
            }
            return Ok(villa);
        }
    }
}