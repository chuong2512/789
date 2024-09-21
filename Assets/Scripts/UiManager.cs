using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public static UiManager instance;
    public Text LevelText,secondmessage;
    public bool skinEnter;
    public GameObject ingamepanel;
    public GameObject playerSelectionPanel;
    public GameObject startpanel,gameplaypanel,losepanel,winpanel ,volumeOn,volumeOff;
    public AudioSource audioSource;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
     
        LevelText.text = "Level " + (gamemanager.instance.getLevel() + 1);
    }
 

    //public void skinmenu()
    //{
    //    // sound
    //    SoundManager.instance.Play("click");
    //    skinEnter = true;
    //    playerSelectionPanel.SetActive(true);
    //    ingamepanel.SetActive(false);
    //}

    public void btn_retry()
    {
        // sound
        //SoundManager.instance.Play("click");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
showAD();
    }
    public void Exit()
    {
        Application.Quit();
    }

    public void VolumeOff()
    {
        audioSource.mute = true;
        volumeOn.SetActive(true);
        volumeOff.SetActive(false);
    }
    public void VolumeOn()
    {
        audioSource.mute = false;
        volumeOff.SetActive(true);
        volumeOn.SetActive(false);
    }

    public void nextlvl()
    {
        gamemanager.instance.setLevel(gamemanager.instance.getLevel() + 1);
        if (gamemanager.instance.LevelsContenu.Length <= gamemanager.instance.getLevel())
            return;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
showAD();
    }

public void showAD(){
        Adcontrol.instace.showAd();
    }

}
