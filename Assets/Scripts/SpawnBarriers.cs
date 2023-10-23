using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBarriers : MonoBehaviour
{

    [SerializeField] private List<Transform> BarriersPartList;
    
    void Start()
    {
        Transform parent = this.transform;
        Transform Barriers = BarriersPartList[Random.Range(0, BarriersPartList.Count)];
        Vector3 SpawnPosition = new Vector3(Barriers.transform.position.x, Barriers.transform.position.y , this.transform.position.z);
        Instantiate(Barriers, SpawnPosition, Barriers.transform.rotation, parent);
    }
}
