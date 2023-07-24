namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BattleCameraComponent_Template : BaseCameraComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x5BD2EF5B;
	}
}

