
using App.Datos.Datos;
using App.Repository.Contracts;
using System.Threading.Tasks;


namespace App.Repository
{
    public class Unit : IUnit
    {

        private readonly DatosDbContext _context;
   
        public UserRepository UserRepository { get; private set; }

        public Unit(DatosDbContext  context)
        {

            _context = context;
            UserRepository = new UserRepository(_context);

        }

        public async Task Commit()
        {

          await  _context.SaveChangesAsync();

        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
