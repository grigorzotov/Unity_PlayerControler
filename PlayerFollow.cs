using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour {

    public Transform player;
    public Vector3 offset;
    public float smoothSpeed = 0.125f;

	// Update is called once per frame
	void FixedUpdate () {
        Vector3 desiredPostion = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPostion, smoothSpeed );

        transform.position = smoothedPosition;

        transform.LookAt(player);

	}
}
