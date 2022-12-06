using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObtacles : MonoBehaviour
{
    public float speed;
    public Vector3 translate;
    void Update(){
        transform.Translate(translate *speed*Time.deltaTime);
    }
}
