
using System.Diagnostics.CodeAnalysis;

namespace WinFormsPD280.Frame.Items;
public class QrCodeItem : Item, IItem
{
    public string Text { get; set; }
    public int Size { get; set; }


    public QrCodeItem(string text, int size, int x, int y):base(x, y)
    {
        Text = text;
        Size = size;
    }

    public void Execute(DisplayManager displayManager)
    {
        displayManager.ShowQrCode(Text, Size, X, Y);
    }

    public override string ToString() 
    {
        return $"QrCode; text = {Text}; size = {Size}";
    }
}
