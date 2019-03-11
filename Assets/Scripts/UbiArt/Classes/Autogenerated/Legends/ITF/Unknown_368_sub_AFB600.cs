using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_368_sub_AFB600 : CSerializable {
		[Serialize("locID"          )] public LocalisationId locID;
		[Serialize("textPath"       )] public Path textPath;
		[Serialize("screenPos"      )] public Vector2 screenPos;
		[Serialize("displayDuration")] public float displayDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(locID));
			SerializeField(s, nameof(textPath));
			SerializeField(s, nameof(screenPos));
			SerializeField(s, nameof(displayDuration));
		}
		public override uint? ClassCRC => 0xBD34A8A0;
	}
}

