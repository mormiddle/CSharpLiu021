﻿using System;
using System.Windows.Forms;

namespace EventExample4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyForm form = new MyForm();
            form.ShowDialog();
        }
    }

    class MyForm : Form
    {
        private TextBox textBox;
        private Button button;

        public MyForm()
        {
            this.textBox = new TextBox();
            this.button = new Button();
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBox);
            this.button.Click += this.ButtonClicked;
            this.button.Text = "Say Hello";
            this.button.Top = 100;
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            this.textBox.Text = "Hello, World!!!!!!!!!!!!!";
        }
    }
}
