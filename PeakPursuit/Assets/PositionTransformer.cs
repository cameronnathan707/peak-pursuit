using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionTransformer : MonoBehaviour
{
    public void MoveObjectToPosition(GameObject objectToMove, float x, float y, float z) {
        objectToMove.transform.position = new Vector3(x,y,z);
    }
}
