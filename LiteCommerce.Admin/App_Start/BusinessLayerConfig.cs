﻿using LiteCommerce.BusinessLayers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace LiteCommerce.Admin
{
    public class BusinessLayerConfig
    {
        public static void Init()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["LiteCommerce"].ConnectionString;
            //TODO khởi tạo các BLL khi sử dụng đến 
            CataLogBLL.Initialize(connectionString);
            UserAccountBLL.Initialize(connectionString);
            DashboardBLL.Initialize(connectionString);
        }
    }
}