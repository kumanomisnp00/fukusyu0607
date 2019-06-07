using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukusyu0607
{
    public partial class Form1 : Form
    {
        //疑似乱数
        //ランダムのシードを指定して初期化したら
        //それを使い続ける
        private static Random rand = new Random();
        int vx = rand.Next(-10, 11);
        int vy = rand.Next(-10, 11);
        int vx1 = rand.Next(-10, 11);
        int vy1 = rand.Next(-10, 11);
        int vx2 = rand.Next(-10, 11);
        int vy2 = rand.Next(-10, 11);

        int time = 100 * 5;

        public Form1()
        {
            InitializeComponent();
            //以下に、label1.Leftとlabel1.topの座標をランダムで求める
            label1.Left = rand.Next(ClientSize.Width - label1.Width);
            label1.Top = rand.Next(ClientSize.Width - label1.Height);

            label2.Left = rand.Next(ClientSize.Width - label2.Width);
            label2.Top = rand.Next(ClientSize.Width - label2.Height);

            label3.Left = rand.Next(ClientSize.Width - label3.Width);
            label3.Top = rand.Next(ClientSize.Width - label3.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {   
            label1.Left += vx;
            label1.Top += vy;

            label2.Left += vx1;
            label2.Top += vy1;

            label3.Left += vx2;
            label3.Top += vy2;



             //マウスが重なったらタイマーを止める
            Point p = PointToClient(MousePosition);

             if ((p.X> label1.Left)
             && (p.X < label1.Right)
             &&(p.Y > label1.Top)
             && (p.Y < label1.Bottom))

              timer1.Enabled = false;

             if ((p.X > label2.Left)
             && (p.X < label2.Right)
             && (p.Y > label2.Top)
             && (p.Y < label2.Bottom))

              timer1.Enabled = false;

             if ((p.X > label3.Left)
              && (p.X < label3.Right)
              && (p.Y > label3.Top)
              && (p.Y < label3.Bottom))

              timer1.Enabled = false;
            
            if(label1.Left<0)
            {
                vx = Math.Abs(vx);
            }
            if(label1.Top<0)
            {
                vy = Math.Abs(vy);
            }
            if(label1.Right>ClientSize.Width)
            {
                vx = Math.Abs(vx);
            }
            if(label1.Top>ClientSize.Width)
            {
                vx = -Math.Abs(vy);
            }

            if(label1.Left<ClientSize.Width)
            {
                vx = -Math.Abs(vx);
            }
            if(label1.Bottom<ClientSize.Width)
            {
                vy = Math.Abs(vy);
            }
            /////////////////////////////////3
            /////////////////////////////////
            if(label2.Right>ClientSize.Width)
            {
                vx1 = Math.Abs(vx1);
            }
            if(label2.Top>ClientSize.Width)
            {
                vx1 = -Math.Abs(vy1);
            }

            if(label2.Left<ClientSize.Width)
            {
                vx1 = -Math.Abs(vx1);
            }
            if (label2.Bottom < ClientSize.Width)
            {
                vy1 = Math.Abs(vy1);
            }
            /////////////////////////////////////3
            /////////////////////////////////////
            if (label3.Right > ClientSize.Width)
            {
                vx2 = Math.Abs(vx2);
            }
            if (label3.Top > ClientSize.Width)
            {
                vx2 = -Math.Abs(vy2);
            }

            if (label3.Left < ClientSize.Width)
            {
                vx2 = -Math.Abs(vx2);
            }
            if (label3.Bottom < ClientSize.Width)
            {
                vy2 = Math.Abs(vy2);
            }
            
        }
    }
}
