using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MENU_CONTROL : MonoBehaviour
{
    public Button cvsP_Button;
    public Button pvsP_Button;
    public Button quit_Button;
    public Button RULES_Button;
   
    public void CvsPGame()
    {
        SceneManager.LoadScene(1);
    }

    public void PvsPGame()
    {
        SceneManager.LoadScene(2);
    }

     public void Rules()
    {
        SceneManager.LoadScene(7);
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
}
