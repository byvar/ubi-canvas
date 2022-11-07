namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_DarkCloudSpawnPointComponent_Template : CSerializable {
		public float activationDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			activationDistance = s.Serialize<float>(activationDistance, name: "activationDistance");
		}
		public override uint? ClassCRC => 0xA5AD645E;
	}
}

