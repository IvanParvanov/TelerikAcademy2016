function solve(args) {
    var input = args,
        n = +input[0],
        arr = input[1].split(' ').map(
            function(item) {
                return parseInt(item, 10);
            }),
        x = +input[2],
        count = 0;

    for (var i = 0; i < arr.length; i++) {
        if (arr[i] === x) {
            count++;
        }
    }
    console.log(count);
}

solve(['8', '28 6 21 6 -7856 73 73 -56','73']);
