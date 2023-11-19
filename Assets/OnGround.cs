using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGround : MonoBehaviour
{
    public TreeOnGround onGround;
    private void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "Ground")
        {
            onGround.isTreeTouchGround = true;
        }
    }
}
