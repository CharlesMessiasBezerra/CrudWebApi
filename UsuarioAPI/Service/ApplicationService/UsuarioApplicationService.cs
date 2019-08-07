using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Usuario.Common.DTO.UsuarioContext;
using Usuario.Infrastructure;
using Usuario.Infrastructure.UnitOfWork.Usuario;


namespace Usuario.Service.ApplicationService
{
    public class UsuarioApplicationService
    {

        private readonly UsuarioUnitOfWork _uow;

        public UsuarioApplicationService(UsuarioUnitOfWork uow)
        {

            _uow = uow;
        }

        public UsuarioDto GetById(int id)
        {
            var query = _uow.UsuarioRepository.GetById(id);

            var dto = query.Select(x => new UsuarioDto{

                Id = x.Id,
                Nome = x.Nome,                
             }).FirstOrDefault();

            return dto;
    }


        }
    }
