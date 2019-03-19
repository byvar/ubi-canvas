using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class CupInfos : CSerializable {
		[Serialize("actorPath"  )] public Path actorPath;
		[Serialize("actorPath3D")] public Path actorPath3D;
		[Serialize("name"       )] public SmartLocId name;
		[Serialize("color"      )] public Color color;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(actorPath));
			SerializeField(s, nameof(actorPath3D));
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(color));
		}
	}
}

