using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinCollider : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Respawn")
        {
            Destroy(gameObject);
            Debug.Log("GG NOOBY");
            /*SceneManager.LoadScene("Menu");*/
        }
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("piece gagnée");
            /*coin compteur +1*/
        }
    }
}