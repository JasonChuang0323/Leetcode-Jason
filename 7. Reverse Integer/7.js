/**
 * @param {number} x
 * @return {number}
 */
var reverse = function(x) {
    let re = 0;
    let flag = true;
    if(x < 0){
        x*= -1;
        flag = false;
    }
    while( x > 0){
        let tmp = x % 10;
        re *= 10;
        re += tmp;
        x = Math.floor(x/10);

    }
      if (re > 2**31 - 1 || re < -1 * 2**31) {
    return 0;
  }
    return flag?re:re*(-1);
        
};