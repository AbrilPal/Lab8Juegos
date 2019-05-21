using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    
    bool on = true;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (on)
            {
                on = false;
                GetComponent<Light>().intensity = 0;
            }else if(on == false)
            {
                on = true;
                GetComponent<Light>().intensity = 20;
            }
        }
      
    }

  /*  private void OnTriggerStay(Collider other)
    {
        other.gameObject.GetComponent<Light>().intensity = Mathf.Sin(Time.time);
    }

    private void OnTriggerExit(Collider other)
    {
        other.gameObject.GetComponent<Light>().intensity = 0;
    }*/
}
