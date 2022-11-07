namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class FogBoxComponent_Template : ActorComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x3684DBA9;
	}
}

