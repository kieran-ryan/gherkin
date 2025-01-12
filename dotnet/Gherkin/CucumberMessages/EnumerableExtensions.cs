using System.Collections.ObjectModel;

namespace Gherkin.CucumberMessages;

internal static class EnumerableExtensions
{
    public static ReadOnlyCollection<T> ToReadOnlyCollection<T>(this IEnumerable<T> enumerable)
    {
        return new ReadOnlyCollection<T>(enumerable.ToList());
    }
}