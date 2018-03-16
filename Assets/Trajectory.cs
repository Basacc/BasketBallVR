using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trajectory : MonoBehaviour {

    public LineRenderer lineRenderer;
    public BallSpawnerWithPropulsion ballSpawner;
    public int stepsNumber;


    void Start () {
       lineRenderer.positionCount = stepsNumber;
        
	}

	List<Vector3> TrajectoryCalculation(Vector3 velocity, Vector3 origin, Vector3 gravity , float time) {
        
        List<Vector3> trajList = new List<Vector3>();
        for (int i = 0; i < stepsNumber; i++)
        {
            float segmenttime = time / stepsNumber * i;
            Vector3 position = origin + velocity * segmenttime + (gravity * segmenttime * segmenttime) * 0.5f;
            trajList.Add(position);
        }
        return trajList;
	}
    void Calc()
    {
        float time = -ballSpawner.forceIntensity*2 / Physics.gravity.y;
        lineRenderer.SetPositions(TrajectoryCalculation(ballSpawner.CalcVelocity(), ballSpawner.forceDirection.position, Physics.gravity, time).ToArray());
    }
    void Update()
    {
        Calc();
    }
}
