# JSON-Parser
Simple C# JSON Parser

This is a simple JSON Parser written for C#. It takes RAW JSON and deserializes it.
In the "JSON Deserializer\bin\Debug" folder you will find the JSON Deserializer.exe to run it in Windows 10.

By default the Array + Nested Parser is running which means it will decode a JSON with some nested values (Street Address) and an array (phoneNumbers) as input.

Please use this example JSON format (copy paste) below for testing. This example is a Serialized JSON String:

```
{
    "firstname" : "John",
    "lastname" : "Doe",
    "age" : 69,
    "isAlive" : true,
    "address" : 
    {
        "streetAddress" : "Kopfstrasse",
        "city" : "Berlin",
        "postCode" : "N1 3XX"
    },
    "phoneNumbers" :
    [
        { "type" : "home", "number" : "+61 03 1234 5678" },
        { "type" : "mobile", "number" : "+61 0405 111 222" }
    ]
}
```




Visual Studio Solution:
In the actual code you can comment-in different versions of the Parser (Simple, Complex, Array and Dynamic).
The Dynamic will attempt to print-out every kind of JSON format but will throw an error.

The purpose of this code is to show how C# can handle JSON with the use of a package called "newtonfoft.json".
You have to read the comment in the code to make it working for you JSON format. The purpose is a basic example only.
Strongly-typed JSON was used for the intellisense. Recommended is class-inheritance for your code.

Any tips and questions are welcome,

Please be kind, i'm a beginner!

Code credits are for Les Jackson https://www.youtube.com/watch?v=CjoAYslTKX0

