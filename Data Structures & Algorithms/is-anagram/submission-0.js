class Solution {
    /**
     * @param {string} s
     * @param {string} t
     * @return {boolean}
     */
    isAnagram(s, t) {
        if (s.length !== t.length) return false;
        const dict = {};

        for (const i of s) {
            dict[i] = (dict[i] || 0) + 1;
        }

        for (const j of t) {
            dict[j] = (dict[j] || 0) - 1;
        }
        
        for (const k in dict)
        { 
            if (dict[k] !== 0)
            { 
                return false;
            }
        }

        return true;
    }
}
