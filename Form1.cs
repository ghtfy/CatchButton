using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

 
        private void button1_MouseEnter(object sender, EventArgs e)
        {   // 1. 난수생성기준비
            Random rd= new Random();
            
            // 2. 가용영역계산(버튼이폼테두리에걸리지않게보호)
            // ClientSize는타이틀바와테두리를제외한실제흰도화지영역임
            int maxX= this.ClientSize.Width;
            int maxY= this.ClientSize.Height;

            // 3. 랜덤좌표추출(0 ~ 최대가용치사이)
            int nextX= rd.Next(0, 239); // 버튼의가로길이 max 239로제한
            int nextY= rd.Next(0, 120); // 버튼의세로길이 max 120로제한

            // 4. 위치할당(새로운Point 객체생성)
            RunButton.Location= new Point(nextX, nextY);

            // 5. 시각적피드백(폼제목표시줄에좌표출력)
            this.Text= $"버튼위치: ({nextX}, {nextY})";

        }

        private void RunButton_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
