using BelMob.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Core.Entidades
{
    public class Usuario
    {

        public Usuario() { }
        public Usuario(string nome, string sobrenome, string email, string passWord, TipoUsuario tipo)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            PassWord = passWord;
            Tipo = tipo;
            Enderecos = new List<Endereco>();
        }

        [Key]
        public int Id { get; set; }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Email { get; private set; }
        public string PassWord { get; private set; }
        public TipoUsuario Tipo { get; private set; }
        public IList<Endereco> Enderecos { get; private set;}


        public void AdicionarEndereco(Endereco endereco)
        {
            Enderecos.Add(endereco);
        }

    }
}
