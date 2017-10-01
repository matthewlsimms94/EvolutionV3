using UnityEngine;
using UnityEditor;

public class CubeMeshGenerator
{
    //TODO: Move these into a cubemesh class
    public static Mesh createMesh(Mesh mesh, float cubeSize)
    {
        Vector3[] vertices = createVertices(cubeSize);
        int[] triangles = createTriangles();
        return createMeshFromVerticesAndTriangles(mesh, vertices, triangles);
    }

    private static Vector3[] createVertices(float cubeSize)
    {
        float halfCubeSize = cubeSize / 2;
        Vector3[] vertices = new Vector3[]{
            CubeCornerDirections.leftBottomBack(halfCubeSize),
            CubeCornerDirections.rightBottomBack(halfCubeSize),
            CubeCornerDirections.rightTopBack(halfCubeSize),
            CubeCornerDirections.leftTopBack(halfCubeSize),
            CubeCornerDirections.leftTopFront(halfCubeSize),
            CubeCornerDirections.rightTopFront(halfCubeSize),
            CubeCornerDirections.rightBottomFront(halfCubeSize),
            CubeCornerDirections.leftBottomFront(halfCubeSize)
        };
        return vertices;
    }

    private static int[] createTriangles()
    {
        int[] triangles = new int[]{
            0, 2, 1, //Front
	        0, 3, 2,
            2, 3, 4, //Top
	        2, 4, 5,
            1, 2, 5, //Right
	        1, 5, 6,
            0, 7, 4, //Left
	        0, 4, 3,
            5, 4, 7, //Back
	        5, 7, 6,
            0, 6, 7, //Bottom
	        0, 1, 6
        };
        return triangles;
    }

    private static Mesh createMeshFromVerticesAndTriangles(Mesh mesh, Vector3[] vertices, int[] triangles)
    {
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.RecalculateNormals();
        return mesh;
    }

}