namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class RLC_MissileCreatureDisplay : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x597BC48A;
	}
}

