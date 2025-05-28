using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject mainMenu, settingsMenu;
    public AudioSource audioSource;
    public Slider slider1;
    public Slider volume1;

    public void Start()
    {
        slider1.value = audioSource.volume;
       // slider1.onValueChanged.AddListener(AudioVolumeChange);

    }
    public void OnclickStartButton()
    {
        SceneManager.LoadScene("Playground");
    }
    public void OnclickQuit()
    {
        Application.Quit();
    }
    public void OnclickReturnToMainMenu()
    {
        mainMenu.SetActive(true);
        settingsMenu.SetActive(false);
    }

    public void OnclickSettingsButton()
    {
        mainMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }

    public void  AudioVolumeChange(float volume)
    {
       // audioSource.volume = slider1.value;
      audioSource.volume = volume;
    }

    // Start is called before the first frame update

}
