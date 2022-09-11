using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalDoor : MonoBehaviour
{
    private Animator _doorAnimator;
    private static readonly int open = Animator.StringToHash("open");

    private List<string> winningSequence = new List<string> { "Blue Button", "Red Button", "Yellow Button", "Green Button", "Yellow Button", "Blue Button", "Green Button", "Red Button"};
    public List<string> currentSequence = new List<string>();

    private void Start()
    {
        _doorAnimator = gameObject.GetComponent<Animator>();
    }

    public void CheckSequence()
    {
        for (int i = 0; i < currentSequence.Count; i++)
        {
            Debug.Log(currentSequence[i]);
            if (currentSequence[i] != winningSequence[i])
            {
                currentSequence.Clear();
                Debug.Log("reset");
                return;
            }
        }
        if (currentSequence.Count == winningSequence.Count)
            _doorAnimator.SetTrigger(open);
        else
            return;
    }
}
