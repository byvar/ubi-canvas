
using UnityEditor.IMGUI.Controls;
using System.Collections.Generic;
using System.Linq;
using UbiArt;
using UnityEngine;
using UbiArt.Animation;

class PatchBankTemplateDropdown : AdvancedDropdown {
	public int? selection;
	public string name;
	public Rect rect;
	public AnimPatchBank pbk;

	public PatchBankTemplateDropdown(AdvancedDropdownState state) : base(state) {
		minimumSize = new UnityEngine.Vector2(50, 400f);
	}
	public PatchBankTemplateDropdown(AdvancedDropdownState state, AnimPatchBank pbk) : this(state) {
		this.pbk = pbk;
	}

	protected override AdvancedDropdownItem BuildRoot() {
		var root = new AdvancedDropdownItem(name);
		root.AddChild(new AdvancedDropdownItem("All") {
			id = -1
		});
		if (pbk != null) {
			for (int tpl_i = 0; tpl_i < pbk.templates.Count; tpl_i++) {
				var tpl = pbk.templates[tpl_i];
				var tplKey = pbk.templateKeys.GetKeyFromValue(tpl_i);
				var sid = new StringID((uint)tplKey);
				var name = $"{tpl_i} - {sid.ToString(Controller.MainContext)}";
				root.AddChild(new AdvancedDropdownItem(name) {
					id = tpl_i
				});
			}
		}

		return root;
	}

	protected override void ItemSelected(AdvancedDropdownItem item) {
		base.ItemSelected(item);
		if (item.children.Count() == 0) {
			selection = item.id;
		}
	}
}
