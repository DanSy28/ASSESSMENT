using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;// this will allow to change the scene 

public class GameManager : MonoBehaviour
{
    #region Variables
    [Header("GAME MANAGER")]
    [Space(10)]
    [Header("Levels")]// this a sup heding 1
    public int LevelToLoad = 1; //this allow us to load a Level
    public Scene curScene;// it allow to change Scene 
    public static GameManager Instance = null;
    #endregion

    public void EndLevel()// this tells us that it will be a end level
    {
        //Scene currentScene = SceneManager.GetActiveScene();
        //SceneManager.LoadScene(currentScene.buildIndex + 0);
        SceneManager.LoadScene(0);// it will allow to change Scene by the sceneManager 
    }
 
}

