# Laboratory  2

# Task 1 - Class
Generate a new project using the console application template. Then, add a new file `Fruit.cs` to your project, which will contain the `Fruit` class.  

The `Fruit` class should have three properties:  
- `Name` of type `string`  
- `IsSweet` of type `bool`  
- `Price` of type `double`  

Inside the `Fruit` class, create a public static factory method called `Create()` that generates and returns a new `Fruit` object with:  
- a random `Name` selected from a predefined set of names,  
- `IsSweet` set to a random boolean value,  
- `Price` set to a random value.  


# Task 2 - Override
For this reason, it will also be necessary to **override** the `ToString()` operation in the `Fruit` class.  

Add a public method to the `Fruit` class that returns a `string` and is named `ToString()`.  
You must use the `override` keyword to enforce polymorphism.


# Task 3 - Linq
Modify the display of the elements so that only items with the property `IsSweet` set to `True` are shown, sorted by `Price` in descending order.


# Task 4 - Async
It is rare for an entire program to run completely synchronously – parallelism and asynchrony mechanisms are very common in many programming languages.  

Add a new class to your project named `UsdCourse`. This class should contain a method that communicates with the Internet and retrieves the current USD exchange rate.  

Since the request to an external web service is performed asynchronously, the method `GetUsdCourseAsync()` should use the `async` keyword and return a `Task<float>`. This does not return a `float` immediately, but rather a "promise" to return a `float` in the future.


# Task 5 - ToStringAsync
Add a property `UsdPrice` to your `Fruit` class – it should calculate the price in US dollars based on the base price.

# Task 6 - MyFormatter
A culture (`locale`) is a set of information that describes how to display date, time, numbers, and currencies depending on the region and language used.  

As you probably know, in Poland currency is displayed as `0,99 zł`, whereas in the USA it is displayed as `$0.99`.  

You should add a mechanism to your program so that the base price (`Price`) is displayed using the standard currency formatting, and the USD price is displayed in the format appropriate for the USA.  

Add a new class to your program named `MyFormatter`. This class should contain a single static method, `FormatUsdPrice`, which takes a `double` as input and returns a `string`.


# Task 7 - Test
Manually testing a program is often tedious, repetitive, and inefficient. For this reason, automated tests are used, particularly unit tests.  

In this task, we will try to create a unit test to check whether the `MyFormatter` class and its `FormatUsdPrice()` method work correctly.

# Task 8 - Test Enchanced
Modify the test so that it checks whether the output contains exactly the value provided for testing, in the precise format.  

For example, if the test value was `0.05`, the test should verify that the result starts with `$0`, then contains a period, and then specifically `05`.

*The first 2 tests are designed to check for a correct result, whereas the last one (3) checks for an incorrect result. If the result is correct, it returns true.*
