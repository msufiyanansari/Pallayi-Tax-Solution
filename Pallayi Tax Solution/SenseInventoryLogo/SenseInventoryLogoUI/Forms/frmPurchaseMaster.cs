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
using SenseInventoryLogoUI.Forms.Class;
namespace SenseInventoryLogoUI.Forms
{
    public partial class frmPurchaseMaster : Form
    {
        int PrimaryKey = 0;
        int rollFKey;
        int cId;
        public frmPurchaseMaster(int Key, int rollKey, int companyId)
        {
            InitializeComponent();
            PrimaryKey = Key;
            rollFKey   = rollKey;
            cId        = companyId;  
        }

        List<clsPurchaseTransactionMember> lstPurchaseTransactionDetail = new List<clsPurchaseTransactionMember>();
        List<clsPurchaseTransactionPaymentMember> lstPurchasePaymentDetail = new List<clsPurchaseTransactionPaymentMember>();

        #region AddUpdateDeletePurchaseMaster
        #region FormFunction
        public void BindSupplierItemComboBox()
        {
            try
            {
                /*****************      Bind the Supplier Combo*******************/
                clsSupplierMaster objLoad = new clsSupplierMaster();
                objLoad.Mode              = "SELECTALL";
                objLoad.CompanyID         = cId;
                var dsSupplier            = objLoad.GetAllSupplier();
                //clsComboBoxItem objComboItem = new clsComboBoxItem();
                //objComboItem.Text = "Please Select Supplier";
                //objComboItem.Value = "0";
                //cmbSupplier.Items.Add(objComboItem);
                DataTable dtSupplier = dsSupplier.Tables[0];
                DataRow dr = dtSupplier.NewRow();
                dr["SupplierID"] = "0";
                dr["SupplierName"] = "Please Select the Supplier";
                dtSupplier.Rows.InsertAt(dr, 0);
                cmbSupplier.DataSource = dtSupplier;
                cmbSupplier.DisplayMember = "SupplierName";
                cmbSupplier.ValueMember = "SupplierID";
                cmbSupplier.Text = "Please Select the Supplier";
                /*****************      Bind the Supplier Combo*******************/



                clsCategoryMaster objLoadItemGroup = new clsCategoryMaster();
                objLoadItemGroup.Mode = "ITEMGROUP";
                objLoadItemGroup.CompanyID = cId;
                var ds = objLoadItemGroup.GetAllCategory();
                DataTable dtItemGroup = ds.Tables[0];
                DataRow drItemGroup = dtItemGroup.NewRow();
                drItemGroup["CategoryMasterCatKey"] = "0";
                drItemGroup["CategoryMasterCatVal"] = "Please Select Item Group";
                dtItemGroup.Rows.InsertAt(drItemGroup, 0);
                //DataRow dr                = dt.NewRow();
                /*          Bind the Item Group     */
                cmbItemGroup.DataSource = dtItemGroup;
                cmbItemGroup.DisplayMember = "CategoryMasterCatVal";
                cmbItemGroup.ValueMember = "CategoryMasterCatKey";
                cmbItemGroup.Text = "Please Select Item Group";
                /*          Bind the Item Group     */
                /*          Bind the Item Group     */

                clsCategoryMaster objLoadBank = new clsCategoryMaster();
                objLoadBank.Mode                    = "SELECTALL";
                objLoadBank.CategoryMasterCatName   = "BankName";
                objLoadBank.CompanyID               = cId;
                var dsBank                          = objLoadBank.GetAllCategory();
                DataTable dtBankName                = dsBank.Tables[0];
                DataRow drBankName                  = dtBankName.NewRow();
                drBankName["CategoryMasterCatKey"]  = "0";
                drBankName["CategoryMasterCatVal"]  = "Please Select Bank";
                dtBankName.Rows.InsertAt(drBankName, 0);
                //DataRow dr                = dt.NewRow();
                /*          Bind the Bank Combo     */
                cmbBank.DataSource         = dtBankName;
                cmbBank.DisplayMember      = "CategoryMasterCatVal";
                cmbBank.ValueMember        = "CategoryMasterCatKey";
                cmbBank.Text               = "Please Select Bank";
                /*          Bind the Bank Combo     */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "BindSupplierItemComboBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region FormLoadEvent
        private void frmPurchaseMaster_Load(object sender, EventArgs e)
        {
            try
            {
                LoadItem();
                BindSupplierItemComboBox();
                ResetPurchaseMaster();
                LoadFormData(PrimaryKey);
                if (PrimaryKey.Equals(0))
                {
                    cmbPurchaseType.Text     = "Tax Invoice";
                    cmbReverseCharge.Text = "No";
                    cmbRounoffOption.Text    = "Minus";
                }
                cmbPaymentMode.Text = "Select Mode";
                cmbPurchaseType.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "frmPurchaseMaster_Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region SelectedInexChanged
        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSupplier.SelectedIndex != 0)
                {
                    clsSupplierMaster objCutomer = new clsSupplierMaster();
                    objCutomer.Mode = "SupplierDetail";
                    objCutomer.SupplierID = Convert.ToInt32(cmbSupplier.SelectedValue);
                    var lstSupplier = objCutomer.GetSupplierDetail().FirstOrDefault();
                    lblSupplierDetail.Text = lstSupplier == null ? String.Empty : lstSupplier.SupplierDetai;
                }
                else
                {
                    lblSupplierDetail.Text = "Select the Supplier Show the Supplier Detail";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "cmbSupplier_SelectedIndexChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion



        #region PurchaseMasterMethod
        public String PurchaseMasterValidation()
        {
            try
            {
                String msg = String.Empty;
                //if (cmbPurchaseType.Text.Equals("Select Type"))
                //{
                //    msg = "Please Select Purchase Type";
                //}
                if (cmbSupplier.Text.Equals("Please Select the Supplier"))
                {
                    if (msg.Length.Equals(0))
                    {
                        msg = "Please Select the Supplier";
                    }
                    else
                    {
                        msg = msg + "\n Please Select the Supplier";
                    }
                }
                int isAvaibleinListItem = cmbSupplier.FindStringExact(cmbSupplier.Text);
                if (isAvaibleinListItem.Equals(-1))
                {
                    if (msg.Length.Equals(0))
                    {
                        msg = "Please Select the Supplier From List";
                    }
                    else
                    {
                        msg = msg + "\n Please Select the Supplier From List";
                    }
                }
                //int validInvoiceNo;
                //int.TryParse(txtInvoiceNo.Text, out validInvoiceNo);
                //if (validInvoiceNo.Equals(0))
                //{
                //    if (msg.Length.Equals(0))
                //    {
                //        msg = "Please Enter the Invoice No";
                //    }
                //    else
                //    {
                //        msg = msg + "\n Please Enter the Invoice No";
                //    }
                //}
                return msg;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "PurchaseMasterValidation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return String.Empty;
            }
        }
        public void ResetPurchaseMaster()
        {
            txtKey.Text = "0";
            txtChlnNo.Text = String.Empty;
            dtpChalanDt.Value = DateTime.Now;
            lblSupplierDetail.Text = "Select the Supplier Show the Supplier Detail:";
            txtMainTotal.Text = String.Empty;
            txtVatAmt.Text = String.Empty;
            txtAddTaxAmount.Text = String.Empty;
            txtIgstAmt.Text     = String.Empty;
            txtGTotal.Text = String.Empty;
            txtPaidAmount.Text = String.Empty;
            txtPendingAmount.Text = String.Empty;
            btnDeletePurchase.Visible = false;
            btnAddPurchase.Text = "Add";
            dgvPurchaseView.DataSource = null;
            ResetPurchaseTransaction();
            cmbSupplier.Text = "Please Select the Supplier";
            cmbItemGroup.Text = "Please Select Item Group";
            cmbPurchaseType.Text = "Tax Invoice";
            cmbRounoffOption.Text   = "Minus";
            lstPurchaseTransactionDetail.Clear();
            dgvPaymentDetail.DataSource = null;
            ResetPurchasePayment();
            lstPurchasePaymentDetail.Clear();
            txtGTotal.Text = String.Empty;
            txtPendingAmount.Text = String.Empty;
            txtPaidAmount.Text = String.Empty;
            txtTransportDetail.Text = String.Empty;
            txtVehicleNo.Text   = String.Empty;
            cmbReverseCharge.SelectedIndex = -1;
            txtRoundoff.Text    = String.Empty;
            cmbPurchaseType.Focus();
            txtCartage.Text     =   String.Empty;
        }
        public void LoadFormData(int Key = 0)
        {
            try
            {
                if (Key != 0)
                {
                    clsPurchaseMaster objLoad = new clsPurchaseMaster();
                    objLoad.Mode = "SELECTONE";
                    objLoad.PurchaseMasterKey = Key;
                    objLoad.CompanyID = cId;
                    var lstPurchaseMaster = objLoad.GetPurchaseMaster().FirstOrDefault();
                    txtKey.Text = lstPurchaseMaster.PurchaseMasterKey.ToString();
                    dtpDate.Value = Convert.ToDateTime(lstPurchaseMaster.PurchaseMasterActualDate);
                    cmbPurchaseType.Text = lstPurchaseMaster.PurchaseMasterType;
                    cmbSupplier.SelectedValue = lstPurchaseMaster.PurchaseMasterSupplierFKey.ToString();
                    lblSupplierDetail.Text = lstPurchaseMaster.PurchaseMasterSupplierDetail;
                    txtBillNo.Text = lstPurchaseMaster.PurchaseMasterBillBookNo;
                    txtInvoiceNo.Text = lstPurchaseMaster.PurchaseMasterInvoiceNo;
                    txtChlnNo.Text = lstPurchaseMaster.PurchaseMasterChlnNo;
                    cmbReverseCharge.Text = lstPurchaseMaster.PurchaseMasterReverseCharge;
                    txtVehicleNo.Text          = lstPurchaseMaster.PurchaseMasterVehicleNo;
                    if (lstPurchaseMaster.PurchaseMasterChlnDate != "01/01/1900")
                    {
                        dtpChalanDt.Value = Convert.ToDateTime(lstPurchaseMaster.PurchaseMasterChlnDate);
                    }
                    txtMainTotal.Text = lstPurchaseMaster.PurchaseMasterMainTotal.ToString();
                    txtVatAmt.Text = lstPurchaseMaster.PurchaseMasterVatAmount.ToString();
                    txtAddTaxAmount.Text = lstPurchaseMaster.PurchaseMasterAddTaxAmt.ToString();
                    txtIgstAmt.Text      = lstPurchaseMaster.PurchaseMasterISGTAmount.ToString();
                    txtGTotal.Text = lstPurchaseMaster.PurchaseMasterGrossTotal.ToString();
                    txtPaidAmount.Text = lstPurchaseMaster.PurchaseMasterPaidAmount.ToString();
                    txtPendingAmount.Text = lstPurchaseMaster.PurchaseMasterPendingAmount.ToString();
                    lstPurchaseTransactionDetail = lstPurchaseMaster.lstPurchaseTransaction;
                    dgvPurchaseView.AutoGenerateColumns = false;
                    dgvPurchaseView.DataSource = lstPurchaseTransactionDetail;
                    lstPurchasePaymentDetail   =   lstPurchaseMaster.lstPurchasePayment;
                    dgvPaymentDetail.AutoGenerateColumns = false;
                    dgvPaymentDetail.DataSource = lstPurchasePaymentDetail;
                    btnAddPurchase.Text = "Update";
                    btnDeletePurchase.Visible = true;
                    txtTransportDetail.Text = lstPurchaseMaster.TranMasterTransportDetail;
                    txtRoundoff.Text        = lstPurchaseMaster.PurchaseMasterRoundoff.ToString();
                    cmbRounoffOption.Text        = lstPurchaseMaster.PurchaseMasterRoundoffOption;
                    txtCartage.Text         = lstPurchaseMaster.PurchaseMasterCartage.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "LoadFormData", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SavePurchaseMaster(string mode)
        {
            try
            {
                clsPurchaseMaster objSave = new clsPurchaseMaster();
                objSave.Mode              = mode.ToUpper();
                String Billdate = dtpDate.Value.ToString("dd/MM/yyyy");
                objSave.CompanyID         = cId;
                objSave.PurchaseMasterDate = clsCommoan.GetDateInddMMYYYY(dtpDate.Value.ToString());
                objSave.PurchaseMasterSupplierFKey = Convert.ToInt32(cmbSupplier.SelectedValue);
                objSave.PurchaseMasterBillBookNo = txtBillNo.Text;
                objSave.PurchaseMasterInvoiceNo = txtInvoiceNo.Text;
                objSave.PurchaseMasterChlnNo = txtChlnNo.Text;
                String chlnDate = dtpChalanDt.Value.ToString("dd/MM/yyyy");
                objSave.PurchaseMasterType = cmbPurchaseType.Text;
                objSave.PurchaseMasterReverseCharge    = cmbReverseCharge.Text;
                objSave.PurchaseMasterVehicleNo        = txtVehicleNo.Text;
                if (DateTime.Now.ToString("dd/MM/yyyy") != chlnDate)
                {
                    objSave.PurchaseMasterChlnDate = clsCommoan.GetDateInddMMYYYY(dtpChalanDt.Value.ToString());
                }
                objSave.PurchaseMasterKey = Convert.ToInt32(txtKey.Text);
                objSave.PurchaseTransactionXML = clsPurchaseTransactionMember.GetPurchaseTransactionXML(lstPurchaseTransactionDetail);
                objSave.PurchaseMasterSupplierDetail = lblSupplierDetail.Text;
                objSave.PurchaseMasterMainTotal = txtMainTotal.Text.Length > 0 ? Convert.ToDecimal(txtMainTotal.Text) : 0;
                objSave.PurchaseMasterVatAmount = txtVatAmt.Text.Length > 0 ? Convert.ToDecimal(txtVatAmt.Text) : 0;
                objSave.PurchaseMasterAddTaxAmt = txtAddTaxAmount.Text.Length > 0 ? Convert.ToDecimal(txtAddTaxAmount.Text) : 0;
                objSave.PurchaseMasterISGTAmount = txtIgstAmt.Text.Length > 0 ? Convert.ToDecimal(txtIgstAmt.Text) : 0;  
                objSave.PurchaseMasterPaidAmount = txtPaidAmount.Text.Length > 0 ? Convert.ToDecimal(txtPaidAmount.Text) : 0;
                objSave.PurchaseMasterPendingAmount    = txtPendingAmount.Text.Length>0?Convert.ToDecimal(txtPendingAmount.Text):0;
                objSave.PurchaseMasterPaymentXML = clsPurchaseTransactionPaymentMember.GetPurchasePaymentXML(lstPurchasePaymentDetail);
                objSave.TranMasterTransportDetail   = txtTransportDetail.Text;
                objSave.PurchaseMasterGrossTotal = txtGTotal.Text.Length > 0 ? Convert.ToDecimal(txtGTotal.Text) : 0;
                objSave.PurchaseMasterRoundoff   = txtRoundoff.Text.Length > 0 ? Convert.ToDecimal(txtRoundoff.Text) : 0;  
                objSave.PurchaseMasterRoundoffOption    = cmbRounoffOption.Text;
                objSave.PurchaseMasterCartage           = txtCartage.Text.Length > 0 ? Convert.ToDecimal(txtCartage.Text) : 0;
                if (mode.ToUpper().Equals("DELETE"))
                {
                    var confirmation = MessageBox.Show("Are You Sure You Want to Delete " + " " + cmbSupplier.Text, "Purchase Master Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (confirmation.ToString().Equals("Yes"))
                    {
                        objSave.AddUpdateDelete();
                        MessageBox.Show("Bill Book No : " + txtBillNo.Text + " Invoice No : " + txtInvoiceNo.Text + " " + mode + " SuccessFully", "Purchase Master Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetPurchaseMaster();
                    }
                }
                else
                {
                    string msg = PurchaseMasterValidation();
                    if (msg.Length > 0)
                    {
                        MessageBox.Show(msg, "Purchase Master Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        objSave.AddUpdateDelete();
                        MessageBox.Show("Bill Book No : " + txtBillNo.Text + " Invoice No : " + txtInvoiceNo.Text + " " + mode + " SuccessFully", "Purchase Master Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetPurchaseMaster();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "SavePurchaseMaster", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GetHsnCode(int catekey)
        {
            try
            {
                clsCategoryMaster objCateKey    = new clsCategoryMaster();
                objCateKey.CategoryMasterCatKey = catekey;
                objCateKey.Mode                 = "SELECTONE";
                var lstCateKey                  = objCateKey.GetCategory().FirstOrDefault();
                txtHsnCode.Text                 = lstCateKey.CategoryMasterHsnCode;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "GetHsnCode", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region ButtonMaster
        private void btnAddPurchase_Click(object sender, EventArgs e)
        {
            try
            {
                SavePurchaseMaster(btnAddPurchase.Text.ToUpper());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "btnAddPurchase_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeletePurchase_Click(object sender, EventArgs e)
        {
            try
            {
                SavePurchaseMaster(btnDeletePurchase.Text.ToUpper());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "btnDeletePurchase_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion 
        #endregion

        #region AddUpdateDeletePurchaseTransaction

        #region PurchaseTransactionSelectedIndex
        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbItem.ValueMember != "")
                {
                    if (cmbItem.Text != "Please Select Item")
                    {
                        clsItemMaster objItem = new clsItemMaster();
                        objItem.ItemMasterKey = Convert.ToInt32(cmbItem.SelectedValue);
                        objItem.Mode = "SELECTONE";
                        objItem.CompanyID        = cId;
                        var lstItemDetail        = objItem.GetItemMaster().FirstOrDefault();
                        if (lstItemDetail != null)
                        {
                            txtPreviousRate.Text = lstItemDetail.ItemMasterRate.ToString();
                            txtItemStock.Text    = lstItemDetail.ItemMasterStock.ToString();
                            txtHsnCode.Text      = lstItemDetail.ItemMasterHsnCode;
                        }
                    }
                    else
                    {
                        txtPreviousRate.Text = String.Empty;
                        txtItemStock.Text = String.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "cmbItem_SelectedIndexChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmbItemGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbItemGroup.ValueMember != "")
                {
                    if (cmbItemGroup.Text != "Please Select Item Group")
                    {
                        clsPurchaseItemMaster objItemGroupItem = new clsPurchaseItemMaster();
                        objItemGroupItem.PurchaseItemMasterGroupFKey = Convert.ToInt32(cmbItemGroup.SelectedValue);
                        objItemGroupItem.Mode = "SELECTALL";
                        var ds = objItemGroupItem.GetPurchaseItemGroupPurchaseItems();
                        DataTable dtItems = ds.Tables[0];
                        DataRow drItems = dtItems.NewRow();
                        drItems["PurchaseItemMasterKey"] = "0";
                        drItems["PurchaseItemMasterName"] = "Please Select Item";
                        dtItems.Rows.InsertAt(drItems, 0);
                        cmbItem.DataSource = dtItems;
                        cmbItem.DisplayMember = "PurchaseItemMasterName";
                        cmbItem.ValueMember   = "PurchaseItemMasterKey";
                        cmbItem.Text = "Please Select Item";
                        GetHsnCode(Convert.ToInt32(cmbItemGroup.SelectedValue));
                    }
                    else
                    {
                        txtHsnCode.Text    = String.Empty;
                        cmbItem.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "cmbItemGroup_SelectedIndexChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region KeyUpEvent
        public String TotalValidation()
        {
            try
            {
                String msg = String.Empty;
                Decimal validQty = 0;
                Decimal.TryParse(txtQty.Text, out validQty);
                if (validQty.Equals(0) && txtQty.Text.Length > 0)
                {
                    txtQty.Text = String.Empty;
                    if (msg.Length.Equals(0))
                    {
                        msg = "Please Enter the Valid Qty";
                    }
                    else
                    {
                        msg = msg + "\nPlease Enter the Valid Qty";
                    }
                }
                Decimal validRate = 0;
                Decimal.TryParse(txtRate.Text, out validRate);
                if (validRate.Equals(0) && txtRate.Text.Length > 0)
                {
                    txtRate.Text = String.Empty;
                    if (msg.Length.Equals(0))
                    {
                        msg = "Please Enter the Valid Rate";
                    }
                    else
                    {
                        msg = msg + "\nPlease Enter the Valid Rate";
                    }
                }
                Decimal validCgstPer = 0;
                Decimal.TryParse(txtCgstPer.Text, out validCgstPer);
                if (validCgstPer.Equals(0) && txtCgstPer.Text.Length > 0)
                {
                    txtCgstPer.Text = String.Empty;
                    if (msg.Length.Equals(0))
                    {
                        msg = "Please Enter the Valid CGST(%)";
                    }
                    else
                    {
                        msg = msg + "\n Please Enter the Valid CGST(%)";
                    }
                }
                Decimal validSgstPer = 0;
                Decimal.TryParse(txtSGSTPer.Text, out validSgstPer);
                if (validSgstPer.Equals(0) && txtSGSTPer.Text.Length > 0)
                {
                    txtSGSTPer.Text = String.Empty;
                    if (msg.Length.Equals(0))
                    {
                        msg = "Please Enter the Valid SGST(%)";
                    }
                    else
                    {
                        msg = msg + "\n Please Enter the Valid SGST(%)";
                    }
                }
                Decimal validIgstPer = 0;
                Decimal.TryParse(txtIgstPer.Text, out validIgstPer);
                if (validIgstPer.Equals(0) && txtIgstPer.Text.Length > 0)
                {
                    txtIgstPer.Text = String.Empty;
                    if (msg.Length.Equals(0))
                    {
                        msg = "Please Enter the Valid IGST(%)";
                    }
                    else
                    {
                        msg = msg + "\n Please Enter the Valid IGST(%)";
                    }
                }
                Decimal validDiscountPer = 0;
                Decimal.TryParse(txtDiscountPer.Text, out validDiscountPer);
                if (validDiscountPer.Equals(0) && txtDiscountPer.Text.Length > 0)
                {
                    txtDiscountPer.Text = String.Empty;
                    if (msg.Length.Equals(0))
                    {
                        msg = "Please Enter the Valid Discount";
                    }
                    else
                    {
                        msg = msg + "\n Please Enter the Valid Discount";
                    }
                }
                return msg;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "TotalValidation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return String.Empty;
            }
        }
        private void txtQty_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                String msg = String.Empty;//TotalValidation();
                if (msg.Length > 0)
                {
                    MessageBox.Show(msg, "Sales Total Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ItemCalcution();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "txtQty_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ItemCalcution()
        {
            try
            {
                Decimal validQty = 0;
                Decimal validRate = 0;
                Decimal validTaxableAmt = 0;
                Decimal validCgstPer = 0;
                Decimal validCgstAmt = 0;
                Decimal validSgstPer = 0;
                Decimal validSgstAmt = 0;
                Decimal validIgstPer = 0;
                Decimal validIgstAmt = 0;
                Decimal validDiscPer = 0;
                Decimal validDiscAmt = 0;
                Decimal validTotal = 0;
                Decimal.TryParse(txtQty.Text, out validQty);
                Decimal.TryParse(txtRate.Text, out validRate);
                Decimal.TryParse(txtCgstPer.Text, out validCgstPer);
                Decimal.TryParse(txtSGSTPer.Text, out validSgstPer);
                Decimal.TryParse(txtIgstPer.Text, out validIgstPer);
                Decimal.TryParse(txtDiscountPer.Text, out validDiscPer);
                validTaxableAmt = Math.Round((validQty * validRate), 2);
                validCgstAmt = validCgstPer.Equals(0) ? 0 : Math.Round(((validTaxableAmt) * (validCgstPer)) / 100, 2);
                validSgstAmt = validSgstPer.Equals(0) ? 0 : Math.Round(((validTaxableAmt) * (validSgstPer)) / 100, 2);
                validIgstAmt = validIgstPer.Equals(0) ? 0 : Math.Round(((validTaxableAmt) * (validIgstPer)) / 100, 2);
                validDiscAmt = validDiscPer.Equals(0) ? 0 : Math.Round(((validTaxableAmt) * (validDiscPer)) / 100, 2);
                validTotal = Math.Round(validTaxableAmt + validCgstAmt + validSgstAmt + validIgstAmt - validDiscAmt, 2);
                txtTaxableValue.Text = validTaxableAmt.ToString();
                txtCGSTAmt.Text = validCgstAmt.ToString();
                txtSgstAmt.Text = validSgstAmt.ToString();
                txtGstAmt.Text = validIgstAmt.ToString();
                txtDiscountAmt.Text = validDiscAmt.ToString();
                txtTotal.Text = validTotal.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "ItemCalcution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CalculateMainTotal()
        {
            try
            {
                Decimal MainTotal = 0;
                Decimal CGSTAmt = 0;
                Decimal SGSTAmt = 0;
                Decimal IGSTAmt = 0;
                Decimal GTOTAL = 0;
                Decimal PaidAmt = 0;
                Decimal Roundoff = 0;
                Decimal Cartage = 0;
                foreach (DataGridViewRow row in dgvPurchaseView.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        if (row.Cells[18].Value.ToString() == "DELETE")
                        {
                            dgvPurchaseView.CurrentCell = null;
                            row.Visible = false;
                        }
                        else
                        {
                            MainTotal += Convert.ToDecimal(row.Cells[6].Value.ToString());
                            CGSTAmt += Convert.ToDecimal(row.Cells[8].Value.ToString());
                            SGSTAmt += Convert.ToDecimal(row.Cells[10].Value.ToString());
                            IGSTAmt += Convert.ToDecimal(row.Cells[12].Value.ToString());
                            GTOTAL += Convert.ToDecimal(row.Cells[13].Value.ToString());
                        }
                    }
                }
                Decimal.TryParse(txtPaidAmount.Text, out PaidAmt);
                Decimal.TryParse(txtRoundoff.Text, out Roundoff);
                Decimal.TryParse(txtCartage.Text, out Cartage);
                txtMainTotal.Text = Math.Round(MainTotal, 2).ToString();
                txtVatAmt.Text = Math.Round(CGSTAmt, 2).ToString();
                txtAddTaxAmount.Text = Math.Round(SGSTAmt, 2).ToString();
                txtIgstAmt.Text = Math.Round(IGSTAmt, 2).ToString();
                if (cmbRounoffOption.Text.Equals("Minus"))
                {
                    txtGTotal.Text = Math.Round(GTOTAL + Cartage - Roundoff, 2).ToString();
                    txtPendingAmount.Text = Math.Round(GTOTAL + Cartage - PaidAmt - Roundoff, 2).ToString();
                }
                else
                {
                    txtGTotal.Text = Math.Round(GTOTAL + Cartage + Roundoff, 2).ToString();
                    txtPendingAmount.Text = Math.Round(GTOTAL + Cartage + PaidAmt - Roundoff, 2).ToString();
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "CalculateMainTotal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtRate_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                String msg = String.Empty;//TotalValidation();
                if (msg.Length > 0)
                {
                    MessageBox.Show(msg, "Sales Total Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ItemCalcution();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "txtRate_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region PurchaseTransactionEvent
        #region PurchaseTransactionMethod
        public void SavePurchaseTransaction(String mode)
        {
            try
            {
                clsPurchaseTransactionMember objSave = new clsPurchaseTransactionMember();
                objSave.Mode = mode.ToUpper();
                if (mode.ToUpper().Equals("DELETE"))
                {
                    var confirmation = MessageBox.Show("Are You Sure You Want to Delete " + " " + cmbItem.Text, "Purchase Item Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (confirmation.ToString().Equals("Yes"))
                    {
                        objSave.Index = Convert.ToInt32(txtIndex.Text);
                        objSave.PurchaseTransactionKey = Convert.ToInt32(txtPurchaseTransactionKey.Text);
                        objSave.PurchaseTransactionQty = txtQty.Text.Length > 0 ? Convert.ToDecimal(txtQty.Text) : 0;
                        objSave.PurchaseTransactionTotal = txtTotal.Text.Length > 0 ? Convert.ToDecimal(txtTotal.Text) : 0;
                        objSave.PurchaseTransactionRate = txtRate.Text.Length > 0 ? Convert.ToDecimal(txtRate.Text) : 0;
                        objSave.PurchaseTransactionHsnCode = txtHsnCode.Text;
                        var lstPurchaseTransactiontmp = clsPurchaseTransactionMember.AddUpdateDeletePurchaseTransaction(objSave, lstPurchaseTransactionDetail);
                        lstPurchaseTransactionDetail = lstPurchaseTransactiontmp;
                        dgvPurchaseView.AutoGenerateColumns = false;
                        dgvPurchaseView.DataSource = lstPurchaseTransactionDetail;
                        CalculateMainTotal();
                        ResetPurchaseTransaction();
                    }
                }
                else
                {

                    String msg = PurchaseTransactionValidation();
                    Decimal validStock = 0;
                    Decimal.TryParse(txtItemStock.Text, out validStock);
                    if (msg.Length > 0)
                    {
                        MessageBox.Show(msg, "Purchase Item Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        objSave.PurchaseTransactionItemGroupFKey = Convert.ToInt32(cmbItemGroup.SelectedValue);
                        objSave.PurchaseTransactionItemGroupFKeyName = cmbItemGroup.Text;
                        int isAvaibleinListItem = cmbItem.FindStringExact(cmbItem.Text);
                        if ((cmbItem.Text != "Please Select Item" && cmbItem.Text != "" && isAvaibleinListItem == -1))
                        {
                            objSave.PurchaseTransactionItemFKey = AddNewItemRunTime();
                        }
                        else
                        {
                            if (isAvaibleinListItem != -1)
                            {
                                cmbItem.Text = cmbItem.Text;
                                objSave.PurchaseTransactionItemFKey = Convert.ToInt32(cmbItem.SelectedValue);
                            }
                            else
                            {
                                objSave.PurchaseTransactionItemFKey = Convert.ToInt32(cmbItem.SelectedValue);
                            }
                        }
                        objSave.PurchaseTransactionItemFKeyName     = cmbItem.Text; 
                        objSave.Index = Convert.ToInt32(txtIndex.Text);
                        objSave.PurchaseTransactionKey = Convert.ToInt32(txtPurchaseTransactionKey.Text);
                        objSave.PurchaseTransactionQty = Convert.ToDecimal(txtQty.Text);
                        objSave.PurchaseTransactionTotal = Convert.ToDecimal(txtTotal.Text);
                        objSave.PurchaseTransactionRate = Convert.ToDecimal(txtRate.Text);
                        objSave.PurchaseTransactionTaxableAmt = txtTaxableValue.Text.Length > 0 ? Convert.ToDecimal(txtTaxableValue.Text) : 0;
                        objSave.PurchaseTransactionCGSTPer = txtCgstPer.Text.Length > 0 ? Convert.ToDecimal(txtCgstPer.Text) : 0;
                        objSave.PurchaseTransactionCGSTAmt = txtCGSTAmt.Text.Length > 0 ? Convert.ToDecimal(txtCGSTAmt.Text) : 0;
                        objSave.PurchaseTransactionSGSTPer = txtSGSTPer.Text.Length > 0 ? Convert.ToDecimal(txtSGSTPer.Text) : 0;
                        objSave.PurchaseTransactionSGSTAmt = txtSgstAmt.Text.Length > 0 ? Convert.ToDecimal(txtSgstAmt.Text) : 0;
                        objSave.PurchaseTransactionIGSTPer = txtIgstPer.Text.Length > 0 ? Convert.ToDecimal(txtIgstPer.Text) : 0;
                        objSave.PurchaseTransactionIGSTAmt = txtGstAmt.Text.Length > 0 ? Convert.ToDecimal(txtGstAmt.Text) : 0;
                        objSave.PurchaseTransactionDiscPer = txtDiscountPer.Text.Length > 0 ? Convert.ToDecimal(txtDiscountPer.Text) : 0;
                        objSave.PurchaseTransactionDiscAmt = txtDiscountAmt.Text.Length > 0 ? Convert.ToDecimal(txtDiscountAmt.Text) : 0;
                        objSave.PurchaseTransactionPoNo      = txtPoNo.Text;
                        objSave.PurchaseTransactionHsnCode = txtHsnCode.Text;
                        var lstPurchaseTransactiontmp = clsPurchaseTransactionMember.AddUpdateDeletePurchaseTransaction(objSave, lstPurchaseTransactionDetail);
                        lstPurchaseTransactionDetail  = lstPurchaseTransactiontmp;
                        dgvPurchaseView.AutoGenerateColumns = false;
                        dgvPurchaseView.DataSource = lstPurchaseTransactionDetail;
                        CalculateMainTotal();
                        ResetPurchaseTransaction();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "SavePurchaseTransaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ResetPurchaseTransaction()
        {
            txtPreviousRate.Text = String.Empty;
            txtQty.Text = String.Empty;
            txtRate.Text = String.Empty;
            txtTotal.Text = String.Empty;
            txtHsnCode.Text = String.Empty;
            txtPurchaseTransactionKey.Text = "0";
            txtIndex.Text = "0";
            btnAddItem.Text = "Add";
            btnDeleteItem.Visible = false;
            cmbItem.Text = "Please Select the Item";
            txtPoNo.Text = String.Empty;
            txtCgstPer.Text = String.Empty;
            txtCGSTAmt.Text = String.Empty;
            txtSGSTPer.Text = String.Empty;
            txtSgstAmt.Text = String.Empty;
            txtIgstPer.Text = String.Empty;
            txtGstAmt.Text = String.Empty;
            txtHsnCode.Text = String.Empty;
            txtTaxableValue.Text = String.Empty;
            txtDiscountPer.Text = String.Empty;
            txtDiscountAmt.Text = String.Empty;
        }
        public Decimal CalculateTotal(string mode)
        {
            try
            {
                Decimal MainTotal = 0;
                foreach (DataGridViewRow row in dgvPurchaseView.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        //if (row.Cells[10].Value.ToString() == "DELETE" && row.Index.Equals(0))
                        //{
                        //    MessageBox.Show("You Cant Delete this Item  Becoze This is First Item in List You Can Update it as well as You Delete Other Exist Item ", "Purchase Item Delete Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //    ResetPurchaseTransaction();
                        //    MainTotal += Convert.ToDecimal(row.Cells[5].Value.ToString());
                        //}
                        //else
                        //{
                        if (row.Cells[10].Value.ToString() == "DELETE")
                        {
                            //row.
                            dgvPurchaseView.CurrentCell = null;
                            row.Visible = false;
                        }
                        else
                        {
                            MainTotal += Convert.ToDecimal(row.Cells[5].Value.ToString());
                        }
                    }
                }
                return MainTotal;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "CalculateTotal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public String PurchaseTransactionValidation()
        {
            try
            {
                String msg = String.Empty;
                //if (cmbItemGroup.Text == "Please Select Item Group")
                //{
                //    msg = msg + "Please Select the Item Group";
                //}
                //int isAvaibleItemGroupinListItem = cmbItemGroup.FindStringExact(cmbItemGroup.Text);
                //if (isAvaibleItemGroupinListItem.Equals(-1))
                //{
                //    if (msg.Length.Equals(0))
                //    {
                //        msg = "Please Select the Item Group From List";
                //    }
                //    else
                //    {
                //        msg = msg + "\nPlease Select the Item Group From List";
                //    }
                //}
                //if (cmbItem.Text == "Please Select Item" || cmbItem.Text == "")
                //{
                //    if (msg.Length.Equals(0))
                //    {
                //        msg = "Please Select the Item";
                //    }
                //    else
                //    {
                //        msg = msg + "\nPlease Select the Item";
                //    }
                //}
                //int isAvaibleIteminListItem = cmbItem.FindStringExact(cmbItem.Text);
                //if (isAvaibleIteminListItem.Equals(-1))
                //{
                //    if (msg.Length.Equals(0))
                //    {
                //        msg = "Please Select the Item From List";
                //    }
                //    else
                //    {
                //        msg = msg + "\nPlease Select the Item From List";
                //    }
                //}
                if (txtQty.Text.Length.Equals(0))
                {
                    if (msg.Length.Equals(0))
                    {
                        msg = "Please Enter the Qty";
                    }
                    else
                    {
                        msg = msg + "\nPlease Enter the Qty ";
                    }
                }
                Decimal validQty = 0;
                Decimal.TryParse(txtQty.Text, out validQty);
                if (validQty.Equals(0) && txtQty.Text.Length > 0)
                {
                    if (msg.Length.Equals(0))
                    {
                        msg = "Please Enter the Valid Qty";
                    }
                    else
                    {
                        msg = msg + "\nPlease Enter the Valid Qty";
                    }
                }

                if (txtRate.Text.Length.Equals(0))
                {
                    if (msg.Length.Equals(0))
                    {
                        msg = "Please Enter the Rate";
                    }
                    else
                    {
                        msg = msg + "\nPlease Enter the Rate";
                    }
                }
                Decimal validRate = 0;
                Decimal.TryParse(txtRate.Text, out validRate);
                if (validRate.Equals(0) && txtRate.Text.Length > 0)
                {
                    if (msg.Length.Equals(0))
                    {
                        msg = "Please Enter the Valid Rate";
                    }
                    else
                    {
                        msg = msg + "\nPlease Enter the Valid Qty";
                    }
                }
                return msg;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "PurchaseTransactionValidation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return String.Empty;
            }
        } 
        #endregion

        #region ButtonPurchaseTransactionEvent
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            SavePurchaseTransaction(btnAddItem.Text);
        }
        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            SavePurchaseTransaction(btnDeleteItem.Text);
        }
        #endregion

        #region PurchaseTransactionGridViewEvent
        private void dgvPurchaseView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex.Equals(0))
                {
                    txtPurchaseTransactionKey.Text = dgvPurchaseView.Rows[e.RowIndex].Cells[15].Value.ToString();
                    txtIndex.Text                  = dgvPurchaseView.Rows[e.RowIndex].Cells[17].Value.ToString();
                    cmbItemGroup.SelectedValue     = dgvPurchaseView.Rows[e.RowIndex].Cells[19].Value.ToString();
                    cmbItem.SelectedValue          = dgvPurchaseView.Rows[e.RowIndex].Cells[14].Value.ToString();
                    cmbItem.Text                   = dgvPurchaseView.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtQty.Text                    = dgvPurchaseView.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtRate.Text                   = dgvPurchaseView.Rows[e.RowIndex].Cells[5].Value.ToString();
                    txtTaxableValue.Text           = dgvPurchaseView.Rows[e.RowIndex].Cells[6].Value.ToString();
                    txtTotal.Text                  = dgvPurchaseView.Rows[e.RowIndex].Cells[13].Value.ToString();
                    txtPoNo.Text                   = dgvPurchaseView.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtHsnCode.Text                = dgvPurchaseView.Rows[e.RowIndex].Cells[20].Value.ToString();
                    txtCgstPer.Text                = Convert.ToDecimal(dgvPurchaseView.Rows[e.RowIndex].Cells[7].Value.ToString()).Equals(0) ? String.Empty : dgvPurchaseView.Rows[e.RowIndex].Cells[7].Value.ToString();
                    txtCGSTAmt.Text                = Convert.ToDecimal(dgvPurchaseView.Rows[e.RowIndex].Cells[8].Value.ToString()).Equals(0) ? String.Empty : dgvPurchaseView.Rows[e.RowIndex].Cells[8].Value.ToString();
                    txtSGSTPer.Text                = Convert.ToDecimal(dgvPurchaseView.Rows[e.RowIndex].Cells[9].Value.ToString()).Equals(0) ? String.Empty : dgvPurchaseView.Rows[e.RowIndex].Cells[9].Value.ToString();
                    txtSgstAmt.Text                = Convert.ToDecimal(dgvPurchaseView.Rows[e.RowIndex].Cells[10].Value.ToString()).Equals(0) ? String.Empty : dgvPurchaseView.Rows[e.RowIndex].Cells[10].Value.ToString();
                    txtIgstPer.Text                = Convert.ToDecimal(dgvPurchaseView.Rows[e.RowIndex].Cells[11].Value.ToString()).Equals(0) ? String.Empty : dgvPurchaseView.Rows[e.RowIndex].Cells[11].Value.ToString();
                    txtGstAmt.Text                 = Convert.ToDecimal(dgvPurchaseView.Rows[e.RowIndex].Cells[12].Value.ToString()).Equals(0) ? String.Empty : dgvPurchaseView.Rows[e.RowIndex].Cells[12].Value.ToString();
                    txtDiscountPer.Text            = Convert.ToDecimal(dgvPurchaseView.Rows[e.RowIndex].Cells[21].Value.ToString()).Equals(0) ? String.Empty : dgvPurchaseView.Rows[e.RowIndex].Cells[21].Value.ToString();
                    txtDiscountAmt.Text            = Convert.ToDecimal(dgvPurchaseView.Rows[e.RowIndex].Cells[22].Value.ToString()).Equals(0) ? String.Empty : dgvPurchaseView.Rows[e.RowIndex].Cells[22].Value.ToString();
                    btnAddItem.Text                = "Update";
                    btnDeleteItem.Visible          = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "dgvPurchaseView_CellContentClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion 
        #endregion

        

        #endregion

        #region AddUpdateDeletePayment

        #region PaymentSelectedIndexEvent
        private void cmbPaymentMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbPaymentMode.Text.Equals("Select Mode") || cmbPaymentMode.Text.Equals("Cash"))
                {
                    cmbBank.Text = "Please Select Bank";
                    cmbBank.Visible = false;
                    lblBankName.Visible = false;
                    dtpChequeDate.Value = DateTime.Now;
                    dtpChequeDate.Visible = false;
                    lblChequeDate.Visible = false;
                    txtChequeNo.Text = String.Empty;
                    txtChequeNo.Visible = false;
                    lblChequeNo.Visible = false;
                    btnAddBank.Visible = false;
                    btnLoadBank.Visible = false;
                }
                else
                {
                    cmbBank.Visible = true;
                    dtpChequeDate.Visible = true;
                    txtChequeNo.Visible = true;
                    lblBankName.Visible = true;
                    lblChequeDate.Visible = true;
                    lblChequeNo.Visible = true;
                    btnAddBank.Visible = true;
                    btnLoadBank.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "cmbPaymentMode_SelectedIndexChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        #endregion

        #region PaymentButtonEvent
        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            try
            {
                SavePurchasePayment(btnAddPayment.Text.ToUpper());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "btnAddPayment_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeletePayment_Click(object sender, EventArgs e)
        {
            try
            {
                SavePurchasePayment(btnDeletePayment.Text.ToUpper());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "btnDeletePayment_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        #endregion

        #region PaymentMethod
        public String PurchasePaymentValidation()
        {
            try
            {
                String msg = String.Empty;
                if (cmbPaymentMode.Text.Equals("Select Mode") || cmbPaymentMode.Text.Equals("Cash"))
                {
                    if (cmbPaymentMode.Text.Equals("Select Mode"))
                    {
                        msg = msg + "Please Select the Payment Mode";
                    }
                    if (txtPayAmount.Text.Length.Equals(0) && msg.Length.Equals(0))
                    {
                        msg = msg + "Please Enter the Amount Value";
                    }
                    else
                    {
                        if (txtPayAmount.Text.Length.Equals(0))
                        {
                            msg = msg + "\nPlease Enter the Amount Value";
                        }
                    }
                }
                else
                {
                    if (txtPayAmount.Text.Length.Equals(0))
                    {
                        msg = msg + "Please Enter the Amount Value";
                    }
                    if (cmbBank.Text.Equals("Please Select Bank") && msg.Length.Equals(0))
                    {
                        msg = msg + "Please Select the Bank";
                    }
                    else
                    {
                        if (cmbBank.Text.Equals("Please Select Bank"))
                        {
                            msg = msg + "\nPlease Select the Bank";
                        }
                    }
                    int isAvaibleBankListItem = cmbBank.FindStringExact(cmbBank.Text);
                    if (cmbBank.Text != "Please Select Bank" && msg.Length.Equals(0) && isAvaibleBankListItem.Equals(-1))
                    {
                        msg = msg + "Please Select the Bank From the List";
                    }
                    else
                    {
                        if (cmbBank.Text != "Please Select Bank" && isAvaibleBankListItem.Equals(-1))
                        {
                            msg = msg + "\nPlease Select the Bank From the List";
                        }
                    }
                    if (txtChequeNo.Text.Length.Equals(0) && msg.Length.Equals(0))
                    {
                        msg = msg + "Please Enter the Cheque No as Well as Tran ID";
                    }
                    else
                    {
                        if (txtChequeNo.Text.Length.Equals(0))
                        {
                            msg = msg + "\nPlease Enter the Cheque No as Well as Tran ID";
                        }
                    }
                }
                return msg;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "PurchasePaymentValidation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return String.Empty;
            }
        }

        public void SavePurchasePayment(String mode)
        {
            try
            {
                clsPurchaseTransactionPaymentMember objSave = new clsPurchaseTransactionPaymentMember();
                objSave.Mode = mode.ToUpper();
                if (mode.ToUpper().Equals("DELETE"))
                {
                    var confirmation = MessageBox.Show("Are You Sure You Want to Delete This Payment Amount " + " " + txtPayAmount.Text, "Purchase Payment Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (confirmation.ToString().Equals("Yes"))
                    {
                        objSave.Index = Convert.ToInt32(txtPaymentIndex.Text);
                        objSave.PurchaseTransactionPayKey = Convert.ToInt32(txtPurchaseTransactionPayKey.Text);
                        objSave.PurchaseTransactionPayType = cmbPaymentMode.Text;
                        if (cmbPaymentMode.Text.Equals("Cash"))
                        {
                            objSave.PurchaseTransactionPayDate   = dtpPaymentDate.Value.ToString("dd/MM/yyyy");
                            objSave.PurchaseActualTransactionPayDate = clsCommoan.GetDateInddMMYYYY(dtpPaymentDate.Value.ToString());
                            objSave.PurchaseTransactionPayAmount = txtPayAmount.Text.Length > 0 ? Convert.ToDecimal(txtPayAmount.Text) : 0;
                        }
                        else
                        {
                            objSave.PurchaseTransactionPayDate = dtpPaymentDate.Value.ToString("dd/MM/yyyy");
                            objSave.PurchaseActualTransactionPayDate   = clsCommoan.GetDateInddMMYYYY(dtpPaymentDate.Value.ToString());
                            objSave.PurchaseActualTransactionCheckDate = clsCommoan.GetDateInddMMYYYY(dtpChequeDate.Value.ToString());
                            objSave.PurchaseTransactionPayAmount = txtPayAmount.Text.Length > 0 ? Convert.ToDecimal(txtPayAmount.Text) : 0;
                            objSave.PurchaseTransactionPayBankFKey = Convert.ToInt32(cmbBank.SelectedValue);
                            objSave.PurchaseTransactionPayBankFKeyName = cmbBank.Text;
                            objSave.PurchaseTransactionPayChequeDate = dtpChequeDate.Value.ToString("dd/MM/yyyy");
                            objSave.PurchaseTransactionPayBankChequeNo = txtChequeNo.Text;
                        }
                        var lstPurchasePaymentDetailtmp = clsPurchaseTransactionPaymentMember.AddUpdateDeletePurchaseTransactionPayments(objSave, lstPurchasePaymentDetail);
                        lstPurchasePaymentDetail = lstPurchasePaymentDetailtmp;
                        dgvPaymentDetail.AutoGenerateColumns = false;
                        dgvPaymentDetail.DataSource = lstPurchasePaymentDetail;
                        /*          Calculate the Paid and Pending Amount ***************/
                        txtPaidAmount.Text = CalculatePendingAmount(mode.ToUpper()).ToString();
                        Decimal grossAmount = 0;
                        Decimal.TryParse(txtGTotal.Text, out grossAmount);
                        Decimal paidAmount = 0;
                        Decimal.TryParse(txtPaidAmount.Text, out paidAmount);
                        txtPendingAmount.Text = (grossAmount - paidAmount).ToString();
                        /*          Calculate the Paid and Pending Amount ***************/
                        ResetPurchasePayment();
                    }
                }
                else
                {

                    String msg = PurchasePaymentValidation();
                    if (msg.Length > 0)
                    {
                        MessageBox.Show(msg, "Purchase Payment Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        objSave.Index = Convert.ToInt32(txtPaymentIndex.Text);
                        objSave.PurchaseTransactionPayKey = Convert.ToInt32(txtPurchaseTransactionPayKey.Text);
                        objSave.PurchaseTransactionPayType = cmbPaymentMode.Text;
                        if (cmbPaymentMode.Text.Equals("Cash"))
                        {
                            //string paymentDate = dtpPaymentDate.Value.ToString("dd/MM/yyyy");
                            objSave.PurchaseTransactionPayDate = dtpPaymentDate.Value.ToString("dd/MM/yyyy");
                            objSave.PurchaseTransactionPayAmount = txtPayAmount.Text.Length > 0 ? Convert.ToDecimal(txtPayAmount.Text) : 0;
                            objSave.PurchaseActualTransactionPayDate = clsCommoan.GetDateInddMMYYYY(dtpPaymentDate.Value.ToString());
                        }
                        else
                        {
                           // string paymentDate = dtpPaymentDate.Value.ToString("dd/MM/yyyy");
                            objSave.PurchaseTransactionPayDate = dtpPaymentDate.Value.ToString("dd/MM/yyyy");
                            objSave.PurchaseActualTransactionPayDate = clsCommoan.GetDateInddMMYYYY(dtpPaymentDate.Value.ToString());
                            objSave.PurchaseActualTransactionCheckDate = clsCommoan.GetDateInddMMYYYY(dtpChequeDate.Value.ToString());
                            objSave.PurchaseTransactionPayAmount = txtPayAmount.Text.Length > 0 ? Convert.ToDecimal(txtPayAmount.Text) : 0;
                            objSave.PurchaseTransactionPayBankFKey = Convert.ToInt32(cmbBank.SelectedValue);
                            objSave.PurchaseTransactionPayBankFKeyName = cmbBank.Text;
                            //string chequeDate = dtpChequeDate.Value.ToString("dd/MM/yyyy");
                            objSave.PurchaseTransactionPayChequeDate = dtpChequeDate.Value.ToString("dd/MM/yyyy");
                            objSave.PurchaseTransactionPayBankChequeNo = txtChequeNo.Text;
                        }
                        var lstPurchasePaymentDetailtmp = clsPurchaseTransactionPaymentMember.AddUpdateDeletePurchaseTransactionPayments(objSave, lstPurchasePaymentDetail);
                        lstPurchasePaymentDetail = lstPurchasePaymentDetailtmp;
                        dgvPaymentDetail.AutoGenerateColumns = false;
                        dgvPaymentDetail.DataSource = lstPurchasePaymentDetail;
                        txtPaidAmount.Text = CalculatePendingAmount(mode.ToUpper()).ToString();
                        Decimal grossAmount = 0;
                        Decimal.TryParse(txtGTotal.Text, out grossAmount);
                        Decimal paidAmount = 0;
                        Decimal.TryParse(txtPaidAmount.Text, out paidAmount);
                        txtPendingAmount.Text = (grossAmount - paidAmount).ToString();
                        ResetPurchasePayment();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "SavePurchasePayment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ResetPurchasePayment()
        {
            cmbPaymentMode.Text = "Cash";
            dtpPaymentDate.Value = DateTime.Now;
            txtPayAmount.Text = String.Empty;
            cmbBank.Text = "Please Select Bank";
            dtpChalanDt.Value = DateTime.Now;
            txtChequeNo.Text = String.Empty;
            txtPaymentIndex.Text = "0";
            btnAddPayment.Text = "Add";
            btnDeletePayment.Visible = false;
            txtPurchaseTransactionPayKey.Text = "0";
        }

        public Decimal CalculatePendingAmount(string mode)
        {
            try
            {
                Decimal PendingAmount = 0;
                foreach (DataGridViewRow row in dgvPaymentDetail.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        if (row.Cells[11].Value.ToString() == "DELETE")
                        {
                            dgvPaymentDetail.CurrentCell = null;
                            row.Visible = false;
                        }
                        else
                        {
                            PendingAmount += Convert.ToDecimal(row.Cells[4].Value.ToString());
                        }
                    }
                }
                return PendingAmount;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "CalculatePendingAmount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        #endregion

        #region PaymentGridviewEvent
        private void dgvPaymentDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex.Equals(0))
                {
                    if (dgvPaymentDetail.Rows[e.RowIndex].Cells[2].Value.ToString().Equals("Cash"))
                    {
                        txtPurchaseTransactionPayKey.Text = dgvPaymentDetail.Rows[e.RowIndex].Cells[9].Value.ToString();
                        txtPaymentIndex.Text              = dgvPaymentDetail.Rows[e.RowIndex].Cells[1].Value.ToString();
                        cmbPaymentMode.Text               = dgvPaymentDetail.Rows[e.RowIndex].Cells[2].Value.ToString();
                        dtpPaymentDate.Value              = Convert.ToDateTime(dgvPaymentDetail.Rows[e.RowIndex].Cells[12].Value);
                        txtPayAmount.Text                 = dgvPaymentDetail.Rows[e.RowIndex].Cells[4].Value.ToString();
                        btnAddPayment.Text                = "Update";
                        btnDeletePayment.Visible          = true;
                    }
                    else
                    {
                        txtPurchaseTransactionPayKey.Text = dgvPaymentDetail.Rows[e.RowIndex].Cells[9].Value.ToString();
                        txtPaymentIndex.Text = dgvPaymentDetail.Rows[e.RowIndex].Cells[1].Value.ToString();
                        cmbPaymentMode.Text = dgvPaymentDetail.Rows[e.RowIndex].Cells[2].Value.ToString();
                        dtpPaymentDate.Value = Convert.ToDateTime(dgvPaymentDetail.Rows[e.RowIndex].Cells[12].Value);
                        txtPayAmount.Text = dgvPaymentDetail.Rows[e.RowIndex].Cells[4].Value.ToString();
                        cmbBank.SelectedValue = dgvPaymentDetail.Rows[e.RowIndex].Cells[5].Value.ToString();
                        dtpChequeDate.Value = Convert.ToDateTime(dgvPaymentDetail.Rows[e.RowIndex].Cells[13].Value);
                        txtChequeNo.Text = dgvPaymentDetail.Rows[e.RowIndex].Cells[8].Value.ToString();
                        btnAddPayment.Text = "Update";
                        btnDeletePayment.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "dgvPaymentDetail_CellContentClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region PaymentKeyUpEvent
        private void txtPayAmount_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode.ToString() != "Tab" && e.KeyCode.ToString() != "ShiftKey" && e.KeyCode.ToString() != "Return" && e.KeyCode.ToString() != "Back")
                {
                    String msg = String.Empty;
                    Decimal validAmount = 0;
                    Decimal.TryParse(txtPayAmount.Text, out validAmount);
                    if (validAmount.Equals(0) && txtPayAmount.Text.Length > 0)
                    {
                        txtPayAmount.Text = String.Empty;
                        MessageBox.Show("Please Enter the Valid Amount", "Purchase Pay Amount Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "txtPayAmount_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void txtInvoiceNo_KeyUp(object sender, KeyEventArgs e)
        {

        }
        #endregion

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmPurchaseItemMaster objShowItemForm = new frmPurchaseItemMaster("Yes", rollFKey,cId);
                objShowItemForm.Show();
            }
            catch (Exception ex)
            {
             MessageBox.Show(ex.Message.ToString(), "btnAddNewItem_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void txtCgstPer_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                String msg = TotalValidation();
                if (msg.Length > 0)
                {
                    MessageBox.Show(msg, "Purchase Total Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ItemCalcution();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "txtDiscPer_KeyUp_1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSGSTPer_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                String msg = TotalValidation();
                if (msg.Length > 0)
                {
                    MessageBox.Show(msg, "Purchase Total Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ItemCalcution();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "txtSGSTPer_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtIgstPer_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                String msg = TotalValidation();
                if (msg.Length > 0)
                {
                    MessageBox.Show(msg, "Sales Total Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ItemCalcution();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "txtIgstPer_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadItem()
        {
            try
            {
                clsItemMaster objItemGroupItem = new clsItemMaster();
                objItemGroupItem.Mode = "SELECTALL";
                objItemGroupItem.CompanyID = cId;
                var ds = objItemGroupItem.GetSearchItems();
                DataTable dtItems = ds.Tables[0];
                DataRow drItems = dtItems.NewRow();
                drItems["ItemMasterKey"] = "0";
                drItems["ItemMasterName"] = "Please Select Item";
                dtItems.Rows.InsertAt(drItems, 0);
                cmbItem.DataSource = dtItems;
                cmbItem.DisplayMember      = "ItemMasterName";
                cmbItem.ValueMember = "ItemMasterKey";
                cmbItem.Text = "Please Select Item";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "LoadItem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public int AddNewItemRunTime()
        {
            try
            {
                clsItemMaster objSave = new clsItemMaster();
                objSave.ItemMasterKey = Convert.ToInt32(txtKey.Text);
                objSave.ItemMasterName = cmbItem.Text;
                objSave.CompanyID = cId;
                //var a   =                       Convert.ToDecimal(txtItemRate.Text)
                objSave.Mode = "ADD";
                int result = objSave.AddUpdateDelete();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "AddNewItemRunTime", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private void txtRoundoff_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                CalculateMainTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "txtRoundoff_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbRounoffOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CalculateMainTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "cmbRounoffOption_SelectedIndexChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                frmSupplier objShowItemForm = new frmSupplier(rollFKey,cId,"NO");
                objShowItemForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "btnAddSupplier_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void BindNewRecordComboCombo(string action)
        {
            try
            {
                if (action.Equals("Supplier"))
                {
                    /*****************      Bind the Supplier Combo*******************/
                    cmbSupplier.DataSource                  = null;
                    cmbSupplier.Items.Clear();
                    clsSupplierMaster objLoad               = new clsSupplierMaster();
                    objLoad.Mode                            = "SELECTALL";
                    objLoad.CompanyID                       = cId;
                    var dsSupplier = objLoad.GetAllSupplier();
                    //clsComboBoxItem objComboItem = new clsComboBoxItem();
                    //objComboItem.Text = "Please Select Supplier";
                    //objComboItem.Value = "0";
                    //cmbSupplier.Items.Add(objComboItem);
                    DataTable dtSupplier = dsSupplier.Tables[0];
                    DataRow dr = dtSupplier.NewRow();
                    dr["SupplierID"] = "0";
                    dr["SupplierName"] = "Please Select the Supplier";
                    dtSupplier.Rows.InsertAt(dr, 0);
                    cmbSupplier.DataSource = dtSupplier;
                    cmbSupplier.DisplayMember = "SupplierName";
                    cmbSupplier.ValueMember = "SupplierID";
                    cmbSupplier.Text = "Please Select the Supplier";
                    /*****************      Bind the Supplier Combo*******************/
                }
                else if (action.Equals("Bank"))
                {
                    cmbBank.DataSource = null;
                    cmbBank.Items.Clear();
                    clsCategoryMaster objLoadBank = new clsCategoryMaster();
                    objLoadBank.Mode = "SELECTALL";
                    objLoadBank.CompanyID   = cId;
                    objLoadBank.CategoryMasterCatName = "BankName";
                    var dsBank = objLoadBank.GetAllCategory();
                    DataTable dtBankName = dsBank.Tables[0];
                    DataRow drBankName = dtBankName.NewRow();
                    drBankName["CategoryMasterCatKey"] = "0";
                    drBankName["CategoryMasterCatVal"] = "Please Select Bank";
                    dtBankName.Rows.InsertAt(drBankName, 0);
                    //DataRow dr                = dt.NewRow();
                    /*          Bind the Bank Combo     */
                    cmbBank.DataSource = dtBankName;
                    cmbBank.DisplayMember = "CategoryMasterCatVal";
                    cmbBank.ValueMember = "CategoryMasterCatKey";
                    cmbBank.Text = "Please Select Bank";
                    /*          Bind the Bank Combo     */
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "BindCustomerCombo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                BindNewRecordComboCombo("Supplier");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "btnLoadCustomer_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddBank_Click(object sender, EventArgs e)
        {
            try
            {
                frmCategoryMaster objShowItemForm = new frmCategoryMaster(rollFKey,cId,"Yes");
                objShowItemForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "btnAddBank_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadBank_Click(object sender, EventArgs e)
        {
            try
            {
                BindNewRecordComboCombo("Bank");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "btnLoadBank_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCartage_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txtCartage_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                CalculateMainTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "txtCartage_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDiscountPer_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                String msg = TotalValidation();
                if (msg.Length > 0)
                {
                    MessageBox.Show(msg, "Sales Total Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ItemCalcution();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "txtDiscountPer_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }	
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
      }
}
    



     
     
     
     
     
     
     








