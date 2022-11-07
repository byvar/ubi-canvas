namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_ActivationSequenceStoneComponent_Template : CSerializable {
		public Path fx;
		public StringID fxBone;
		public float activationTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			fx = s.SerializeObject<Path>(fx, name: "fx");
			fxBone = s.SerializeObject<StringID>(fxBone, name: "fxBone");
			activationTime = s.Serialize<float>(activationTime, name: "activationTime");
		}
		public override uint? ClassCRC => 0x7007EA49;
	}
}

