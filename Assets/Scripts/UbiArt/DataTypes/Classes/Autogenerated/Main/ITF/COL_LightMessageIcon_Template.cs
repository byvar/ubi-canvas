namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_LightMessageIcon_Template : CSerializable {
		public float transitionTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			transitionTime = s.Serialize<float>(transitionTime, name: "transitionTime");
		}
		public override uint? ClassCRC => 0x8A66B0E3;
	}
}

