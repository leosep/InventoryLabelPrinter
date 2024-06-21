using BLL;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryLabelPrinter
{
    public partial class frmConfirm : Form
    {
        private int amount;
        private DataGridView dg;

        public frmConfirm(int amount, DataGridView dg)
        {
            InitializeComponent();
            this.amount = amount;
            this.dg = dg;
            lblCantidad.Text = amount.ToString();
            lblFaltantes.Text = amount.ToString();
        }

        private async void btnImprimir_ClickAsync(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                await PrintAsync();
            }
            catch (Exception ex)
            {
                HandlePrintException(ex);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private async Task PrintAsync()
        {
            SetPrintingState(true);
            InitializeProgressBar();

            decimal total = this.amount;
            decimal portion = 0;
            decimal missing = this.amount;

            ZebraPrinter zb = new ZebraPrinter();

            foreach (DataGridViewRow row in dg.Rows)
            {
                if (IsRowChecked(row))
                {
                    await PrintRowAsync(zb, row);
                    UpdateProgressBar(ref portion, ref missing, total);
                }
            }

            SetPrintingState(false);
        }

        private bool IsRowChecked(DataGridViewRow row)
        {
            return Convert.ToBoolean(row.Cells["checkBoxColumn"].EditedFormattedValue);
        }

        private async Task PrintRowAsync(ZebraPrinter zb, DataGridViewRow row)
        {
            await zb.printUsb(row.Cells[2].Value.ToString(), row.Cells[1].Value.ToString());
        }

        private void UpdateProgressBar(ref decimal portion, ref decimal missing, decimal total)
        {
            pbImprimir.Value++;
            portion = pbImprimir.Value;
            decimal percent = Math.Floor((portion / total) * 100m);
            missing--;

            UpdateLabels(percent, missing);
        }

        private void UpdateLabels(decimal percent, decimal missing)
        {
            lblPorciento.Invoke(new Action(() => lblPorciento.Text = percent.ToString() + "%"));
            lblFaltantes.Invoke(new Action(() => lblFaltantes.Text = missing.ToString()));
        }

        private void SetPrintingState(bool isPrinting)
        {
            btnImprimir.Text = isPrinting ? "Printing..." : "Done...";
            btnImprimir.Enabled = !isPrinting;
        }

        private void InitializeProgressBar()
        {
            pbImprimir.Maximum = this.amount;
            pbImprimir.Step = 1;
            pbImprimir.Value = 0;
        }

        private void HandlePrintException(Exception ex)
        {
            btnImprimir.Text = "Error...";
            MessageBox.Show("Error trying to connect to the printer or the operation has been cancelled.");
            // Log the exception if needed
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConfirm_Load(object sender, EventArgs e)
        {
            // Any initialization logic can be placed here if needed
        }
    }
}
