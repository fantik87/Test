using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Weapon : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float bulletSpeed = 10f;
    [SerializeField] public float bulletLifetime = 3f;
    void Start()
    {

    }

    public void SpawnBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);
        Rigidbody2D bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
        bulletRigidbody.velocity = spawnPoint.transform.position * bulletSpeed;
       /* bullet.Position.x = spawnPoint.Position.x * bulletSpeed;*/
        Debug.Log("hui");

        Destroy(bullet, bulletLifetime);
    }




    void Update()
    {
        
    }
}
