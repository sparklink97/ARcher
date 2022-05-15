using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class SpawnTargets : MonoBehaviour
{
    [SerializeField]
    private GameObject target;

   
    public bool isReady;
    private bool wasStarted;

    // Start is called before the first frame update
    void Update()
    {
        if(isReady && !wasStarted)
        {
            wasStarted = true;
            StartCoroutine(StartSpawningTargets());
        }
    }

    IEnumerator StartSpawningTargets()
    {
        yield return new WaitForSeconds(2);

        Instantiate(target, new Vector3(Random.Range(-8.0f, 8.0f), -2.0f, Random.Range(-8.0f, 8.0f)), Quaternion.identity);
        StartCoroutine(StartSpawningTargets());
    }
}
