using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public int sceneNumber;

    public void GoToScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }
}