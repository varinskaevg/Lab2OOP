using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Lab2;
using System.Text;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private PostalAddress lastCreatedAddress;
        private PostalAddress lastEditedAddress;
        private PostalAddress address;
        private List<PostalAddress> addresses;
        private string savedIndex;
        private string savedCountry;
        private string savedCity;
        private string savedStreet;
        private string savedHouse;
        private string savedApartment;
        public Form1()
        {
            InitializeComponent();
            btnCreate.Click += btnCreate_Click;
            addresses = new List<PostalAddress>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> cities = new List<string>() { "�������", "���", "�����" };
            List<string> countries = new List<string>() { "������", "�����", "ͳ�������" };

            comboBoxCity.Items.AddRange(cities.ToArray());
            comboBoxCountry.Items.AddRange(countries.ToArray());

            label1.Text = "������ ���� ��� ���������";
            label2.Text = "�������� ������:";
            label3.Text = "�����:";
            label4.Text = "̳���:";
            label5.Text = "������:";
            label6.Text = "�������:";
            label7.Text = "��������:";
            label8.Text = "���������:";
            btnCreate.Text = "��������";
            btnDelete.Text = "�������� ����";
            btnEdit.Text = "�����������";
            btnShow.Text = "��������";
            btnSave.Text = "��������";
            lblResult.Text = "";
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIndex.Text) || string.IsNullOrEmpty(comboBoxCountry.Text) ||
                string.IsNullOrEmpty(comboBoxCity.Text) || string.IsNullOrEmpty(txtStreet.Text) ||
                string.IsNullOrEmpty(txtHouse.Text) || string.IsNullOrEmpty(txtApartment.Text))
            {
                MessageBox.Show("���� �����, �������� �� ����.", "������������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            savedIndex = txtIndex.Text;
            savedCountry = comboBoxCountry.Text;
            savedCity = comboBoxCity.Text;
            savedStreet = txtStreet.Text;
            savedHouse = txtHouse.Text;
            savedApartment = txtApartment.Text;
            PostalAddress newAddress = new PostalAddress(savedIndex, savedCountry, savedCity, savedStreet, savedHouse, savedApartment);
            addresses.Add(newAddress);
            lblResult.Text = newAddress.ToString();
            lastCreatedAddress = newAddress;
            ClearFields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lastCreatedAddress != null)
            {
                txtIndex.Text = lastCreatedAddress.Index;
                comboBoxCountry.Text = lastCreatedAddress.Country;
                comboBoxCity.Text = lastCreatedAddress.City;
                txtStreet.Text = lastCreatedAddress.Street;
                txtHouse.Text = lastCreatedAddress.House;
                txtApartment.Text = lastCreatedAddress.Apartment;
            }
            else
            {
                MessageBox.Show("�� �� ���� �������� �����.");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            addresses.Clear();
            address = null;
            ClearFields();
            lblResult.Text = "";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            StringBuilder addressesStringBuilder = new StringBuilder();

            if (lastCreatedAddress != null)
            {
                addressesStringBuilder.AppendLine("������� ��������� �����:");
                addressesStringBuilder.AppendLine(lastCreatedAddress.ToString());
            }

            if (lastEditedAddress != null)
            {
                addressesStringBuilder.AppendLine("������� ������������� �����:");
                addressesStringBuilder.AppendLine(lastEditedAddress.ToString());
            }

            if (addressesStringBuilder.Length > 0)
            {
                lblResult.Text = addressesStringBuilder.ToString();
            }
            else
            {
                MessageBox.Show("������ ����� �������.");
            }
        }
        private void ClearFields()
        {
            txtIndex.Text = "";
            comboBoxCountry.SelectedIndex = -1;
            comboBoxCity.SelectedIndex = -1;
            txtStreet.Text = "";
            txtHouse.Text = "";
            txtApartment.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lastEditedAddress = new PostalAddress(txtIndex.Text, comboBoxCountry.Text, comboBoxCity.Text, txtStreet.Text, txtHouse.Text, txtApartment.Text);
            ClearFields();
            lblResult.Text = lastEditedAddress.ToString();
        }

        private void txtIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;
        }

        private void txtHouse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;
        }

        private void txtApartment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;
        }

        private void comboBoxCountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
