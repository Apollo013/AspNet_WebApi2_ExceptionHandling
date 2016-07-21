# WebApi2_Owin_ExceptionHandling
A run through on various exception handling, logging and http response implementations in a Web Api 2 app.

---

A Web Api 2 / OWIN app built using VS2015 Community. Test using Fiddler or POSTMAN.

---

##Http Responses

###Features
|Feature|Comment|
|-------|-------|
|IHttpActionResult| Demonstrates a few examples of builtin .NET shortcut methods for returning a response {OK, BadRequest, etc}|
|IHttpActionResult| Demonstrates how to create a custom 201 (Created) response that derives from 'IHttpActionResult'|
|Request.CreateResponse| Demonstrates how to use a method of the current contexts 'HttpRequestMessage' object(Request) to generate a 'HttpResponseMessage'. Could also have used 'CreateErrorResponse' |
|HttpResponseMessage| Demonstrates how to create a 400 (BadRequest) 'HttpResponseMessage' |
|HttpResponseException| Used to throw the above 'HttpResponseMessage' |


###Tests
|Verb|Uri|Response|
|----|---|--------|
|POST|http://localhost:[YOUR_PORT_NUMBER]/httpresponseexceptions/customcreatedresponse/John|201 (Created)|
|GET| http://localhost:[YOUR_PORT_NUMBER]/httpresponseexceptions/ok |200 (OK) |
|GET| http://localhost:[YOUR_PORT_NUMBER]/httpresponseexceptions/notfound |404 (NotFound)|
|GET| http://localhost:[YOUR_PORT_NUMBER]/httpresponseexceptions/nocontent |204 (NoContent)|
|GET| http://localhost:[YOUR_PORT_NUMBER]/httpresponseexceptions/checkid/{4} |200 (OK)|
|GET| http://localhost:[YOUR_PORT_NUMBER]/httpresponseexceptions/checkid/{101} |400 (BadRequest)|

---

##Exception Filter

###Features
|Feature|Comment|
|-------|-------|
|ExceptionFilterAttribute| Demonstrates how to create a custom Exception Filter Attribute that is applied at the action level|
|Exception| Demonstrates how to create a custom exception class that derives from 'Exception' |
|HttpResponseMessage| Demonstrates how to create a 404 (NotFound) 'HttpResponseMessage' |
|HttpResponseException| Used to throw the above 'HttpResponseMessage' |


###Tests
|Verb|Uri|Response|
|----|---|--------|
|GET|http://localhost:[YOUR_PORT_NUMBER]/exceptionfilter/{id:int}|404 (NotFound) |

---

###Resources
|Title|Author|Publisher|
|-----|------|---------|
|[Improving Error Handling in ASP.NET Web API 2.1 with OWIN](https://www.jayway.com/2016/01/08/improving-error-handling-asp-net-web-api-2-1-owin/)| Tomas Lycken | JAYWAY |
|[How to handle errors in Web API](http://www.infoworld.com/article/2994111/application-architecture/how-to-handle-errors-in-web-api.html)| Joydip Kanjilal | InfoWorld |
|[Handling Errors in Web API Using Exception Filters and Exception Handlers](http://blog.karbyn.com/articles/handling-errors-in-web-api-using-exception-filters-and-exception-handlers/)| Michael Lumpp | KARBYN Blog |
|[Exception Handling in ASP.NET Web API - A Guided Tour](https://www.exceptionnotfound.net/the-asp-net-web-api-exception-handling-pipeline-a-guided-tour/)| Matthew Jones | ExceptionNotFound.net |
|[Request logging and Exception handling/logging in Web APIs using Action Filters, Exception Filters and NLog](http://www.codeproject.com/Articles/1028416/RESTful-Day-sharp-Request-logging-and-Exception-ha) |  Akhil Mittal | Code Project |
|[Web API Pipeline Revealed: A True Practical Approach](http://www.c-sharpcorner.com/article/webapi-pipeline-revealed-a-true-practical-approach/)| Sachin Kalia | C# Corner |
