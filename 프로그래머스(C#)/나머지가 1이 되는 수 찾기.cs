function solution(n) {
    let answer = 0;
    new Array(n).fill(0).map((_,index)=> index+2).some(item => {
        if(n % item === 0 ) {
            answer = item;
            return true;
        }
        return false;
    })
    return answer;
}
