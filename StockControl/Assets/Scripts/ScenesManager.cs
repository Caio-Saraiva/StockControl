using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public float changeTime = 0.2f;
    public void ToMenu()
    {
        StartCoroutine(MenuCorutine());
    }

    IEnumerator MenuCorutine()
    {
        int actualScene = SceneManager.GetActiveScene().buildIndex;
        yield return new WaitForSeconds(changeTime);
        SceneManager.LoadSceneAsync("SC_Menu");
        SceneManager.UnloadSceneAsync(actualScene);
    }

    public void ToCosts()
    {
        StartCoroutine(CostCorutine());
    }

    IEnumerator CostCorutine()
    {
        int actualScene = SceneManager.GetActiveScene().buildIndex;
        yield return new WaitForSeconds(changeTime);
        SceneManager.LoadSceneAsync("SC_Costs");
        SceneManager.UnloadSceneAsync(actualScene);
    }

    public void ToInventory()
    {
        StartCoroutine(InvCorutine());
    }

    IEnumerator InvCorutine()
    {
        int actualScene = SceneManager.GetActiveScene().buildIndex;
        yield return new WaitForSeconds(changeTime);
        SceneManager.LoadSceneAsync("SC_Inventory");
        SceneManager.UnloadSceneAsync(actualScene);
    }

    public void ToSettings()
    {
        StartCoroutine(SettingsCorutine());
    }

    IEnumerator SettingsCorutine()
    {
        int actualScene = SceneManager.GetActiveScene().buildIndex;
        yield return new WaitForSeconds(changeTime);
        SceneManager.LoadSceneAsync("SC_Settings");
        SceneManager.UnloadSceneAsync(actualScene);
    }

    public void ToReport()
    {
        StartCoroutine(ReportCorutine());
    }

    IEnumerator ReportCorutine()
    {
        int actualScene = SceneManager.GetActiveScene().buildIndex;
        yield return new WaitForSeconds(changeTime);
        SceneManager.LoadSceneAsync("SC_Report");
        SceneManager.UnloadSceneAsync(actualScene);
    }
}
