using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.tag == "Bullet")
        {
            Debug.Log("please disappear like my motivation");
            Destroy(collision.gameObject);


        }


    }

}
