/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 23.05.2017
 * Time: 11:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Telefonbook_form
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(370, 340);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1KeyPress);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(313, 408);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Записать";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(135, 365);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Имя";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(388, 287);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Сохранённое имя";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(525, 323);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "Вывести";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(749, 275);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(178, 460);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "label4";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(225, 399);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 7;
			this.label5.Text = "label5";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(247, 323);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 8;
			this.label6.Text = "label6";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(262, 21);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(285, 23);
			this.label7.TabIndex = 9;
			this.label7.Text = "Работа со свойством Car";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(278, 55);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(148, 23);
			this.label8.TabIndex = 10;
			this.label8.Text = "Введите марку авто";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(388, 52);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(127, 20);
			this.textBox2.TabIndex = 11;
			this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox2KeyPress);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(278, 98);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(96, 49);
			this.button3.TabIndex = 12;
			this.button3.Text = "Вывести марку авто";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(388, 113);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(127, 20);
			this.textBox3.TabIndex = 13;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(41, 9);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(199, 22);
			this.label9.TabIndex = 14;
			this.label9.Text = "Введите данные телефониста";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(84, 34);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(145, 20);
			this.textBox4.TabIndex = 15;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(51, 37);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(64, 23);
			this.label10.TabIndex = 16;
			this.label10.Text = "Имя";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(17, 60);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 23);
			this.label11.TabIndex = 17;
			this.label11.Text = "Таб. номер";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(84, 56);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(145, 20);
			this.textBox5.TabIndex = 18;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(41, 80);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(100, 23);
			this.label12.TabIndex = 19;
			this.label12.Text = "Смена";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(84, 77);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(145, 20);
			this.textBox6.TabIndex = 20;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(34, 103);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(100, 23);
			this.label13.TabIndex = 19;
			this.label13.Text = "Филиал";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(84, 98);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(145, 20);
			this.textBox7.TabIndex = 20;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(17, 124);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(100, 23);
			this.label14.TabIndex = 19;
			this.label14.Text = "Марка авто";
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(84, 121);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(145, 20);
			this.textBox8.TabIndex = 20;
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(84, 143);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(145, 20);
			this.textBox9.TabIndex = 20;
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(27, 146);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(100, 23);
			this.label15.TabIndex = 19;
			this.label15.Text = "Зарплата";
			// 
			// textBox10
			// 
			this.textBox10.Location = new System.Drawing.Point(84, 166);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(145, 20);
			this.textBox10.TabIndex = 20;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1069, 621);
			this.Controls.Add(this.textBox10);
			this.Controls.Add(this.textBox9);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label10);
			this.Name = "MainForm";
			this.Text = "Telefonbook_form";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
	}
}
