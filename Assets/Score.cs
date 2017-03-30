using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {
    public int points = 1;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ScoreManager.instance.addScore(points);
        }
    }
}
