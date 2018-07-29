using SenseInventoryLogoBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SenseInventoryLogoUI.Forms
{
    public partial class frmCompanyDetail : Form
    {
        int cId;
        public frmCompanyDetail(int companyId)
        {
            InitializeComponent();
            cId = companyId;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SaveFormData(btnAdd.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SaveFormData(btnDelete.Text);
        }
        public void SaveFormData(string mode)
        {
            try
            {
                clsCompanyBusiness objSave = new clsCompanyBusiness();
                objSave.CompanyName = txtName.Text;
                objSave.CompanyBusinessTitle = txttitle.Text;
                objSave.CompanyBusinessDescription = txtDescription.Text;
                objSave.CompanyBusinessAddress = txtAddress.Text;
                objSave.CompanyBusinessContact1 = txtContact1.Text;
                objSave.CompanyBusinessContact2 = txtContact2.Text;
                objSave.CompanyBusinessGstTinNo = txtGstTinNo.Text;
                objSave.CompanyBusinessBankName = txtBankName.Text;
                objSave.CompanyBusinessBankAcctNo = txtActNo.Text;
                objSave.CompanyBusinessBankIFSCCode = txtIFSCCode.Text;
                objSave.CompanyBusinessBankBranch = txtBranch.Text;
                objSave.CompanyID = Convert.ToInt32(txtKey.Text);
                objSave.CompanyStateName    = txtState.Text;
                objSave.CompanyStateCode    = txtStateCode.Text;
                objSave.Mode = mode;
                if (mode.ToUpper().Equals("DELETE"))
                {
                    var confirmation = MessageBox.Show("Are You Sure You Want to Delete " + " " + txtName.Text, "Company Master Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
                    if (msg.Length > 0)
                    {
                        MessageBox.Show(msg, "Company Master Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        objSave.AddUpdateDelete();
                        MessageBox.Show(txtName.Text + " " + mode + " Success Fully", "Company Master Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindDataGrid();
                        ResetFormControl();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "SaveFormData", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ResetFormControl()
        {
            txtKey.Text = "0";
            txtName.Text = String.Empty;
            txttitle.Text = String.Empty;
            txtDescription.Text = String.Empty;
            txtAddress.Text = String.Empty;
            txtContact1.Text = String.Empty;
            txtContact2.Text = String.Empty;
            txtGstTinNo.Text = String.Empty;
            txtBankName.Text = String.Empty;
            txtActNo.Text = String.Empty;
            txtIFSCCode.Text = String.Empty;
            txtBranch.Text = String.Empty;
            txtState.Text   = String.Empty;
            txtStateCode.Text   = String.Empty;
            btnAdd.Text = "Add";
            btnDelete.Visible = false;
            txtName.Focus();
        }

        #region GRIDBINDFUNCTION
        public void BindDataGrid()
        {
            try
            {
                clsCompanyBusiness objLoad = new clsCompanyBusiness();
                objLoad.Mode = "SELECTALL";
                dgvCustomerMaster.AutoGenerateColumns = false;
                var ds = objLoad.GetAllCompany();
                dgvCustomerMaster.DataSource = ds.Tables[0];
                lblRecordCount.Text = ds.Tables[0].Rows.Count.ToString();
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
                clsCompanyBusiness objLoad = new clsCompanyBusiness();
                objLoad.Mode = "SELECTALL";
                objLoad.CompanyName = txtSearchCompany.Text;
                objLoad.CompanyBusinessAddress = txtSearchAddress.Text;
                dgvCustomerMaster.AutoGenerateColumns = false;
                var ds = objLoad.SearchCompanyDetail();
                dgvCustomerMaster.DataSource = ds.Tables[0];
                lblRecordCount.Text = ds.Tables[0].Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "SearchBindDataGrid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void frmCompanyDetail_Load(object sender, EventArgs e)
        {
            try
            {
                BindDataGrid();
                txtName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "frmCompanyDetail_Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private void dgvCustomerMaster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex.Equals(0))
                {
                    txtName.Text = dgvCustomerMaster.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txttitle.Text = dgvCustomerMaster.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtDescription.Text = dgvCustomerMaster.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtAddress.Text = dgvCustomerMaster.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtContact1.Text = dgvCustomerMaster.Rows[e.RowIndex].Cells[5].Value.ToString();
                    txtContact2.Text = dgvCustomerMaster.Rows[e.RowIndex].Cells[6].Value.ToString();
                    txtGstTinNo.Text = dgvCustomerMaster.Rows[e.RowIndex].Cells[7].Value.ToString();
                    txtBankName.Text = dgvCustomerMaster.Rows[e.RowIndex].Cells[8].Value.ToString();
                    txtActNo.Text = dgvCustomerMaster.Rows[e.RowIndex].Cells[9].Value.ToString();
                    txtIFSCCode.Text = dgvCustomerMaster.Rows[e.RowIndex].Cells[10].Value.ToString();
                    txtBranch.Text = dgvCustomerMaster.Rows[e.RowIndex].Cells[11].Value.ToString();
                    txtKey.Text = dgvCustomerMaster.Rows[e.RowIndex].Cells[12].Value.ToString();
                    txtState.Text = dgvCustomerMaster.Rows[e.RowIndex].Cells[13].Value.ToString();
                    txtStateCode.Text = dgvCustomerMaster.Rows[e.RowIndex].Cells[14].Value.ToString();

                    btnAdd.Text = "Update";
                    btnDelete.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "dgvCustomerMaster_CellContentClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
