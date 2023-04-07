using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DropdownHandler : MonoBehaviour
{
    public TextMeshProUGUI selectedItemText;
    private void Start()
    {
        var dropdown = transform.GetComponent<TMP_Dropdown>();
        dropdown.options.Clear();

        List<string> items = new List<string>();
        items.Add("Item 1");
        items.Add("Item 2");
        items.Add("Item 3");

        // Fill dropdown with items
        foreach(string item in items)
        {
            dropdown.options.Add(new TMP_Dropdown.OptionData() {text = item});
        }

        DropdownItemSelected(dropdown);

        dropdown.onValueChanged.AddListener(delegate {DropdownItemSelected(dropdown);});
    }

    private void DropdownItemSelected(TMP_Dropdown dropdown)
    {
        int index = dropdown.value;
        selectedItemText.text = dropdown.options[index].text;
    }
}
