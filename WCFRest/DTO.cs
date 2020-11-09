using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFRest
{
    //[DataContract(IsReference = true)]
    public class PostTypeDTO
    {
        [DataMember]
        public short PostTypeID { get; set; }
        [DataMember]
        public string PostTypeName { get; set; }
    }

   // [DataContract(IsReference = true)]
    public class PostDTO
    {
        [DataMember]
        public int PostID {get; set; }

    [DataMember]
        public string PostHeader { get; set; }

        [DataMember]
        public string PostText { get; set; }

        [DataMember]
        public short PostTypeID { get; set; }

    }


}