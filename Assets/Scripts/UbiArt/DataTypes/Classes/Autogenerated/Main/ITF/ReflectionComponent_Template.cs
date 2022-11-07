namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class ReflectionComponent_Template : ActorComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x3B421FA6;
	}
}

