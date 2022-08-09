using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioCamara : MonoBehaviour
{
    public Transform posPP, posTP;

    private bool vision;
    
   
    void Update()
    {
      
        if(Input.GetKeyDown(KeyCode.V))
        {
            vision = true;
        }

        if(Input.GetKeyDown(KeyCode.Tab))
        {
            vision = false;
        }

        if(vision == true)
        {
            transform.position = Vector3.Lerp(transform.position, posPP.position, 5 * Time.deltaTime);
            
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, posTP.position, 5 * Time.deltaTime);
        }
    }
}
