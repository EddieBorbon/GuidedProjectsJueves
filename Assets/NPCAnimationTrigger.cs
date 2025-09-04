using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCAnimationTrigger : MonoBehaviour
{
    public Animator npcAnimator;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")){
            int randomIndex = Random.Range(1,4);
            npcAnimator.SetInteger("TalkIndex",randomIndex);
        }
    }
}
