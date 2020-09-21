using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_UIFramePrisonerCounterComponent_Template : ActorComponent_Template {
		public StringID stand;
		public StringID shake;
		public float slotTimeInterval;
		public CArrayO<Path> medalPaths;
		public float medalTransitionDuration;
		public CArrayO<Vec3d> medalOffsets;
		public CArrayO<Vec3d> medalOffsets3Slots;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				stand = s.SerializeObject<StringID>(stand, name: "stand");
				shake = s.SerializeObject<StringID>(shake, name: "shake");
				slotTimeInterval = s.Serialize<float>(slotTimeInterval, name: "slotTimeInterval");
				medalPaths = s.SerializeObject<CArrayO<Path>>(medalPaths, name: "medalPaths");
				medalOffsets = s.SerializeObject<CArrayO<Vec3d>>(medalOffsets, name: "medalOffsets");
				medalOffsets3Slots = s.SerializeObject<CArrayO<Vec3d>>(medalOffsets3Slots, name: "medalOffsets3Slots");
				medalTransitionDuration = s.Serialize<float>(medalTransitionDuration, name: "medalTransitionDuration");
			} else {
				stand = s.SerializeObject<StringID>(stand, name: "stand");
				shake = s.SerializeObject<StringID>(shake, name: "shake");
				slotTimeInterval = s.Serialize<float>(slotTimeInterval, name: "slotTimeInterval");
				medalPaths = s.SerializeObject<CArrayO<Path>>(medalPaths, name: "medalPaths");
				medalTransitionDuration = s.Serialize<float>(medalTransitionDuration, name: "medalTransitionDuration");
			}
		}
		public override uint? ClassCRC => 0x65F08F2E;
	}
}

