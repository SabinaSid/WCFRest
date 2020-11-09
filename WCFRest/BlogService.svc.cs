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
        public int AddPost(string postHeader, string postText, string postTypeId)
        {
            var datacontext = new DataClassesDataContext();
            var p = new Post();
            p.PostHeader = postHeader;
            p.PostText = postText;
            p.PostTypeID = Int16.Parse(postTypeId);
            datacontext.Post.InsertOnSubmit(p);
            datacontext.SubmitChanges();
            return p.PostID;
        }

        public int AddPostType(string postTypeName)
        {
            var datacontext = new DataClassesDataContext();
            var pt = new PostType();
            pt.PostTypeName = postTypeName;
            datacontext.PostType.InsertOnSubmit(pt);
            datacontext.SubmitChanges();
            return pt.PostTypeID;

        }

        public int DeletePost(string postId)
        {
            var datacontext = new DataClassesDataContext();
            var p = datacontext.Post.FirstOrDefault(x => x.PostTypeID.ToString() == postId);
            datacontext.Post.DeleteOnSubmit(p);
            datacontext.SubmitChanges();
            return p.PostID;
        }

        public void DeletePostType(string postTypeId)
        {
            var datacontext = new DataClassesDataContext();
            var pt = datacontext.PostType.FirstOrDefault(x => x.PostTypeID.ToString() == postTypeId);
            datacontext.PostType.DeleteOnSubmit(pt);
            datacontext.SubmitChanges();
        }

        public PostDTO GetPost(string postId)
        {
            using (var datacontext = new DataClassesDataContext())
            {
                var p = datacontext.Post.FirstOrDefault(x => x.PostID.ToString() == postId);
                return new PostDTO() { PostID = p.PostID, PostHeader=p.PostHeader,PostText=p.PostText,PostTypeID=p.PostTypeID };
            }
 
        }

        public IEnumerable<PostDTO> GetPosts()
        {
            using (var datacontext = new DataClassesDataContext())
            {
                var lst = new List<PostDTO>();
                foreach (var p in datacontext.Post)
                {
                    lst.Add(new PostDTO() { PostID = p.PostID, PostHeader = p.PostHeader, PostText = p.PostText, PostTypeID = p.PostTypeID });
                }
                return lst;
            }
            
        }

        public PostTypeDTO GetPostType(string postTypeId)
        {
            using (var datacontext = new DataClassesDataContext())
            {
                var pt = datacontext.PostType.FirstOrDefault(x => x.PostTypeID.ToString() == postTypeId);
                return new PostTypeDTO() { PostTypeID = pt.PostTypeID, PostTypeName = pt.PostTypeName };
            }

        }

        public IEnumerable<PostTypeDTO> GetPostTypes()
        {
            using (var datacontext = new DataClassesDataContext())
            {
                var lst = new List<PostTypeDTO>();
                foreach (var pt in datacontext.PostType)
                    lst.Add(new PostTypeDTO() { PostTypeID = pt.PostTypeID, PostTypeName = pt.PostTypeName });
                return lst;
            }
        }

        public int UpdatePost(string postId, string postHeader, string postText, string postTypeId)
        {
            var datacontext = new DataClassesDataContext();
            var p = datacontext.Post.FirstOrDefault(x => x.PostID.ToString() == postId);
            p.PostHeader = postHeader;
            p.PostText = postText;
            p.PostTypeID = Int16.Parse(postTypeId);
            datacontext.SubmitChanges();
            return p.PostID;
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
