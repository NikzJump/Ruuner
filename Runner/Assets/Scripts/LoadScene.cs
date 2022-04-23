using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void ChangeScene(int numberScene)
    {
        SceneManager.LoadScene(numberScene);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
