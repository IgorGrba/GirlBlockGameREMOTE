using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUpTween : MonoBehaviour
{

    public List<Transform> objectsToShow;

    public AnimationCurve ease;

    public Vector2 delay;

    public float duration = 0.3f;

    public bool resizeOnStart = true;
    public bool playOnStart = false;

    List<Vector3> defaultSizes = new List<Vector3>();

    // Start is called before the first frame update
    void Start()
    {
        CacheSizes();

        if (resizeOnStart)
        {
            Debug.Log(gameObject.name);
            foreach (var item in objectsToShow)
            {
                item.localScale = Vector3.zero;
            }
        }

        if (playOnStart)
        {
            Play();
        }
    }

    void CacheSizes()
    {
        foreach (var item in objectsToShow)
        {
            defaultSizes.Add(item.localScale);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Play();
        }
    }

    public void Play()
    {
        for (int i = 0; i < objectsToShow.Count; i++)
        {
            var size = defaultSizes[i];
            var item = objectsToShow[i];
            ScaleUp(item, size);
        }
    }

    void ScaleUp(Transform whichTransform, Vector3 defaultSize)
    {
        whichTransform.localScale = Vector3.zero;
        StartCoroutine(ScaleUp(whichTransform, Vector3.zero, defaultSize));
    }

    IEnumerator ScaleUp(Transform whichTransform, Vector3 from, Vector3 to)
    {
        float x = Random.Range(delay.x, delay.y);
        if (x > 0.0f)
        {
            yield return new WaitForSeconds(x);
        }

        Vector3 delta = to - from;

        for (float c = 0.0f, t = 0.0f, d = duration; c <= d; c += Time.deltaTime, t = ease.Evaluate(c / d))
        {
            whichTransform.localScale = from + delta * t;
            yield return null;
        }
        whichTransform.localScale = to;
    }
}
