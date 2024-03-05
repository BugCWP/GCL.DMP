using DMP.Model.Enum;

namespace DMP.Model.Entity
{
    public class DocNodeEntity : EntityBase
    {
        public string Name { get; set; }
        public DocNodeTypeEnum DocNodeType { get; set; }
        public DocFileTypeEnum DocFileType { get; set; }
        public string FilePath { get; set; }

        public Guid ParentDocNodeId { get; set; }

        public string ProjectId { get; set; }
    }
}
