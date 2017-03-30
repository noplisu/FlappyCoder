using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour {
	void Update () {
        outOfCamera();
    }

    void outOfCamera()
    {
        Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position);
        if (viewPos.x < 0) { Destroy(gameObject); }
    }
}
