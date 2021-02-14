using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSize : MonoBehaviour
{
    private GameObject Player; 
    private Vector3 scaleChange; 
    // Start is called before the first frame update
    void ChangeBall()
    {   
        scaleChange = new Vector3(2f, 2f, 2f); 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
