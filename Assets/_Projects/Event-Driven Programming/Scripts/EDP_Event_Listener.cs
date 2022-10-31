using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Tutorial_EventDrivenProgramming
{
    public class EDP_Event_Listener : MonoBehaviour
    {
        private void OnEnable()
        {
            EDP_Event_Publisher.OnDeath += EDP_Event_Publisher_OnDeath;
            EDP_Event_Publisher.OnDeathFunny += EDP_Event_Publisher_OnDeathFunny;
        }

        private void OnDisable()
        {
            EDP_Event_Publisher.OnDeath -= EDP_Event_Publisher_OnDeath;
            EDP_Event_Publisher.OnDeathFunny -= EDP_Event_Publisher_OnDeathFunny;
        }

        private void EDP_Event_Publisher_OnDeath(object sender, EDP_Event_Publisher.OnDeathEventArgs args)
        {
            PrintArgs(args);
        }
        private void EDP_Event_Publisher_OnDeathFunny(object sender, EDP_Event_Publisher.OnDeathFunnyEventArgs args)
        {
            PrintArgs(args.args_base);
        }

        void PrintArgs(EDP_Event_Publisher.OnDeathEventArgs args)
        {
            Debug.Log($"Is Alive: {args.IsAlive}, Dead Object: {args.DeadActor.gameObject.name}");
        }
    }
}