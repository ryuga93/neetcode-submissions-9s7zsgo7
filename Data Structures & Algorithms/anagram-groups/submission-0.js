class Solution {
    /**
     * @param {string[]} strs
     * @return {string[][]}
     */
    groupAnagrams(strs) {
        const result = {};

        for (let word of strs)
        {
            const countKey = new Array(26).fill(0);

            for (let character of word)
            {
                countKey[character.charCodeAt(0) - 'a'.charCodeAt(0)]++;
            }

            const key = countKey.join(',');

            if (!result[key])
            {
                result[key] = [];
            }

            result[key].push(word);
        }

        return Object.values(result);
    }
}
