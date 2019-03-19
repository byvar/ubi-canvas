using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventSpawnWave : Event {
		[Serialize("waveType"          )] public uint waveType;
		[Serialize("speed"             )] public float speed;
		[Serialize("delayBeforeMoving" )] public float delayBeforeMoving;
		[Serialize("mustOffsetByRadius")] public bool mustOffsetByRadius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(waveType));
			SerializeField(s, nameof(speed));
			SerializeField(s, nameof(delayBeforeMoving));
			SerializeField(s, nameof(mustOffsetByRadius));
		}
		public override uint? ClassCRC => 0xFC4BCD1E;
	}
}

