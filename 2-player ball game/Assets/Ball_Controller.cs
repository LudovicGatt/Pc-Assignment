using System.Collections;
using UnityEngine;

public class Ball_Controller : MonoBehaviour {
    //get a reference to the rigidbody

    Rigidbody2D rb;

    private float speedInXDirection;


    // Use this for initialization
    void Start() {

        rb = GetComponent<Rigidbody2D>();
        Vector3 launchDirection = new Vector3();
        rb.velocity = new Vector3 (8f,0f,0f);
        //Pause ball logic for 2.5 seconds
        StartCoroutine(Pause());
    }
	
	// Update is called once per frame
	void Update () {
        //if ball goes out of bounce in the left
        if(transform.position.x < -22f)
        {
            transform.position = Vector3.zero;
            rb.velocity = Vector3.zero;
            //Give player 2 a point
            Scoreboard_Controller.instance.GivePlayerTwoAPoint();
            StartCoroutine(Pause());
        }
        //if ball goes out of bounce in the right
        if (transform.position.x > 22f)
        {
            transform.position = Vector3.zero;
            rb.velocity = Vector3.zero;
            //Give player 1 a point
            Scoreboard_Controller.instance.GivePlayerOneAPoint();
            StartCoroutine(Pause());
        }
    }
    
    IEnumerator Pause()
    {
        // wait for 2.5 seconds
        yield return new WaitForSeconds(2f);
        //call the function LaunchBall
        LaunchBall();
    }

    void LaunchBall()
    {
        transform.position = Vector3.zero;
        //ball chooses a direction to go
        //determin direction in x-axis
        int xDirection = Random.Range(0, 2);

        //determin direction in the y-axis
        int yDirection = Random.Range(0, 3);

        Vector3 launchDorection = new Vector3();

        if (xDirection == 0)
        {
            launchDorection.x = -8f;

        }
        if (xDirection == 1)
        {
            launchDorection.y = 8f;
        }

        if (xDirection == 2)
        {
            launchDorection.x = 0f;
        }

        if (yDirection == 0)
        {
           launchDorection.y = -8f;
        }
        if (yDirection == 1)
        {
            launchDorection.x = 8f;

        }
        if (yDirection == 2)
        {
            launchDorection.x = 0f;

        }
        //Assign velocity based off of where we launch the ball
        rb.velocity = launchDorection;



    }



    void OnCollisionEnter2D (Collision2D hit)
    {
        if (hit.gameObject.name == "TopBounce")
        {
#pragma warning disable CS0219 // Variable is assigned but its value is never used
            float speedInDirection = 0f;
#pragma warning restore CS0219 // Variable is assigned but its value is never used


            if (rb.velocity.x > 0f)
                speedInXDirection = 8f;

            if (rb.velocity.x < 0f)
                speedInXDirection = -8f;



            rb.velocity = new Vector3(speedInXDirection, -8f, 0f);
        }
        if (hit.gameObject.name == "BottemBounce")
        {

            if (rb.velocity.x > 0f)
                speedInXDirection = 8f;

            if (rb.velocity.x < 0f)
                speedInXDirection = -8f;

                rb.velocity = new Vector3(speedInXDirection, 8f, 0f);
        }
        if (hit.gameObject.name == "Left_pannel")
        {
            rb.velocity = new Vector3(13f, 0f, 0f);

            //if ball hits lower half of the pannel
            if (transform.position.y - hit.gameObject.transform.position.y < -1)
            {
                rb.velocity = new Vector3(8f, -8f, 0f);
            }
            // if ball hits upper half of the pannel
            if (transform.position.y - hit.gameObject.transform.position.y > 1)
            {
                rb.velocity = new Vector3(8f, 8f, 0f);
            }
        }
        if (hit.gameObject.name == "Right_pannel")
        {
            rb.velocity = new Vector3(-13f, 8f, 0f);

            //if ball hits lower half of the pannel
            if (transform.position.y - hit.gameObject.transform.position.y < -1)
            {
                rb.velocity = new Vector3(-8f, -8f, 0f);
            }
            // if ball hits upper half of the pannel
            if (transform.position.y - hit.gameObject.transform.position.y > 1)
            {
                rb.velocity = new Vector3(-8f, 8f, 0f);
            }




            if (hit.gameObject.name == "Block")
            {
                rb.velocity = new Vector3(-13f, 8f, 0f);

                //if ball hits the upper block.
                if (transform.position.y - hit.gameObject.transform.position.y < -1)
                {
                    rb.velocity = new Vector3(-8f, -8f, 0f);
                }
                // if ball hits the lower block.
                if (transform.position.y - hit.gameObject.transform.position.y > 1)
                {
                    rb.velocity = new Vector3(-8f, 8f, 0f);
                }
            }



            }
        }
}
