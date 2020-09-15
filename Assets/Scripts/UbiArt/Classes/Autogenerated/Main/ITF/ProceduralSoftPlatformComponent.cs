using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class ProceduralSoftPlatformComponent : GraphicComponent {
		[Serialize("endPos"         )] public Vec3d endPos;
		[Serialize("useBeginTexture")] public bool useBeginTexture;
		[Serialize("useEndTexture"  )] public bool useEndTexture;
		[Serialize("initIteration"  )] public bool initIteration;
		[Serialize("lianaOnTrigger" )] public bool lianaOnTrigger;
		[Serialize("flipTexture"    )] public bool flipTexture;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(endPos));
					SerializeField(s, nameof(useBeginTexture));
					SerializeField(s, nameof(useEndTexture));
					SerializeField(s, nameof(initIteration));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(endPos));
					SerializeField(s, nameof(useBeginTexture));
					SerializeField(s, nameof(useEndTexture));
					SerializeField(s, nameof(initIteration));
					SerializeField(s, nameof(lianaOnTrigger));
					SerializeField(s, nameof(flipTexture));
				}
			}
		}
		public override uint? ClassCRC => 0x9986E181;
	}
}

