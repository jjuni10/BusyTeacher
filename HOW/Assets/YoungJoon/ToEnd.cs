using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToEnd : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Item") //�����۰� �浹 ��
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
