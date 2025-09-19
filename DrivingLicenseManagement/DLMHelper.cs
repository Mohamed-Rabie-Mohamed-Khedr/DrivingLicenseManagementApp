using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

internal static class DLMHelper
{
    internal static bool IsAppExit = true;
    internal static Bitmap GetImage(string path)
    {
		Bitmap bmp = null;
		try
		{
            if (File.Exists(path))
            {
                FileStream file = new FileStream(path, FileMode.Open);
                bmp = new Bitmap(file);
                file.Close();
            }
        }
        catch (Exception ex)
		{
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
        return bmp;
    }

    internal static Bitmap GetImagePersonDefault(bool IsMale)
    {
        if (IsMale)
            return DrivingLicenseManagement.Properties.Resources.male;
        else
            return DrivingLicenseManagement.Properties.Resources.female;
    }

    internal static bool RemoveFile(string path)
    {
        bool result = false;
        try
        {
            if (File.Exists(path))
            {
                File.Delete(path);
                result = true;
            }
        }
        catch (Exception ex)
        {
            result = false;
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return result;
    }
}