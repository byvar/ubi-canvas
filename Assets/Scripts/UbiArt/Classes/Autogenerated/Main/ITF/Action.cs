using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH)]
	public partial class Action : CSerializable {
		public CMap<StringID, FXControl> actions;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			actions = s.SerializeObject<CMap<StringID, FXControl>>(actions, name: "actions");
		}
	}
}

