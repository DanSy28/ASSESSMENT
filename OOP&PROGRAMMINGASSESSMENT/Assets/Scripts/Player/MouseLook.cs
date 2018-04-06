using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MouseLook
{
    [AddComponentMenu("Player/Camera/FirstPerson")]

    public class MouseLook : MonoBehaviour
    {
        #region Variables
        [Header("Sensitivity")]
        public float sensitivityX = 15;// this speed the X axise
        public float sensitivityY = 15;// this speed the Y axise
        [Header("Rotation Clamp")]
        public float minimumY = -60; // this min the  Y axise 
        public float maxY = 60; // this min the X axise
        float rotationY = 0;// this tells that i won't rotat on y
        public RotationalAxis axis = RotationalAxis.MouseX;// allow to show that the it can use axis on moueX 
        #endregion

        public enum RotationalAxis
        {
            MouseXAndY = 0, // the movement of mouse speed 
            MouseX = 1, // this so that mouseX can speed up to 1 
            MouseY = 2 // this so that mousey can speed up to 2
        }
        void Start()
        {
            if (this.GetComponent<Rigidbody>()) // this tells us that the mouse can move forcely around 
            {
                this.GetComponent<Rigidbody>().freezeRotation = true;// it allow us to use freexe rotation on a rigidbody
            }
        }
        void Update()
        {
            if (axis == RotationalAxis.MouseXAndY)// it tells the mouse can move both X and Y axise 
            {
                float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityX;// allow to input the x axis sensitivity 
                rotationY += Input.GetAxis("Mouse Y") * sensitivityY;//this allow us to do yaxies sensitivity
                rotationY = Mathf.Clamp(rotationY, minimumY, maxY);// it is trying to find rotationY, minimumY and maxY
                transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);//trying minimize the -rotationY rotationX
            }
            else if (axis == RotationalAxis.MouseX)// It trying so see if it performs th roationAxis to MouseX
            {
                transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityX, 0);// this tells up it move the x axise 

            }
            else //axis == RotationalAxis.MouseY
            {
                rotationY += Input.GetAxis("Mouse Y") * sensitivityY; // mouse can move form y axise 
                rotationY = Mathf.Clamp(rotationY, minimumY, maxY); // mouse can move move x axise 
                transform.localEulerAngles = new Vector3(-rotationY, transform.localEulerAngles.y, 0);// it's trying find and minimize -rotationY
            }



        }
    }
}
