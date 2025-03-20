using Eveent_.Context;
using Eveent_.Domains;
using Eveent_.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Eveent_.Repositories
{
    public class PresencaRepository : IPresencaRepository
    {
        private readonly Eveent_Context? _context;

        public PresencaRepository(Eveent_Context? context)
        {
            _context = context;
        }
        public void Atualizar(Guid id, Presenca presenca)
        {
            try
            {
                Presenca presencaBuscado = _context?.Presenca.Find(id)!;

                if (presencaBuscado != null)
                {
                    presencaBuscado.IdPresenca = presencaBuscado.IdPresenca;
                }
                _context?.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Presenca BuscarPorId(Guid id)
        {
            try
            {
                Presenca presencaBusacado = _context?.Presenca.Find(id)!;
                if (presencaBusacado != null)
                {
                    return presencaBusacado;
                }
                return null!;
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
                Presenca presencaBuscado = _context?.Presenca.Find(id)!;
                if(presencaBuscado != null)
                {
                    _context?.Presenca.Remove(presencaBuscado);
                }
                _context?.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Inscrever(Presenca inscricao)
        {
            try
            {
                _context?.Presenca.Add(inscricao);
            
                _context?.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Presenca> Listar()
        {
            try
            {
                List<Presenca> listaPresencas = _context?.Presenca.ToList()!;

                return listaPresencas;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Presenca> ListarMinhas(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
