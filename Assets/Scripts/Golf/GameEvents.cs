using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class GameEvents : MonoBehaviour
    {
        public static System.Action onCollisionStones;

        public static void CollisionnStoneInvoke()
        {
            onCollisionStones?.Invoke();
        }
    }
}
