

/**Exercise 6.1.8.2: The following array of numbers has been declared:
 * let numbers = [10, 40, 0, 20, 50];
Write a program that, in a loop, divides the number 1000 by successive elements of the numbers array, displaying the result of each division. 
To divide the numbers, use the function from the previous task. 
Use the try...catch construction to handle an exception thrown in the case of division by zero. 
If such an exception is caught, the program should print an appropriate message (taken from the exception)
 and continue its operation (division by successive elements of the array).
 */

let numbers = [10, 40, 0, 20, 50];


numbers.forEach( numbers => {console.log(numbers); try { 1000/numbers} catch (error){ error = 1000/0}
});

console.log(numbers, ",");