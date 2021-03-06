using System.Collections.Generic;
using ReallyTinyCms.Core.Model;

namespace ReallyTinyCms.Core.Storage
{
    public interface ICmsContentRepository
    {
        IList<CmsContentItem> RetrieveAll();
        CmsContentItem Retrieve(string contentItemName);
        void SaveOrUpdate(CmsContentItem item);
        void Delete(string contentItemName);

    	bool StorageExists();
    	void CreateStorage();
    }
}