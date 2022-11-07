namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_EventSpawnWave : Event {
		public uint waveType;
		public float speed;
		public float delayBeforeMoving;
		public int mustOffsetByRadius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			waveType = s.Serialize<uint>(waveType, name: "waveType");
			speed = s.Serialize<float>(speed, name: "speed");
			delayBeforeMoving = s.Serialize<float>(delayBeforeMoving, name: "delayBeforeMoving");
			mustOffsetByRadius = s.Serialize<int>(mustOffsetByRadius, name: "mustOffsetByRadius");
		}
		public override uint? ClassCRC => 0x231051EA;
	}
}

