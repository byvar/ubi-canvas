using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_EventTriggerChangePage : Event {
		[Serialize("enterPoint"     )] public Vector3 enterPoint;
		[Serialize("exitPoint"      )] public Vector3 exitPoint;
		[Serialize("finalPoint"     )] public Vector3 finalPoint;
		[Serialize("verticalEject"  )] public bool verticalEject;
		[Serialize("destinationPage")] public uint destinationPage;
		[Serialize("playerDuration" )] public float playerDuration;
		[Serialize("useFade"        )] public bool useFade;
		[Serialize("isCageDoor"     )] public bool isCageDoor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(enterPoint));
			SerializeField(s, nameof(exitPoint));
			SerializeField(s, nameof(finalPoint));
			SerializeField(s, nameof(verticalEject));
			SerializeField(s, nameof(destinationPage));
			SerializeField(s, nameof(playerDuration));
			SerializeField(s, nameof(useFade));
			SerializeField(s, nameof(isCageDoor));
		}
		public override uint? ClassCRC => 0xD0CE9111;
	}
}

