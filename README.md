###EInvoice Service Side & Client
-------------------
>此專案為依據《電子發票辦理辦法》實作法規所刊載應實作功能。


####Einvorment:
+   ASP.Net MVC(.Net Core 2.2)
+   UWP(Windows 10-Build 1803,.Net Core 2.2)
+	React.Js
+	Bootstrap 4.3
>SDK https://dotnet.microsoft.com/download/dotnet-core/2.2
###Sub Project
-------------------
+	EInvCenter - 加值中心Web服務(.net Core MVC)
+	EInvClient - 客戶端(UWP)
+	Libs - 商業邏輯模組
+	DBMigration-資料庫遷移執行專案

###部屬服務
-------------------
>將DBMigration 設定為起始專案，並將DBContext內中的連線字串修改為目標資料庫。
>開啟套件管理主控台，鍵入update-database即可建立資料表。

	



