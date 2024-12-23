using UnityEngine;
using TMPro;

public class DisplayDistanceText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _distanceText;
    [SerializeField] private Transform _playerTrans;

    private Vector2 _startPosition; //can get the position with vector(x and y)

    private void Start()
    {
        _startPosition = _playerTrans.position;//say where the begging is
    }
    private void Update()
    {
        Vector2 distance = (Vector2)_playerTrans.position - _startPosition;//where the player is - where the begging is
        distance.y = 0;//caz no change in y

        if (distance.x < 0)
        {
            distance.x = 0;
        }
        _distanceText.text = distance.x.ToString("0");
    }
}
