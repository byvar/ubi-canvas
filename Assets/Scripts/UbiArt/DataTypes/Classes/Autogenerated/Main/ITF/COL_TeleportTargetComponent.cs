namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_TeleportTargetComponent : CSerializable {
		public Placeholder arriveFromInfos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			arriveFromInfos = s.SerializeObject<Placeholder>(arriveFromInfos, name: "arriveFromInfos");
		}
		public override uint? ClassCRC => 0xB1576575;
	}
}

