using DMP.Repository.IRepository;
using DMP.Service.IService;

namespace DMP.Service
{
    public class DocNodeService : IDocNodeService
    {
        public readonly IDocNodeRepository _docNodeRepository;

        public DocNodeService(IDocNodeRepository docNodeRepository)
        {
            _docNodeRepository = docNodeRepository;
        }


    }
}
