namespace UtilityLibraries;

public static class StringLibrary
{

  public static bool StartsWithUpper(this string? str)
  {
    if (string.IsNullOrWhiteSpace(str))
      return false;

    char ch = str[0];
    return char.IsUpper(ch);
  }

  public static bool EndsWithUpper(this string? str)
  {
    if (string.IsNullOrWhiteSpace(str))
      return false;

    char ch = str[str.Length - 1];
    return char.IsUpper(ch);
  }
}
