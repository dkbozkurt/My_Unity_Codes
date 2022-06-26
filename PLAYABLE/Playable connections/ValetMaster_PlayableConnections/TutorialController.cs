using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialController : MonoBehaviour
{

    [SerializeField] private GameObject _hand;
    [SerializeField] private GameObject _text;
    [SerializeField] private GameObject _gear;
    //[SerializeField] private GameObject _arrow;

    private bool _tutorialEnded=false;
    void Start()
    {
        _hand.SetActive(true);
        _text.SetActive(true);
        //_gear.SetActive(false);
        //_arrow.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (!_tutorialEnded && Input.GetMouseButtonDown(0))
        {
            _hand.SetActive(false);
            _text.SetActive(false);
            //_gear.SetActive(true);
            //CloseArrowAfterTime();
            _tutorialEnded = true;
        }
    }

    private void CloseArrowAfterTime()
    {
        StartCoroutine(Do());
        IEnumerator Do()
        {
            yield return new WaitForSeconds(3f);
            //_arrow.SetActive(false);
        }
    }
}
