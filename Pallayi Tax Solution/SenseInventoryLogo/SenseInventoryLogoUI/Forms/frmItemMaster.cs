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
    public partial class frmItemMaster : Form
    {
        String pageAction;
        //String img_file = "D:\\StarEngineeringUI\\Resources\\blankImage.jpg";
        int rollFKey; int cId;
        public frmItemMaster(String formAction, int rollKey, int companyId)
        {
            InitializeComponent();
            pageAction = formAction;
            rollFKey   = rollKey;
            cId        = companyId;
        }

        #region ADDUPDATEDELETEFUNCTION
        public void SaveFormData(String mode)
        {
            try
            {
                clsItemMaster objSave = new clsItemMaster();
                objSave.ItemMasterKey           = Convert.ToInt32(txtKey.Text);
                objSave.ItemMasterName          = txtItemName.Text;
                objSave.ItemMasterGroupFKey     = Convert.ToInt32(cmbItemGroup.SelectedValue);
                objSave.ItemMasterGroupFKeyName = cmbItemGroup.Text;
                objSave.ItemWeight              = txtItemWeight.Text.Length > 0 ? Convert.ToDecimal(txtItemWeight.Text) : 0;
                objSave.ItemMasterHsnCode       = txtHsnCode.Text;
                //var a   =                       Convert.ToDecimal(txtItemRate.Text)
                objSave.ItemMasterDescription   = txtItemDescription.Text;
                objSave.Mode                    = mode.ToUpper();
                objSave.CompanyID               = cId;
                if (mode.ToUpper().Equals("DELETE"))
                {
                    var confirmation = MessageBox.Show("Are You Sure You Want to Delete " + " " + txtItemName.Text, "Item Master Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
                    
                    //int isAvaibleinListItem = cmbItemGroup.FindStringExact(cmbItemGroup.Text);
                    //if (isAvaibleinListItem.Equals(-1))
                    //{
                    //    if (msg.Length.Equals(0))
                    //    {
                    //        msg = "Please Select the Item Group From List";
                    //    }
                    //    else
                    //    {
                    //        msg = msg + "\n Please Select the Item Group From List";
                    //    }
                    //}
                    Decimal validRate = 0;
                    Decimal.TryParse(txtItemRate.Text, out validRate);
                    if (validRate.Equals(0) && txtItemRate.Text.Length>0)
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
                    if (txtItemRate.Text.Length.Equals(0))
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
                    //Decimal.TryParse(txtItemStock.Text, out validStock);
                    //if (validStock.Equals(0) && txtItemStock.Text.Length > 0)
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
                    
                    if (msg.Length > 0)
                    {
                        MessageBox.Show(msg, "Item Master Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        objSave.ItemMasterRate      =   Convert.ToDecimal(txtItemRate.Text);
                        objSave.ItemMasterStock     =   txtItemStock.Text.Length > 0 ? Convert.ToDecimal(txtItemStock.Text) : 0;
                        //String picName              =   img_file.Substring(img_file.LastIndexOf('\\'));
                        //string path                 =   Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("bin"));
                        //Bitmap imgImage             =   new Bitmap(pctBoxItemImage.Image);
                        //imgImage.Save(path + "Resources" + picName);
                        //objSave.ItemMasterImage     =   path + "Resources" + picName;   
                        objSave.AddUpdateDelete();
                        MessageBox.Show(txtItemName.Text + " " + mode + " Success Fully", "Item Master Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtItemName.Text        = String.Empty;
            txtItemRate.Text        = String.Empty;
            txtItemDescription.Text = String.Empty;
            txtItemStock.Text       = String.Empty;
            txtItemWeight.Text      = String.Empty;
            txtHsnCode.Text         = String.Empty;
            //pctBoxItemImage.Image = Image.FromFile("D:\\StarEngineeringUI\\Resources\\blankImage.jpg");
            cmbItemGroup.Focus();
            btnAdd.Text             = "Add";
            btnDelete.Visible       = false;
        }
        #endregion

        #region GRIDBINDFUNCTION
        public void BindDataGrid()
        {
            try
            {
                clsItemMaster objLoad       = new clsItemMaster();
                objLoad.Mode                = "SELECTALL";
                objLoad.CompanyID           = cId;
                dgvItemMaster.AutoGenerateColumns = false;
                var ds                      = objLoad.GetAllItems(); ;
                dgvItemMaster.DataSource    = ds.Tables[0];
                lblRecordCount.Text         = ds.Tables[0].Rows.Count.ToString();
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
                dgvItemMaster.DataSource = null;
                clsItemMaster objSearchItems       = new clsItemMaster();
                objSearchItems.Mode                = "SELECTALL";
                objSearchItems.CompanyID           = cId;
                objSearchItems.ItemMasterGroupFKey = Convert.ToInt32(cmbSearchItemGroup.SelectedValue);
                objSearchItems.ItemMasterName      = txtSearchItemName.Text;
                objSearchItems.ItemMasterRate      = txtSearchItemRate.Text.Length > 0 ? Convert.ToDecimal(txtSearchItemRate.Text) : 0;
                dgvItemMaster.AutoGenerateColumns  = false;
                var ds                             = objSearchItems.GetSearchItems();
                dgvItemMaster.DataSource           = ds.Tables[0];
                lblRecordCount.Text                = ds.Tables[0].Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "SearchBindDataGrid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region BINDCOMBOBOX
        public void BindItemGroup()
        {
            try
            {
                clsCategoryMaster objLoad   = new clsCategoryMaster();
                objLoad.Mode                = "ITEMGROUP";
                objLoad.CompanyID           = cId;
                var ds                      = objLoad.GetAllCategory();
                DataTable dt                = ds.Tables[0];
                DataRow dr                  = dt.NewRow();
                dr["CategoryMasterCatKey"]  = "0";
                dr["CategoryMasterCatVal"]  = "Please Select Item Group";
                dt.Rows.InsertAt(dr, 0);
                //DataRow dr                = dt.NewRow();
                /*          Bind the Item Group     */
                cmbItemGroup.DataSource     = dt;
                cmbItemGroup.DisplayMember  = "CategoryMasterCatVal";
                cmbItemGroup.ValueMember    = "CategoryMasterCatKey";
                cmbItemGroup.Text           = "Please Select Item Group";
                /*          Bind the Item Group     */

                /*          Bind the Search  Item Group     */
                cmbSearchItemGroup.DataSource = dt;
                cmbSearchItemGroup.DisplayMember = "CategoryMasterCatVal";
                cmbSearchItemGroup.ValueMember   = "CategoryMasterCatKey";
                cmbSearchItemGroup.Text          = "Please Select Item Group";
                /*          Bind the Search  Item Group     */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "BindItemGroup", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        #endregion

        #region FORMLOADEVENT
        private void frmItemMaster_Load(object sender, EventArgs e)
        {
            try
            {
                BindItemGroup();
                BindDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "frmItemMaster_Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message.ToString(), "btnDeleteItem_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Decimal validRate = 0;
                Decimal.TryParse(txtSearchItemRate.Text, out validRate);
                String msg = String.Empty;
                //int isAvaibleinListItem = cmbItemGroup.FindStringExact(cmbSearchItemGroup.Text);
                //if (isAvaibleinListItem.Equals(-1))
                //{
                //        msg = "Please Select the Item Group From List";
                //}
                if (validRate.Equals(0) && txtSearchItemRate.Text.Length > 0)
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
                    MessageBox.Show(msg, "Item Master Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void dgvItemMaster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex.Equals(0))
                {
                    txtKey.Text                         = dgvItemMaster.Rows[e.RowIndex].Cells[1].Value.ToString();
                    cmbItemGroup.SelectedValue          = dgvItemMaster.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtItemName.Text                    = dgvItemMaster.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtItemRate.Text                    = dgvItemMaster.Rows[e.RowIndex].Cells[5].Value.ToString();
                    txtItemDescription.Text             = dgvItemMaster.Rows[e.RowIndex].Cells[6].Value.ToString();
                    txtItemStock.Text                   = dgvItemMaster.Rows[e.RowIndex].Cells[7].Value.ToString();
                    txtItemWeight.Text                  = dgvItemMaster.Rows[e.RowIndex].Cells[8].Value.ToString();
                    txtHsnCode.Text                     = dgvItemMaster.Rows[e.RowIndex].Cells[9].Value.ToString();
                    btnAdd.Text                         = "Update";
                    btnDelete.Visible                   = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "dgvItemMaster_CellContentClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    pctBoxItemImage.Image   = Image.FromFile(op.FileName);   
                }
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.Message.ToString(), "btnBrowse_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtItemWeight_TextChanged(object sender, EventArgs e)
        {

        }

    }
}



