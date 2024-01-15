using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinCollider : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Respawn")
        {
            Debug.Log("pièce supprimée");
            Destroy(gameObject);
        }
        if (other.tag == "Player")
        {
            Debug.Log("piece gagnée");
            /*coin compteur +1*/
        }
    }
}