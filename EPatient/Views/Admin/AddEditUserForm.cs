using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using EPatient.Models;

namespace EPatient.Views.Admin
{
    public partial class AddEditUserForm : MetroFramework.Forms.MetroForm
    {
        public User UserInfo => bindingSourceUser.Current as User;

        public AddEditUserForm(User obj)
        {
            InitializeComponent();
            bindingSourceUser.DataSource = obj;
        }

        private void AddEditUserForm_Load(object sender, EventArgs e)
        {
            cboRole.DisplayMember = "Name";
            cboRole.ValueMember = "Id";
            cboPavilion.DisplayMember = "Name";
            cboPavilion.ValueMember = "Id";

            using (EPatientContext _context = new EPatientContext())
            {
                cboRole.DataSource = _context.Roles.ToList();
                cboPavilion.DataSource = _context.Pavilions.ToList();
            }

            if (UserInfo.RoleId != 0)         
                cboRole.SelectedIndex = cboRole.FindStringExact(UserInfo.Role.Name);
            else
                cboRole.SelectedIndex = -1;

            if (UserInfo.PavilionId != null)
                cboPavilion.SelectedIndex = cboPavilion.FindStringExact(UserInfo.Pavilion.Name);
            else
                cboPavilion.SelectedIndex = -1;

            if (string.IsNullOrEmpty(UserInfo.Name))
            {
                textPassword.Enabled = true;
                chkBoxEditPassword.Hide();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (!string.IsNullOrEmpty(textPassword.Text))
                {
                    UserInfo.Password = Utilities.HashingPassword.Hash(textPassword.Text);
                }

                bindingSourceUser.EndEdit();
                DialogResult = DialogResult.OK;
            }
        }

        private void textName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textName.Text) || textName.Text.Length > 255)
            {
                e.Cancel = true;
                textName.Focus();
                errorProvider.SetError(textName, "(لطفا نام کاربری را وارد کنید (حداکثر 255 کاراکتر");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textName, null);
            }
        }

        private void textSurname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textSurname.Text) || textSurname.Text.Length > 255)
            {
                e.Cancel = true;
                textSurname.Focus();
                errorProvider.SetError(textSurname, "لطفا نام خانوادگی کاربر را وارد کنید");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textSurname, null);
            }
        }

        private void textUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textUsername.Text) || textUsername.Text.Length > 255)
            {
                e.Cancel = true;
                textUsername.Focus();
                errorProvider.SetError(textUsername, "لطفا نام کاربری کاربر را وارد کنید");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textUsername, null);
            }
        }

        private void cboRole_Validating(object sender, CancelEventArgs e)
        {
            if (cboRole.SelectedIndex < 0)
            {
                e.Cancel = true;
                cboRole.Focus();
                errorProvider.SetError(cboRole, "لطفا یک دسترسی را انتخاب کنید");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cboRole, null);
            }
        }

        private void chkBoxEditPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxEditPassword.Checked)
            {
                textPassword.Enabled = true;
            }
            else
            {
                textPassword.Enabled = false;
            }
        }
    }
}
