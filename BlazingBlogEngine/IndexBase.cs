using Microsoft.AspNetCore.Components;

namespace BlazingBlogEngine
{
    public class IndexBase : LayoutComponentBase
    {
        public string GetTextFromMethodInClass()
        {
            return "This text is derived from a C# .cs file within the assembly";
        }
    }
}