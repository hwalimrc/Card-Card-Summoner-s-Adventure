using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject Target; // 카메라가 따라갈 대상.
    public float moveSpeed; // 카메라가 얼마나 빠른 속도로 대상을 쫓을 것인가?.
    private Vector3 targetPosition; // 대상의 현재 위치값.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() // 카메라는 매 프레임 마다 대상을 따라가야 함.
    {
        if (Target.gameObject != null)
        {
            targetPosition.Set(Target.transform.position.x, Target.transform.position.y, 
                this.transform.position.z); // this->카메라를 가리킨다.

            this.transform.position = Vector3.Lerp(this.transform.position, 
                targetPosition, moveSpeed * Time.deltaTime); // 1초의 moveSpeed 만큼 이동,
            

        }
    }
}
