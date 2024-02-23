using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectables : MonoBehaviour
{
    public AudioSource coinFX;

    public float rotateSpeed = 1;
    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }
    void OnTriggerEnter(Collider other)
    {
      
        this.gameObject.SetActive(false);
        coinFX.Play();
    }

}