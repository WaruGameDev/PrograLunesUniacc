using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowTheTarget : MonoBehaviour
{
    public NavMeshAgent theAgent;
    public Transform target;
   
    // Start is called before the first frame update
    void Start()
    {
        theAgent.SetDestination(target.position);
    }
    


}
