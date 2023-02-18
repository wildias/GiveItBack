using ControleEmprestimo.DATA.Interfaces;
using ControleEmprestimo.DATA.Models;    
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEmprestimo.DATA.Repositories
{
    public class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto
    {
        public RepositoryProduto(bool SaveChanges = true) : base(SaveChanges) 
        {
            
        }
    }
}
