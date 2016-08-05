using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Reflection;

namespace QColorTools
{
    public partial class StrawForm : Form
    {
        Panel mPanelColor;
        Bitmap mOriImage;
        Bitmap mCrossImage;
        Bitmap mTempImage;
        Pen pnLine = new Pen(Color.Black);
        public StrawForm(Bitmap background, Panel panelColor)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);//以下三行消除主界面闪烁
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);

            InitializeComponent();
            this.mOriImage = background;
            this.mPanelColor = panelColor;
            this.mCrossImage = 
                this.mOriImage.Clone(new RectangleF(0, 0, this.mOriImage.Width, this.mOriImage.Height), this.mOriImage.PixelFormat);
            this.mTempImage = new Bitmap(this.mOriImage.Width, this.mOriImage.Height, PixelFormat.Format32bppArgb);

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.BackgroundImage = this.mCrossImage;
        }

        private void StrawForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape) 
            {
                this.Close();
            }            
        }

        [DllImport("user32.dll")]
        public static extern IntPtr LoadCursorFromFile(string fileName);

        [DllImport("user32.dll")]
        public static extern IntPtr SetCursor(IntPtr cursorHandle);

        [DllImport("user32.dll")]
        public static extern uint DestroyCursor(IntPtr cursorHandle);

        public void LoadCursor()
        { 
            Cursor myCursor = new Cursor(Cursor.Current.Handle);
            IntPtr colorCursorHandle = LoadCursorFromFile("straw.cur");
            myCursor.GetType().InvokeMember("handle", BindingFlags.Public |
                BindingFlags.NonPublic | BindingFlags.Instance |
                BindingFlags.SetField, null, myCursor,
                new object[] { colorCursorHandle });
            this.Cursor = myCursor;
        }

        private void StrawForm_MouseMove(object sender, MouseEventArgs e)
        {
            //Cursor.Current = Cursors.Hand;
            LoadCursor();
            using (Graphics g = Graphics.FromImage(this.mTempImage))
            {
                g.Clear(Color.Transparent);
                g.DrawImage(this.mOriImage, new Point(0, 0));
                g.DrawLine(pnLine, new Point(0, e.Y), new Point(mCrossImage.Width, e.Y));
                g.DrawLine(pnLine, new Point(e.X, 0), new Point(e.X, mCrossImage.Height));                
            }

            using (Graphics g = Graphics.FromImage(this.mCrossImage))
            {
                g.Clear(Color.Transparent);
                g.DrawImage(this.mTempImage, 0, 0);
            }

            this.Refresh();
        }

        private void StrawForm_Click(object sender, EventArgs e)
        {
            if (((MouseEventArgs)e).Button == System.Windows.Forms.MouseButtons.Left)
            {
                Point clickPoint = new Point(((MouseEventArgs)e).X, ((MouseEventArgs)e).Y);
                Color c = this.mOriImage.GetPixel(clickPoint.X, clickPoint.Y);
                this.mPanelColor.BackColor = c;
                this.Close();
            }
            else 
            {
                this.Close();
            }           
        }

        private void StrawForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        private void StrawForm_Load(object sender, EventArgs e)
        {
            //Cursor.Current = Cursors.Hand;
            LoadCursor();
        }
    }
}
