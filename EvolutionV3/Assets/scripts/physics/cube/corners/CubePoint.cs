using UnityEngine;
using System.Collections;

public interface CubePoint
{
    void setPosition(Vector3 position);
    Vector3 getPosition();
    Rigidbody getRigidbody();
}
