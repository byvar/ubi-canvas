using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_130_sub_73CC00 : CSerializable {
		[Serialize("costumeTransitionTime")] public float costumeTransitionTime;
		[Serialize("messageInfos"         )] public Placeholder messageInfos;
		[Serialize("unlockMessageButtons" )] public Placeholder unlockMessageButtons;
		[Serialize("newContentPath"       )] public Path newContentPath;
		[Serialize("rumble_name"          )] public StringID rumble_name;
		[Serialize("rumble_cycleDelay"    )] public float rumble_cycleDelay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(costumeTransitionTime));
			SerializeField(s, nameof(messageInfos));
			SerializeField(s, nameof(unlockMessageButtons));
			SerializeField(s, nameof(newContentPath));
			SerializeField(s, nameof(rumble_name));
			SerializeField(s, nameof(rumble_cycleDelay));
		}
		public override uint? ClassCRC => 0x7F8B4E1C;
	}
}

