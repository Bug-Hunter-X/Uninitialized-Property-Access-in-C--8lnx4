# Uninitialized Property Access in C#

This example demonstrates a subtle bug that can occur in C# when accessing a property before it has been explicitly initialized.  While it's common to handle uninitialized variables, the behavior with properties can be less predictable.  The code accesses the `MyProperty` before assigning any value, leading to unexpected results.

## How to reproduce

1. Compile and run the `bug.cs` file.
2. Observe the output; it will be the default value for `int` (0).  This default value may be difficult to detect and debug if expected data is not assigned.

## Solution

The provided `bugSolution.cs` demonstrates how to properly initialize the property within the class to prevent the issue.   Consider explicit initialization in the constructor or before accessing the property.