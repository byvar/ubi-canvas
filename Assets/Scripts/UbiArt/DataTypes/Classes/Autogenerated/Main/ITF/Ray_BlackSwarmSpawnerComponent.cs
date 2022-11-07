namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Ray_BlackSwarmSpawnerComponent : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xB6328071;
	}
}

