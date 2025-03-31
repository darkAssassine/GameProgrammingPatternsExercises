using System.Diagnostics;

namespace FlyweightPattern
{
    internal class Page
    {
        private PageLayout layout;
        private string body;
        public readonly int PageNumber;
        public Page(PageLayout _layout, string _body, int _pageNumber)
        {
            layout = _layout;
            body = _body;
            PageNumber = _pageNumber;
        }

        public void Print()
        {
            Debug.Write($"{layout.Header}{body}{layout.Author}{layout.Ad}{PageNumber}{layout.End}");
        }
    }
}
