using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telpo : MonoBehaviour
{
    public Transform Target;
 
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Hero")
        {
            col.transform.position = Target.position; // 부딪힌 객체를 타겟의 위치로 보낸다.
        }
    }
}
