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
using System.Globalization;
using System.IO;

namespace SenseInventoryLogoUI.Forms
{
    public partial class frmPurchaseItemMaster : Form
    {
        String pageAction;
        //String img_file = "D:\\StarEngineeringUI\\Resources\\blankImage.jpg";
        int rollFKey;
        int cId;
        public frmPurchaseItemMaster(String formAction, int rollKey, int companyId)
        {
            InitializeComponent();
            pageAction  = formAction;
            rollFKey    = rollKey;
            cId         = companyId;
        }

        #region ADDUPDATEDELETEFUNCTION
        public void SaveFormData(String mode)
        {
            try
            {
                clsPurchaseItemMaster objSave = new clsPurchaseItemMaster();
                objSave.PurchaseItemMasterKey           = Convert.ToInt32(txtKey.Text);
                objSave.PurchaseItemMasterName          = txtPurchaseItemName.Text;
                objSave.PurchaseItemMasterGroupFKey     = Convert.ToInt32(cmbPurchaseItemGroup.SelectedValue);
                objSave.PurchaseItemMasterGroupFKeyName = cmbPurchaseItemGroup.Text;
                objSave.PurchaseItemMasterType          = cmbType.Text;
                objSave.PurchaseItemMasterHsnCode       = txtHsnCode.Text;
                objSave.CompanyID                       = cId;
                //var a   =                       Convert.ToDecimal(txtPurchaseItemRate.Text)
                objSave.PurchaseItemMasterDescription   = txtPurchaseItemDescription.Text;
                objSave.Mode                            = mode.ToUpper();
                if (mode.ToUpper().Equals("DELETE"))
                {
                    var confirmation = MessageBox.Show("Are You Sure You Want to Delete " + " " + txtPurchaseItemName.Text, "PurchaseItem Master Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
                    
                    int isAvaibleinListPurchaseItem = cmbPurchaseItemGroup.FindStringExact(cmbPurchaseItemGroup.Text);
                    if (isAvaibleinListPurchaseItem.Equals(-1))
                    {
                        if (msg.Length.Equals(0))
                        {
                            msg = "Please Select the PurchaseItem Group From List";
                        }
                        else
                        {
                            msg = msg + "\n Please Select the PurchaseItem Group From List";
                        }
                    }
                    Decimal validRate = 0;
                    Decimal.TryParse(txtPurchaseItemRate.Text, out validRate);
                    if (validRate.Equals(0) && txtPurchaseItemRate.Text.Length>0)
                    {
                        if (msg.Length.Equals(0))
                        {
                            msg = "Please Enter the Valid Rate";
                        }
                        else
                        {
                            msg = msg + "\n Please Enter the Valid Rate";
                        }
                    }
                    if (txtPurchaseItemRate.Text.Length.Equals(0))
                    {
                        if (msg.Length.Equals(0))
                        {
                            msg = "Please Enter the Rate";
                        }
                        else
                        {
                            msg = msg + "\n Please Enter the Rate";
                        }
                    }
                    //Decimal validStock  =   0;
                    //Decimal.TryParse(txtPurchaseItemStock.Text, out validStock);
                    //if (validStock.Equals(0) && txtPurchaseItemStock.Text.Length > 0)
                    //{
                    //    if (msg.Length.Equals(0))
                    //    {
                    //        msg = "Please Enter the Valid Stock";
                    //    }
                    //    else
                    //    {
                    //        msg = msg + "\n Please Enter the Valid Stock";
                    //    }
                    //}
                    //Decimal validjobrate = 0;
                    //Decimal.TryParse(txtJobRate.Text, out validjobrate);
                    //if (validjobrate.Equals(0) && txtJobRate.Text.Length > 0)
                    //{
                    //    if (msg.Length.Equals(0))
                    //    {
                    //        msg = "Please Enter the  Job Rate";
                    //    }
                    //    else
                    //    {
                    //        msg = msg + "\n Please Enter the Valid Job Rate";
                    //    }
                    //}
                    if (msg.Length > 0)
                    {
                        MessageBox.Show(msg, "PurchaseItem Master Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        objSave.PurchaseItemMasterRate      =   Convert.ToDecimal(txtPurchaseItemRate.Text);
                        objSave.PurchaseItemMasterStock     =   txtPurchaseItemStock.Text.Length > 0 ? Convert.ToDecimal(txtPurchaseItemStock.Text) : 0;
                        objSave.PurchaseItemMasterJobRate   =   txtJobRate.Text.Length > 0 ? Convert.ToDecimal(txtJobRate.Text) : 0;
                        //String picName              =   img_file.Substring(img_file.LastIndexOf('\\'));
                        //string path                 =   Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("bin"));
                        //Bitmap imgImage             =   new Bitmap(pctBoxPurchaseItemImage.Image);
                        //imgImage.Save(path + "Resources" + picName);
                        //objSave.PurchaseItemMasterImage     =   path + "Resources" + picName;   
                        objSave.AddUpdateDelete();
                        MessageBox.Show(txtPurchaseItemName.Text + " " + mode + " Success Fully", "PurchaseItem Master Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindDataGrid();
                        ResetFormControl();
                        if(pageAction.Equals("Yes"))
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

            txtKey.Text             = "0";
            txtPurchaseItemName.Text        = String.Empty;
            txtPurchaseItemRate.Text        = String.Empty;
            txtPurchaseItemDescription.Text = String.Empty;
            txtPurchaseItemStock.Text       = String.Empty;
            txtJobRate.Text                 = String.Empty;
            txtHsnCode.Text                 = String.Empty;
            cmbType.Text                    = "Select Type";
            //pctBoxPurchaseItemImage.Image = Image.FromFile("D:\\StarEngineeringUI\\Resources\\blankImage.jpg");
            cmbPurchaseItemGroup.Focus();
            btnAdd.Text             = "Add";
            btnDelete.Visible       = false;
        }
        #endregion

        #region GRIDBINDFUNCTION
        public void BindDataGrid()
        {
            try
            {
                clsPurchaseItemMaster objLoad = new clsPurchaseItemMaster();
                objLoad.Mode = "SELECTALL";
                objLoad.CompanyID = cId;
                dgvPurchaseItemMaster.AutoGenerateColumns = false;
                var ds = objLoad.GetAllPurchaseItems(); ;
                dgvPurchaseItemMaster.DataSource = ds.Tables[0];
                lblRecordCount.Text      = ds.Tables[0].Rows.Count.ToString();
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
                dgvPurchaseItemMaster.DataSource = null;
                clsPurchaseItemMaster objSearchPurchaseItems       = new clsPurchaseItemMaster();
                objSearchPurchaseItems.Mode                = "SELECTALL";
                objSearchPurchaseItems.CompanyID = cId;
                objSearchPurchaseItems.PurchaseItemMasterGroupFKey = Convert.ToInt32(cmbSearchPurchaseItemGroup.SelectedValue);
                objSearchPurchaseItems.PurchaseItemMasterName      = txtSearchPurchaseItemName.Text;
                objSearchPurchaseItems.PurchaseItemMasterRate      = txtSearchPurchaseItemRate.Text.Length > 0 ? Convert.ToDecimal(txtSearchPurchaseItemRate.Text) : 0;
                dgvPurchaseItemMaster.AutoGenerateColumns  = false;
                var ds                             = objSearchPurchaseItems.GetSearchPurchaseItems();
                dgvPurchaseItemMaster.DataSource           = ds.Tables[0];
                lblRecordCount.Text                = ds.Tables[0].Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "SearchBindDataGrid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region BINDCOMBOBOX
        public void BindPurchaseItemGroup()
        {
            try
            {
                clsCategoryMaster objLoad = new clsCategoryMaster();
                objLoad.Mode = "PurchaseItemGroup";
                objLoad.CompanyID = cId;
                var ds = objLoad.GetAllCategory();
                DataTable dt = ds.Tables[0];
                DataRow dr                  = dt.NewRow();
                dr["CategoryMasterCatKey"]  = "0";
                dr["CategoryMasterCatVal"]  = "Please Select PurchaseItem Group";
                dt.Rows.InsertAt(dr, 0);
                //DataRow dr                = dt.NewRow();
                /*          Bind the PurchaseItem Group     */
                cmbPurchaseItemGroup.DataSource     = dt;
                cmbPurchaseItemGroup.DisplayMember  = "CategoryMasterCatVal";
                cmbPurchaseItemGroup.ValueMember    = "CategoryMasterCatKey";
                cmbPurchaseItemGroup.Text           = "Please Select PurchaseItem Group";
                /*          Bind the PurchaseItem Group     */

                /*          Bind the Search  PurchaseItem Group     */
                cmbSearchPurchaseItemGroup.DataSource = dt;
                cmbSearchPurchaseItemGroup.DisplayMember = "CategoryMasterCatVal";
                cmbSearchPurchaseItemGroup.ValueMember   = "CategoryMasterCatKey";
                cmbSearchPurchaseItemGroup.Text          = "Please Select PurchaseItem Group";
                /*          Bind the Search  PurchaseItem Group     */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "BindPurchaseItemGroup", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        #endregion

        #region FORMLOADEVENT
        private void frmPurchaseItemMaster_Load(object sender, EventArgs e)
        {
            try
            {
                BindPurchaseItemGroup();
                BindDataGrid();
                cmbType.Text    = "Select Type";
                cmbPurchaseItemGroup.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "frmPurchaseItemMaster_Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message.ToString(), "btnDeletePurchaseItem_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Decimal validRate = 0;
                Decimal.TryParse(txtSearchPurchaseItemRate.Text, out validRate);
                int isAvaibleinListPurchaseItem = cmbPurchaseItemGroup.FindStringExact(cmbSearchPurchaseItemGroup.Text);
                String msg = String.Empty;
                if (isAvaibleinListPurchaseItem.Equals(-1))
                {
                        msg = "Please Select the PurchaseItem Group From List";
                }
                if (validRate.Equals(0) && txtSearchPurchaseItemRate.Text.Length > 0)
                {
                    if (msg.Length.Equals(0))
                    {
                        msg = "Please Enter the Valid Rate";
                    }
                    else
                    {
                        msg = msg + "\n Please Enter the Valid Rate";
                    }
                }
                if (msg.Length > 0)
                {
                    MessageBox.Show(msg, "PurchaseItem Master Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SearchBindDataGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "btnSearch_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        #endregion

        #region GRIDVIEWEVENT
        private void dgvPurchaseItemMaster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex.Equals(0))
                {
                    txtKey.Text                                 = dgvPurchaseItemMaster.Rows[e.RowIndex].Cells[1].Value.ToString();
                    cmbPurchaseItemGroup.SelectedValue          = dgvPurchaseItemMaster.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtPurchaseItemName.Text                    = dgvPurchaseItemMaster.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtPurchaseItemRate.Text                    = dgvPurchaseItemMaster.Rows[e.RowIndex].Cells[5].Value.ToString();
                    txtPurchaseItemDescription.Text             = dgvPurchaseItemMaster.Rows[e.RowIndex].Cells[6].Value.ToString();
                    txtPurchaseItemStock.Text                   = dgvPurchaseItemMaster.Rows[e.RowIndex].Cells[7].Value.ToString();
                    txtJobRate.Text                             = dgvPurchaseItemMaster.Rows[e.RowIndex].Cells[9].Value.ToString();
                    cmbType.Text                                = dgvPurchaseItemMaster.Rows[e.RowIndex].Cells[10].Value.ToString();
                    txtHsnCode.Text                             = dgvPurchaseItemMaster.Rows[e.RowIndex].Cells[11].Value.ToString();
                    btnAdd.Text                                 = "Update";
                    btnDelete.Visible                           = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "dgvPurchaseItemMaster_CellContentClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "Only Image File |*.jpeg;*.png;*.jpg;*.gif;";
                if (op.ShowDialog() != DialogResult.Cancel)
                {
                    //img_file                = op.FileName;
                    pctBoxPurchaseItemImage.Image   = Image.FromFile(op.FileName);   
                }
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.Message.ToString(), "btnBrowse_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtJobRate_TextChanged(object sender, EventArgs e)
        {

        }

    }
}



