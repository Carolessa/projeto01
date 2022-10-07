using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Entities
{
    public class Pessoa
    {
        #region Propriedades

        public Guid Id { get; set; }
        public String Nome { get; set; }
        public DateTime DataNascimento  { get; set; }

        #endregion
    }
}
