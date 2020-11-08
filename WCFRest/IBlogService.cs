using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
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
        IEnumerable<PostType> GetPostTypes();

        /// <summary>
        /// Метод чтения записи в талблице PostType
        /// </summary>
        /// <param name="postTypeId"></param>
        /// <returns>запись из таблицы PostType</returns>
        [OperationContract]
        IEnumerable<PostType> GetPostType(string postTypeId);

        /// <summary>
        /// Метод добавления записи в талблице PostType
        /// </summary>
        /// <param name="postTypeId">идентификатор записи</param>
        /// <returns>идентификатор новой записи в таблице PostType</returns>
        [OperationContract]
        int AddPostType(string postTypeName);

        /// <summary>
        /// Метод редактирования записи в таблице PostType
        /// </summary>
        /// <param name="postTypeId">идентификатор записи</param>
        /// <param name="postTypeName">новое значение типа поста</param>
        [OperationContract]
        void UpdatePostType(string postTypeId, string postTypeName);

        /// <summary>
        /// Метод удаления записи из таблицы PostType
        /// </summary>
        /// <param name="postTypeId">идентификатор записи</param>
        [OperationContract]
        void DeletePostType(string postTypeId);



    }
}
