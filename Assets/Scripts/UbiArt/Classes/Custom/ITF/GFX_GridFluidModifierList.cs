using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class GFX_GridFluidModifierList : CSerializable {
		public StringID Name;
		public bool Active;
		public bool IsExternal;
		public CList<GFX_GridFluidModifier> ModifierList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				Name = s.SerializeObject<StringID>(Name, name: "Name");
				Active = s.Serialize<bool>(Active, name: "Active");
				IsExternal = s.Serialize<bool>(IsExternal, name: "IsExternal");
				ModifierList = s.SerializeObject<CList<GFX_GridFluidModifier>>(ModifierList, name: "ModifierList");
			}
		}
	}
}

