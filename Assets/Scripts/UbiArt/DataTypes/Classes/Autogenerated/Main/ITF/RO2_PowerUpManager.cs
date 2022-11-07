namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_PowerUpManager : CSerializable {
		public CMap<StringID, RO2_PowerUp> powerUps;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			powerUps = s.SerializeObject<CMap<StringID, RO2_PowerUp>>(powerUps, name: "powerUps");
		}
	}
}

