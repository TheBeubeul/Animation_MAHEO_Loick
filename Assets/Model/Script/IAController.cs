using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using Unity.Jobs.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.AI;

public enum IAState
{
    None,
    Idle,
    Patrol,
    Sleep,
    PlayerSeen,
    PlayerNear
}

public class IAController : MonoBehaviour
{
    private IAState _state = IAState.None;
    [SerializeField] private Animator _animator;
    public bool PlayerNear = false;
    [SerializeField] private NavMeshAgent _agent;
    [SerializeField] private GameObject _waypoint;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CheckTransition();
        Behavior();
    }
    private void Behavior()
    {
        switch (_state)
        {
            case IAState.None:
                //
                //
                break;
            case IAState.Idle:
                //
                //
                break;
            case IAState.Patrol:
                // find next destination
                _agent.SetDestination(_waypoint.transform.position);
                //
                break;
            case IAState.Sleep:
                //
                //
                break;
            case IAState.PlayerSeen:
                //
                //
                break;
            case IAState.PlayerNear:
                //
                //
                break;

        }
    }
    private void CheckTransition()
    {
        switch (_state)
        {
          case IAState.None:
                // je veux vérifier si le player est proche -> PlayerNear
            break;
        case IAState.Idle:
                // je veux vérifier si le player est proche -> PlayerNear
                if (PlayerNear)
                {
                    // change state -> PlayerNear
                    _state = IAState.PlayerNear;
                    _animator.SetBool("Near", true);
                }
                break;
        case IAState.Patrol:
                // je veux vérifier si le player est proche -> PlayerNear
                if (PlayerNear)
                {
                    // change state -> PlayerNear
                    _state = IAState.PlayerNear;
                    _animator.SetBool("Near", true);
                }
                break;
        case IAState.Sleep:
                // je veux vérifier si le player est proche -> PlayerNear
                if (PlayerNear)
                {
                    // change state -> PlayerNear
                    _state = IAState.PlayerNear;
                    _animator.SetBool("Near", true);
                }
                break;
        case IAState.PlayerSeen:
                // je veux vérifier si le player est proche -> PlayerNear
                if (PlayerNear)
                {
                    // change state -> PlayerNear
                    _state = IAState.PlayerNear;
                    _animator.SetBool("Near", true);
                }
                break;
        case IAState.PlayerNear:
                // je veux vérifier si le player est proche -> Patrol
                if (!PlayerNear)
                {
                    // change state -> Patrol
                    _state = IAState.Patrol;
                    _animator.SetBool("Near", false);
                }
                break;

        }
    }
}


