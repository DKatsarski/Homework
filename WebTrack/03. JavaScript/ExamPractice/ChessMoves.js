function solve(args) {
    let r = +args[0];

    let board = args.slice(2, 2 + r);
    let moves = args.slice(3 + r);

    function parseMove(move) {
        let cells = move.split(' ');

        return {
            from: {
                r: r - (+cells[0][1]),
                c: cells[0].charCodeAt(0) - 97
            },
            to: {
             r: r - (+cells[0][1]),
            c: cells[1].charCodeAt(0) - 97
            }
        }
    }
  
  console.log(board[0][2]);
}

console.log(solve([
'3',
'4',
'--R-',
'B--B',
'Q--Q',
'12',
'd1 b3',
'a1 a3',
'c3 b2',
'a1 c1',
'a1 b2',
'a1 c3',
'a2 b3',
'd2 c1',
'b1 b2',
'c3 b1',
'a2 a3',
'd1 d3'
]));