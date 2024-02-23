using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour

{
    private Rigidbody Rb;
    public float moveSpeed=2;

    public TMP_Text countText;
    static int coinCount;
    public TMP_Text winText;
     AudioSource source;
     
     AudioSource source1;

    // Start is called before the first frame update
    void Start()
    {
        countText.text="0";
        winText.text = "";
        source1 = GetComponent<AudioSource>();
        source1.Play();
        
    }
    void Update()
    {
        countText.text="Count: " + coinCount.ToString();
        source = GetComponent<AudioSource>();
        // float horizontalInput = Input.GetAxis("Horizontal");
        // float verticalInput = Input.GetAxis("Vertical");
        WinCheck();
        //transform.Translate(new Vector3(horizontalInput, 0, verticalInput) * Time.deltaTime * moveSpeed);
    }
    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Pick up")){
            other.gameObject.SetActive(false);
            source.Play();
            coinCount+=1;
            //WinCheck();
        }

    }
    void WinCheck()
    {
        if (coinCount==5)
        {
            winText.text = "You Win!";
            Debug.Log("WinCheck called");
            StartCoroutine(StartScreenAfterDelay(4f));
            }

    }
    IEnumerator StartScreenAfterDelay(float delay)
    {
            yield return new WaitForSeconds(delay);
             SceneManager.LoadScene("Start");

    }
}