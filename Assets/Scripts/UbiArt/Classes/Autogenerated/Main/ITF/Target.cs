using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH)]
	public partial class Target : CSerializable {
		public CMap<StringID, Action> targets;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			targets = s.SerializeObject<CMap<StringID, Action>>(targets, name: "targets");
		}
	}
}

