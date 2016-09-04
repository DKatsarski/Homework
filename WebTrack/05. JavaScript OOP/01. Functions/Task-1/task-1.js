/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	
*/

function sum(array1, array2) {
    
    typeValidator(array1);
    typeValidator(array2);

    checkIfArrayIsEmpty(array1);
    checkIfArrayIsEmpty(array2);

    numbersInArrayValidator(array1);
    numbersInArrayValidator(array2);

    var sumofNumbersInArray1 = sumInArray(array1);
    var sumofNumbersInArray2 = sumInArray(array2);

	var sumArrays = sumofNumbersInArray1 + sumofNumbersInArray2;
    return sumArrays;
}
console.log(sum([3, 'a', 3], [2, 2, 2]));

function sumInArray(args) {
    var temp = 0;
    for (var i = 0; i < args.length; i++) {
        temp += +args[i];
    }
    return temp;
}

function typeValidator(args) {
  if (!Array.isArray(args)) {
      throw new Error();
  }
}

function checkIfArrayIsEmpty(args) {
    if (args.length === 0) {
        return null;
    }
}

function numbersInArrayValidator(args) {
   for (var i = 0; i < args.length; i++) {
       if (isNaN(args[i])) {
           throw new Error();
       } 
   }
}
module.exports = sum;