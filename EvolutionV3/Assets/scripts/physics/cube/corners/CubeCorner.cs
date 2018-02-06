using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(SphereCollider))]

public class CubeCorner : MonoBehaviour, CubePoint
{
    private SphereCollider sphereCollider;
    private Rigidbody cubeRigidbody;
    private Vector3 positionMod;
    private CubeCornerDirections.Direction direction;

    private void Start()
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

    public void connectToCentre(CubePoint centre)
    {
        //TODO:
    }

    public static CubeCorner createInstance(Transform parent, float size, Vector3 position, 
        Vector3 positionMod, CubeCornerDirections.Direction direction)
    {
        GameObject createdGameObject = new GameObject("CORNER", typeof(CubeCorner));
        CubeCorner createdCorner = createdGameObject.GetComponent<CubeCorner>();
        createdCorner.setParent(parent);
        createdCorner.setSize(size);
        createdCorner.setPosition(position);
        createdCorner.positionMod = positionMod;
        createdCorner.setDirection(direction);
        return createdCorner;
    }

    private void setParent(Transform parent)
    {
        transform.SetParent(parent);
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

    private void setDirection(CubeCornerDirections.Direction direction)
    {
        this.direction = direction;
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
