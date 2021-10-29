using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletProjectile : MonoBehaviour
{
    public GameObject spawnPosObj;
    public GameObject Bullet;

    private int bulletSpeed = 10;
    private int bulletDespawn = 3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = (GameObject)Instantiate(Bullet, spawnPosObj.transform.position, Quaternion.identity);

            bullet.GetComponent<BulletScript>().travelDirection = spawnPosObj.transform.forward * bulletSpeed;
            Destroy(bullet, bulletDespawn);
            //bullet.velocity = transform.TransformDirection(Vector3.forward * 10);
        }
    }
}
