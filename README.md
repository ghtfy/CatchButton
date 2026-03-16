# 버튼 잡기 게임 (C# 코딩)

## 개요
- C# 프로그래밍 학습
- 핵심 기능

1. 마우스가 `나를 잡아봐` 버튼 영역으로 접근 시 도망갑니다.
2. `나를 잡아봐` 버튼을 잡을 시 메시지 박스를 출력합니다.
3. 버튼 클릭 성공 점수가 증가하며 클릭 실패 시 점수가 감소합니다.
4. 점수에 따라 난이도가 달라지도록 (`나를 잡아봐`버튼 축소) 합니다.
  
- 화면 구성 
1. 메인 타겟  `나를 잡아봐`를 클릭.
2. 점수 출력 `This.Text`부분에 나의 점수 결과가 표시됩니다.
3. 배경 영역 `Form`부분에 버튼의 움직이는 전체 영역이 됩니다.


- ## 실행 화면
### 1단계 기본 도망 기능
 - 마우스를 `나를 잡아봐` 버튼으로 향하게 다가가면 도망가는 기능을 구현하였습니다.
 - **주의 사항** : 버튼의 (X,Y) 값을 수정하여 Text 상자 밖으로 `나를 잡아봐`가 벗어 나지 않게 범위를 수정해야 합니다.
   마우스 커서가 버튼영역(`Mouse Enter`)에 진입 시 랜덤 좌표로 이동하도록 구현합니다.
<img width="997" height="599" alt="Image" src="https://github.com/user-attachments/assets/c49d304f-73fe-439f-96ec-22b5b66c6643" />


### 2 단계 시각적/청각적 피드백
 - 버튼을 잡았을 때 적절한 피드백을 주도록 구현하였습니다.
- **주의 사항**:`나를 잡아봐` 버튼을 클릭 할 경우에만 메시지 박스를 띄웁니다
마우스가 닿을경우가 아닌 클릭(`click`) 이벤트가 발생 시에만 메세지 박스를 띄우도록 설정합니다.
  
<img width="997" height="601" alt="Image" src="https://github.com/user-attachments/assets/22036352-71a5-4ceb-87d6-272b86f750cc" />

   
### 3 단계 점수 표시와 점수별 난이도 조정
  - `나를 잡아봐` 버튼 클릭 성공 시 점수 추가 , 도망다니면 감점 10점 기능을 구현하였습니다.
  - 버튼 클릭 성공 시 난이도 조절을 위해 `나를 잡아봐` 버튼이 축소 되도록 기능을 구현하였습니다.
  - **주의 사항**
  " public partial class Form1 : Form" 바로 아랫부분에 int score = 0;을 넣어주지 않을 경우
  'score'의 이름이 컨텍스트에 없기 때문에 코드 실행의 오류가 생깁니다.
  
<img width="794" height="477" alt="스크린샷 2026-03-12 124537" src="https://github.com/user-attachments/assets/5ad8ca2b-6cd4-4a64-bc11-748d5da45e7b" />
  
<img width="795" height="479" alt="스크린샷 2026-03-12 124558" src="https://github.com/user-attachments/assets/6e47311d-a4dd-42b2-befa-74f99b3849d1" />

<img width="1001" height="600" alt="Image" src="https://github.com/user-attachments/assets/03fa00fa-5bb5-49d8-982c-79383ad6f8c1" />

### `나를 잡아봐` 버튼을 20회 놓쳤을 시 게임오버 기능 구현
- **주의 사항**
  ```csharp
  missCount++; 를 넣지 않을 시 버튼을 놓친 횟수를 인식하지 못해 `게임오버` 버튼이 구현 안 됩니다.
  RunButton.Enabled = true; 코드를 삽입하여 재시작시 버튼이 활성화 하도록 하였습니다
<img width="997" height="595" alt="Image" src="https://github.com/user-attachments/assets/7c46a354-81dc-4b7a-b194-d77350aa5ed9" />

## 구현 시 어려웠던 점
- 좌표값을 계산 후 `나를 잡아봐` 버튼이 폼 영역 밖으로 벗어나지 않도록 값을 적절한 값을 대입하는 부분이 어려웠습니다.
- 코딩 작업 중 어려운 사항은 visual studio 내 GitHub Copilot의 도움을 받아 오류 수정 및 작성을 하였습니다.
