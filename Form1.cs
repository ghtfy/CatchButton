using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Media; // 효과음 추가를 위한 코드 삽입

namespace CatchButton
{
    public partial class Form1 : Form
    {
        int score = 0; // 점수 표시를 위한 컨텍스트 선언
        int missCount = 0; //버튼을 놓친 횟수 저장 변수
        Size initialSize; // 처음 버튼 크기를 기억하는 변수

        //SoundPlayer escapeSound = new SoundPlayer("escape.wav"); // 도망 효과음
        //SoundPlayer catchSound = new SoundPlayer("catch.wav");   // 잡기 효과음


        public Form1()
        {
            InitializeComponent();
            initialSize = RunButton.Size; //시작 시 버튼 크기 저장
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
            missCount++; // 버튼 놓칠때 횟수 적용 코드

            //escapeSound.Play(); //도망 효과음 추가 

            this.Text = $"현재 점수: {score}점";

            if (missCount >= 20) //게임 오버 체크 코드
            {
                MessageBox.Show("Game Over! 20번 놓치셨습니다.", "게임 종료");
                //ResetGame(); // 게임 리셋하는 선언
                RunButton.Enabled = false;// 게임 오버시 버튼 비활성 코드 

                return;      // 더 이상 아래 도망 로직을 실행하지 않음
            }
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            //점수 추가 표시
            score += 100;

            //catchSound.Play(); //잡기 효과음


            this.Text = $"현재 점수: {score}점";

            // 2. 난이도 조절: 버튼 크기를 10% 축소 (현재 크기의 90%로 설정)
            int newWidth = (int)(RunButton.Width * 0.9);
            int newHeight = (int)(RunButton.Height * 0.9);

            RunButton.Size = new Size(newWidth, newHeight);//새 버튼 크기 적용

            //메세지 박스 클릭시 메시지 띄우기
            MessageBox.Show("축하합니다~!", "성공"); 
            
        }
        private void ResetGame()
        {
            score = 0;             // 점수 초기화
            missCount = 0;         // 놓친 횟수 초기화
            RunButton.Size = initialSize; // 버튼 크기를 처음 상태로 복구
            RunButton.Location = new Point(100, 100); // 버튼 위치를 적당한 곳으로 이동

            RunButton.Enabled = true;//게임 재시작 버튼 
            this.Text = "게임을 다시 시작합니다!";
        }

        // ★ 추가: [다시 시작] 버튼을 따로 클릭했을 때 호출
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
