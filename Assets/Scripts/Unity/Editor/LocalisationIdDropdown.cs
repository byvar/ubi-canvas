
using UnityEditor.IMGUI.Controls;
using System.Collections.Generic;
using System.Linq;
using UbiArt;
using UbiArt.Localisation;
using UnityEngine;

class LocalisationIdDropdown : AdvancedDropdown {
	public LocalisationId selection = null;
	public string name;
	public Rect rect;

	public LocalisationIdDropdown(AdvancedDropdownState state) : base(state) {
		minimumSize = new UnityEngine.Vector2(50, 400f);
	}

	protected override AdvancedDropdownItem BuildRoot() {
		var root = new AdvancedDropdownItem(name);
		Localisation_Template lt = MapLoader.Loader.localisation;
		root.AddChild(new AdvancedDropdownItem("-1 - None"));
		root.AddChild(new AdvancedDropdownItem("0 - None"));
		if (lt != null && lt.strings != null && lt.strings.Count > 0) {
			CMap<LocalisationId, LocText> textMap = lt.strings[0];
			List<uint> keys = textMap.Keys.Select(k => k.id).ToList();
			keys.Sort();
			foreach (uint key in keys) {
				root.AddChild(new AdvancedDropdownItem(key + " - " + textMap[key].text.Replace("\n","\\n")));
			}
		}

		return root;
	}

	protected override void ItemSelected(AdvancedDropdownItem item) {
		base.ItemSelected(item);
		Localisation_Template lt = MapLoader.Loader.localisation;
		if (item.children.Count() == 0) {
			if (lt != null && lt.strings != null && lt.strings.Count > 0) {
				CMap<LocalisationId, LocText> textMap = lt.strings[0];
				string keyStr = item.name.Substring(0, item.name.IndexOf(' '));
				int key = int.Parse(keyStr);
				if (key == -1) {
					selection = new LocalisationId();
				} else if (key == 0) {
					selection = new LocalisationId(0);
				} else {
					selection = (uint)key;
				}
			}
		}
	}
}
