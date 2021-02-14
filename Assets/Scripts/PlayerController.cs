using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour 
{

    public float speed = 800.0f;
    public Text scoreText;
    public Text winText; 
    private int count = 0;
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        GetComponent<Rigidbody>().AddForce (movement * speed * Time.deltaTime);
    }

    public void StopPlaying()
    {
        SceneManager.LoadScene("Exit");
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "PickUp") {
            other.gameObject.SetActive(false); 
            count += 1;
            scoreText.text = "Score: " + count;
        }
        if (count >= 16) 
        { 
            StopPlaying(); 
        }
    }
}
