using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiPruebaPuntoNET.Modelos.Dto;

namespace ApiPruebaPuntoNET.Datos
{
    public static class VillaStore
    {
        public static List<VillaDto>villaList= new List<VillaDto>
        {
            new VillaDto{Id=1,Nombre="Vista a la Piscina"},
            new VillaDto{Id=2,Nombre="Vista a la Playa"}
        };
    }
}