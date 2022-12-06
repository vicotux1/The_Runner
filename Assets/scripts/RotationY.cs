using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationY : MonoBehaviour{
    [SerializeField] Vector3 Rotation;

    void Update(){ 
        XYZRotation();
        }
        void XYZRotation(){
         transform.Rotate(Rotation); 
         }

}
