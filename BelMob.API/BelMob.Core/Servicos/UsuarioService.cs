using BelMob.Core.DTOs.Request;
using BelMob.Core.DTOs.Response;
using BelMob.Core.Entidades;
using BelMob.Core.Interfaces.Repositorios;
using BelMob.Core.Interfaces.Servicos;
using BelMob.Core.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Core.Servicos
{
    public class UsuarioService : IUsuarioService
    {
        private IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public void Cadastrar(CadastroUsuarioRequest usuario)
        {
            var user = new Usuario(usuario.Nome, usuario.Sobrenome, usuario.Email, usuario.PassWord, usuario.Tipo);

            var endereco = new Endereco(usuario.Rua, usuario.Cep, usuario.Numero, usuario.Complemento, Enums.TipoEndereco.Residencial, user);

            user.AdicionarEndereco(endereco);

            _usuarioRepository.Create(user);
        }

        public List<UsuarioResponse> Listar()
        {
            var list = _usuarioRepository.GetAll();

            return list.Select(c => UsuarioMapper.From(c)).ToList();
        }
    }
}
