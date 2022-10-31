using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tutorial_EventDrivenProgramming
{
    public class EDP_Event_Publisher : MonoBehaviour
    {
        #region Events

        /// <summary>
        /// Data packet sent when this Actor dies
        /// </summary>
        public class OnDeathEventArgs
        {
            public EDP_Event_Publisher DeadActor;
            public bool IsAlive = false;

            public OnDeathEventArgs(bool isAlive, EDP_Event_Publisher deadActor)
            {
                IsAlive = isAlive;
                DeadActor = deadActor;  
            }
        }

        public class OnDeathFunnyEventArgs
        {
            public OnDeathEventArgs args_base;
            public bool isFunny = false;
        }

        public static event System.EventHandler<OnDeathEventArgs> OnDeath;
        public static event System.EventHandler<OnDeathFunnyEventArgs> OnDeathFunny;

        #endregion

        #region Destroy

        private void OnDestroy()
        {
            OnDeath?.Invoke(this, new OnDeathEventArgs(false, this));
        }

        #endregion
    }
}