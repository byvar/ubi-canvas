using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class AnimPathAABB : CSerializable {
		[Serialize("name")] public StringID name;
		[Serialize("path")] public Path path;
		[Serialize("aabb")] public AABB aabb;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(path));
			SerializeField(s, nameof(aabb));
		}
	}
}

