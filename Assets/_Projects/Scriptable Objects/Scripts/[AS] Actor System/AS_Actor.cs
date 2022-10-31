using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ActorSystem
{
    public class AS_Actor : MonoBehaviour
    {
        public AS_ActorBaseStats _BaseStats;

        public float CurrentHP;
        public float CurrentSpeed;

        private void Update()
        {
            CurrentHP = _BaseStats.MaxHP;
            CurrentSpeed = _BaseStats.MaxSpeed;
        }
    }
}