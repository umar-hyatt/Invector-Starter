using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    #region Variables
    [Space]
    [Header("Variables")]
    public GameObject Player;

    [Space]
    [Header("Panels")]
    public GameObject PausePanel;
    public GameObject CompletePanel;
    public GameObject FailedPanel;
    #endregion

    #region UnityFunction
    private void Awake()
    {
        
    }
    private void Start()
    {
        
    }
    private void OnEnable()
    {
        
    }
    private void OnDisable()
    {
        
    }
    #endregion
    #region CustomFunctions
    public void Pause()
    {
        Time.timeScale = 0;
        PausePanel.SetActive(true);
    }
    public void Resume()
    {
        Time.timeScale = 1;
        PausePanel.SetActive(false);
    }
    public void Home()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Next()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void LevelComplete()
    {
        Time.timeScale = 0;
        CompletePanel.SetActive(true);
    }
    public void LevelFailed()
    {
        Time.timeScale = 0;
        FailedPanel.SetActive(true);
    }
    #endregion
}
