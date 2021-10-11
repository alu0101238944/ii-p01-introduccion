
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour {
  int iterations = 0;
  public int id;
  // Update is called once per frame
  void Update() {
    Debug.Log(System.String.Format("Tag: {0}, Id: {1}, Iterations: {2}",
        gameObject.tag, id, iterations++));
  }
}
