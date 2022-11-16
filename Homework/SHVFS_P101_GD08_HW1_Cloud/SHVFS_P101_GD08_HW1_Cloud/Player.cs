using System;
using System.Collections.Generic;

namespace SHVFS_P101_GD08_C7_SnakesOnATrain
{
    public class Player
    {
        // Speed
        public Vector2 Position;
        // 
        public Vector2 Direction;
        
        #region Data structures
        public Dictionary<ConsoleKey, Vector2> InputDirections;
        #endregion
    }
}