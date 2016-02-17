using UnityEngine;
using System.Collections;

namespace shootemup
{
    public static class Action
    {
        public enum MoveAction
        {
            NONE = -1,
            BRAKE = 0,
            UP = 1,
            RIGHT = 2,
            DOWN = 3,
            LEFT = 4
        }
    }
}