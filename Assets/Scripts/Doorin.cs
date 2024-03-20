
using UnityEngine;

public class Doorin : MonoBehaviour
{
    public GameObject target;
    private bool isTra;
    [SerializeField] float time;
    void Start()
    {
        isTra= true;
    }

    void Update()
    {
        if(!isTra)
        {
            if(time<0.5f)
            {
                time += Time.deltaTime;
            }
            else
            {
                time = 0f;
                isTra = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!isTra)
        {
            return;
        }
        if(collision.gameObject.tag!="Bullet")
        {
            return;
        }
        collision.transform.position = target.transform.position;
        target.GetComponent<Doorin>().isTra = false;
    }
}
