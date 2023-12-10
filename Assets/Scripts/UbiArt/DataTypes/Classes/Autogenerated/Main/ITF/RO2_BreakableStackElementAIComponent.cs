namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BreakableStackElementAIComponent : RO2_AIComponent {
		public ObjectPath managerPath;
		public uint countSpawnMax;
		public bool blockIsDestroy;
		public uint checkPointRow = uint.MaxValue;
		public uint checkPointCol = uint.MaxValue;
		public uint blockState;
		public bool hasTuto;
		public GFXPrimitiveParam atlasPrimitiveParam;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL) {
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					managerPath = s.SerializeObject<ObjectPath>(managerPath, name: "managerPath");
				}
				countSpawnMax = s.Serialize<uint>(countSpawnMax, name: "countSpawnMax");
				if (s.HasFlags(SerializeFlags.Persistent)) {
					blockIsDestroy = s.Serialize<bool>(blockIsDestroy, name: "blockIsDestroy");
					checkPointRow = s.Serialize<uint>(checkPointRow, name: "checkPointRow");
					checkPointCol = s.Serialize<uint>(checkPointCol, name: "checkPointCol");
					blockState = s.Serialize<uint>(blockState, name: "blockState");
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					hasTuto = s.Serialize<bool>(hasTuto, name: "hasTuto", options: CSerializerObject.Options.BoolAsByte);
				}
			} else {
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					managerPath = s.SerializeObject<ObjectPath>(managerPath, name: "managerPath");
				}
				countSpawnMax = s.Serialize<uint>(countSpawnMax, name: "countSpawnMax");
				if (s.HasFlags(SerializeFlags.Persistent)) {
					blockIsDestroy = s.Serialize<bool>(blockIsDestroy, name: "blockIsDestroy");
					checkPointRow = s.Serialize<uint>(checkPointRow, name: "checkPointRow");
					checkPointCol = s.Serialize<uint>(checkPointCol, name: "checkPointCol");
					blockState = s.Serialize<uint>(blockState, name: "blockState");
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					hasTuto = s.Serialize<bool>(hasTuto, name: "hasTuto");
				}
				atlasPrimitiveParam = s.SerializeObject<GFXPrimitiveParam>(atlasPrimitiveParam, name: "atlasPrimitiveParam");
			}
		}
		public override uint? ClassCRC => 0x61E0F003;
	}
}

