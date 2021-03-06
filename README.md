
## EWS Managed API Continuation

[![Gitter](https://badges.gitter.im/JoinChat.svg)](https://gitter.im/OfficeDev/ews-managed-api?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)

This project is a fork of the [ews managed API](https://github.com/OfficeDev/ews-managed-api) at commit
>Update README.md |  25a393dbc68b420d25999bdf0a03c23d86412f57

It exists because starting July 19th 2018, [Exchange Web Services (EWS)](https://github.com/OfficeDev/ews-managed-api) will no longer receive feature updates. <br />
This project however, will.<br />


The Exchange Web Services (EWS) Managed API provides a managed interface for developing .NET & .NET Core client applications that use EWS.
By using the EWS Managed API, you can access almost all the information stored in an Office 365, Exchange Online, or Exchange Server mailbox. 



## A word of warning

EWS is in sustaining mode, the recommended access pattern for Office 365 and Exchange online data is [Microsoft Graph](https://graph.microsoft.com). <br />
There is no EWS replacement for on-premise Exchange. <br />
For more information concerning EWS discontinuation, click [here](https://developer.microsoft.com/en-us/graph/blogs/upcoming-changes-to-exchange-web-services-ews-api-for-office-365/).

## License

[MIT](https://en.wikipedia.org/wiki/MIT_License)


## Releases

You can download the binary version of the old EWS Managed API from [nuget](http://www.nuget.org/packages/Microsoft.Exchange.WebServices/).
<br />
The old nuget is not compatible with .NET Core.<br />
The new EWS Managed API is not yet on nuget. <br />
You just need to build this project from source. 


## Getting started resources

The exchange code samples are available in purified form in the ["ExchangeCodeSamples"-directory](https://github.com/OfficeDevUnofficial/ews-managed-api/tree/master/ExchangeCodeSamples) of this repository.

See the following articles to help you get started:
- [Get started with EWS Managed API client applications](http://msdn.microsoft.com/en-us/library/office/dn567668(v=exchg.150).aspx)
- [How to: Reference the EWS Managed API assembly](http://msdn.microsoft.com/en-us/library/office/dn528373(v=exchg.150).aspx)
- [How to: Set the EWS service URL by using the EWS Managed API](http://msdn.microsoft.com/en-us/library/office/dn509511(v=exchg.150).aspx)
- [How to: Communicate with EWS by using the EWS Managed API](http://msdn.microsoft.com/en-us/library/office/dn467891(v=exchg.150).aspx)
- [How to: Trace requests and responses to troubleshoot EWS Managed API applications](http://msdn.microsoft.com/en-us/library/office/dn495632(v=exchg.150).aspx)


## Documentation

Documentation for the EWS Managed API is available in the [Web services](http://msdn.microsoft.com/en-us/library/office/dd877012(v=exchg.150).aspx) node of the [MSDN Library](http://msdn.microsoft.com/en-us/library/ms123401.aspx).
In addition to the getting started links provided, you can find how to topics and code samples for the most frequently used EWS Managed API objects in the [Develop](http://msdn.microsoft.com/en-us/library/office/jj900166(v=exchg.150).aspx) node. All the latest information about the EWS Managed API, EWS, and related web services can be found under the [Explore the EWS Managed API, EWS, and web services in Exchange](http://msdn.microsoft.com/en-us/library/office/jj536567(v=exchg.150).aspx) topic on MSDN.


## Prerequisites

You need the following to work with the EWS Managed API:
- A C# compiler to build the DLL files. We recommend 
   - [JetBrains Rider (Linux, Mac, Windows)](https://www.jetbrains.com/rider/)
   - [JetBrains Rider EAP (gratis)](https://www.jetbrains.com/rider/eap/)
   - [MonoDevelop (free)](https://www.monodevelop.com/) 
   - [Visual Studio 2017 Community (gratis)](https://visualstudio.microsoft.com/downloads/) 
   - [Visual Studio Mac (gratis)](https://visualstudio.microsoft.com/vs/mac/).
- 
   - An Exchange server that is running Exchange Online with a version of Exchange starting with Exchange Server 2007+
   - or a mailbox on Office 365
- .NET-Core 2.0 (NetStandard 2.0), or a version of the .NET Framework starting with full .NET Framework 3.5+.


## Additional resources

- [Exchange 101 code samples](http://code.msdn.microsoft.com/Exchange-2013-101-Code-3c38582c)
- [EWS Managed API reference](http://msdn.microsoft.com/en-us/library/jj220535(v=exchg.80).aspx)


## Community

Exchange has an active developer community that you can turn to when you need help. We recommend using the [Exchange Server Development forum on MSDN](http://social.msdn.microsoft.com/Forums/en-US/home?category=exchangeserver&filter=alltypes&sort=lastpostdesc), or using the [ews] tag on [StackOverflow](http://stackoverflow.com/questions/tagged/ews).
