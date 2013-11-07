using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public static class Messages
    {
        /*=================数据库访问消息===================*/
        public const int MSG_CONNECT_SERVER_START = 10000;
        public const int MSG_CONNECT_SERVER_SUCCESS = 10001;
        public const int MSG_CONNECT_SERVER_FAIL = 10002;

        public const int MSG_GET_SN_START = 10003;
        public const int MSG_GET_SN_SUCCESS = 10004;
        public const int MSG_GET_SN_FAIL = 10005;

        public const int MSG_GET_PRODUCT_START = 10006;
        public const int MSG_GET_PRODUCT_SUCCESS = 10007;
        public const int MSG_GET_PRODUCT_FAIL = 10008;

        public const int MSG_SET_PRODUCT_START = 10009;
        public const int MSG_SET_PRODUCT_SUCCESS = 10010;
        public const int MSG_SET_PRODUCT_FAIL = 10011;

        public const int MSG_SET_SN_FLAG_START = 10012;
        public const int MSG_SET_SN_FLAG_SUCCESS = 10013;
        public const int MSG_SET_SN_FLAG_FAIL = 10014;


        /*======================SN操作消息====================*/
        public const int MSG_WRITE_SN_START = 10014;
        public const int MSG_WRITE_SN_STATE_CHANGE = 10015;
        public const int MSG_WRITE_SN_SUCCESS = 10016;
        public const int MSG_WRITE_SN_FAIL = 10017;
        public const int MSG_READ_SN_START = 10018;
        public const int MSG_READ_SN_STATE_CHANGE = 10019;
        public const int MSG_READ_SN_SUCCESS = 10020;
        public const int MSG_READ_SN_FAIL = 10021;


        public const int MSG_EXIT = 10022;
        public const int MSG_UPDATE_UI = 10023;
        public const int MSG_UPDATE_DEVICE_COUNT = 1024;

        public const int MSG_GET_SN_STATUS_START = 10025;
        public const int MSG_GET_SN_STATUS_FAIL = 10026;
        public const int MSG_GET_SN_STATUS_SUCCESS = 1027;

        public const int MSG_GET_ULPK_START = 10028;
        public const int MSG_GET_ULPK_FAIL = 10029;
        public const int MSG_GET_ULPK_SUCCESS = 1030;


        public const int MSG_RETRY_SCAN = 1031;
    
    }
}
