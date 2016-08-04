function solve(args) {
   var s = args[0],
   c1 = args[1],
   c2 = args[2],
   c3 = args[3],
   answer = 0;

   for (var i = 0; i < s / c1 + 1; i++) {
       for (var j = 0; j < s / c2 + 1; j++) {
            for (var k = 0; k < s / c3 + 1; k++) {
                
                var price = (i * c1) + (j * c2) + (k * c3);
                if (price <= s) {
                answer = Math.max(price, answer);
                }
                
            }
       }
   }
   console.log(answer);
}


   solve([110 ,13, 15, 17]);
