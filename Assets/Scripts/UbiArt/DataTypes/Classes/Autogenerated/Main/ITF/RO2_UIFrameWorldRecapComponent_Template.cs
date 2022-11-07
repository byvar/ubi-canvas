namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_UIFrameWorldRecapComponent_Template : ActorComponent_Template {
		public LocalisationId locId;
		public StringID FXFirework;
		public StringID FXFireStreamRight;
		public StringID FXFireStreamLeft;
		public Vec3d offsetFirework;
		public Vec3d offsetFireStreamRight;
		public Vec3d offsetFireStreamLeft;
		public StringID standEmptyAnim;
		public StringID standWithCupAnim;
		public float waitDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			locId = s.SerializeObject<LocalisationId>(locId, name: "locId");
			FXFirework = s.SerializeObject<StringID>(FXFirework, name: "FXFirework");
			FXFireStreamRight = s.SerializeObject<StringID>(FXFireStreamRight, name: "FXFireStreamRight");
			FXFireStreamLeft = s.SerializeObject<StringID>(FXFireStreamLeft, name: "FXFireStreamLeft");
			offsetFirework = s.SerializeObject<Vec3d>(offsetFirework, name: "offsetFirework");
			offsetFireStreamRight = s.SerializeObject<Vec3d>(offsetFireStreamRight, name: "offsetFireStreamRight");
			offsetFireStreamLeft = s.SerializeObject<Vec3d>(offsetFireStreamLeft, name: "offsetFireStreamLeft");
			standEmptyAnim = s.SerializeObject<StringID>(standEmptyAnim, name: "standEmptyAnim");
			standWithCupAnim = s.SerializeObject<StringID>(standWithCupAnim, name: "standWithCupAnim");
			waitDuration = s.Serialize<float>(waitDuration, name: "waitDuration");
		}
		public override uint? ClassCRC => 0x729EFDF7;
	}
}

