using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinCollider : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == GameObject.Find("pikePrefab(clone)"))
        {
            Destroy(gameObject);
            /*SceneManager.LoadScene("Menu");*/
        } else
        {
            Destroy(gameObject);
            /*COMPTEUR DE PIECE +1*/
        }
    }
}