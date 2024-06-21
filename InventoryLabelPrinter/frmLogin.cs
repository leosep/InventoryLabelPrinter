using System;
using System.Linq;
using System.Windows.Forms;
using DAL;
using BLL;

namespace InventoryLabelPrinter
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string password = txtContrasena.Text;

            if (ValidateUser(user, password))
            {
                OpenMainForm();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private bool ValidateUser(string user, string password)
        {
            using (var context = new GOFFICE_DATAEntities())
            {
                string encryptedPassword = EncryptPassword(password);
                var query = from u in context.cousuarios
                            where u.usuarioid.Equals(user) && u.password.Equals(encryptedPassword)
                            select u;

                var userEntity = query.FirstOrDefault();
                if (userEntity != null)
                {
                    Globals.user = userEntity.usuarioid;
                    return true;
                }
                return false;
            }
        }

        private string EncryptPassword(string password)
        {
            MD5 encrypt = new MD5();
            return encrypt.CreateMD5(password);
        }

        private void OpenMainForm()
        {
            frmLabels labels = new frmLabels();
            labels.Show();
            this.Hide();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // Additional load logic if required
        }
    }
}
