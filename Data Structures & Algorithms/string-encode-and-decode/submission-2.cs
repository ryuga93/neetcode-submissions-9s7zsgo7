public class Solution {

    public string Encode(IList<string> strs)
    {
        if (strs == null || strs.Count == 0) return string.Empty;
        var countList = new List<int>();
        var s = string.Empty;

        foreach (var str in strs)
        {
            countList.Add(str.Length);
            
            s += str;
        }

        var countString = string.Empty;
        foreach (var count in countList)
        {
            countString +=  count + ",";
        }
        s = countString + "#" + s;
        return s;
    }

    public List<string> Decode(string s)
    {
        if (s.Length == 0) return new List<string>();
        var countList = new List<int>();
        var decoded = new List<string>();
        var startIndex = 0;
        string i = string.Empty;
        for (var index = 0; index < s.Length; index++)
        {
            var c = s[index];
            if (c == '#')
            {
                startIndex = index + 1;
                break;
            }
            if (c == ',')
            {
                countList.Add(int.Parse(i));
                i = "";
                continue;
            }
            i += c;
        }

        var message = s.Substring(startIndex);
        var extractIndex = 0;
        foreach (var count in countList)
        {
            decoded.Add(message.Substring(extractIndex, count));
            extractIndex = extractIndex + count;
        }

        return decoded;
    }
}
