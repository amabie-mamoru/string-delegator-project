using UnityEngine;

namespace ANamespace
{
    public class AScript : MonoBehaviour
    {
        public bool Func()
        {
            Debug.Log("execute Func");
            return true;
        }

        public void Action()
        {
            Debug.Log("execute Action");
        }
    }
}