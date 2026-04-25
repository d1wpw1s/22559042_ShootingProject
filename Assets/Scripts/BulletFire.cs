using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour
{
    public GameObject bulletObject;
    public GameObject bulletFireObject;
    public float fireRate = 0.5f;
    private float nextFireTime = 0f;

    void Update()
    {
        bool isFire = Input.GetButtonDown("Jump");
        if (isFire && Time.time >= nextFireTime)
        {
            nextFireTime = Time.time + fireRate;
            GameObject bullet = Instantiate(bulletObject);
            bullet.transform.position = bulletFireObject.transform.position;
        }
    }
}
