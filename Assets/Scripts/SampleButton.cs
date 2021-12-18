using UnityEngine;
using UnityEngine.UI;

namespace Sample
{
    [RequireComponent(typeof(Button))]
    public class SampleButton : MonoBehaviour
    {
        private void Start() {
            this.GetComponent<Button>().onClick.AddListener(() =>
            {
                UnityEngine.Debug.Log("Hoge");
            });
        }
    }
}