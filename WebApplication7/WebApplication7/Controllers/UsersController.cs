
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using WebApplication7.Models;

    namespace WebApplication7.Controllers
    {
        public class UsersController : Controller
        {
            // 模擬資料，用來模擬從資料庫中獲取的用戶資料
            private static readonly List<User> Users = new List<User>
        {
            new User { Id = 1, Name = "張三", Age = 25 },
            new User { Id = 2, Name = "李四", Age = 30 },
            new User { Id = 3, Name = "王五", Age = 28 }
        };

            // GET: /Users
            public IActionResult Index()
            {
                return View(Users);  // 傳遞用戶資料到視圖
            }
        }
    }


