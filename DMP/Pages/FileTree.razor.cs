using BootstrapBlazor.Components;
using DMP.Model.Dto;
using DMP.Service.IService;
using Microsoft.AspNetCore.Components;

namespace DMP.Pages
{
    public partial class FileTree 
    {
        private readonly IDocNodeService _nodeService;

        //private static List<TreeViewItem<TreeItemDto>> GetIconItems()
        //{
        //    return GetDocNodeList("");
        //}

        public string searchValue = string.Empty;

        public FileTree()
        {

        }

        public FileTree(IDocNodeService docNodeService)
        {
            _nodeService = docNodeService;
        }

        public static List<TreeViewItem<TreeItemDto>> GetDocNodeList(string path)
        {
            List<DocNodeDto> res = new List<DocNodeDto>();
            DirectoryInfo theFolder = new DirectoryInfo(path);
            var docNode = new DocNodeDto(theFolder.Name);
            docNode.FilePath = path;
            List<DocNodeDto> childrenNodes = new List<DocNodeDto>();
            foreach (FileInfo file in theFolder.GetFiles())
            {
                childrenNodes.Add(new DocNodeDto(file.Name, file.Extension.Replace(".", ""), file.FullName));
            }

            foreach (DirectoryInfo folder in theFolder.GetDirectories())
            {
                childrenNodes.AddRange(GetDocNodeList(folder.FullName));
            }
            docNode.Children = childrenNodes;
            res.Add(docNode);
            return res;
        }
    }
}
