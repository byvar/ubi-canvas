using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_Brick_Template : CSerializable {
		[Serialize("name"         )] public StringID name;
		[Serialize("name"         )] public string name;
		[Serialize("path"         )] public Path path;
		[Serialize("spawnCooldown")] public uint spawnCooldown;
		[Serialize("difficulty"   )] public uint difficulty;
		[Serialize("murphymode"   )] public eMM murphymode;
		[Serialize("murphymode"   )] public Enum_murphymode murphymode;
		[Serialize("archive"      )] public ArchiveMemory archive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(path));
				SerializeField(s, nameof(spawnCooldown));
				SerializeField(s, nameof(difficulty));
				SerializeField(s, nameof(murphymode));
				if (s.HasFlags(SerializeFlags.Flags10)) {
					SerializeField(s, nameof(archive));
				}
			} else {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(path));
				SerializeField(s, nameof(spawnCooldown));
				SerializeField(s, nameof(difficulty));
				SerializeField(s, nameof(murphymode));
			}
		}
		public enum eMM {
			[Serialize("eMM_Both"        )] Both = 0,
			[Serialize("eMM_TouchOnly"   )] TouchOnly = 1,
			[Serialize("eMM_NonTouchOnly")] NonTouchOnly = 2,
		}
		public enum Enum_murphymode {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0xDDE750FB;
	}
}

