using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBlocks : MonoBehaviour
{

    public float y = -5f;

    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

        transform.Translate(0, y = Time.deltaTime, 0);
    }
}
