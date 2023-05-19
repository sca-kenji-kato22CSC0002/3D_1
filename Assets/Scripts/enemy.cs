using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    [SerializeField]private GameObject player;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //–ˆƒtƒŒ[ƒ€—Í‚ğ‰Á‚¦‚é
        rb.AddForce(player.transform.position - transform.position);
        //
    }
}
