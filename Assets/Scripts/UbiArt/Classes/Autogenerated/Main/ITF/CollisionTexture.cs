using UnityEngine;

namespace UbiArt.ITF {
	public partial class CollisionTexture : CSerializable {
		[Serialize("build"       )] public uint build;
		[Serialize("offset"      )] public float offset;
		[Serialize("cornerIn"    )] public Vector2 cornerIn;
		[Serialize("cornerOut"   )] public Vector2 cornerOut;
		[Serialize("cornerInCur" )] public bool cornerInCur;
		[Serialize("cornerOutCur")] public bool cornerOutCur;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(build));
			SerializeField(s, nameof(offset));
			SerializeField(s, nameof(cornerIn));
			SerializeField(s, nameof(cornerOut));
			if (s.HasFlags(SerializeFlags.Flags10)) {
				SerializeField(s, nameof(cornerInCur));
				SerializeField(s, nameof(cornerOutCur));
			}
		}
	}
}

