using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int delay;

    
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    
    public void Quit()
    {
        Application.Quit();
    }

}
