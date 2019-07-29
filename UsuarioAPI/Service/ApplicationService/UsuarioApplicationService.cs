using System;
using System.Collections.Generic;
using System.Text;
using Usuario.Common.DTO.UsuarioContext;
using Usuario.Infrastructure;

namespace Usuario.Service.ApplicationService
{
    public class UsuarioApplicationService
    {

        private readonly UsuarioUnitOfWork _uow;

        public UsuarioApplicationService(UsuarioUnitOfWork uow)
        {
            _uow = uow;
        }

        public void Insert(UsuarioDto dto)
        {                       
            _uow.AlunoRepository.Add(aluno);
            _uow.Commit();
        }


    }
}
