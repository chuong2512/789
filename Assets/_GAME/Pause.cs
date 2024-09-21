using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    public GameObject panel;


    void Start()
    {
       // panel = GameObject.FindGameObjectsWithTag("pause");
    }

        public void PauseGame()
    {
        Time.timeScale = 0;
        panel.SetActive(true);
showAD();
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        panel.SetActive(false);
    }


public void showAD(){
        //AdsManager.instance.ShowInterstitial();
    }
}
