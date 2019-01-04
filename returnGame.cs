using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class returnGame : MonoBehaviour
{
    public void 돌아가기()
    {
        SceneManager.LoadScene("Stage(1)");
    }
}