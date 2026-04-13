namespace Codemunkie.DevTools
{
    public record ToolBinding(string Name, Keys Keys, Action Handler);

    public record ToolBindingCategory(string Name, IEnumerable<ToolBinding> ToolBindings);
}
