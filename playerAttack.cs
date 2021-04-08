using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack : MonoBehaviour
{
    public projectileBehaviour RockPrefab;
    public Transform LaunchOffset;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Instantiate(RockPrefab, LaunchOffset.position, transform.rotation);
        }
    }
}
