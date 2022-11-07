namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_PowerUp : CSerializable {
		public CArrayO<Generic<RO2_BasicPowerUpData>> dataList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			dataList = s.SerializeObject<CArrayO<Generic<RO2_BasicPowerUpData>>>(dataList, name: "dataList");
		}
	}
}

