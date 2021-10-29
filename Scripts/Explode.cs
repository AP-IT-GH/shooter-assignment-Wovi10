using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    public GameObject explosion;
    public GameObject gameOverText;
    public GameObject finalCamera;

    void OnCollisionEnter(Collision other)
    {
        if (gameObject == GameObject.Find("PlayerJet"))
        {
            changeCams();
            changeUI();
        }
        else
        {
            ScoreScript.scoreValue += 100;
        }
        GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
        Destroy(gameObject);
        Destroy(expl, 3);
    }

    void changeUI()
    {
        gameOverText.SetActive(true);
    }

    void changeCams()
    {
        finalCamera.SetActive(true);
    }
}
