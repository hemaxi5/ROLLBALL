using UnityEngine;
using System.Collections;



public class GyroRotate : MonoBehaviour 

{
     //Vector3 rot;
     //Gyroscope m_Gyro;
      public Rigidbody rb;
      public float speed=50f;
      float dx;
      float dz;


void Start ()
     {
     //      m_Gyro = Input.gyro;
     //      m_Gyro.enabled = true;
               rb=GetComponent<Rigidbody>();
     }

void Update ()
     {
          dx=Input.acceleration.x * speed;
          dz=-Input.acceleration.z *speed;
          //transform.position= new Vector2(Mathf.Clamp(transform.position.x,-7.5f,7.5f),transform.position.y);
          //transform.position= new Vector3(Mathf.Clamp(transform.position.x,-7.5f,7.5f),transform.position.y,transform.position.z);
          transform.position= new Vector3(Mathf.Clamp(transform.position.x,-7.5f,7.5f),transform.position.y,Mathf.Clamp(transform.position.z, -8f, 8f));
          Debug.Log("X position: " + transform.position.x);
          Debug.Log("Z position: " + transform.position.z);
     }
     private void FixedUpdate(){
          //rb.velocity= new Vector2(dx,0);
          rb.velocity= new Vector3(dx,0,dz);

     }
}