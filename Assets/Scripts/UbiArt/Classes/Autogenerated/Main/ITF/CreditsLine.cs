using UnityEngine;

namespace UbiArt.ITF {
	public partial class CreditsLine : CSerializable {
		[Serialize("type"     )] public uint type;
		[Serialize("flag"     )] public uint flag;
		[Serialize("text"     )] public string text;
		[Serialize("firstName")] public string firstName;
		[Serialize("lastName" )] public string lastName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(type));
			SerializeField(s, nameof(flag));
			SerializeField(s, nameof(text));
			SerializeField(s, nameof(firstName));
			SerializeField(s, nameof(lastName));
		}
	}
}

