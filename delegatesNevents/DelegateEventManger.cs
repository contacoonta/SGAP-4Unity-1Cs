using UnityEngine;
using System.Collections;

public class DelegateEventManager : MonoBehaviour
{
    //1. define delegate
    public delegate void UnitEventHandler( GameObject unit );

    //2. define event
    public static event UnitEventHandler OnUnitSpawn;
    public static event UnitEventHandler OnUnitDestroy;    

    //3. define trigger
    public static void SpawnUnit( GameObject unit )
    {
        if (OnUnitSpawn != null)
            OnUnitSpawn(unit);
    }

    public static void DestroyUnit( GameObject unit )
    {
        if (OnUnitSpawn != null)
            OnUnitDestroy(unit);
    }    
}