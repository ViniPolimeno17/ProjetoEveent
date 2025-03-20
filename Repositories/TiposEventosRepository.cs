using Eveent_.Context;
using Eveent_.Domains;
using Eveent_.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Eveent_.Repositories
{
    public class TiposEventosRepository : ITiposEventosRepository
    {
        private readonly Eveent_Context? _context;

        public TiposEventosRepository(Eveent_Context? context)
        {
            _context = context;
        }

        public void Atualizar(Guid id, TiposEventos tiposEventos)
        {
            try
            {
                TiposEventos tipoDeEventoBuscado = _context?.TiposEventos.Find(id)!;

                if (tipoDeEventoBuscado != null)
                {
                    tipoDeEventoBuscado.IdTipoEventos = tiposEventos.IdTipoEventos;
                }
                _context?.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    

        public TiposEventos BuscarPorId(Guid id)
        {
            try
            {
                TiposEventos tipoEventosBuscado = _context?.TiposEventos.Find(id)!;
                if (tipoEventosBuscado != null)
                {
                    return tipoEventosBuscado;
                }
                return null!;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(TiposEventos tiposEventos)
        {
            try
            {
                _context?.TiposEventos.Add(tiposEventos);

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
                TiposEventos TipoBuscado = _context?.TiposEventos.Find(id)!;
                if (TipoBuscado != null)
                {
                    _context?.TiposEventos.Remove(TipoBuscado);
                }
                _context?.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TiposEventos> Listar()
        {
            try
            {
                List<TiposEventos> listaTiposEventos = _context?.TiposEventos.ToList()!;

                return listaTiposEventos;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
