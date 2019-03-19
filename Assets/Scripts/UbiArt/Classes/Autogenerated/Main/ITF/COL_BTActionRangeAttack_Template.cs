using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BTActionRangeAttack_Template : CSerializable {
		[Serialize("name"                  )] public StringID name;
		[Serialize("animAttack"            )] public StringID animAttack;
		[Serialize("targetBoneID"          )] public StringID targetBoneID;
		[Serialize("projectileAnchorBoneID")] public StringID projectileAnchorBoneID;
		[Serialize("projectileActorPath"   )] public Path projectileActorPath;
		[Serialize("detectionShape"        )] public Placeholder detectionShape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(animAttack));
			SerializeField(s, nameof(targetBoneID));
			SerializeField(s, nameof(projectileAnchorBoneID));
			SerializeField(s, nameof(projectileActorPath));
			SerializeField(s, nameof(detectionShape));
		}
		public override uint? ClassCRC => 0x25554ED4;
	}
}

