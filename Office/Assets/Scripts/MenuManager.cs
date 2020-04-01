using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    private GameObject m_player;
    private bool helpActive = false;

    private Vector3 spawnPlayer = new Vector3(-20, 1.8f, 30.0f);
    [SerializeField]
    private GameObject helpCanvas;
    [SerializeField]
    private GameObject canvas;
    [SerializeField]
    private GameObject WelcomeText;
    public void PlayGame()
    {
        m_player.transform.position = spawnPlayer;
        GetComponent<OVRScreenFade>().OnLevelFinishedLoading(0);
        canvas.SetActive(false);
        WelcomeText.SetActive(true);
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void Help()
    {
        if(!helpActive)
        {
            helpCanvas.SetActive(true);
            helpActive = true;
        }
        else
        {
            helpCanvas.SetActive(false);
            helpActive = false;
        }
    }
       
}
