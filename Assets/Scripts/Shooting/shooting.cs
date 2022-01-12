using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePoint;
    public float bulletSpeed = 50;
    public float shootTimer;
    private bool isShooting;

    Vector2 lookDirection;
    float lookAngle;

    void Start()
    {
        isShooting = false;
    }

    void Update()
    {
        lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        lookAngle = Mathf.Atan2(lookDirection.x, lookDirection.y) * Mathf.Rad2Deg;

        //firePoint.Rotate(new Vector3(lookDirection.x, lookDirection.y, 0f));
        //   = Quaternion.Euler(0, 0, lookAngle);
        //firePoint.rotation.SetLookRotation(lookDirection);
        //firePoint.rotation.SetLookRotation(new Vector3(lookDirection.x, lookDirection.y, 0f));
        firePoint.LookAt(lookDirection);
        Debug.Log("lookAngle: " + lookAngle + ", lookDirection: " + lookDirection);

        Vector2 dir = lookDirection - new Vector2(firePoint.position.x, firePoint.position.y);

        dir.Normalize();

        float angleDeg = Mathf.Atan(dir.y / dir.x) * Mathf.Rad2Deg;
        if (dir.x < 0) angleDeg += 180;

        if (Input.GetMouseButtonDown(0))
        {
            if (dir.y >= 0)
            {
                
                if (!isShooting)
                {
                    StartCoroutine(Shoot());
                    GameObject bulletClone = Instantiate(bullet);
                    bulletClone.transform.position = firePoint.position;
                    bulletClone.transform.rotation = Quaternion.Euler(0, 0, angleDeg); ;

                    bulletClone.GetComponent<Rigidbody2D>().velocity = firePoint.forward * bulletSpeed;
                }
            }

        }


    }

    IEnumerator Shoot()
    {
        isShooting = true;
        yield return new WaitForSeconds(shootTimer);
        isShooting = false;
    }


}

