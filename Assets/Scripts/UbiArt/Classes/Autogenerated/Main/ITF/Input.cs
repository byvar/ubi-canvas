using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH)]
	public partial class Input : CSerializable {
		[Serialize("name"   )] public StringID name;
		[Serialize("varType")] public InputType varType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(varType));
		}
		public enum InputType {
			[Serialize("InputType_F32")] F32 = 0,
			[Serialize("InputType_U32")] U32 = 1,
		}
	}
}

