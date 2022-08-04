using BelMob.Core.DTOs.Response;
using BelMob.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Core.Mapper
{
    public static class UsuarioMapper
    {

        public static UsuarioResponse From(Usuario usuario)
        {
            var dto = new UsuarioResponse();
            dto.Id = usuario.Id;
            dto.Name = usuario.Nome;

            if (usuario.Enderecos != null)
                dto.Enderecos = usuario.Enderecos.Select(c => EnderecoMapper.From(c)).ToList();


            return dto;

        }

    }
}
