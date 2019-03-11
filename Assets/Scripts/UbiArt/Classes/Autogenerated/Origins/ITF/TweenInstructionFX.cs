using UnityEngine;

namespace UbiArt.ITF {
	public partial class TweenInstructionFX : CSerializable {
		[Serialize("name"  )] public StringID name;
		[Serialize("target")] public ObjectPath target;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(target));
		}
		public override uint? ClassCRC => 0xCF6AFA8B;
	}
}

