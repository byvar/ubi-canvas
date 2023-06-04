namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class AIStickBoneAction : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x891E1B63;
	}
}

