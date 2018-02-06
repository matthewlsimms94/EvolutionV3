using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(SphereCollider))]

public class CubeCentre : MonoBehaviour, CubePoint
{
    private SphereCollider sphereCollider;
    private Rigidbody cubeRigidbody;

    public Vector3 getPosition()
    {
        return transform.localPosition;
    }

    public void setPosition(Vector3 position)
    {
        transform.localPosition = position;
    }

    public static CubeCentre createInstance(Transform parent, float size)
    {
        GameObject createdGameObject = new GameObject("CENTRE", typeof(CubeCentre));
        CubeCentre createdCentre = createdGameObject.GetComponent<CubeCentre>();
        createdCentre.setParent(parent);
        createdCentre.setSize(size);
        createdCentre.setPosition(new Vector3());
        return createdCentre;
    }

    private void setParent(Transform parent)
    {
        transform.parent = parent;
    }

    private void setSize(float size)
    {
        getSphereCollider().radius = size;
    }

    private SphereCollider getSphereCollider()
    {
        if (sphereCollider == null)
        {
            sphereCollider = GetComponent<SphereCollider>();
        }
        return sphereCollider;
    }

    public Rigidbody getRigidbody()
    {
        if (cubeRigidbody == null)
        {
            cubeRigidbody = GetComponent<Rigidbody>();
        }
        return cubeRigidbody;
    }
}
