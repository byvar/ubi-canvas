namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionManager_Template : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x80DEEF3D;
	}
}

