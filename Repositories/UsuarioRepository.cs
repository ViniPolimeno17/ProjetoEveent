using api_filmes_senai.Domains;
using Eveent_.Context;
using Eveent_.Interfaces;

namespace Eveent_.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly Eveent_Context? _context;
        public Usuarios BuscarPorEmailESenha(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public Usuarios BuscarPorId(Guid id)
        {
            try
            {
                Usuarios usuarioBuscado = _context.Usuarios.Find(id)!;
                if(usuarioBuscado != null)
                {
                    return usuarioBuscado;
                }
                return null!;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(Usuarios novoUsuario)
        {
            try
            {
                //novoUsuario.Senha = Criptografia.GerarHash(novoUsuario.Senha!);

                _context.Usuarios.Add(novoUsuario);

                _context.SaveChanges();

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
 