using UnityEngine;
using System.Collections;

public class DelegateEventManager : MonoBehaviour
{
    //1. define delegate
    public delegate void UnitEventHandler( GameObject unit );

    //2. define event
    public static event UnitEventHandler OnSpawnUnit;

    //3. define trigger
    public static void SpawnUnit( GameObject unit )
    {
        if (OnSpawnUnit != null)
            OnSpawnUnit(unit);
    }
}