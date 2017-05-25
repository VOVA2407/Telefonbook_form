/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 23.05.2017
 * Time: 11:17
 * Программа для тестирования и отработки навыков.
 * 25.05 Создан класс оператор
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
///ust a comment
namespace Telefonbook_form
{
	
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	/// 
	public class telefonist
	{
		//человек, который работает с телефонной книгой
		private string name;
		private string number;
		
		public string Name()
		{
			return name;
		}
		
		public void setName(string Name)
		{
			this.name = Name;
		}
		
		public void setNumber(int Number)
		{
			this.number = Number;
		}
		
	}
	public class PhoneBook
	{
		private string name; // закрытые поля
		private string surname;
		private string number;
		static private int age = 24;
		public PhoneBook(string Name)
		{
			this.name = Name;
		}

     public string Familia // свойство
     {  get { return surname; }
         set { surname = value; }
     }
		public void setSurname(string Surname)
		{
			surname = Surname;
		}
		public string M1() // 
		{
			return name;
		}
		public string M2()
		{
			return surname;
		}

		/*public void setName()
		{get return; set Name = value;}*/
	}//end of class PhoneBook
	public partial class MainForm : Form
	{
		public static bool rus = false;
	public static bool eng = false;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		

		
		
		
		void TextBox1KeyPress(object sender, KeyPressEventArgs e)
		{
			
			if ((e.KeyChar > 'А') && (e.KeyChar < 'Я') || (e.KeyChar == '\b'))
			{
				rus = true;
				eng = false;
				return;
			}
			if((e.KeyChar > 'A') && (e.KeyChar < 'Z') || (e.KeyChar == '\b'))
			{
				rus = false;
				eng = true;
				return;
			}
			e.Handled = true;
		}
		
		
		void Button1Click(object sender, EventArgs e)
		{
		
			string Name;
			Name = textBox1.Text;
			
			PhoneBook Book = new PhoneBook(Name);
			Book.Familia = "VOVA";
			if(rus)
			{
			label3.Text = Book.M1();
			}
			if(eng)
			{
			label4.Text = Book.M1();
			}
			label5.Text = Book.Familia;
			Book.setSurname("IAKOVLEV");
			label6.Text = Book.M2();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			
		}
	}
}
