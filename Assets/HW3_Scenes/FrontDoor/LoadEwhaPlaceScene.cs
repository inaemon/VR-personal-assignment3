using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadEwhaPlaceScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider c)
    {
        if(c.gameObject.name == "RobotPlayer") 
        {
            SceneManager.LoadScene("EwhaPlace");
        }
    }
}
