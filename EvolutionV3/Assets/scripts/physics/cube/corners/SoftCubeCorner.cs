using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(SphereCollider))]

public class SoftCubeCorner : MonoBehaviour, CubeCorner
{
    private SphereCollider sphereCollider;
    private Vector3 positionMod;

    public void Start()
    {
    }

    public void setPosition(Vector3 position)
    {
        transform.localPosition = position + positionMod;
    }

    public Vector3 getPosition()
    {
        return transform.localPosition + positionMod;
    }

    public static CubeCorner createInstance(Transform parent, float size, Vector3 position, Vector3 positionMod)
    {
        GameObject createdGameObject = new GameObject("CORNER", typeof(SoftCubeCorner));
        SoftCubeCorner createdCorner = createdGameObject.GetComponent<SoftCubeCorner>();
        createdCorner.setParent(parent);
        createdCorner.setSize(size);
        createdCorner.setPosition(position);
        createdCorner.positionMod = positionMod;
        return createdCorner;
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

    private void setParent(Transform parent)
    {
        transform.SetParent(parent);
    }
}
