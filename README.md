# JSON-Parser
Simple C# JSON Parser

This is a simple JSON Parser written for C#. It takes RAW JSON and deserializes it.
In the \JSON\JSON Deserializer\bin\Debug you will find the JSON Deserializer.exe to run it in Windows 10.

By default the Array + Nested Parser is running which means it will decode a JSON with some nested values (Street Address) and an array (phoneNumbers) as input.

Please use the example JSON format (copy paste) below for testing:

```
{
    "firstname" : "Roger",
    "lastname" : "Moore",
    "age" : 89,
    "isAlive" : false,
    "address" : 
    {
        "streetAddress" : "Sheissestrasse",
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

The purpose of my code is to show how C# can handle JSON with the use of a package called "newtonfoft.json".
You have to read the comment in my code to make it working for you JSON format. The purpose is a basic example only.
Strongly-typed JSON was used for the intellisense. I'd recommend class-inheritance for your code.

Any tips and questions are welcome,

Please be kind, i'm a beginner!

