using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InvsSaveLoad : MonoBehaviour
{
    public TextMeshProUGUI Latinha;
    public TextMeshProUGUI Garrafa;
    private int LatinhaValue;
    private int GarrafaValue;
    
    void Start()
    {
        Latinha.text = "x" + PlayerPrefs.GetInt("Latinha").ToString();
        Garrafa.text = "x" + PlayerPrefs.GetInt("Garrafa").ToString();

        LatinhaValue = PlayerPrefs.GetInt("Latinha");
        GarrafaValue = PlayerPrefs.GetInt("Garrafa");
    }

    void Update()
    {
        LatinhaValue = PlayerPrefs.GetInt("Latinha");
        GarrafaValue = PlayerPrefs.GetInt("Garrafa");

        Latinha.text = "x" + PlayerPrefs.GetInt("Latinha").ToString();
        Garrafa.text = "x" + PlayerPrefs.GetInt("Garrafa").ToString();
    }

    public void AddLatinha()
    {
        LatinhaValue++;
        Latinha.text = "x" + LatinhaValue.ToString();
        PlayerPrefs.SetInt("Latinha", LatinhaValue);
    }

    public void SubLatinha()
    {
        LatinhaValue--;
        if (LatinhaValue <= 0)
        {
            LatinhaValue = 0;
        }
        Latinha.text = "x" + LatinhaValue.ToString();
        PlayerPrefs.SetInt("Latinha", LatinhaValue);
    }

    public void AddGarrafa()
    {
        GarrafaValue++;
        Garrafa.text = "x" + GarrafaValue.ToString();
        PlayerPrefs.SetInt("Garrafa", GarrafaValue);
    }

    public void SubGarrafa()
    {
        GarrafaValue--;
        if (GarrafaValue <= 0)
        {
            GarrafaValue = 0;
        }
        Garrafa.text = "x" + GarrafaValue.ToString();
        PlayerPrefs.SetInt("Garrafa", GarrafaValue);
    }

    public void DeleteLatinha()
    {
        PlayerPrefs.DeleteKey("Latinha");
    }

    public void DeleteGarrafa()
    {
        PlayerPrefs.DeleteKey("Garrafa");
    }
}
