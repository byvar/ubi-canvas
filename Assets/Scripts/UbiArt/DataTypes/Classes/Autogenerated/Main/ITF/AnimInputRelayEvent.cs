using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class AnimInputRelayEvent : Event {
		public StringID InputName;
		public eTo TargetMode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			InputName = s.SerializeObject<StringID>(InputName, name: "InputName");
			TargetMode = s.Serialize<eTo>(TargetMode, name: "TargetMode");
		}
		public enum eTo {
			[Serialize("eToMyself"   )] Myself = 0,
			[Serialize("eToActivator")] Activator = 1,
		}
		public override uint? ClassCRC => 0x534E75DA;
	}
}

