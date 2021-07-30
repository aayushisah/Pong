using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menu : MonoBehaviour
{
    public Button return_Button;
  
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
