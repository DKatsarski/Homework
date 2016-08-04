function solve(args) {
    var s = Number(args[0]),
    count = 0,
    sum = 0,
    cars =   0,
    trucks = 0,
    trikes = 0;

    for (var truc = 0; truc <= s; truc += 10) {
        for (var c = 0; c <= s; c += 4) {
            for (var tri = 0; tri <= s; tri += 3) {
                
                trikes = tri;
                cars = c;
                trucks = truc;


                if ((trucks + cars + trikes) === s) {
                    count += 1;
                }
                
            }
            
        }
        
    }

    


console.log(count);



}


solve(['7']);