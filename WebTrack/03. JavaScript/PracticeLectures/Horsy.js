function solve(params) {
    function getPoints(row, col) {
        return Math.pow(2, row) - col;
    }

   // console.log(getPoints(1, 4));

   function getRowsAndCols(str) {
     var parts = str.split(' ');
     return [parseInt(parts[0]), parseInt(parts[1])];
   }
   //console.log(getRowsAndCols('312 5323'));

   function getValue(params, row, col) {
     return params[row + 1][col];
   }

   var rowsAndCols = getRowsAndCols(params[0]),
        rows = rowsAndCols[0],
        cols = rowsAndCols[1],
        row = rows - 1,
        col = cols - 1,
        points = 0,
        moves = 0,
        used = [];

   var horseMoves = [[-2, 1], [-1, 2], [1, 2],
    [2, 1], [2, -1], [1, -2], [-1, -2], [-2, -1]];     

while (ture) {
  if (row >= rows || col >= cols || row < 0 || col < 0) {
    console.log("Go go Horsy! Collected " + points + " weeds")
    break;
  }

  if (used[row * col + col]) {
        console.log("Sadly the horse is doomed in " + moves + " jumps")
    break;
  }

  points = points +  getPoints(row, col);
  moves = moves + 1;

  var move = horseMoves[getValue(params, row, col) - 1];
 	used[row * col + col] = true;
  row += move[0];
  col += move[1];

    }
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