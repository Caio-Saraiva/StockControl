using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteSound : MonoBehaviour
{
    public int muteValue;

    private void Start()
    {
        muteValue = PlayerPrefs.GetInt("MuteValue");
        if (muteValue == 0)
        {
            AudioListener.volume = 1;
        }
        else if (muteValue == 1)
        {
            AudioListener.volume = 0;
        }
    }

    public void Mute()
    {
        if(muteValue == 0)
        {
            muteValue = 1;
            PlayerPrefs.SetInt("MuteValue", muteValue);
            AudioListener.volume = 0;
        }
        else if(muteValue == 1)
        {
            muteValue = 0;
            PlayerPrefs.SetInt("MuteValue", muteValue);
            AudioListener.volume = 1;
        }
    }
}
