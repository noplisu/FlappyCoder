using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour {
  #region Public variables
    public float jumpForce = 10;
    public float speed = 1;
  #endregion

  #region Private variables
    Rigidbody rigid;
  #endregion

  #region Unity callbacks
    void Start () {
        rigid = GetComponent<Rigidbody>();	
	}
	
	void Update () {
        outOfCamera();
        fly();
        move();
    }

    void OnCollisionEnter(Collision collision) {
        dead();
    }
  #endregion

  #region Private methods
    void move()
    {
        Vector3 velocity = rigid.velocity;
        velocity.x = speed;
        rigid.velocity = velocity;
    }

    void fly() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            rigid.velocity = Vector3.zero;
            rigid.AddForce(Vector3.up * jumpForce);
        }
    }

    void dead() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void outOfCamera() {
        Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position);
        if (viewPos.y < 0 || viewPos.y > 1) { dead(); }
    }
  #endregion
}
