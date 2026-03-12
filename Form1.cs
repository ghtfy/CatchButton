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
        int score = 0; // 점수 표시를 위한 컨텍스트 선언
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

            //도망가는 점수 감점 10점 
            score -= 10;
            this.Text = $"현재 점수: {score}점";
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            //점수 추가 표시
            score += 100;
            this.Text = $"현재 점수: {score}점";

            // 2. 난이도 조절: 버튼 크기를 10% 축소 (현재 크기의 90%로 설정)
            int newWidth = (int)(RunButton.Width * 0.9);
            int newHeight = (int)(RunButton.Height * 0.9);

            //메세지 박스 클릭시 메시지 띄우기
            MessageBox.Show("축하합니다~!", "성공"); 
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
