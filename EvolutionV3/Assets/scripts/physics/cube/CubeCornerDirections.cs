using UnityEngine;

public class CubeCornerDirections
{
    private enum Direction
    {
        LEFT_BOTTOM_BACK,
        RIGHT_BOTTOM_BACK,
        RIGHT_TOP_BACK,
        LEFT_TOP_BACK,
        LEFT_TOP_FRONT,
        RIGHT_TOP_FRONT,
        RIGHT_BOTTOM_FRONT,
        LEFT_BOTTOM_FRONT
    }

    private static Vector3 cornerDirection(Direction direction, float scale)
    {
        switch (direction) {
            case Direction.LEFT_BOTTOM_BACK:
                return new Vector3(-1, -1, -1) * scale;
            case Direction.LEFT_TOP_BACK:
                return new Vector3(-1, 1, -1) * scale;
            case Direction.LEFT_BOTTOM_FRONT:
                return new Vector3(-1, -1, 1) * scale;
            case Direction.LEFT_TOP_FRONT:
                return new Vector3(-1, 1, 1) * scale;
            case Direction.RIGHT_BOTTOM_BACK:
                return new Vector3(1, -1, -1) * scale;
            case Direction.RIGHT_TOP_BACK:
                return new Vector3(1, 1, -1) * scale;
            case Direction.RIGHT_BOTTOM_FRONT:
                return new Vector3(1, -1, 1) * scale;
            case Direction.RIGHT_TOP_FRONT:
                return new Vector3(1, 1, 1) * scale;
        }
        return new Vector3(0, 0, 0);
    }

    public static Vector3 leftBottomBack(float scale)
    {
        return cornerDirection(Direction.LEFT_BOTTOM_BACK, scale);
    }

    public static Vector3 leftTopBack(float scale)
    {
        return cornerDirection(Direction.LEFT_TOP_BACK, scale);
    }

    public static Vector3 leftBottomFront(float scale)
    {
        return cornerDirection(Direction.LEFT_BOTTOM_FRONT, scale);
    }

    public static Vector3 leftTopFront(float scale)
    {
        return cornerDirection(Direction.LEFT_TOP_FRONT, scale);
    }

    public static Vector3 rightBottomBack(float scale)
    {
        return cornerDirection(Direction.RIGHT_BOTTOM_BACK, scale);
    }

    public static Vector3 rightTopBack(float scale)
    {
        return cornerDirection(Direction.RIGHT_TOP_BACK, scale);
    }

    public static Vector3 rightBottomFront(float scale)
    {
        return cornerDirection(Direction.RIGHT_BOTTOM_FRONT, scale);
    }

    public static Vector3 rightTopFront(float scale)
    {
        return cornerDirection(Direction.RIGHT_TOP_FRONT, scale);
    }
}
