using BelMob.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Core.Entidades
{
    public class Endereco
    {
        public Endereco() { }
        public Endereco(string rua, string cep, string numero, string complemento, TipoEndereco tipo, Usuario usuario)
        {
            Rua = rua;
            Cep = cep;
            Numero = numero;
            Complemento = complemento;
            Tipo = tipo;
            Usuario = usuario;
        }

        [Key]
        public int Id { get; set; }

        public string Rua { get; private set; }

        public string Cep { get; private set; }

        public string Numero { get; private set; }

        public string Complemento { get; private set; }

        public TipoEndereco Tipo { get; private set; }

        public Usuario Usuario { get; set; }
    }
}
