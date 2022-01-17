using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol_4 : MonoBehaviour
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
        LeftPos = transform.GetChild(0);
        RightPos = transform.GetChild(1);
        start = transform.position;
        des = IsMovingRight ? RightPos.position : LeftPos.position;
        canStart = true;
        Turn();
    }

    
    void Update()
    {
        if (canStart)
        {
            Debug.Log("Started");
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
        Turn();
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

    private void Turn()
    {
        //Transform target = IsMovingRight ? RightPos : LeftPos;
        //CurrentTarget = target;
        //transform.LookAt (CurrentTarget);
        float direction = IsMovingRight ? -0.14f : 0.14f;
        transform.localScale = new Vector2(direction, transform.localScale.y);

    }

    

}
