namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RevivePointComponent_Template : ActorComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x28ACB767;
	}
}

