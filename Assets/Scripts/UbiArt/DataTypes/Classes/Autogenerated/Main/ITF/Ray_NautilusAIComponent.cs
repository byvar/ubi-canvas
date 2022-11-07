namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_NautilusAIComponent : CSerializable {
		public AngleAmount minAngle;
		public AngleAmount maxAngle;
		public Mode mode;
		public int lockOnMinReached;
		public int lockOnMaxReached;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				minAngle = s.SerializeObject<AngleAmount>(minAngle, name: "minAngle");
				maxAngle = s.SerializeObject<AngleAmount>(maxAngle, name: "maxAngle");
				mode = s.Serialize<Mode>(mode, name: "mode");
				lockOnMinReached = s.Serialize<int>(lockOnMinReached, name: "lockOnMinReached");
				lockOnMaxReached = s.Serialize<int>(lockOnMaxReached, name: "lockOnMaxReached");
			}
		}
		public enum Mode {
			[Serialize("Mode_Fixed")] Fixed = 0,
			[Serialize("Mode_Roll" )] Roll = 1,
		}
		public override uint? ClassCRC => 0xCC7A9B93;
	}
}

