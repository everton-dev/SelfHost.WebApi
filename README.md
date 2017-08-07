# Web Api Self-Hosted
This console application is a self-hosted. You determine the URL where you would call the Controllers routes, that is, you don't need to host your application in an IIS.

This application uses specific DLLs, these are:

- Microsoft.Owin.Hosting
- Microsoft.AspNet.Cors
- Microsoft.AspNet.WebApi.Client
- Microsoft.AspNet.WebApi.Core
- Microsoft.AspNet.WebApi.Core.pt
- Microsoft.AspNet.WebApi.Cors
- Microsoft.AspNet.WebApi.Owin
- Microsoft.AspNet.WebApi.OwinSelfHost
- Microsoft.Owin.Host.HttpListener
- Microsoft.Owin.Security
- Microsoft.Owin.Security.OAuth

You can install it through the NuGet Package Manager.
Tip: To call the routes I'm using Postman (download: https://www.getpostman.com/).

Follow the URLs To call the four created routes:

- http://your-host-name:3001/ListColor
- http://your-host-name:3001/InsertColor/Pink/Rosa/
- http://your-host-name:3001/UpdateColor/Red /Vermelhão/
- http://your-host-name:3001/DeleteColor/Green/

Have a fun! :D
