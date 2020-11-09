using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFRest
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "BlogService" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы BlogService.svc или BlogService.svc.cs в обозревателе решений и начните отладку.
    public class BlogService : IBlogService
    {
        public int AddPostType(string postTypeName)
        {
            var datacontext = new DataClassesDataContext();
            var pt = new PostType();
            pt.PostTypeName = postTypeName;
            datacontext.PostType.InsertOnSubmit(pt);
            datacontext.SubmitChanges();
            return pt.PostTypeID;

        }

        public void DeletePostType(string postTypeId)
        {
            var datacontext = new DataClassesDataContext();
            var pt = datacontext.PostType.FirstOrDefault(x => x.PostTypeID.ToString() == postTypeId);
            datacontext.PostType.DeleteOnSubmit(pt);
            datacontext.SubmitChanges();
        }

        public void DoWork()
        {
        }

        public PostType GetPostType(string postTypeId)
        {
            var datacontext = new DataClassesDataContext();
            return datacontext.PostType.FirstOrDefault(x => x.PostTypeID.ToString() == postTypeId);

        }

        public IEnumerable<PostType> GetPostTypes()
        {
            var datacontext = new DataClassesDataContext();
            return datacontext.PostType.AsEnumerable();

        }

        public void UpdatePostType(string postTypeId, string postTypeName)
        {
            var datacontext = new DataClassesDataContext();
            var pt = datacontext.PostType.FirstOrDefault(x => x.PostTypeID.ToString() == postTypeId);
            pt.PostTypeName = postTypeName;
            datacontext.SubmitChanges();
        }
    }
}
