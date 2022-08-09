using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    private int rango = 2;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(player.transform.position, player.transform.forward, out hit, rango))
        {
           if(hit.collider.GetComponent<Esconderse>() == true)
            {
                if(Input.GetKeyDown(KeyCode.Space))
                {
                    hit.collider.GetComponent<Esconderse>().entra = true;
                }

            }
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.black;
        Gizmos.DrawRay(player.transform.position, player.transform.forward * rango);
    }
}
