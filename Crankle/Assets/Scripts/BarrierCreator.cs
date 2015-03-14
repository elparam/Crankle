using UnityEngine;

public class BarrierCreator : MonoBehaviour
{
    public GameObject Barrier;
    private Transform _lastBarrier;

    void Start()
    {

    }

    void Update()
    {
        if (IsDistanceForCreation())
        {
            CreateBarrier();
        }
    }

    private bool IsDistanceForCreation()
    {
        if (_lastBarrier == null) return true;
        var distance = transform.position.x - _lastBarrier.position.x;
        return distance > GameData.DistanceBetweenBorders;
    }

    private void CreateBarrier()
    {
        var position = transform.position;
        if (_lastBarrier != null)
        {
            position.y = _lastBarrier.transform.position.y + Random.Range(-GameData.BorderPositionDifference, GameData.BorderPositionDifference);
            while (Mathf.Abs(position.y) > 3f)
            {
                position.y = _lastBarrier.transform.position.y + Random.Range(-GameData.BorderPositionDifference, GameData.BorderPositionDifference);
            }
        }
        var barrier = (GameObject)Instantiate(Barrier, position, Quaternion.identity);
        _lastBarrier = barrier.transform;
        _lastBarrier.GetComponent<BarrierController>().MoveBarrier();
    }

}
