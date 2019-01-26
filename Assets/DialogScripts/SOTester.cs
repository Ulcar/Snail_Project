using UnityEngine;
using UnityEngine.UI;
using TMPro;
public   class SOTester:MonoBehaviour
    {
    [SerializeField]
    GenericDataList list;
    [SerializeField]
    TextMeshPro text, speaker;

    [SerializeField]
    Camera camera;

    [SerializeField]
    GameObject speechBubble;

    int index = 0;
    private void OnEnable()
    {
        text.gameObject.SetActive(true);
        speaker.gameObject.SetActive(true);
        speechBubble.SetActive(true);
        index = 0;
        Parse();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Parse();
        }
    }

   void Parse()
    {
        if (index >= list.dataList.Count)
        {
            this.enabled = false;
            text.gameObject.SetActive(false);
            speaker.gameObject.SetActive(false);
            speechBubble.SetActive(false);
            return;
        }
        GenericData data = list.dataList[index];
        if (data.type == typeof(TMP_Text))
        {
            data.DoEffect(text, speaker);

        }

        if (data.type == typeof(Camera))
        {

        }

        index++;
    }
}
