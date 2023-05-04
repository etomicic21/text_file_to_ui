using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextToFile
{
    public partial class UserInfoForm : Form
    {
        public UserInfoForm()
        {
            InitializeComponent();
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
            }

            var userDisplayer = new UserDisplayer(filePath);

            LoadData(userDisplayer);
        }

        private void LoadData(UserDisplayer userDisplayer)
        {
            txtFullName.Text = userDisplayer.FullName;
            txtYearOfBirth.Text = userDisplayer.YearOfBirth;
            txtCity.Text = userDisplayer.City;
            txtFaculty.Text = userDisplayer.Faculty;
            txtRole.Text = userDisplayer.Role;
            lblAttribute.Text = userDisplayer.AttributeName;
            txtAttribute.Text = userDisplayer.AttributeValue;
        }
    }
}
