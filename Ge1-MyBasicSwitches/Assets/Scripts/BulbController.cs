using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulbController : SwitchController {
    private bool bulbOff = true;

    private Animator bulbAnimator;

    private void Awake()
    {
        bulbAnimator = gameObject.GetComponent<Animator>();
        bulbOff();
    }
    public void BulbOn()
    {
        lightOff = false;
        bulbAnimator.SetBool("BulbOff", false);//switchOff used because false is set in the variable above (you can also write false for shorthand if u wish)
    }

    public void BulbOff()
    {
        lightOff = true;
        bulbAnimator.SetBool("BulbOff", true);
    }
}
