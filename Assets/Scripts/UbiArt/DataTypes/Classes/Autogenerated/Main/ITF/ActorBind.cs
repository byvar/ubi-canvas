using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class ActorBind : CSerializable {
		public ObjectPath parentPath;
		public Vec3d offsetPos;
		public float offsetAngle;
		public Type type;
		public uint typeData;
		public bool useParentFlip;
		public bool useParentScale;
		public bool removeWithParent;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags_x30 | SerializeFlags.Flags_xC0)) {
				parentPath = s.SerializeObject<ObjectPath>(parentPath, name: "parentPath");
				offsetPos = s.SerializeObject<Vec3d>(offsetPos, name: "offsetPos");
				offsetAngle = s.Serialize<float>(offsetAngle, name: "offsetAngle");
				type = s.Serialize<Type>(type, name: "type");
				typeData = s.Serialize<uint>(typeData, name: "typeData");
			}
			if(s.HasFlags((SerializeFlags.Flags_x30 | SerializeFlags.Flags_xC0 | SerializeFlags.Editor))) {
				useParentFlip = s.Serialize<bool>(useParentFlip, name: "useParentFlip");
				useParentScale = s.Serialize<bool>(useParentScale, name: "useParentScale");
				removeWithParent = s.Serialize<bool>(removeWithParent, name: "removeWithParent");
			}
		}
		public enum Type {
			[Serialize("Root"     )] Root = 0,
			[Serialize("BoneIndex")] BoneIndex = 1,
			[Serialize("BoneName" )] BoneName = 2,
		}
	}
}

