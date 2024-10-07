console.log( "I am working");
//6.1.8

function div(a, b) {
    if (b == 0) {
        throw new RangeError("Can't divide by 0");
    }
    return a / b;
}
console.log(div(4, 2)); // -> 2
console.log(div(4, 0)); // -> Uncaught RangeError: Can’t divide by 0

//6.2.5
function outer() {
    let name = "outer";
    let str = inner();
    return str;
}
 
function inner() {
    let name = "inner";
    console.log(name); // -> inner
    console.time(name);
    return "Hello !";
}
 
console.log("before outer() call");
// debugger;
console.log(outer());
console.log("after outer() call");


//6.2.11
let part = 0;
console.time('Leibniz');
for (let k = 0; k < 10000000; k++) {
    part = part + ((-1) ** k) / (2 * k + 1);
}
console.timeEnd('Leibniz'); // -> Leibniz: 456.60498046875 ms
let pi = part * 4;
console.log(pi); // -> 3.1415925535897915

//6.2.13.1
let end = 5; 
for(let i=1; i<=end; i++){
    console.log(i); 
}
//6.2.13.2
let counter = 0; 
let maxValue = 10; 
let result = 1; 
 
// debugger; 
for (counter = 0; counter < maxValue; counter++) { 
    console.log(result); 
    result *= maxValue - counter - 1; 
} 
console.log("Final result: ", result);

//6.2.13.3
function max(array) { 
    let maxValue = array[1]; 
    for(let i=1; i<maxValue; i++){
        if(array[i] > maxValue) { 
            maxValue = array[i]; 
        } 
    } 
    return console.log("6.2.13.3 maxValue: ", maxValue); 
} 
 
console.log( max([1, 4, 6, 2])); // -> 6 
console.log( max([10, 4, 6, 2])); // -> 6
