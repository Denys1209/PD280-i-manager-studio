
namespace WinFormsPD280.Frame.Items;
public class DynamicTextItem : StaticTextItem
{
    public int Id { get; set; }

    public DynamicTextItem(string text, int fontSize, int x, int y, int color, int id) : base(text, fontSize, x, y, color)
    {
        Id = id;
    }

    public new void Execute(DisplayManager displayManager)
    {
        displayManager.ShowDynamicText(Text, Id, FontSize, X, Y, Color);
    }
    public override string ToString()
    {
        return $"Dynamic text; text = ${Text}; FontSize = ${FontSize}; Color = ${Color}; Id = ${Id}";
    }

}
