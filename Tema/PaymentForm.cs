using System;
using System.Windows.Forms;

namespace Tema
{
    public partial class PaymentForm : Form
    {
        Account m_FromAccount = new Account();
        Account m_ToAccount = new Account();

        public PaymentForm()
        {
            InitializeComponent();

            m_FromAccount.SoldChanged += (s, e) =>
            {
                spAccount1Sold.Value = m_FromAccount.Sold;
            };

            m_ToAccount.SoldChanged += (s, e) =>
            {
                spAccount2Sold.Value = m_ToAccount.Sold;
            };

            spAccount1Sold.Focus();
            spAccount1Sold.Select(0, 100);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            m_FromAccount.LoadSold(spAccount1Sold.Value);
            spAccount1Sold.Enabled =
                btnConfirm.Enabled = false;

            spPaymentValue.Focus();
            spPaymentValue.Select(0, 100);
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                m_FromAccount.Withdraw(spPaymentValue.Value);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                spPaymentValue.Value = 0;
                spPaymentValue.Focus();
                spPaymentValue.Select(0, 100);
            }
        }

        private void btnTransferFrom_Click(object sender, EventArgs e)
        {
            try
            {
                m_FromAccount.Transfer(spTransferFrom.Value, m_ToAccount);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                spTransferFrom.Value = 0;
                spTransferFrom.Focus();
                spTransferFrom.Select(0, 100);
            }
        }

        private void spSold_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnConfirm.PerformClick();
        }

        private void spPaymentValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnWithdraw.PerformClick();
        }

        private void btnTransferTo_Click(object sender, EventArgs e)
        {
            try
            {
                m_ToAccount.Transfer(spTransferTo.Value, m_FromAccount);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                spTransferTo.Value = 0;
                spTransferTo.Focus();
                spTransferTo.Select(0, 100);
            }
        }
    }
}
