using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookStart : MonoBehaviour
{
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        //animator.Play("Armature|ArmatureAction");   
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BookRun()
    {
        //animator.Play("Armature|ArmatureAction");

        animator.enabled = true;
    }

}
