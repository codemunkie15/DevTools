namespace Codemunkie.DevTools.TextTools
{
    public static class TextToolsExtensions
    {
        public static string ToCsl(
            this IEnumerable<string> lines,
            string cslSeperator,
            string itemPrefix = "",
            string itemSuffix = "")
        {
            var items = lines.Select(i => $"{itemPrefix}{i}{itemSuffix}");
            
            return string.Join($",{cslSeperator}", items);
        }
    }
}