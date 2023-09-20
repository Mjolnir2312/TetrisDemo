using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostBlock : Block
{
    internal bool IsDestroyed() {
        return transform.childCount == 0;
    }

    private void OnMouseDown()
    {
        Debug.Log("You are click in the GhostBlock:" + this.name);
    }
}
