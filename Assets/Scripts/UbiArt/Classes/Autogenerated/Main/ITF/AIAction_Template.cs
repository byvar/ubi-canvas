using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RL | GameFlags.VH)]
	public partial class AIAction_Template : CSerializable {
		public StringID action;
		public StringID endMarker;
		public bool useRootPos;
		public bool finishOnContact;
		public Vec2d rootPosScale;
		public float ignoreContactDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.engineVersion <= Settings.EngineVersion.RO) {
				if (this is AIDestroyAction_Template) return;
			}
			action = s.SerializeObject<StringID>(action, name: "action");
			endMarker = s.SerializeObject<StringID>(endMarker, name: "endMarker");
			useRootPos = s.Serialize<bool>(useRootPos, name: "useRootPos");
			finishOnContact = s.Serialize<bool>(finishOnContact, name: "finishOnContact");
			rootPosScale = s.SerializeObject<Vec2d>(rootPosScale, name: "rootPosScale");
			ignoreContactDuration = s.Serialize<float>(ignoreContactDuration, name: "ignoreContactDuration");
		}
		public override uint? ClassCRC => 0xA6F57F72;
	}
}

