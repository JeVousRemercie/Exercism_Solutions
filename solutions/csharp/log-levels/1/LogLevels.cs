static class LogLine
{
    public static string Message(string logLine)
    {
        return logLine.Split(":")[1].Trim();
        throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
    }

    public static string LogLevel(string logLine)
    {
        return logLine.Split(":")[0].ToLower().Trim('[', ']');
        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {
        string message = logLine.Split(":")[1].Trim();
        string level = logLine.Split(":")[0].ToLower().Replace('[', '(').Replace(']', ')');
        return ($"{message} {level}");
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}
