using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class BlendTreeNodeBlend_Template<T> : BlendTreeNodeTemplate<T> {
		[Serialize("leafs"            )] public CList<Generic<BlendTreeNodeTemplate<T>>> leafs;
		[Serialize("ignoreRuleChanges")] public bool ignoreRuleChanges;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				SerializeField(s, nameof(leafs));
			}
			SerializeField(s, nameof(ignoreRuleChanges));
		}
		public override uint? ClassCRC => 0x422981DB;
	}
}

