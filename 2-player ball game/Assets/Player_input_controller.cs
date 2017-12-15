using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_input_controller : MonoBehaviour {

    //script that handles input from two players.
    //player 1 = controls left pannel with w/s keys.
    //player 2 = cpmtrpls right pannel with the mouse.

    public GameObject Leftpannel;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //Defualt speed of the bat to zero on every frame
        Leftpannel.GetComponent<Rigidbody2D>().velocity = new Vector3(0f, 0f, 0f);


        //if the player is pressign the W key....
        if (Input.GetKey(KeyCode.W))
        {
            //Moving the pannel up
            Debug.Log("Player 1 is pressign W");
            //set the velocity to go up 1.
            Leftpannel.GetComponent<Rigidbody2D>().velocity = new Vector3(0f, 8f, 0f);
        }
        //If the player is pressign the S key...
       else if (Input.GetKey(KeyCode.S))
        {
            //Moving the pannel down
            Debug.Log("Player 2 is pressing S");
            //set the velosity to go down (-1)
            Leftpannel.GetComponent<Rigidbody2D>().velocity = new Vector3(0f, -8f, 0f);
        }
        //if you arent pressign any keys the velosity is 0
        //Defualt speed of the pannel to zero on every frame
       


       
        
    }
}
