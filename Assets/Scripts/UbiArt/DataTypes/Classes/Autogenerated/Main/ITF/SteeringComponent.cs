namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class SteeringComponent : ActorComponent {
		public bool drawDebug;
		public float WalkSpeed;
		public float RunSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			drawDebug = s.Serialize<bool>(drawDebug, name: "drawDebug");
			WalkSpeed = s.Serialize<float>(WalkSpeed, name: "WalkSpeed");
			RunSpeed = s.Serialize<float>(RunSpeed, name: "RunSpeed");
		}
		public override uint? ClassCRC => 0x388C5A2B;
	}
}

