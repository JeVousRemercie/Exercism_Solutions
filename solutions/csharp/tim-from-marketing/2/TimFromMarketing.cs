static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        return (id == null) ? $"{name} - {(department?.ToUpper() ?? "OWNER")}" : $"[{id}] - {name} - {(department ?? "OWNER").ToUpper()}";
        throw new NotImplementedException("Please implement the (static) Badge.Print() method");
    }
}
