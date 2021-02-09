using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media; 

namespace PlayGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PlayGameButton_Click(object sender, EventArgs e)
        {
            SoundPlayer EndPlayer = new SoundPlayer(Properties.Resources.StartupSound);

            GameStartLabel1.Visible = false;
            GameStartLabel1.Text = "Game Starting in 3";
            Refresh();
            SoundPlayer AlertPlayer = new SoundPlayer(Properties.Resources.ding);
            AlertPlayer.Play();
            Thread.Sleep (1000);
            
            GameStartLabel1.Text = "Game Starting in 3..2";
            Refresh();
            AlertPlayer.Play();
            Thread.Sleep (1000);

            GameStartLabel1.Text = "Game Starting in 3..2..1";
            Refresh();
            AlertPlayer.Play();
            Thread.Sleep (1000);

            GameStartLabel1.Text = "Begin!";
            Refresh();

            EndPlayer.Play();
            Thread.Sleep(500);
            GameStartLabel1.Text = "";

            
        }

        private void GameStartLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
