using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BTActionRangeAttack_Template : CSerializable {
		public StringID name;
		public StringID animAttack;
		public StringID targetBoneID;
		public StringID projectileAnchorBoneID;
		public Path projectileActorPath;
		public Placeholder detectionShape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.SerializeObject<StringID>(name, name: "name");
			animAttack = s.SerializeObject<StringID>(animAttack, name: "animAttack");
			targetBoneID = s.SerializeObject<StringID>(targetBoneID, name: "targetBoneID");
			projectileAnchorBoneID = s.SerializeObject<StringID>(projectileAnchorBoneID, name: "projectileAnchorBoneID");
			projectileActorPath = s.SerializeObject<Path>(projectileActorPath, name: "projectileActorPath");
			detectionShape = s.SerializeObject<Placeholder>(detectionShape, name: "detectionShape");
		}
		public override uint? ClassCRC => 0x7C29B7AC;
	}
}

