using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrelloRepo;

namespace DesktopClient2
{
    public partial class Form1 : Form
    {
        private readonly IRepo repo = RepoFactory.GetRepo();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillUsers();
            FillItems();
        }

        private void FillItems()
        {
            LbItems.DataSource = repo.GetItems().ToList();
        }

        private void FillUsers()
        {
            CbUsers.DataSource = repo.GetUsers().ToList();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (Form_Valid())
            {
                repo.AddItem(new Item
                {
                    Id = int.Parse(TbId.Text.Trim()),
                    Description = TbDescription.Text.Trim(),
                    Date = DtpDate.Value,
                    User = CbUsers.SelectedItem as User
                });
                FillItems();
                ClearForm();
            }
        }

        private void ClearForm()
        {
            TbId.Clear();
            TbDescription.Clear();
            DtpDate.Value = DateTime.Now;
        }

        private bool Form_Valid()
        {
            if (!int.TryParse(TbId.Text.Trim(), out int val))
            {
                MessageBox.Show("Id must be a number.");
                TbId.Focus();
                return false;
            }
            
            if (string.IsNullOrEmpty(TbDescription.Text.Trim()))
            {
                MessageBox.Show("Description cannot be empty.");
                TbDescription.Focus();
                return false;
            }
            
            return true;
        }
    }
}