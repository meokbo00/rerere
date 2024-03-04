using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody rigidbody;
    public float speed = 8f;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        float xspeed = x * speed;
        float zspeed = z * speed;
        Vector3 newvelo = new Vector3(xspeed, 0, zspeed);
        rigidbody.velocity = newvelo;
    }
    public void Die()
    {
        gameObject.SetActive(false);
    }
}
