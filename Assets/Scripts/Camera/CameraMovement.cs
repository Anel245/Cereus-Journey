using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    private Transform player; 

    private Vector3 tempPos;

    [SerializeField]
    private float minX, maxX;



    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform; 
    }

    // Update is called once per frame
    void LateUpdate()
    {

        tempPos = transform.position;
        tempPos.x = player.position.x;


        transform.position = tempPos;



    }
} // class
