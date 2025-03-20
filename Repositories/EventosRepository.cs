using Eveent_.Context;
using Eveent_.Domains;
using Eveent_.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Eveent_.Repositories
{
    public class EventosRepository : IEventosRepository
    {
        private readonly Eveent_Context? _context;
        public void Atualizar(Guid id, Eventos evento)
        {
            try
            {
                Eventos eventobuscado = _context?.Eventos.Find(id)!;

                if (eventobuscado != null)
                {
                    eventobuscado.TituloDeEventos = evento.TituloDeEventos;
                    eventobuscado.Descricao = evento.Descricao;
                    eventobuscado.DataEvento = evento.DataEvento;
                    eventobuscado.IdTipoEventos = evento.IdTipoEventos;
                }
                _context?.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Eventos BuscarPorId(Guid id)
        {
            try
            {
                Eventos eventoBuscado = _context.Eventos.Find(id)!;
                if (eventoBuscado != null) {
                    return eventoBuscado;
                }
                return null!;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(Eventos evento)
        {
            try
            {
                _context?.Eventos.Add(evento);

                _context?.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            try
            {
                Eventos eventoBuscado = _context?.Eventos.Find(id)!;
                if (eventoBuscado != null)
                {
                    _context?.Eventos.Remove(eventoBuscado);
                }
                _context?.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Eventos> Listar()
        {
            try
            {
                List<Eventos> listaEventos = _context?.Eventos.ToList()!;

                return listaEventos;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Eventos> ListarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Eventos> ListarProximosEventos()
        {
            throw new NotImplementedException();
        }
    }
}
