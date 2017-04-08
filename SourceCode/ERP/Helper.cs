using System.Text;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace ERP
{
    class Helper
    {
        public static void SaveImageCapture(System.Drawing.Image image)
        {
            //11111
            //changed for testing code12356
            SaveFileDialog s = new SaveFileDialog();
            s.FileName = "Image";// Default file name
            s.DefaultExt = ".Jpg";// Default file extension
            s.Filter = "Image (.jpg)|*.jpg"; // Filter files by extension

            // Show save file dialog box
            // Process save file dialog box results
            if (s.ShowDialog() == DialogResult.OK)
            {
                // Save Image
                string fileName = s.FileName;
                FileStream fstream = new FileStream(fileName, FileMode.Create);
                image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
                fstream.Close();

            }

            //asdasdsd
        }
    }
}
