using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class Playanimsyarn : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    [YarnCommand("PlayShakeFlustered")]
    public void PlayShakeFlustered()
    {
        animator.Play("ShakeFlustered");
    }
    [YarnCommand("PlayFlusteredStill")]
    public void PlayFlusteredStill()
    {
        animator.Play("FlusteredStill");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
                animator.Play("ShakeFlustered");
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.Play("FlusteredStill");
        }
    }
}
