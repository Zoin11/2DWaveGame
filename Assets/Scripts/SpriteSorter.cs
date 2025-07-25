using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class SpriteSorter : MonoBehaviour
{

    //public bool isStatic = false; 
    public float offset = 0;
    private int SortingOdrerBase = 0;
    private Renderer renderer;

    private void Awake()
    {
        renderer = GetComponent<Renderer>();
    }

    private void LateUpdate()
    {
        renderer.sortingOrder = (int)(SortingOdrerBase - transform.position.y + offset);

        /*if (isStatic)
            Destroy(this);*/
    }

}
