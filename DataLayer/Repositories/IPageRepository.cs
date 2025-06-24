using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IPageRepository : IDisposable
    {
        IEnumerable<Page> GetAllPages();
        Page GetPageById(int pageId);
        bool InsertPage(Page page);
        bool UpdatePage(Page page);
        bool DeletePage(Page page);
        bool DeletePage(int pageId);
        void Save();

        IEnumerable<Page> TopNews(int take = 3);
        IEnumerable<Page> PagesInSlider();
        IEnumerable<Page> LastNews(int take = 4);
        IEnumerable<Page> LatesNews(int take = 3);
        IEnumerable<Page> ShowPageByGroupId(int groupId);
        IEnumerable<Page> SearchPage(string search);
        IEnumerable<Page> MainNews(int take = 9);
    }
}
