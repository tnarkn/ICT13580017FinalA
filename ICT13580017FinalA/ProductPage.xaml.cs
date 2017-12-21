using System;
using System.Collections.Generic;
using ICT13580017FinalA.Models;
using Xamarin.Forms;

namespace ICT13580017FinalA
{
    public partial class ProductPage : ContentPage
    {
        ProductPage product;

        public ProductPage()
        {
            InitializeComponent();

			this.product = product;

			titleLable.Text = product == null ? "เพิ่มสินค้าใหม่" : "แก้ไขข้อมูล";

            saveButton.Clicked += SaveButton_Clicked;
			cancelButton.Clicked += CancelButton_Clicked;

            sex.Items.Add("ชาย");
            sex.Items.Add("หญิง");

			if (product != null)
			{
                NameEntry.Text = product.Name;
                lastNameEntry.Text = product.lastName;
				descriptionEditor.Text = product.description;
                sex.SelectedItem = product.sex;
                phone.Text = product.phone.ToString();
                Age.Text = product.Age.ToString();
                department.Text = product.department.ToString();
			}
		}

		async void SaveButton_Clicked(object sender, EventArgs e)
		{
			var isOk = await DisplayAlert("ยืนยัน", "คุณต้องการบันทึกใช่หรือไม่", "ใช่", "ไม่ใช่");

			if (isOk)
			{
				if (product == null)
				{
					var product = new Product();
                    product.Name = NameEntry.Text;
                    product.lastName = lastNameEntry.Text;
                    product.department = department.Text;
                    product.email = email.Text;
                    product.descriptionEditor = descriptionEditor.Text;
                    product.total = int.Parse(total.Text);
                    product.Age = int.Parse(Age.Text);
                    product.phone = int.Parse(phone.Text);
                    product.sex = decimal.Parse(sex.Text);
                    product.salary = decimal.Parse(salary.text);
                    var id = App.GetDbHelper().AddProduct(product);
					await DisplayAlert("บันทึกสำเร็จ", "รหัสสินค้าของท่านคือ #" + Id, "ตกลง");
				}
				else
				{
					await DisplayAlert("บันทึกสำเร็จ", "รหัสสินค้าของท่านคือ ", "ตกลง");
				}
			}
		}

		void CancelButton_Clicked(object sender, EventArgs e)
		{
			Navigation.PopModalAsync();
		}
	}
}
