using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using WinFormsPD280.Frame.Items;

namespace WinFormsPD280.Frame;
public class DisplayFrame : IDisplayFrame
{

    private List<IItem> items;
    public string Name { get; set; }
    public int WaitAfterDisplay { get; set; }

    public DisplayFrame(string name, int waitAfterDisplay = 3)
    {
        items = new List<IItem>();
        WaitAfterDisplay = waitAfterDisplay;
        Name = name;
    }
    public void DisplayMyself(DisplayManager displayManager)
    {
        foreach (var i in items)
        {
            i.Execute(displayManager);
        }
        Thread.Sleep(WaitAfterDisplay * 1000);
    }

    public void AddStaticText(StaticTextItem staticTextItem)
    {
        items.Add(staticTextItem);
    }

    public void AddDynamicText(DynamicTextItem dynamicTextItem)
    {
        items.Add(dynamicTextItem);
    }

    public void AddQrCode(QrCodeItem qrCodeItem)
    {
        items.Add(qrCodeItem);
    }

    public void AddImg(ImgItem imgItem)
    {
        items.Add(imgItem);
    }

    public List<IItem> GetItems() 
    {
        return items;
    }

    public override string ToString()
    {
        return $"name = '{this.Name}'; duration = {this.WaitAfterDisplay}; how many items = {this.items.Count};";
    }

}
