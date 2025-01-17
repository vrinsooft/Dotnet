﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SafiCodeAPI.Business
{
    public class APIResponse
    {

        public enum StatusCodeMessage
        {
            OK = 200,
            Bad_Request = 400,
            Unauthorized = 401,
            Forbidden = 403,
            Not_Found = 404,
            Method_Not_Allowed = 405,
            No_Data_Found = 406,
            Request_Timeout = 408,
            Request_Rejected = 500,
            Signature_Not_Match = 901,
            Missing_Parameters = 902,
            Empty_Mandatory_Parameters = 903,
            SOMETHING_WENT_WRONG = 900,
            Code_Not_Match = 904,
            Code_Expired = 908,
            Token_Invalid = 905,
            Email_Already_Exist = 906,
            Wrong_Old_Password = 907,
            Wrong_Credentials = 909,
            Wrong_ReferalCode = 910,
            Deactive_Account = 911
        }


        public static object ResponseFormate(object ResponseObject,int ResponseCode,string ResponseMessage="")
        {

            return new
            {
                ResponseCode,
                ResponseObject,
                ResponseMessage
            };
        }


       
    }
}
