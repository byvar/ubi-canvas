namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_SpawnedNPCComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x1F797026;
	}
}

