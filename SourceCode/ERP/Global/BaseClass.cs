using System;
using System.Collections.Generic;
using System.Text;
using WinControlLibrary;
using System.Data;

using System.Windows.Forms;
using ERP;
using Common;
using System.Web.UI.WebControls;


namespace ERP.Global
{
    public class BaseClass : System.Windows.Forms.Form
    {
        private ErrorProvider EP;
        public NotifyIcon notifyIcon1 = new NotifyIcon();

        private System.ComponentModel.IContainer components;

        public BaseClass()
        { EP = new ErrorProvider(); }


        /// <summary>
        /// Check for the required field, returns true if fail  else return false.
        /// </summary>
        /// <param name="control">TextBox ID</param>
        /// <returns></returns>
        public bool CheckRequiredField(BTextBox control)
        {
            if (string.IsNullOrEmpty(control.Text))
            {
                EP.SetError(control, Messages.Required);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckRequiredField(BDateTextBox control)
        {
            if (string.IsNullOrEmpty(control.Text))
            {
                EP.SetError(control, Messages.Required);
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Check for the required field, returns true if fail  else return false.
        /// </summary>
        /// <param name="control">TextBox ID</param>
        /// <returns></returns>
        internal bool CheckRequiredField(BCombo control)
        {
            if (control.Text.ToLower() == "select" || control.SelectedIndex == 0)
            {
                EP.SetError(control, Messages.Required);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.EP = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EP)).BeginInit();
            this.SuspendLayout();
            // 
            // EP
            // 
            this.EP.ContainerControl = this;
            // 
            // BaseClass
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "BaseClass";
            ((System.ComponentModel.ISupportInitialize)(this.EP)).EndInit();
            this.ResumeLayout(false);

        }
        public int GetInt(object obj)
        {
            int res = 0;
            int.TryParse(obj.ToString(), out res);
            return res;
        }
        #region Get String Value

        /// <summary>
        /// </summary>
        /// <param name="obj"object></param>
        /// <returns>StringValue</returns>
        public string GetString(object obj)
        {
            try
            {
                return obj != null ? Convert.ToString(obj) : string.Empty;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
        #endregion

        #region Is Allow Deletion

        /// <summary>
        /// Is Allow Deletion
        /// </summary>
        /// <returns></returns>
        public bool IsAllowDeletion()
        {
            if (MessageBox.Show(Messages.Delete, Messages.Required, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        #endregion

        public string GetGridCellValue(BGrid gridCtrl, int rowIndex, int columnIndex)
        {
            string cellvalue = string.Empty;
            if (rowIndex >= 0 && columnIndex >= 0)
            {
                if (gridCtrl.RowCount > rowIndex)
                {
                    cellvalue = GetString(gridCtrl.Rows[rowIndex].Cells[columnIndex].Value);
                }
            }
            return cellvalue;
        }

        #region FillCombo

        /// <summary>
        /// fill combo as per requirement
        /// </summary>
        /// <param name="combo">ddrop down object</param>
        /// <param name="type">
        /// 1-[Yes,No]    ,   2-[True, False]    ,3-[BType-B-Sheat,P/L Acc, Trading]
        /// </param>

        public void FillCombo(BCombo combo, int type)
        {
            if (combo == null) return;
            List<KeyValue> lst = new List<KeyValue>();
            switch (type)
            {
                case 1:
                    {
                        lst.Add(new KeyValue { Key = "0", Value = "No" });
                        lst.Add(new KeyValue { Key = "1", Value = "Yes" });
                    }
                    break;
                case 2:
                    {
                        lst.Add(new KeyValue { Key = "0", Value = "False" });
                        lst.Add(new KeyValue { Key = "1", Value = "True" });
                    }
                    break;
                case 3:
                    {
                        lst.Add(new KeyValue { Key = "0", Value = "Please Select" });
                        lst.Add(new KeyValue { Key = "B", Value = "Balance Sheet" });
                        lst.Add(new KeyValue { Key = "P", Value = "Profit & Loss" });
                        lst.Add(new KeyValue { Key = "T", Value = "Trading" });
                    }
                    break;
                case 4:
                    {
                        lst.Add(new KeyValue { Key = "0", Value = "Add" });
                        lst.Add(new KeyValue { Key = "1", Value = "Less" });
                    }
                    break;
                case 5: //Pankaj
                    {
                        lst.Add(new KeyValue { Key = "0", Value = "Select Month" });
                        lst.Add(new KeyValue { Key = "1", Value = "April" });
                        lst.Add(new KeyValue { Key = "2", Value = "May" });
                        lst.Add(new KeyValue { Key = "3", Value = "June" });
                        lst.Add(new KeyValue { Key = "4", Value = "July" });
                        lst.Add(new KeyValue { Key = "5", Value = "August" });
                        lst.Add(new KeyValue { Key = "6", Value = "September" });
                        lst.Add(new KeyValue { Key = "7", Value = "October" });
                        lst.Add(new KeyValue { Key = "8", Value = "November" });
                        lst.Add(new KeyValue { Key = "9", Value = "December" });
                        lst.Add(new KeyValue { Key = "10", Value = "January" });
                        lst.Add(new KeyValue { Key = "11", Value = "Febuary" });
                        lst.Add(new KeyValue { Key = "12", Value = "March" });
                    }
                    break;
                case 6:
                    {
                        lst.Add(new KeyValue { Key = "1", Value = "PCS" });
                        lst.Add(new KeyValue { Key = "2", Value = "KG" });
                    }
                    break;

                case 7:
                    {
                        lst.Add(new KeyValue { Key = "0", Value = "Cash" });
                        lst.Add(new KeyValue { Key = "1", Value = "Cheque" });
                        lst.Add(new KeyValue { Key = "2", Value = "CreditCard" });
                        lst.Add(new KeyValue { Key = "3", Value = "Company" });
                        lst.Add(new KeyValue { Key = "4", Value = "Coupan" });
                    }
                    break;
                case 8:
                    {
                        lst.Add(new KeyValue { Key = "0", Value = "Not Applicable" });
                        lst.Add(new KeyValue { Key = "1", Value = "Finished Goods" });
                        lst.Add(new KeyValue { Key = "2", Value = "Raw Material" });
                        lst.Add(new KeyValue { Key = "3", Value = "Primary Group" });
                    }

                    break;
                case 9:
                    {
                        lst.Add(new KeyValue { Key = "0", Value = "Dr" });
                        lst.Add(new KeyValue { Key = "1", Value = "Cr" });

                    }
                    break;
                case 10:
                    {
                        lst.Add(new KeyValue { Key = "0", Value = "Not Applicable " });
                        lst.Add(new KeyValue { Key = "1", Value = "Central 12%" });
                        lst.Add(new KeyValue { Key = "2", Value = "Central 2%" });
                        lst.Add(new KeyValue { Key = "3", Value = "Job Work Sale" });
                        lst.Add(new KeyValue { Key = "4", Value = "VAT 12.5%" });
                        lst.Add(new KeyValue { Key = "5", Value = "VAT 4%" });

                    }
                    break;
                case 11:
                    {
                        lst.Add(new KeyValue { Key = "0", Value = "Not Applicable" });
                        lst.Add(new KeyValue { Key = "1", Value = "Central Purchase" });
                        lst.Add(new KeyValue { Key = "2", Value = "Local Purchase" });

                    }
                    break;
                case 12:
                    {
                        lst.Add(new KeyValue { Key = "1", Value = "Other" });
                        lst.Add(new KeyValue { Key = "2", Value = "Cash" });
                        lst.Add(new KeyValue { Key = "3", Value = "Bank" });
                        lst.Add(new KeyValue { Key = "4", Value = "Supplier" });
                        lst.Add(new KeyValue { Key = "5", Value = "Customer" });
                        lst.Add(new KeyValue { Key = "6", Value = "Transporter" });

                    }
                    break;
                case 13:
                    {

                        lst.Add(new KeyValue { Key = "0", Value = "Ist Stage" });
                        lst.Add(new KeyValue { Key = "1", Value = "IInd Stage" });
                        lst.Add(new KeyValue { Key = "2", Value = "Manufacturar" });
                        lst.Add(new KeyValue { Key = "3", Value = "Importer" });


                    }
                    break;
                case 14:
                    {
                        // lst.Add(new KeyValue { Key = "0", Value = "Not Applicable" });
                        lst.Add(new KeyValue { Key = "0", Value = "Normal" });
                        lst.Add(new KeyValue { Key = "1", Value = "Export" });

                    }
                    break;

                case 15:
                    {

                        lst.Add(new KeyValue { Key = "0", Value = "None" });
                        lst.Add(new KeyValue { Key = "1", Value = "RG 23A Part1" });
                        lst.Add(new KeyValue { Key = "2", Value = "RG 23C Part1" });
                        lst.Add(new KeyValue { Key = "3", Value = "RG-1" });
                    }
                    break;

                case 16:
                    {
                        lst.Add(new KeyValue { Key = "0", Value = "Not Applicable" });
                        lst.Add(new KeyValue { Key = "1", Value = "Polymer/Platin-1" });
                        lst.Add(new KeyValue { Key = "2", Value = "Main Item" });
                        lst.Add(new KeyValue { Key = "3", Value = "Sub Item" });

                    }
                    break;

                case 17:
                    {
                        lst.Add(new KeyValue { Key = "0", Value = "Not Applicable" });
                        lst.Add(new KeyValue { Key = "1", Value = "Package" });
                        lst.Add(new KeyValue { Key = "2", Value = "Losses" });

                    }
                    break;
                case 18:
                    {
                        //lst.Add(new KeyValue { Key = "0", Value = "Please Select" });
                        lst.Add(new KeyValue { Key = "0", Value = "Not Applicable" });
                        lst.Add(new KeyValue { Key = "1", Value = "India" });
                        lst.Add(new KeyValue { Key = "2", Value = "Delhi" });

                    }
                    break;
                case 19:
                    {
                        lst.Add(new KeyValue { Key = "0", Value = "Not Applicable" });
                        lst.Add(new KeyValue { Key = "1", Value = "India" });
                        lst.Add(new KeyValue { Key = "2", Value = "Delhi" });

                    }
                    break;
                case 20:
                    {
                        lst.Add(new KeyValue { Key = "0", Value = "Not Applicable" });
                        lst.Add(new KeyValue { Key = "1", Value = "Sale Return" });
                        lst.Add(new KeyValue { Key = "2", Value = "Purchase" });

                    }
                    break;

                case 21:
                    {
                        lst.Add(new KeyValue { Key = "0", Value = "Please Select" });
                        lst.Add(new KeyValue { Key = "1", Value = "Finished Goods" });
                        lst.Add(new KeyValue { Key = "2", Value = "Raw Material" });
                        lst.Add(new KeyValue { Key = "3", Value = "Primary Group" });

                    }
                    break;

                case 22:
                    {
                        lst.Add(new KeyValue { Key = "0", Value = "Please Select" });
                        lst.Add(new KeyValue { Key = "1", Value = "Male" });
                        lst.Add(new KeyValue { Key = "2", Value = "Female" });
                    }
                    break;
                default:
                    break;
            }

            combo.ValueMember = "Key";
            combo.DisplayMember = "Value";
            combo.DataSource = lst;
            if (lst.Count > 0)
            {
                combo.SelectedIndex = 0;
            }
        }

        public void FillCombo(BCombo combo, DataTable table, string defaultValue1 = "")
        {
            try
            {
                DataTable dt = table.Copy();
                combo.Items.Clear();

                DataRow dr1 = dt.NewRow();
                dr1["Code"] = "0";
                dr1["Value"] = defaultValue1;

                dt.Rows.InsertAt(dr1, 0);
                combo.ValueMember = "Code";
                combo.DisplayMember = "Value";
                combo.DataSource = dt;
            }
            catch (Exception exception)
            {
                ErrorLog.LogErrorInTxtFormat(exception);
            }


        }

        #endregion

        #region Show Message

        /// <summary>
        /// Show Message
        /// </summary>
        /// <param name="messageConstatnts">MessageConstatnts</param>
        public void ShowMessage(string message, MessageType mt = MessageType.AlertMessage)
        {
            switch (mt)
            {
                case MessageType.BallonInfo:
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    break;
                case MessageType.AlertMessage:
                    MessageBox.Show(message, Common.Messages.Header);
                    return;
                case MessageType.BallonError:
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                    break;
                case MessageType.AlertError:
                    return;
                default:
                    break;
            }


            notifyIcon1.BalloonTipTitle = Common.Messages.Header;
            notifyIcon1.BalloonTipText = message;
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(30000);
        }

        #endregion


    }


}
