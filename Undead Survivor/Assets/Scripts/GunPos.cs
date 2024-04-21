using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPos : MonoBehaviour
{
    SpriteRenderer player;

    Vector3 rightGunPos = new Vector3(1.1f, -0.05f, 0);
    Vector3 rightGunPosReverse = new Vector3(-1f, -0.05f, 0);

    private void Awake()
    {
        player = GetComponentsInParent<SpriteRenderer>()[0];
    }

    private void LateUpdate()
    {
        bool isReverse = player.flipX;

        transform.localPosition = isReverse ? rightGunPosReverse : rightGunPos;
    }
}
