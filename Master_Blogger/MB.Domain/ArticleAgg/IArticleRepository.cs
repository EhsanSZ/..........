using System.Collections.Generic;
using MB.Application.Contracts.Article;

namespace MB.Domain.ArticleAgg
{
    public interface IArticleRepository /*: IRepository<long, Article>*/
    {
        List<ArticleViewModel> GetList();
        void CreateAndSave(Article entity);
    }
}