using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_EventSpawnWave : Event {
		public uint waveType;
		public float speed;
		public float delayBeforeMoving;
		public bool mustOffsetByRadius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			waveType = s.Serialize<uint>(waveType, name: "waveType");
			speed = s.Serialize<float>(speed, name: "speed");
			delayBeforeMoving = s.Serialize<float>(delayBeforeMoving, name: "delayBeforeMoving");
			mustOffsetByRadius = s.Serialize<bool>(mustOffsetByRadius, name: "mustOffsetByRadius");
		}
		public override uint? ClassCRC => 0xFC4BCD1E;
	}
}

