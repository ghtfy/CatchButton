# 버튼 잡기 게임 (C# 코딩)

## 개요
- C# 프로그래밍 학습
- 핵심 기능 : 버튼 컨트롤 영역 안으로 마우스가 들어갈 경우 버튼을 랜덤 위치로 이동하도록 합니다.
- 화면 구성 :

- ## 실행 화면
### 1단계 기본 도망 기능
 - 마우스를 `나를 잡아봐` 버튼으로 향하게 다가가면 도망가는 기능을 구현하였습니다.
 - **주의 사항** : 버튼의 (X,Y) 값을 수정하여 Text 상자 밖으로 `나를 잡아봐`가 벗어 나지 않게 범위를 수정해야 합니다.

![Image](https://github.com/user-attachments/assets/b101cedd-ac85-49d6-8b6e-de437011df1f)

### 2 단계 시작걱/청각적 피드백
 - 버튼을 잡았을 때 적절한 피드백을 주도록 구현하였습니다.
  **주의 사항**:`나를 잡아봐` 버튼을 클릭 할 경우에만 메시지 박스를 띄웁니다
  <img width="800" height="478" alt="스크린샷 2026-03-12 121843" src="https://github.com/user-attachments/assets/86a56310-2b32-48da-a73d-04968a2139f9" />

   
- 3 단계 점수 표시와 점수별 난이도 조정
  `나를 잡아봐` 버튼 클릭 성공 시 점수 추가 , 도망다니면 감점 10점 기능을 구현하였습니다.
  **주의 사항**
  " public partial class Form1 : Form" 바로 아랫부분에 int score = 0;을 넣어주지 않을 경우
  'score'의 이름이 컨텍스트에 없기 때문에 코드 실행의 오류가 생깁니다.
  
  <img width="794" height="477" alt="스크린샷 2026-03-12 124537" src="https://github.com/user-attachments/assets/5ad8ca2b-6cd4-4a64-bc11-748d5da45e7b" />

  
<img width="795" height="479" alt="스크린샷 2026-03-12 124558" src="https://github.com/user-attachments/assets/6e47311d-a4dd-42b2-befa-74f99b3849d1" />

- 4 단계 코드의 실행 스크린샷

## 구현 시 어려웠던 점
-컨드롤의 좌표를 계산하는 것,..
-인터넷 연결은 coilot의 도움을 받아...
