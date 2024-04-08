using System;
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
    public partial class Настройки : Form
    {
        
        public event Action<int> TrackBarValueChanged;
        public Настройки(int volume)
        {
            InitializeComponent();
            trackBar5.Value = volume; // для того, чтобы не начинался с ноля
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

       

        
        private void tabPage2_Click(object sender, EventArgs e) // настройка звука
        {

        }

        private void trackBar4_Scroll(object sender, EventArgs e) // громкость персонажей
        {
            TrackBarValueChanged?.Invoke(trackBar4.Value); 
        }

        private void trackBar3_Scroll(object sender, EventArgs e) // громкость звука 
        {
            TrackBarValueChanged?.Invoke(trackBar3.Value);
        }
        private void TrackBar5_Scroll(object sender, EventArgs e) // громкость музыки
        {
            TrackBarValueChanged?.Invoke(trackBar5.Value); // Invoke - связующее между двумя процессами
        }
        private void Button1_Click(object sender, EventArgs e) // кнопка возвращения в главное меню 
        {
            this.Hide();
            Главноеменю главноеменю = (Главноеменю)Application.OpenForms[0];
            главноеменю.Show();
        }

    }
}

// ? - проверка ивента (изменилось ли?) Invoke - связь между окнами и передача значения TrackBar