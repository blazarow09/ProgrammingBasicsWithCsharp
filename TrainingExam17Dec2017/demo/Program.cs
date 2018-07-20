function pool([v, x, y, N])
{

    let poolVol = parseInt(v);

    let debit1 = parseInt(x);

    let debit2 = parseInt(y);

    let hours = parseFloat(N);

    let palenPool = hours * debit1 + hours * debit2;

    if (palenPool <= poolVol)
    {

        let kolkoPalen = Math.truncpalenPool / poolVol * 100);

        let kolkoDebit1 = Math.trunc(debit1  * hours / palenPool * 100);

        let kolkoDebit2 = Math.trunc(debit2 * hours / palenPool * 100);

        console.log(`The pool is ${ kolkoPalen}% full.Pipe 1: ${ kolkoDebit1}%.Pipe 2: ${ kolkoDebit2}%.`);

    }
    else
    {

        let kolkoPreliva = palenPool - poolVol;

        console.log(`For ${ hours}
        hours the pool overflows with ${ kolkoPreliva}
        liters.`);

    }

}