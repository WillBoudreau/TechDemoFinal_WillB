using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehaviour : MonoBehaviour
{
    public void QuitBUT()
    {
        Application.Quit();
    }
    public void RestartBUT()
    {
        SceneManager.LoadScene(0);
    }
}
