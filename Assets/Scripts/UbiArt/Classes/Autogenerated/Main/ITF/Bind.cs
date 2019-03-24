using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class Bind : CSerializable {
		[Serialize("parentPath"      )] public ObjectPath parentPath;
		[Serialize("offsetPos"       )] public Vector3 offsetPos;
		[Serialize("offsetAngle"     )] public float offsetAngle;
		[Serialize("type"            )] public Type type;
		[Serialize("typeData"        )] public uint typeData;
		[Serialize("useParentFlip"   )] public bool useParentFlip;
		[Serialize("useParentScale"  )] public bool useParentScale;
		[Serialize("useParentAlpha"  )] public bool useParentAlpha;
		[Serialize("removeWithParent")] public bool removeWithParent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags_x30 | SerializeFlags.Flags_xC0)) {
				SerializeField(s, nameof(parentPath));
				SerializeField(s, nameof(offsetPos));
				SerializeField(s, nameof(offsetAngle));
				SerializeField(s, nameof(type));
				SerializeField(s, nameof(typeData));
				if (s.HasFlags(SerializeFlags.Editor)) {
					SerializeField(s, nameof(useParentFlip));
					SerializeField(s, nameof(useParentScale));
					SerializeField(s, nameof(useParentAlpha));
					SerializeField(s, nameof(removeWithParent));
				}
			}
		}
		public enum Type {
			[Serialize("Root"              )] Root = 0,
			[Serialize("BoneName"          )] BoneName = 1,
			[Serialize("ProceduralBoneName")] ProceduralBoneName = 2,
		}
	}
}

