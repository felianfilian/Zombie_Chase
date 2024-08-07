using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public Rigidbody2D rb;

    public bool walkRight;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (walkRight)
        {
            rb.velocity = new Vector3(10f,0f,0f);
        }
    }
}
