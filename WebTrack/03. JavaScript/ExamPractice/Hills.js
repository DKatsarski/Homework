 function solve(args) {
     let heights = args[0].split(' ').map(Number);
     let bestCount = -1;
     let count = 0;

     let current;
     let isDescending = true;

     current = heights[0];
     heights.push(-1);
     for (let i = 1; i < heights.length; i += 1) {
         let height = heights[i];
  
         if (isDescending) {
             //descent finished
             if (current < height) {
                 
                 isDescending = !isDescending;
             }
         } else {
                //ascending
                if (current > height) {
                    bestCount = Math.max(bestCount, count);
                    count = 0;
                    //save count
                    //reset count
                    isDescending = !isDescending;
                }
         }
         current = height;
         count += 1;
     }

     console.log(bestCount);

 }

 console.log(solve(['5 1 7 6 3 6 4 2 3 8']));