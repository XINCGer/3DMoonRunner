using UnityEngine;
using System.Collections;

public class Board : Obstacle {
    public override void OnTriggerEnter(Collider other)
    {
        if(!PlayerController.instance.isRoll)
            base.OnTriggerEnter(other);
    }
}
