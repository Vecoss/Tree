using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CuttingTree : MonoBehaviour
{
    [SerializeField, Range(0, 100)] int treeHP = 100;
    [SerializeField] int dmg = 20;
    public GameObject tree;
    public GameObject cutTree;
    public GameObject logs;
    private bool isTreeCut = false;
    public TreeOnGround isOnGround;
    private bool isTreeExist = false;
    private void Awake()
    {
        if (!isTreeExist)
        {
            Debug.Log("Spawn");
            GameObject newObject = Instantiate(tree, gameObject.transform.position, gameObject.transform.rotation);
            tree = newObject;
        }
    }
    private void Update()
    {
        Cutting();
         if (isOnGround.isTreeTouchGround)
        {
            Falling();
        }
    }

    private void Cutting()
    {
        if(treeHP <= 0 && !isTreeCut)
        {
            Debug.Log("Uciête");
            GameObject newObject = Instantiate(cutTree, tree.transform.position, tree.transform.rotation);
            cutTree = newObject;
            DestroyImmediate(tree, true);
            isTreeCut = true;
        }
    }

    private void Falling()
    {
            Debug.Log("Le¿y");
            GameObject newObject = Instantiate(logs, cutTree.transform.position, cutTree.transform.rotation);
            logs = newObject;
            DestroyImmediate(cutTree, true);
            isOnGround.isTreeTouchGround = false;
    }
}
