using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody rigidbody;
    void Start()
    {
        this.rigidbody = GetComponent<Rigidbody>();
        this.rigidbody.velocity = transform.forward * speed;
        Destroy(gameObject, 3f);
    }

    // 추가
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("충돌");
            PlayerControl playerControl = GetComponent<PlayerControl>();
            if(playerControl != null)
            {
                playerControl.Die();
            }
        }
    }
}
