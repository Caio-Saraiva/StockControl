using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Settings : MonoBehaviour
{
    public void QuitApp()
    {
        Application.Quit();
    }

    public void OpenURL()
    {
        Application.OpenURL("https://github.com/Caio-Saraiva");
    }
}
