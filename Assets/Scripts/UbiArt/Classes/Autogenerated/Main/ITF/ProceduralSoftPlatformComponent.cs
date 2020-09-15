using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class ProceduralSoftPlatformComponent : GraphicComponent {
		public Vec3d endPos;
		public bool useBeginTexture;
		public bool useEndTexture;
		public bool initIteration;
		public bool lianaOnTrigger;
		public bool flipTexture;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Default)) {
					endPos = s.SerializeObject<Vec3d>(endPos, name: "endPos");
					useBeginTexture = s.Serialize<bool>(useBeginTexture, name: "useBeginTexture");
					useEndTexture = s.Serialize<bool>(useEndTexture, name: "useEndTexture");
					initIteration = s.Serialize<bool>(initIteration, name: "initIteration");
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					endPos = s.SerializeObject<Vec3d>(endPos, name: "endPos");
					useBeginTexture = s.Serialize<bool>(useBeginTexture, name: "useBeginTexture");
					useEndTexture = s.Serialize<bool>(useEndTexture, name: "useEndTexture");
					initIteration = s.Serialize<bool>(initIteration, name: "initIteration");
					lianaOnTrigger = s.Serialize<bool>(lianaOnTrigger, name: "lianaOnTrigger");
					flipTexture = s.Serialize<bool>(flipTexture, name: "flipTexture");
				}
			}
		}
		public override uint? ClassCRC => 0x9986E181;
	}
}

