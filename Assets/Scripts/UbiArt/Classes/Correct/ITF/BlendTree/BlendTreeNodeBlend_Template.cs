using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class BlendTreeNodeBlend_Template<T> : BlendTreeNodeTemplate<T> {
		public CList<Generic<BlendTreeNodeTemplate<T>>> leafs;
		public bool ignoreRuleChanges;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				leafs = s.SerializeObject<CList<Generic<BlendTreeNodeTemplate<T>>>>(leafs, name: "leafs");
			}
			ignoreRuleChanges = s.Serialize<bool>(ignoreRuleChanges, name: "ignoreRuleChanges");
		}
		public override uint? ClassCRC => 0x422981DB;
	}
}

