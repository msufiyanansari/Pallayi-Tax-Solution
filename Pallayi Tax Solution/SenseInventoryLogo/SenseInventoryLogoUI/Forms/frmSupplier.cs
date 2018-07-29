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
    public partial class frmSupplier : Form
    {
        int rollFKey;
        String pageAction;
        int cId;
        public frmSupplier(int rollKey,int companyId, String formAction = "NO")
        {
            InitializeComponent();
            rollFKey           = rollKey;
            pageAction         = formAction;
            cId                = companyId;
        }

        #region FORMLOADEVENT
        private void frmSupplier_Load(object sender, EventArgs e)
        {
            try
            {
                txtSupplierName.Focus();
                BindDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "frmSupplier_Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        #endregion

        #region ADDUPDATEDELETEFUNCTION
        public void SaveFormData(String mode)
        {
            try
            {
                clsSupplierMaster objSave           = new clsSupplierMaster();
                objSave.SupplierID                  = Convert.ToInt32(txtKey.Text);
                objSave.SupplierName                = txtSupplierName.Text;
                objSave.SupplierAddress             = txtSupplierAddress.Text;
                objSave.SupplierContactPerson       = txtContactPerson.Text;
                objSave.SupplierContactNo           = txtContactNo.Text;
                objSave.CompanyID                   = cId;
                String cstDate                      = dtpCstTinDate.Value.ToString("dd/MM/yyyy");
                if (DateTime.Now.ToString("dd/MM/yyyy") != cstDate)
                {
                    objSave.SupplierCSTDate = clsCommoan.GetDateInddMMYYYY(cstDate);
                }
                String gstDate                      = dtpGstTinDate.Value.ToString("dd/MM/yyyy");
                if (DateTime.Now.ToString("dd/MM/yyyy") != gstDate)
                {
                    objSave.SupplierGSTDate = clsCommoan.GetDateInddMMYYYY(gstDate);
                }
                objSave.Mode = mode.ToUpper();
                if (mode.ToUpper().Equals("DELETE"))
                {
                    var confirmation = MessageBox.Show("Are You Sure You Want to Delete " + " " + txtSupplierName.Text, "Supplier Master Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
                        MessageBox.Show(msg, "Supplier Master Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        objSave.SupplierCSTNo = txtcstTinNo.Text;
                        if (txtGstTinNo.Text.Length > 0)
                        {
                            objSave.SupplierGSTNo = txtGstTinNo.Text;
                        }
                        objSave.AddUpdateDelete();
                        MessageBox.Show(txtSupplierName.Text + " " + mode + " Success Fully", "Supplier Master Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtSupplierName.Text        = String.Empty;
            txtSupplierAddress.Text     = String.Empty;
            txtContactPerson.Text       = String.Empty;
            txtContactNo.Text           = String.Empty;
            txtcstTinNo.Text            = String.Empty;
            txtGstTinNo.Text            = String.Empty;
            dtpCstTinDate.Value         = DateTime.Now;
            dtpGstTinDate.Value         = DateTime.Now;
            btnAdd.Text                 = "Add";
            btnDelete.Visible           = false;
            txtSupplierName.Focus();
        } 
        #endregion

        #region GRIDBINDFUNCTION
        public void BindDataGrid()
        {
            try
            {
                clsSupplierMaster objLoad             = new clsSupplierMaster();
                objLoad.Mode                          = "SELECTALL";
                objLoad.CompanyID                     = cId;
                dgvSupplierMaster.AutoGenerateColumns = false;
                var ds                                = objLoad.GetAllSupplier();
                dgvSupplierMaster.DataSource          = ds.Tables[0];
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
                dgvSupplierMaster.DataSource = null;
                clsSupplierMaster objLoad             = new clsSupplierMaster();
                objLoad.CompanyID                     = cId;
                objLoad.Mode                          = "SELECTALL";
                objLoad.SupplierName                  = txtSearchSupplier.Text;
                objLoad.SupplierContactNo             = txtSearchContactPerson.Text;
                objLoad.SupplierAddress               = txtSearchAddress.Text;
                dgvSupplierMaster.AutoGenerateColumns = false;
                var ds                                = objLoad.GetSearchSupplier();
                dgvSupplierMaster.DataSource          = ds.Tables[0];
                lblRecordCount.Text                   = ds.Tables[0].Rows.Count.ToString();
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
        private void dgvSupplierMaster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex.Equals(0))
                {
                    txtSupplierName.Text            = dgvSupplierMaster.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtSupplierAddress.Text         = dgvSupplierMaster.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtContactPerson.Text           = dgvSupplierMaster.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtContactNo.Text               = dgvSupplierMaster.Rows[e.RowIndex].Cells[4].Value.ToString();
                    
                    txtGstTinNo.Text                = dgvSupplierMaster.Rows[e.RowIndex].Cells[5].Value.ToString();
                    
                    if (dgvSupplierMaster.Rows[e.RowIndex].Cells[6].Value.ToString().Length>0)
                    {
                        dtpGstTinDate.Value = Convert.ToDateTime(dgvSupplierMaster.Rows[e.RowIndex].Cells[10].Value);
                    }
                    txtcstTinNo.Text = dgvSupplierMaster.Rows[e.RowIndex].Cells[7].Value.ToString();
                    if (dgvSupplierMaster.Rows[e.RowIndex].Cells[8].Value.ToString().Length>0)
                    {
                        dtpCstTinDate.Value         = Convert.ToDateTime(dgvSupplierMaster.Rows[e.RowIndex].Cells[11].Value);
                    }
                    txtKey.Text                     = dgvSupplierMaster.Rows[e.RowIndex].Cells[9].Value.ToString();
                    btnAdd.Text                     = "Update";
                    btnDelete.Visible               = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "dgvSupplierMaster_CellContentClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        #endregion
    }
}

      





































