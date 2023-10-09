using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHit : MonoBehaviour
{
    public Animator anim;

    public void HitAnim()
    {
        anim.SetTrigger("Hit");
        anim.SetTrigger("Idle");
    }
}
