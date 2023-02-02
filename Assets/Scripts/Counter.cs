using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private List<GameObject> _coins;
    [SerializeField] private TextMeshProUGUI _textMeshPro;
    [SerializeField] private string _text;

    private void Start()
    {
        _textMeshPro.text = _text;
        _textMeshPro.gameObject.SetActive(false);
    }
    private void Update()
    {
        for (int i = 0; i < _coins.Count; i++)
        {
            if (_coins[i] == null)
            {
                _coins.Remove(_coins[i]);
            }
        }
        if (_coins.Count < 1)
        {
            
            _textMeshPro.gameObject.SetActive(true);
        }
    }
}
