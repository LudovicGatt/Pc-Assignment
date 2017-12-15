using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour {



    public GameObject Rightpannel;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Rightpannel.GetComponent<Rigidbody2D>().velocity = new Vector3(0f, 0f, 0f);

        //if the player is moving the mouse....
        float mousecontrolle = (Input.mousePosition.y / Screen.height * 14f) - 7f;
        mousecontrolle = Mathf.Clamp(mousecontrolle, -8, 8f);

        //Vector3 saves the points in x,y,z
        //Keeps the position fixed.
        Vector3 pannleXY = new Vector3(this.transform.position.x, mousecontrolle, 0);

        this.transform.position = pannleXY;
        Rightpannel.GetComponent<Rigidbody2D>().velocity = new Vector3(0f, 0f, 0f);
    }
}
