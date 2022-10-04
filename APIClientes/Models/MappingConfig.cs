using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIClientes.Models
{
    public class MappingConfig
    {

        //aqui se va a relacionar los dto con los modelos

        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ClienteDto, Cliente>();
                config.CreateMap<Cliente, ClienteDto>();
            });

            return mappingConfig;
        }
        //una vez realizado debo inyectar por dependencia en el startup.cs
    }
}
