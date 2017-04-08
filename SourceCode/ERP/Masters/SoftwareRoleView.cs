using System;
using System.Data;
using System.Windows.Forms;
using DgvFilterPopup;
using System.Collections.Generic;
using Common;
using ERP;
using ERP.PurelifeErpClient;
using System.Drawing;


namespace ERP.Masters
{
    public partial class SoftwareRoleView : Global.BaseClass
    {
        private static SoftwareRoleView sForm = null;
        int SelectedRow = 0;
        public SoftwareRoleView()
        {
            InitializeComponent();
        }
        public static SoftwareRoleView Instance()
        {
            if (sForm == null) { sForm = new SoftwareRoleView(); }
            return sForm;
        }
        public void BindData()
        {
            try
            {
                using (PurelifeErpClient.PurelifeErpClient clientObj = new PurelifeErpClient.PurelifeErpClient())
                {
                    BindingSource bs = new BindingSource();
                    grdSoftwareRole.DataSource = clientObj.DataListing(PurelifeErpClient.PageName.SoftwareRole);
                    bs.DataSource = grdSoftwareRole.DataSource;
                    if (grdSoftwareRole.DataSource == null) return;
                    if (txtSearch.Text != null)
                    {
                        bs.Filter = string.Format("SoftwareRole LIKE '%{0}%'", txtSearch.Text);
                    }
                    new DgvFilterManager(grdSoftwareRole);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SoftwareRoleView_Load(object sender, EventArgs e)
        {
            // BindData();
            grdSoftwareRole.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10.5f, FontStyle.Bold);
            // grdAccountDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255,255,255);
            grdSoftwareRole.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            new SoftwareRoleAdd(this, 0).ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                SelectedRow = grdSoftwareRole.CurrentRow.Index;
                int codeValue = grdSoftwareRole.Rows[SelectedRow].Cells["Id"].Value.ToInt();
                EditData(SelectedRow, codeValue);
                // BindData();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
        private void EditData(int rowIndex, int codeValue)
        {
            try
            {
                SoftwareRoleAdd addForm = new SoftwareRoleAdd(this, codeValue);
                addForm.txtSoftwareRole.Text = grdSoftwareRole.Rows[rowIndex].Cells["SoftwareRole"].Value.ToString();


                addForm.ShowDialog();
            }
            catch (Exception exception)
            {
                throw exception;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SelectedRow = grdSoftwareRole.CurrentRow.Index;
                int id = GetInt(grdSoftwareRole.Rows[SelectedRow].Cells["Id"].Value);

                using (PurelifeErpClient.PurelifeErpClient purelifeErpClient = new PurelifeErpClient.PurelifeErpClient())
                {
                    purelifeErpClient.Delete(PurelifeErpClient.PageName.SoftwareRole, id);
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdSoftwareRole_MouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.grdSoftwareRole.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Empty;
            }
        }

        private void grdSoftwareRole_MouseEnter(object sender, EventArgs e)
        {
            grdSoftwareRole.DefaultCellStyle.SelectionBackColor = Color.Silver;
        }

        private void grdSoftwareRole_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
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
        
    }
}
