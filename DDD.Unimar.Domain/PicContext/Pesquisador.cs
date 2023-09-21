using DDD.Unimar.Domain.UserManagementContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Unimar.Domain.PicContext
{
    public class Pesquisador : User
    {
        public string Titulacao { get; set; }
        public IList<Projeto> Projetos { get; set; }
    }
}
