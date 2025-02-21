# Unhandled Exception in C# Method

This example demonstrates a common C# error: an exception thrown without proper handling.  The `DoSomething()` method throws an exception if the `Value` property is 0, but it doesn't handle this exception, leading to the program's potential termination.  The solution provides a proper way to handle this exception.

## Bug
The `bug.cs` file contains the problematic code.  When `Value` is 0 and `DoSomething()` is called, an `Exception` is thrown without any attempt to gracefully handle the situation.

## Solution
The `bugSolution.cs` file shows the corrected code. This version uses a `try-catch` block to handle the potential `Exception`. This prevents the application from crashing unexpectedly.