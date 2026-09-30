using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10f; //public 공룡(공용)
    int[] scores = new int[5];

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Start()
    {
        for (int i = 0; i < scores.Length; i++)
            scores[i] = (i + 1) * 10;

        Debug.Log(scores[0]);
        Debug.Log(scores[1]);
        Debug.Log(scores[2]);
        Debug.Log(scores[3]);
        Debug.Log(scores[4]);
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        
        Vector3 direction = new Vector3(x, y, 0);
        transform.position += direction.normalized * speed * Time.deltaTime;
    }
}
