using UnityEngine;
using System.Collections;

namespace shootemup
{
    [RequireComponent(typeof(LineRenderer))]
    public class WaypointsController : MonoBehaviour
    {

        public GameObject go1;
        public GameObject go2;
        public GameObject go3;

        private LineRenderer lr;

        // Use this for initialization
        void Start()
        {
            lr = GetComponent<LineRenderer>();

            //lr.SetPosition(0, go1.transform.position);
            //lr.SetPosition(1, go2.transform.position);

            var positions = new Vector3[3] {
            go1.transform.position,
            go2.transform.position,
            go3.transform.position
        };

            lr.SetPositions(positions);

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
