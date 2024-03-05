

namespace DMP.Model
{
    public class EntityBase
    {
        public Guid Id { get; set; }
        public Guid CreaterId { get; set; }
        public string CreaterName { get; set; }

        public DateTime CreaterTime { get; set; }

        public Guid ModifiedId { get; set; }

        public string ModifiedName { get; set; }

        public DateTime ModifiedTime { get; set; }
    }
}
