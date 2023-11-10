using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        private char _islem;
        bool _ekranTemizlenecekMi;
        int _ilksayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void rakam1Button_Click_1(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "1";
        }
        private void rakam2Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "2";
        }

        private void rakam3Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "3";
        }

        private void rakam4Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "4";
        }

        private void rakam5Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "5";
        }

        private void rakam6Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "6";
        }

        private void rakam7Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "7";
        }

        private void rakam8Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "8";
        }

        private void rakam9Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "9";
        }

        private void rakam0Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "0";
        }

        private void toplaButton_Click_1(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizlenecekMi = true;
            _ilksayi = Convert.ToInt32(ekranLabel.Text);
        }
        private void cikarButton_Click_1(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizlenecekMi = true;
            _ilksayi = Convert.ToInt32(ekranLabel.Text);
        }
        private void silButton_Click_1(object sender, EventArgs e)
        {
            ekranLabel.Text = "";
        }

        private void esittirButton_Click(object sender, EventArgs e)
        {
            int ikinciSayi = Convert.ToInt32(ekranLabel.Text);
            int sonuc;
            switch(_islem)
            {
                case '+':
                    sonuc = _ilksayi + ikinciSayi;
                    break;
                case '-':
                    sonuc = _ilksayi - ikinciSayi;
                    break;
                case '*':
                    sonuc = _ilksayi * ikinciSayi;
                    break;
                case '/':
                    sonuc = _ilksayi / ikinciSayi;
                    break;
                default:
                    sonuc = 0;
                    break;
            }
            ekranLabel.Text = Convert.ToString(sonuc);
        }

        private void bolButton_Click_2(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizlenecekMi = true;
            _ilksayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void carpButton_Click_1(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTemizlenecekMi = true;
            _ilksayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.D1) 
            {
                if (_ekranTemizlenecekMi)
                {
                    ekranLabel.Text = "";
                    _ekranTemizlenecekMi = false;
                }
                if (ekranLabel.Text == "0") ekranLabel.Text = "";
                ekranLabel.Text += "1";
            }
            else if (e.KeyCode == Keys.D2)
            {
                if (_ekranTemizlenecekMi)
                {
                    ekranLabel.Text = "";
                    _ekranTemizlenecekMi = false;
                }
                if (ekranLabel.Text == "0") ekranLabel.Text = "";
                ekranLabel.Text += "2";
            }
            else if (e.KeyCode == Keys.D3)
            {
                if (_ekranTemizlenecekMi)
                {
                    ekranLabel.Text = "";
                    _ekranTemizlenecekMi = false;
                }
                if (ekranLabel.Text == "0") ekranLabel.Text = "";
                ekranLabel.Text += "3";
            }
            else if (e.KeyCode == Keys.D4)
            {
                if (_ekranTemizlenecekMi)
                {
                    ekranLabel.Text = "";
                    _ekranTemizlenecekMi = false;
                }
                if (ekranLabel.Text == "0") ekranLabel.Text = "";
                ekranLabel.Text += "4";
            }
            else if (e.KeyCode == Keys.D5)
            {
                if (_ekranTemizlenecekMi)
                {
                    ekranLabel.Text = "";
                    _ekranTemizlenecekMi = false;
                }
                if (ekranLabel.Text == "0") ekranLabel.Text = "";
                ekranLabel.Text += "5";
            }
            else if (e.KeyCode == Keys.D6)
            {
                if (_ekranTemizlenecekMi)
                {
                    ekranLabel.Text = "";
                    _ekranTemizlenecekMi = false;
                }
                if (ekranLabel.Text == "0") ekranLabel.Text = "";
                ekranLabel.Text += "6";
            }
            else if (e.KeyCode == Keys.D7)
            {
                if (_ekranTemizlenecekMi)
                {
                    ekranLabel.Text = "";
                    _ekranTemizlenecekMi = false;
                }
                if (ekranLabel.Text == "0") ekranLabel.Text = "";
                ekranLabel.Text += "7";
            }
            else if (e.KeyCode == Keys.D8)
            {
                if (_ekranTemizlenecekMi)
                {
                    ekranLabel.Text = "";
                    _ekranTemizlenecekMi = false;
                }
                if (ekranLabel.Text == "0") ekranLabel.Text = "";
                ekranLabel.Text += "8";
            }
            else if (e.KeyCode == Keys.D9)
            {
                if (_ekranTemizlenecekMi)
                {
                    ekranLabel.Text = "";
                    _ekranTemizlenecekMi = false;
                }
                if (ekranLabel.Text == "0") ekranLabel.Text = "";
                ekranLabel.Text += "9";
            }
            else if (e.KeyCode == Keys.D0)
            {
                if (_ekranTemizlenecekMi)
                {
                    ekranLabel.Text = "";
                    _ekranTemizlenecekMi = false;
                }
                if (ekranLabel.Text == "0") ekranLabel.Text = "";
                ekranLabel.Text += "0";
            }
            else if (e.KeyCode == Keys.Delete)
            {
                ekranLabel.Text = "";
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                _islem = '*';
                _ekranTemizlenecekMi = true;
                _ilksayi = Convert.ToInt32(ekranLabel.Text);
            }
            //En son Klavyeden basılınca rakamların etkinleştirilmesi yapıldı
        }
    }
}
