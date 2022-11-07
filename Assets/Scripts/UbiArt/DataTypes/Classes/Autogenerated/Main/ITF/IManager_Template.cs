namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class IManager_Template : TemplateObj {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x97FB2CAC;
	}
}

