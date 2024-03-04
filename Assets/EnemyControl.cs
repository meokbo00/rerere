using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public GameObject BulletPrefab;
    public float min = 0.5f;
    public float max = 3f;

    private Transform target;
    private float spawnrate;
    private float timeafterspawn;

    void Start()
    {
        timeafterspawn = 0;
        spawnrate = Random.Range(min, max);
        target = FindObjectOfType<PlayerControl>().transform;
    }
    void Update()
    {
        timeafterspawn += Time.deltaTime;
        if(timeafterspawn > spawnrate)
        {
            timeafterspawn = 0;
            GameObject bullet = Instantiate(BulletPrefab, transform.position, transform.rotation);
            bullet.transform.LookAt(target);
            spawnrate = Random.Range(min, max);
        }
    }
}
