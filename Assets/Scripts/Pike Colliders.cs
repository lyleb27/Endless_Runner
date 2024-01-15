using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PikeCollider : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("T'as perdu mais flemme de faire le menu");
            /*SceneManager.LoadScene("Menu");*/
        }
    }
}