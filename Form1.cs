using Practise_WFA_LogInSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practise_WFA_LogInSystem
{
    public partial class Form1 : Form
    {
        DetailInfo detailInfo = new DetailInfo();
        public Form1()
        {
            InitializeComponent();
        }

        void GenerateMember() 
        {
            detailInfo.FirstName = txtFirstName.Text;
            detailInfo.LastName = txtLastName.Text;
            detailInfo.BirthDate = DateTime.Parse(mskdBirthDate.Text);
            detailInfo.Email = txtEmail.Text;
            detailInfo.Phone = txtPhone.Text;
            detailInfo.Age = DateTime.Now.Year - detailInfo.BirthDate.Year;
        }

        void ListOfMember()
        {
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = detailInfo.Id.ToString();
            listViewItem.SubItems.Add(detailInfo.FirstName);
            listViewItem.SubItems.Add(detailInfo.LastName);
            listViewItem.SubItems.Add(detailInfo.Age.ToString());
            listViewItem.SubItems.Add(detailInfo.BirthDate.ToString());
            listViewItem.SubItems.Add(detailInfo.Email.ToString());
            listViewItem.SubItems.Add(detailInfo.Phone.ToString());
            lstViewUserInfo.Items.Add(listViewItem);
        }

        void Eraser(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                if (item is TextBox || item is MaskedTextBox)
                {
                    item.Text = string.Empty;
                }
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            GenerateMember();
            ListOfMember();
            Eraser(groupBox1);
        }
        
    }
}
