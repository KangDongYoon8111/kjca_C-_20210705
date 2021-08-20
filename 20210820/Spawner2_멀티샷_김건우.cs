using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    public GameObject bullet = null;
    private Transform target = null;
    private float min = 0.5f;
    private float max = 3f;
    private float rate = 2f;
    private float time = 0f;

    void Start()
    {
        time = 0f;
        rate = Random.Range(min, max);
        target = FindObjectOfType<Player>().transform;
    }

    void Update()
    {
        time += Time.deltaTime;

        if (time >= rate)
        {
            time = 0f;

            // 단발
            //GameObject b = Instantiate(bullet, transform.position, transform.rotation);
            //b.transform.LookAt(new Vector3(target.position.x, b.transform.position.y, target.position.z));

            // 멀티샷 시작
            float angle = GetAngle(
                new Vector2(transform.position.x, transform.position.z),
                new Vector2(target.transform.position.x, target.transform.position.z)
            );

            float D2R = Mathf.Deg2Rad;
            angle -= 60;
            for (int i = 0; i < 25; i++)
            {
                Vector3 temp2 = new Vector3(transform.position.x, 1f, transform.position.z);
                GameObject c = Instantiate(bullet, temp2, transform.rotation);
                Vector3 temp = new Vector3(Mathf.Cos(angle * D2R), 0f, Mathf.Sin(angle * D2R));
                c.transform.LookAt(c.transform.position + temp);

                angle += 5;
            }
            // 멀티샷 끝

            rate = Random.Range(min, max);
        }

        transform.LookAt(target);
    }

    private float GetAngle(Vector2 start, Vector2 end)
    {
        Vector2 v2 = end - start;
        return Mathf.Atan2(v2.y, v2.x) * Mathf.Rad2Deg;
    }
}
