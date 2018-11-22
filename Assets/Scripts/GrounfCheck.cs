using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrounfCheck : MonoBehaviour
{

    public int touches;

    private void OnTriggerEnter2D(Collider2D other)
    {
        touches++;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        touches--;
    }
}
