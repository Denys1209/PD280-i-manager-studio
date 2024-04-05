
using System.Runtime.InteropServices;

namespace WinFormsPD280;
class PD280Functions
{
    [DllImport(".\\dlls\\TPD280DLL.dll", EntryPoint = "OpenComm")]
    public static extern Boolean OpenComm(string comPort, int baudrate);

    // CloseComm method
    [DllImport(".\\dlls\\TPD280DLL.dll", EntryPoint = "CloseComm")]
    public static extern void CloseComm();

    // DSP_Init method
    [DllImport(".\\dlls\\TPD280DLL.dll", EntryPoint = "DSP_Init")]
    public static extern int DSP_Init();

    // DSP_Restart method
    [DllImport(".\\dlls\\TPD280DLL.dll", EntryPoint = "DSP_Restart")]
    public static extern int DSP_Restart();

    // DSP_SetStyle method
    [DllImport(".\\dlls\\TPD280DLL.dll", EntryPoint = "DSP_SetStyle")]
    public static extern int DSP_SetStyle(int n);

    // DSP_UploadPicture method
    [DllImport(".\\dlls\\TPD280DLL.dll", EntryPoint = "DSP_UploadPicture")]
    public static extern int DSP_UploadPicture(string fileName, string filePath, int width, int height);

    // DSP_ShowPicture method
    [DllImport(".\\dlls\\TPD280DLL.dll", EntryPoint = "DSP_ShowPicture")]
    public static extern int DSP_ShowPicture(string fileName, int x, int y, int type);

    // DSP_ShowQrCode method
    [DllImport(".\\dlls\\TPD280DLL.dll", EntryPoint = "DSP_ShowQrCode")]
    public static extern int DSP_ShowQrCode(string text, int size, int x, int y);

    [DllImport(".\\dlls\\TPD280DLL.dll", EntryPoint = "DSP_ShowFixedText")]
    public static extern int DSP_ShowFixedText(string text, int size, int x, int y, int color);

    // DSP_ShowDynamicText method
    [DllImport(".\\dlls\\TPD280DLL.dll", EntryPoint = "DSP_ShowDynamicText")]
    public static extern int DSP_ShowDynamicText(string text, int id, int size, int x, int y, int color);


    public static void HandleError(int errorCode)
    {
        string errorMessage;
        switch (errorCode)
        {
            case 0:
                // Success, no message needed
                return;
            case 1:
                errorMessage = "Serial port not opened";
                break;
            case 2:
                errorMessage = "Serial port is busy";
                break;
            case 3:
                errorMessage = "Timeout";
                break;
            case 4:
                errorMessage = "Handshake failed";
                break;
            case 5:
                errorMessage = "File does not exist";
                break;
            case 6:
                errorMessage = "Wrong file number";
                break;
            case 7:
                errorMessage = "Download failed";
                break;
            case 8:
                errorMessage = "Text is empty";
                break;
            case 9:
                errorMessage = "Execution failed";
                break;
            case 10:
                errorMessage = "Bad file format";
                break;
            case 11:
                errorMessage = "Wrong file name";
                break;
            case 12:
                errorMessage = "Unknown device";
                break;
            default:
                errorMessage = $"Unknown error code: {errorCode}";
                break;
        }

        // Display the error message using a MessageBox
        MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
