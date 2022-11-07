namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class SpawnManagerComponent_Template : ActorComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x43C07439;
	}
}

