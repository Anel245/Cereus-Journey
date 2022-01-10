using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePoint;
    public float bulletSpeed = 50;

    Vector2 lookDirection;
    float lookAngle;

    void Update()
    {
        lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;

        //firePoint.Rotate(new Vector3(lookDirection.x, lookDirection.y, 0f));
        //   = Quaternion.Euler(0, 0, lookAngle);
        //firePoint.rotation.SetLookRotation(lookDirection);
        //firePoint.rotation.SetLookRotation(new Vector3(lookDirection.x, lookDirection.y, 0f));
        firePoint.LookAt(lookDirection);
        Debug.Log("lookAngle: " + lookAngle + ", lookDirection: " + lookDirection);

        if (Input.GetMouseButtonDown(0))
        {
            GameObject bulletClone = Instantiate(bullet);
            bulletClone.transform.position = firePoint.position;
            bulletClone.transform.rotation = Quaternion.Euler(0, 0, lookAngle);

            bulletClone.GetComponent<Rigidbody2D>().velocity = firePoint.forward * bulletSpeed;
        }
    }
}

