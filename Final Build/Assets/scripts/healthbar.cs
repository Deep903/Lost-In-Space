using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour {
    Image healthBar;
    float maxHealth = 100f;
    public static float health;

    public float TotalHp;
    public float CurrentHp;
    public GameObject player;

    // Use this for initialization
    void Start()
    {
        healthBar = GetComponent<Image>();
        health = maxHealth;

    }

    // Update is called once per frame
    void Update()
    {

        healthBar.fillAmount = health / maxHealth;

    }


    void TakeDamage()
    {
        CurrentHp -= 5;
        transform.localScale = new Vector3((CurrentHp / TotalHp), 1, 1);
      /*  if (CurrentHp == 0)
        {
            //MoveScript.Destroy(gameObject);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            //CurrentHp -= 5;
            //transform.localScale = new Vector3((CurrentHp / TotalHp), 1, 1);
        }*/



    }
}
