using UnityEngine;

public class lab5 : MonoBehaviour
{
    public Animator firstCharacterAnimator;
    public Animator secondCharacterAnimator;

    void Update()
    {
        // Example: Trigger animation swap on the press of a key (e.g., Space key)
        if (Input.GetKeyDown(KeyCode.Space))
        {
             RuntimeAnimatorController tempController = firstCharacterAnimator.runtimeAnimatorController;
        firstCharacterAnimator.runtimeAnimatorController = secondCharacterAnimator.runtimeAnimatorController;
        secondCharacterAnimator.runtimeAnimatorController = tempController;
        }
    }

    
}
