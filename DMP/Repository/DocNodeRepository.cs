using DMP.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace DMP.Repository
{
    public class DocNodeRepository : IDocNodeRepository
    {
        private readonly DbContext _dbContext;

        public DocNodeRepository(DMPDbContext dbContext)
        {
            _dbContext = dbContext;
        }


    }
}
