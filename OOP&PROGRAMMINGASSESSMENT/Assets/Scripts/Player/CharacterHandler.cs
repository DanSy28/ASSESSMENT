using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script allow us to find the Component section that is in the option Character Set Up 
//this where the Character Handler gose 
[AddComponentMenu("Character Set Up/Character Handler")]
public class CharacterHandler : MonoBehaviour
{
    [Header("Character")]
    #region Character 
    //this allow you to controller the charcter 
    public CharacterController controller;
   


    #endregion
    //private Vector3 spawnPoint;

    #region Start
    void start()
    {

        //when the controller finds a character control it will be more variable 
        controller = this.GetComponent<CharacterController>();
    }
    #endregion
    
    
 
    

}

