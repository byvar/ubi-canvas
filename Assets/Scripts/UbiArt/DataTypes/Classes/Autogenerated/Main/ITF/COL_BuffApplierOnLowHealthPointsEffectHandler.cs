namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BuffApplierOnLowHealthPointsEffectHandler : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x83748E8B;
	}
}

