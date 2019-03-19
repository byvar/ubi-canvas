using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BossOceanBodyPart_Template : RO2_SnakeBodyPartActor_Template {
		[Serialize("buboPath"                )] public Path buboPath;
		[Serialize("missilePath"             )] public Path missilePath;
		[Serialize("missileBone"             )] public StringID missileBone;
		[Serialize("closeRangeAttackDistance")] public float closeRangeAttackDistance;
		[Serialize("buboAttachBones"         )] public Placeholder buboAttachBones;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(buboPath));
				SerializeField(s, nameof(buboAttachBones));
				SerializeField(s, nameof(missilePath));
				SerializeField(s, nameof(missileBone));
				SerializeField(s, nameof(closeRangeAttackDistance));
			} else {
				SerializeField(s, nameof(buboPath));
				SerializeField(s, nameof(missilePath));
				SerializeField(s, nameof(missileBone));
				SerializeField(s, nameof(closeRangeAttackDistance));
			}
		}
		public override uint? ClassCRC => 0x1167622B;
	}
}

