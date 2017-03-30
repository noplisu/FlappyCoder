using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {
  #region Public variables
    public Transform followObject;
  #endregion

  #region Private variables
    Vector3 distance;
  #endregion

  #region Unity callbacks
    void Start () {
        distance = transform.position - followObject.position;
	}
	
	void Update () {
        Vector3 position = transform.position;
        position.x = followObject.position.x + distance.x;
        transform.position = position;
    }
  #endregion
}
