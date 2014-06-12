using UnityEngine;
using System.Collections;

public class DelegateEventListener : MonoBehaviour
{
    void Start()
    {
        UnitDelegateEvent.OnSpawnUnit += this.OnSpawnUnit;
    }

    void OnDestroy()
    {
        UnitDelegateEvent.OnSpawnUnit -= this.OnSpawnUnit;
    }

    public void OnSpawnUnit( GameObject unit )
    {
        
    }

}
