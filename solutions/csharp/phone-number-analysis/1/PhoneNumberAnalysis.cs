public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string firstDigits = phoneNumber.Split("-")[0];
        string prefixCode = phoneNumber.Split("-")[1];
        string lastDigits = phoneNumber.Split("-")[2];
        return (firstDigits == "212", prefixCode == "555", lastDigits);
        throw new NotImplementedException($"Please implement the (static) PhoneNumber.Analyze() method");
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
        throw new NotImplementedException($"Please implement the (static) PhoneNumber.IsFake() method");
    }
}
