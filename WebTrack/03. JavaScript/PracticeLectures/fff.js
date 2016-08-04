function sove(args) {
  var a = +args[0];
  var b = +args[1];
  var height = +args[2];

  var area = ((a + b) / 2) * height;
  console.log(area.toFixed(7));
}

function solve(args) {
    //area = ((a + b) / 2) * h)
    var a = +args[0],
        b = +args[1],
        h = +args[2],
        area;

    area = (((a + b) / 2) * h);
    console.log(area.toFixed(7));
}