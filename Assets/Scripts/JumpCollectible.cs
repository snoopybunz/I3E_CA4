using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCollectible : Collectible
{
    public float jumpHeightIncrease = 2f;

    public override void Collected()
    {
        base.Collected();
        var player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            var controller = player.GetComponent<StarterAssets.FirstPersonController>();
            if (controller != null)
            {
                controller.JumpHeight += jumpHeightIncrease;
                Debug.Log("Player jump height increased!");
            }
        }
        Destroy(gameObject);
    }
}
