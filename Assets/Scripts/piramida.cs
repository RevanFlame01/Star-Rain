using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piramida : MonoBehaviour
{
    public GameObject myLihgt;
    private float _time;
   
    void Start()
    {
        _time = 0f;
        myLihgt.SetActive(false);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        _time = 1f;
            if (_time == 1f)
        {
            myLihgt.SetActive(true);
            _time = 0f;
        }


       

    }

    private void FixedUpdate()
    {
        if (_time == 0f)
        {
            myLihgt.SetActive(false);
        }

    }
}
