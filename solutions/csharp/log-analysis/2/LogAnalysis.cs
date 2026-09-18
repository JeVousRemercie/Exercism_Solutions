public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string delimiter) => 
        str.Split(delimiter)[1];
    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string del1, string del2) {
        int start = str.IndexOf(del1) + del1.Length;
        int end = str.IndexOf(del2);
        int length = end - start;
        return str.Substring(start, length);
    }
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str) {
        string delimiter = ": ";
        return str.SubstringAfter(delimiter);
    }
    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str) {
        string del1 = "[";
        string del2 = "]";
        return str.SubstringBetween(del1, del2);
    }
        
}