using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public float shootSpeed, shootTimer;

    private bool isShooting;

    public Transform shootPosR;
    public Transform shootPosL;
    public GameObject bullet;


    void Start()
    {
        isShooting = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") &&!isShooting)
        {
            StartCoroutine(Shoot());
        }

    }


    IEnumerator Shoot()
    {
        int direction()
        {
            if(GetComponent <SpriteRenderer>().flipX)
            {
                return -1;
            }
            else
            {
                return +1;
            }

        }
        Vector3 shootPos()
        {
            if (GetComponent<SpriteRenderer>().flipX)
            {
                return shootPosL.position;
            }
            else
            {
                return shootPosR.position;
            }

        }

        isShooting = true;

        GameObject newBullet = Instantiate(bullet, shootPos(), Quaternion.identity);
        newBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(shootSpeed * direction() , 0f);
        newBullet.transform.localScale = new Vector2(newBullet.transform.localScale.x * direction(), newBullet.transform.localScale.y);

        yield return new WaitForSeconds(shootTimer);
        isShooting = false;
    }


}
