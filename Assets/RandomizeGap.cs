using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeGap : MonoBehaviour {
    public Transform upper;
    public Transform lower;
    public float minOffset = -3;
    public float maxOffset = 3;
    public float minGap = 2;
    public float maxGap = 4;

	void Awake () {
        float offset = Random.Range(minOffset, maxOffset);
        float gap = Random.Range(minGap, maxGap);

        Vector3 upperPosition = upper.position;
        upperPosition.y = upper.position.y + offset + gap;
        upper.position = upperPosition;

        Vector3 lowerPosition = lower.position;
        lowerPosition.y = lower.position.y + offset - gap;
        lower.position = lowerPosition;
    }
}
