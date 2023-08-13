using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;


 namespace BlogApi.Utils
{
    
    public class SuccesResponse
    {   
 

        public string Code { get; set; }
    
        public string Message { get; set; }
   
        public object Response { get; set; }
    
         public Boolean Status { get; set; }

    }
}