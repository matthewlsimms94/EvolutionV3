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
    private CubeCorner cubeCentre;
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
        cubeCentre = SoftCubeCorner.createInstance(transform, CORNER_SIZE, new Vector3(), new Vector3());
    }

    private void createCorners()
    {
        corners = CubeMeshGenerator.createCorners(transform, vertices, CORNER_SIZE);
    }

    private void connectCorners()
    {

    }

    public Vector3 getPosition()
    {
        return cubeCentre.getPosition();
    }

}
