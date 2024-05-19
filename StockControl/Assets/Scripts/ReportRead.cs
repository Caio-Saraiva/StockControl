using TMPro;
using UnityEngine;

public class ReportRead : MonoBehaviour
{
    public TextMeshProUGUI LatQtnd;
    public TextMeshProUGUI GarQtnd;
    public TextMeshProUGUI LatCost;
    public TextMeshProUGUI GarCost;
    public TextMeshProUGUI OtherCost;
    public TextMeshProUGUI TotalCost;
    void Awake()
    {
        int latinhaQtnd = PlayerPrefs.GetInt("Latinha");
        int garrafaQtnd = PlayerPrefs.GetInt("Garrafa");
        float latinhaCost = PlayerPrefs.GetFloat("LatinhaCost");
        float garrafaCost = PlayerPrefs.GetFloat("GarrafaCost");
        float otherCost = PlayerPrefs.GetFloat("Cost");
        float totalCost = latinhaCost + garrafaCost + otherCost;

        LatQtnd.text = "x" + latinhaQtnd.ToString();
        GarQtnd.text = "x" + garrafaQtnd.ToString();
        LatCost.text = "R$ " + latinhaCost.ToString();
        GarCost.text = "R$ " + garrafaCost.ToString();
        OtherCost.text = "R$ " + otherCost.ToString();
        TotalCost.text = "R$ " + totalCost.ToString();
    }
}
