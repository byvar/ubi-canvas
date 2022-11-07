namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_GlobalPowerUpUnlocked : CSerializable {
		public bool dive;
		public bool walkOnWallsGlobal;
		public bool reduction;
		public bool helicopter;
		public bool fight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			dive = s.Serialize<bool>(dive, name: "dive");
			walkOnWallsGlobal = s.Serialize<bool>(walkOnWallsGlobal, name: "walkOnWallsGlobal");
			reduction = s.Serialize<bool>(reduction, name: "reduction");
			helicopter = s.Serialize<bool>(helicopter, name: "helicopter");
			fight = s.Serialize<bool>(fight, name: "fight");
		}
	}
}

