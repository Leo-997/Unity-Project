using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    public GameObject redObj;
    [SerializeField] private GameObject blueObj;
    // Start is called before the first frame update
    void Start()
    {
<<<<<<< Updated upstream
        Application.targetFrameRate = 60;
        Instantiate(redObj, new Vector3(2,0,0), Quaternion.identity);
        Instantiate(blueObj, new Vector3(-2, 0, 0), Quaternion.identity);
=======
        Instantiate(redObj, Vector3.zero, Quaternion.identity);
        //Instantiate(blueObj, Vector3., Quaternion.identity);
>>>>>>> Stashed changes
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
