using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BreakableStackElementAIComponent : RO2_AIComponent {
		[Serialize("managerPath"        )] public ObjectPath managerPath;
		[Serialize("countSpawnMax"      )] public uint countSpawnMax;
		[Serialize("blockIsDestroy"     )] public bool blockIsDestroy;
		[Serialize("checkPointRow"      )] public uint checkPointRow;
		[Serialize("checkPointCol"      )] public uint checkPointCol;
		[Serialize("blockState"         )] public uint blockState;
		[Serialize("hasTuto"            )] public bool hasTuto;
		[Serialize("atlasPrimitiveParam")] public GFXPrimitiveParam atlasPrimitiveParam;
		[Serialize("hasTuto"            )] public byte hasTuto;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(managerPath));
				}
				SerializeField(s, nameof(countSpawnMax));
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(blockIsDestroy));
					SerializeField(s, nameof(checkPointRow));
					SerializeField(s, nameof(checkPointCol));
					SerializeField(s, nameof(blockState));
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(hasTuto));
				}
				SerializeField(s, nameof(hasTuto));
			} else {
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(managerPath));
				}
				SerializeField(s, nameof(countSpawnMax));
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(blockIsDestroy));
					SerializeField(s, nameof(checkPointRow));
					SerializeField(s, nameof(checkPointCol));
					SerializeField(s, nameof(blockState));
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(hasTuto));
				}
				SerializeField(s, nameof(atlasPrimitiveParam));
			}
		}
		public override uint? ClassCRC => 0x61E0F003;
	}
}

