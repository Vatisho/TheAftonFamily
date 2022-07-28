using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour{
   
    public void PlayGame ()
    {
        SceneManager.LoadScene("Game");
    }

    public void QuitGame ()
    {
        Debug.Log("QUIT!");
        if (UnityEditor.EditorApplication.isPlaying == true)
        {

            UnityEditor.EditorApplication.isPlaying = false;

        }
        else
        {

            Application.Quit();

        }


    }
}
