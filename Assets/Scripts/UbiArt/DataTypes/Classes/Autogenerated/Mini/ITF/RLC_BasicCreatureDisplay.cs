namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class RLC_BasicCreatureDisplay : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xC3863CFC;
	}
}

