using UnityEngine;
using System.Collections;

public class _moveToward : MonoBehaviour{
    public Transform carrilesParent,carrilPositioActual;
    public Transform [] carrilesPosition;
    public int carrilActualIndex;
    public float speed;
     
     private void Awake() {
     carrilesPosition=new Transform [carrilesParent.childCount];
     for (int i =0; i<carrilesParent.childCount; i++)
     {
        carrilesPosition[i]=carrilesParent.GetChild(i);
        }
        carrilPositioActual=carrilesPosition[carrilActualIndex];
     }
     private void Update() {
        bool derecha=Input.GetButtonDown("Derecha");
        bool izquierda=Input.GetButtonDown("Izquierda");
        if(derecha){
            if(carrilActualIndex >0){
                carrilActualIndex--;
            }
        }
        if(izquierda){
            if(carrilActualIndex <carrilesPosition.Length-1){
                carrilActualIndex++;
            }
        }
        carrilPositioActual=carrilesPosition[carrilActualIndex];
        transform.position=Vector3.MoveTowards(transform.position,carrilPositioActual.position,speed* Time.deltaTime);
    }

    }