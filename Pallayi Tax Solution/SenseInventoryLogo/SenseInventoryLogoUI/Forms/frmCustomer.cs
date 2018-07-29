using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SenseInventoryLogoBL;
using System.Data.SqlClient;
using SenseInventoryLogoUI.Forms.Class;
using System.Globalization;
namespace SenseInventoryLogoUI.Forms
{
    public partial class frmCustomer : Form
    {
        int rollFKey; String pageAction;
        int cId;
        public frmCustomer(int rollKey, int companyId, String formAction = "NO")
        {
            InitializeComponent();
            rollFKey        = rollKey;
            pageAction      = formAction;
            cId             = companyId;
        }

        #region FORMLOADEVENT
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                BindDataGrid();
                txtCustomerName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "frmCustomer_Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        #endregion

        #region ADDUPDATEDELETEFUNCTION
        public void SaveFormData(String mode)
        {
            try
            {
                clsCustomerMaster objSave           = new clsCustomerMaster();
                objSave.CustomerID                  = Convert.ToInt32(txtKey.Text);
                objSave.CustomerName                = txtCustomerName.Text;
                objSave.CustomerAddress             = txtCustomerAddress.Text;
                objSave.CustomerContactPerson       = txtContactPerson.Text;
                objSave.CustomerContactNo           = txtContactNo.Text;
                objSave.CompanyID                   = cId;
                objSave.CustomerPanNo               = txtCustomerPanNo.Text;
                String cstDate                      = dtpCstTinDate.Value.ToString("dd/MM/yyyy");
                if (DateTime.Now.ToString("dd/MM/yyyy") != cstDate)
                {
                    objSave.CustomerCSTDate = clsCommoan.GetDateInddMMYYYY(dtpCstTinDate.Value.ToString());
                }
                String gstDate                      = dtpGstTinDate.Value.ToString("dd/MM/yyyy");
                if (DateTime.Now.ToString("dd/MM/yyyy") != gstDate)
                {
                    objSave.CustomerGSTDate = clsCommoan.GetDateInddMMYYYY(dtpGstTinDate.Value.ToString());
                }
                objSave.Mode = mode.ToUpper();
                if (mode.ToUpper().Equals("DELETE"))
                {
                    var confirmation = MessageBox.Show("Are You Sure You Want to Delete " + " " + txtCustomerName.Text, "Customer Master Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (confirmation.ToString().Equals("Yes"))
                    {
                        objSave.AddUpdateDelete();
                        BindDataGrid();
                        ResetFormControl();
                    }
                }
                else
                {
                    String msg = objSave.Validation();



                    //if (txtcstTinNo.Text.Length != 11 && txtcstTinNo.Text.Length>0)
                    //{
                    //    if (msg.Length.Equals(0))
                    //    {
                    //        msg = "Please Enter the 11 Digit  Cst Tin No: ";
                    //    }
                    //    else
                    //    {
                    //        msg = msg + "\n Please Enter the 11 Digit Valid Cst Tin No: ";
                    //    }
                    //}
                    //if (txtGstTinNo.Text.Length < 11 && txtGstTinNo.Text.Length > 0)
                    //{
                    //    if (txtGstTinNo.Text.Length!=11)
                    //    {
                    //        if (msg.Length.Equals(0))
                    //        {
                    //            msg = "Please Enter the 11 Digit Valid Gst Tin No: ";
                    //        }
                    //        else
                    //        {
                    //            msg = msg +  "\n Please Enter the 11 Digit Valid Gst Tin No: ";
                    //        }
                    //    }
                    //}
                    if (msg.Length > 0)
                    {
                        MessageBox.Show(msg, "Customer Master Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        objSave.CustomerCSTNo = txtcstTinNo.Text;
                        if (txtGstTinNo.Text.Length > 0)
                        {
                            objSave.CustomerGSTNo = txtGstTinNo.Text;
                        }
                        objSave.AddUpdateDelete();
                        MessageBox.Show(txtCustomerName.Text + " " + mode + " Success Fully", "Customer Master Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindDataGrid();
                        ResetFormControl();
                        if (pageAction.Equals("Yes"))
                        {
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "SaveFormData", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public Boolean CheckDateValidation(String date)
        {
            if (date.Length > 0)
            {
                DateTime d;
                return DateTime.TryParseExact(date, "dd/MM/yyyy",CultureInfo.InvariantCulture,DateTimeStyles.None,out d);
            }
            else
            {
                return false;
            }
        }
        public void ResetFormControl()
        {
            txtKey.Text                 = "0";
            txtCustomerName.Text        = String.Empty;
            txtCustomerAddress.Text     = String.Empty;
            txtContactPerson.Text       = String.Empty;
            txtContactNo.Text           = String.Empty;
            txtcstTinNo.Text            = String.Empty;
            txtGstTinNo.Text            = String.Empty;
            dtpCstTinDate.Value         = DateTime.Now;
            dtpGstTinDate.Value         = DateTime.Now;
            txtCustomerPanNo.Text       = String.Empty;
            btnAdd.Text                 = "Add";
            btnDelete.Visible           = false;
            txtCustomerName.Focus();
        } 
        #endregion

        #region GRIDBINDFUNCTION
        public void BindDataGrid()
        {
            try
            {
                clsCustomerMaster objLoad             = new clsCustomerMaster();
                objLoad.Mode                          = "SELECTALL";
                objLoad.CompanyID                     = cId;
                dgvCustomerMaster.AutoGenerateColumns = false;
                var ds                                = objLoad.GetAllCustomer();
                dgvCustomerMaster.DataSource          = ds.Tables[0];
                lblRecordCount.Text                   = ds.Tables[0].Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "BindDataGrid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SearchBindDataGrid()
        {
            try
            {
                dgvCustomerMaster.DataSource = null;
                clsCustomerMaster objLoad = new clsCustomerMaster();
                objLoad.Mode = "SELECTALL";
                objLoad.CompanyID = cId;
                objLoad.CustomerName = txtSearchCustomer.Text;
                objLoad.CustomerContactNo = txtSearchContactPerson.Text;
                objLoad.CustomerAddress = txtSearchAddress.Text;
                dgvCustomerMaster.AutoGenerateColumns = false;
                var ds = objLoad.GetSearchCustomer();
                dgvCustomerMaster.DataSource = ds.Tables[0];
                lblRecordCount.Text = ds.Tables[0].Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "SearchBindDataGrid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        #endregion

        #region BUTTONEVENT
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFormData(btnAdd.Text.ToUpper());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "btnAdd_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFormData(btnDelete.Text.ToUpper());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "btnDelete_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SearchBindDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "btnSearch_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        #endregion

        #region GRIDVIEWEVENT
        private void dgvCustomerMaster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex.Equals(0))
                {
                    txtCustomerName.Text            = dgvCustomerMaster.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtCustomerAddress.Text         = dgvCustomerMaster.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtContactPerson.Text           = dgvCustomerMaster.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtContactNo.Text               = dgvCustomerMaster.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtCustomerPanNo.Text           = dgvCustomerMaster.Rows[e.RowIndex].Cells[12].Value.ToString();
                    txtGstTinNo.Text                = dgvCustomerMaster.Rows[e.RowIndex].Cells[5].Value.ToString();
                    if (dgvCustomerMaster.Rows[e.RowIndex].Cells[6].Value.ToString().Length>0)
                    {
                        dtpGstTinDate.Value = Convert.ToDateTime(dgvCustomerMaster.Rows[e.RowIndex].Cells[10].Value.ToString());
                    }
                    txtcstTinNo.Text = dgvCustomerMaster.Rows[e.RowIndex].Cells[7].Value.ToString();
                    if (dgvCustomerMaster.Rows[e.RowIndex].Cells[8].Value.ToString().Length>0)
                    {
                        dtpCstTinDate.Value         = Convert.ToDateTime(dgvCustomerMaster.Rows[e.RowIndex].Cells[11].Value.ToString());
                    }
                    txtKey.Text                     = dgvCustomerMaster.Rows[e.RowIndex].Cells[9].Value.ToString();
                    btnAdd.Text                     = "Update";
                    btnDelete.Visible               = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "dgvCustomerMaster_CellContentClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        #endregion

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchContactPerson_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

      





































