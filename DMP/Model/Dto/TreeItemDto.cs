using Microsoft.AspNetCore.Components;

namespace DMP.Model.Dto
{
    public class TreeItemDto
    {
        public string Text { get; set; }
        public string Icon { get; set; }
        public string CssClass { get; set; }
        public bool CheckedState { get; set; }
        public bool IsDisable { get; set; }
        public bool IsExpand { get; set; }
        public bool HasChildren { get; set; }
        public bool ShowLoading { get; set; }
        public RenderFragment Template { get; set; }
        public List<TreeItemDto> Items { get; set; }
    }
}
