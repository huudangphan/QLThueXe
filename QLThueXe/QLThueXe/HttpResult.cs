using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace QLThueXe
{
    public class HttpResult
    {
        public int msgCode { get; set; }
        public object content { get; set; }
        
        public HttpResult()
        {
        }
        public HttpResult(int msgCode) 
        {
            this.msgCode = msgCode;        
        }
        public HttpResult(object content) 
        {           
            this.content = content;
        }
      
    }
}
