using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Settings : MonoBehaviour
{
    [SerializeField]
    private string webLink;
    public void QuitApp()
    {
        Application.Quit();
    }

    public void OpenURL()
    {
        Application.OpenURL(webLink);
    }
}
