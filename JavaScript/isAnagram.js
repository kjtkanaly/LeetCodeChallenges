/**
 * @param {string} s
 * @param {string} t
 * @return {boolean}
 */
var isAnagram = function(s, t) {
    
    // Default
    if (s.length != t.length)
    {
        return false;
    }
    
    const sChar = s.split("");
    const tChar = t.split("");
    
    sChar.sort();
    tChar.sort();
    
    for (let i = 0; i < sChar.length; i++)
    {
        if (sChar[i] != tChar[i]) return false;
    }
    
    return true;
};