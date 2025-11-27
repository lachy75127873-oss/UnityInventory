📦 UnityInventory
내일배움캠프 Unity 심화 주차 개인 과제 – 인벤토리 시스템 구현 프로젝트(2025.11.24~11.28)

📘 프로젝트 소개
다음의 구현을 목적으로 진행한 프로젝트입니다.
1. 메인화면 / 상태창 / 인밴토리 UI 생성및 화면 전환.
2. 플레이어 생성 및 Json을 이용한 정보 저장 및 로드.
3. ScriptableObject를 통한 아이템 정보 관리.
4. 동적생성 구조를 통한 구현

⭐ 구현 내용
ManagerRoot와 SceneInitializer를 통한 씬 초기화 및 오브젝트 생성 진행
<img width="1820" height="1540" alt="image" src="https://github.com/user-attachments/assets/6626493b-f137-4d5f-9a6c-42f17e0670e7" />

메인 화면
<img width="1262" height="714" alt="image" src="https://github.com/user-attachments/assets/4d35f84c-022d-4f62-90f5-d3f29831e3bf" />

상태창
<img width="1262" height="714" alt="image" src="https://github.com/user-attachments/assets/647543c1-5bd8-4f32-9754-ebe1b80ab3c2" />

인밴토리
<img width="1262" height="714" alt="image" src="https://github.com/user-attachments/assets/b856a44b-aaf2-48e1-a23d-cca43a8ec44e" />

시네머신을 통한 회전 연출
<img width="1262" height="1518" alt="image" src="https://github.com/user-attachments/assets/a3566d82-a54b-4192-a76b-eb0a7a08a865" />

🧪 개발 과정 & 트러블슈팅
https://dw990207.tistory.com/
40일차 ~ 43일차 TIL에 해당 내용 정리

'인벤토리 UI'구현 과제에서는 UNITY의 새로운 기능 보다는, 참조와 객체에 대한 문제가 주로 발생했습니다.
다양한 참조 오류들이 있었지만, 대부분 어떤 대상(객체)를 어느 시점(초기화)에 참조하는가의 문제로 이어졌습니다.

특히 Interface를 상속받은 Initializer를 통해서 특정 씬을 초기화하고, Resources로드를 통해 객체를
동적으로 생성하는 구조로 프로그래밍해보면서, 시간은 다소 걸렸어도 참조오류의 원인을 명확하게 파악할 수 있었습니다.

다양한 기능을 구현하지는 못했지만, Initializer이용과 Json을 처음 다뤄봤다는 점에서 좋은 경험이었습니다.

🔸 AssetReference
Font: <Norumbega font> by <stormgold>
UI pack: RPG extension by Kenney Vleugels
KayKit : Adventurers Character Pack (2.0)
icons pack : shikashi's fantasy
