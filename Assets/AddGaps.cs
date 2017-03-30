using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddGaps : MonoBehaviour {
  #region Public variables
    public GameObject gap;
    public float cooldown = 1;
    #endregion

    #region Private variables
    Plane plane;
    Camera cam;
    Vector3 viewportVector = new Vector3(1, 0.5f, 0);
  #endregion

  #region Unity callbacks
    void Start () {
        cam = Camera.main;
        plane = new Plane(Vector3.back, Vector3.zero);
        StartCoroutine(CreateGap());
    }
  #endregion

  #region Private methods
    IEnumerator CreateGap()
    {
        Ray ray = cam.ViewportPointToRay(viewportVector);
        float distance;
        plane.Raycast(ray, out distance);
        Vector3 spawnPoint = ray.GetPoint(distance);
        Instantiate(gap, spawnPoint, gap.transform.rotation);
        yield return new WaitForSeconds(cooldown);
        StartCoroutine(CreateGap());
    }
  #endregion
}
