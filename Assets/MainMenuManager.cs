using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    #region Variables
    [Space]
    [Header("Variables")]
    public string RateUsLink;
    public string PrivacyPolicyLink;
    public string MoreGamesLink;
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
    public void Play()
    {
        SceneManager.LoadScene("Gameplay");
    }
    public void RateUs()
    {
        Application.OpenURL(RateUsLink);
    }
    public void PrivacyPolicy()
    {
        Application.OpenURL(PrivacyPolicyLink);
    }
    public void MoreGames()
    {
        Application.OpenURL(MoreGamesLink);
    }
    #endregion
}
