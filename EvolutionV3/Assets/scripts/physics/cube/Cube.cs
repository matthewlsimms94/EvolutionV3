using UnityEngine;

public interface Cube {
    Vector3 getPosition();
    void create();
    Mesh getMesh();
    void createMesh();//Maybe delete at this level? Make private?
}
