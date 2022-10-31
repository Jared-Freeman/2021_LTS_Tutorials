using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ActorSystem
{
    [CreateAssetMenu(menuName = "ActorSystem/ActorBaseStats", order = 1)]
    public class AS_ActorBaseStats : ScriptableObject
    {
        public float MaxHP;
        public float MaxSpeed;

        public AS_Actor CreateActor(GameObject host = null)
        {
            GameObject go;
            if (host == null)
            {
                go = new GameObject("New Actor");
            }
            else go = host;

            var actor = go.AddComponent<AS_Actor>();
            actor._BaseStats = this;

            return actor;
        }
    }
}