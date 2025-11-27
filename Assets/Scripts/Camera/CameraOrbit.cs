using Cinemachine;
using UnityEngine;

public class CameraOrbit : MonoBehaviour
{
    [SerializeField] private Transform target;   // 중심이 될 캐릭터
    [SerializeField] private float radius = 4f;  // 거리
    [SerializeField] private float height = 1.5f; // 높이
    [SerializeField] private float speed = 20f;  // 초당 회전 각도 (도 단위)

    private float _angle;
    
    private CinemachineVirtualCamera  virtualCamera;

    private void Start()
    {
        //타겟 등록
        target = GameManager.Instance.Player.transform;
        
        //가상 카메라 참조
        virtualCamera = GetComponentInChildren<CinemachineVirtualCamera>();
        
        if (target == null)
        {
            Debug.LogWarning("CameraOrbit: target이 비어있습니다.");
            return;
        }
        
        //대상 지정
        virtualCamera.Follow  = target;
        virtualCamera.LookAt = target;

        // 시작 각도에서 한 번 위치 세팅
        UpdatePosition();
    }

    private void LateUpdate()
    {
        if (target == null) return;

        // 시간에 따라 각도 증가
        _angle += speed * Time.deltaTime;

        UpdatePosition();
    }

    private void UpdatePosition()
    {
        // 각도(도)를 라디안으로 변환
        float rad = _angle * Mathf.Deg2Rad;

        // target 주변 원 궤적 계산 (XZ 평면)
        Vector3 offset = new Vector3(
            Mathf.Sin(rad) * radius,
            height,
            Mathf.Cos(rad) * radius
        );

        transform.position = target.position + offset;

        // 항상 target을 바라보게
        transform.LookAt(target.position + Vector3.up * height);
    }
}