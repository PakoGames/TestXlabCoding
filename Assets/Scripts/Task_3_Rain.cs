using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task_3_Rain : MonoBehaviour
{
    public enum PathTypes
    {
        linear,
        loop
    }

    public PathTypes pathTypes;
    public int movementDirection = 1;
    public int moveingTo = 0;
    public Transform[] PathElements;

    public IEnumerator<Transform> GetNextPathPoint()
    {
        if (PathElements == null || PathElements.Length < 1)
        {
            yield break;
        }

        while (true)
        {
            yield return PathElements[moveingTo];

            if (PathElements.Length == 1)
            {
                continue;
            }

            if (pathTypes == PathTypes.linear)
            {
                if (moveingTo <= 0)
                {
                    movementDirection = 1;
                }

                else if (moveingTo >= PathElements.Length - 1)
                {
                    movementDirection = -1;
                }
            }
            moveingTo = moveingTo + movementDirection;

            if (pathTypes == PathTypes.loop)
            {
                if (moveingTo >= PathElements.Length)
                {
                    moveingTo = 0;
                }
            }

            if (moveingTo < 0)
            {
                moveingTo = PathElements.Length - 1;
            }
        }
    }


}
