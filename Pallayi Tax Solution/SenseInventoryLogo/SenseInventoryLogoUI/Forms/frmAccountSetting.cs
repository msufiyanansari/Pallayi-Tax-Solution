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
    public partial class frmAccountSetting : Form
    {
        int rollFKey;
        int cId;
        public frmAccountSetting(int rollKey, int companyId)
        {
            InitializeComponent();
            rollFKey = rollKey;
            cId      = companyId;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LoadFormData()
        {
            try
            {
                clsUserMaster objLoad = new clsUserMaster();
                objLoad.Mode = "SELECTONE";
                objLoad.CompanyID = cId;
                var lstUser = objLoad.GetUserData().FirstOrDefault();
                if (lstUser != null)
                {
                    txtFirstName.Text           = lstUser.UserFirstName;
                    txtLastName.Text            = lstUser.UserLastName;
                    txtAddress.Text             = lstUser.UserAddress;
                    txtEmail.Text               = lstUser.UserEmail;
                    txtUserName.Text            = lstUser.UserName;
                    txtUserPassword.Text        = lstUser.UserPassword;
                    chkActive.Checked           = lstUser.UserIsActive == 1 ? true : false;
                    lblAccountHeader.Text       = "Welcome To";
                    lblAccountHeader.Text       = lblAccountHeader.Text + " " + txtFirstName.Text + " " + txtLastName.Text;
                    txtKey.Text                 = lstUser.UserID.ToString();
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
                clsUserMaster objSave = new clsUserMaster();
                objSave.UserFirstName     =         txtFirstName.Text  ;  
                objSave.UserLastName      =         txtLastName.Text   ;  
                objSave.UserAddress       =         txtAddress.Text     ;  
                objSave.UserEmail         =         txtEmail.Text      ;  
                objSave.UserName          =         txtUserName.Text    ;  
                objSave.UserPassword      =         txtUserPassword.Text;  
                objSave.UserIsActive      =         chkActive.Checked   ==  true    ?   1   :   0;  
                objSave.UserID            =         Convert.ToInt32(txtKey.Text);
                objSave.Mode              =         "UPDATE";
                objSave.CompanyID         =         cId;
                objSave.AddUpdateDelete();
                MessageBox.Show(txtUserName.Text + " " + "Update SuccessFully", "User Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
                LoadFormData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "SaveFormData", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked == true)
            {
                lblShowPassword.Visible = true;
                lblShowPassword.Text    = txtUserPassword.Text;
            }
            else
            {
                lblShowPassword.Visible = false;
            }
        }

        private void frmAccountSetting_Load(object sender, EventArgs e)
        {
            try
            {
                LoadFormData();
                txtFirstName.Focus();
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
    }
}
