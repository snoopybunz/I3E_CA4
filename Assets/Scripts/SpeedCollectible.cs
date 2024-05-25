using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedCollectible : Collectible
{
    public float speedIncrease = 5f;

    public override void Collected()
    {
        base.Collected();
        var player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            var controller = player.GetComponent<StarterAssets.FirstPersonController>();
            if (controller != null)
            {
                controller.MoveSpeed += speedIncrease;
                Debug.Log("Player speed increased!");
            }
        }
        Destroy(gameObject);
    }
}
