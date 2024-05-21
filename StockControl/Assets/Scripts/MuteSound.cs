using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

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

        PlayerPrefs.SetFloat("LatinhaCost", (float)Math.Round(PlayerPrefs.GetInt("Latinha") * 2.34f, 2));
        PlayerPrefs.SetFloat("GarrafaCost", (float)Math.Round(PlayerPrefs.GetInt("Garrafa") * 1.27f, 2));
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
