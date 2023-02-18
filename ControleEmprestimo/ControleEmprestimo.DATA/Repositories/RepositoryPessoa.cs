using ControleEmprestimo.DATA.Interfaces;
using ControleEmprestimo.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEmprestimo.DATA.Repositories
{
    public class RepositoryPessoa : RepositoryBase<Pessoa>, IRepositoryPessoa
    {
        public RepositoryPessoa(bool SaveChanges = true) : base(SaveChanges)
        {
             
        }
    }
}
