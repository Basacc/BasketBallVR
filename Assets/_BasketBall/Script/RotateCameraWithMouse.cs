using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCameraWithMouse : MonoBehaviour {

    public Transform _cameraToAffect;
    public float _horizontalDegreeRotation = 90;
    public float _verticalDegreeRotation = 90;
    public float _verticalPourcent;
    public float _horizontaPourcent;
    public Vector3 _positionMouse;

	// Update is called once per frame
	void Update () {

#if UNITY_EDITOR

        float horizontalPourcent = Input.mousePosition.x / Screen.width;
        float verticalPourcent = Input.mousePosition.y / Screen.height;
        _horizontaPourcent = horizontalPourcent;
        _verticalPourcent = verticalPourcent;

        _positionMouse = Input.mousePosition;

        horizontalPourcent -= 0.5f;
        horizontalPourcent *= 2f;

        verticalPourcent -= 0.5f;
        verticalPourcent *= 2f;

        horizontalPourcent = Mathf.Clamp(horizontalPourcent, -1f, 1f);
        verticalPourcent = Mathf.Clamp(verticalPourcent, -1f, 1f);

        _cameraToAffect.localRotation = Quaternion.Euler(new Vector3(_verticalDegreeRotation*verticalPourcent, _horizontalDegreeRotation* horizontalPourcent, 0));

#endif

    }
}
