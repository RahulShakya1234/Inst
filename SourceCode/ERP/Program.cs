using System;
using System.Collections.Generic;
using Common;
using System.Windows.Forms;
using ERP.SalePurchase;
using System.Diagnostics;

namespace ERP
{
    public class Program
    {
        //private MDIParentApp _waitForm;
        //protected void ShowWaitForm(string message)
        //{
        //    // don't display more than one wait form at a time
        //    if (_waitForm != null && !_waitForm.IsDisposed)
        //    {
        //        return;
        //    }

        //    _waitForm = new MDIParentApp();
        //    _waitForm.SetMessage(message); // "Loading data. Please wait..."
        //    _waitForm.TopMost = true;
        //    _waitForm.StartPosition = FormStartPosition.CenterScreen;
        //    _waitForm.Show();
        //    _waitForm.Refresh();

        //    // force the wait window to display for at least 700ms so it doesn't just flash on the screen
        //    System.Threading.Thread.Sleep(700);
        //    Application.Idle += OnLoaded;
        //}
        //private void OnLoaded(object sender, EventArgs e)
        //{
        //    Application.Idle -= OnLoaded;
        //    _waitForm.Close();
        //}

        //public void transmitprotocol()
        //{
        //    try
        //    {
        //        MessageBox.Show("Please wait. Uploading logo.", "Status");

        //        // Transmitting protocol coding here. Takes around 2 minutes to finish.

        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex.ToString());
        //    }
        //}
        ///// <summary>
        ///// The main entry point for the application.
        ///// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Common.Common.SetAppSettings(Application.StartupPath);
            Application.Run(new MDIParentApp());
            Application.UseWaitCursor = true;
        }
    }
}
