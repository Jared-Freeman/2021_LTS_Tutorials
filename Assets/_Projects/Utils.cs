using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Utils
{
    public static class Validate
    {
        public static bool IsNull(object obj)
        {
            if (obj == null) return true;
            return false;
        }

        public static bool IsNull(object[] objects)
        {
            bool result = true;
            foreach(object obj in objects)
            {
                if (IsNull(obj)) result = false;
            }
            return result;
        }
    }
}