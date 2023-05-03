using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsButton : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject optionsMenu;
    public AudioSource speaker;
    public AudioClip optionsTTS;
    public void OptionsButtonPressed(){
        Debug.Log("Options Button Pressed!");
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }
    public void OptionButtonHover(){
        if (TTS.ttsOn){
            speaker.PlayOneShot(optionsTTS);
        }
    }
}
