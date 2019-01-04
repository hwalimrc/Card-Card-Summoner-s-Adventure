using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shop : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Hero")
        { SceneManager.LoadScene("상점"); }
    }

    public void 돌아가기()
    {
        SceneManager.LoadScene("Stage(1)");
    }
}
