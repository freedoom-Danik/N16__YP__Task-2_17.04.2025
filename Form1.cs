using System;
using System.Drawing;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace N16__YP__Task_2_17._04._2025
{
    public partial class Form1 : Form
    {
        private int snowflakeY = -50; // ��������� ������� ��������

        public Form1()
        {
            InitializeComponent();
            Timer timer = new Timer { Interval = 50 };
            timer.Tick += (s, e) => UpdateSnowflakePosition();
            timer.Start();
        }

        private void UpdateSnowflakePosition()
        {
            snowflakeY += 5; // �������� �������
            if (snowflakeY > ClientSize.Height) snowflakeY = -50; // ����������� ���������
            Invalidate(); // ����������� �����
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Pen pen = new Pen(Color.Blue))
            using (SolidBrush brush = new SolidBrush(Color.White))
            {
                e.Graphics.DrawEllipse(pen, 100, snowflakeY, 20, 20); // ������ ��������
                e.Graphics.FillEllipse(brush, 100, snowflakeY, 20, 20);
            }
        }
    }
}