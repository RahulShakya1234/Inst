using System;
using System.Windows.Forms;
using Common;
using Application = System.Windows.Forms.Application;


namespace ERP
{
    public partial class Login : Global.BaseClass
    {
        int _selectedRow = 0;
        KeyValue _k;
        public Login()
        {
            InitializeComponent();
        }
        public Login(KeyValue k)
        {
            _k = k;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool status = true;
            try
            {
                string username = txtUserName.Text;
                string password = txtPassword.Text;
                if (username.ToString() == "" && password.ToString() == "")
                {
                    MessageBox.Show("Enter username and password");
                    return;
                }
                else
                {
                    using (PurelifeErpClient.PurelifeErpClient purelifeErpClient = new PurelifeErpClient.PurelifeErpClient())
                    {
                        PurelifeErpClient.Result res = purelifeErpClient.UserLogin(PurelifeErpClient.PageName.MSTUserDetails, username, password);
                        if (res.Id.ToInt() > 0)
                        {
                            SessionManager.UserCode = res.Id;
                            SessionManager.UserName = username;
                            this.Close();
                            _k.Value = "true";
                            Close();
                        }
                        else
                        {
                            ShowError.SetError(txtPassword, "Please enter correct details");
                            base.ShowMessage("Invalid user, Please enter correct details");     
                        }
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //private void btnLogin_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        bool status = true;

        //        if (string.IsNullOrEmpty(txtUserName.Text))
        //        {
        //            ShowError.SetError(txtUserName, "Please enter user name");
        //            status = false;
        //        }
        //        if (string.IsNullOrEmpty(txtUserName.Text))
        //        {
        //            ShowError.SetError(txtPassword, "Please enter password");
        //            status = false;
        //        }

        //        if (status == false)
        //        {
        //            return;
        //        }

        //        if (txtUserName.Text == "Admin" && txtPassword.Text == "1")
        //        {
        //            SessionManager.UserCode = int.MaxValue;
        //            SessionManager.UserName = "Admin";
        //            this.Close();
        //            K.Value = "true";
        //            return;
        //        }
        //        else
        //        {
        //            MessageBox.Show("Invalid User");
        //            K.Value = "false";
        //            this.Close();
        //            return;
        //        }

        //        //string strLogin = "Select UserCode, UserName from UserMaster Where UserName ='"  + txtUserName.Text + "' and Password = '" + txtPassword.Text + "'";
        //        //DataTable dtLogin = OleDbHelper.ExecuteDataset(Connection.CON, CommandType.Text, strLogin).Tables[0];
        //        //if (dtLogin.Rows.Count > 0)
        //        //{
        //        //    SessionManager.UserCode = Convert.ToInt32(dtLogin.Rows[0]["UserCode"]);
        //        //    SessionManager.UserName = Convert.ToString(dtLogin.Rows[0]["UserName"]);
        //        //    this.Close();
        //        //    K.Value = "true";
        //        //}
        //        //else
        //        //{
        //        //    K.Value = "false";
        //        //    ShowError.SetError(txtPassword, "Please enter correct details");
        //        //    base.ShowMessage("Invalid user, Please enter correct details");
        //        //    txtPassword.Clear();
        //        //    txtPassword.Focus();
        //        //}

        //        //while (BISystemInitilise.CanContinue == false)
        //        //{
        //        //    Console.Write("Waiting");
        //        //}

        //    }
        //    catch (Exception)
        //    {

        //    }

        //}

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //Company.SysConFg();
        }


    }
}
