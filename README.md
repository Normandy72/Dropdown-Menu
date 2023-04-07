# Instructions

1. Create a __Canvas__, change its color if needed.
2. Add a __Dropdown__, change its color, font, font size, etc. if needed.
3. You can remove all options from the dropdown to add them dynamically via script.
4. Create a new script ("DropdownHandler").
5. Clear all options at Start (`dropdown.options.Clear();`).
6. Create List that contains all items for dropdown. Add as many items as you need.
7. Add all items to Dropdown as OptionData (`dropdown.options.Add(new Dropdown.OptionData() {text = item});`).
8. Create a delegate to a DropdowmItemSelected method.
9. Create __DropdownItemSelected__ method, ad its logic.
10. Call this method in Start.