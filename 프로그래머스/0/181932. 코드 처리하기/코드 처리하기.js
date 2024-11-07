function solution(code) {
    let mode = 0;
    let ret = ""; 

    for (let idx = 0; idx < code.length; idx++) {
        const cur = code[idx];
        
        if (cur === "1") {
            mode = mode === 0 ? 1 : 0;
            continue;
        }
        
        if (mode === 0) {
            if (idx % 2 === 0) {
                ret += cur;
            }
        } else {
            if (idx % 2 === 1) {
                ret += cur;
            }
        }
    }
    return ret || "EMPTY";
}