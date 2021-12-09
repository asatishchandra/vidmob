using Newtonsoft.Json;
using System.Collections.Generic;


namespace VidMob.Models
{
    public class Response<T> where T : class
    {
        public T Data { get; set; }
        public Status Status { get; set; }
    }

    public class Status
    {
        public Status(int code = 0, bool sucess = false, string message = "", string returnUrl = "")
        {
            StatusCode = code;
            Success = sucess;
            ErrorMessage = message;
            ReturnUrl = returnUrl;
        }
        public int StatusCode { get; set; }
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public string ReturnUrl { get; set; }
        public override string ToString() => ExtenstionMethods.ToExtJsJsonItem(this);
    }

    public static class ExtenstionMethods
    {
        public static string ToExtJsJsonItem(this object item) => JsonConvert.SerializeObject(item);
    }
}
