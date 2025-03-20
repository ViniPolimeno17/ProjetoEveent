using Eveent_.Context;
using Eveent_.Domains;
using Eveent_.Interfaces;

namespace Eveent_.Repositories
{
    public class ComentarioEventosRepository : IComentarioEventosRepository
    {
        private readonly Eveent_Context? _context;
        public ComentarioEvento BuscarPorIdUsuario(Guid idUsuario, Guid IdEventos)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(ComentarioEvento comentarioEvento)
        {
            try
            {
                _context?.ComentarioEvento.Add(comentarioEvento);

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

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ComentarioEvento> Listar(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
