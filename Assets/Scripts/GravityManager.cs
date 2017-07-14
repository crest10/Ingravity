using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityManager : MonoBehaviour {
    private Vector3 forceToAdd = Vector3 (5, 5, 0);
    private GameObject obj;
    private RotateObject other ;
    private Boolean rotating = false;
    private Boolean changegravityminus = false;
    private Boolean changegravityplus = false;

    function Start () {
        other = obj.GetComponent (RotateObject);
    }

    function Update () {
        if (other.gravity == 1) {
            transform.Rotate (0, 0, 0);
            rigidbody.AddForce (0, 0, 0);
            Physics.gravity = new
            Vector3 (0f, -9.81f, 0f);
        }

        if (other.gravity == 2) {
            transform.Rotate (0, 0, 90);
            rigidbody.AddForce (0, 0, 0);
            Physics.gravity = new
            Vector3 (-9.81f, 0f, 0f);
        }

        if (other.gravity == 3) {
            transform.Rotate (0, 0, 90);
            rigidbody.AddForce (0, 0, 0);
            Physics.gravity = new
            Vector3 (0f, 9.81f, 0f);
        }

        if (other.gravity == 4) {
            transform.Rotate (0, 0, 90);
            rigidbody.AddForce (0, 0, 0);
            Physics.gravity = new
            Vector3 (9.81f, 0f, 0f);
        }

        if (Input.GetKeyDown (KeyCode.PageUp) && rotating == false) {
            changegravityminus = false;
            rotating = true;
            transform.Rotate (0, 0, -90);
            rigidbody.velocity = forceToAdd;
            Physics.gravity = Quaternion.Euler (0, 0, -90) * Physics.gravity;
            rotating = false;
            changegravityminus = true;
        }

        if (Input.GetKeyDown (KeyCode.PageDown) && rotating == false) {
            rotating = true;
            transform.Rotate (0, 0, 90);
            rigidbody.velocity = forceToAdd;
            Physics.gravity = Quaternion.Euler (0, 0, 90) * Physics.gravity;
            rotating = false;
        }
    }
}