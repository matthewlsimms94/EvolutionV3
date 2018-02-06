using UnityEngine;

public static class CubeCornerDirections
{
    public enum Direction
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

    public static Vector3 cornerDirection(Direction direction, float scale)
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

    public static Vector3[] allDirections(float scale)
    {
        return new Vector3[]{
            cornerDirection(Direction.LEFT_BOTTOM_BACK, scale),
            cornerDirection(Direction.RIGHT_BOTTOM_BACK, scale),
            cornerDirection(Direction.RIGHT_TOP_BACK, scale),
            cornerDirection(Direction.LEFT_TOP_BACK, scale),
            cornerDirection(Direction.LEFT_TOP_FRONT, scale),
            cornerDirection(Direction.RIGHT_TOP_FRONT, scale),
            cornerDirection(Direction.RIGHT_BOTTOM_FRONT, scale),
            cornerDirection(Direction.LEFT_BOTTOM_FRONT, scale)
        };
    }

}
