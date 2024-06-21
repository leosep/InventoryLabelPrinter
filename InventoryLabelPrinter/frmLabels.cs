using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DAL;
using InventoryLabelPrinter.Models;

namespace InventoryLabelPrinter
{
    public partial class frmLabels : Form
    {
        public frmLabels()
        {
            InitializeComponent();
        }

        private void frmEtiquetas_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            WindowState = FormWindowState.Maximized;
        }

        private void LoadComboBoxes()
        {
            using (var context = new GOFFICE_DATAEntities())
            {
                var typeList = GetTypeList(context);
                InitializeComboBox(cboTipo, "tipo_activo", "descrip", typeList);

                var groupList = GetGroupList(context);
                InitializeComboBox(cboGrupo, "grupo_activo", "descrip", groupList);
            }
        }

        private static List<aftipoact> GetTypeList(GOFFICE_DATAEntities context)
        {
            var typeList = context.aftipoacts.OrderBy(t => t.descrip).ToList();
            typeList.Insert(0, new aftipoact { tipo_activo = -1, descrip = "-----SELECT-----" });
            return typeList;
        }

        private static List<afgrupos> GetGroupList(GOFFICE_DATAEntities context)
        {
            var groupList = context.afgrupos.OrderBy(g => g.descrip).ToList();
            groupList.Insert(0, new afgrupos { grupo_activo = -1, descrip = "-----SELECT-----" });
            return groupList;
        }

        private static void InitializeComboBox(ComboBox comboBox, string valueMember, string displayMember, object dataSource)
        {
            comboBox.ValueMember = valueMember;
            comboBox.DisplayMember = displayMember;
            comboBox.DataSource = dataSource;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void PerformSearch()
        {
            dgActivos.Columns.Clear();
            Cursor.Current = Cursors.WaitCursor;

            using (var context = new GOFFICE_DATAEntities())
            {
                var query = BuildSearchQuery(context);
                DisplaySearchResults(query);
            }

            Cursor.Current = Cursors.Default;
        }

        private IQueryable<ActiveList> BuildSearchQuery(GOFFICE_DATAEntities context)
        {
            int code = GetIntValue(txtCodigo.Text);
            int finalCode = GetIntValue(txtCodigoFinal.Text);
            string desc = txtDesc.Text;
            int type = Convert.ToInt32(cboTipo.SelectedValue);
            int group = Convert.ToInt32(cboGrupo.SelectedValue);
            string serie = txtSerie.Text;

            var query = from a in context.afactivos
                        select new ActiveList
                        {
                            activo = a.activo,
                            descripcion = a.descrip.Trim(),
                            codTipo = a.aftipoact.tipo_activo,
                            tipo = a.aftipoact.descrip.Trim(),
                            codGrupo = a.afgrupos.grupo_activo,
                            grupo = a.afgrupos.descrip.Trim(),
                            serie = a.serie.Trim()
                        };

            if (!string.IsNullOrEmpty(serie))
            {
                query = query.Where(a => a.serie.Contains(serie));
            }

            if (!string.IsNullOrEmpty(desc))
            {
                query = query.Where(a => a.descripcion.Contains(desc));
            }

            if (code > 0 && finalCode < 1)
            {
                txtCodigoFinal.Text = txtCodigo.Text;
                query = query.Where(a => a.activo == code);
            }

            if (code > 0 && finalCode > 0)
            {
                query = query.Where(x => x.activo >= code && x.activo <= finalCode);
            }

            if (type > -1)
            {
                query = query.Where(a => a.codTipo == type);
            }

            if (group > -1)
            {
                query = query.Where(a => a.codGrupo == group);
            }

            return query.OrderBy(a => a.activo);
        }

        private static int GetIntValue(string text)
        {
            return string.IsNullOrEmpty(text.Trim()) ? 0 : Convert.ToInt32(text);
        }

        private void DisplaySearchResults(IQueryable<ActiveList> query)
        {
            BindingSource source = new BindingSource
            {
                DataSource = query.ToList()
            };

            dgActivos.DataSource = source;
            dgActivos.AutoResizeColumns();
            dgActivos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            CreateCheckBoxes();
        }

        private void btnImprimir_ClickAsync(object sender, EventArgs e)
        {
            int labelsAmount = CountSelectedLabels();

            if (labelsAmount > 0)
            {
                frmConfirm confirm = new frmConfirm(labelsAmount, dgActivos);
                confirm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must select at least one fixed asset to print labels.");
            }
        }

        private int CountSelectedLabels()
        {
            return dgActivos.Rows.Cast<DataGridViewRow>()
                .Count(row => Convert.ToBoolean(row.Cells["checkBoxColumn"].EditedFormattedValue));
        }

        private void frmEtiquetas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmEtiquetas_SizeChanged(object sender, EventArgs e)
        {
            ResizeFormElements();
        }

        private void ResizeFormElements()
        {
            int newFormHeight = this.Height;
            int newFormWidth = this.Width;

            dgActivos.Size = new Size(newFormWidth - 40, newFormHeight - 250);
            gbBuscar.Size = new Size(newFormWidth - 40, gbBuscar.Height);
        }

        private void HandleKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar.PerformClick();
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateKeyPress(sender, e);
        }

        private void txtCodigoFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateKeyPress(sender, e);
        }

        private static void ValidateKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox)?.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void ClearControls()
        {
            txtCodigo.Clear();
            txtCodigoFinal.Clear();
            txtDesc.Clear();
            cboGrupo.SelectedIndex = cboGrupo.FindStringExact("-----SELECT-----");
            cboTipo.SelectedIndex = cboTipo.FindStringExact("-----SELECT-----");
            txtSerie.Clear();
        }

        private void CreateCheckBoxes()
        {
            Point headerCellLocation = dgActivos.GetCellDisplayRectangle(0, -1, true).Location;
            AddHeaderCheckBox(headerCellLocation);

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
            {
                HeaderText = "",
                Width = 30,
                Name = "checkBoxColumn"
            };
            dgActivos.Columns.Insert(0, checkBoxColumn);

            dgActivos.CellContentClick += DataGridView_CellClick;
        }

        private void AddHeaderCheckBox(Point headerCellLocation)
        {
            headerCheckBox.Location = new Point(headerCellLocation.X + 8, headerCellLocation.Y + 2);
            headerCheckBox.BackColor = Color.White;
            headerCheckBox.Size = new Size(18, 18);
            headerCheckBox.Click += HeaderCheckBox_Clicked;
            dgActivos.Controls.Add(headerCheckBox);
        }

        private void HeaderCheckBox_Clicked(object sender, EventArgs e)
        {
            dgActivos.EndEdit();
            foreach (DataGridViewRow row in dgActivos.Rows)
            {
                DataGridViewCheckBoxCell checkBox = row.Cells["checkBoxColumn"] as DataGridViewCheckBoxCell;
                checkBox.Value = headerCheckBox.Checked;
            }
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                UpdateHeaderCheckBox();
            }
        }

        private void UpdateHeaderCheckBox()
        {
            bool isChecked = dgActivos.Rows.Cast<DataGridViewRow>()
                .All(row => Convert.ToBoolean(row.Cells["checkBoxColumn"].EditedFormattedValue));
            headerCheckBox.Checked = isChecked;
        }

        CheckBox headerCheckBox = new CheckBox();
    }
}
