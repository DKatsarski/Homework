function solve(args) {
    let heights = args[0].split(' ').map(Number);
    let pockets = 0;
    let count = 0;
    let internalCount = 0;
     heights.push(-1);
    for (let i = 2; i < heights.length; i += 1) {
        
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

console.log(solve([ "16 13 31 12 36 8 46 31 48 12 49 2 48 49 9 26 47 18 5 2 1 16 39 32 42 26 21 30 29 12 20 47 33 16 19 6 37 25 9 37 39 20 37 38 41 25 38 31 48 46 13 25 36 35 33 7 28 32 39 25 27 25 35 38 1 1 9 43 17 43 6 0 22 21 47 44 8 1 38 26 10 40 48 25 7 49 3 28 17 48 6 31 37 5 22 11 6 18 32 42 0 31 24 2 11 31 48 16 5 28 6 13 4 12 48 15 12 49 27 18 35 35 20 15 26 16 20 41 45 16 0 7 47 22 0 38 38 16 42 34 28 31 19 38 0 32 27 18 34 8 15 26 40 26 9 11 22 24 38 45 18 35 5 44 49 5 27 41 26 27 3 17 12 1 21 35 41 20 36 31 35 43 22 10 30 29 4 4 49 36 33 4 27 19 12 16 45 38 10 30 20 2 5 13 9 47 6 0 39 14 45 41 43 29 16 44 28 19 16 32 35 27 31 18 48 21 5 46 27 49 2 0 17 45 22 24 42 18 21 36 18 9 13 48 7 32 36 4 48 0 23 4 27 32 11 25 30 47 31 49 29 35 42 30 27 38 45 40 44 38 33 18 6 33 2 34 47 10 28 5 1 47 6 20 25 31 33 1 16 20 49 47 28 8 3 41 27 42 31 48 33 6 43 24 24 24 41 23 26 6 46 11 21 3 43 7 33 44 11 48 4 17 40 44 6 11 38 32 42 41 22 19 42 46 26 8 6 44 42 49 43 21 17 46 3 42 32 0 21 0 38 7 8 15 9 19 20 25 45 29 43 37 25 23 23 9 14 37 7 30 49 20 17 35 17 30 34 38 37 7 16 16 33 4 38 30 35 21 44 46 20 24 10 0 47 39 38 12 20 9 42 42 29 4 33 14 14 46 43 10 4 17 38 27 47 33 49 34 8 17 32 34 20 45 33 19 27 34 29 31 1 20 34 47 3 31 16 35 32 19 38 39 4 27 26 29 6 30 33 33 46 39 31 25 31 40 41 12 30 47 16 29 6 43 12 5 1 13 8 3 39 38 3 26 34 17 9 19 23 1 1 0 40 27 24 27 46 4 0 42 12 5 26 23 24 40 44 30 15 12"
]));