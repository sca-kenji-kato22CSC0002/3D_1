using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset;

    public float speed = 1;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        offset = player.transform.position - transform.position;

        var movement = offset;

        rb.AddForce(movement * speed);


        //transform.position = player.transform.position - offset;
    }
}
