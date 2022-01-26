# Spotzer Order API
I've used .Net 5.0 which is both supported .Net framework and .Net Core
The project infrustructure consists of 2 main class library(API and Application). 
It is not totally represents a specific design architecture but I've considered domain driven design principles
API class library which is main project to provide order API, consists of Controller and Filters for swagger operations

# For swagger usage
I'm getting help from Swashbuckle which is most popular swagger tool for .Net.
Because of passing dynamic parameter in Controller action, I've customized the Swagger examples. It has also different json example options for 4 partners.
Swagger has also some Statup configuration for DI operations. In action post method , I've used manuel annotation to provide swagger example options.
# Logging
I've used NLog for logging operations.It's gathering all logs from Microsoft logging extensions and store it in specific log file. You can also configure file path
by using NLog.config file. For config operations also you can check Program.cs class.
# Exception Handling
I've created a custom middleware for Exception handling. In startup Configure class added a UseExceptionHandler for the exception middleware.
It's gathering exceptions from Microsoft Diagnostic library and listening all errors in runtime, also response error details.
# Spotzer Media Application
It process all domain operations inside application layer. I've considered OCP to process request. 
You can check OrderCreator, Partner classes and dependent Interface for it.
Stored all possible models inside Dto folder.
Stored interface class inside Interfaces folder.
Stored service class inside Services folder.
Stored all validation classes inside Validation folder.
# For validation; 
I've used Fluent Validation which is useful and popular tool for .Net applications. In validations folder, I've checked some special requirements
according to customer demands.
In my approach it has also Response Model for validation classes to response user for validation results.
# Test
For testing, getting help from Xunit. Tested static helper classes' methods and Order creators.

#Basic UML Diagrrams



