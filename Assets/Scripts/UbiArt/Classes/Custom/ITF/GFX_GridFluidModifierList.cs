using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class GFX_GridFluidModifierList : CSerializable {
		[Serialize("Name"        )] public StringID Name;
		[Serialize("Active"      )] public bool Active;
		[Serialize("IsExternal"  )] public bool IsExternal;
		[Serialize("ModifierList")] public CList<GFX_GridFluidModifier> ModifierList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(Name));
				SerializeField(s, nameof(Active));
				SerializeField(s, nameof(IsExternal));
				SerializeField(s, nameof(ModifierList));
			}
		}
	}
}

