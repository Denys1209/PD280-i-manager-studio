
using WinFormsPD280.Frame.Items;

namespace WinFormsPD280.Frame;
public interface IDisplayFrame
{
    public void DisplayMyself(DisplayManager displayManager);
    public void AddStaticText(StaticTextItem staticTextItem);

    public void AddDynamicText(DynamicTextItem dynamicTextItem);

    public void AddQrCode(QrCodeItem qrCodeItem);

    public void AddImg(ImgItem imgItem);

    public List<IItem> GetItems();


}
