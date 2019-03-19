using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class AnimInputRelayEvent : Event {
		[Serialize("InputName" )] public StringID InputName;
		[Serialize("TargetMode")] public eTo TargetMode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(InputName));
			SerializeField(s, nameof(TargetMode));
		}
		public enum eTo {
			[Serialize("eToMyself"   )] Myself = 0,
			[Serialize("eToActivator")] Activator = 1,
		}
		public override uint? ClassCRC => 0x534E75DA;
	}
}

