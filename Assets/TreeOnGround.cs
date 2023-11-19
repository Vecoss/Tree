using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TreeOnGround", menuName = "Tree")]
public class TreeOnGround : ScriptableObject
{
    [SerializeField] public bool isTreeTouchGround = false;
}
