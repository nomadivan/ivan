

var builder = WebApplication.CreateBuilder(args);

// 添加 MVC 服務 
//builder.Services 中配置應用所需的服務。這是為應用程式注入所需功能（如資料庫、身份驗證、MVC 等）的地方。
// 例如，配置 MVC 服務：
//builder.Services.AddControllersWithViews(); // 添加 MVC 服務（包括控制器和視圖）
//其他常見的服務配置還包括：
//註冊資料庫上下文（AddDbContext）
//註冊身份驗證（AddAuthentication）
//註冊自定義服務（AddScoped, AddSingleton）

builder.Services.AddControllersWithViews();

/*app 物件在這裡配置應用程式的請求處理管道。中介軟件是處理進入請求和返回結果的組件。例如：
請求路由
身份驗證和授權
錯誤處理
靜態文件服務
請求日誌記錄
跨域資源共享（CORS）設定*/
var app = builder.Build();

// 使用路由中間件
app.UseRouting();

// 設定首頁的路由為 "Users/Index"
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Users}/{action=Index}/{id?}"); //默認控制器是usercontroll,默認動作是index

// 啟動應用
app.Run();
