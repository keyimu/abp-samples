namespace Acme.BookStore.Blazor.Pages;

public partial class Index
{
    /// <summary>Planning week: ISO Monday of the selected week; binds to MudWeekPicker.</summary>
    public DateTime? PlanningWeekMonday { get; set; }
}
