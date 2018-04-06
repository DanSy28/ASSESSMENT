using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //this allow you to use Canvas element
using UnityEngine.SceneManagement;//this allow you to change Scence

public class GameManager1 : MonoBehaviour
{
    #region Variables
    [Header("GAME MANAGER")]
    [Space(10)]
    [Header("Levels")]// this a sup heding 1
    public int LevelToLoad = 1; //this allow us to load a Level
    public Scene curScene; // it allow to change Scene 
    #endregion

    public void ChangeScene()//this is publicy viable function that allows us to change scene
    {
        SceneManager.LoadScene(1);// it will allow to change Scene by the sceneManager 
    }
    public void ExitGame() //this allow us to leave the game
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;// the game is running it won't quit game
#endif
        Application.Quit();//it allow us to closes the application
    }

}




