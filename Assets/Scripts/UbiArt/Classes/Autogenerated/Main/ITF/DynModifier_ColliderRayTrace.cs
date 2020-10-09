using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class DynModifier_ColliderRayTrace : AbstractDynModifier {
		public Vec2d OffSet;
		public float Size;
		public ECOLLISIONFILTER CollisionMask;
		public CListO<StringID> IgnoreGMat;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			OffSet = s.SerializeObject<Vec2d>(OffSet, name: "OffSet");
			Size = s.Serialize<float>(Size, name: "Size");
			CollisionMask = s.Serialize<ECOLLISIONFILTER>(CollisionMask, name: "CollisionMask");
			IgnoreGMat = s.SerializeObject<CListO<StringID>>(IgnoreGMat, name: "IgnoreGMat");
		}
		public enum ECOLLISIONFILTER {
			[Serialize("ECOLLISIONFILTER_NONE"       )] NONE = 0,
			[Serialize("ECOLLISIONFILTER_ALL"        )] ALL = 1038,
			[Serialize("ECOLLISIONFILTER_CHARACTERS" )] CHARACTERS = 4,
			[Serialize("ECOLLISIONFILTER_ENVIRONMENT")] ENVIRONMENT = 2,
			[Serialize("ECOLLISIONFILTER_ITEMS"      )] ITEMS = 8,
		}
		public override uint? ClassCRC => 0x74CFDCC0;
	}
}

