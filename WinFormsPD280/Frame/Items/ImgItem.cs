
namespace WinFormsPD280.Frame.Items;
public class ImgItem :Item, IItem
{
    public string Name { get; set; }
    public int ShowType { get; set; }

    public ImgItem(string name, int showType, int x, int y) : base(x, y)
    {
        Name = name;
        ShowType = showType;
    }

    public void Execute(DisplayManager displayManager)
    {
        displayManager.ShowPicture(Name, X, Y, ShowType);
    }

    public override string ToString() 
    {
        return $"Image; name = {Name}; show type = {ShowType}";
    }
}
