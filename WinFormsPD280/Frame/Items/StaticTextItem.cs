
namespace WinFormsPD280.Frame.Items;
public class StaticTextItem : Item, IItem
{
    public int Color { get; set; }
    public string Text { get; set; }
    public int FontSize { get; set; }

    public StaticTextItem(string text, int fontSize, int x, int y, int color) :base(x, y)
    {
        Text = text;
        FontSize = fontSize;
        Color = color;
    }

    public void Execute(DisplayManager displayManager)
    {
        displayManager.ShowFixedText(Text, FontSize, X, Y, Color);
    }

    public override string ToString()
    {
        return $"Static text; text = ${Text}; FontSize = ${FontSize}; Color=${Color}";
    }
}
