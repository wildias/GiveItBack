using ControleEmprestimo.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEmprestimo.DATA.Services
{
    public class PessoaService
    {
        public RepositoryPessoa oRepositoryPessoa { get; set; }  

        public PessoaService() 
        {
            oRepositoryPessoa = new RepositoryPessoa();
        }
    }

    
}
