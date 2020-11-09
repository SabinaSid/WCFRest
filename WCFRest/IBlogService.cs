using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFRest
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IBlogService" в коде и файле конфигурации.
    [ServiceContract]
    public interface IBlogService
    {
        [OperationContract]
        void DoWork();

        /// <summary>
        /// Метод чтения данных для таблицы PostType
        /// </summary>
        /// <returns>таблица PostType</returns>
        [OperationContract]
        [WebGet(UriTemplate = "/PostTypes", ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<PostType> GetPostTypes();

        /// <summary>
        /// Метод чтения записи в талблице PostType
        /// </summary>
        /// <param name="postTypeId"></param>
        /// <returns>запись из таблицы PostType</returns>
        [OperationContract]
        [WebGet(UriTemplate = "/PostTypes/{postTypeId}", ResponseFormat = WebMessageFormat.Json)]
        PostType GetPostType(string postTypeId);

        /// <summary>
        /// Метод добавления записи в талблице PostType
        /// </summary>
        /// <param name="postTypeId">идентификатор записи</param>
        /// <returns>идентификатор новой записи в таблице PostType</returns>
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/PostTypeAdd/{postTypeName}", ResponseFormat = WebMessageFormat.Json)]
        int AddPostType(string postTypeName);

        /// <summary>
        /// Метод редактирования записи в таблице PostType
        /// </summary>
        /// <param name="postTypeId">идентификатор записи</param>
        /// <param name="postTypeName">новое значение типа поста</param>
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "/PostTypeUpdate/{postTypeId}/{postTypeName}", ResponseFormat = WebMessageFormat.Json)]
        void UpdatePostType(string postTypeId, string postTypeName);

        /// <summary>
        /// Метод удаления записи из таблицы PostType
        /// </summary>
        /// <param name="postTypeId">идентификатор записи</param>
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "/PostTypeDelete/{postTypeId}", ResponseFormat = WebMessageFormat.Json)]
        void DeletePostType(string postTypeId);

        /// <summary>
        /// Метод получения записей из таблицы Post
        /// </summary>
        /// <returns>записи таблицы Post</returns>
        [OperationContract]
        [WebInvoke(Method ="GET",UriTemplate ="/Posts",RequestFormat =WebMessageFormat.Json)]
        IEnumerable<Post> GetPosts();

        /// <summary>
        /// Метод получения записи таблицы Post
        /// </summary>
        /// <param name="postId">идентификатор записи</param>
        /// <returns>запись таблицы Post</returns>
        [OperationContract]
        [WebInvoke(Method ="GET",UriTemplate ="/Posts/{postId}",RequestFormat =WebMessageFormat.Json)]
        Post GetPost(string postId);

        /// <summary>
        /// Метод добавления записи в таблицу Post
        /// </summary>
        /// <param name="postHeader">заголовок поста</param>
        /// <param name="postText">текст поста</param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(Method ="POST",UriTemplate ="/PostAdd/{postHeader}/{postText}",RequestFormat =WebMessageFormat.Json)]
        int AddPost(string postHeader, string postText);

        /// <summary>
        /// Метод редактирования записи в таблице Post
        /// </summary>
        /// <param name="postId">идентификатор записи</param>
        /// <param name="postHeader">заголовок поста</param>
        /// <param name="postText">текст поста</param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(Method ="PUT",UriTemplate ="/PostUpdate/{postId}/{postHeader}/{postText}")]
        int UpdatePost(string postId, string postHeader, string postText);

        /// <summary>
        /// Метод удаления записи в таблице Post
        /// </summary>
        /// <param name="postId">идентификатор записи</param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(Method ="DELETE",UriTemplate ="/PostDelete/{postId}")]
        int DeletePost(string postId);



    }
}
