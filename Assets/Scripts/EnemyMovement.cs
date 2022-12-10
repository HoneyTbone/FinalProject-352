using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float speed;
    private EnemySpawner points;
    private int pointNumber;

    [SerializeField] GameObject Explosion;

    // Start is called before the first frame update
    void Start()
    {
        points = GameObject.FindGameObjectWithTag("GameManager").GetComponent<EnemySpawner>();
    }


    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, points.points[pointNumber].position, speed * Time.deltaTime);
        if(Vector2.Distance(transform.position, points.points[pointNumber].position) < 0.1f)
        {
            pointNumber++;
        }
    }


    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if(other.tag == "Bullet")
        {
             Destroy(Instantiate(Explosion, this.transform.position, Quaternion.identity), 2f);
             Destroy(gameObject);
        }
    }
}
