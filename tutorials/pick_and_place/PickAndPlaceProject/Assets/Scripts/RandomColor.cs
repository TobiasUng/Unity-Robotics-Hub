using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{

    public Material[] colors;
    

    // Start is called before the first frame update
    void Start()
    {
        //this.GetComponent<Renderer>().material = colors[Random.Range(0, colors.Length)];
    } 
}
