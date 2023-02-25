using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class TempO2 : MonoBehaviour
{
    public bool v;
    public Slider temp;
    public float deg;

    public Slider O2;
    public bool o;


    // Update is called once per frame
    void Update()
    {
        if (v)
        {
            temp.value += deg ;
        }
        else
        {
            temp.value -= deg ;
        }

        if (!o)
        {
            O2.value -= 0.01f; 

        }
        else
        {
            O2.value += deg ;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("temp")) 
        { 
          v = true;
        }
        if (other.CompareTag("O2"))
        {
            o = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {

        if (other.CompareTag("temp"))
        {
            v = false;
        }
        if (other.CompareTag("O2"))
        {
            o = false;
        }
    }
    
    
}
