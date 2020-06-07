using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Game
{
    public partial class Form1 : Form
    {
        Game obj_game = new Game();

        int count=0, rndm=0,countnext=0;
        Random rd = new Random();

        public Form1()
        {
            InitializeComponent();
            rndm = rd.Next(1, 6);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_Load.Enabled = true;
            btn_spin.Enabled = false;
            btn_shoot.Enabled = false;
            btn_shootAway.Enabled = false;
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {

            obj_game.Load();
            //code to display image in picture box on button click 
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("Simple_Game.Resources.Load.gif");
            Bitmap bmp = new Bitmap(myStream);
            gamegif_PictureBox.Image = bmp;

            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(Properties.Resources.Load1);
            snd.Play();

            btn_Load.Enabled = false;
            btn_spin.Enabled = true;
            btn_shoot.Enabled = false;
            btn_shootAway.Enabled = false;

        }

        private void btn_spin_Click(object sender, EventArgs e)
        {
            obj_game.Spin();
            //code to display image in picture box on button click 
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("Simple_Game.Resources.Spin.gif");
            Bitmap bmp = new Bitmap(myStream);
            gamegif_PictureBox.Image = bmp;

            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(Properties.Resources.Spin1);
            snd.Play();

            btn_Load.Enabled = false;
            btn_spin.Enabled = false;
            btn_shoot.Enabled = true;
            btn_shootAway.Enabled = true;
        }

        private void btn_shoot_Click(object sender, EventArgs e)
        {
            obj_game.Shoot();
            count++;

            //code to display image in picture box on button click 
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("Simple_Game.Resources.Shoot.gif");
            Bitmap bmp = new Bitmap(myStream);
            gamegif_PictureBox.Image = bmp;

            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(Properties.Resources.Shoot1);
            snd.Play();


            if (count==rndm) {
                MessageBox.Show("Your are died");
                btn_shoot.Enabled = false;
                btn_shootAway.Enabled = false;
            }
            else {
                MessageBox.Show("You are safe ");
            }

            if (count==4) {
                btn_shoot.Enabled = false;
                
            }

            btn_Load.Enabled = false;
            btn_spin.Enabled = false;


        }

        private void btn_shootAway_Click(object sender, EventArgs e)
        {
            obj_game.ShootAway();
            countnext++;

            //code to display image in picture box on button click 
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("Simple_Game.Resources.ShootAway.gif");
            Bitmap bmp = new Bitmap(myStream);
            gamegif_PictureBox.Image = bmp;

            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(Properties.Resources.ShootAway1);
            snd.Play();
            if (countnext<2) {
                MessageBox.Show("you saved");
            }
            else{
                
                btn_spin.Enabled = false;
                btn_shoot.Enabled = false;
                btn_shootAway.Enabled = false;
            }

        }

        private void btn_Playagain_Click(object sender, EventArgs e)
        {
            //code to display image in picture box on button click 
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("Simple_Game.Resources.playagain.png");
            Bitmap bmp = new Bitmap(myStream);
            gamegif_PictureBox.Image = bmp;
            btn_Load.Enabled = true;
        }
    }
}
