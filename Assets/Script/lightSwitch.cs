using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightSwitch : MonoBehaviour
{
    
    public Light thislight;
    public bool istriggered;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(istriggered == true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Debug.Log("fml");

                if (thislight.enabled == false)
                {
                    thislight.enabled = true;
                }

                else if (thislight.enabled == true)
                {
                    thislight.enabled = false;
                }

            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        istriggered = true;

        print("lol");
        
        
    }

    private void OnTriggerExit(Collider other)
    {
        istriggered = false;
    }
}
