1.Create an ICalculator interface

2. Has 2 methods, Multiply and Add that should be able to multiply and add 2 integers respectively, and return the result

3.Create a Calculator class that implements the ICalculator interface

4.Create a ListCalculator class. This should have 2 methods:
- MultiplyList - takes a list of 0 or more integers, and an integer "factor" - returns the input list, with each number in the list multiplied by the factor value
- AddList      - takes a list of 0 or more integers, and an integer "operand" - returns the input list, with the operand value added to each number
>

5.The ListCalculator doesn't know how to do multiplication and addition, so it should use an "injected" instance of an ICalculator to do the math, only for MultiplyList.


// Program.cs
// Write a program that creates a list of several integers - it should then print out the starting list
// Use a ListCalculator to add a value to each number in the list, then multiply each value in the list by another value
// Finally print the values in the list after the calculations have been performed