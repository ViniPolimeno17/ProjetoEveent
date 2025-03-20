using Eveent_.Context;
using Eveent_.Domains;
using Eveent_.Interfaces;

namespace Eveent_.Repositories
{
    public class TipoUsuarioRepository : ITiposUsuariosRepository
    {
        private readonly Eveent_Context? _context;
        public TipoUsuarioRepository(Eveent_Context? context)
        {
            _context = context;
        }
        public void Atualizar(Guid id, TiposUsuarios tiposUsuarios)
        {
            try
            {
                TiposUsuarios tipoUsuarioBuscado = _context?.TiposUsuarios.Find(id)!;

                if (tipoUsuarioBuscado != null)
                {
                    tipoUsuarioBuscado.IdTipoUsuario = tiposUsuarios.IdTipoUsuario;
                }
                _context?.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public TiposUsuarios BuscarPorId(Guid id)
        {
            try
            {
                TiposUsuarios tipoUsuariosBuscado = _context?.TiposUsuarios.Find(id)!;
                if (tipoUsuariosBuscado != null)
                {
                    return tipoUsuariosBuscado;
                }
                return null!;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(TiposUsuarios tiposUsuarios)
        {
            try
            {
                _context?.TiposUsuarios.Add(tiposUsuarios);

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
                TiposUsuarios tipoUsuariosBuscado = _context?.TiposUsuarios.Find(id)!;
                if (tipoUsuariosBuscado != null)
                {
                    _context?.TiposUsuarios.Remove(tipoUsuariosBuscado);
                }
                _context?.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }       

        public List<TiposUsuarios> Listar()
        {
            try
            {
                List<TiposUsuarios> listaTiposUsuarios = _context?.TiposUsuarios.ToList()!;

                return listaTiposUsuarios;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
