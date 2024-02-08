using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SDH_BlazorTraining.Models
{
    [Table("Tbl_Blog")]
    public class BlogDataModel
    {
        [Key]
        public int Blog_Id { get; set; }
        public String Blog_Title { get; set; }
        public String Blog_Author { get; set; }
        public String Blog_Content { get; set; }

    }

    public enum EnumResponseType
    {
        None,
        Success,
        Information,
        Warning,
        Error
    }

    public class ResponseModel
    {
        public ResponseModel()
        {
        }

        public ResponseModel(string respCode, string respDesp, EnumResponseType respType)
        {
            RespCode = respCode;
            RespDesp = respDesp;
            RespType = respType;
        }

        public string RespCode { get; set; }
        public string RespDesp { get; set; }
        public EnumResponseType RespType { get; set; }
    }

    public class BaseSubResponseModel
    {
        public ResponseModel Response { get; set; }

    }
}
