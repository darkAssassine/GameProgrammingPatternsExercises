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
            Console.Write($"{layout.Header}{body}{layout.Ad}{layout.Author}Page {PageNumber}{layout.End}");
        }
    }
}
