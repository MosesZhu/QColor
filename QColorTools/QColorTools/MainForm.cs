using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QColorTools
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            UnBindEvent();
            Color c = panelColor.BackColor;
            this.tbxR.Text = c.R.ToString();
            this.tbxG.Text = c.G.ToString();
            this.tbxB.Text = c.B.ToString();
            this.tbxColorString.Text = ConvertColorToString(c);
            BindEvent();
        }

        private void btnStraw_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height);
            Graphics g = Graphics.FromImage(bitmap);
            g.CopyFromScreen(0, 0, 0, 0, bitmap.Size);

            using (StrawForm strawForm = new StrawForm(bitmap, this.panelColor))
            {
                strawForm.ShowDialog();
            }
        }

        public void BindEvent()
        {
            this.panelColor.BackColorChanged += panelColor_BackColorChanged;
            this.tbxColorString.TextChanged += SingleChannel_TextChanged;
            this.tbxR.TextChanged += SingleChannel_TextChanged;
            this.tbxG.TextChanged += SingleChannel_TextChanged;
            this.tbxB.TextChanged += SingleChannel_TextChanged;
        }

        public void UnBindEvent()
        {
            this.panelColor.BackColorChanged -= panelColor_BackColorChanged;
            this.tbxColorString.TextChanged -= SingleChannel_TextChanged;
            this.tbxR.TextChanged -= SingleChannel_TextChanged;
            this.tbxG.TextChanged -= SingleChannel_TextChanged;
            this.tbxB.TextChanged -= SingleChannel_TextChanged;
        }

        private void panelColor_BackColorChanged(object sender, EventArgs e)
        {
            UnBindEvent();

            Color c = panelColor.BackColor;
            this.tbxR.Text = c.R.ToString();
            this.tbxG.Text = c.G.ToString();
            this.tbxB.Text = c.B.ToString();
            this.tbxColorString.Text = ConvertColorToString(c);

            BindEvent();
        }

        public string ConvertColorToString(Color color)
        {
            return DtoX(color.R) + DtoX(color.G) + DtoX(color.B);
        }

        private string DtoX(int d)
        {
            string x = "";
            if (d < 16)
            {
                x = chang(d);
            }
            else
            {
                int c;

                int s = 0;
                int n = d;
                int temp = d;
                while (n >= 16)
                {
                    s++;
                    n = n / 16;
                }
                string[] m = new string[s];
                int i = 0;
                do
                {
                    c = d / 16;
                    m[i++] = chang(d % 16);//判断是否大于10，如果大于10，则转换为A~F的格式 
                    d = c;
                } while (c >= 16);
                x = chang(d);
                for (int j = m.Length - 1; j >= 0; j--)
                {
                    x += m[j];
                }
            }
            if (x.Length == 1)
            {
                x = "0" + x;
            }
            return x;
        }

        private string chang(int d)
        {
            string x = "";
            switch (d)
            {
                case 10:
                    x = "A";
                    break;
                case 11:
                    x = "B";
                    break;
                case 12:
                    x = "C";
                    break;
                case 13:
                    x = "D";
                    break;
                case 14:
                    x = "E";
                    break;
                case 15:
                    x = "F";
                    break;
                default:
                    x = d.ToString();
                    break;
            }
            return x;
        }

        private void tbxColorString_TextChanged(object sender, EventArgs e)
        {

        }

        private void SingleChannel_TextChanged(object sender, EventArgs e)
        {
            UnBindEvent();

            int R = Convert.ToInt32(this.tbxR.Text);
            int G = Convert.ToInt32(this.tbxG.Text);
            int B = Convert.ToInt32(this.tbxB.Text);
            Color c = Color.FromArgb(R, G, B);

            panelColor.BackColor = c;
            this.tbxColorString.Text = ConvertColorToString(c);

            BindEvent();
        }

        private void btnPalette_Click(object sender, EventArgs e)
        {
            ColorDialog dlgColor = new ColorDialog();
            dlgColor.AllowFullOpen = true;
            dlgColor.Color = panelColor.ForeColor;

            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                panelColor.ForeColor = dlgColor.Color;
                this.tbxR.Text = panelColor.ForeColor.R.ToString();
                this.tbxG.Text = panelColor.ForeColor.G.ToString();
                this.tbxB.Text = panelColor.ForeColor.B.ToString();
                this.tbxColorString.Text = ConvertColorToString(panelColor.ForeColor);
            }
        }
    }
}
