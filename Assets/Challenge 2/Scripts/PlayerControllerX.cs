using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timePassed = 0f;
    private bool spaceHasBeenPressed = false;
    public float allowedPressedFrq = 1.5f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && !spaceHasBeenPressed)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            spaceHasBeenPressed = true;
        }

        if(spaceHasBeenPressed) timePassed += Time.deltaTime;
        
        if(timePassed >= allowedPressedFrq)
        {
            spaceHasBeenPressed = false;
            timePassed = 0;     
        }
    }
}
