using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public GameObject pauseGame;
    public bool getPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        pauseGame.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setPaused()
    {
        if (getPaused == true)
        {
            Time.timeScale = 0;
            pauseGame.SetActive(true);
            getPaused = false;
        }

        else if (getPaused == false)
        {
            Time.timeScale = 1;
            pauseGame.SetActive(false);
            getPaused = true;
        }
    }
}
