var str = '3.5+4*10-5.3/5=';
var numbers = str.split(/\s*[\-\+\/\*=]\s*/).filter(Boolean);
var operators = str.split(/[\d\.=\s]+/).filter(Boolean);
var numOperator = 0;
var summ  = parseFloat(numbers[0]);

for (let i = 1; i < numbers.length; i++) {
    let operand = parseFloat(numbers[i]);
    switch (operators[numOperator++]) {
        case '*':
            summ *= operand;
            break;
        case '/':
            summ /= operand;
            break;
        case '+':
            summ += operand;
            break;
        case '-':
            summ -= operand;
            break;
        default:
            break;
    }
}
console.log(summ);

function Operators(str)
{
    let reg = /[\d\.=\s]+/;
        return str.split(reg).filter(Boolean);
}
function Numbers(str)
{
    let reg = /\s*[\-\+\/\*=]\s*/;
    return str.split(reg).filter(Boolean);
}
    
