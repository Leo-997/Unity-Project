using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public int i = 3;
    public Renderer rend;
    public int R ;
    // Start is called before the first frame update
    void Start()
    {
        R = Random.Range(150, 251);// Let the R equal a random int from 150 to 250
    }

    // Update is called once per frame
    void Update()
    { 
        i++;
        Debug.Log(gameObject.name+":"+i);
  
        if( gameObject.tag == "Red" && i == 100) {
            gameObject.SetActive(false);//Deactivate this gameobject
        }

        if ( gameObject.tag == "Blue" && i == R) {
            rend = GetComponent<Renderer>();
            rend.enabled = false;//Turn off the render
        }

    }
}
