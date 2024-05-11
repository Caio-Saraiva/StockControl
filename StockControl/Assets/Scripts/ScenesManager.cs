using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public void ToMenu()
    {
        int actualScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadSceneAsync("SC_Menu");
        SceneManager.UnloadSceneAsync(actualScene);
    }

    public void ToCosts()
    {
        int actualScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadSceneAsync("SC_Costs");
        SceneManager.UnloadSceneAsync(actualScene);
    }

    public void ToInventory()
    {
        int actualScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadSceneAsync("SC_Inventory");
        SceneManager.UnloadSceneAsync(actualScene);
    }

    public void ToSettings()
    {
        int actualScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadSceneAsync("SC_Settings");
        SceneManager.UnloadSceneAsync(actualScene);
    }
}
