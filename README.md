# ParseUtility
A simple utility for parsing nullable and non-nullable types without having to deal with 
TryParse or typing out the full name of the type's Parse method. Requires .NET 2.0 or 
greater.

## Examples
### Parse a string to an int
```
CompileFailed.Utility.Parse.ParseString<int>("123"); //123
```
### Parse a string to a nullable int
```
CompileFailed.Utility.Parse.ParseStringNullable<int>("123"); // 123
CompileFailed.Utility.Parse.ParseStringNullable<int>("Not an int!"); // NULL
CompileFailed.Utility.Parse.ParseStringNullable<int>(""); // NULL
```
