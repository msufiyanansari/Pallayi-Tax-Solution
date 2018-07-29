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
    public partial class frmSalesMaster : Form
    {
        int PrimaryKey = 0;
        int rollFKey;
        int cId;
        public frmSalesMaster(int Key, int rollKey, int companyId)
        {
            InitializeComponent();
            PrimaryKey      = Key;
            rollFKey        = rollKey;
            cId             = companyId;
        }

        List<clsSalesTransactionMember> lstSalesTransactionDetail = new List<clsSalesTransactionMember>();
        List<clsSalesTransactionPaymentMember> lstSalesPaymentDetail = new List<clsSalesTransactionPaymentMember>();
        
        #region AddUpdateDeleteSalesMaster
        #region FormFunction
        public void BindCustomerItemComboBox()
        {
            try
            {
                /*****************      Bind the Customer Combo*******************/
                clsCustomerMaster objLoad = new clsCustomerMaster();
                objLoad.Mode = "SELECTALL";
                objLoad.CompanyID = cId;
                var dsCustomer = objLoad.GetAllCustomer();
                //clsComboBoxItem objComboItem = new clsComboBoxItem();
                //objComboItem.Text = "Please Select Customer";
                //objComboItem.Value = "0";
                //cmbCustomer.Items.Add(objComboItem);
                DataTable dtCustomer = dsCustomer.Tables[0];
                DataRow dr = dtCustomer.NewRow();
                dr["CustomerID"] = "0";
                dr["CustomerName"] = "Please Select the Customer";
                dtCustomer.Rows.InsertAt(dr, 0);
                cmbCustomer.DataSource = dtCustomer;
                cmbCustomer.DisplayMember = "CustomerName";
                cmbCustomer.ValueMember = "CustomerID";
                cmbCustomer.Text = "Please Select the Customer";
                /*****************      Bind the Customer Combo*******************/



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

                clsCategoryMaster objLoadBank = new clsCategoryMaster();
                objLoadBank.Mode                    = "SELECTALL";
                objLoadBank.CompanyID               = cId;
                objLoadBank.CategoryMasterCatName   = "BankName";
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
                MessageBox.Show(ex.Message.ToString(), "BindCustomerItemComboBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region FormLoadEvent
        private void frmSalesMaster_Load(object sender, EventArgs e)
        {
            try
            {
                LoadItem();
                BindCustomerItemComboBox();
                SetBillBookNoInvoiceNo();
                ResetSalesMaster();
                LoadFormData(PrimaryKey);
                if (PrimaryKey.Equals(0))
                {
                    cmbSalesType.Text     = "Tax Invoice";
                    cmbReverseCharge.Text = "No";
                    cmbRounoffOption.Text = "Minus";   
                }
                cmbPaymentMode.Text       = "Select Mode";
                this.ActiveControl = cmbSalesType;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "frmSalesMaster_Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region SelectedInexChanged
        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCustomer.SelectedIndex != 0 )
                {
                    clsCustomerMaster objCutomer = new clsCustomerMaster();
                    objCutomer.Mode = "CustomerDetail";
                    objCutomer.CustomerID = Convert.ToInt32(cmbCustomer.SelectedValue);
                    var lstCustomer = objCutomer.GetCustomerDetail().FirstOrDefault();
                    lblCustomerDetail.Text = lstCustomer == null ? String.Empty : lstCustomer.CustomerDetai;
                }
                else
                {
                    lblCustomerDetail.Text = "Select the Customer Show the Customer Detail";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "cmbCustomer_SelectedIndexChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region SetBillBookNoMethod
        public void SetBillBookNoInvoiceNo()
        {
            try
            {
                clsSalesMaster objLoadBillBookNo = new clsSalesMaster();
                objLoadBillBookNo.CompanyID      = cId;
                var ds = objLoadBillBookNo.GetBillBookNoInvoiceNo();
                txtBillNo.Text = ds.Tables[0].Rows[0]["SalesMasterBillBookNo"].ToString();
                txtInvoiceNo.Text = ds.Tables[0].Rows[0]["SalesMasterInvoiceNo"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "SetBillBookNoInvoiceNo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region SalesMasterMethod
        public String SalesMasterValidation()
        {
            try
            {
                String msg = String.Empty;
                if (cmbSalesType.Text.Equals("Select Type"))
                {
                    msg = "Please Select Sales Type";
                }
                if (cmbCustomer.Text.Equals("Please Select the Customer"))
                {
                    if (msg.Length.Equals(0))
                    {
                        msg = "Please Select the Customer";
                    }
                    else
                    {
                        msg = msg + "\n Please Select the Customer";
                    }
                }
                int isAvaibleinListItem = cmbCustomer.FindStringExact(cmbCustomer.Text);
                if (isAvaibleinListItem.Equals(-1))
                {
                    if (msg.Length.Equals(0))
                    {
                        msg = "Please Select the Customer From List";
                    }
                    else
                    {
                        msg = msg + "\n Please Select the Customer From List";
                    }
                }
                int validInvoiceNo;
                int.TryParse(txtInvoiceNo.Text, out validInvoiceNo);
                if (validInvoiceNo.Equals(0))
                {
                    if (msg.Length.Equals(0))
                    {
                        msg = "Please Enter the Invoice No";
                    }
                    else
                    {
                        msg = msg + "\n Please Enter the Invoice No";
                    }
                }
                return msg;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "SalesMasterValidation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return String.Empty;
            }
        }
        public void ResetSalesMaster()
        {
            txtKey.Text = "0";
            txtChlnNo.Text = String.Empty;
            dtpChalanDt.Value = DateTime.Now;
            lblCustomerDetail.Text = "Select the Customer Show the Customer Detail:";
            txtMainTotal.Text = String.Empty;
            txtVatAmt.Text = String.Empty;
            txtAddTaxAmount.Text = String.Empty;
            txtIgstAmt.Text     = String.Empty;
            txtGTotal.Text = String.Empty;
            txtPaidAmount.Text = String.Empty;
            txtPendingAmount.Text = String.Empty;
            btnDeleteSales.Visible = false;
            btnAddSales.Text = "Add";
            dgvSalesView.DataSource = null;
            ResetSalesTransaction();
            cmbCustomer.Text = "Please Select the Customer";
            cmbItemGroup.Text = "Please Select Item Group";
            cmbSalesType.Text = "Tax Invoice";
            cmbRounoffOption.Text   = "Minus";
            lstSalesTransactionDetail.Clear();
            dgvPaymentDetail.DataSource = null;
            ResetSalesPayment();
            lstSalesPaymentDetail.Clear();
            txtGTotal.Text = String.Empty;
            txtPendingAmount.Text = String.Empty;
            txtPaidAmount.Text = String.Empty;
            txtTransportDetail.Text = String.Empty;
            txtVehicleNo.Text   = String.Empty;
            cmbReverseCharge.SelectedIndex = -1;
            txtRoundoff.Text    = String.Empty;
            txtCartage.Text     = String.Empty;
            txtDelieveryNote.Text = String.Empty;
            txtSupplierRefNo.Text = String.Empty;
            txtSupplierotherRefNo.Text = String.Empty;
            txtDocumentNo.Text = String.Empty;
            txtDispatchthrough.Text = String.Empty;
            txtDestination.Text = String.Empty;
            txtLading.Text = String.Empty;
            cmbSalesType.Focus();
        }
        public void LoadFormData(int Key = 0)
        {
            try
            {
                if (Key != 0)
                {
                    clsSalesMaster objLoad  = new clsSalesMaster();
                    objLoad.Mode            = "SELECTONE";
                    objLoad.CompanyID       = cId;
                    objLoad.SalesMasterKey  = Key;
                    var lstSalesMaster = objLoad.GetSalesMaster().FirstOrDefault();
                    txtKey.Text = lstSalesMaster.SalesMasterKey.ToString();
                    dtpDate.Value = Convert.ToDateTime(lstSalesMaster.SalesMasterActualDate);
                    cmbSalesType.Text = lstSalesMaster.SalesMasterType;
                    cmbCustomer.SelectedValue = lstSalesMaster.SalesMasterCustomerFKey.ToString();
                    lblCustomerDetail.Text = lstSalesMaster.SalesMasterCustomerDetail;
                    txtBillNo.Text = lstSalesMaster.SalesMasterBillBookNo;
                    txtInvoiceNo.Text = lstSalesMaster.SalesMasterInvoiceNo;
                    txtChlnNo.Text = lstSalesMaster.SalesMasterChlnNo;
                    cmbReverseCharge.Text = lstSalesMaster.SalesMasterReverseCharge;
                    txtVehicleNo.Text          = lstSalesMaster.SalesMasterVehicleNo;
                    if (lstSalesMaster.SalesMasterChlnDate != "01/01/1900")
                    {
                        dtpChalanDt.Value = Convert.ToDateTime(lstSalesMaster.SalesMasterChlnDate);
                    }
                    txtMainTotal.Text = lstSalesMaster.SalesMasterMainTotal.ToString();
                    txtVatAmt.Text = lstSalesMaster.SalesMasterVatAmount.ToString();
                    txtAddTaxAmount.Text = lstSalesMaster.SalesMasterAddTaxAmt.ToString();
                    txtIgstAmt.Text      = lstSalesMaster.SalesMasterISGTAmount.ToString();
                    txtGTotal.Text = lstSalesMaster.SalesMasterGrossTotal.ToString();
                    txtPaidAmount.Text = lstSalesMaster.SalesMasterPaidAmount.ToString();
                    txtPendingAmount.Text = lstSalesMaster.SalesMasterPendingAmount.ToString();
                    cmbRounoffOption.Text   = lstSalesMaster.SalesMasterRoundoffOption;
                    txtCartage.Text         = lstSalesMaster.SalesMasterCartage.ToString();
                    lstSalesTransactionDetail = lstSalesMaster.lstSalesTransaction;
                    dgvSalesView.AutoGenerateColumns = false;
                    txtDelieveryNote.Text  = lstSalesMaster.SalesMasterDelieveryNote;
                    txtSupplierRefNo.Text   = lstSalesMaster.SalesMasterSupplierRefNo;
                    txtSupplierotherRefNo.Text = lstSalesMaster.SalesMasterOtherRefNo;
                    txtDocumentNo.Text          = lstSalesMaster.SalesMasterDispatchDocumentNo;
                    txtDispatchthrough.Text     = lstSalesMaster.SalesMasterDispatchthrought;
                    txtDestination.Text         = lstSalesMaster.SalesMasterDestination;
                    txtLading.Text              = lstSalesMaster.SalesMasterBillingofLading;
                    dgvSalesView.DataSource = lstSalesTransactionDetail;
                    lstSalesPaymentDetail   =   lstSalesMaster.lstSalesPayment;
                    dgvPaymentDetail.AutoGenerateColumns = false;
                    dgvPaymentDetail.DataSource = lstSalesPaymentDetail;
                    btnAddSales.Text = "Update";
                    btnDeleteSales.Visible = true;
                    txtTransportDetail.Text = lstSalesMaster.TranMasterTransportDetail;
                    txtRoundoff.Text        = lstSalesMaster.SalesMasterRoundoff.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "LoadFormData", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SaveSalesMaster(string mode)
        {
            try
            {
                clsSalesMaster objSave = new clsSalesMaster();
                objSave.Mode = mode.ToUpper();
                objSave.CompanyID = cId;
                objSave.SalesMasterDate = clsCommoan.GetDateInddMMYYYY(dtpDate.Value.ToString());
                objSave.SalesMasterCustomerFKey = Convert.ToInt32(cmbCustomer.SelectedValue);
                objSave.SalesMasterBillBookNo = txtBillNo.Text;
                objSave.SalesMasterInvoiceNo = txtInvoiceNo.Text;
                objSave.SalesMasterChlnNo = txtChlnNo.Text;
                objSave.SalesMasterType = cmbSalesType.Text;
                objSave.SalesMasterReverseCharge    = cmbReverseCharge.Text;
                objSave.SalesMasterVehicleNo        = txtVehicleNo.Text;
                objSave.SalesMasterChlnDate = clsCommoan.GetDateInddMMYYYY(dtpChalanDt.Value.ToString());
                objSave.SalesMasterKey = Convert.ToInt32(txtKey.Text);
                objSave.SalesTransactionXML = clsSalesTransactionMember.GetSalesTransactionXML(lstSalesTransactionDetail);
                objSave.SalesMasterCustomerDetail = lblCustomerDetail.Text;
                objSave.SalesMasterMainTotal = txtMainTotal.Text.Length > 0 ? Convert.ToDecimal(txtMainTotal.Text) : 0;
                objSave.SalesMasterVatAmount = txtVatAmt.Text.Length > 0 ? Convert.ToDecimal(txtVatAmt.Text) : 0;
                objSave.SalesMasterAddTaxAmt = txtAddTaxAmount.Text.Length > 0 ? Convert.ToDecimal(txtAddTaxAmount.Text) : 0;
                objSave.SalesMasterISGTAmount = txtIgstAmt.Text.Length > 0 ? Convert.ToDecimal(txtIgstAmt.Text) : 0;  
                objSave.SalesMasterPaidAmount = txtPaidAmount.Text.Length > 0 ? Convert.ToDecimal(txtPaidAmount.Text) : 0;
                objSave.SalesMasterPendingAmount    = txtPendingAmount.Text.Length>0?Convert.ToDecimal(txtPendingAmount.Text):0;
                objSave.SalesMasterPaymentXML = clsSalesTransactionPaymentMember.GetSalesPaymentXML(lstSalesPaymentDetail);
                objSave.TranMasterTransportDetail   = txtTransportDetail.Text;
                objSave.SalesMasterGrossTotal = txtGTotal.Text.Length > 0 ? Convert.ToDecimal(txtGTotal.Text) : 0;
                objSave.SalesMasterRoundoff   = txtRoundoff.Text.Length > 0 ? Convert.ToDecimal(txtRoundoff.Text) : 0;
                objSave.SalesMasterRoundoffOption = cmbRounoffOption.Text;
                objSave.SalesMasterCartage        = txtCartage.Text.Length > 0 ? Convert.ToDecimal(txtCartage.Text) : 0;
                objSave.SalesMasterDelieveryNote = txtDelieveryNote.Text;
                objSave.SalesMasterSupplierRefNo = txtSupplierRefNo.Text;
                objSave.SalesMasterOtherRefNo = txtSupplierotherRefNo.Text;
                objSave.SalesMasterDispatchDocumentNo = txtDocumentNo.Text;
                objSave.SalesMasterDispatchthrought = txtDispatchthrough.Text;
                objSave.SalesMasterDestination = txtDestination.Text;
                objSave.SalesMasterBillingofLading = txtLading.Text;
                if (mode.ToUpper().Equals("DELETE"))
                {
                    var confirmation = MessageBox.Show("Are You Sure You Want to Delete " + " " + cmbCustomer.Text, "Sales Master Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (confirmation.ToString().Equals("Yes"))
                    {
                        objSave.AddUpdateDelete();
                        MessageBox.Show("Bill Book No : " + txtBillNo.Text + " Invoice No : " + txtInvoiceNo.Text + " " + mode + " SuccessFully", "Sales Master Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetSalesMaster();
                        SetBillBookNoInvoiceNo();
                    }
                }
                else
                {
                    string msg = SalesMasterValidation();
                    if (msg.Length > 0)
                    {
                        MessageBox.Show(msg, "Sales Master Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        int key                               = objSave.AddUpdateDelete();
                        frmReportSelection objReportSelection = new frmReportSelection(key, String.Empty, 1, rollFKey,cId);
                        objReportSelection.MdiParent          = this.MdiParent;
                        this.Close();
                        objReportSelection.Show();
                        objReportSelection.WindowState        = FormWindowState.Minimized;
                        objReportSelection.WindowState        = FormWindowState.Maximized;
                        //MessageBox.Show("Bill Book No : " + txtBillNo.Text + " Invoice No : " + txtInvoiceNo.Text + " " + mode + " SuccessFully", "Sales Master Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetSalesMaster();
                        SetBillBookNoInvoiceNo();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "SaveSalesMaster", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region ButtonMaster
        private void btnAddSales_Click(object sender, EventArgs e)
        {
            try
            {
                SaveSalesMaster(btnAddSales.Text.ToUpper());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "btnAddSales_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeleteSales_Click(object sender, EventArgs e)
        {
            try
            {
                SaveSalesMaster(btnDeleteSales.Text.ToUpper());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "btnDeleteSales_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion 
        #endregion

        #region AddUpdateDeleteSalesTransaction

        #region SalesTransactionSelectedIndex

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
                        objItem.CompanyID = cId;
                        var lstItemDetail = objItem.GetItemMaster().FirstOrDefault();
                        if (lstItemDetail != null)
                        {
                            txtPreviousRate.Text = lstItemDetail.ItemMasterRate.ToString();
                            txtItemStock.Text = lstItemDetail.ItemMasterStock.ToString();
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
                        clsItemMaster objItemGroupItem = new clsItemMaster();
                        objItemGroupItem.ItemMasterGroupFKey = Convert.ToInt32(cmbItemGroup.SelectedValue);
                        objItemGroupItem.Mode = "SELECTALL";
                        var ds = objItemGroupItem.GetItemGroupItems();
                        DataTable dtItems = ds.Tables[0];
                        DataRow drItems = dtItems.NewRow();
                        drItems["ItemMasterKey"] = "0";
                        drItems["ItemMasterName"] = "Please Select Item";
                        dtItems.Rows.InsertAt(drItems, 0);
                        cmbItem.DataSource = dtItems;
                        cmbItem.DisplayMember = "ItemMasterName";
                        cmbItem.ValueMember = "ItemMasterKey";
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
        private void txtQty_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                String msg = String.Empty; //TotalValidation();
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

        private void txtRate_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                String msg = String.Empty; //TotalValidation();
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

        #region SalesTransactionEvents
        #region SalesTransactionMethod
        public void SaveSalesTransaction(String mode)
        {
            try
            {
                clsSalesTransactionMember objSave = new clsSalesTransactionMember();
                objSave.Mode = mode.ToUpper();
                if (mode.ToUpper().Equals("DELETE"))
                {
                    var confirmation = MessageBox.Show("Are You Sure You Want to Delete " + " " + cmbItem.Text, "Sales Item Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (confirmation.ToString().Equals("Yes"))
                    {
                        objSave.Index                               = Convert.ToInt32(txtIndex.Text);
                        objSave.SalesTransactionKey                 = Convert.ToInt32(txtSalesTransactionKey.Text);
                        objSave.SalesTransactionQty                 = txtQty.Text.Length > 0 ? Convert.ToDecimal(txtQty.Text) : 0;
                        objSave.SalesTransactionRate                = txtRate.Text.Length > 0 ? Convert.ToDecimal(txtRate.Text) : 0;
                        objSave.SalesTransactionHsnCode             = txtHsnCode.Text;
                        objSave.SalesTransactionTaxableAmt          = txtTaxableValue.Text.Length > 0 ? Convert.ToDecimal(txtTaxableValue.Text) : 0;
                        objSave.SalesTransactionCGSTPer             = txtCgstPer.Text.Length > 0 ? Convert.ToDecimal(txtCgstPer.Text) : 0;
                        objSave.SalesTransactionCGSTAmt             = txtCGSTAmt.Text.Length > 0 ? Convert.ToDecimal(txtCGSTAmt.Text) : 0;
                        objSave.SalesTransactionSGSTPer             = txtSGSTPer.Text.Length > 0 ? Convert.ToDecimal(txtSGSTPer.Text) : 0;
                        objSave.SalesTransactionSGSTAmt             = txtSgstAmt.Text.Length > 0 ? Convert.ToDecimal(txtSgstAmt.Text) : 0;
                        objSave.SalesTransactionIGSTPer             = txtIgstPer.Text.Length > 0 ? Convert.ToDecimal(txtIgstPer.Text) : 0;
                        objSave.SalesTransactionIGSTAmt             = txtGstAmt.Text.Length > 0 ? Convert.ToDecimal(txtGstAmt.Text) : 0;
                        objSave.SalesTransactionTotal               = txtTotal.Text.Length > 0 ? Convert.ToDecimal(txtTotal.Text) : 0;
                        objSave.SalesTransactionPoNo                = txtPoNo.Text;
                        var lstSalesTransactiontmp                  = clsSalesTransactionMember.AddUpdateDeleteSalesTransaction(objSave, lstSalesTransactionDetail);
                        lstSalesTransactionDetail                   = lstSalesTransactiontmp;
                        dgvSalesView.AutoGenerateColumns            = false;
                        dgvSalesView.DataSource                     = lstSalesTransactionDetail;
                        CalculateMainTotal();
                        ResetSalesTransaction();
                    }
                }
                else
                {

                    String msg = SalesTransactionValidation();
                    Decimal validStock = 0;
                    Decimal.TryParse(txtItemStock.Text, out validStock);
                    if (msg.Length > 0)
                    {
                        MessageBox.Show(msg, "Sales Item Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //else if (validStock <= 0)
                    //{
                    //    MessageBox.Show("You Can Not Sales This Item Becoze Stock is Not Available", "Sales Item Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                    else
                    {
                        objSave.SalesTransactionItemGroupFKey               = Convert.ToInt32(cmbItemGroup.SelectedValue);
                        objSave.SalesTransactionItemGroupFKeyName           = cmbItemGroup.Text;
                        int isAvaibleinListItem = cmbItem.FindStringExact(cmbItem.Text);
                        if ((cmbItem.Text != "Please Select Item" && cmbItem.Text != "" && isAvaibleinListItem == -1))
                        {
                            objSave.SalesTransactionItemFKey = AddNewItemRunTime();
                        }
                        else
                        {
                            if (isAvaibleinListItem != -1)
                            {
                                cmbItem.Text = cmbItem.Text;
                                objSave.SalesTransactionItemFKey = Convert.ToInt32(cmbItem.SelectedValue);
                            }
                            else
                            {
                                objSave.SalesTransactionItemFKey = Convert.ToInt32(cmbItem.SelectedValue);
                            }
                        }
                        objSave.SalesTransactionItemFKeyName    = cmbItem.Text;
                        objSave.Index = Convert.ToInt32(txtIndex.Text);
                        objSave.SalesTransactionKey = Convert.ToInt32(txtSalesTransactionKey.Text);
                        objSave.SalesTransactionQty = Convert.ToDecimal(txtQty.Text);
                        objSave.SalesTransactionRate = Convert.ToDecimal(txtRate.Text);
                        objSave.SalesTransactionTaxableAmt = txtTaxableValue.Text.Length > 0 ? Convert.ToDecimal(txtTaxableValue.Text) : 0;
                        objSave.SalesTransactionCGSTPer = txtCgstPer.Text.Length > 0 ? Convert.ToDecimal(txtCgstPer.Text) : 0;
                        objSave.SalesTransactionCGSTAmt = txtCGSTAmt.Text.Length > 0 ? Convert.ToDecimal(txtCGSTAmt.Text) : 0;
                        objSave.SalesTransactionSGSTPer = txtSGSTPer.Text.Length > 0 ? Convert.ToDecimal(txtSGSTPer.Text) : 0;
                        objSave.SalesTransactionSGSTAmt = txtSgstAmt.Text.Length > 0 ? Convert.ToDecimal(txtSgstAmt.Text) : 0;
                        objSave.SalesTransactionIGSTPer = txtIgstPer.Text.Length > 0 ? Convert.ToDecimal(txtIgstPer.Text) : 0;
                        objSave.SalesTransactionIGSTAmt = txtGstAmt.Text.Length > 0 ? Convert.ToDecimal(txtGstAmt.Text) : 0;
                        objSave.SalesTransactionTotal   = txtTotal.Text.Length > 0 ? Convert.ToDecimal(txtTotal.Text) : 0;
                        objSave.SalesTransactionPoNo      = txtPoNo.Text;
                        objSave.SalesTransactionHsnCode = txtHsnCode.Text;
               
                        var lstSalesTransactiontmp = clsSalesTransactionMember.AddUpdateDeleteSalesTransaction(objSave, lstSalesTransactionDetail);
                        lstSalesTransactionDetail  = lstSalesTransactiontmp;
                        dgvSalesView.AutoGenerateColumns = false;
                        dgvSalesView.DataSource = lstSalesTransactionDetail;
                        CalculateMainTotal();
                        ResetSalesTransaction();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "SaveSalesTransaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ResetSalesTransaction()
        {
            
            txtPreviousRate.Text = String.Empty;
            txtQty.Text = String.Empty;
            txtRate.Text = String.Empty;
            txtTotal.Text = String.Empty;
            txtSalesTransactionKey.Text = "0";
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
            txtGstAmt.Text  = String.Empty;
            txtTaxableValue.Text    = String.Empty;
            txtHsnCode.Text     = String.Empty;
            cmbItem.Focus();
        }
        public String SalesTransactionValidation()
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
                MessageBox.Show(ex.Message.ToString(), "SalesTransactionValidation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return String.Empty;
            }
        } 
        #endregion
        #region ButtonSalesTransactionEvent
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveSalesTransaction(btnAddItem.Text.ToUpper());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "btnAddItem_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveSalesTransaction(btnDeleteItem.Text.ToUpper());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "btnDeleteItem_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region SalesTransactionGridViewEvent
        private void dgvSalesView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.ColumnIndex.Equals(0))
                {
                    txtSalesTransactionKey.Text = dgvSalesView.Rows[e.RowIndex].Cells[15].Value.ToString();
                    txtIndex.Text               = dgvSalesView.Rows[e.RowIndex].Cells[17].Value.ToString();
                    cmbItemGroup.SelectedValue  = dgvSalesView.Rows[e.RowIndex].Cells[19].Value.ToString();
                    cmbItem.SelectedValue       = dgvSalesView.Rows[e.RowIndex].Cells[14].Value.ToString();
                    txtTaxableValue.Text        = dgvSalesView.Rows[e.RowIndex].Cells[6].Value.ToString();
                    cmbItem.Text                = dgvSalesView.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtQty.Text                 = dgvSalesView.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtRate.Text                = dgvSalesView.Rows[e.RowIndex].Cells[5].Value.ToString();
                    txtTotal.Text               = dgvSalesView.Rows[e.RowIndex].Cells[13].Value.ToString();
                    txtPoNo.Text                = dgvSalesView.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtHsnCode.Text             = dgvSalesView.Rows[e.RowIndex].Cells[20].Value.ToString();
                    txtCgstPer.Text             = Convert.ToDecimal(dgvSalesView.Rows[e.RowIndex].Cells[7].Value.ToString()).Equals(0) ? String.Empty : dgvSalesView.Rows[e.RowIndex].Cells[7].Value.ToString();
                    txtCGSTAmt.Text             = Convert.ToDecimal(dgvSalesView.Rows[e.RowIndex].Cells[8].Value.ToString()).Equals(0) ? String.Empty : dgvSalesView.Rows[e.RowIndex].Cells[8].Value.ToString();
                    txtSGSTPer.Text             = Convert.ToDecimal(dgvSalesView.Rows[e.RowIndex].Cells[9].Value.ToString()).Equals(0) ? String.Empty : dgvSalesView.Rows[e.RowIndex].Cells[9].Value.ToString();
                    txtSgstAmt.Text             = Convert.ToDecimal(dgvSalesView.Rows[e.RowIndex].Cells[10].Value.ToString()).Equals(0) ? String.Empty : dgvSalesView.Rows[e.RowIndex].Cells[10].Value.ToString();
                    txtIgstPer.Text             = Convert.ToDecimal(dgvSalesView.Rows[e.RowIndex].Cells[11].Value.ToString()).Equals(0) ? String.Empty : dgvSalesView.Rows[e.RowIndex].Cells[11].Value.ToString();
                    txtGstAmt.Text              = Convert.ToDecimal(dgvSalesView.Rows[e.RowIndex].Cells[12].Value.ToString()).Equals(0) ? String.Empty : dgvSalesView.Rows[e.RowIndex].Cells[12].Value.ToString();
                    btnAddItem.Text             = "Update";
                    btnDeleteItem.Visible       = true;
                    cmbItem.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "dgvSalesView_CellContentClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    btnAddBank.Visible  = false;
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
                SaveSalesPayment(btnAddPayment.Text.ToUpper());
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
                SaveSalesPayment(btnDeletePayment.Text.ToUpper());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "btnDeletePayment_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        #endregion

        #region PaymentMethod
        public String SalesPaymentValidation()
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
                MessageBox.Show(ex.Message.ToString(), "SalesPaymentValidation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return String.Empty;
            }
        }

        public void SaveSalesPayment(String mode)
        {
            try
            {
                clsSalesTransactionPaymentMember objSave = new clsSalesTransactionPaymentMember();
                objSave.Mode = mode.ToUpper();
                if (mode.ToUpper().Equals("DELETE"))
                {
                    var confirmation = MessageBox.Show("Are You Sure You Want to Delete This Payment Amount " + " " + txtPayAmount.Text, "Sales Payment Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (confirmation.ToString().Equals("Yes"))
                    {
                        objSave.Index = Convert.ToInt32(txtPaymentIndex.Text);
                        objSave.SalesTransactionPayKey = Convert.ToInt32(txtSalesTransactionPayKey.Text);
                        objSave.SalesTransactionPayType = cmbPaymentMode.Text;
                        if (cmbPaymentMode.Text.Equals("Cash"))
                        {
                            objSave.SalesTransactionPayDate         = dtpPaymentDate.Value.ToString("dd/MM/yyyy");
                            objSave.SalesActualTransactionPayDate   = dtpPaymentDate.Value.ToString();
                            objSave.SalesTransactionPayAmount = txtPayAmount.Text.Length > 0 ? Convert.ToDecimal(txtPayAmount.Text) : 0;
                        }
                        else
                        {
                            objSave.SalesTransactionPayDate       = dtpPaymentDate.Value.ToString("dd/MM/yyyy");
                            objSave.SalesActualTransactionPayDate = dtpPaymentDate.Value.ToString();
 
                            objSave.SalesTransactionPayAmount = txtPayAmount.Text.Length > 0 ? Convert.ToDecimal(txtPayAmount.Text) : 0;
                            objSave.SalesTransactionPayBankFKey = Convert.ToInt32(cmbBank.SelectedValue);
                            objSave.SalesTransactionPayBankFKeyName = cmbBank.Text;
                            objSave.SalesTransactionPayChequeDate   = dtpChequeDate.Value.ToString("dd/MM/yyyy");
                            objSave.SalesActualTransactionCheckDate = dtpChequeDate.Value.ToString();
                            objSave.SalesTransactionPayBankChequeNo = txtChequeNo.Text;
                        }
                        var lstSalesPaymentDetailtmp = clsSalesTransactionPaymentMember.AddUpdateDeleteSalesTransactionPayments(objSave, lstSalesPaymentDetail);
                        lstSalesPaymentDetail = lstSalesPaymentDetailtmp;
                        dgvPaymentDetail.AutoGenerateColumns = false;
                        dgvPaymentDetail.DataSource = lstSalesPaymentDetail;
                        /*          Calculate the Paid and Pending Amount ***************/
                        txtPaidAmount.Text = CalculatePendingAmount(mode.ToUpper()).ToString();
                        Decimal grossAmount = 0;
                        Decimal.TryParse(txtGTotal.Text, out grossAmount);
                        Decimal paidAmount = 0;
                        Decimal.TryParse(txtPaidAmount.Text, out paidAmount);
                        txtPendingAmount.Text = (grossAmount - paidAmount).ToString();
                        /*          Calculate the Paid and Pending Amount ***************/
                        ResetSalesPayment();
                    }
                }
                else
                {

                    String msg = SalesPaymentValidation();
                    if (msg.Length > 0)
                    {
                        MessageBox.Show(msg, "Sales Payment Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        objSave.Index = Convert.ToInt32(txtPaymentIndex.Text);
                        objSave.SalesTransactionPayKey = Convert.ToInt32(txtSalesTransactionPayKey.Text);
                        objSave.SalesTransactionPayType = cmbPaymentMode.Text;
                        if (cmbPaymentMode.Text.Equals("Cash"))
                        {
                            //string paymentDate = dtpPaymentDate.Value.ToString("dd/MM/yyyy");
                            objSave.SalesTransactionPayDate = dtpPaymentDate.Value.ToString("dd/MM/yyyy");
                            objSave.SalesActualTransactionPayDate = dtpPaymentDate.Value.ToString();
                            objSave.SalesTransactionPayAmount = txtPayAmount.Text.Length > 0 ? Convert.ToDecimal(txtPayAmount.Text) : 0;
                        }
                        else
                        {
                           // string paymentDate = dtpPaymentDate.Value.ToString("dd/MM/yyyy");
                            objSave.SalesTransactionPayDate = dtpPaymentDate.Value.ToString("dd/MM/yyyy");
                            objSave.SalesActualTransactionPayDate = dtpPaymentDate.Value.ToString();
                            objSave.SalesTransactionPayAmount = txtPayAmount.Text.Length > 0 ? Convert.ToDecimal(txtPayAmount.Text) : 0;
                            objSave.SalesTransactionPayBankFKey = Convert.ToInt32(cmbBank.SelectedValue);
                            objSave.SalesTransactionPayBankFKeyName = cmbBank.Text;
                            //string chequeDate = dtpChequeDate.Value.ToString("dd/MM/yyyy");
                            objSave.SalesTransactionPayChequeDate = dtpChequeDate.Value.ToString("dd/MM/yyyy");
                            objSave.SalesActualTransactionCheckDate = dtpChequeDate.Value.ToString();
                            objSave.SalesTransactionPayBankChequeNo = txtChequeNo.Text;
                            objSave.SalesActualTransactionCheckDate = dtpChequeDate.Value.ToString();
                        }
                        var lstSalesPaymentDetailtmp = clsSalesTransactionPaymentMember.AddUpdateDeleteSalesTransactionPayments(objSave, lstSalesPaymentDetail);
                        lstSalesPaymentDetail = lstSalesPaymentDetailtmp;
                        dgvPaymentDetail.AutoGenerateColumns = false;
                        dgvPaymentDetail.DataSource = lstSalesPaymentDetail;
                        txtPaidAmount.Text = CalculatePendingAmount(mode.ToUpper()).ToString();
                        Decimal grossAmount = 0;
                        Decimal.TryParse(txtGTotal.Text, out grossAmount);
                        Decimal paidAmount = 0;
                        Decimal.TryParse(txtPaidAmount.Text, out paidAmount);
                        txtPendingAmount.Text = (grossAmount - paidAmount).ToString();
                        ResetSalesPayment();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "SaveSalesPayment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ResetSalesPayment()
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
            txtSalesTransactionPayKey.Text = "0";
            cmbPaymentMode.Focus();
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
                        txtSalesTransactionPayKey.Text = dgvPaymentDetail.Rows[e.RowIndex].Cells[9].Value.ToString();
                        txtPaymentIndex.Text           = dgvPaymentDetail.Rows[e.RowIndex].Cells[1].Value.ToString();
                        cmbPaymentMode.Text            = dgvPaymentDetail.Rows[e.RowIndex].Cells[2].Value.ToString();
                        dtpPaymentDate.Value           = Convert.ToDateTime(dgvPaymentDetail.Rows[e.RowIndex].Cells[12].Value.ToString());
                        txtPayAmount.Text = dgvPaymentDetail.Rows[e.RowIndex].Cells[4].Value.ToString();
                        btnAddPayment.Text = "Update";
                        btnDeletePayment.Visible = true;
                    }
                    else
                    {
                        txtSalesTransactionPayKey.Text = dgvPaymentDetail.Rows[e.RowIndex].Cells[9].Value.ToString();
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
                if (e.ColumnIndex.Equals(14))
                {
                   int  result =  Convert.ToInt32(dgvPaymentDetail.Rows[e.RowIndex].Cells[9].Value.ToString());
                   if (result.Equals(0))
                   {
                       MessageBox.Show("First Add the Payment then Print it", "Payment Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   }    
                   else
                   {
                       frmPaymentReportViewer objLoad = new frmPaymentReportViewer(result,cId);
                       objLoad.Show();
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
                        MessageBox.Show("Please Enter the Valid Amount", "Sales Pay Amount Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try
            {
                if (e.KeyCode.ToString() != "Tab" && e.KeyCode.ToString() != "ShiftKey" && e.KeyCode.ToString() != "Return" && e.KeyCode.ToString() != "Back")
                {
                    int validInvoiceNo;
                    int.TryParse(txtInvoiceNo.Text, out validInvoiceNo);
                    if (validInvoiceNo.Equals(0) && txtInvoiceNo.Text.Length.Equals(0))
                    {
                        txtInvoiceNo.Text = String.Empty;
                        txtInvoiceNo.Focus();
                        MessageBox.Show("Please Enter the Invoice No", "txtInvoiceNo_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (validInvoiceNo.Equals(0) && txtInvoiceNo.Text.Length > 0)
                    {
                        txtInvoiceNo.Text = String.Empty;
                        txtInvoiceNo.Focus();
                        MessageBox.Show("Please Enter the Valid", "txtInvoiceNo_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "txtInvoiceNo_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmItemMaster objShowItemForm = new frmItemMaster("Yes", rollFKey, cId);
                objShowItemForm.Show();
            }
            catch (Exception ex)
            {
             MessageBox.Show(ex.Message.ToString(), "btnAddNewItem_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public String TotalValidation()
        {
            try
            {
                String msg = String.Empty;
                Decimal validQty = 0;
                Decimal.TryParse(txtQty.Text, out validQty);
                if (validQty.Equals(0) && txtQty.Text.Length > 0 )
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
                return msg;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "TotalValidation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return String.Empty;
            }
        }
        public void ItemCalcution()
        {
            try
            {
                Decimal validQty                     = 0;
                Decimal validRate                    = 0;
                Decimal validTaxableAmt              = 0;
                Decimal validCgstPer                 = 0;
                Decimal validCgstAmt                 = 0;
                Decimal validSgstPer                 = 0;
                Decimal validSgstAmt                 = 0;
                Decimal validIgstPer                 = 0;
                Decimal validIgstAmt                 = 0;
                Decimal validTotal                   = 0;
                Decimal.TryParse(txtQty.Text, out validQty);
                Decimal.TryParse(txtRate.Text, out validRate);
                Decimal.TryParse(txtCgstPer.Text, out validCgstPer);
                Decimal.TryParse(txtSGSTPer.Text, out validSgstPer);
                Decimal.TryParse(txtIgstPer.Text, out validIgstPer);
                validTaxableAmt                      = Math.Round((validQty *validRate),2);
                validCgstAmt                         = validCgstPer.Equals(0) ? 0 : Math.Round(((validTaxableAmt) * (validCgstPer)) / 100, 2);
                validSgstAmt                         = validSgstPer.Equals(0) ? 0 : Math.Round(((validTaxableAmt) * (validSgstPer)) / 100, 2);
                validIgstAmt                         = validIgstPer.Equals(0) ? 0 : Math.Round(((validTaxableAmt) * (validIgstPer)) / 100, 2);
                validTotal                           = Math.Round(validTaxableAmt + validCgstAmt + validSgstAmt + validIgstAmt , 2);
                txtTaxableValue.Text                 = validTaxableAmt.ToString();
                txtCGSTAmt.Text                      = validCgstAmt.ToString();
                txtSgstAmt.Text                      = validSgstAmt.ToString();
                txtGstAmt.Text                       = validIgstAmt.ToString();
                txtTotal.Text                        = validTotal.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "ItemCalcution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCgstPer_KeyUp(object sender, KeyEventArgs e)
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
                    MessageBox.Show(msg, "Sales Total Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void CalculateMainTotal()
        {
            try
            {
                Decimal MainTotal = 0;
                Decimal CGSTAmt   = 0;
                Decimal SGSTAmt   = 0;
                Decimal IGSTAmt   = 0;
                Decimal GTOTAL    = 0;
                Decimal PaidAmt   = 0;
                Decimal Roundoff  = 0;
                Decimal Cartage   = 0;
                foreach (DataGridViewRow row in dgvSalesView.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        if (row.Cells[18].Value.ToString() == "DELETE")
                        {
                            dgvSalesView.CurrentCell        = null;
                            row.Visible                     = false;
                        }
                        else
                        {
                            MainTotal                       += Convert.ToDecimal(row.Cells[6].Value.ToString());
                            CGSTAmt                         += Convert.ToDecimal(row.Cells[8].Value.ToString());
                            SGSTAmt                         += Convert.ToDecimal(row.Cells[10].Value.ToString());
                            IGSTAmt                         += Convert.ToDecimal(row.Cells[12].Value.ToString());
                            GTOTAL                          += Convert.ToDecimal(row.Cells[13].Value.ToString());
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
                    txtGTotal.Text              = Math.Round(GTOTAL + Cartage - Roundoff, 2).ToString();
                    txtPendingAmount.Text       = Math.Round(GTOTAL + Cartage - PaidAmt - Roundoff, 2).ToString();
                }
                else
                {
                    txtGTotal.Text              = Math.Round(GTOTAL + Cartage + Roundoff, 2).ToString();
                    txtPendingAmount.Text       = Math.Round(GTOTAL + Cartage + PaidAmt - Roundoff, 2).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "CalculateMainTotal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtChlnNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
        public void LoadItem()
        {
            try
            {
                clsItemMaster objItemGroupItem = new clsItemMaster();
                objItemGroupItem.Mode = "SELECTALL";
                objItemGroupItem.CompanyID  = cId;
                var ds = objItemGroupItem.GetSearchItems();
                DataTable dtItems = ds.Tables[0];
                DataRow drItems = dtItems.NewRow();
                drItems["ItemMasterKey"] = "0";
                drItems["ItemMasterName"] = "Please Select Item";
                dtItems.Rows.InsertAt(drItems, 0);
                cmbItem.DataSource = dtItems;
                cmbItem.DisplayMember = "ItemMasterName";
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
                clsItemMaster objSave   = new clsItemMaster();
                objSave.ItemMasterKey   = Convert.ToInt32(txtKey.Text);
                objSave.ItemMasterName  = cmbItem.Text;
                objSave.CompanyID       = cId;
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
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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

        private void txtRoundoff_TextChanged(object sender, EventArgs e)
        {

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

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                frmCustomer objShowItemForm = new frmCustomer(rollFKey,cId,"Yes");
                objShowItemForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "btnAddCustomer_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void BindNewRecordComboCombo(string action)
        {
            try
            {
                if (action.Equals("Customer"))
                {
                    /*****************      Bind the Customer Combo*******************/
                    cmbCustomer.DataSource    = null;
                    cmbCustomer.Items.Clear();
                    clsCustomerMaster objLoad = new clsCustomerMaster();
                    objLoad.Mode = "SELECTALL";
                    objLoad.CompanyID = cId;
                    var dsCustomer = objLoad.GetAllCustomer();
                    //clsComboBoxItem objComboItem = new clsComboBoxItem();
                    //objComboItem.Text = "Please Select Customer";
                    //objComboItem.Value = "0";
                    //cmbCustomer.Items.Add(objComboItem);
                    DataTable dtCustomer = dsCustomer.Tables[0];
                    DataRow dr = dtCustomer.NewRow();
                    dr["CustomerID"]                    = "0";
                    dr["CustomerName"]                  = "Please Select the Customer";
                    dtCustomer.Rows.InsertAt(dr, 0);
                    cmbCustomer.DataSource              = dtCustomer;
                    cmbCustomer.DisplayMember           = "CustomerName";
                    cmbCustomer.ValueMember             = "CustomerID";
                    cmbCustomer.Text                    = "Please Select the Customer";
                    /*****************      Bind the Customer Combo*******************/
                }
                else if (action.Equals("Bank"))
                {
                    cmbBank.DataSource                  = null;
                    cmbBank.Items.Clear();
                    clsCategoryMaster objLoadBank       = new clsCategoryMaster();
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
                    cmbBank.DataSource                  = dtBankName;
                    cmbBank.DisplayMember               = "CategoryMasterCatVal";
                    cmbBank.ValueMember                 = "CategoryMasterCatKey";
                    cmbBank.Text                        = "Please Select Bank";
                    /*          Bind the Bank Combo     */
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "BindCustomerCombo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                BindNewRecordComboCombo("Customer");
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
                frmCategoryMaster objShowItemForm = new frmCategoryMaster(rollFKey,cId, "Yes");
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        
      }
}
    