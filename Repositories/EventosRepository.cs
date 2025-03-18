using Eveent_.Context;
using Eveent_.Domains;
using Eveent_.Interfaces;

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
                    eventobuscado.IdTipoEventos = evento.IdTipoEventos;
                    eventobuscado.IdInstituicao = evento.IdInstituicao;
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
            throw new NotImplementedException();
        }

        public List<Eventos> Listar()
        {
            throw new NotImplementedException();
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
