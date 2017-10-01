using UnityEngine;
using System.Collections.Generic;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]

public class SoftCube : MonoBehaviour, Cube
{
    private const int NO_OF_CORNERS = 8;
    private const float CUBE_SIZE = 1;
    private SoftCubeCorner[] cornerBodies = new SoftCubeCorner[NO_OF_CORNERS];
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

    }

    public void create()
    {
        createMesh();
    }

    //TODO: Doesn't return anything right now!
    public Vector3 getPosition()
    {
        return new Vector3();
    }

    //Ditto
    public Mesh getMesh()
    {
        return null;
    }

    //TODO: Move these into a cubemesh class
    public void createMesh()
    {
        Mesh baseMesh = GetComponent<MeshFilter>().mesh;
        mesh = CubeMeshGenerator.createMesh(baseMesh, CUBE_SIZE);
        vertices = mesh.vertices;
    }

    private void updateVertices()
    {
        mesh.vertices = vertices;
    }

}
