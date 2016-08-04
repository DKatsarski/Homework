function solve(args) {
    var s = args[0],
    c1 = args[1],
    c2 = args[2],
    c3 = args[3];
    var result = 0;

    for (var i = 0; i < s / c1 + 1; i++) {
        for (var j = 0; j < s / c2 + 1; j++) {
            for (var k = 0; k < s / c3 + 1; k++) {
                var combinations = (c1 * i) + (c2 * j) + (c3 * k);
                    if (combinations <= s) {
                        if (combinations > result) {
                            result = combinations;
                        }
                    }
            }
            
        }
    }

    console.log(result)
    
}

console.log(solve(['20', '11', '200', '300']));