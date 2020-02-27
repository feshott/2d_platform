using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondHandler : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            gameObject.SetActive(false);
        }
    }

}
