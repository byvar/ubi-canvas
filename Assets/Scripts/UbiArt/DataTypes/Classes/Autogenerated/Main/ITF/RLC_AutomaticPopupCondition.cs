using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_AutomaticPopupCondition : CSerializable {
		public online.TimeInterval timeSinceLastShown;
		public uint sessionsSinceLastShown;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			timeSinceLastShown = s.SerializeObject<online.TimeInterval>(timeSinceLastShown, name: "timeSinceLastShown");
			sessionsSinceLastShown = s.Serialize<uint>(sessionsSinceLastShown, name: "sessionsSinceLastShown");
		}
	}
}

