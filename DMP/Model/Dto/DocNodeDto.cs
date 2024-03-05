namespace DMP.Model.Dto
{
    public class DocNodeDto
    {
        public string FileType { get; set; }

        public string Name { get; set; }

        public string FilePath { get; set; }

        public List<DocNodeDto> Children { get; set; }

        public DocNodeDto(string name)
        {
            Name = name;
        }

        public DocNodeDto(string name, string file)
        {
            Name = name;
            FileType = file;
        }

        public DocNodeDto(string name, string file, string path)
        {
            Name = name;
            FileType = file;
            FilePath = path;
        }

        public DocNodeDto(string name, List<DocNodeDto> children)
        {
            Name = name;
            Children = children;
        }
    }
}
