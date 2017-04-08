using System;
using System.Data;
using System.Windows.Forms;
using DgvFilterPopup;
using System.Collections.Generic;
using Common;
using ERP;
using ERP.PurelifeErpClient;
using System.Drawing;
namespace ERP.SalePurchase
{
    public partial class ItemGroupView : Global.BaseClass
    {


        private static ItemGroupView sForm = null;
        int SelectedRow = 0;

        public ItemGroupView()
        {
            InitializeComponent();
        }
        public static ItemGroupView Instance()
        {
            if (sForm == null) { sForm = new ItemGroupView(); }
            return sForm;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            new ItemGroupAdd(this, 0).ShowDialog();
        }
        private void SetButtons()
        {
            //btnRefresh.SetBackGroundImage();
            btnADD.SetBackGroundImage();
            btnEdit.SetBackGroundImage();
            btnDelete.SetBackGroundImage();
            btnExit.SetBackGroundImage();
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
                    grdItemGroupView.DataSource = clientObj.DataListing(PurelifeErpClient.PageName.ItemGroup);
                    bs.DataSource = grdItemGroupView.DataSource;
                    if (grdItemGroupView.DataSource == null) return;
                    if (txtSearch.Text != null)
                    {
                        bs.Filter = string.Format("ItemGroupName LIKE '%{0}%'", txtSearch.Text);
                    }
                    new DgvFilterManager(grdItemGroupView);
                }
            }
                
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ItemGroupView_Load(object sender, EventArgs e)
        {
           // BindData();
            grdItemGroupView.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10.5f, FontStyle.Bold);
            // grdAccountDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255,255,255);
            grdItemGroupView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            try
            {
                SelectedRow = grdItemGroupView.CurrentRow.Index;
                int codeValue = grdItemGroupView.Rows[SelectedRow].Cells["ItemGroupMasId"].Value.ToInt();
                EditData(SelectedRow, codeValue);
               // BindData();
            }
            catch (Exception exception)
            {
                throw exception;
            }
           
         
        }

        //private void EditData(int SelectedRow, double codeValue)
        //{
        //    try
        //    {
        //        ItemGroupAdd addForm = new ItemGroupAdd(this, codeValue);
        //        addForm.ShowDialog();
        //    }
        //    catch (Exception exception)
        //    {
        //        //ErrorLog.LogErrorInTxtFormat(exception);
        //    }
        //}

        private void EditData(int rowIndex, int codeValue)
        {
            try
            {
                ItemGroupAdd addForm = new ItemGroupAdd(this, codeValue);
                addForm.txtGroupName.Text = grdItemGroupView.Rows[rowIndex].Cells["ItemGroupName"].Value.ToString();
                addForm.ddlUpperGroup.SelectedValue = grdItemGroupView.Rows[rowIndex].Cells["UpperGroup"].Value.ToString();
                addForm.txtPrefix.Text = grdItemGroupView.Rows[rowIndex].Cells["Prefix"].Value.ToString();
                addForm.ddlSalableItemGrp.SelectedValue = grdItemGroupView.Rows[rowIndex].Cells["SalableItemGrp"].Value.ToString().ToLower() == "true" ? "1" : "0";
                addForm.ddlAutomaticQC.SelectedValue = grdItemGroupView.Rows[rowIndex].Cells["AutomaticQC"].Value.ToString().ToLower() == "true" ? "1" : "0";
                addForm.ddlAutoAssemlyfromRGP.SelectedValue = grdItemGroupView.Rows[rowIndex].Cells["AutoAssemblyFromRGP"].Value.ToString().ToLower() == "true" ? "1" : "0";
                addForm.ddlAutoMRN.SelectedValue = grdItemGroupView.Rows[rowIndex].Cells["AutoMrn"].Value.ToString().ToLower() == "true" ? "1" : "0";
                addForm.ddlPORequiredinMRN.SelectedValue = grdItemGroupView.Rows[rowIndex].Cells["POReqInMRN"].Value.ToString().ToLower() == "true" ? "1" : "0";
                addForm.ddlShowinWorkerOrder.SelectedValue = grdItemGroupView.Rows[rowIndex].Cells["ShowInWorkerOrder"].Value.ToString().ToLower() == "true" ? "1" : "0";
                addForm.ddlMakeAutoProductionEntry.SelectedValue = grdItemGroupView.Rows[rowIndex].Cells["MakeAutoProdEntry"].Value.ToString().ToLower() == "true" ? "1" : "0";
                addForm.ddlScheduleNoRequiredinMRN.SelectedValue = grdItemGroupView.Rows[rowIndex].Cells["ScheduleNoRequiredinMRN"].Value.ToString().ToLower() == "true" ? "1" : "0";
                addForm.ShowDialog();
            }   
            catch (Exception exception)
            {
                throw exception;
            }

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                SelectedRow = grdItemGroupView.CurrentRow.Index;
                int id = GetInt(grdItemGroupView.Rows[SelectedRow].Cells["ItemGroupMasId"].Value);

                using (PurelifeErpClient.PurelifeErpClient purelifeErpClient = new PurelifeErpClient.PurelifeErpClient())
                {
                    purelifeErpClient.Delete(PurelifeErpClient.PageName.ItemGroup, id);
                    purelifeErpClient.Close();
                }
                if (id > 0)
                {


                    var confirmResult = MessageBox.Show("Are you sure to delete this item ?",
                       "Confirm Delete!!",
                       MessageBoxButtons.YesNo);

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void DeleteData(double codeValue)
        {
            try
            {
                //base.Delete("ItemsGroupAdd", "Id", codeValue.ToString());
                BindData();
            }
            catch (Exception exception)
            {
                //ErrorLog.LogErrorInTxtFormat(exception);
            }
        }

        private void grdItemGroupView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private void btnFind_Click(object sender, EventArgs e)
        //{
        //    BindData();
           
        //}

        private void btnRefresh_Click(object sender, EventArgs e)
        {
           // BindData();
            //this.Refresh();
            //ItemGroupView frm = new ItemGroupView();
            //frm.Refresh();
        }

        private void grdItemGroupView_MouseEnter(object sender, EventArgs e)
        {
            grdItemGroupView.DefaultCellStyle.SelectionBackColor = Color.Silver;
        }

        private void grdItemGroupView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                this.grdItemGroupView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(232, 232, 232);
                //this.grdAccountGroupDetails.Rows[lastindex].DefaultCellStyle.BackColor = Color.SkyBlue; 
                //lastindex = e.RowIndex;
            }
        }

        private void grdItemGroupView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.grdItemGroupView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Empty;
            }
        }

        private void btnFind_Click_1(object sender, EventArgs e)
        {
            BindData();
        }

        private void groupBox1_Paint(object sender, PaintEventArgs p)
        {
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

        private void btnFind_Click(object sender, EventArgs e)
        {
            BindData();
        }
        //private void btnADD_Click(object sender, EventArgs e)
        ////{

        ////}

        //private void btnExit_Click_1(object sender, EventArgs e)
        //{

        //}

        //private void btnDelete_Click_1(object sender, EventArgs e)
        //{

        //}

        //private void btnEdit_Click_1(object sender, EventArgs e)
        //{

        //}

        //private void btnADD_Click_1(object sender, EventArgs e)
        //{

        //}
    }
}
