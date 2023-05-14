using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroSceneScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait());
    }

    // Update is called once per frame
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3);

        SceneManager.LoadScene("EntraceMenu");

    }
}
