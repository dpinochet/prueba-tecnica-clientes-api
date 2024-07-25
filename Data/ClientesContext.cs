using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using ClientesAPI.Models;
using MySqlConnector;

namespace ClientesAPI.Data
{
    public class ClientesContext : DbContext
    {
        public ClientesContext(DbContextOptions<ClientesContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }

        public async Task<List<Cliente>> GetClientesPaginados(int pageNumber, int pageSize)
        {
            var pageNumberParameter = new MySqlParameter("@PageNumber", pageNumber);
            var pageSizeParameter = new MySqlParameter("@PageSize", pageSize);

            return await Clientes.FromSqlRaw("CALL GetClientesPaginados(@PageNumber, @PageSize)", pageNumberParameter, pageSizeParameter).ToListAsync();
        }
    }
}
