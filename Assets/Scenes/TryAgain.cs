using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TryAgain : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
    
    public void Return()
    {
        SceneManager.LoadScene("Menu");
    }
}
