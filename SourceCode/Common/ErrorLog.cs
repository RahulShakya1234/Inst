using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class ErrorLog : IDisposable
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ex"></param>
        public static void LogErrorInTxtFormat(Exception ex)
        {
            //MessageBox.Show(ex.Message);

            Exception exception = ex;

            System.Text.StringBuilder sBody = new StringBuilder();

            sBody.Append("------------------------------------------------------------\n");
            sBody.Append("---          .NET Thrown Exception Class Details         ---\n");
            sBody.Append("------------------------------------------------------------\n\n");

            sBody.AppendFormat("\n\nSource: {0}\n\n", exception.Source);
            sBody.AppendFormat("\n\nMessage: {0}\n\n", exception.Message);
            sBody.AppendFormat("\n\nStack trace: {0}\n\n", exception.StackTrace);
            sBody.AppendFormat("\n\nInner Exception: {0}\n\n", exception.InnerException);
            sBody.AppendFormat("\n\nBase Exception: {0}\n\n", exception.GetBaseException());

            //MessageBox.Show(exception.Message);
            // Writing error details in a file
            try
            {


                string directoryPath = Settings.AppPath + @"\Logs\";
                System.IO.DirectoryInfo dirInfo = new System.IO.DirectoryInfo(directoryPath);

                if (!dirInfo.Exists)
                {
                    dirInfo.Create();
                }

                System.IO.FileStream fs = new System.IO.FileStream(directoryPath + DateTime.Now.ToString("dd_MM_yyyy") + ".txt", System.IO.FileMode.Append, System.IO.FileAccess.Write);

                System.IO.StreamWriter sw = new System.IO.StreamWriter(fs);

                sw.Write(sBody.ToString());

                sw.Close();
                fs.Close();
            }
            catch
            {
            }

        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            this.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
