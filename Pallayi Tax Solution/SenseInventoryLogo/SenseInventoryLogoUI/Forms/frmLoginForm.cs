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
namespace SenseInventoryLogoUI.Forms
{
    public partial class frmLoginForm : Form
    {
        public frmLoginForm()
        {
            InitializeComponent();
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmLoginForm_Load(object sender, EventArgs e)
        {
            BindCompanyCombo();
            txtUserName.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                String msg = String.Empty;
                clsUserMaster objAuth               = new clsUserMaster();
                objAuth.UserName                    = txtUserName.Text;
                objAuth.UserPassword                = txtPassword.Text;
                objAuth.CompanyID                   = Convert.ToInt32(cmbCompany.SelectedValue);
                objAuth.Mode                        = "AUTHONTICATE";
                msg                                 = objAuth.AuthenticateValidate();
                if (msg.Length > 0)
                {
                    MessageBox.Show(msg, "Authonticate Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var lstUser = objAuth.GetUserData().FirstOrDefault();
                    if (lstUser != null)
                    {
                        frmMainMaster objMainMaster = new frmMainMaster(lstUser.UserRollFKey, Convert.ToInt32(cmbCompany.SelectedValue));
                        this.Hide();
                        objMainMaster.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Invalid User Name and Password", "Authonticate Aler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "btnLogin_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void BindCompanyCombo()
        {
            try
            {
                clsCompanyBusiness objLoad = new clsCompanyBusiness();
                objLoad.Mode                    = "SELECTALL";
                var ds                          = objLoad.GetAllCompany();
                DataTable dt                    = ds.Tables[0];
                DataRow dr                      = dt.NewRow();
                dr["CompanyBusinessKey"]        = "0";
                dr["CompanyName"]               = "Please Select Company";
                dt.Rows.InsertAt(dr, 0);
                //DataRow dr                = dt.NewRow();
                /*          Bind the Item Group     */
                cmbCompany.DataSource           = dt;
                cmbCompany.DisplayMember        = "CompanyName";
                cmbCompany.ValueMember          = "CompanyBusinessKey";
                cmbCompany.Text                 = "Please Select Company";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "BindCompanyCombo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
