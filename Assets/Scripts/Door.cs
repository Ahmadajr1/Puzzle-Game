using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Animator _doorAnimator;
    private static readonly int open = Animator.StringToHash("open");

    private void Start()
    {
        _doorAnimator = transform.parent.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            _doorAnimator.SetTrigger(open);
    }
}
