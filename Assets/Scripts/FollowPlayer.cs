using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public float FollowSpeed = 2f;
    public float yOffset =1f;
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        if (target.position.x > -15 && transform.position.x < 130.1738) {
            Vector3 newPos = new Vector3(target.position.x,target.position.y + yOffset,-10f);
            transform.position = Vector3.Slerp(transform.position,newPos,FollowSpeed*Time.deltaTime);
        }
    }
}