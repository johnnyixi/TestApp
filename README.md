# TestApp

1. The CorrelationId should be the same for the duration of a HTTP request
2. The duration of the DoImportantStuffAsync method should be reduced under 3.1 seconds
3. The method GenerateAsync of RandomGeneratorService takes a lot more than it should. This can be substantially improved 
4. An extension method for ```long``` (stopwatch.ElapsedMilliseconds) should return a string of the form "{} second/s and {} milliseconds"

```
stopwatch.ElapsedMilliseconds = 1222 => "1 second/s and 222 milliseconds"
```

This method should be used to populate a new property in the response classes, named ```FormatedElapsedTime```

// Tentative

5. A base class for ImportantResponse and RandomGenerator response

// TODO
