using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_Patroling : MonoBehaviour
{
    [SerializeField]
    public bool IsMovingRight;
    [SerializeField]
    float moveSpeed = 1f;
    Transform LeftPos;
    Transform RightPos;
    Transform CurrentTarget;
    public bool canStart;
    public float fraction;
    Vector3 start, des;
    void Start()
    {
        LeftPos = transform.parent.GetChild(0);
        RightPos = transform.parent.GetChild(1);
        start = LeftPos.position;
        des = RightPos.position;
        canStart = true;
        
        

    }


    void Update()
    {
        if (canStart)
        {

            canStart = false;
            StopAllCoroutines();
            StartCoroutine(MoveTo());
            
        }
    }
    IEnumerator MoveTo()
    {
        // While not there, move
        while (fraction < 1)
        {
            fraction += Time.deltaTime * moveSpeed;
            transform.position = Vector3.Lerp(start, des, fraction);
            yield return null;
        }

        // done, cleanup and swap targets
        IsMovingRight = !IsMovingRight;
        
        fraction = 0f;
        canStart = true;

        var tmp = des;
        des = start;
        start = tmp;

    }

    private bool IsFacingRight()
    {
        return transform.localScale.x > Mathf.Epsilon;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.SetParent(transform);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.transform.SetParent(null); 
    }











}

