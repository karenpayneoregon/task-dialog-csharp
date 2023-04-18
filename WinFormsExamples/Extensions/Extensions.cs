using System.Diagnostics;

namespace WinFormsExamples.Extensions;

/// <summary>
/// Common string extensions 
/// </summary>
public static class Extensions
{
    [DebuggerStepThrough]
    public static string ToYesNoString(this bool value) => (value ? "Yes" : "No");
}