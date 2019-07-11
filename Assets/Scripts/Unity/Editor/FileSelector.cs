
using UnityEditor.IMGUI.Controls;
using System.Collections.Generic;
using System.Linq;

class FileSelectionDropdown : AdvancedDropdown {
	public string selection = null;
	public string[] files;
	public string name;
	//public SerializedProperty property;

	public FileSelectionDropdown(AdvancedDropdownState state) : base(state) {
		minimumSize = new UnityEngine.Vector2(50, 400f);
	}

	protected override AdvancedDropdownItem BuildRoot() {
		var root = new AdvancedDropdownItem(name);
		for (int i = 0; i < files.Length; i++) {
			Add(root, files[i], files[i], i);
		}

		return root;
	}

	protected void Add(AdvancedDropdownItem parent, string path, string fullPath, int id) {
		if (path.Contains("/")) {
			// Folder
			string folder = path.Substring(0, path.IndexOf("/"));
			string rest = path.Substring(path.IndexOf("/") + 1);
			AdvancedDropdownItem folderNode = parent.children.FirstOrDefault(c => c.name == folder);
			if (folderNode == null) {
				folderNode = new AdvancedDropdownItem(folder);
				parent.AddChild(folderNode);
			}
			Add(folderNode, rest, fullPath, id);
		} else {
			// File
			parent.AddChild(new AdvancedDropdownItem(path) {
				id = id
			});
		}
	}

	protected override void ItemSelected(AdvancedDropdownItem item) {
		base.ItemSelected(item);
		if (item.children.Count() == 0 && files != null && files.Length > item.id) {
			selection = files[item.id];
			//property.stringValue = selection;
		}
	}
}
