using UnityEngine;
using UnityEditor;
//TODO: SEPERATE THIS OUT?!
public static class CubeMeshGenerator
{
    public static Mesh createMesh(Mesh mesh, float cubeSize, float cornerSize)
    {
        Vector3[] vertices = createVertices(cubeSize-(cornerSize*2));
        int[] triangles = createTriangles();
        return createMeshFromVerticesAndTriangles(mesh, vertices, triangles);
    }

    private static Vector3[] createVertices(float cubeSize)
    {
        float halfCubeSize = cubeSize / 2;
        Vector3[] vertices = CubeCornerDirections.allDirections(halfCubeSize);
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

    public static CubeCorner[] createCorners(Transform parent, Vector3[] cornerPositions, float cornerSize)
    {
        Vector3[] cornerSizeMod = CubeCornerDirections.allDirections(cornerSize);
        CubeCorner[] corners = new CubeCorner[8];//TODO: HARDCODEY
        for (int i = 0; i < 8; i++)
        {
            CubeCornerDirections.Direction direction = (CubeCornerDirections.Direction)i;
            corners[i] = CubeCorner.createInstance(parent, cornerSize, 
                cornerPositions[i], cornerSizeMod[i], direction);
        }
        return corners;
    }

    public static CubeCorner[] connectCornersToCentre(CubeCorner[] corners, CubeCentre centre)
    {
        foreach (CubeCorner corner in corners)
        {
            corner.connectToCentre(centre);
        }
        return corners;
    }
}