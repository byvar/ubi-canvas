namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class AIBounceToLayerAction : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xC0639154;
	}
}

