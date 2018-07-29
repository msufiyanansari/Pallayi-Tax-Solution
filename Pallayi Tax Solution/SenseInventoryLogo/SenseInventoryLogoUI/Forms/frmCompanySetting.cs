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
    public partial class frmCompanySetting : Form
    {
        int rollFKey;
        public frmCompanySetting(int rollKey)
        {
            InitializeComponent();
            rollFKey = rollKey;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LoadFormData()
        {
            try
            {
                clsCompanyBusiness objLoad = new clsCompanyBusiness();
                objLoad.Mode = "SELECTONE";
                var lstUser = objLoad.GetCompanyBusiness().FirstOrDefault();
                if (lstUser != null)
                {
                    txtName.Text                = lstUser.CompanyName;
                    txttitle.Text               = lstUser.CompanyBusinessTitle;
                    txtDescription.Text         = lstUser.CompanyBusinessDescription;
                    txtAddress.Text             = lstUser.CompanyBusinessAddress;
                    txtContact1.Text            = lstUser.CompanyBusinessContact1;
                    txtContact2.Text            = lstUser.CompanyBusinessContact2;
                    txtGstTinNo.Text            = lstUser.CompanyBusinessGstTinNo;
                    txtBankName.Text            = lstUser.CompanyBusinessBankName;
                    txtActNo.Text               = lstUser.CompanyBusinessBankAcctNo;
                    txtIFSCCode.Text            = lstUser.CompanyBusinessBankIFSCCode;
                    txtBranch.Text              = lstUser.CompanyBusinessBankBranch;
                    lblAccountHeader.Text       = "Welcome To";
                    lblAccountHeader.Text       = lblAccountHeader.Text + " " + txtName.Text;
                    txtKey.Text                 = lstUser.CompanyBusinessKey.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "LoadFormData", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SaveFormData()
        {
            try
            {
                clsCompanyBusiness objSave = new clsCompanyBusiness();
                objSave.CompanyName                   =         txtName.Text;
                objSave.CompanyBusinessTitle          =         txttitle.Text;
                objSave.CompanyBusinessDescription    =         txtDescription.Text;
                objSave.CompanyBusinessAddress        =         txtAddress.Text;
                objSave.CompanyBusinessContact1       =         txtContact1.Text;
                objSave.CompanyBusinessContact2       =         txtContact2.Text;
                objSave.CompanyBusinessGstTinNo       =         txtGstTinNo.Text;
                objSave.CompanyBusinessBankName       =         txtBankName.Text;
                objSave.CompanyBusinessBankAcctNo     =         txtActNo.Text;
                objSave.CompanyBusinessBankIFSCCode   =         txtIFSCCode.Text;
                objSave.CompanyBusinessBankBranch     =         txtBranch.Text;
                objSave.CompanyBusinessKey            =         Convert.ToInt32(txtKey.Text);
                objSave.Mode                          =         "UPDATE";
                objSave.AddUpdateDelete();
                MessageBox.Show(txtName.Text + " " + "Update SuccessFully", "Company Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
                LoadFormData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "SaveFormData", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void frmAccountSetting_Load(object sender, EventArgs e)
        {
            try
            {
                LoadFormData();
                txtName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "frmAccountSetting_Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFormData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "btnUpdate_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblAccountHeader_Click(object sender, EventArgs e)
        {

        }
    }
}
