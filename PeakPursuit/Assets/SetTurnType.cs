using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SetTurnType : MonoBehaviour
{
    public ActionBasedSnapTurnProvider snapTurn;
    public ActionBasedContinuousTurnProvider continuousTurn;
    

    public void SetTypeFromIndex(int index) {
        snapTurn.enabled = index == 1;
        continuousTurn.enabled = index == 0;
    }
}
