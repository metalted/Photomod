using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Photomod
{
    public class SpectatorSpeedDisplay : MonoBehaviour
    {
        private Image SteerLeftFiller;
        private Image SteerRightFiller;
        private Image Break;
        private Image ArmsUp;
        private TextMeshProUGUI percentageText;
        private AnimationCurve curve;
        private Image LerpLeftFiller;
        private Image LerpRightFiller;
        private Color SteerMinColor;
        private Color SteerMaxColor;
        private Color LerpMinColor;
        private Color LerpMaxColor;
        private Color NotActive;
        private Color Active;

        public void CopyAndDestroySpeedDisplay()
        {
            SpeedDisplay speedDisplay = gameObject.GetComponent<SpeedDisplay>();
            SteerLeftFiller = speedDisplay.SteerLeftFiller;
            SteerRightFiller = speedDisplay.SteerRightFiller;
            Break = speedDisplay.Break;
            ArmsUp = speedDisplay.ArmsUp;
            percentageText = speedDisplay.percentageText;
            curve = speedDisplay.curve;
            LerpLeftFiller = speedDisplay.LerpLeftFiller;
            LerpRightFiller = speedDisplay.LerpRightFiller;
            SteerMinColor = speedDisplay.SteerMinColor;
            SteerMaxColor = speedDisplay.SteerMaxColor;
            LerpMinColor = speedDisplay.LerpMinColor;
            LerpMaxColor = speedDisplay.LerpMaxColor;
            NotActive = speedDisplay.NotActive;
            Active = speedDisplay.Active;
            GameObject.Destroy(speedDisplay);
        }

        private Color HSVLerp(Color min, Color max, float t)
        {
            t = curve.Evaluate(t);
            float H1;
            float S1;
            float V1;
            Color.RGBToHSV(min, out H1, out S1, out V1);
            float H2;
            float S2;
            float V2;
            Color.RGBToHSV(max, out H2, out S2, out V2);
            double H3 = (double)Mathf.Lerp(H1, H2, t);
            float num1 = Mathf.Lerp(S1, S2, t);
            float num2 = Mathf.Lerp(V1, V2, t);
            double S3 = (double)num1;
            double V3 = (double)num2;
            return Color.HSVToRGB((float)H3, (float)S3, (float)V3);
        }

        public void UpdateIndicator(float steering, bool braking, bool armsup)
        {
            LerpLeftFiller.fillAmount = steering < 0.0 ? -steering : 0.0f;
            LerpRightFiller.fillAmount = steering;
            LerpLeftFiller.color = HSVLerp(LerpMinColor, LerpMaxColor, -steering);
            LerpRightFiller.color = HSVLerp(LerpMinColor, LerpMaxColor, steering);
            SteerLeftFiller.fillAmount = steering < 0.0 ? -steering : 0.0f;
            SteerRightFiller.fillAmount = steering;
            SteerLeftFiller.color = HSVLerp(SteerMinColor, SteerMaxColor, -steering);
            SteerRightFiller.color = HSVLerp(SteerMinColor, SteerMaxColor, steering);
            Break.color = braking ? Active : NotActive;
            ArmsUp.color = armsup ? Active : NotActive;
            percentageText.text = (steering * 100f).ToString("F0") + "%";
        }
    }
}
