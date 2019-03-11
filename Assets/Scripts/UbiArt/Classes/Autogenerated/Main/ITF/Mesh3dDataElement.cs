using UnityEngine;

namespace UbiArt.ITF {
	public partial class Mesh3dDataElement : CSerializable {
		[Serialize("path"        )] public Path path;
		[Serialize("dummyPath"   )] public Path dummyPath;
		[Serialize("textureIndex")] public uint textureIndex;
		[Serialize("family"      )] public StringID family;
		[Serialize("familyIndex" )] public int familyIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(path));
			SerializeField(s, nameof(dummyPath));
			SerializeField(s, nameof(textureIndex));
			SerializeField(s, nameof(family));
			SerializeField(s, nameof(familyIndex));
		}
	}
}

