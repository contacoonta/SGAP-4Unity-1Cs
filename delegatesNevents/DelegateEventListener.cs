using UnityEngine;
using System.Collections;

public class DelegateEventListener : MonoBehaviour
{
    void Start()
    {
        UnitDelegateEvent.OnUnitSpawn += this.SpawnUnit;
    }

    void Destroy()
    {
        UnitDelegateEvent.OnUnitSpawn -= this.SpawnUnit;
    }

    public void SpawnUnit( GameObject unit )
    {
        // ui hp bar
    }

    public void DestroyUnit( GameObject unit )
    {

    }
}