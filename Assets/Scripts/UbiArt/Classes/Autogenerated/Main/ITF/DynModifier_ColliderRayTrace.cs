using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class DynModifier_ColliderRayTrace : AbstractDynModifier {
		[Serialize("OffSet"       )] public Vec2d OffSet;
		[Serialize("Size"         )] public float Size;
		[Serialize("CollisionMask")] public ECOLLISIONFILTER CollisionMask;
		[Serialize("IgnoreGMat"   )] public CList<StringID> IgnoreGMat;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(OffSet));
			SerializeField(s, nameof(Size));
			SerializeField(s, nameof(CollisionMask));
			SerializeField(s, nameof(IgnoreGMat));
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

