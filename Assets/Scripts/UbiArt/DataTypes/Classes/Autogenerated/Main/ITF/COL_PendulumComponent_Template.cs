namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_PendulumComponent_Template : ActorComponent_Template {
		public StringID fxOnHit;
		public StringID fxOnStartMove;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			fxOnHit = s.SerializeObject<StringID>(fxOnHit, name: "fxOnHit");
			fxOnStartMove = s.SerializeObject<StringID>(fxOnStartMove, name: "fxOnStartMove");
		}
		public override uint? ClassCRC => 0x7EB31AD5;
	}
}

