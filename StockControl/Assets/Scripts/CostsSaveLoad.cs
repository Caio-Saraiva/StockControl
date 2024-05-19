using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System;

public class CostsSaveLoad : MonoBehaviour
{
    [SerializeField]
    private float LatinhaCost;
    [SerializeField]
    private float GarrafaCost;
    
    public TextMeshProUGUI Latinha;
    public TextMeshProUGUI Garrafa;
    public TextMeshProUGUI Cost;
    public TextMeshProUGUI TotalCost;

    public TMP_InputField InsertCost;

    void Start()
    {
        //LoadData and Calculo
        int LatinhaQntd = PlayerPrefs.GetInt("Latinha");
        int GarrafaQntd = PlayerPrefs.GetInt("Garrafa");
        float LatinhaTotal = LatinhaQntd * LatinhaCost;
        float GarrafaTotal = GarrafaQntd * GarrafaCost;
        PlayerPrefs.SetFloat("LatinhaCost", LatinhaTotal);
        PlayerPrefs.SetFloat("GarrafaCost", GarrafaTotal);

        Latinha.text    = "R$ " + Math.Round(LatinhaTotal, 2).ToString();
        Garrafa.text    = "R$ " + Math.Round(GarrafaTotal, 2).ToString();
        Cost.text       = "R$ " + Math.Round(PlayerPrefs.GetFloat("Cost"), 2).ToString();
        TotalCost.text  = "R$ " + Math.Round(LatinhaTotal + GarrafaTotal + PlayerPrefs.GetFloat("Cost"), 2).ToString();
    }

    private void Update()
    {
        TotalCost.text = "R$ " + Math.Round(PlayerPrefs.GetFloat("LatinhaCost") + PlayerPrefs.GetFloat("GarrafaCost") + PlayerPrefs.GetFloat("Cost"), 2).ToString();
        Cost.text = "R$ " + Math.Round(PlayerPrefs.GetFloat("Cost"), 2).ToString();
    }

    public void SaveData()
    {
        PlayerPrefs.SetFloat("Cost", float.Parse(InsertCost.text));
        Cost.text = "R$ " + InsertCost.text;
    }

    public void DeleteData()
    {
        PlayerPrefs.DeleteKey("Cost");
        Cost.text = "R$ " + "";
        InsertCost.text = "";
    }
}
