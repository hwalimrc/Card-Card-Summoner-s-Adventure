using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openGate : MonoBehaviour
{
    public GameObject 레버_닫힌상태;
    public GameObject 레버_열린상태;

    public GameObject 문_열린상태;
    public GameObject 문_닫힌상태;

    public bool 몬스터;
    // Start is called before the first frame update
    void Start()
    {
        문_열린상태.SetActive(false);
        레버_열린상태.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Laber.laberOpen == true)
        {
            레버_열린상태.SetActive(true);
            레버_닫힌상태.SetActive(false);
            문_열린상태.SetActive(true);
            문_닫힌상태.SetActive(false);
        }
    }
}
