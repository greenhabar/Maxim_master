using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;


namespace WindowsFormsApp1
{
    public partial class Главноеменю : Form
    {
        Настройки sett;
        Запуск begin;
        public int volume = 50; // громкость музыки
        public int volumecharacter = 50; // громкость персонажа
        public int volumesounds = 50; // громкость звуков
        private WaveOutEvent waveOut; // непосредственно инициализирует воспроизведение мелодию 
        private AudioFileReader audioFileReader; // для считывания аудиофайла
        public Главноеменю()
        {
            InitializeComponent();
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    // Загрузка изображения персонажа
        //    Bitmap bitmap = new Bitmap("path_to_character_image.jpg");
             
        //    // Отображение изображения в PictureBox
        //    pictureBox1.Image = bitmap;
        //}

        private void Button1_Click(object sender, EventArgs e) // переход на форму запуска игры 
        {
            this.Hide();
            begin = new Запуск();
            begin.ShowDialog();
            this.Show();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            this.Hide(); // скрывает главное меню 
            sett = new Настройки(volume);
            sett.TrackBarValueChanged += TrackChange;
            sett.ShowDialog();
            this.Show();
            
        }

        private void TrackChange(int Mus) // используем для отслеживания и изменения громесоти или подписка на изменения
        {
            volume = Mus;
            if (waveOut != null)
            {
                waveOut.Volume = (float)volume / 100f; //  waveOut.Volume  воспринимает от 0 до 1 float - делает одно число дробным делим на 100, чтобы не нарушать условия (от 0 до 1)
            }
        }

        private void MusicPlay(object sender, EventArgs e)
        {
            if (waveOut == null)
            {
                waveOut = new WaveOutEvent();
                AudioFileReader audioFileReader = new AudioFileReader("Путь до файла");
                waveOut.Init(audioFileReader); // передаётся конвертированная музыка в waveout
                waveOut.Volume = (float)volume / 100f; // чтобы воспроизводил громкость по умолчанию 
                // (1)waveOut.PlaybackStopped += (2)WaveOut_PlaybackStoppeed; - (1) событие остановки музыки (2) метод для повторного произведения
                waveOut.Play();
            }
            else
            {
                waveOut.Play();
            }

        }

        private void button5_Click(object sender, EventArgs e) // выход из игры 
        {
            this.Close();
        }
    }
}
