
using System.Text;

namespace WinFormsPD280;
class DisplayManager
{
    private bool isConnect;
    public readonly int Height;
    public readonly int Width;
    private readonly int SizeForPaint; 

    public DisplayManager(int height = 320, int width = 240)
    {
        isConnect = false;
        this.Height = height;
        this.Width = width;
        this.SizeForPaint = 1;
    }

    public bool Connect(String com, int baudrate)
    {
        Boolean test = PD280Functions.OpenComm(com, baudrate);
        if (test)
        {
            isConnect = true;
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Disconnect()
    {
        this.isConnect = false;
        PD280Functions.CloseComm();
    }

    public void InitializeDisplay()
    {
        int result = PD280Functions.DSP_Init();
        PD280Functions.HandleError(result);
    }

    public void RestartDisplay()
    {
        int result = PD280Functions.DSP_Restart();
        PD280Functions.HandleError(result);
    }

    public void SetDisplayStyle(int style)
    {
        int result = PD280Functions.DSP_SetStyle(style);
        PD280Functions.HandleError(result);
    }

    public  void UploadPicture(string fileName, string filePath, int width, int height)
    {
        int result = PD280Functions.DSP_UploadPicture(fileName, filePath, width, height);
        PD280Functions.HandleError(result);
    }

    public void ShowPicture(string fileName, int x, int y, int type)
    {
        int result = PD280Functions.DSP_ShowPicture(fileName, x, y, type);
        PD280Functions.HandleError(result);
    }

    public void ShowQrCode(string text, int size, int x, int y)
    {
        int result = PD280Functions.DSP_ShowQrCode(text, size, x, y);
        PD280Functions.HandleError(result);
    }

    public void ShowFixedText(string text, int size, int x, int y, int color)
    {
        int result = PD280Functions.DSP_ShowFixedText(text, size, x, y, color);
        PD280Functions.HandleError(result);
    }

    public void ShowDynamicText(string text, int id, int size, int x, int y, int color)
    {
        int result = PD280Functions.DSP_ShowDynamicText(text, id, size, x, y, color);
        PD280Functions.HandleError(result);
    }

    public void PaintRectangle(int height, int width,int color, int x, int y) 
    {
        StringBuilder text = new StringBuilder(height*width+width);

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                text.Append('@');
            }

            text.Append('\n');
        }
        string textToPaint = text.ToString();
        for (int i = 0; i < 20; ++i) {
            int result = PD280Functions.DSP_ShowFixedText(text.ToString(), SizeForPaint, x, y, color);
            PD280Functions.HandleError(result);
        }
    }
}