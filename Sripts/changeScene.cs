using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    /*int resolution;
    bool toggle;
    bool fullScreen;*/
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void openSettings()
    {
        SceneManager.LoadScene(2);
    }
    /*public void setSettings()
    {
        /*resolution = PlayerPrefs.GetInt("resolutionNumber", resolutionSettings.resolutionValue.value);
        toggle = PlayerPrefs.GetInt("screenToggle isOn") == 1 ? true : false;
        fullScreen = PlayerPrefs.GetInt ("fullScreen?") == 1 ? true : false;
    }
    public void Awake()
    {
        setSettings();
        
    }*/
}
