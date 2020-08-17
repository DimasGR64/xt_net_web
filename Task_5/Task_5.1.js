var str = 'у попа была собака';
var delsymbols = [];
var stringsplit = str.split(" ");

for(var i = 0; i < stringsplit.length; i++)
{
    for(var j = 0; j < stringsplit[i].length; j++)
    {
        if(stringsplit[i].includes(stringsplit[i][j], j+1))
            delsymbols.push(stringsplit[i][j]);
    }
}

for(var i = 0; i < delsymbols.length; i++)
{
    str = str.split(delsymbols[i]).join('');
}
console.log(str)
//.join(" ").split(".").join(" ").split("!").join(" ").split("?").join(" ").split(" ");