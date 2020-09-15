using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventPowerUp : Event {
		[Serialize("id"         )] public StringID id;
		[Serialize("enable"     )] public bool enable;
		[Serialize("startingPos")] public Vec3d startingPos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(id));
			SerializeField(s, nameof(enable));
			SerializeField(s, nameof(startingPos));
		}
		public override uint? ClassCRC => 0x35C9FDBD;
	}
}

