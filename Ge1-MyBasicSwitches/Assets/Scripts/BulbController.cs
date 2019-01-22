using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulbController : MonoBehaviour {

    private Animator bulbAnimator;
    public bool bulbOn;

    void Awake()
    {
        bulbAnimator = gameObject.GetComponent<Animator>();
        bulbOn = false;
    }

    public void turnOn()
    {
        bulbAnimator.SetBool("BulbOn", true);
    }

    public void turnOff()
    {
        bulbAnimator.SetBool("BulbOn", false);
    }
}
