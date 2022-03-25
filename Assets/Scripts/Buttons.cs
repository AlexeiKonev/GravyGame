using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject startPanel;
   
    void Start()
    {
        startPanel.SetActive(true);
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
    public void StartLevel()
    {
        startPanel.SetActive(false);
        Time.timeScale = 1;
    }
     
    
}