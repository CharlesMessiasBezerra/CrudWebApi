using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Usuario.Common.DTO.UsuarioContext;
using Usuario.Domain.UsuarioContext;
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

            var dto = query.Select(x => new UsuarioDto
            {

                Id = x.Id,
                Nome = x.Nome,
                Idade = x.Idade,
            }).FirstOrDefault();



            return dto;
        }


        public List<UsuarioDto> GetAll()
        {
            var query = _uow.UsuarioRepository.GetAll();

            var dto = query.Select(x => new UsuarioDto
            {
                Id = x.Id,
                Nome = x.Nome,
                Idade = x.Idade,
                Sexo = x.Sexo,
                IdCidade = x.IdCidade
            }).ToList();


            return dto;
        }

        public void Update(UsuarioDto dto, int id)
        {
            var query = _uow.UsuarioRepository.GetById(id);

            var aluno = query.FirstOrDefault();

            aluno.Idade = dto.Idade;            
            _uow.Commit();

        }

        public void Delete(int id)
        {
            var query = _uow.UsuarioRepository.GetById(id);
            var usuario = query.FirstOrDefault();

         _uow.UsuarioRepository.Delete(usuario);
            _uow.Commit();

        }

        public void Insert(UsuarioDto dto)
        {
            var usuariodb = new UsuarioDB
            {
                Nome = dto.Nome,
                Idade = dto.Idade,
                Sexo = dto.Sexo,
                IdCidade = dto.IdCidade
            };

            _uow.UsuarioRepository.Add(usuariodb);
            _uow.Commit();

        }
    }
}
