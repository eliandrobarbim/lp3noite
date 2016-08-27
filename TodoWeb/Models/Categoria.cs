using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoWeb.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }

        #region Chave Estrangeira
        //Chave Estrangeira - Region - oculta o código
        public int UsuarioId { get; set; }
        #endregion
    }
}