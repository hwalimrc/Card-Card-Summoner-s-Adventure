using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laber : MonoBehaviour
{
    public static bool laberOpen = false;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Hero")
        {
            if(laberOpen == false) laberOpen = true;
        }
    }
}