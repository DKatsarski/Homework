function solve(args) {
    let heights = args[0].split(' ').map(Number);
    let pockets = 0;
    let count = 0;
    let internalCount = 0;
  
    for (let i = 1; i < heights.length; i += 1) {
        
        if (heights[i - 1] >= heights[i]) {
            count += 1; //proverqwam dali stojnostta e peak.
        } else {
            count = 0;
        }

        if (count === 1 && heights[i - 1] !== heights[i]) {
            

            if (i === heights.length - 1) {
                break;
            } else if (i === heights.length - 2 && heights[i + 1] > heights[i]) {
                pockets += heights[i]; break;
            } else if (i === heights.length - 2) {
                break;
            } else if (heights[i + 1] > heights[i + 2] && heights[i + 1] > heights[i] ) {
                pockets += heights[i];
            }








        }






    }



    console.log(pockets);

}



console.log(solve([ "3 45 3"]));

console.log(solve([ "53 20 1 30 2 40 3 10 1"]));
console.log('should be: 5');

console.log(solve([ "53 20 1 30 30 2 40 3 10 1"]));
console.log('should be: 3');

console.log(solve(["53 20 1 30 2 40 3 3 10 1" ]));
console.log('should be: 2');