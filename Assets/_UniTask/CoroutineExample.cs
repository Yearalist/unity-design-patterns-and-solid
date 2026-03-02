
using System.Collections;
using UnityEngine;

public class CoroutineExample : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            StartCoroutine(DoTasksWithCoroutine());
        }
    }

    private IEnumerator DoTasksWithCoroutine()
    {
        Debug.Log("[Coroutine] Starting tasks...");

        Debug.Log("[Coroutine] Task 1: Loading resources...");
        yield return new WaitForSeconds(1f);
        Debug.Log("[Coroutine] Task 1: Done!");

        Debug.Log("[Coroutine] Task 2: Processing data...");
        yield return new WaitForSeconds(2f);
        Debug.Log("[Coroutine] Task 2: Done!");

        Debug.Log("[Coroutine] Task 3: Saving progress...");
        yield return new WaitForSeconds(1f);
        Debug.Log("[Coroutine] Task 3: Done!");

        Debug.Log("[Coroutine] All tasks completed!");
    }

}
