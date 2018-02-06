using UnityEngine;
using System.Collections.Generic;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]

public class SoftCube : MonoBehaviour, Cube
{
    private const int NO_OF_CORNERS = 8;
    private const float CUBE_SIZE = 1f;
    private const float CORNER_SIZE = 0.1f;
    private CubeCorner[] corners = new CubeCorner[NO_OF_CORNERS];
    private CubeCentre centre;
    private Vector3[] vertices;
    private Mesh mesh;

    // Use this for initialization
    void Start()
    {
        create(); 
    }

    // Update is called once per frame
    void Update()
    {
        updateVertices();
    }

    private void updateVertices()
    {
        updateStoredVertices();
        mesh.vertices = vertices;
    }

    private void updateStoredVertices()
    {
        for (int i = 0; i < NO_OF_CORNERS; i++)
        {
            vertices[i] = corners[i].getPosition();
        }
    }

    private void create()
    {
        createMesh();
        createCentre();
        createCorners();
        connectCorners();
    }

    public void createMesh()
    {
        Mesh baseMesh = GetComponent<MeshFilter>().mesh;
        mesh = CubeMeshGenerator.createMesh(baseMesh, CUBE_SIZE, CORNER_SIZE);
        vertices = mesh.vertices;
    }

    private void createCentre()
    {
        centre = CubeCentre.createInstance(transform, CORNER_SIZE);
    }

    private void createCorners()
    {
        corners = CubeMeshGenerator.createCorners(transform, vertices, CORNER_SIZE);
    }

    private void connectCorners()
    {
        CubeMeshGenerator.connectCornersToCentre(corners, centre);
    }

    public Vector3 getPosition()
    {
        return centre.getPosition();
    }

}
