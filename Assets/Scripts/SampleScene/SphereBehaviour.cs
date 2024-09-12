using UnityEngine;

namespace SampleScene
{
    public class SampleSceneBehaviour : MonoBehaviour
    {
        private const float TimeWindow = 2;
        private const float Half = TimeWindow / 2;
        private const float TimeNormalizer = 1.5f;
        private const float Acc = 9.8f;
        private const float InitialDisplacement = 3;

        private void Update()
        {
            var normalizedTime = Time.time * TimeNormalizer;
            var timeInWindow = normalizedTime % TimeWindow;
            var forwards = timeInWindow < Half;
            var timeDisplacement = forwards ? timeInWindow : TimeWindow - timeInWindow;

            var tx = transform;
            var currentPos = tx.position;
            var y = Displacement(timeDisplacement);
            tx.position = new Vector3(currentPos.x, y, currentPos.z);
        }

        private static float Displacement(float t) => InitialDisplacement - 1f / 2 * Acc * t * t;
    }
}