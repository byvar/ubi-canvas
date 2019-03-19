using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Ray_ShooterActorParameter_StackData : CSerializable {
		[Serialize("Path__0"    )] public Path Path__0;
		[Serialize("uint__1"    )] public uint uint__1;
		[Serialize("uint__2"    )] public uint uint__2;
		[Serialize("uint__3"    )] public uint uint__3;
		[Serialize("int__4"     )] public int int__4;
		[Serialize("int__5"     )] public int int__5;
		[Serialize("StringID__6")] public StringID StringID__6;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Path__0));
			SerializeField(s, nameof(uint__1));
			SerializeField(s, nameof(uint__2));
			SerializeField(s, nameof(uint__3));
			SerializeField(s, nameof(int__4));
			SerializeField(s, nameof(int__5));
			SerializeField(s, nameof(StringID__6));
		}
	}
}

