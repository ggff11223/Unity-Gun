using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 20f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // ใช้ปุ่มซ้ายของเมาส์เป็นการยิง
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.velocity = firePoint.forward * bulletSpeed;
    }
}
