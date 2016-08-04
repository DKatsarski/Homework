function solve(args) {
    var n = parseInt(args[0]);
    var result = 1;

    args = args.map(Number);

    for (var i = 2; i < args.length; i++) {
        
        if (args[i - 1] > args[i]) {
            result++;
        }
   }


    console.log(result);
}

console.log(solve(['6', '1', '3', '-5', '8',  '7', '-6']));