# Sending Email using ASP.NET Core with FluentEmail
A simple example of a sending email project using ASP.NET Core with FluentEmail.

```
This tutorial is under construction!
```


What you need to do
-------------------

Considering that you know a little about .Net Core, open the 'Visual Studio Code' and create a new mvc project.

Open the file 'appsettings.json' and put yours configurations like the example below:

```json
{
  "Logging": {
    "IncludeScopes": false,
    "LogLevel": {
      "Default": "Warning"
    }
  },
  "EmailSettings": {
    "FromName": "Your name",
    "FromAddress": "you@domain.com",
    "ToEmail": "",
    "CcEmail": "",
    "BccEmail": "",
    "ServerAddress": "smtp.gmail.com",
    "ServerPort": 587,
    "ServerUseSsl": true,
    "Username": "",
    "Password": ""
  }
}
```

Configure this file using the data in the table below (or other server), Gmail and Hotmail worked with me:

| Server Name  | SMTP Address | Port  | SSL |
| ------------- | ------------- | ------------- | ------------- |
| Gmail | smtp.gmail.com | 587 | Yes |
| Hotmail | smtp.live.com | 587 | Yes |


License
-------

This example application is [MIT Licensed](https://github.com/anzolin/AspNetCoreSendEmailWithFluentEmail/blob/master/LICENSE).


About the author
----------------

Hello everyone, my name is Diego Anzolin Ferreira. I'm a .NET developer from Brazil. I hope you will enjoy this simple example application as much as I enjoy developing it. If you have any problems, you can post a [GitHub issue](https://github.com/anzolin/AspNetCoreSendEmailWithFluentEmail/issues). You can reach me out at diego@anzolin.com.br.
