﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Запуск : Form
    {
        public Запуск()
        {
            InitializeComponent();

        }

        private void button3_Click(object sender, EventArgs e) // возвращение в главное меню
        {
            this.Hide();
            Главноеменю главноеменю = (Главноеменю)Application.OpenForms[0];
            главноеменю.Show(); 
        }
    }
}
