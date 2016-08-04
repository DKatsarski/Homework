function solve(params) {
    function getPoints(row, col) {
        return Math.pow(2, row) - col;
    }

    function getRowsAndCols(str) {
        var parts = str.split(' ');
        return [parseInt(parts[0]), parseInt(parts[1])];
    }

    var rowsAndCols = getRowsAndCols(params[0]),
    rows = rowsAndCols[0],
    cols = rowsAndCols[1];
    


   var horseMoves = [[-2, 1], [-1, 2], [1, 2],
    [2, 1], [2, -1], [1, -2], [-1, -2], [-2, -1]];     
 


}




console.log(solve(['3 5',
  '54561',
  '43328',
  '52388',
]));

console.log('Go go Horsy! Collected 1 weeds')

console.log(solve(['3 5',
  '54361',
  '43326',
  '52188',
]));

console.log('Sadly the horse is doomed in 7 jumps ')