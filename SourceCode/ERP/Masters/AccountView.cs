using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DgvFilterPopup;
using System.Linq;
using Common;

using ERP;

using System.Data.OleDb;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Drawing.Drawing2D;

namespace ERP.SalePurchase
{
    public partial class AccountView : Global.BaseClass
    {
        private static AccountView sForm = null;
        int SelectedRow = 0;
        public AccountView()
        {
            InitializeComponent();
        }

        public static AccountView Instance()
        {
            if (sForm == null) { sForm = new AccountView(); }
            return sForm;
        }



        // Color colour = ColorTranslator.FromHtml("#0000FF");
        private void AccountView_Load(object sender, EventArgs e)
        {
            SetButtons();
            //BindData();
            BindDropDown();
            //BindDDLDefaultValue();
            //groupBox1.borderColor = Color.Black;
            //BindData("All");
            //grdAccountDetails.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10.5f, FontStyle.Bold);
            ddlPrimaryGroup.Focus();
        }

        public void BindDropDown()
        {
            //fill the account group combo
            //BindDDLDefaultValue();
            FillCombo(ddlState, 18);
            FillCombo(ddlPrimaryGroup, Common.Masters.AccountGroup, "All");

        }
        private void SetButtons()
        {
            btnAdd.SetBackGroundImage();
            btnEdit.SetBackGroundImage();
            btnDelete.SetBackGroundImage();
            btnExit.SetBackGroundImage();
            //btnRefresh.SetBackGroundImage();
            btnFind.SetBackGroundImage();
        }

        public void BindData()
        {

            //grdItemGroupView.DataSource = OleDbHelper.ExecuteDataset(Connection.CON, CommandType.Text, " SELECT * from ItemsGroupAdd;").Tables[0];
            //new DgvFilterManager(grdItemGroupView);

            try
            {
                using (PurelifeErpClient.PurelifeErpClient clientObj = new PurelifeErpClient.PurelifeErpClient())
                {
                    BindingSource bs = new BindingSource();
                    grdAccountDetails.DataSource = clientObj.DataListing(PurelifeErpClient.PageName.Account);
                    bs.DataSource = grdAccountDetails.DataSource;
                    //if (txtByName.Text != null)
                    //{
                    //    bs.Filter = string.Format("AccountName LIKE '%{0}%'", txtByName.Text);
                    //}
                    if (grdAccountDetails.DataSource == null) return;
                    if (ddlState.SelectedValue.ToInt() > 0)
                    {
                        bs.Filter = string.Format("State = {0}", ddlState.SelectedValue);
                    }

                    if (ddlPrimaryGroup.SelectedValue.ToInt() > 0)
                    {
                        bs.Filter = string.Format("AccountGroupMasId= {0}", ddlPrimaryGroup.SelectedValue);
                        //bs.Filter = string.Format("AccountGroupMasId", ddlGroupName.SelectedValue);
                    }

                    if (ddlPrimaryGroup.SelectedValue.ToString() == "0")
                    {
                        grdAccountDetails.DataSource = clientObj.DataListing(PurelifeErpClient.PageName.Account);
                        bs.DataSource = grdAccountDetails.DataSource;
                    }
                    new DgvFilterManager(grdAccountDetails);
                }
            }
            catch (Exception exception)
            {
                //ErrorLog.LogErrorInTxtFormat(exception);
                throw exception;
            }
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                SelectedRow = grdAccountDetails.CurrentRow.Index;
                double codeValue = grdAccountDetails.Rows[SelectedRow].Cells["AccountMasId"].Value.ToInt();
                EditMaster(SelectedRow, codeValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        #region Delete

        /// <summary>
        /// Delete the master for the respective table
        /// </summary>
        private void DeleteMaster(Double codeValue)
        {
            try
            {

                //base.Delete("AccMas", "AccCode", codeValue.ToString());

                BindData();

            }
            catch (Exception exception)
            {
                //ErrorLog.LogErrorInTxtFormat(exception);
            }

        }

        #endregion

        #region Edit Master

        /// <summary>
        /// Edit Master
        /// </summary>
        /// <param name="rowIndex"></param>
        private void EditMaster(int rowIndex, double codeValue)
        {
            try
            {
                //AccountAdd addForm = new AccountAdd(this, codeValue);
                //addForm.ShowDialog();

                AccountAdd addForm = new AccountAdd(this, codeValue);
                addForm.txtAccountType.Text = grdAccountDetails.Rows[rowIndex].Cells["AccountName"].Value.ToString();
                addForm.ddlPrimaryGroup.SelectedValue = grdAccountDetails.Rows[rowIndex].Cells["AccountGroupMasId"].Value.ToString();
                addForm.ddlAccountType.SelectedValue = grdAccountDetails.Rows[rowIndex].Cells["AccType"].Value.ToString();
                addForm.txtBalance.Text = grdAccountDetails.Rows[rowIndex].Cells["Balance"].Value.ToString();
                addForm.ddlDrCr.SelectedValue = grdAccountDetails.Rows[rowIndex].Cells["BalanceType"].Value.ToString();
                //  addForm.ddlDrCr.SelectedValue = grdAccountDetails.Rows[rowIndex].Cells["BalanceTypeName"].Value.ToString();
                addForm.ddlState.SelectedValue = grdAccountDetails.Rows[rowIndex].Cells["State"].Value.ToString();
                addForm.ddlSaleType.SelectedValue = grdAccountDetails.Rows[rowIndex].Cells["STypeCode"].Value.ToString();
                addForm.ddlPurchaseType.SelectedValue = grdAccountDetails.Rows[rowIndex].Cells["PTypeCode"].Value.ToString();

                addForm.txtAddress1.Text = grdAccountDetails.Rows[rowIndex].Cells["Address"].Value.ToString();
                addForm.txtMobileNo.Text = grdAccountDetails.Rows[rowIndex].Cells["MobileNo"].Value.ToString();
                addForm.txtEmail.Text = grdAccountDetails.Rows[rowIndex].Cells["EMail"].Value.ToString();
                addForm.txtRegistration.Text = grdAccountDetails.Rows[rowIndex].Cells["RegistratnNo"].Value.ToString();
                addForm.txtPLACodeNo.Text = grdAccountDetails.Rows[rowIndex].Cells["PLACodeNo"].Value.ToString();
                addForm.txtCommodity.Text = grdAccountDetails.Rows[rowIndex].Cells["Commodity"].Value.ToString();
                addForm.txtRange.Text = grdAccountDetails.Rows[rowIndex].Cells["Range"].Value.ToString();
                addForm.txtDivision.Text = grdAccountDetails.Rows[rowIndex].Cells["Division"].Value.ToString();
                addForm.txtCollactorate.Text = grdAccountDetails.Rows[rowIndex].Cells["Collectorate"].Value.ToString();

                addForm.txtPanNo.Text = grdAccountDetails.Rows[rowIndex].Cells["PanNo"].Value.ToString();
                addForm.txtCSTNo.Text = grdAccountDetails.Rows[rowIndex].Cells["CSTNo"].Value.ToString();
                addForm.txtSTNo.Text = grdAccountDetails.Rows[rowIndex].Cells["TinSTNo"].Value.ToString();
                addForm.txtECCNo.Text = grdAccountDetails.Rows[rowIndex].Cells["ECCNo"].Value.ToString();
                addForm.txtCreditDays.Text = grdAccountDetails.Rows[rowIndex].Cells["CreditDays"].Value.ToString();
                addForm.ddlAdjBillWise.SelectedValue = grdAccountDetails.Rows[rowIndex].Cells["AdjBillWise"].Value.ToString().ToLower() == "true" ? "1" : "0";
                addForm.txtTDSRate.Text = grdAccountDetails.Rows[rowIndex].Cells["TDSRate"].Value.ToString();

                addForm.txtTDSCategory.Text = grdAccountDetails.Rows[rowIndex].Cells["TDSCategory"].Value.ToString();
                addForm.ddlLockAcc.SelectedValue = grdAccountDetails.Rows[rowIndex].Cells["LockAccount"].Value.ToString().ToLower() == "true" ? "1" : "0";
                addForm.txtModeofTransport.Text = grdAccountDetails.Rows[rowIndex].Cells["ModeofTransport"].Value.ToString();
                addForm.txtNatureofPay.Text = grdAccountDetails.Rows[rowIndex].Cells["NatureofPay"].Value.ToString();
                addForm.txtVenderCode.Text = grdAccountDetails.Rows[rowIndex].Cells["VenderCode"].Value.ToString();
                addForm.ddlTypeOfSupplier.SelectedValue = grdAccountDetails.Rows[rowIndex].Cells["typeOfSupplier"].Value.ToString();
                addForm.txtCountry.Text = grdAccountDetails.Rows[rowIndex].Cells["Country"].Value.ToString();
                addForm.txtDestination.Text = grdAccountDetails.Rows[rowIndex].Cells["Destination"].Value.ToString();

                addForm.txtFax.Text = grdAccountDetails.Rows[rowIndex].Cells["Fax"].Value.ToString();
                addForm.txtCodeNo.Text = grdAccountDetails.Rows[rowIndex].Cells["CodeNo"].Value.ToString();
                addForm.txtDiscount.Text = grdAccountDetails.Rows[rowIndex].Cells["Discount"].Value.ToString();
                addForm.ddlCustomerType.SelectedValue = grdAccountDetails.Rows[rowIndex].Cells["TypeofCustomer"].Value.ToString();
                addForm.txtLocation.Text = grdAccountDetails.Rows[rowIndex].Cells["Location"].Value.ToString();
                addForm.txtIntrestRate.Text = grdAccountDetails.Rows[rowIndex].Cells["InterestRate"].Value.ToString();
                addForm.ddlActive.SelectedValue = grdAccountDetails.Rows[rowIndex].Cells["Active"].Value.ToString().ToLower() == "true" ? "1" : "0";
                addForm.ShowDialog();

            }
            catch (Exception exception)
            {
                ErrorLog.LogErrorInTxtFormat(exception);
            }

        }
        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                SelectedRow = grdAccountDetails.CurrentRow.Index;
                int id = GetInt(grdAccountDetails.Rows[SelectedRow].Cells["AccountMasId"].Value);

                using (PurelifeErpClient.PurelifeErpClient purelifeErpClient = new PurelifeErpClient.PurelifeErpClient())
                {
                    purelifeErpClient.Delete(PurelifeErpClient.PageName.Account, id);
                    purelifeErpClient.Close();
                }
                if (id > 0)
                {


                    var confirmResult = MessageBox.Show("Are you sure to delete this item ?", "Confirm Delete!!", MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.Yes)
                    {
                        MessageBox.Show("Successfully Deleted");
                        // this.Close();
                    }

                    else
                    {
                        return;
                    }
                }


                BindData();
            }
            catch (Exception exception)
            {
                ErrorLog.LogErrorInTxtFormat(exception);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AccountAdd(this, 0).ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // public class SolidColorBrush { }
        private void grdAccountDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //SolidColorBrush sbColorBrush = new SolidColorBrush(Color.Lavender);
            //grdAccountDetails.BackgroundColor = sbColorBrush;
            //this.BackColor = Color.LightCyan;
            //this.ForeColor = System.Drawing.Color.LightCyan;
            //grdAccountDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            //grdAccountDetails.DefaultCellStyle.Font = new Font("Calibri", 10.25f, FontStyle.Regular);
            //grdAccountDetails.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 11, FontStyle.Regular);
            //grdAccountDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.BurlyWood;
            //grdAccountDetails.EnableHeadersVisualStyles = false;
            //grdAccountDetails.RowHeadersVisible = false;


        }
        //  int _selectedIndex;
        //string _text;
        private void btnFind_Click(object sender, EventArgs e)
        {
        }

        private void ddlGroupName_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void ddlGroupName_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnFind_Click_1(object sender, EventArgs e)
        {
            //   if (txtByName.Text != null || txtStateCity.Text != null || ddlGroupName.SelectedValue != null)
            // if (ddlGroupName.SelectedValue == "0")
            {
                BindData();
            }
            //else
            //{
            //    return;
            //}
        }

        private void txtByName_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                SelectedRow = grdAccountDetails.CurrentRow.Index;
                int id = GetInt(grdAccountDetails.Rows[SelectedRow].Cells["AccountMasId"].Value);

                using (PurelifeErpClient.PurelifeErpClient purelifeErpClient = new PurelifeErpClient.PurelifeErpClient())
                {
                    purelifeErpClient.Delete(PurelifeErpClient.PageName.Account, id);
                    //purelifeErpClient.Close();
                }
                BindData();
                if (id > 0)
                {
                    ShowMessage("Deleted successfully");
                    //Close();
                }
                else
                {
                    ShowMessage("Error Please Try Later");

                }
            }
            catch (Exception exception)
            {
                ErrorLog.LogErrorInTxtFormat(exception);
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        //public void BindDDLDefaultValue(AccountGroup ddl)
        //{
        //    ListItem li = new ListItem("All", "0");
        //    ddl.Items.Insert(0, li);    
        //    //ListItem li = new ListItem("Please Select", "0");
        //   // ddlGroupName.Items.Add(new ListItem("ALL", "0"));
        //    //ddlGroupName.Items.Insert(0, "All");
        //}
        private void ddlGroupName_onload(object sender, EventArgs e)
        {
            //string selected = "";
            //if (ddlGroupName.Items.Count > 0 && ddlGroupName.SelectedIndex != 0)
            //{
            //    selected = ddlGroupName.SelectedValue.ToString();
            //}

            //if (!String.IsNullOrEmpty(selected))
            //{
            //    ddlGroupName.SelectedValue = selected;

            //ddlGroupName.Items.Add(new ListItem("ALL", "0"));
            //com li = new ComboBox("Please Select", "0");
            //ddl.Items.Insert(0, li);
            //ddlGroupName.Items.Insert(0,);
        }

        private void grdAccountDetails_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdAccountDetails_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                this.grdAccountDetails.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(232, 232, 232);
                //this.grdAccountGroupDetails.Rows[lastindex].DefaultCellStyle.BackColor = Color.SkyBlue; 
                //lastindex = e.RowIndex;
            }
        }

        private void grdAccountDetails_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.grdAccountDetails.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Empty;
            }
        }

        private void grdAccountDetails_MouseEnter(object sender, EventArgs e)
        {
            grdAccountDetails.DefaultCellStyle.SelectionBackColor = Color.Silver;
        }

        //private void groupBox1_Enter(object sender, PaintEventArgs e)

        //{
        //    ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);

        //}
        //groupBox1.Paint += PaintBorderlessGroupBox;



        //private void PaintBorderlessGroupBox(object sender, PaintEventArgs e)
        //{
        //    groupBox1.Paint += PaintBorderlessGroupBox;

        //    GroupBox box = (GroupBox)sender;
        //    e.Graphics.Clear(SystemColors.Control);
        //    e.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 0, 0);

        //    //GroupBox box = sender as GroupBox;
        //    //  ControlPaint.DrawBorder( e.Graphics, Color.Red, Color.Blue);
        //}



        //        private void groupBox1_Load(object sender, EventArgs e)
        //        {
        ////            myGroupBox myGroupBox = new myGroupBox();
        ////            myGroupBox.Text = "GroupBox1";
        ////            this.FormBorderStyle = FormBorderStyle.Fixed3D;
        ////            this.Controls.Add(myGroupBox);

        ////                Graphics g = this.CreateGraphics();
        ////Pen pen = new Pen(Color.Black, 2);

        ////g.DrawRectangle(pen, 100,100, 100, 200);



        //        }

        //public class myGroupBox : GroupBox
        //{
        //    private Color borderColor;

        //    public Color BorderColor
        //    {
        //        get { return this.borderColor; }
        //        set { this.borderColor = value; }
        //    }

        //    public myGroupBox()
        //    {
        //        this.borderColor = Color.Black;
        //    }

        //    protected override void OnPaint(PaintEventArgs e)
        //    {
        //        Size tSize = TextRenderer.MeasureText(this.Text, this.Font);

        //        Rectangle borderRect = e.ClipRectangle;
        //        borderRect.Y += tSize.Height / 2;
        //        borderRect.Height -= tSize.Height / 2;
        //        ControlPaint.DrawBorder(e.Graphics, borderRect, this.borderColor, ButtonBorderStyle.Outset);

        //        Rectangle textRect = e.ClipRectangle;
        //        textRect.X += 6;
        //        textRect.Width = tSize.Width;
        //        textRect.Height = tSize.Height;
        //        e.Graphics.FillRectangle(new SolidBrush(this.BackColor), textRect);
        //        e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), textRect);
        //    }
        //}

        ////protected override void OnPaint(PaintEventArgs e)
        ////{
        ////    base.OnPaint(e);
        ////    int borderWidth = 2;
        ////    Color borderColor = Color.Blue;
        ////}

        private void groupBox1_Paint_1(object sender, PaintEventArgs p)
        {
            //base.OnPaint(e);
            //int borderWidth = 2;
            //Color borderColor = Color.Blue;

            GroupBox box = (GroupBox)sender;
            p.Graphics.Clear(SystemColors.Control);
            p.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 0, 0);
            DrawGroupBox(box, p.Graphics, Color.Red, Color.Black);
            ControlPaint.DrawBorder(p.Graphics, this.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                //Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 2,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                // Clear text and border
                g.Clear(this.BackColor);

                // Draw text
                // g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

                // Drawing Border
                //Left
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                // g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                //Top2
                // g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }

        private void grdAccountDetails_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
