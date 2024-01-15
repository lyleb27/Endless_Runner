using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PikeCollider : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Pike Collider script");
        if (other.tag == "Player")
        {
            Debug.Log("T'as perdu mais flemme de faire le menu");
            SceneManager.LoadScene("Menu");
        }
        Destroy(other.gameObject);
    }
}