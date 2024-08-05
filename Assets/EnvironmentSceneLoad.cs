using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnvironmentSceneLoad : MonoBehaviour
{
    public GameObject Environment;
    public UnityEvent onAwake;
    private void Awake()
    {
        Environment.SetActive(true);
        if (onAwake != null)
        {
            onAwake.Invoke();
        }
    }
}
