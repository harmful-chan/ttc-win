# ttc-win

TikTok 评论系统，可以获取直播间评论，分享，当前观看人数，总观看人数等信息，同时支持翻译`auto -> 中文`

项目引用 [TikTokLiveSharp](https://github.com/sebheron/TikTokLiveSharp) 在这之上扩展。

支持国内代理软件 SS/SSR, astrill vpn, 直连等。使用前需要填写配置文件，例如

```json
[ 
	{ 
        "UniqueID": "hans.students", // tiktok 账号名
        "SessionID": "xxx xxx ... xxx", // 32个16进制数
        "Expiration": 1665290552 // 时间戳 
    }
    // ...
]
```

sessionid等数据可以在谷歌浏览器获取，域：tiktok.com

项目基于 .net core 3.1 winfrom 运行前需要安装运行环境 [官方](https://dotnet.microsoft.com/zh-cn/download/dotnet/3.1)

+ [.NET Desktop Runtime 3.1.28](https://dotnet.microsoft.com/zh-cn/download/dotnet/3.1)

### 启动流程

+ 日志初始化
+ 历史配置
+ 字体安装
  + *CascadiaMono*, *CascadiaCode* 
+ 代理检查（按以下顺序）
  + http://localhost:8888 [Fiddler]
  + http://localhost:3213 [Astrill VPN]
  + http://localhost:1080 [SS/SSR]
  + 直连
  + 环境变量 http_proxy, https_proxy
+ TIKTOK直播间准备
+ 定时任务 10s
  + 本地保存直播间数据
  + 获取本机公网IP
+ (假数据 1s )：测试用，可以生成加入人员，评论等数据

*ps:代码挺垃圾的，轻喷*

