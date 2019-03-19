using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_BossMorayBodyPart_Template : BodyPart_Template {
		[Serialize("buboPath"                )] public Path buboPath;
		[Serialize("buboAttachBones"         )] public CArray<StringID> buboAttachBones;
		[Serialize("missilePath"             )] public Path missilePath;
		[Serialize("missileBone"             )] public StringID missileBone;
		[Serialize("closeRangeAttackDistance")] public float closeRangeAttackDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(buboPath));
			SerializeField(s, nameof(buboAttachBones));
			SerializeField(s, nameof(missilePath));
			SerializeField(s, nameof(missileBone));
			SerializeField(s, nameof(closeRangeAttackDistance));
		}
		public override uint? ClassCRC => 0xFFE973DA;
	}
}

