using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SenseInventoryLogoBL;

namespace SenseInventoryLogoUI.Forms
{
    public partial class frmCategoryMaster : Form
    {
        int    rollFKey;
        String pageAction;
        int    cId;
        public frmCategoryMaster(int rollKey, int companyId, String formAction = "NO")
        {
            InitializeComponent();
            rollFKey        = rollKey;
            pageAction      = formAction;
            cId             = companyId;
        }

        #region FUNCTION
        public void BindCategoryCombo()
        {
            try
            {
                clsCategoryMaster objLoad = new clsCategoryMaster();
                objLoad.Mode                = "COMBOFILL";
                objLoad.CompanyID           = cId;
                var ds                      = objLoad.GetAllCategory();
                DataTable dt                = ds.Tables[0];
                DataRow dr                  = dt.NewRow();
                dr["CategoryMasterCatKey"]  = "0";
                dr["CategoryMasterCatName"] = "Please Select Category";
                dt.Rows.InsertAt(dr, 0);
                cmbCategory.DataSource      = dt;
                cmbCategory.DisplayMember   = "CategoryMasterCatName";
                cmbCategory.ValueMember     = "CategoryMasterCatKey";
                cmbCategory.Text            = "Please Select Category";
                cmbCategory.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "BindCategoryCombo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void BindDataGrid()
        {
            try
            {
                clsCategoryMaster objLoad                   = new clsCategoryMaster();
                objLoad.Mode                                = "SELECTALL";
                objLoad.CompanyID                           = cId;
                objLoad.CategoryMasterCatName               = cmbCategory.Text;
                dgvCategoryDetail.AutoGenerateColumns       = false;
                var ds                                      = objLoad.GetAllCategory();
                dgvCategoryDetail.DataSource                = ds.Tables[0];
                
                lblRecordCount.Text = ds.Tables[0].Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "BindDataGrid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SaveFormData(String mode)
        {
            try
            {
                clsCategoryMaster objSave = new clsCategoryMaster();
                objSave.CategoryMasterCatKey = Convert.ToInt32(txtKey.Text);
                objSave.CategoryMasterCatName = cmbCategory.Text;
                objSave.CategoryMasterCatVal = txtCategoryValue.Text;
                objSave.CategoryMasterCatIsActive = chkActiveInActive.Checked == true ? 1 : 0;
                objSave.CategoryMasterHsnCode     = txtHsnCode.Text;
                objSave.Mode = mode.ToUpper();
                objSave.CompanyID   = cId;
                if (mode.ToUpper().Equals("DELETE"))
                {
                    var confirmation = MessageBox.Show("Are You Sure You Want to Delete " + " " + txtCategoryValue.Text, "Category Master Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (confirmation.ToString().Equals("Yes"))
                    {
                        objSave.AddUpdateDelete();
                        BindDataGrid();
                        ResetFormControl();
                    }
                }
                else
                {
                    if (objSave.Validation().Length > 0)
                    {
                        MessageBox.Show(objSave.Validation(), "Category Master Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        objSave.AddUpdateDelete();
                        MessageBox.Show(cmbCategory.Text + " " + txtCategoryValue.Text + " " + mode + " Success Fully", "Category Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public void ResetFormControl()
        {
            cmbCategory.Focus();
            txtCategoryValue.Text = String.Empty;
            txtCategoryValue.Focus();
            btnAddCategory.Text = "Add";
            btnDeleteCategory.Visible = false;
            txtHsnCode.Text = String.Empty;
            cmbCategory.Enabled = true;
        } 
        #endregion

        #region EVENTS
        private void frmCategoryMaster_Load(object sender, EventArgs e)
        {
            try
            {
                BindCategoryCombo();
                cmbCategory.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "frmCategoryMaster_Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFormData(btnAddCategory.Text.ToUpper());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "btnAddCategory_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory.Text != "Please Select Category")
                {
                    BindDataGrid();
                }
                else
                {
                    dgvCategoryDetail.DataSource = null;
                    lblRecordCount.Text          = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "cmbCategory_SelectedIndexChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFormData(btnDeleteCategory.Text.ToUpper());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "btnDeleteCategory_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region GRIDVIEWEVENT
        private void dgvCategoryDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex.Equals(0))
                {
                    cmbCategory.Text                             = dgvCategoryDetail.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtCategoryValue.Text                        = dgvCategoryDetail.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtKey.Text                                  = dgvCategoryDetail.Rows[e.RowIndex].Cells[4].Value.ToString();
                    chkActiveInActive.Checked                    = Convert.ToBoolean(dgvCategoryDetail.Rows[e.RowIndex].Cells[5].Value);
                    txtHsnCode.Text                              = dgvCategoryDetail.Rows[e.RowIndex].Cells[6].Value.ToString();
                    cmbCategory.Enabled                          = false;
                    btnAddCategory.Text                          = "Update";
                    btnDeleteCategory.Visible                    = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "dgvCategoryDetail_CellContentClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        
        #endregion

        
    }
}
 