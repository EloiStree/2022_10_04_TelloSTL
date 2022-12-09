using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StlBladeRotatingForFun : MonoBehaviour
{
    public float m_rotationSpeed=720f;
    public Vector3 m_axis = Vector3.up;
    public Transform m_whatToRotate;
    void Update()
    {
        m_whatToRotate.Rotate(m_axis, m_rotationSpeed * Time.deltaTime, Space.Self);
    }

    private void Reset()
    {
        m_whatToRotate = this.transform;
    }
}
