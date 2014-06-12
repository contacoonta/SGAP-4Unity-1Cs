using UnityEngine;
using System.Collections;

public class DelegateEventListener : MonoBehaviour
{
    void Start()
    {
        UnitDelegateEvent.OnUnitSpawn += this.OnUnitSpawn;
    }

    void Destroy()
    {
        UnitDelegateEvent.OnUnitSpawn -= this.OnUnitSpawn;
    }

    public void OnUnitSpawn( GameObject unit )
    {
        
    }

}
