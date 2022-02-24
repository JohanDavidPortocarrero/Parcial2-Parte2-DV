using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirCamara : MonoBehaviour
{
    public GameObject player;
    public GameObject player2;
    public GameObject player3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 direccion = player.transform.position;;

        if( direccion.y <= -15.94 ){

            direccion = player2.transform.position;
            
            if( direccion.x <= -16 ){
                direccion = player3.transform.position;
                if( direccion.x <= -24 ){
                    direccion.x = -24f;
                    direccion.z = -10f;
                }
                else{
                    direccion.y = -16f;
                    direccion.z = -10f;
                }
            }
            else{
                direccion.y = -16f;
                direccion.z = -10f;
            }

        }
        else{
            direccion.z = -10f;
            direccion.x = 0.5f;
        }        

        transform.position = direccion;

        //Transform.position = direccion;
        //new Vector3(player.transform.position.x, player.transform.position.x, player.transform.position.x);
    }
}
