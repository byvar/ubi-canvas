using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_TorchFlameSpawnerComponent_Template : ActorComponent_Template {
		public Path torchPath;
		public CArray<StringID> snapBones;
		public float ZOffset;
		public StringID animOnFlip;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				torchPath = s.SerializeObject<Path>(torchPath, name: "torchPath");
				snapBones = s.SerializeObject<CArray<StringID>>(snapBones, name: "snapBones");
				ZOffset = s.Serialize<float>(ZOffset, name: "ZOffset");
				animOnFlip = s.SerializeObject<StringID>(animOnFlip, name: "animOnFlip");
			} else {
				torchPath = s.SerializeObject<Path>(torchPath, name: "torchPath");
				snapBones = s.SerializeObject<CArray<StringID>>(snapBones, name: "snapBones");
				snapBones = s.SerializeObject<CArray<StringID>>(snapBones, name: "snapBones");
				ZOffset = s.Serialize<float>(ZOffset, name: "ZOffset");
				animOnFlip = s.SerializeObject<StringID>(animOnFlip, name: "animOnFlip");
			}
		}
		public override uint? ClassCRC => 0x98412800;
	}
}

