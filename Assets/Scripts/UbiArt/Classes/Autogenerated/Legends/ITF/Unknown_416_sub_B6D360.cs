using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_416_sub_B6D360 : CSerializable {
		[Serialize("lockWithTeensy")] public bool lockWithTeensy;
		[Serialize("detectRange"   )] public float detectRange;
		[Serialize("worldTag"      )] public StringID worldTag;
		[Serialize("LockType"      )] public Enum_LockType LockType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(lockWithTeensy));
				SerializeField(s, nameof(detectRange));
				SerializeField(s, nameof(worldTag));
				SerializeField(s, nameof(LockType));
			}
		}
		public enum Enum_LockType {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0x6DED949C;
	}
}

