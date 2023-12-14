using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Columns : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other0)
    {
        if (other0.GetComponent<Bird>() != null)
        {
            GameControl.instance.BirdScored();
        }
    }










}
